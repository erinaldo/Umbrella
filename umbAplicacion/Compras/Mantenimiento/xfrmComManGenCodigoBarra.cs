using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Compras.Impresion;
using umbAplicacion.Compras.Listado;
using umbNegocio.Compra;
using umbNegocio.Entidades;
using umbNegocio.Inventario;
using Umbrella;

namespace umbAplicacion.Compras.Mantenimiento
{
    public partial class xfrmComManGenCodigoBarra : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private List<EntCOM_DETGENCODBARRA> objDetalle;

        public xfrmComManGenCodigoBarra() { InitializeComponent(); }
        public xfrmComManGenCodigoBarra(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }

        #region Procedimientos heredados

        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Generación de codigos de barra en recepción de carnes"; //Asignamos el título al formulario
                this.gluItem.DataSource = clsInvItem.funListar(); //Cargamos el control con el maestro de items
                switch (varOpeCodigo) { //Verificamos que opción selecciono
                    case 1: //Opción 1 para insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNomSerie.Text;
                        
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.objDetalle = new List<EntCOM_DETGENCODBARRA>();
                        this.objDetalle.Add(new EntCOM_DETGENCODBARRA(0));
                        this.grcDetalle.DataSource = objDetalle;
                        break;
                    case 2: //Opción 2 para modificar
                    case 4: //Opcion 4 para consultar
                        EntCOM_CABGENCODBARRA objCabecera = daoComGenCodigoBarra.getInstance().metConsultar(varRegCodigo);
                        if(objCabecera != null) {
                            varDocCodigo = objCabecera.atrDocCodigo;
                            this.txtCodigo.EditValue = objCabecera.atrCabCodigo;
                            this.txtCodSerie.EditValue = objCabecera.atrDocCodigo;
                            this.txtNomSerie.EditValue = objCabecera.atrDocNombre;
                            this.txtNumero.EditValue = objCabecera.atrCabNumero;
                            this.datFecha.EditValue = objCabecera.atrCabFecha;
                            this.bedProveedor.EditValue = objCabecera.atrPrvCodigo;
                            this.txtProveedor.EditValue = objCabecera.atrPrvNombre;
                            this.txtLote.EditValue = objCabecera.atrCabLote;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<EntCOM_DETGENCODBARRA>();
                            objDetalle = daoComGenCodigoBarra.getInstance().metConsultarDetalle(varRegCodigo);
                            if (varOpeCodigo.Equals(2)) {
                                //Recuperamos la ultima secuencia 
                                int varSecuencia = 0;
                                if (!objDetalle.Count.Equals(0)) varSecuencia = objDetalle.Max(p => p.atrDetSecuencia);
                                this.objDetalle.Add(new EntCOM_DETGENCODBARRA(varSecuencia));
                            }
                            this.grcDetalle.DataSource = objDetalle;
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) {
                            this.btnGrabar.Enabled = false;
                            this.colDetImprimir.Visible = true;
                            this.colAtrIteCodigo.OptionsColumn.AllowEdit = false;
                            this.colAtrDetLote.OptionsColumn.AllowEdit = false;
                        }
                        break;
                    default:
                        break;
                }
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar() {
            base.proGrabar();
            try {
                //Eliminamos las filas vacias del detalle
                objDetalle.RemoveAll(p => p.atrIteNombre.Equals(""));
                EntCOM_CABGENCODBARRA objDocumento = new EntCOM_CABGENCODBARRA();
                objDocumento.atrDocCodigo = int.Parse(this.txtCodSerie.Text);
                objDocumento.atrCabFecha = (DateTime)this.datFecha.EditValue;
                objDocumento.atrPrvCodigo = this.bedProveedor.EditValue.ToString();
                objDocumento.atrPrvNombre = this.txtProveedor.Text;
                objDocumento.atrCabLote = this.txtLote.Text;
                objDocumento.atrCabComentario = "";
                objDocumento.atrDetalles = objDetalle;
                //Validamos que los datos esten ingresados
                string varMensaje = objDocumento.funValidar();
                if (!varMensaje.Equals("")) {
                    string varControl = varMensaje.Split(':')[0];
                    string varError = varMensaje.Split(':')[1].Trim();

                    ConditionValidationRule objCondicionVacio = new ConditionValidationRule();
                    objCondicionVacio.ConditionOperator = ConditionOperator.IsNotBlank;
                    objCondicionVacio.ErrorText = varError;

                    if (varControl.Equals("bedProveedor"))
                        this.dxValidation.SetValidationRule(bedProveedor, objCondicionVacio);
                    else if (varControl.Equals("txtLote"))
                        this.dxValidation.SetValidationRule(txtLote, objCondicionVacio);
                    else if (varControl.Equals("grcDetalle")) {
                        XtraMessageBox.Show(varError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.objDetalle = new List<EntCOM_DETGENCODBARRA>();
                        this.objDetalle.Add(new EntCOM_DETGENCODBARRA(0));
                        this.grcDetalle.DataSource = objDetalle;
                    }
                        

                    dxValidation.Validate();
                    return;
                }

                object[] objResultado = new object[2];
                switch (varOpeCodigo) {
                    case 1:
                        objResultado = daoComGenCodigoBarra.getInstance().metInsertar(objDocumento);
                        proEnviarMensaje(objResultado);
                        if (objResultado[0].Equals("ok")) {
                            if (XtraMessageBox.Show("Desea imprimir las etiquetas", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                proImprimirEtiquetas(1);
                        }
                        break;
                    case 2:
                        objDocumento.atrCabCodigo = int.Parse(this.txtCodigo.Text);
                        objDocumento.atrCabNumero = int.Parse(this.txtNumero.Text);
                        objResultado = daoComGenCodigoBarra.getInstance().metModificar(objDocumento);
                        proEnviarMensaje(objResultado);
                        if (objResultado[0].Equals("ok")) {
                            if (XtraMessageBox.Show("Desea imprimir las etiquetas", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                proImprimirEtiquetas(1);
                        }
                        break;
                    default:
                        break;
                }
                this.Close();
            }catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Procedimientos y funciones
        private void proEnviarMensaje(object[] objResultado) {
            if (objResultado[0].Equals("ok")) {
                string varNumero = objResultado[1].ToString().Split(':')[0];
                string varMensaje = objResultado[1].ToString().Split(':')[1].Trim();
                this.txtNumero.Text = varNumero;
                XtraMessageBox.Show(varMensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
                XtraMessageBox.Show(objResultado[1].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void proImprimirEtiquetas(int varOpcion) {
            crtEtiquetaCarnesBPM objImpresionEtiquetaBPM;
            int varCodigoBarra;
            DataTable dtValoresEtiqueta;
            switch (varOpcion) {
                case 1: //Cuando mandamos a imprimir despues de guardar
                    foreach (EntCOM_DETGENCODBARRA objFilaDetalle in objDetalle) {
                        varCodigoBarra = clsComEntMercanciasCab.funRecuperarCodigoBarra(txtNomSerie.Text, int.Parse(txtNumero.Text), objFilaDetalle.atrIteCodigo);
                        dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiquetaBPM(varCodigoBarra);

                        objImpresionEtiquetaBPM = new crtEtiquetaCarnesBPM();
                        objImpresionEtiquetaBPM.SetDataSource(dtValoresEtiqueta);
                        objImpresionEtiquetaBPM.PrintOptions.PrinterName = ConfigurationManager.AppSettings["ImpresoraEtiqueta"];
                        objImpresionEtiquetaBPM.PrintToPrinter(objFilaDetalle.atrDetNroImpresion, false, 0, 1);
                    }
                    break;
                case 2: //Cuando mandamos a imprimir linea por linea
                    string varIteCodigo = ((EntCOM_DETGENCODBARRA)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).atrIteCodigo;
                    int varNroImpresion = ((EntCOM_DETGENCODBARRA)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).atrDetNroImpresion;
                    varCodigoBarra = clsComEntMercanciasCab.funRecuperarCodigoBarra(txtNomSerie.Text, int.Parse(txtNumero.Text), varIteCodigo);
                    dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiquetaBPM(varCodigoBarra);

                    objImpresionEtiquetaBPM = new crtEtiquetaCarnesBPM();
                    objImpresionEtiquetaBPM.SetDataSource(dtValoresEtiqueta);
                    objImpresionEtiquetaBPM.PrintOptions.PrinterName = ConfigurationManager.AppSettings["ImpresoraEtiqueta"];
                    objImpresionEtiquetaBPM.PrintToPrinter(varNroImpresion, false, 0, 1);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void bedProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                using (xfrmComLisProveedor frmFormulario = new xfrmComLisProveedor(true)) {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0) {
                        this.bedProveedor.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvCodigo;
                        this.txtProveedor.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvNombre;
                        this.bedProveedor.Focus();
                    }
                    else
                        this.txtProveedor.Text = "";
                }
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedProveedor_EditValueChanged(object sender, EventArgs e) {
            try {
                string varPrvCodigo = this.bedProveedor.Text.Trim();
                if (varPrvCodigo.Length < 9) { this.txtProveedor.Text = ""; return; }
                this.txtProveedor.Text = "";
                foreach (clsComProveedor csRegistro in clsComProveedor.funListar(varPrvCodigo)) 
                    this.txtProveedor.Text = csRegistro.PrvNombre;
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvDetalle_ShowingEditor(object sender, CancelEventArgs e) {
            if (this.grvDetalle.FocusedColumn == colAtrIteCodigo) {
                this.colAtrIteCodigo.OptionsColumn.ReadOnly = false;
                this.gluItem.ImmediatePopup = true;
            } else if (this.grvDetalle.FocusedColumn == colAtrDetLote)
            {
                if (this.grvDetalle.GetRowCellDisplayText(this.grvDetalle.FocusedRowHandle, colAtrDetTieneLote).Equals("Y"))
                    this.colAtrDetLote.OptionsColumn.ReadOnly = false;
                else
                    this.colAtrDetLote.OptionsColumn.ReadOnly = true;
            }
        }
        private void gluItem_Leave(object sender, EventArgs e) {
            try {
                string varIteCodigo = (sender as GridLookUpEdit).Text;
                if (varIteCodigo.Equals("")) return;
                //Instanciamos la clase de items
                List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);
                //Recuperamos la posicion en la que nos encontramos
                int varFila = this.grvDetalle.FocusedRowHandle;
                if (!lisItem.Equals(null)) {
                    foreach (var regItem in lisItem) {
                        this.grvDetalle.SetRowCellValue(varFila, colAtrIteCodigo, regItem.ItemCode);
                        this.grvDetalle.SetRowCellValue(varFila, colAtrIteNombre, regItem.ItemName);
                        this.grvDetalle.SetRowCellValue(varFila, colAtrIteUndInventario, regItem.InvntryUom);
                        this.grvDetalle.SetRowCellValue(varFila, colAtrDetTieneLote, regItem.ManBtchNum);
                        this.grvDetalle.SetRowCellValue(varFila, colAtrDetLote, regItem.ManBtchNum == "Y" ? this.txtLote.Text : "");
                    }
                } else {
                    this.grvDetalle.SetRowCellValue(varFila, colAtrIteNombre, "");
                    this.grvDetalle.SetRowCellValue(varFila, colAtrIteUndInventario, "");
                    this.grvDetalle.SetRowCellValue(varFila, colAtrDetTieneLote, "");
                    this.grvDetalle.SetRowCellValue(varFila, colAtrDetLote, "");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluItem_Popup(object sender, EventArgs e) {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void xfrmComManGenCodigoBarra_KeyDown(object sender, KeyEventArgs e) {
            try { 
                if (e.KeyCode == Keys.Enter) {
                    //Validamos que se ha la operacion de insertar o modificar
                    if (!varOpeCodigo.Equals(1) && !varOpeCodigo.Equals(2)) return;
                    //Validamos que si no esta en la columna nro de impresion no pueda agregar una nueva linea
                    if (this.grvDetalle.FocusedColumn != colAtrDetNroImpresion) return;
                    //Recuperamos la fila seleccionada
                    EntCOM_DETGENCODBARRA objFilaDetalle = (EntCOM_DETGENCODBARRA)this.grvDetalle.GetRow(this.grvDetalle.FocusedRowHandle);
                    int varSecuencia = objDetalle.Max(p => p.atrDetSecuencia);
                    int varPosicionFila = this.grvDetalle.FocusedRowHandle;
                    object varFilaNueva = this.grvDetalle.GetRowCellValue(this.grvDetalle.RowCount - 1, colAtrIteCodigo);

                    //Validamos que los campos ha sido debidamente ingresados
                    string varMensaje = objFilaDetalle.funValidarFila();
                    if (!varMensaje.Equals("")) {
                        string varControl = varMensaje.Split(':')[0];
                        string varError = varMensaje.Split(':')[1].Trim();
                        this.grvDetalle.SetColumnError(this.grvDetalle.Columns[varControl], varError);
                        this.grvDetalle.FocusedColumn = this.grvDetalle.Columns[varControl];
                        return;
                    }

                    if (varFilaNueva == null || varFilaNueva == DBNull.Value) {
                        if (this.grvDetalle.RowCount - 1 == 0)
                            this.objDetalle.Add(new EntCOM_DETGENCODBARRA(0));
                    }
                    else if (this.grvDetalle.FocusedRowHandle == this.grvDetalle.RowCount - 1) {
                        this.objDetalle.Add(new EntCOM_DETGENCODBARRA(varSecuencia));
                    }
                    if (varPosicionFila < 0) {
                        this.grvDetalle.FocusedRowHandle = 0;
                        this.grvDetalle.FocusedColumn = colAtrIteCodigo;
                    }
                    else {
                        this.grvDetalle.FocusedRowHandle = varPosicionFila + 1;
                        this.grvDetalle.FocusedColumn = colAtrIteCodigo;
                    }
                    //Refrescamos el detalle
                    this.grcDetalle.RefreshDataSource();
                }
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtLote_Validating(object sender, CancelEventArgs e) {
            try {
                foreach (EntCOM_DETGENCODBARRA objFilaDetalle in objDetalle)
                    objFilaDetalle.atrDetLote = this.txtLote.Text;
                this.grcDetalle.RefreshDataSource();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ibuImpresion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e){
            proImprimirEtiquetas(2);
        }
        private void smiEliminar_Click(object sender, EventArgs e) {
            try {
                if (this.grvDetalle.IsFocusedView) {
                    EntCOM_DETGENCODBARRA objFilaDetalle = (EntCOM_DETGENCODBARRA)this.grvDetalle.GetRow(this.grvDetalle.FocusedRowHandle);
                    objDetalle.Remove(objFilaDetalle);
                    this.grcDetalle.RefreshDataSource();
                }
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
