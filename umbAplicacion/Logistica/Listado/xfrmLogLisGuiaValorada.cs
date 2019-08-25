using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Logistica.Mantenimiento;
using umbNegocio;
using umbNegocio.Logistica;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Logistica.Listado
{
    public partial class xfrmLogLisGuiaValorada : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmLogLisGuiaValorada() { InitializeComponent(); }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Listado de guias valoradas"; //Nombre del listado
                const string varNomFormulario = "umbAplicacion.Logistica.Listado.xfrmLogLisGuiaValorada"; //Ubicación del formulario dentro del sistema
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = daoLogGuiaValorada.getInstance().metListar();
                //Validaciones del listado
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proNuevo() {
            base.proNuevo();
            try {
                //Llamamos al mantenimiendo para la opcion insertar
                xfrmLogManGuiaValorada objFormulario = new xfrmLogManGuiaValorada(varCodFormulario, varCodOperacion, 1);
                objFormulario.ShowDialog();
                this.grcListado.DataSource = daoLogGuiaValorada.getInstance().metListar();
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proEliminar() {
            varCodDocumento = 1;
            base.proEliminar();
            try {
                int varRegistro = 0;
                Boolean varBanEliminacion = false;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el id del registro seleccionado
                    varRegistro = ((clsLogGuiaValorada)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).AtrCabCodigo;
                    //Llamamos al metodo para eliminar el registro
                    if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar el registro seleccionado") == DialogResult.Yes) {
                        daoLogGuiaValorada.getInstance().metEliminar(varRegistro);
                        varBanEliminacion = true;
                    }
                }
                else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsLogGuiaValorada)this.grvListado.GetRow(varPosicion)).AtrCabCodigo;
                        //Llamamos al metodo para eliminar el registro
                        if (clsMensajesSistema.metMsgPregunta(string.Format("Esta seguro de eliminar el registro seleccionado: {0}", varRegistro)) == DialogResult.Yes) {
                            daoLogGuiaValorada.getInstance().metEliminar(varRegistro);
                            varBanEliminacion = true;
                        }
                    }
                }
                if (varBanEliminacion) {
                    clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgEliminar);
                    //Llenamos el listado de las cantidades permitidas para la facturación
                    this.grcListado.DataSource = daoLogGuiaValorada.getInstance().metListar();
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
