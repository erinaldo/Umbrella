using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Finanzas.Listado;
using umbNegocio;
using umbNegocio.Costos;
using umbNegocio.Finanzas;
using System.Linq;

namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManNormaReparto : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        List<clsCosDetPlanCuenta> dtDetPlanCuenta;
        List<clsCosDetCenCosto> dtDetCenCosto;
        clsCosNormaReparto objNormaReparto = new clsCosNormaReparto();

        int varCdpLineaCopiar = 0;
        public xfrmCosManNormaReparto() { InitializeComponent(); }
        public xfrmCosManNormaReparto(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Mantenimiento de normas de reparto";
                switch (varOpeCodigo) {
                    case 1:
                        //Iniciamos los campos para poder ingresar la informacion
                        this.proIniciarCampos();
                        break;
                    case 2:
                    case 4:
                        //Inicializamos el plan de cuentas y centros de costo para los detalles
                        this.gluPlanCuenta.DataSource = clsFinPlaCuenta.funListar();
                        this.gluCenCosto.DataSource = clsFinCenCosto.funListar();

                        objNormaReparto = new clsCosNormaReparto();
                        objNormaReparto.metConsultar(varRegCodigo);
                        if (objNormaReparto.DetCenCosto != null) {
                            this.txtCodigo.Text = objNormaReparto.CcrCodigo.ToString();
                            this.txtDescripcion.Text = objNormaReparto.CcrDescripcion;
                            this.bedCcoCodigo.EditValue = objNormaReparto.CcoCodigo;
                            this.txtCcoNombre.Text = objNormaReparto.CcoNombre;
                            this.chkActivo.Checked = objNormaReparto.CcrActivo.Equals("Activo") ? true : false;
                            //Plan de cuenta
                            dtDetPlanCuenta = new List<clsCosDetPlanCuenta>();
                            dtDetPlanCuenta = objNormaReparto.DetPlanCuenta;
                            this.grcDetPlanCuenta.DataSource = dtDetPlanCuenta;
                            //Centros de costo
                            dtDetCenCosto = new List<clsCosDetCenCosto>();
                            dtDetCenCosto = objNormaReparto.DetCenCosto;
                            this.grcDetCenCosto.DataSource = dtDetCenCosto;
                            //Verificamos si tiene mas de una linea el detalle 
                            if (this.grvDetPlanCuenta.RowCount > 1) {
                                this.grvDetPlanCuenta.FocusedRowHandle = 1;
                                this.grvDetPlanCuenta.FocusedRowHandle = 0;
                            }
                        }
                        break;
                }
                var csValidaciones = new Umbrella.clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void proIniciarCampos() {
            this.txtCodigo.Text = "0";
            this.txtDescripcion.Text = "";
            this.bedCcoCodigo.EditValue = null;
            this.chkActivo.Checked = true;
            //Creamos los datatables que vamos a utilizar en el formulario
            //Plan de cuentas
            dtDetPlanCuenta = new List<clsCosDetPlanCuenta>();
            dtDetPlanCuenta.Add(new clsCosDetPlanCuenta(1, "", 0, "", ""));
            this.grcDetPlanCuenta.DataSource = dtDetPlanCuenta;
            //Centros de costo
            dtDetCenCosto = new List<clsCosDetCenCosto>();
            dtDetCenCosto.Add(new clsCosDetCenCosto(1, 1, "", "", 0, false));
            this.grcDetCenCosto.DataSource = dtDetCenCosto;
            //Inicializamos el plan de cuentas y centros de costo para los detalles
            this.gluPlanCuenta.DataSource = clsFinPlaCuenta.funListar();
            this.gluCenCosto.DataSource = clsFinCenCosto.funListar();
        }
        private void bedCcoCodigo_EditValueChanged(object sender, EventArgs e){
            try {
                string varCcoCodigo = this.bedCcoCodigo.Text.Trim();
                this.txtCcoNombre.Text = "";

                if (varCcoCodigo.Length.Equals(4)) {
                    foreach(clsFinCenCosto csRegistro in clsFinCenCosto.funListar(varCcoCodigo)){
                        this.bedCcoCodigo.EditValue = csRegistro.CcoCodigo;
                        this.txtCcoNombre.Text = csRegistro.CcoNombre;
                    }
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void bedCcoCodigo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de items
                using (xfrmFinLisCenCosto frmFormulario = new xfrmFinLisCenCosto(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de item
                        this.bedCcoCodigo.Text = ((clsFinCenCosto)frmFormulario.DrVarFila[0]).CcoCodigo;
                        this.txtCcoNombre.Text = ((clsFinCenCosto)frmFormulario.DrVarFila[0]).CcoNombre;
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void gluPlanCuenta_Leave(object sender, EventArgs e)
        {
            try {
                string varCccFormato = (sender as GridLookUpEdit).Text;
                if (String.IsNullOrEmpty(varCccFormato)) return; //Verificamos que si el valor del campo es nulo o vacio ya no siga ejecutando la lineas de codigo
                //Posicion en la grilla
                int varPosicion = this.grvDetPlanCuenta.FocusedRowHandle;
                int varCdpLinea = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, colCdpLineaPC).ToString());
                int varCuantos = dtDetPlanCuenta.Count<clsCosDetPlanCuenta>(p => p.CccFormato == varCccFormato && p.CdpLinea != varCdpLinea);
                //Validamos que si existe no lo vuelva a ingresar
                if (!varCuantos.Equals(0)) {
                    clsMensajesSistema.metMsgError("La cuenta contable ya fue ingresada");
                    this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccFormato, "");
                    this.grvDetPlanCuenta.FocusedRowHandle = varPosicion + 1;
                    this.grvDetPlanCuenta.FocusedColumn = colCccFormato;
                    return;
                }
                var lisItem = clsFinPlaCuenta.funListar(varCccFormato);//Recuperamos la fila de la cuenta que estamos consultando
                if (lisItem != null) {
                    foreach(var varFila in lisItem) {
                        this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccFormato, varFila.CueFormato);
                        this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccNombre, varFila.CueNombre);
                        this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccCodigo, varFila.CueCodigo);
                    }
                }
                else {
                    this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccFormato, "");
                    this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccNombre, "");
                    this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCccCodigo, "");
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void gluPlanCuenta_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void grvDetPlanCuenta_ShownEditor(object sender, EventArgs e)
        {
            try {
                if (this.grvDetPlanCuenta.FocusedColumn.Equals(colCccFormato)) {
                    if (this.grvDetPlanCuenta.FocusedRowHandle.Equals(this.grvDetPlanCuenta.RowCount - 1) || this.grvDetPlanCuenta.FocusedRowHandle < 0){
                        this.gluPlanCuenta.ImmediatePopup = true;
                        //Recuperamos el nombre de la cuenta contable
                        String varCentroCosto = this.bedCcoCodigo.EditValue == null ? "" : this.bedCcoCodigo.EditValue.ToString();
                        if (!varCentroCosto.Equals(""))
                            this.colCccFormato.OptionsColumn.ReadOnly = false;
                        else
                            this.colCccFormato.OptionsColumn.ReadOnly = true;
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void grvDetPlanCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.Equals(Keys.Enter)) {
                    //Posicionamos el cursor en la columna nombre de la cuenta contable
                    this.grvDetPlanCuenta.FocusedColumn = colCccNombre;
                    //Posicion en la grilla
                    int varPosicion = this.grvDetPlanCuenta.FocusedRowHandle;
                    //Recuperamos el valor del nro de linea
                    int varLinea = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, colCdpLineaPC).ToString());
                    //Recuperamos el nombre de la cuenta contable
                    String varCuentaContable = this.grvDetPlanCuenta.GetRowCellValue(varPosicion, colCccNombre).ToString();

                    if (varPosicion.Equals(this.grvDetPlanCuenta.RowCount - 1) && !varCuentaContable.Equals("")) {
                        this.dtDetPlanCuenta.Add(new clsCosDetPlanCuenta(varLinea + 1, "", 0, "", ""));
                        this.dtDetCenCosto.Add(new clsCosDetCenCosto(varLinea + 1, 1, "", "", 0, false));
                        this.grvDetPlanCuenta.FocusedRowHandle = varPosicion + 1;
                        this.grvDetPlanCuenta.FocusedColumn = colCccFormato;
                        this.grvDetPlanCuenta.RefreshData();
                    }
                    else {
                        this.grvDetPlanCuenta.FocusedRowHandle = this.grvDetPlanCuenta.RowCount - 1;
                        this.grvDetPlanCuenta.FocusedColumn = colCccFormato;
                    }
                }
                
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void grvDetPlanCuenta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //Recuperamos el valor del nro de linea
            int varLinea = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(e.FocusedRowHandle,"CdpLinea").ToString());
            if (dtDetCenCosto != null) this.grcDetCenCosto.DataSource = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea.Equals(varLinea));
            this.grvDetCenCosto.RefreshData();
        }
        private void gluCenCosto_Leave(object sender, EventArgs e)
        {
            try {
                string varCcoCodigo = (sender as GridLookUpEdit).Text;
                if (String.IsNullOrEmpty(varCcoCodigo)) return; //Verificamos que si el valor del campo es nulo o vacio ya no siga ejecutando la lineas de codigo
                var lisCentroCosto = clsFinCenCosto.funListar(varCcoCodigo);//Recuperamos la fila del centro de costos que estamos consultando
                //Posicion en la grilla
                int varPosicion = this.grvDetCenCosto.FocusedRowHandle;
                int varCdpLinea = int.Parse(this.grvDetCenCosto.GetRowCellValue(varPosicion, colCdpLineaCC).ToString());
                int varCdeLinea = int.Parse(this.grvDetCenCosto.GetRowCellValue(varPosicion, colCdeLineaCC).ToString());
                int varCuantos = dtDetCenCosto.Count<clsCosDetCenCosto>(p => p.CcoCodigo.Equals(varCcoCodigo) && p.CdpLinea.Equals(varCdpLinea) && p.CdeLinea != varCdeLinea);
                //Validamos que si existe no lo vuelva a ingresar
                if (!varCuantos.Equals(0)) {
                    clsMensajesSistema.metMsgError("El centro de costo ya fue ingresado");
                    this.grvDetCenCosto.SetRowCellValue(varPosicion, colCcoCodigo, "");
                    this.grvDetCenCosto.FocusedRowHandle = varPosicion + 1;
                    this.grvDetCenCosto.FocusedColumn = colCcoCodigo;
                    return;
                }
                if (lisCentroCosto != null) {
                    foreach (var varFila in lisCentroCosto) {
                        this.grvDetCenCosto.SetRowCellValue(varPosicion, colCcoCodigo, varFila.CcoCodigo);
                        this.grvDetCenCosto.SetRowCellValue(varPosicion, colCcoNombre, varFila.CcoNombre);
                    }
                }
                else {
                    this.grvDetCenCosto.SetRowCellValue(varPosicion, colCcoCodigo, "");
                    this.grvDetCenCosto.SetRowCellValue(varPosicion, colCcoNombre, "");
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void gluCenCosto_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void grvDetCenCosto_ShownEditor(object sender, EventArgs e)
        {
            try {
                if (this.grvDetCenCosto.FocusedColumn.Equals(colCcoCodigo)) {
                    if (this.grvDetCenCosto.FocusedRowHandle.Equals(this.grvDetCenCosto.RowCount - 1) || this.grvDetCenCosto.FocusedRowHandle < 0) {
                        this.gluCenCosto.ImmediatePopup = true;
                        //Recuperamos el nombre de la cuenta contable
                        String varCuentaContable = this.grvDetPlanCuenta.GetRowCellValue(this.grvDetPlanCuenta.FocusedRowHandle, colCccNombre).ToString();
                        if (!varCuentaContable.Equals(""))
                            this.colCcoCodigo.OptionsColumn.ReadOnly = false;
                        else
                            this.colCcoCodigo.OptionsColumn.ReadOnly = true;
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void grvDetCenCosto_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.Equals(Keys.Enter)) {
                    //Posicionamos el cursor en la columna nombre del centro de costo
                    this.grvDetCenCosto.FocusedColumn = colCcoNombre;
                    //Posicion en la grilla
                    int varPosicion = this.grvDetCenCosto.FocusedRowHandle;
                    //Recuperamos el valor del nro de linea del centro de costo y cuenta contable
                    int varLineaPC = int.Parse(this.grvDetCenCosto.GetRowCellValue(varPosicion, colCdpLineaCC).ToString());
                    int varLineaCC = int.Parse(this.grvDetCenCosto.GetRowCellValue(varPosicion, colCdeLineaCC).ToString());
                    //Recuperamos el nombre del centro de costo
                    String varCentroCosto = this.grvDetCenCosto.GetRowCellValue(varPosicion, colCcoNombre).ToString();

                    if (varPosicion.Equals(this.grvDetCenCosto.RowCount - 1) && !varCentroCosto.Equals("")) {
                        this.dtDetCenCosto.Add(new clsCosDetCenCosto(varLineaPC, varLineaCC + 1, "", "", 0, false));
                        this.grcDetCenCosto.DataSource = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea.Equals(varLineaPC));
                        this.grvDetCenCosto.FocusedRowHandle = varPosicion + 1;
                        this.grvDetCenCosto.FocusedColumn = colCcoCodigo;
                        this.grvDetCenCosto.RefreshData();
                    }
                    else {
                        this.grvDetCenCosto.FocusedRowHandle = this.grvDetCenCosto.RowCount - 1;
                        this.grvDetCenCosto.FocusedColumn = colCcoCodigo;
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void itePorcentaje_Leave(object sender, EventArgs e)
        {
            try {
                int varPosicion = this.grvDetPlanCuenta.FocusedRowHandle;
                int varCdpLinea = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, colCdpLineaCC).ToString());
                decimal varSuma = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea == varCdpLinea).Sum<clsCosDetCenCosto>(p => p.CdePorcentaje);
                this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCdpPorcentaje, decimal.Parse(String.Format("{0:0.00}", varSuma)));
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try {
                int varCcrCodigo = int.Parse(this.txtCodigo.Text);
                String varCcrDescripcion = this.txtDescripcion.Text;
                String varCcoCodigo = this.bedCcoCodigo.EditValue == null ? "" : this.bedCcoCodigo.EditValue.ToString();
                String varCcoNombre = this.txtCcoNombre.Text;
                String varCcrActivo = this.chkActivo.Checked ? "Activo" : "Inactivo";
                //Recuperamos y validamos los detalles del plan de cuenta
                List<clsCosDetPlanCuenta> objDetPlanCuenta = dtDetPlanCuenta.Where<clsCosDetPlanCuenta>(p => p.CccNombre != "").ToList();
                //Recuperamos y validamos los detalles del centro de costo
                List<clsCosDetCenCosto> objDetCenCosto = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CcoNombre != "").ToList();
                clsCosNormaReparto objNormaReparto = new clsCosNormaReparto(varCcrCodigo, varCcrDescripcion, varCcrActivo, varCcoCodigo, varCcoNombre, objDetPlanCuenta, objDetCenCosto);
                int varResultado = varOpeCodigo.Equals(1) ? objNormaReparto.metInsertar() : objNormaReparto.metModificar();
                if (varResultado >= 0) {
                    if (varOpeCodigo.Equals(1)) 
                        clsMensajesSistema.metMsgInformativo(string.Format(clsMensajesSistema.msgGuardar, varResultado));
                    else if (varOpeCodigo.Equals(2))
                        clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgActualizar);
                    this.Close();
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void smiEliminar_Click(object sender, EventArgs e) {
            try {
                if (this.grvDetPlanCuenta.IsFocusedView) {
                    int varPosicionSiguiente = this.grvDetPlanCuenta.FocusedRowHandle + 1;
                    int varCdpLinea = this.grvDetPlanCuenta.GetRowCellValue(varPosicionSiguiente, "CdpLinea") == null ? 1 : int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicionSiguiente, "CdpLinea").ToString());
                    clsCosDetPlanCuenta objFila = (clsCosDetPlanCuenta)this.grvDetPlanCuenta.GetRow(this.grvDetPlanCuenta.FocusedRowHandle);
                    dtDetPlanCuenta.Remove(objFila);
                    dtDetCenCosto.RemoveAll(p => p.CdpLinea == objFila.CdpLinea);
                    if (dtDetPlanCuenta.Count == 0) {
                        dtDetPlanCuenta.Add(new clsCosDetPlanCuenta(1, "", 0, "", ""));
                        dtDetCenCosto.Add(new clsCosDetCenCosto(1, 1, "", "", 0, false));
                    }
                    if (dtDetCenCosto != null) this.grcDetCenCosto.DataSource = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea.Equals(varCdpLinea));
                    this.grvDetPlanCuenta.RefreshData();
                    this.grvDetCenCosto.RefreshData();
                }
                else if (this.grvDetCenCosto.IsFocusedView) {
                    clsCosDetCenCosto objFila = (clsCosDetCenCosto)this.grvDetCenCosto.GetRow(this.grvDetCenCosto.FocusedRowHandle);
                    dtDetCenCosto.Remove(objFila);
                    if (dtDetCenCosto.Count<clsCosDetCenCosto>(p => p.CdpLinea == objFila.CdpLinea) == 0)  dtDetCenCosto.Add(new clsCosDetCenCosto(objFila.CdpLinea, 1, "", "", 0, false));
                    if (dtDetCenCosto != null) this.grcDetCenCosto.DataSource = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea.Equals(objFila.CdpLinea));
                    this.grvDetCenCosto.RefreshData();
                    decimal varSuma = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea == objFila.CdpLinea).Sum<clsCosDetCenCosto>(p => p.CdePorcentaje);
                    this.grvDetPlanCuenta.SetRowCellValue(this.grvDetPlanCuenta.FocusedRowHandle, colCdpPorcentaje, decimal.Parse(String.Format("{0:0.00}", varSuma)));
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void gluPlanCuenta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Search) {
                    //Instanciamos al formulario listado de plan de cuentas
                    using (xfrmFinLisPlaCuenta frmFormulario = new xfrmFinLisPlaCuenta(true)) {
                        frmFormulario.ShowDialog();
                        if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                            //Asignamos los valores obtenidos del listado
                            int varPosicion = this.grvDetPlanCuenta.RowCount - 1;
                            String varCccNombre = this.grvDetPlanCuenta.GetRowCellValue(varPosicion, "CccNombre").ToString();
                            clsCosDetPlanCuenta objFila = (clsCosDetPlanCuenta)this.grvDetPlanCuenta.GetRow(varPosicion);
                            int varCdpLinea = 0;
                            if (varCccNombre.Equals("")) {
                                varCdpLinea = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, "CdpLinea").ToString());
                                this.dtDetPlanCuenta.Remove(objFila);
                                this.dtDetCenCosto.RemoveAll(p => p.CdpLinea == varCdpLinea);
                            }
                            varCdpLinea = (this.dtDetPlanCuenta.Count.Equals(0) ? 0 : this.dtDetPlanCuenta.Max<clsCosDetPlanCuenta>(p => p.CdpLinea)) + 1;
                            foreach (clsFinPlaCuenta varFila in frmFormulario.DrVarFila) {
                                if (dtDetPlanCuenta.Where<clsCosDetPlanCuenta>(p => p.CccCodigo == varFila.CueCodigo).Count().Equals(0)) {
                                    dtDetPlanCuenta.Add(new clsCosDetPlanCuenta(varCdpLinea, varFila.CueCodigo, 0, varFila.CueNombre, varFila.CueFormato));
                                    dtDetCenCosto.Add(new clsCosDetCenCosto(varCdpLinea, 1, "", "", 0, false));
                                    varCdpLinea++;
                                }
                            }
                            grvDetPlanCuenta.RefreshData();
                            this.grvDetPlanCuenta.FocusedRowHandle = this.grvDetPlanCuenta.RowCount - 1;
                            this.grvDetPlanCuenta.FocusedColumn = colCccNombre;
                            this.grvDetPlanCuenta.FocusedColumn = colCccFormato;

                        }
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void cmsmenu_Opening(object sender, CancelEventArgs e) {
            if (grvDetPlanCuenta.IsFocusedView) {
                smiCopiar.Enabled = true;
                smiPegar.Enabled = true;
            } else {
                smiCopiar.Enabled = false;
                smiPegar.Enabled = false;
            }

        }
        private void smiCopiar_Click(object sender, EventArgs e) {
            try {
                int varPosicion = this.grvDetPlanCuenta.FocusedRowHandle;
                varCdpLineaCopiar = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, "CdpLinea").ToString());
                int varCuantos = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea == varCdpLineaCopiar && p.CcoNombre != "").Count();
                if (varCuantos.Equals(0)) { clsMensajesSistema.metMsgError("No existen centros de costo en la cuenta seleccionada"); varCdpLineaCopiar = 0;  }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void smiPegar_Click(object sender, EventArgs e) {
            try {
                foreach (int varPosicion in this.grvDetPlanCuenta.GetSelectedRows()) {
                    int varCdpLineaPegar = int.Parse(this.grvDetPlanCuenta.GetRowCellValue(varPosicion, "CdpLinea").ToString());
                    this.dtDetCenCosto.RemoveAll(p => p.CdpLinea == varCdpLineaPegar);
                    int i = 1;
                    List<clsCosDetCenCosto> objTemporal = this.dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea == varCdpLineaCopiar).ToList<clsCosDetCenCosto>();
                    foreach (clsCosDetCenCosto varFila in objTemporal) {
                        dtDetCenCosto.Add(new clsCosDetCenCosto(varCdpLineaPegar, i, varFila.CcoCodigo, varFila.CcoNombre, varFila.CdePorcentaje, varFila.CdeDiferencia));
                        i++;
                    }
                    grvDetCenCosto.RefreshData();
                    if (dtDetCenCosto != null) this.grcDetCenCosto.DataSource = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea.Equals(varCdpLineaPegar));
                    decimal varSuma = dtDetCenCosto.Where<clsCosDetCenCosto>(p => p.CdpLinea == varCdpLineaPegar).Sum<clsCosDetCenCosto>(p => p.CdePorcentaje);
                    this.grvDetPlanCuenta.SetRowCellValue(varPosicion, colCdpPorcentaje, decimal.Parse(String.Format("{0:0.00}", varSuma)));
                }
                this.grvDetPlanCuenta.ClearSelection();
                
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
