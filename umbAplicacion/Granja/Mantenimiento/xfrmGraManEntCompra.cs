using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;
using umbAplicacion.Compras.Listado;
using umbNegocio.Compra;
using umbNegocio.General;
using umbNegocio.Granja;
using umbDatos;
using umbNegocio.Inventario;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Drawing.Drawing2D;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManEntCompra : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        DataTable dtEntCompra;

        private string varOldIteCodigo = "";
        private string varCodParDocumento = "";

        private decimal varSubtotal;
        private decimal varImpuesto;
        private decimal varTotal;
        private decimal varIVA;

        public xfrmGraManEntCompra()
        {
            InitializeComponent();
        }
        public xfrmGraManEntCompra(int varFormulario, int varOperacion, int varRegistro )
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Entrada de mercancia (Compra)";
                //Recuperamos la informacion para los controles q contendra opciones para que escoja el usuario
                this.gluItem.DataSource = clsInvItem.funListar();
                this.lueBodega.Properties.DataSource = clsGenBodega.funRecUsuarioBodega(clsVariablesGlobales.varCodUsuario);
                //Recuperamos la informacion del parametro del IVA
                varIVA = clsGenParametros.funObtenerIvaSAP();
                //Recuperamos la informacion de los documentos que registran animales
                varCodParDocumento = clsGenOpciones.CargarValor("G.Ema.Entrada.Doc"); 
                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text);
                        varDocNombre = this.txtNombre.Text;
                        //Iniciamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.lueBodega.ItemIndex = 0;
                        //Instanciamos el datatable que sera utilizado para el detalle del documento
                        this.proDtEntCompra();
                        //Agregamos la primera linea del detalle el documento
                        this.proAñadirDtEntCompra(1, "", "", "", "", "", "N", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "IVA_EXE", 0);
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsGraEntCompra csRegistro in clsGraEntCompra.funListar(string.Format("Where CabCodigo = {0}", varRegCodigo))) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.txtNomSerie.Text = csRegistro.DocNombre.ToString();
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.txtSapNumero.Text = csRegistro.CabNumSap.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.bedProveedor.EditValue = csRegistro.PrvCodigo;
                            this.txtNombre.Text = csRegistro.PrvNombre;
                            this.lueBodega.EditValue = csRegistro.BodCodigo;
                            this.memObservacion.Text = csRegistro.CabComentario;
                            //Instanciamos los objetos del datatable
                            this.proDtEntCompra();
                            //Recuperamos los datos de los detalles de la entrada de mercancia
                            DataTable dtRecEntMercancia = clsGraEntCompra.funRecDetEntMercancia(varRegCodigo);
                            //Llenamos la informacion recuperada en el DataTable
                            foreach (DataRow drEntMercancia in dtRecEntMercancia.Rows) {
                                int varSecuencia = int.Parse(drEntMercancia["DetSecuencia"].ToString());            //Nro de linea 
                                string varIteCodigo =  drEntMercancia["IteCodigo"].ToString();                              //Codigo del item
                                string varIteNombre = drEntMercancia["IteNombre"].ToString();                             //Descripcion del item
                                string varIteUndInventario = drEntMercancia["IteUndInventario"].ToString();     //Unidad de medida del item
                                string varIteTieLote = drEntMercancia["DetTieLote"].ToString();                            //Identificar si el item es gestionado por lotes
                                string varIteIVACompra = drEntMercancia["IteIvaCompra"].ToString();                            //IVA de compra del item
                                string varDetChapeta = drEntMercancia["DetChapeta"].ToString();                            //Chapeta del animal
                                string varDetLote = drEntMercancia["DetLote"].ToString();                            //Lote del animal
                                decimal varDetCantidad = decimal.Parse(drEntMercancia["DetCantidad"].ToString());        //Cantidad a ingresar
                                decimal varDetCosto = decimal.Parse(drEntMercancia["DetCosto"].ToString());                  //Costo del producto
                                decimal varDetDsto = decimal.Parse(drEntMercancia["DetDsto"].ToString());                      //Dsto del producto
                                decimal varDetTotal = decimal.Parse(drEntMercancia["DetTotal"].ToString());                     //Total en dolares del producto
                                decimal varItePsoStd = decimal.Parse(drEntMercancia["ItePsoStandar"].ToString());                     //Total en dolares del producto
                                decimal varDetPeso = decimal.Parse(drEntMercancia["DetPeso"].ToString());                     //Peso del animal
                                int varDetObjType = int.Parse(drEntMercancia["DecObjType"].ToString());            //Nro de objeto de la orden de compra de SAP
                                int varDetDocEntry = int.Parse(drEntMercancia["DecDocEntry"].ToString());            //Codigo de la orden de compra de SAP
                                int varDetDocNum = int.Parse(drEntMercancia["DecDocNum"].ToString());            //Numero de la orden de compra de SAP
                                int varDetLineNum = int.Parse(drEntMercancia["DecLineNum"].ToString());            //Numero de la linea de la orden de compra de SAP
                                int varDetPieza= int.Parse(drEntMercancia["DetPieza"].ToString());            //Numero de piezas de los items
                                proAñadirDtEntCompra(varSecuencia, varIteCodigo, varIteNombre, varIteUndInventario, varDetChapeta, varDetLote, varIteTieLote, varDetCantidad, varDetPieza, 
                                                                           varDetPeso, varDetCosto, varDetDsto, varDetTotal, varDetObjType, varDetDocEntry, varDetDocNum, varDetLineNum, 
                                                                           varIteIVACompra, varItePsoStd);
                            }
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; this.btnCopiar.Enabled = false; }
                        break;
                }

                if (varCodParDocumento.Contains(varDocCodigo.ToString())) {
                    this.colDetLote.Visible = false;
                    this.colDetChapeta.Visible = true;
                    this.colDetPeso.Visible = true;
                }
                else {
                    this.colDetLote.Visible = true;
                    this.colDetChapeta.Visible = false;
                    this.colDetPeso.Visible = false;
                }

                //Verificamos los acceso del usuario al formulario\
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                DataRow[] dtValidaciones = dtEntCompra.Select("IteCodigo = ''");
                foreach (DataRow drValidaciones in dtValidaciones) drValidaciones.Delete();
                this.dtEntCompra.AcceptChanges();
                
                dtValidaciones = dtEntCompra.Select("DetCantidad = 0");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de cantidad favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                dtValidaciones = dtEntCompra.Select("DetCosto = 0");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de costo favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (varCodParDocumento.Contains(varDocCodigo.ToString())) {
                    dtValidaciones = dtEntCompra.Select("DetChapeta = ''");
                    if (dtValidaciones.Length > 0) { XtraMessageBox.Show("Existe valores en blanco en la columna de chapeta favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                else {
                    dtValidaciones = dtEntCompra.Select("DetLote = '' and DetTieLote = 'Y'");
                    if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El item {0}-{1} requiere numero de lote", dtValidaciones[0].ItemArray[1], dtValidaciones[0].ItemArray[2]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                    dtValidaciones = dtEntCompra.Select("DetLote <> '' and DetTieLote = 'N'");
                    if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El item {0}-{1} no requiere numero de lote", dtValidaciones[0].ItemArray[1], dtValidaciones[0].ItemArray[2]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }

                var csRegistro = new clsGraEntCompra()
               {
                   CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                   DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                   DocNombre = this.txtNomSerie.Text,
                   CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                   CabEntrySap = 0,
                   CabNumSap = 0,
                   CabFecha = (DateTime)this.datFecha.EditValue,
                   PrvCodigo = this.bedProveedor.EditValue.ToString(),
                   PrvNombre = this.txtNombre.Text,
                   BodCodigo = this.lueBodega.EditValue.ToString(),
                   CabImportacion = this.txtImportacion.Text,
                   CabComentario = this.memObservacion.Text,
                   CabSubtotal = decimal.Parse(this.colDetTotal.Summary[0].SummaryValue.ToString()),
                   CabIva = decimal.Parse(this.colDetTotal.Summary[1].SummaryValue.ToString()),
                   CabTotal = decimal.Parse(this.colDetTotal.Summary[2].SummaryValue.ToString()),
                   EstCodigo = "Nor",
                   DetEntMercancia = this.dtEntCompra
               };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        csRegistro = clsGraEntCompra.funListar(string.Format("Where a.CabNumero = {0}", varCodigo))[0];
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", csRegistro.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proDtEntCompra()
        {
            dtEntCompra = new DataTable { TableName = "EntradaCompra" };
            dtEntCompra.Columns.Add("DetSecuencia", typeof(int));
            dtEntCompra.Columns.Add("IteCodigo", typeof(string));
            dtEntCompra.Columns.Add("IteNombre", typeof(string));
            dtEntCompra.Columns.Add("IteUndInventario", typeof(string));
            dtEntCompra.Columns.Add("DetChapeta", typeof(string));
            dtEntCompra.Columns.Add("DetLote", typeof(string));
            dtEntCompra.Columns.Add("DetTieLote", typeof(string));
            dtEntCompra.Columns.Add("DetCantidad", typeof(decimal));
            dtEntCompra.Columns.Add("DetPieza", typeof(int));
            dtEntCompra.Columns.Add("DetPeso", typeof(decimal));
            dtEntCompra.Columns.Add("DetCosto", typeof(decimal));
            dtEntCompra.Columns.Add("DetDsto", typeof(decimal));
            dtEntCompra.Columns.Add("DetTotal", typeof(decimal));
            dtEntCompra.Columns.Add("ObjType", typeof(int));
            dtEntCompra.Columns.Add("DocEntry", typeof(int));
            dtEntCompra.Columns.Add("DocNum", typeof(int));
            dtEntCompra.Columns.Add("LineNum", typeof(int));
            dtEntCompra.Columns.Add("TaxCodeAP", typeof(string));
            dtEntCompra.Columns.Add("DetPsoStd", typeof(decimal));

            this.grcListado.DataSource = dtEntCompra;
            
        }
        private void proAñadirDtEntCompra(int varLinea, string varIteCodigo, string varIteNombre, string varIteUndInventario, string varDetChapeta, string varDetLote, string varTieLote, decimal varCantidad, int varPieza,
                                                                    decimal varPeso, decimal varCosto, decimal varDsto, decimal varTotal, int varObjType, int varDocEntry, int varDocNum, int varLineNum, 
                                                                    string varTaxCodeAP, decimal varDetPsoStd)
        {
            try
            {
                this.dtEntCompra.Rows.Add(  varLinea,                                     //Es la columna DetLinea
                                                                   varIteCodigo,                                //Es la columna IteCodigo
                                                                   varIteNombre,                        //Es la columna IteNombre
                                                                   varIteUndInventario,          //Es la columna IteUndInventario
                                                                   varDetChapeta,                 //Es la columna DetChapeta
                                                                   varDetLote,                      //Es la columna DetLote
                                                                   varTieLote,                      //Es la columna DetTieLote
                                                                   varCantidad,                    //Es la columna DetCantidad
                                                                   varPieza,                           //Es la columna DetPieza
                                                                   varPeso,                            //Es la columna DetPeso
                                                                   varCosto,                          //Es la columna DetCosto
                                                                   varDsto,                            //Es la columna DetDsto
                                                                   varTotal,                            //Es la columna DetTotal
                                                                   varObjType,                      //Es la columna ObjType
                                                                   varDocEntry,                     //Es la columna DocEntry
                                                                   varDocNum,                      //Es la columna DocNum
                                                                   varLineNum,                      //Es la columna LineNum
                                                                   varTaxCodeAP,                //Es la columna TaxCodeAR
                                                                   varDetPsoStd);               //Pso Std de venta del producto
            }
            catch (Exception) { throw; }
        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable que contentra el codigo de proveedor
                string varCodProveedor = this.bedProveedor.Text;
                //Variable que contentra el codigo de la bodega
                string varCodBodega = this.lueBodega.EditValue == null ? "" :  this.lueBodega.EditValue.ToString();
                //Validamos si el usuario ha escogido un proveedor
                if (varCodProveedor.Equals("")) { XtraMessageBox.Show("Debe seleccionar un proveedor para el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                //Validamos si el usuario ha escogido una bodega
                if (varCodBodega.Equals("")) { XtraMessageBox.Show("Debe seleccionar una bodega para el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                //Recuperamos las ordenes de compras ingresada en SAP vinculados al proveedor del objeto OPOR
                DataTable dtOPOR = clsSegDocumento.funDocProveedor("OPOR", varCodProveedor);
                var objFrmFormulario = new frmDocProveedor(dtOPOR) { StartPosition = FormStartPosition.CenterParent };
                objFrmFormulario.ShowDialog();
                //Verificamos si el usuario escogio una orden de compra
                if (!(objFrmFormulario.DrVarFila == null)) {
                    //Instanciamos el datatable que sera utilizado para el detalle del documento
                    this.proDtEntCompra();
                    //Recuperamos la informacion del detalle de las ordenes de compras seleccionadas por el usuario
                    DataTable dtLisEntCompra = clsGraEntCompra.funRecDetOrdCompraSAP(objFrmFormulario.DrVarFila);
                    //Bucle utilizado para recorrer los detalles de la ordenes de compras
                    for (int i = 0; i < dtLisEntCompra.Rows.Count; i++) {
                        //Para la primera linea recuperamos informacion de la cabecera del documeno
                        if (i.Equals(0)) this.txtImportacion.Text = dtLisEntCompra.Rows[i]["U_num_importacion"].ToString();
                        //Recuperamos la informacion en sus respectivas variables                      
                        string varIteCodigo = dtLisEntCompra.Rows[i]["ItemCode"].ToString();
                        string varIteNombre = dtLisEntCompra.Rows[i]["Dscription"].ToString();
                        string varIteUndInventario = dtLisEntCompra.Rows[i]["InvntryUom"].ToString();
                        string varTieLote = dtLisEntCompra.Rows[i]["ManBtchNum"].ToString();
                        decimal varCantidad = decimal.Parse(dtLisEntCompra.Rows[i]["Quantity"].ToString());
                        int varPieza = int.Parse(Math.Round(decimal.Parse(dtLisEntCompra.Rows[i]["Pieza"].ToString()), 0).ToString());
                        decimal varCosto = decimal.Parse(dtLisEntCompra.Rows[i]["Price"].ToString());
                        decimal varDsto = decimal.Parse(dtLisEntCompra.Rows[i]["DiscPrcnt"].ToString());
                        decimal varTotal = decimal.Parse(dtLisEntCompra.Rows[i]["LineTotal"].ToString());
                        int varObjType = int.Parse(dtLisEntCompra.Rows[i]["ObjType"].ToString());
                        int varDocEntry = int.Parse(dtLisEntCompra.Rows[i]["DocEntry"].ToString());
                        int varDocNum = int.Parse(dtLisEntCompra.Rows[i]["DocNum"].ToString());
                        int varLineNum = int.Parse(dtLisEntCompra.Rows[i]["LineNum"].ToString());
                        string varTaxCodeAP = dtLisEntCompra.Rows[i]["TaxCodeAP"].ToString();
                        decimal varDetPsoStd = decimal.Parse(dtLisEntCompra.Rows[i]["SWeight1"].ToString());
                        //Procedimiento utilizado para agregar una linea en los detalles del documento
                        proAñadirDtEntCompra(i + 1, varIteCodigo, varIteNombre, varIteUndInventario, "", "", varTieLote, varCantidad, varPieza, 0, varCosto, varDsto, varTotal, varObjType, varDocEntry, varDocNum, varLineNum, varTaxCodeAP, varDetPsoStd);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de proveedores
                using (xfrmComLisProveedor frmFormulario = new xfrmComLisProveedor(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedProveedor.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvCodigo;
                        this.txtNombre.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvNombre.ToString();
                        //Instanciamos el datatable que sera utilizado para el detalle del documento
                        this.proDtEntCompra();
                        //Agregamos la primera linea del detalle el documento
                        this.proAñadirDtEntCompra(1, "", "", "", "", "", "N", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "IVA_EXE", 0);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varCardCode = this.bedProveedor.Text.Trim();

                this.txtNombre.Text = "";
                if (varCardCode.Length < 9)  return;
                this.txtNombre.Text = "";
                this.btnCopiar.Enabled = false;
                
                foreach (clsComProveedor csRegistro in clsComProveedor.funListar(varCardCode)) 
                { 
                    this.txtNombre.Text = csRegistro.PrvNombre; 
                    this.btnCopiar.Enabled = true;
                    //Instanciamos el datatable que sera utilizado para el detalle del documento
                    this.proDtEntCompra();
                    //Agregamos la primera linea del detalle el documento
                    this.proAñadirDtEntCompra(1, "", "", "", "", "", "N", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "IVA_EXE",0);
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
                if (!lisItem.Equals(null)) {
                    //Asignamos los valores recuperados a la fila
                    this.grvListado.SetRowCellValue(varFila, colIteCodigo, lisItem[0].ItemCode);
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, lisItem[0].ItemName);
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, lisItem[0].InvntryUom);
                    this.grvListado.SetRowCellValue(varFila, colDetTieLote, lisItem[0].ManBtchNum);
                    this.grvListado.SetRowCellValue(varFila, colTaxCodeAP, lisItem[0].TaxCodeAP);
                    this.grvListado.SetRowCellValue(varFila, colDetPsoStd, lisItem[0].SWeight1);
                    this.grvListado.SetRowCellValue(varFila, colDetCosto, lisItem[0].AvgPrice);
                    this.grvListado.SetRowCellValue(varFila, colDetCantidad, 1);
                    this.grvListado.SetRowCellValue(varFila, colDetTotal, lisItem[0].AvgPrice);
                }
                else {
                    //En caso de no existir coincidencias enceramos los datos de la fila
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, "");
                    this.grvListado.SetRowCellValue(varFila, colDetTieLote, "");
                    this.grvListado.SetRowCellValue(varFila, colTaxCodeAP, "IVA_EXE");
                    this.grvListado.SetRowCellValue(varFila, colDetPsoStd, 0);
                    this.grvListado.SetRowCellValue(varFila, colDetCosto, 0);
                    this.grvListado.SetRowCellValue(varFila, colDetTotal, 0);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void xfrmGraManEntCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Verificamos que la tecla pulsada por el usuario sea la tecla ENTER
                if (e.KeyCode.Equals(Keys.Enter)) {
                    //Verificamos si el usuario esta posicionado en el detalle del documento
                    if (!grvListado.IsFocusedView) return;
                    //Verificamos si existe al menos un detalle
                    if (grvListado.RowCount.Equals(0)) return;
                    //Verificamos si el usuario esta posicionado en el campo Pieza, Costo o Total
                    if (!(grvListado.FocusedColumn.Equals(colDetPieza) || grvListado.FocusedColumn.Equals(colDetCosto) || grvListado.FocusedColumn.Equals(colDetTotal))) return;
                    //Posicionamos el focus del detalle en la fila que de como resultado del total de filas - 1
                    grvListado.FocusedRowHandle = grvListado.RowCount - 1;
                    //Posicionamos el focus del detalle en la columna UNIDAD
                    grvListado.FocusedColumn = grvListado.Columns["DetUnidad"];
                    //Variable q contendra la fila en la que se encuentra posicionado el usuario
                    int varPosicion = this.grvListado.FocusedRowHandle;
                    //Varable q contendra el nro de linea siguiente
                    int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString()) + 1;
                    //Recuperamos los valores que contiene la fila en las siguiente variables 
                    string varIteCodigo = this.grvListado.GetRowCellValue(varPosicion, colIteCodigo).ToString();
                    string varTieLote = this.grvListado.GetRowCellValue(varPosicion, colDetTieLote).ToString();
                    string varDetChapeta = this.grvListado.GetRowCellValue(varPosicion, colDetChapeta).ToString();
                    string varDetLote = this.grvListado.GetRowCellValue(varPosicion, colDetLote).ToString();
                    decimal varCantidad = decimal.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetCantidad).ToString());
                    decimal varCosto = decimal.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetCosto).ToString());
                    //Validaciones que tiene la fila para poder agregar una nueva
                    if (varIteCodigo.Equals("")) { this.grvListado.SetColumnError(colIteCodigo, "Debe ingresar el codigo del item"); return; }
                    if (varCantidad.Equals(0)) { this.grvListado.SetColumnError(colDetCantidad, "La cantidad debe ser mayor a cero"); return; }
                    if (varCosto.Equals(0)) { this.grvListado.SetColumnError(colDetCosto, "El costo debe ser mayor a cero"); return; }
                    if (this.txtNomSerie.Text.Substring(4, 1).Equals("A") && varDetChapeta.Equals("")) { this.grvListado.SetColumnError(colDetChapeta, "Debe ingresar el nro de chapeta"); grvListado.FocusedColumn = colDetChapeta; return; }
                    if (!this.txtNomSerie.Text.Substring(4, 1).Equals("A") && varTieLote.Equals("Y") && varDetLote.Equals("")) { this.grvListado.SetColumnError(colDetLote, "Debe ingresar el nro de lote"); return; }
                    //Agregamos la primera linea del detalle el documento
                    this.proAñadirDtEntCompra(1, "", "", "", "", "", "N", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "IVA_EXE", 0);
                    //Posicionamos el cursor en la nueva fila
                    this.grvListado.FocusedRowHandle = varPosicion + 1;
                    //Posicionamos el cursor en la columna Item
                    this.grvListado.FocusedColumn = colIteCodigo;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
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
                //En caso de que el usuario este posicionado en la columna de lote y este item sea gestionado por lotes se activara la columna
                else if (this.grvListado.FocusedColumn.Equals(colDetLote)) {
                        if (this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DetTieLote"].ToString().Equals("N"))
                            this.colDetLote.OptionsColumn.ReadOnly = true;
                        else
                            this.colIteCodigo.OptionsColumn.ReadOnly = false;
                    }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_CustomDrawFooter(object sender, RowObjectCustomDrawEventArgs e)
        {
            try
            {
                //Sombriamos la linea de totales de fondo blanco
                e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Handled = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column == colDetCosto) {
                    //Utilizamos para poder poner el costo a la derecha
                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.DrawString(e.Cache, e.Info.DisplayText, e.Bounds);
                    e.Handled = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView grvGeneral = sender as GridView;

                // Initialization 
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    varSubtotal = 0;
                    varImpuesto = 0;
                    varTotal = 0;
                }
                // Calculation 
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                    if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName.Equals("DetTotal"))
                    {
                        switch (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).Index)
                        {
                            case 0:
                                varSubtotal = varSubtotal + decimal.Parse(e.FieldValue.ToString());
                                break;
                            case 1:
                                varImpuesto = varImpuesto + (grvGeneral.GetRowCellValue(e.RowHandle, colTaxCodeAP).ToString().Equals("IVA") ? (decimal.Parse(e.FieldValue.ToString()) * (decimal)(varIVA/100)) : 0);
                                break;
                            case 2:
                                varTotal = varTotal + decimal.Parse(e.FieldValue.ToString()) + (grvGeneral.GetRowCellValue(e.RowHandle, colTaxCodeAP).ToString().Equals("IVA") ? (decimal.Parse(e.FieldValue.ToString()) * (decimal)(varIVA/100)) : 0);
                                break;
                        }
                    }
                }
                // Finalization 
                if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                {
                    if (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).FieldName.Equals("DetTotal"))
                    {
                        switch (((DevExpress.XtraGrid.GridSummaryItem)(e.Item)).Index)
                        {
                            case 0:
                                e.TotalValue = varSubtotal;
                                break;
                            case 1:
                                e.TotalValue = varImpuesto;
                                break;
                            case 2:
                                e.TotalValue = varTotal;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                //Obtenemos el objeto DataRow de la fila seleccionada
                DataRow drFila = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                //Variables utilizadas para los calculos
                int varDetPieza = 0;
                decimal varDetCantidad = 0;
                decimal varDetCosto = 0;
                decimal varDetDsto = 0;
                decimal varDetTotal = 0;
                decimal varDetPsoStd = decimal.Parse(drFila["DetPsoStd"].ToString());
                string varIteUndInventario = drFila["IteUndInventario"].ToString();
                //Validamos si estamos posicionados en la columna de cantidad
                if (this.grvListado.FocusedColumn.Equals(colDetCantidad))
                {
                    varDetCantidad = decimal.Parse(e.Value.ToString());
                    varDetCosto = decimal.Parse(drFila["DetCosto"].ToString());
                    varDetDsto = decimal.Parse(drFila["DetDsto"].ToString());
                    if (varDetCosto > 0)
                        varDetTotal = decimal.Round((varDetCantidad * varDetCosto) - (varDetDsto == 0 ? 0 : ((varDetCantidad * varDetCosto) * (varDetDsto / 100))), 2);
                    drFila["DetTotal"] = varDetTotal;
                    //Verificamos si el item es en kilos o unidades
                    if (varIteUndInventario.ToLower().Equals("kilo"))
                        if (varDetPsoStd > 0)
                            varDetPieza = int.Parse(decimal.Round(varDetCantidad / varDetPsoStd, 0).ToString());
                    drFila["DetPieza"] = varDetPieza;
                }
                else if (this.grvListado.FocusedColumn.Equals(colDetDsto))
                {
                    varDetCantidad = decimal.Parse(drFila["DetCantidad"].ToString());
                    varDetCosto = decimal.Parse(drFila["DetCosto"].ToString());
                    varDetDsto = decimal.Parse(e.Value.ToString());
                    if (varDetCosto > 0 && varDetCantidad > 0)
                        varDetTotal = decimal.Round((varDetCantidad * varDetCosto) - (varDetDsto == 0 ? 0 : ((varDetCantidad * varDetCosto) * (varDetDsto / 100))), 2);
                    drFila["DetTotal"] = varDetTotal;
                }
                else if (this.grvListado.FocusedColumn.Equals(colDetCosto))
                {
                    varDetCantidad = decimal.Parse(drFila["DetCantidad"].ToString());
                    varDetCosto = decimal.Parse(e.Value.ToString());
                    varDetDsto = decimal.Parse(drFila["DetDsto"].ToString());
                    if (varDetCantidad > 0)
                        varDetTotal = decimal.Round((varDetCantidad * varDetCosto) - (varDetDsto == 0 ? 0 : ((varDetCantidad * varDetCosto) * (varDetDsto / 100))), 2);
                    drFila["DetTotal"] = varDetTotal;
                }
                else if (this.grvListado.FocusedColumn.Equals(colDetTotal))
                {
                    varDetCantidad = decimal.Parse(drFila["DetPeso"].ToString());
                    varDetCosto = decimal.Parse(drFila["DetCosto"].ToString());
                    varDetTotal = decimal.Parse(e.Value.ToString());
                    if (varDetCosto > 0 && varDetCantidad > 0)
                        varDetDsto = decimal.Round(((decimal.Round(varDetCosto * varDetCantidad, 2) - varDetTotal) * 100) / decimal.Round(varDetCosto * varDetCantidad, 2), 2);
                    else if (varDetCosto.Equals(0) && varDetCantidad > 0)
                        varDetCosto = decimal.Round(varDetTotal / varDetCantidad, 2);
                    drFila["DetDsto"] = varDetDsto;
                    drFila["DetCosto"] = varDetCosto;
                }
                this.grvListado.UpdateCurrentRow();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

      

       
    }
}
