using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Granja;
using Umbrella;
using System.Linq;
using umbAplicacion.Inventario.Listado;
using umbNegocio.Inventario;
using DevExpress.XtraGrid.Columns;
using umbAplicacion.Granja.Auxiliar;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManParto : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string varOldAnmAlternativo = "";

        private List<clsGraPartoDet> objDetalle;

        public xfrmGraManParto()
        {
            InitializeComponent();
        }
        public xfrmGraManParto(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Procedimientos heredados
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Registro de parto";
                //Recuperamos de la base de datos la informacion que va hacer utilizada en el formulario
                this.gluChapeta.DataSource = clsGraAnimal.funListar("Where c.Genero = 'HEMBRA' and EstCodigo = 'ACT' and AnmEstCiclo = 'VACIO'");
                this.lueBodega.Properties.DataSource = clsDiccionario.Listar("GRAPARBODEGA");
                //Verificamos la opcion
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
                        this.datFecDesde.EditValue = DateTime.Now;
                        this.lueBodega.ItemIndex = 0;
                        //Debemos instanciar la clase a la grilla para el ingreso de detalles
                        this.objDetalle = new List<clsGraPartoDet>();
                        this.objDetalle.Add(new clsGraPartoDet(0));
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsGraPartoCab csRegistro in clsGraPartoCab.funListar(varRegCodigo)){
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.txtNomSerie.Text = csRegistro.DocNombre;
                            this.txtNumero.Text = csRegistro.CabNumero.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.datFecDesde.EditValue = csRegistro.CabFecDesde;
                            this.datFecHasta.EditValue = csRegistro.CabFecHasta;
                            this.bedItem.Text = csRegistro.IteCodigo;
                            this.txtLote.Text = csRegistro.CabLote;
                            this.lueBodega.EditValue = csRegistro.BodCodigo.ToString();
                            this.memObsDocumento.Text = csRegistro.CabComentario;

                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsGraPartoDet>();
                            clsGraPartoDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia 
                            int varSecuencia = objDetalle.Max(p => p.DetSecuencia);
                            this.objDetalle.Add(new clsGraPartoDet(varSecuencia));
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
                //Eliminamos las filas vacias del detalle 
                objDetalle.RemoveAll(p => p.AnmCodigo.Equals(0));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Validamos que todos los datos se han llenado correctamente en el detalle
                string varMensaje = clsGraPartoDet.funValidarDetalle(objDetalle);
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                //Verificamos si existe un error
                if (!varMensaje.Equals("")) throw new Exception(varMensaje);
                //Asignamos los valores de la propiedades de la clase animal
                var csRegistro = new clsGraPartoCab() {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),

                    CabFecha = (DateTime)datFecha.EditValue,
                    CabFecDesde = (DateTime)datFecDesde.EditValue,
                    CabFecHasta = (DateTime)datFecHasta.EditValue,

                    IteCodigo = this.bedItem.Text,
                    IteNombre = this.txtIteNombre.Text,
                    CabLote = this.txtLote.Text,
                    BodCodigo = this.lueBodega.EditValue.ToString(),
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
        //Evento utilizado cuando el texto es modificado en el control
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
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
        // Evento utilizado cuando hace click en el boton de busqueda
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
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
        //Evento utilizado para desplegar el listado del combo de animales
        private void gluChapeta_Popup(object sender, EventArgs e)
        {
            //Limpiamos todos los filtros que existan en el control gluItem
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        //Evento utilizado cuando sale del foco del control
        private void gluChapeta_Leave(object sender, EventArgs e)
        {
            try
            {
                //Recuperamos en la variable el codigo de la chapeta digitado por el usuario
                string varAnmAlternativo = (sender as GridLookUpEdit).Text;
                //Verificamos que el usuario haya digitado el codigo
                if (varAnmAlternativo.Equals("")) return;
                //Verificamos que exista una modificacion en el codigo de la chapeta
                if (varAnmAlternativo == varOldAnmAlternativo) return;
                //Instanciamos el objeto Animal
                List<clsGraAnimal> lisAnimal = clsGraAnimal.funListar(string.Format("Where a.AnmAlternativo = '{0}'", varAnmAlternativo)).ToListOf<clsGraAnimal>();
                //Verificamos si el animal tiene dosis aplicadas
                int varCuantos = clsGraDosisAplicadas.funListar(lisAnimal[0].AnmCodigo).Count;
                if (varCuantos.Equals(0)) { XtraMessageBox.Show("La madre no puede ser escogida porque no tiene dosis aplicadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  return; }
                //Recuperamos en la variable la fila en la que se encuentra posicionado el usuario
                int varFila = this.grvListado.FocusedRowHandle;
                if (!lisAnimal.Equals(null)) {
                    //Asignamos los valores recuperados a la fila
                    this.grvListado.SetRowCellValue(varFila, colAnmCodigo, lisAnimal[0].AnmCodigo);
                    this.grvListado.SetRowCellValue(varFila, colAnmAlternativo, lisAnimal[0].AnmAlternativo);
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, lisAnimal[0].IteNombre);
                    this.grvListado.SetRowCellValue(varFila, colDetCstInicial, lisAnimal[0].AnmTPValorDepreciable);
                }
                else {
                    //En caso de no existir coincidencias enceramos los datos de la fila
                    this.grvListado.SetRowCellValue(varFila, colAnmCodigo, 0);
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colDetCstInicial, 0);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para el calculo del nro de animales
        private void itxNumero_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos la cantidad digitada por el usuario
                var varCantidad = ((TextEdit)sender).Text;
                if (varCantidad == null) return;
                //Recuperamos la fila seleccionada
                clsGraPartoDet drFila = (clsGraPartoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                //Verificamos si esta posicionado en la columna de nro vivos
                if (this.grvListado.FocusedColumn.Equals(colDetNroVivos))
                    drFila.DetNroVivos = int.Parse(varCantidad.ToString());
                else if (this.grvListado.FocusedColumn.Equals(colDetNroMuertos))
                    drFila.DetNroMuertos = int.Parse(varCantidad.ToString());
                else if (this.grvListado.FocusedColumn.Equals(colDetNroMomificados))
                    drFila.DetNroMomificados = int.Parse(varCantidad.ToString());
                //Asignamos el nro total de animales
                drFila.DetNroTotal = drFila.DetNroVivos + drFila.DetNroMuertos + drFila.DetNroMomificados;
                this.grcListado.RefreshDataSource();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para el calculo del peso del nro de animales
        private void itxDecimalCuatro_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos el peso digitado por el usuario
                var varPeso = ((TextEdit)sender).Text;
                if (varPeso == null) return;
                //Recuperamos la fila seleccionada
                clsGraPartoDet drFila = (clsGraPartoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                //Asignamos el valor del peso a la propiedad pertinente
                drFila.DetTotalKg = decimal.Parse(varPeso);
                //Calculamos el costo promedio de los animales basandonos en los vivos
                drFila.DetPromedioKg = drFila.DetNroVivos > 0 ? decimal.Round(drFila.DetTotalKg / drFila.DetNroVivos, 4) : 0;
                //Actualizamos el detalle
                this.grcListado.RefreshDataSource();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para detectar lo que presiona el usuario en el formulario
        private void xfrmGraManParto_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                //Verificamos que la tecla presionada sea el enter
                if (e.KeyCode.Equals(Keys.Enter)) {
                    //Verificamos que este puesto el focus en el detalle
                    if (!grvListado.IsFocusedView) return;
                    //Recuperamos la columna en la que esta posicionado
                    GridColumn varColumna = this.grvListado.FocusedColumn;
                    this.grvListado.FocusedColumn = colDetSecuencia;
                    this.grvListado.FocusedColumn = varColumna;
                    //Si la columna devuelve un valor nulo salimos del proceso
                    if (this.grvListado.FocusedColumn == null) return;
                    //Verificamos que el usuario este posicionado en la columan de total peso caso contrario salirmos del proceso
                    if (!this.grvListado.FocusedColumn.Equals(colDetTotalKg))
                        return;
                    //Limpiamos todos los errores del detalle de movimientos
                    this.grvListado.ClearColumnErrors();
                    //Recuperamos la fila seleccionada e instanciamos con la clase detalle de inventario
                    clsGraPartoDet objFila = (clsGraPartoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                    //Validamos que los campos ha sido debidamente ingresados
                    string varMensaje = objFila.funValidarFila();
                    if (!varMensaje.Equals("")) {
                        //Separamos la columna que tiene el error
                        string varControl = varMensaje.Split(':')[0];
                        //Separamos el mensaje de error
                        string varError = varMensaje.Split(':')[1].Trim();
                        //Activamos el error
                        this.grvListado.SetColumnError(this.grvListado.Columns[varControl], varError);
                        //Posicionamos el cursor en la columna del error
                        this.grvListado.FocusedColumn = this.grvListado.Columns[varControl];
                        return;
                    }
                    //Agregamos una nueva linea
                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1)) {
                        int varPosicion = this.grvListado.FocusedRowHandle;
                        int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString());
                        this.objDetalle.Add(new clsGraPartoDet(varLinea));
                        this.grcListado.RefreshDataSource();
                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        this.grvListado.FocusedColumn = colAnmAlternativo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para saber cuando el usuario toma el focus del detalle
        private void grvListado_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try {
                //Recuperamos los valores antiguos para cuando haya una modificacion
                if (this.grvListado.FocusedColumn.Equals(colAnmAlternativo))
                    varOldAnmAlternativo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colAnmAlternativo).ToString();
                //En caso de que el usuario este posicionado en la columna item abrir la opciones de items
                if (this.grvListado.FocusedColumn.Equals(colAnmAlternativo)) {
                    if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0) {
                        this.colAnmAlternativo.OptionsColumn.ReadOnly = false;
                        this.gluChapeta.ImmediatePopup = true;
                    }
                    else
                        this.colAnmAlternativo.OptionsColumn.ReadOnly = true;
                }
                if (this.grvListado.FocusedColumn.Equals(colDetFecNacimiento) ||
                     this.grvListado.FocusedColumn.Equals(colDetNroVivos) ||
                     this.grvListado.FocusedColumn.Equals(colDetNroMuertos) ||
                     this.grvListado.FocusedColumn.Equals(colDetNroMomificados) ||
                     this.grvListado.FocusedColumn.Equals(colDetTotalKg)){
                    string varEstCodigo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colEstCodigo).ToString();
                    if (varEstCodigo.ToUpper().Equals("")) {
                        this.colDetFecNacimiento.OptionsColumn.ReadOnly = true;
                        this.colDetNroVivos.OptionsColumn.ReadOnly = true;
                        this.colDetNroMuertos.OptionsColumn.ReadOnly = true;
                        this.colDetNroMomificados.OptionsColumn.ReadOnly = true;
                        this.colDetTotalKg.OptionsColumn.ReadOnly = true;
                    }
                    else {
                        this.colDetFecNacimiento.OptionsColumn.ReadOnly = false;
                        this.colDetNroVivos.OptionsColumn.ReadOnly = false;
                        this.colDetNroMuertos.OptionsColumn.ReadOnly = false;
                        this.colDetNroMomificados.OptionsColumn.ReadOnly = false;
                        this.colDetTotalKg.OptionsColumn.ReadOnly = false;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Evento utilizado para obtener las dosis aplicadas a la cerda
        private void ibuDosis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Recuperamos la fila seleccionada e instanciamos con la clase detalle parto
                clsGraPartoDet objFila = (clsGraPartoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                //Verificamos si existe una chapeta seleccionada
                if (objFila.AnmCodigo.Equals(0)) return;
                xfrmGraAuxDosis objFormulario;
                if (objFila.EstCodigo.Equals("")) objFormulario = new xfrmGraAuxDosis(objFila.AnmCodigo, objFila.AnmAlternativo, objFila.IteNombre, true, true, 0);
                else objFormulario = new xfrmGraAuxDosis(objFila.AnmCodigo, objFila.AnmAlternativo, objFila.IteNombre, true, false, int.Parse(this.txtCodigo.Text));
                objFormulario.StartPosition = FormStartPosition.CenterParent;
                objFormulario.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        

    }
}
