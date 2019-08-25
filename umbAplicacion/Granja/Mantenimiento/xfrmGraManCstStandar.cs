using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio.Finanzas;
using umbNegocio.Granja;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using umbNegocio.Inventario;
using umbAplicacion.Inventario.Listado;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManCstStandar : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string varOldCueFormato = "";

        private List<clsGraCstStandarDet> objDetalle;

        public xfrmGraManCstStandar()
        {
            InitializeComponent();
        }
        public xfrmGraManCstStandar(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varDocCodigo = 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Procedimientos heredados
        //Procedimiento para iniciar el formulario
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Costo estandar";
                //Recuperamos de la base de datos la informacion que va hacer utilizada en el formulario
                this.gluCtaContable.DataSource = clsFinPlaCuenta.funListar();
                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.datFecDesde.EditValue = DateTime.Now;
                        //Debemos instanciar la clase a la grilla para el ingreso de detalles
                        this.objDetalle = new List<clsGraCstStandarDet>();
                        this.objDetalle.Add(new clsGraCstStandarDet(0));
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsGraCstStandarCab csRegistro in clsGraCstStandarCab.funListar(varRegCodigo)) {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.datFecDesde.EditValue = csRegistro.CabFechaDesde;
                            this.datFecHasta.EditValue = csRegistro.CabFechaHasta;
                            this.bedItem.Text = csRegistro.IteCodigo;
                            this.memObsDocumento.Text = csRegistro.CabComentario;
                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsGraCstStandarDet>();
                            clsGraCstStandarDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia 
                            int varSecuencia = objDetalle.Max(p => p.DetSecuencia);
                            this.objDetalle.Add(new clsGraCstStandarDet(varSecuencia));
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
        //Operacion de grabar
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                //Eliminamos las filas vacias 
                objDetalle.RemoveAll(p => p.CueCodigo.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Validamos que todos los datos se han llenado correctamente en el detalle
                string varMensaje = clsGraCstStandarDet.funValidarDetalle(objDetalle);
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                //Verificamos si existe un error
                if (!varMensaje.Equals("")) throw new Exception(varMensaje);
                //Asignamos los valores de la propiedades de la clase instanciada
                var csRegistro = new clsGraCstStandarCab() {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    
                    CabFecha = (DateTime)datFecha.EditValue,
                    CabFechaDesde = (DateTime)datFecDesde.EditValue,
                    CabFechaHasta = this.datFecHasta.EditValue == null ? (DateTime?)null : DateTime.Parse(this.datFecHasta.EditValue.ToString()),

                    IteCodigo = this.bedItem.Text,
                    IteNombre = this.txtIteNombre.Text,
                    CabComentario = this.memObsDocumento.Text,
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
        #endregion
        #region Eventos del formulario
        private void xfrmGraManCstStandar_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode.Equals(Keys.Enter)) {
                    if (!grvListado.IsFocusedView) return;
                    GridColumn varColumna = this.grvListado.FocusedColumn;
                    this.grvListado.FocusedColumn = colDetSecuencia;
                    this.grvListado.FocusedColumn = varColumna;

                    if (this.grvListado.FocusedColumn == null) return;
                    if (!this.grvListado.FocusedColumn.Equals(colDetValor))
                        return;
                    //Limpiamos todos los errores del detalle de movimientos
                    this.grvListado.ClearColumnErrors();
                    //Recuperamos la fila seleccionada e instanciamos con la clase detalle de inventario
                    clsGraCstStandarDet objFila = (clsGraCstStandarDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
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
                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1)) {
                        int varPosicion = this.grvListado.FocusedRowHandle;
                        int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString());
                        this.objDetalle.Add(new clsGraCstStandarDet(varLinea));
                        this.grcListado.RefreshDataSource();
                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        this.grvListado.FocusedColumn = colCueFormato;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluCtaContable_Popup(object sender, EventArgs e)
        {
            //Limpiamos todos los filtros que existan en el control gluItem
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluCtaContable_Leave(object sender, EventArgs e)
        {
            try {
                //Recuperamos en la variable el codigo del item digitado por el usuario
                string varCueFormato = (sender as GridLookUpEdit).Text;
                //Verificamos que el usuario haya digitado el codigo
                if (varCueFormato.Equals("")) return;
                //Verificamos que exista una modificacion en el codigo del item
                if (varCueFormato == varOldCueFormato) return;
                //Instanciamos el objeto Item
                List<clsFinPlaCuenta> objLista = clsFinPlaCuenta.funListar(varCueFormato);
                //Recuperamos en la variable la fila en la que se encuentra posicionado el usuario
                int varFila = this.grvListado.FocusedRowHandle;
                if (!objLista.Equals(null)) {
                    //Asignamos los valores recuperados a la fila
                    this.grvListado.SetRowCellValue(varFila, colCueCodigo, objLista[0].CueCodigo);
                    this.grvListado.SetRowCellValue(varFila, colCueNombre, objLista[0].CueNombre);
                    this.grvListado.SetRowCellValue(varFila, colCueFormato, objLista[0].CueFormato);
                }
                else {
                    //En caso de no existir coincidencias enceramos los datos de la fila
                    this.grvListado.SetRowCellValue(varFila, colCueNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colCueFormato, "");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para verificar si los datos han sido modificados antes de la edicion
        private void grvListado_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                string varEstado = "";
                //Recuperamos los valores antiguos para cuando haya una modificacion
                if (this.grvListado.FocusedColumn.Equals(colCueFormato))
                    varOldCueFormato = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colCueFormato).ToString();
                //En caso de que el usuario este posicionado en la columna item abrir la opciones de items
                if (this.grvListado.FocusedColumn.Equals(colCueFormato)){
                    varEstado = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colEstCodigo).ToString();
                    if (varEstado.ToUpper().Equals("ACT")) 
                        this.colCueFormato.OptionsColumn.ReadOnly = true;
                    else {
                        if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0) {
                            this.colCueFormato.OptionsColumn.ReadOnly = false;
                            this.gluCtaContable.ImmediatePopup = true;
                        }
                        else
                            this.colCueFormato.OptionsColumn.ReadOnly = true;
                    }
                }
                //Verificamos que el detalle no haya sido activado de lo contrario no se puede modificar 
                if (this.grvListado.FocusedColumn.Equals(colDetValor)){
                    varEstado = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colEstCodigo).ToString();
                    if (varEstado.ToUpper().Equals("ACT"))
                        this.colCueFormato.OptionsColumn.ReadOnly = true;
                    else
                        this.colCueFormato.OptionsColumn.ReadOnly = false;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try{
                string varIteCodigo = this.bedItem.Text.Trim();

                this.txtIteNombre.Text = "";
                if (varIteCodigo.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)){
                    this.bedItem.EditValue = csRegistro.ItemCode;
                    this.txtIteNombre.Text = csRegistro.ItemName;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
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
        #endregion
    }
}
