using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.General;
using umbNegocio.Granja;
using umbNegocio.Inventario;
using Umbrella;
using umbNegocio.Finanzas;
using System.Linq;
using umbNegocio.Seguridad;
using umbAplicacion.Granja.Mantenimiento;
using System.Data.OleDb;


namespace umbAplicacion.Inventario.Mantenimiento
{
    public partial class xfrmInvManMovimiento : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string varOldIteCodigo = "";
        private bool varReqChapetaLote = false;

        private List<clsInvMovimientoDet> objDetalle;
        
        
        //private clsCABMOVIMIENTO obj = new clsCABMOVIMIENTO();
        //private clsMOTIVO objMotivo = new clsMOTIVO();
        //private clsOWHS objOWHS = new clsOWHS();
        //private clsOIBT objBatch = new clsOIBT();
        //private clsANIMAL objA = new clsANIMAL();

        public xfrmInvManMovimiento()
        {
            InitializeComponent();
        }
        public xfrmInvManMovimiento(int varFormulario, int varOperacion, int varRegistro)
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
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Entrada/Salida de mercancias";

                //Recuperamos de la base de datos la informacion que va hacer utilizada en el formulario
                this.lueRazon.Properties.DataSource = clsDiccionario.Listar("INVOBJOVIMIENTO");
                this.iluTipoDestino.DataSource = clsDiccionario.Listar("INVTIPDESTINO");
                this.gluItem.DataSource = clsInvItem.funListar();
                this.iluMotPerdida.DataSource = clsGraMotPerdida.Listar();
                this.gluBatch.DataSource = clsGraAnimal.funRecAnimalesInventario();

                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNomSerie.Text;
                        //Verificamos si el documento es de entrada o de salida
                        this.txtTipoMovimiento.Text = varDocNombre.Substring(1, 1).Equals("E") ? "ENTRADA" : "SALIDA";
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.lueCenCosto.Enabled = false;
                        this.lueProyecto.Enabled = false;
                        lueMotivo.Properties.DataSource = clsInvMotivo.Listar(varDocNombre.Substring(1, 1).Equals("E") ? "ENTRADA" : "SALIDA");

