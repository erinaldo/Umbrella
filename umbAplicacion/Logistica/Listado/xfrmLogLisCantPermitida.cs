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
    public partial class xfrmLogLisCantPermitida : umbAplicacion.Plantillas.Listado.xfrmPlaListado {
        public xfrmLogLisCantPermitida() {
            InitializeComponent();
        }
        public override void proIniciarFormulario(){
            base.proIniciarFormulario();
            try {
                this.Text = "Listado de cantidades permitidas en facturación"; //Nombre del listado
                const string varNomFormulario = "umbAplicacion.Logistica.Listado.xfrmLogLisCantPermitida"; //Ubicación del formulario dentro del sistema
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = clsLogCantPermitida.metListar();
                //Validaciones del listado
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message);  }
        }
        public override void proNuevo() {
            base.proNuevo();
            try {
                //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                xfrmLogManCantPermitida objFormulario = new xfrmLogManCantPermitida(varCodFormulario, varCodOperacion, 1);
                objFormulario.ShowDialog();
                this.grcListado.DataSource = clsLogCantPermitida.metListar();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message);  }
        }
        public override void proModificar() {
            varCodDocumento = 1;
            base.proModificar();
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el id del registro seleccionado
                    varRegistro = ((clsLogCantPermitida)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).Id;
                    //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                    xfrmLogManCantPermitida objFormulario = new xfrmLogManCantPermitida(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                } else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsLogCantPermitida)this.grvListado.GetRow(varPosicion)).Id;
                        //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                        xfrmLogManCantPermitida objFormulario = new xfrmLogManCantPermitida(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = clsLogCantPermitida.metListar();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message);  }
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
                    varRegistro = ((clsLogCantPermitida)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).Id;
                    //Llamamos al metodo para eliminar el registro
                    if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar el registro seleccionado") == DialogResult.Yes) { 
                        clsLogCantPermitida.metEliminar(varRegistro);
                        varBanEliminacion = true;
                    }
                }
                else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsLogCantPermitida)this.grvListado.GetRow(varPosicion)).Id;
                        //Llamamos al metodo para eliminar el registro
                        if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar el registro seleccionado") == DialogResult.Yes) {
                            clsLogCantPermitida.metEliminar(varRegistro);
                            varBanEliminacion = true;
                        }
                    }
                }
                if (varBanEliminacion) {
                    clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgEliminar);
                    //Llenamos el listado de las cantidades permitidas para la facturación
                    this.grcListado.DataSource = clsLogCantPermitida.metListar();
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
