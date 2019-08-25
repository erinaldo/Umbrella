using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Umbrella;
using umbNegocio.Seguridad;
using umbNegocio;
using umbAplicacion.Finanzas.Listado;
using umbNegocio.Finanzas;
using umbNegocio.GestionBancos;

namespace umbAplicacion.GestionBancos.Mantenimiento
{
    public partial class xfrmGbaManExtBancario : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        List<clsGbaExtBancarioDet> objDetalle;

        public xfrmGbaManExtBancario()
        {
            InitializeComponent();
        }
        public xfrmGbaManExtBancario(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try {
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
       }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Extractos bancarios";
                
                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNomSerie.Text;
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.DateTime = DateTime.Now;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        foreach (clsGbaExtBancarioCab csRegistro in clsGbaExtBancarioCab.funListar(varRegCodigo)) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.Text = csRegistro.DocCodigo.ToString();
                            this.txtNomSerie.Text = csRegistro.DocNombre.ToString();
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.bedCueContable.Text = csRegistro.CueFormato;
                            this.txtCueCodigo.Text = csRegistro.CueCodigo;
                            this.txtNombre.Text = csRegistro.CueNombre;
                            this.txtDescripcion.Text = csRegistro.CabDescripcion;
                            this.butExaminar.Text = csRegistro.CabRuta;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsGbaExtBancarioDet>();
                            clsGbaExtBancarioDet.proListar(varRegCodigo, out objDetalle);
                            this.grcListado.DataSource = objDetalle;
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        break;
                    default:
                        break;
                }
                //Verificamos los acceso del usuario al formulario\
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try {
                //Eliminamos las filas vacias del detalle de extractos bancarios
                objDetalle.RemoveAll(p => p.DetComentario.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;

                var csRegistro = new clsGbaExtBancarioCab() {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),

                    CabFecha = (DateTime)this.datFecha.EditValue,

                    DocNombre = this.txtNomSerie.Text,
                    CabDescripcion = this.txtDescripcion.Text,
                    CabRuta = this.butExaminar.Text,
                    CueCodigo = this.txtCueCodigo.Text,
                    CueNombre = this.txtNombre.Text,
                    CueFormato = this.bedCueContable.Text,
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalle);
                switch (varOpeCodigo){
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void butExaminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                this.openFileDialog.FileName = "";
                this.openFileDialog.Filter = "Microsoft Excel|*.xls;*.xlsx";
                this.openFileDialog.FilterIndex = 2;
                this.openFileDialog.RestoreDirectory = true;

                if (this.openFileDialog.ShowDialog() == DialogResult.OK) this.butExaminar.Text = this.openFileDialog.FileName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                //Debemos instanciar la clase a la grilla para el ingreso de detalles
                this.objDetalle = new List<clsGbaExtBancarioDet>();
                string varPath = this.butExaminar.Text.Trim();
                if (!varPath.Equals(""))
                {
                    using (OleDbConnection varConexion = new OleDbConnection() { ConnectionString = (String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=\"Excel 12.0;HDR=YES\"", varPath)) })
                    {
                        varConexion.Open();
                        OleDbCommand varComando = new OleDbCommand("Select Nro, Fecha, Referencia, Comentario, Debe, Haber From [EXTBANCARIO$]", varConexion);
                        OleDbDataAdapter varAdaptador = new OleDbDataAdapter(varComando);
                        DataSet dsExcel = new DataSet();
                        DataTable dtExtracto = new DataTable();
                        varAdaptador.Fill(dsExcel);
                        dtExtracto = dsExcel.Tables[0];
                        int i = 0;
                        //Recorremos la informacion recuperada del excel
                        foreach (DataRow drExtracto in dtExtracto.Rows) {
                              //Instanciamos una fila del detalle de la clase clsFinDocPreliminarDet
                            clsGbaExtBancarioDet objFilaDetalle = new clsGbaExtBancarioDet(){
                                DetSecuencia = ++i, //Secuencia
                                DetFecha = Convert.ToDateTime(string.Format("{0}/{1}/{2}", drExtracto["Fecha"].ToString().Substring(0, 4), drExtracto["Fecha"].ToString().Substring(4, 2), drExtracto["Fecha"].ToString().Substring(6, 2))), //Fecha
                                DetReferencia = drExtracto["Referencia"].ToString().Trim(), //Referencia
                                DetComentario = drExtracto["Comentario"].ToString().Trim(), //Comentario
                                DetDebe = drExtracto["Debe"] == System.DBNull.Value ? 0 : drExtracto["Debe"].ToString().Trim() == "-" ? 0 : decimal.Parse(drExtracto["Debe"].ToString()), //Debe
                                DetHaber = drExtracto["Haber"] == System.DBNull.Value ? 0 : drExtracto["Haber"].ToString().Trim() == "-" ? 0 : decimal.Parse(drExtracto["Haber"].ToString()) //Haber
                            };
                            //Validamos que la informacion de la fila sea la correcta
                            string varMensaje = objFilaDetalle.funValidarFila();
                            if (!varMensaje.Equals("")) { XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            objDetalle.Add(objFilaDetalle);       
                        }
                        this.grcListado.DataSource = objDetalle;
                        this.grcListado.RefreshDataSource();
                        XtraMessageBox.Show("Informacion extraida con exito!!!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { XtraMessageBox.Show("Debe escoger el archivo para poder extraer la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCueContable_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varCueFormato = this.bedCueContable.Text.Trim();

                if (varCueFormato.Length < 14) { this.txtNombre.Text = ""; this.txtCueCodigo.Text = ""; return; }

                this.txtNombre.Text = "";
                this.txtCueCodigo.Text = "";
                foreach (clsFinPlaCuenta csRegistro in clsFinPlaCuenta.funListar(varCueFormato)) {
                    this.txtNombre.Text = csRegistro.CueNombre;
                    this.txtCueCodigo.Text = csRegistro.CueCodigo;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCueContable_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmFinLisPlaCuenta frmFormulario = new xfrmFinLisPlaCuenta(true)) {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0) this.bedCueContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueFormato;
                    else bedCueContable.Text = "";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