                        //Debemos instanciar la clase a la grilla para el ingreso de detalles
                        this.objDetalle = new List<clsInvMovimientoDet>();
                        this.objDetalle.Add(new clsInvMovimientoDet(0)); 
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                         //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsInvMovimientoCab csRegistro in clsInvMovimientoCab.funListar(varRegCodigo)) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.txtNomSerie.Text = csRegistro.DocNombre;
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.txtSapNumero.Text = csRegistro.CabNumeroSAP.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.txtTipoMovimiento.Text = csRegistro.CabTipMovimiento;
                            this.lueMotivo.Properties.DataSource = clsInvMotivo.Listar(csRegistro.DocNombre.Substring(1, 1).Equals("E") ? "ENTRADA" : "SALIDA");
                            this.lueMotivo.EditValue = int.Parse(csRegistro.IdMotivo.ToString());
                            this.lueRazon.EditValue = csRegistro.CabRazon.ToString();
                            this.lueCenCosto.EditValue = csRegistro.CcoCodigo == "" ? null : csRegistro.CcoCodigo.ToString();
                            this.lueProyecto.EditValue = csRegistro.PryCodigo == "" ? null : csRegistro.PryCodigo.ToString();
                            this.lueBodega.EditValue = csRegistro.BodCodigo.ToString();
                            this.memObsDocumento.Text = csRegistro.CabComentario;
                            this.memObsDiario.Text = csRegistro.CabComenDiario;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsInvMovimientoDet>();
                            clsInvMovimientoDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia 
                            int varSecuencia = objDetalle.Max(p => p.DetSecuencia);
                            this.objDetalle.Add(new clsInvMovimientoDet(varSecuencia)); 
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
                //Eliminamos las filas vacias del detalle de inventario
                objDetalle.RemoveAll(p => p.IteCodigo.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Recuperamos en la variable el valor del campo razon
                string varRazon = this.lueRazon.EditValue == null ? "" : this.lueRazon.EditValue.ToString();
                //Validamos que todos los datos se han llenado correctamente en el detalle
                string varMensaje = clsInvMovimientoDet.funValidarDetalle(objDetalle, varRazon, varReqChapetaLote);
                if (!varMensaje.Equals("")) throw new Exception(varMensaje);
                //Asignamos los valores de la propiedades de la clase animal
                var csRegistro = new clsInvMovimientoCab() {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    IdMotivo = int.Parse(this.lueMotivo.EditValue.ToString()),

                    CabFecha = (DateTime)datFecha.EditValue,

                    CabTipMovimiento = this.txtTipoMovimiento.Text,
                    BodCodigo = this.lueBodega.EditValue.ToString(),
                    CabRazon = this.lueRazon.EditValue.ToString(),
                    CabComentario = this.memObsDocumento.Text,
                    CabComenDiario = this.memObsDiario.Text,
                    CcoCodigo = this.lueCenCosto.EditValue == null ? null : this.lueCenCosto.EditValue.ToString(),
                    PryCodigo = this.lueProyecto.EditValue == null ? null : this.lueProyecto.EditValue.ToString()
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

        private void xfrmManMovimiento_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.Equals(Keys.Enter)) {
                    if (!grvListado.IsFocusedView) return;
                     GridColumn varColumna = this.grvListado.FocusedColumn;
                     this.grvListado.FocusedColumn = colDetSecuencia;
                     this.grvListado.FocusedColumn = varColumna;
                    
                    if (this.grvListado.FocusedColumn == null) return;
                    if (!this.grvListado.FocusedColumn.Equals(colDetCantidad) &&
                         !this.grvListado.FocusedColumn.Equals(colDetPieza) &&
                         !this.grvListado.FocusedColumn.Equals(colIdMotPerdida))
                        return;
                    //Limpiamos todos los errores del detalle de movimientos
                    this.grvListado.ClearColumnErrors();
                    //Recuperamos la fila seleccionada e instanciamos con la clase detalle de inventario
                    clsInvMovimientoDet objFila = (clsInvMovimientoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                    //Recuperamos en la variable el valor del campo razon
                    string varRazon = this.lueRazon.EditValue == null ? "" : this.lueRazon.EditValue.ToString();
                    //Validamos que los campos ha sido debidamente ingresados
                    string varMensaje = objFila.funValidarFila(varRazon, varReqChapetaLote);
                    if (!varMensaje.Equals("")) {
                        string varControl = varMensaje.Split(':')[0];
                        string varError = varMensaje.Split(':')[1].Trim();
                        this.grvListado.SetColumnError(this.grvListado.Columns[varControl], varError);
                        this.grvListado.FocusedColumn = this.grvListado.Columns[varControl];
                        return;
                    }
                    //Agregamos una nueva linea
                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1)) {
                        int varPosicion = this.grvListado.FocusedRowHandle;
                        int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString());
                        this.objDetalle.Add(new clsInvMovimientoDet(varLinea));
                        this.grcListado.RefreshDataSource();
                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        if (!varRazon.ToLower().Equals("prd")) this.grvListado.FocusedColumn = colIteCodigo;
                        else this.grvListado.FocusedColumn = colDetIdDestino;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
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
                    this.grvListado.SetRowCellValue(varFila, colDetPieza, lisItem[0].InvntryUom.ToLower().Equals("kilo") ? 1 : 0);
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
                    this.grvListado.SetRowCellValue(varFila, colDetPieza, 0);
                    this.grvListado.SetRowCellValue(varFila, colCosto, 0);
                    this.grvListado.SetRowCellValue(varFila, colValor, 0);

                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void smiBorrar_Click(object sender, EventArgs e)
        {
            //if (grvListado.IsFocusedView && grvListado.RowCount > 0)
            //{
            //    DataRow selRow = ((DataRowView)(grvListado.GetFocusedRow())).Row;
            //    tabDet.Rows.Remove(selRow);
            //    tabDet.AcceptChanges();
            //}
            //if (grvListado.RowCount == 0)
            //    tabDet.Rows.Add(tabDet.NewRow());
        }
        private void lueMotivo_EditValueChanged(object sender, EventArgs e)
        {
            try {
                this.lueCenCosto.Enabled = false;
                this.lueCenCosto.EditValue = null;

                this.lueProyecto.Enabled = false;
                this.lueProyecto.EditValue = null;

                var varBodega = lueMotivo.GetColumnValue("ListaBodega");
                var varCenCosto = lueMotivo.GetColumnValue("ListaCenCosto");
                var varProyecto = lueMotivo.GetColumnValue("ListaProyecto");
                varReqChapetaLote = (bool)lueMotivo.GetColumnValue("Requerido");
                //Verificamos cuales bodegas tiene asociadas el motivo
                if (!varBodega.Equals("")) {
                    string[] lstBodega = varBodega.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    this.lueBodega.Properties.DataSource = clsGenBodega.funListar(lstBodega);
                    this.lueBodega.ItemIndex = 0;
                }
                //Verificamos cuales centros de costo tiene asociado el motivo
                if (!varCenCosto.Equals("")) {
                    string[] lstCenCosto = varCenCosto.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    this.lueCenCosto.Properties.DataSource = clsFinCenCosto.funListar(lstCenCosto);
                    this.lueCenCosto.ItemIndex = 0;
                    this.lueCenCosto.Enabled = true;
                }
                if (!varProyecto.Equals("")) {
                    string[] lstProyecto = varProyecto.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    this.lueProyecto.Properties.DataSource = clsFinProyecto.funListar(lstProyecto);
                    this.lueProyecto.ItemIndex = 0;
                    this.lueProyecto.Enabled = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void lueCenCosto_EditValueChanged(object sender, EventArgs e)
        {
            //Recuperamos el nombre del centro de costo
            var varCenCosto = lueCenCosto.GetColumnValue("PrcName");
            this.txtCenCosto.Text = varCenCosto == null ? "" : varCenCosto.ToString();
        }
        private void lueProyecto_EditValueChanged(object sender, EventArgs e)
        {
            //Recuperamos el nombre del proyecto
            var varProyecto = lueProyecto.GetColumnValue("PrjName");
            this.txtProyecto.Text = varProyecto == null ? "" : varProyecto.ToString();
        }
        private void gluBatch_EditValueChanged(object sender, EventArgs e)
        {
            try {
                var objFila = this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                var objBatch = ((GridLookUpEdit)sender).EditValue;
                string objRazon = this.lueRazon.EditValue == null ? "" : this.lueRazon.EditValue.ToString();

                if (objFila == null) return;
                if (objBatch == null) return;

                ((clsInvMovimientoDet)objFila).DetIdDestino = ((DataRowView)objBatch).Row.ItemArray[0].ToString();
                //Verificamos si la razon es de perdida
                if (objRazon.ToLower().Equals("prd")) {
                    //Asignamos a la variable el valor del codigo del item
                    string varIteCodigo = ((DataRowView)objBatch).Row.ItemArray[2].ToString();
                    //Asignamos a la fila actual con columna iteCodigo el valor de la variable
                    ((clsInvMovimientoDet)objFila).IteCodigo = varIteCodigo;
                    //Instanciamos el objeto Item
                    List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);
                     ((clsInvMovimientoDet)objFila).IteNombre = lisItem[0].ItemName;
                     ((clsInvMovimientoDet)objFila).IteUndInventario = lisItem[0].InvntryUom;
                     ((clsInvMovimientoDet)objFila).IteTieLote = lisItem[0].ManBtchNum;
                     ((clsInvMovimientoDet)objFila).ItePsoStd = 0;
                     ((clsInvMovimientoDet)objFila).DetCantidad = 1;
                     ((clsInvMovimientoDet)objFila).DetPieza = 1;
                }
                grvListado.UpdateCurrentRow();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void iluTipoDestino_EditValueChanged(object sender, EventArgs e)
        {
            try {
                
                var objTipoDestino = ((LookUpEdit)sender);
                if (objTipoDestino.EditValue.ToString().ToLower().Equals("a")) {
                    this.colDetBatchNro.Caption = "Chapeta";
                    string varBodCodigo = this.lueBodega.EditValue.ToString();
                    this.gluBatch.DataSource = clsGraAnimal.funRecAnimalesInventario();
                }
                else {
                    this.colDetBatchNro.Caption = "Lote";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para modificar el orden de las columnas del detalle de movimientos
        private void lueRazon_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Ocultamos la columnas
                this.colIdMotPerdida.Visible = false;
                this.colDetPeso.Visible = false;
                this.colDetTipDestino.Visible = false;
                this.colDetIdDestino.Visible = false;
                this.colDetOpcion.Visible = false;
                //Obtenemos el valor seleccionado por el usuario
                var objRazon = ((LookUpEdit)sender).EditValue;
                //Habilitamos las columnas que son requeridas
                if (varReqChapetaLote) {
                    this.colDetTipDestino.Visible = true;
                    this.colDetIdDestino.Visible = true;
                    this.colDetOpcion.Visible = true;
                }
                //Verificamos si el valor seleccionado es de razon perdida
                if (objRazon.ToString().ToLower().Equals("prd")) {
                    //Habilitamos la columna del motivo de perdida y peso
                    this.colIdMotPerdida.Visible = true;
                    this.colDetPeso.Visible = true;
                    //Ordenamos las columnas para la razon de perdida
                    if (varReqChapetaLote) this.colDetTipDestino.VisibleIndex = 1;
                    if (varReqChapetaLote) this.colDetIdDestino.VisibleIndex = 2;
                    if (varReqChapetaLote) this.colDetOpcion.VisibleIndex = 3;
                    this.colIteCodigo.VisibleIndex = 4;
                    this.colIteNombre.VisibleIndex = 5;
                    this.colIteUndInventario.VisibleIndex = 6;
                    this.colDetCantidad.VisibleIndex = 7;
                    this.colDetPieza.VisibleIndex = 8;
                    this.colDetPeso.VisibleIndex = 9;
                    this.colIdMotPerdida.VisibleIndex = 10;
                    //Deshabilitamos para edicion los siguientes campos
                    this.colIteCodigo.OptionsColumn.AllowEdit = false;
                }
                else {
                    this.colIteCodigo.VisibleIndex = 1;
                    this.colIteNombre.VisibleIndex = 2;
                    this.colIteUndInventario.VisibleIndex = 3;
                    if (varReqChapetaLote) this.colDetTipDestino.VisibleIndex = 4;
                    if (varReqChapetaLote) this.colDetIdDestino.VisibleIndex = 5;
                    if (varReqChapetaLote) this.colDetOpcion.VisibleIndex = 6;
                    //Habilitamos para edicion los siguientes campos
                    this.colIteCodigo.OptionsColumn.AllowEdit = true;
                }
                this.memObsDiario.Text = lueRazon.Text;
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
                    if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0) {
                        this.colIteCodigo.OptionsColumn.ReadOnly = false;
                        this.gluItem.ImmediatePopup = true;
                    }
                    else
                        this.colIteCodigo.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para poder llamar al mantenimiento de informacion de animales
        private void ibeBatch_Click(object sender, EventArgs e)
        {
            try {
                int varCodFormulario = 0;
                int varCuantos = 0;
                int varAnmCodigo = 0;

                //Recuperamos el valor seleccionado por el usuario en la chapeta
                ButtonEdit objBoton = ((ButtonEdit)sender);
                //Si no existe codigo de la chapeta salimos del proceso
                if (objBoton.Text.Equals("")) return;
                varAnmCodigo = int.Parse(clsGraAnimal.funListar(string.Format("Where a.AnmAlternativo = '{0}'", objBoton.Text)).Rows[0]["AnmCodigo"].ToString());
                
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisAnimal";
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
                varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, 1, 2);
                //En caso de tener acceso a la operacion modificar llamamos al formulario
                if (!varCuantos.Equals(0)) {
                    xfrmGraManAnimal frmFormulario = new xfrmGraManAnimal(varCodFormulario, 2, varAnmCodigo);
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                }
                else {
                    //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion consultar
                    varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, 1, 4);
                    if (!varCuantos.Equals(0)) {
                        xfrmGraManAnimal frmFormulario = new xfrmGraManAnimal(varCodFormulario, 4, varAnmCodigo);
                        frmFormulario.StartPosition = FormStartPosition.CenterParent;
                        frmFormulario.ShowDialog();
                    }
                    else XtraMessageBox.Show("El usuario no tiene acceso para la informacion de animales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try {
                //Debemos instanciar la clase a la grilla para el ingreso de detalles
                this.objDetalle = new List<clsInvMovimientoDet>();
                this.grcListado.DataSource = objDetalle;
                string varPath = this.butExaminar.Text.Trim();
                if (!varPath.Equals("")) {
                    using (OleDbConnection varConexion = new OleDbConnection() { ConnectionString = (String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=\"Excel 12.0;HDR=YES\"", varPath)) }) {
                        varConexion.Open();
                        OleDbCommand varComando = new OleDbCommand("Select Nro, Item, Descripcion, TipoDestino, ChapetaLote, Cantidad, Piezas From [INVSALIDA$]", varConexion);
                        OleDbDataAdapter varAdaptador = new OleDbDataAdapter(varComando);
                        DataSet dsExcel = new DataSet();
                        DataTable dtInvSalida = new DataTable();
                        varAdaptador.Fill(dsExcel);
                        dtInvSalida = dsExcel.Tables[0];
                        string varRazon = this.lueRazon.EditValue == null ? "" : this.lueRazon.EditValue.ToString();
                        //Recorremos la informacion recuperada del excel
                        foreach (DataRow drFilaDetalle in dtInvSalida.Rows) {
                            string varIteCodigo = drFilaDetalle["Item"] == null ? "" : drFilaDetalle["Item"].ToString();
                            string varAnmAlternativo = drFilaDetalle["ChapetaLote"] == null ? "" : drFilaDetalle["ChapetaLote"].ToString();
                            string varTipoDestino = drFilaDetalle["TipoDestino"].ToString().ToUpper().Equals("CHAPETA") ? "A" : "L";
                            
                            //Recuperamos la informacion del item
                            List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);
                            //Recuperamos la informacion de la chapeta o el lote
                            DataTable lisChapeta = null;
                            if (varTipoDestino.Equals("A")) {
                                lisChapeta = clsGraAnimal.funListar(string.Format("Where a.AnmAlternativo = '{0}'", varAnmAlternativo));
                                if (lisChapeta.Rows.Count > 0)
                                    if (!lisChapeta.Rows[0]["EstCodigo"].ToString().Equals("ACTIVO")) {
                                        this.grcListado.RefreshDataSource();
                                        XtraMessageBox.Show(string.Format("La chapeta nro: {0} no se encuentra activa", varAnmAlternativo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                            }
                            //Instanciamos una fila del detalle de la clase detalle de movimientos
                            clsInvMovimientoDet objFilaDetalle = new clsInvMovimientoDet() {
                                DetSecuencia = drFilaDetalle["Nro"] == null || drFilaDetalle["Nro"].ToString().Equals("") ? 0 : int.Parse(drFilaDetalle["Nro"].ToString()), //Secuencia
                                IdMotPerdida = null, //Motivo de perdida
                                DetPieza = drFilaDetalle["Piezas"] == null || drFilaDetalle["Piezas"].ToString().Equals("") ? 0 : int.Parse(drFilaDetalle["Piezas"].ToString()), //Piezas
                                IteCodigo = drFilaDetalle["Item"] == null ? "" : drFilaDetalle["Item"].ToString(), //Item
                                IteNombre = lisItem.Count().Equals(0) ? "" : lisItem[0].ItemName, //Descripcion
                                IteUndInventario = lisItem.Count().Equals(0) ? "" : lisItem[0].InvntryUom, //Unidad de inventario
                                IteTieLote = lisItem.Count().Equals(0) ? "" : lisItem[0].ManBtchNum, //Item gestionado por lotes
                                DetTipDestino = drFilaDetalle["TipoDestino"].ToString().ToUpper().Equals("CHAPETA") ? "A" : "L", //Verifica si es chapeta o lote
                                DetIdDestino = lisChapeta.Rows.Count.Equals(0) ? null : drFilaDetalle["ChapetaLote"].ToString() , //Codigo alterno de la chapeta o lote
                                ItePsoStd = lisItem.Count().Equals(0) ? 0 : lisItem[0].SWeight1, //Peso standar
                                DetCantidad = drFilaDetalle["Cantidad"] == null || drFilaDetalle["Cantidad"].ToString().Equals("") ? 0 : decimal.Parse(drFilaDetalle["Cantidad"].ToString()), //Cantidad
                                DetPeso = 0,
                                DetCosto = 0,
                                DetValor = 0
                            };
                            //Validamos que la informacion de la fila sea la correcta
                            string varMensaje = objFilaDetalle.funValidarFila(varRazon, varReqChapetaLote);
                            if (varMensaje != "") varMensaje = varMensaje.Substring(varMensaje.IndexOf(':', 0) + 2, varMensaje.Length - varMensaje.IndexOf(':', 0) -2);
                            if (!varMensaje.Equals("")) { this.grcListado.RefreshDataSource(); XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            objDetalle.Add(objFilaDetalle);
                        }
                        this.grcListado.RefreshDataSource();
                        XtraMessageBox.Show("Informacion extraida con exito!!!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { XtraMessageBox.Show("Debe escoger el archivo para poder extraer la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void butExaminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                this.openFileDialog.FileName = "";
                this.openFileDialog.Filter = "Microsoft Excel|*.xls;*.xlsx";
                this.openFileDialog.FilterIndex = 2;
                this.openFileDialog.RestoreDirectory = true;

                if (this.openFileDialog.ShowDialog() == DialogResult.OK) this.butExaminar.Text = this.openFileDialog.FileName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
