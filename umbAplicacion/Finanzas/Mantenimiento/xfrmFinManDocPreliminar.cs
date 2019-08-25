using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Finanzas;
using umbNegocio.Seguridad;
using Umbrella;
using umbNegocio.Granja;

namespace umbAplicacion.Finanzas.Mantenimiento
{
    public partial class xfrmFinManDocPreliminar : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private List<clsFinDocPreliminarDet> objDetalle;

        public xfrmFinManDocPreliminar()
        {
            InitializeComponent();
        }
        public xfrmFinManDocPreliminar(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
       }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Documentos preliminares";
                switch (varOpeCodigo) {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text);
                        varDocNombre = this.txtNomSerie.Text;
                        //Iniciamos los campos con valores predefinidos
                        this.datFecha.DateTime = DateTime.Now;
                        this.txtNumero.Text = "0";
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                        foreach (clsFinDocPreliminarCab csRegistro in clsFinDocPreliminarCab.funListar(string.Format("Where a.CabCodigo = {0}",varRegCodigo))) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.Text = csRegistro.DocCodigo.ToString();
                            this.txtNomSerie.Text = csRegistro.DocNombre.ToString();
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.txtComentario.Text =  csRegistro.CabComentario;
                            this.txtReferencia1.EditValue = csRegistro.CabReferencia1;
                            this.txtReferencia2.Text = csRegistro.CabReferencia2;
                            this.butExaminar.EditValue = csRegistro.CabRuta;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsFinDocPreliminarDet>();
                            clsFinDocPreliminarDet.proListar(varRegCodigo, out objDetalle);
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
                //Eliminamos las filas vacias del detalle de documentos preliminares
                objDetalle.RemoveAll(p => p.CueCodigo.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;

                var csRegistro = new clsFinDocPreliminarCab() {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),

                    CabFecha = (DateTime)this.datFecha.EditValue,
                    
                    DocNombre = this.txtNomSerie.Text,
                    CabComentario = this.txtComentario.Text,
                    CabReferencia1 = this.txtReferencia1.Text,
                    CabReferencia2 = this.txtReferencia2.Text,
                    CabRuta = this.butExaminar.Text,
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalle);
                switch (varOpeCodigo)
                {
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                this.Close();
            }
            catch (Exception ex) { 
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.objDetalle = new List<clsFinDocPreliminarDet>();
                string varPath = this.butExaminar.Text.Trim();
                if (!varPath.Equals(""))
                {
                    using (OleDbConnection varConexion = new OleDbConnection() { ConnectionString = (String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=\"Excel 12.0;HDR=YES\"", varPath)) })
                    {
                        varConexion.Open();
                        OleDbCommand varComando = new OleDbCommand("Select Nro, CtaContable, Descripcion, Debe, Haber, CodCcosto, CentroCosto, Comentario, Referencia1, Referencia2 From [DOCPRELIMINAR$]", varConexion);
                        OleDbDataAdapter varAdaptador = new OleDbDataAdapter(varComando);
                        DataSet dsExcel = new DataSet();
                        DataTable dtAsiento = new DataTable();
                        varAdaptador.Fill(dsExcel);
                        dtAsiento = dsExcel.Tables[0];
                        foreach (DataRow drAsiento in dtAsiento.Rows) {
                            //Recuperamos la informacion de la cuenta contable
                            clsFinPlaCuenta varCtaContableSAP = clsFinPlaCuenta.funListar(drAsiento["CtaContable"].ToString()).Count.Equals(0) ? null : clsFinPlaCuenta.funListar(drAsiento["CtaContable"].ToString())[0];
                            //Recuperamos informacion del centro de costo
                            clsFinCenCosto varCenCostoSAP = null;
                            if (drAsiento["CodCcosto"].ToString().Trim() != "")
                                varCenCostoSAP = clsFinCenCosto.funListar(drAsiento["CodCcosto"].ToString()).Count.Equals(0) ? null : clsFinCenCosto.funListar(drAsiento["CodCcosto"].ToString())[0];
                            //Instanciamos una fila del detalle de la clase clsFinDocPreliminarDet
                            clsFinDocPreliminarDet objFilaDetalle = new clsFinDocPreliminarDet(){
                                DetSecuencia = int.Parse(drAsiento["Nro"].ToString()), //Secuencia
                                CueCodigo = varCtaContableSAP == null ? drAsiento["CtaContable"].ToString() : varCtaContableSAP.CueCodigo, //Codigo cuenta contable
                                CueNombre = varCtaContableSAP == null ? "" : varCtaContableSAP.CueNombre, //Nombre cuenta contable
                                CueFormato = varCtaContableSAP == null ? "" : varCtaContableSAP.CueFormato, //Formato cuenta contable
                                CcoCodigo = varCenCostoSAP == null ? drAsiento["CodCcosto"].ToString() : drAsiento["CodCcosto"].ToString(), //Codigo centro de costo
                                CcoNombre = varCenCostoSAP == null || drAsiento["CodCcosto"].ToString().Trim().Equals("") ? "" : varCenCostoSAP.CcoNombre.ToUpper(), //Nombre del centro de costo
                                DetComentario = drAsiento["Comentario"].ToString().Trim(), //Comentario
                                DetReferencia1 = drAsiento["Referencia1"].ToString().Trim(), //Referencia1
                                DetReferencia2 = drAsiento["Referencia2"].ToString().Trim(), //Referencia2
                                DetDebe = drAsiento["Debe"] == System.DBNull.Value ? 0 : drAsiento["Debe"].ToString().Trim() == "-" ? 0 : decimal.Parse(drAsiento["Debe"].ToString()),
                                DetHaber = drAsiento["Haber"] == System.DBNull.Value ? 0 : drAsiento["Haber"].ToString().Trim() == "-" ? 0 : decimal.Parse(drAsiento["Haber"].ToString())
                            };
                           
                            //Validamos que la informacion de la fila sea la correcta
                            string varMensaje = objFilaDetalle.funValidarFila();
                            if (!varMensaje.Equals("")) { XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}
                            objDetalle.Add(objFilaDetalle);
                        }
                        this.grcListado.DataSource = objDetalle;
                        XtraMessageBox.Show("Informacion extraida con exito!!!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { XtraMessageBox.Show("Debe escoger el archivo para poder extraer la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExtraerDepreciacion_Click(object sender, EventArgs e)
        {
            try {
                //Debemos instanciar la clase a la grilla para el ingreso de detalles
                this.objDetalle = new List<clsFinDocPreliminarDet>();
                DataTable dtAsiento = clsGraDepAcumulada.funRecDiarioDepreciacion((DateTime)datFecha.EditValue);
                int i = 0;
                foreach (DataRow drAsiento in dtAsiento.Rows) {
                    //Recuperamos la informacion de la cuenta contable
                    clsFinPlaCuenta varCtaContableSAP = clsFinPlaCuenta.funListar(drAsiento["CtaFormato"].ToString())[0];
                    //Recuperamos informacion del centro de costo
                    clsFinCenCosto varCenCostoSAP = null;
                    if (drAsiento["CcoCodigo"].ToString().Trim() != "")
                        varCenCostoSAP = clsFinCenCosto.funListar(drAsiento["CcoCodigo"].ToString())[0];
                    //Instanciamos una fila del detalle de la clase clsFinDocPreliminarDet
                    clsFinDocPreliminarDet objFilaDetalle = new clsFinDocPreliminarDet() {
                        DetSecuencia = ++i, //Secuencia
                        CueCodigo = varCtaContableSAP.CueCodigo, //Codigo cuenta contable
                        CueNombre = varCtaContableSAP.CueNombre, //Nombre cuenta contable
                        CueFormato = varCtaContableSAP.CueFormato, //Formato cuenta contable
                        CcoCodigo = drAsiento["CcoCodigo"].ToString(), //Codigo centro de costo
                        CcoNombre = drAsiento["CcoCodigo"].ToString().Trim().Equals("") ? "" : varCenCostoSAP.CcoNombre.ToUpper(), //Nombre del centro de costo
                        DetComentario = drAsiento["Chapeta"].ToString().Trim(), //Comentario
                        DetReferencia1 = "", //Referencia1
                        DetReferencia2 ="", //Referencia2
                        DetDebe = drAsiento["DacDebe"] == System.DBNull.Value ? 0 : drAsiento["DacDebe"].ToString().Trim() == "-" ? 0 : decimal.Parse(drAsiento["DacDebe"].ToString()),
                        DetHaber = drAsiento["DacHaber"] == System.DBNull.Value ? 0 : drAsiento["DacHaber"].ToString().Trim() == "-" ? 0 : decimal.Parse(drAsiento["DacHaber"].ToString())
                    };
                    //Validamos que la informacion de la fila sea la correcta
                    string varMensaje = objFilaDetalle.funValidarFila();
                    if (!varMensaje.Equals("")) { XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    objDetalle.Add(objFilaDetalle);
                }
                this.grcListado.DataSource = objDetalle;
                XtraMessageBox.Show("Informacion extraida con exito!!!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


    }
}
