using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio.Granja;
using umbNegocio.Inventario;
using Umbrella;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using umbAplicacion.Inventario.Listado;
using umbNegocio;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManLaboratorio : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string varOldIteCodigo = "";

        private List<clsGraLaboratorioDet> objDetalle;

        public xfrmGraManLaboratorio()
        {
            InitializeComponent();
        }
        public xfrmGraManLaboratorio(int varFormulario, int varOperacion, int varRegistro)
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
                this.Text = "Registro de laboratorio";
                //Recuperamos de la base de datos la informacion que va hacer utilizada en el formulario
                this.gluItem.DataSource = clsInvItem.funListar();
                this.gluAnimal.Properties.DataSource = clsGraAnimal.funRecAnimalesMachos();
                this.lueBodega.Properties.DataSource = clsDiccionario.Listar("GRALABBODEGA");
                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNomSerie.Text;
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.lueBodega.ItemIndex = 0;
                        //Debemos instanciar la clase a la grilla para el ingreso de detalles
                        this.objDetalle = new List<clsGraLaboratorioDet>();
                        this.objDetalle.Add(new clsGraLaboratorioDet(0));
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsGraLaboratorioCab csRegistro in clsGraLaboratorioCab.funListar(varRegCodigo)) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.txtNomSerie.Text = csRegistro.DocNombre;
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.txtSAPSalida.Text = csRegistro.CabNumeroSAPSalida.ToString();
                            this.txtSAPEntrada.Text = csRegistro.CabNumeroSAPEntrada.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.gluAnimal.EditValue = csRegistro.AnmCodigo;
                            this.gluAnimal.Text = csRegistro.AnmAlternativo;
                            this.bedItem.Text = csRegistro.IteCodigo;
                            this.txtLote.Text = csRegistro.CabLote;
                            this.txtDosis.EditValue = csRegistro.CabDosis;
                            this.txtCstInicial.EditValue = csRegistro.CabCstInicial;
                            this.lueBodega.EditValue = csRegistro.BodCodigo.ToString();
                            this.memObsDocumento.Text = csRegistro.CabComentario;
                            this.memObsDiario.Text = csRegistro.CabComenDiario;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsGraLaboratorioDet>();
                            clsGraLaboratorioDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia 
                            int varSecuencia = objDetalle.Max(p => p.DetSecuencia);
                            this.objDetalle.Add(new clsGraLaboratorioDet(varSecuencia));
                            this.grcListado.DataSource = objDetalle;
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try {
                //Eliminamos las filas vacias del detalle
                objDetalle.RemoveAll(p => p.IteCodigo.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Validamos que todos los datos se han llenado correctamente en el detalle
                string varMensaje = clsGraLaboratorioDet.funValidarDetalle(objDetalle);
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                //Verificamos si existe un error
                if (!varMensaje.Equals("")) throw new Exception(varMensaje);
                //Asignamos los valores de la propiedades de la clase animal
                var csRegistro = new clsGraLaboratorioCab()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    AnmCodigo = this.gluAnimal.EditValue.Equals("") ? 0 : int.Parse(this.gluAnimal.EditValue.ToString()),
                    CabDosis = this.txtDosis.Text.Equals("") ? 0 : int.Parse(this.txtDosis.Text),

                    CabFecha = (DateTime)datFecha.EditValue,

                    AnmAlternativo = this.gluAnimal.Text,
                    IteCodigo = this.bedItem.Text,
                    IteNombre = this.txtIteNombre.Text,
                    CabLote = this.txtLote.Text,
                    BodCodigo = this.lueBodega.EditValue.ToString(),
                    CabComentario = this.memObsDocumento.Text,
                    CabComenDiario = this.memObsDiario.Text,
                    CabCstInicial = decimal.Parse(this.txtCstInicial.Text)
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalle);
                //Si no hay ningun error procedemos a mostrar el mensaje respectivo
                switch (varOpeCodigo)
                {
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con la nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }   
        }
        private void xfrmGraManLaboratorio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    if (!grvListado.IsFocusedView) return;
                    GridColumn varColumna = this.grvListado.FocusedColumn;
                    this.grvListado.FocusedColumn = colDetSecuencia;
                    this.grvListado.FocusedColumn = varColumna;

                    if (this.grvListado.FocusedColumn == null) return;
                    if (!this.grvListado.FocusedColumn.Equals(colDetCantidad))
                        return;
                    //Limpiamos todos los errores del detalle de movimientos
                    this.grvListado.ClearColumnErrors();
                    //Recuperamos la fila seleccionada e instanciamos con la clase detalle de inventario
                    clsGraLaboratorioDet objFila = (clsGraLaboratorioDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                    //Validamos que los campos ha sido debidamente ingresados
                    string varMensaje = objFila.funValidarFila();
                    if (!varMensaje.Equals("")) {
                        string varControl = varMensaje.Split(':')[0];
                        string varError = varMensaje.Split(':')[1].Trim();
                        this.grvListado.SetColumnError(this.grvListado.Columns[varControl], varError);
                        this.grvListado.FocusedColumn = this.grvListado.Columns[varControl];
                        return;
                    }
                    //Agregamos una nueva linea
                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1)){
                        int varPosicion = this.grvListado.FocusedRowHandle;
                        int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString());
                        this.objDetalle.Add(new clsGraLaboratorioDet(varLinea));
                        this.grcListado.RefreshDataSource();
                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        this.grvListado.FocusedColumn = colIteCodigo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluItem_Popup(object sender, EventArgs e)
        {
            //Limpiamos todos los filtros que existan en el control gluItem
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluItem_Leave(object sender, EventArgs e)
        {
            try
            {
                //Recuperamos en la variable el codigo del item digitado por el usuario
                string varIteCodigo = (sender as GridLookUpEdit).Text;
                //Verificamos que el usuario haya digitado el codigo
                if (varIteCodigo.Equals("")) return;
                //Verificamos que exista una modificacion en el codigo del item
                if (varIteCodigo == varOldIteCodigo) return;
                //Instanciamos el objeto Item
                List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);
                //Recuperamos en la variable la fila en la que se encuentra posicionado el usuario
                int varFila = this.grvListado.FocusedRowHandle;
                if (!lisItem.Equals(null))
                {
                    //Asignamos los valores recuperados a la fila
                    this.grvListado.SetRowCellValue(varFila, colIteCodigo, lisItem[0].ItemCode);
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, lisItem[0].ItemName);
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, lisItem[0].InvntryUom);
                    this.grvListado.SetRowCellValue(varFila, colIteTieLote, lisItem[0].ManBtchNum);
                    this.grvListado.SetRowCellValue(varFila, colItePsoStd, lisItem[0].SWeight1);
                    this.grvListado.SetRowCellValue(varFila, colDetCantidad, 1);
                    this.grvListado.SetRowCellValue(varFila, colCosto, lisItem[0].AvgPrice);
                    this.grvListado.SetRowCellValue(varFila, colValor, lisItem[0].AvgPrice);
                }
                else
                {
                    //En caso de no existir coincidencias enceramos los datos de la fila
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, "");
                    this.grvListado.SetRowCellValue(varFila, colIteTieLote, "");
                    this.grvListado.SetRowCellValue(varFila, colItePsoStd, 0);
                    this.grvListado.SetRowCellValue(varFila, colDetCantidad, 0);
                    this.grvListado.SetRowCellValue(varFila, colCosto, 0);
                    this.grvListado.SetRowCellValue(varFila, colValor, 0);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para verificar si los datos han sido modificados antes de la edicion
        private void grvListado_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try {
                //Recuperamos los valores antiguos para cuando haya una modificacion
                if (this.grvListado.FocusedColumn.Equals(colIteCodigo))
                    varOldIteCodigo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colIteCodigo).ToString();
                //En caso de que el usuario este posicionado en la columna item abrir la opciones de items
                if (this.grvListado.FocusedColumn.Equals(colIteCodigo)) {
                    if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0){
                        this.colIteCodigo.OptionsColumn.ReadOnly = false;
                        this.gluItem.ImmediatePopup = true;
                    }
                    else
                        this.colIteCodigo.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluAnimal_Popup(object sender, EventArgs e)
        {
            //Limpiamos todos los filtros que existan en el control gluItem
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluAnimal_EditValueChanged(object sender, EventArgs e)
        {
            this.gluAnimal.Properties.ImmediatePopup = true;
        }
        private void gluAnimal_Leave(object sender, EventArgs e)
        {
            try {
                //Recuperamos en la variable el codigo de la chapeta 
                int varAnmCodigo = (sender as GridLookUpEdit).EditValue == null ? 0 : int.Parse((sender as GridLookUpEdit).EditValue.ToString());
                //Verificamos que el usuario haya digitado el codigo
                if (varAnmCodigo.Equals(0)) return;
                //Asignamos el valor del costo inicial para las dosis 
                object var = (sender as GridLookUpEdit).GetSelectedDataRow();
                if (var == null) return;
                decimal varValorDepreciacion = decimal.Parse(((System.Data.DataRowView)(var)).Row.ItemArray[3].ToString());
                decimal varValorAcumDepreciacion = decimal.Parse(((System.Data.DataRowView)(var)).Row.ItemArray[4].ToString());
                this.txtCstInicial.Text = varValorAcumDepreciacion >= varValorDepreciacion ? "0" : ((System.Data.DataRowView)(var)).Row.ItemArray[2].ToString();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// CAMC - 2016/10/14   Programación del campo que contendra el item de SAP del animal este item variara 
        ///                                      deacuerdo a si el animal esta en formacion o ya ha sido activado
        /// </summary>
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try {
                string varIteCodigo = this.bedItem.Text.Trim();

                this.txtIteNombre.Text = "";
                if (varIteCodigo.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)) {
                    this.bedItem.EditValue = csRegistro.ItemCode;
                    this.txtIteNombre.Text = csRegistro.ItemName;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtIteNombre.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
    }

}
