using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Logistica.Listado;
using umbNegocio;
using umbNegocio.Logistica;

using System.Linq;
using DevExpress.XtraEditors;
using umbNegocio.Seguridad;

namespace umbAplicacion.Logistica.Mantenimiento
{
    public partial class xfrmLogManGuiaValorada : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento {
        private List<clsLogDetGuiaValorada> objDetalle;

        public xfrmLogManGuiaValorada() { InitializeComponent(); }
        public xfrmLogManGuiaValorada(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                this.Text = "Mantenimiento de cantidades permitidas en facturación";
                this.lueRuta.Properties.DataSource = daoLogRutGuia.getInstance().metListar();
                switch (varOpeCodigo) {
                    case 1:
                        this.txtCodigo.Text = "";
                        this.txtValor.EditValue = 0;
                        this.datFecha.EditValue = DateTime.Now;
                        this.lueRuta.ItemIndex = 0;
                        proCargarDetalle();
                        this.chkAgrupado.Checked = false;
                        break;
                    case 2:
                        clsLogGuiaValorada objRegistro = daoLogGuiaValorada.getInstance().metListar(varRegCodigo);
                        if (objRegistro != null) {
                            this.txtCodigo.Text = objRegistro.AtrCabCodigo.ToString();
                            this.datFecha.EditValue = objRegistro.AtrCabFecha;
                            this.txtValor.Text = objRegistro.AtrCabValor.ToString();
                            this.lueRuta.EditValue = objRegistro.AtrCabRuta.AtrRguCodigo;
                            objDetalle = objRegistro.AtrDetalle;

                            this.grcDetalle.DataSource = objDetalle;
                        }
                        break;
                }

                var csValidaciones = new Umbrella.clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proGrabar() {
            base.proGrabar();
            try {
                int varId = this.txtCodigo.Text == "" ? 0 : int.Parse(this.txtCodigo.Text);
                DateTime varFecha = (DateTime)this.datFecha.EditValue;
                decimal varValor = decimal.Parse(this.txtValor.Text);
                Boolean varAgrupado = chkAgrupado.Checked;
                clsLogRutGuia varRuta = daoLogRutGuia.getInstance().metListar(int.Parse(this.lueRuta.EditValue.ToString()));
                if (varAgrupado)
                    foreach (int varPosicion in this.grvDetalle.GetSelectedRows()) {
                        ((clsLogDetGuiaValorada)this.grvDetalle.GetRow(varPosicion)).AtrDetValor = double.Parse(varValor.ToString());
                    }
                objDetalle.RemoveAll(p => p.AtrDetValor == 0);
                String varResultado = daoLogGuiaValorada.getInstance().metInsertar(new clsLogGuiaValorada(varId, varFecha, varAgrupado, varValor, varRuta, objDetalle));
                if (varResultado.Equals("Ok")) {
                    if (varOpeCodigo.Equals(1))
                        clsMensajesSistema.metMsgInformativo("Registro ingresado con exito");
                    else if (varOpeCodigo.Equals(2))
                        clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgActualizar);
                    this.Close();
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            try {
                using (xfrmLogLisGuiaRemision frmFormulario = new xfrmLogLisGuiaRemision(true)) {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0) {
                        if (objDetalle == null) { objDetalle = new List<clsLogDetGuiaValorada>(); this.grcDetalle.DataSource = objDetalle; }
                        int varSecuencia = objDetalle.Count.Equals(0) ? 0  : objDetalle.Max(p => p.AtrDetSecuencia);
                        foreach (clsLogGuiaRemisionCab drFilaCabecera in frmFormulario.DrVarFila) {
                            if (objDetalle.Where(p => p.AtrDetCabGuia == drFilaCabecera.CabCodigo).Count() == 0) { 
                                int atrDetCabGuia = drFilaCabecera.CabCodigo;
                                String atrDetDocNombre = drFilaCabecera.DocNombre;
                                int atrDetCabNumero = drFilaCabecera.CabNumero;
                                DateTime atrDetCabFecha = drFilaCabecera.CabFecha;
                                String atrDetChfNombre = drFilaCabecera.ChfNombre;
                                String atrDetAyuNombre = drFilaCabecera.AyuNombre;
                                String atrDetTrnPlaca = drFilaCabecera.TrnPlaca;
                                objDetalle.Add(new clsLogDetGuiaValorada(++varSecuencia, atrDetCabGuia, atrDetDocNombre, atrDetCabNumero, atrDetCabFecha, atrDetChfNombre, atrDetAyuNombre, atrDetTrnPlaca, 0));
                            }
                        }
                        this.grcDetalle.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            try {
                clsLogDetGuiaValorada objFilaDetalle = (clsLogDetGuiaValorada) grvDetalle.GetRow(this.grvDetalle.FocusedRowHandle);
                objDetalle.Remove(objFilaDetalle);
                this.grcDetalle.RefreshDataSource();
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void chkAgrupado_CheckedChanged(object sender, EventArgs e) {
            try {
                if (((CheckEdit)sender).Checked) {
                    this.grvDetalle.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
                    this.grvDetalle.OptionsSelection.MultiSelect = true;
                    this.grvDetalle.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                    this.colAtrDetValor.Visible = false;
                    this.txtValor.Enabled = true;
                } else {
                    this.grvDetalle.OptionsSelection.CheckBoxSelectorColumnWidth = 0;
                    this.grvDetalle.OptionsSelection.MultiSelect = false;
                    this.grvDetalle.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
                    this.colAtrDetValor.Visible = true;
                    this.txtValor.Enabled = false;
                }
                foreach (clsLogDetGuiaValorada drFila in objDetalle)
                    drFila.AtrDetValor = 0;
                this.grcDetalle.RefreshDataSource();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        #region Procedimiento y funciones del formulario
        private void proCargarDetalle() {
            try {
                int varCodFormulario = 0;
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar("umbAplicacion.Logistica.Listado.xfrmLogLisGuiaRemision")) { varCodFormulario = csRegistro.FrmCodigo; }
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                List<clsLogGuiaRemisionCab> objCabeceras = clsLogGuiaRemisionCab.funListarValorada(2, varDocumento);
                objDetalle = new List<clsLogDetGuiaValorada>();
                int varSecuencia = 0;
                foreach (clsLogGuiaRemisionCab drFilaCabecera in objCabeceras) {
                    int atrDetCabGuia = drFilaCabecera.CabCodigo;
                    String atrDetDocNombre = drFilaCabecera.DocNombre;
                    int atrDetCabNumero = drFilaCabecera.CabNumero;
                    DateTime atrDetCabFecha = drFilaCabecera.CabFecha;
                    String atrDetChfNombre = drFilaCabecera.ChfNombre;
                    String atrDetAyuNombre = drFilaCabecera.AyuNombre;
                    String atrDetTrnPlaca = drFilaCabecera.TrnPlaca;
                    objDetalle.Add(new clsLogDetGuiaValorada(++varSecuencia, atrDetCabGuia, atrDetDocNombre, atrDetCabNumero, atrDetCabFecha, atrDetChfNombre, atrDetAyuNombre, atrDetTrnPlaca, 0));
                }
                this.grcDetalle.DataSource = objDetalle;
            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        #endregion
    }
}
