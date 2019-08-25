using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Costos.Mantenimiento;
using umbNegocio;
using umbNegocio.Costos;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Costos.Listado
{
    public partial class xfrmCosLisNormaReparto : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        clsCosNormaReparto objNormaReparto = new clsCosNormaReparto();
        public xfrmCosLisNormaReparto() { InitializeComponent(); }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Listado de normas de reparto"; //Nombre del listado
                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisNormaReparto"; //Ubicación del formulario dentro del sistema
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = objNormaReparto.metConsultar();
                //Validaciones del listado
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proNuevo() {
            base.proNuevo();
            try {
                //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                xfrmCosManNormaReparto objFormulario = new xfrmCosManNormaReparto(varCodFormulario, varCodOperacion, 1);
                objFormulario.ShowDialog();
                this.grcListado.DataSource = objNormaReparto.metConsultar();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proModificar() {
            varCodDocumento = 1;
            base.proModificar();
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el id del registro seleccionado
                    varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CcrCodigo;
                    //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                    xfrmCosManNormaReparto objFormulario = new xfrmCosManNormaReparto(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(varPosicion)).CcrCodigo;
                        //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                        xfrmCosManNormaReparto objFormulario = new xfrmCosManNormaReparto(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = objNormaReparto.metConsultar();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
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
                    varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CcrCodigo;
                    //Llamamos al metodo para eliminar el registro
                    if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar el registro seleccionado") == DialogResult.Yes) {
                        objNormaReparto.metEliminar(varRegistro);
                        varBanEliminacion = true;
                    }
                } else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(varPosicion)).CcrCodigo;
                        //Llamamos al metodo para eliminar el registro
                        if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar el registro seleccionado") == DialogResult.Yes) {
                            objNormaReparto.metEliminar(varRegistro);
                            varBanEliminacion = true;
                        }
                    }
                }
                if (varBanEliminacion) {
                    clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgEliminar);
                    //Llenamos el listado 
                    this.grcListado.DataSource = objNormaReparto.metConsultar();
                }
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proConsultar() {
            varCodDocumento = 1;
            base.proConsultar();
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el id del registro seleccionado
                    varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CcrCodigo;
                    //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                    xfrmCosManNormaReparto objFormulario = new xfrmCosManNormaReparto(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                } else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((clsCosNormaReparto)this.grvListado.GetRow(varPosicion)).CcrCodigo;
                        //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                        xfrmCosManNormaReparto objFormulario = new xfrmCosManNormaReparto(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void btnGenerar_Click(object sender, EventArgs e) {
            try {
                const string varFormularioNombre = "umbAplicacion.Costos.Listado.xfrmCosLisDistribucion";
                int varFormularioCodigo = 0;
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varFormularioNombre)) varFormularioCodigo = csRegistro.FrmCodigo; 
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varFormularioCodigo);
                if (varDocumento.Equals("")) { clsMensajesSistema.metMsgError("El usuario no tiene acceso al formulario seleccionado"); return; }
                //Arreglo de enteros
                List<int> objSeleccionado = new List<int>();
                //Recorremos las filas seleccionadas
                foreach (int varPosicion in grvListado.GetSelectedRows()) {
                    if (((clsCosNormaReparto)this.grvListado.GetRow(varPosicion)).CcrActivo.Equals("Activo")) {
                        int varCcrCodigo = ((clsCosNormaReparto)this.grvListado.GetRow(varPosicion)).CcrCodigo;
                        objSeleccionado.Add(varCcrCodigo);
                    }
                }
                //Validamos que haya seleccionado alguna fila
                if (objSeleccionado.Count.Equals(0)) { clsMensajesSistema.metMsgError("Debe seleccional al menos una norma de reparto activa"); return; }
                using (xfrmCosManDistribucion objFormulario = new xfrmCosManDistribucion(37, 1, 0, objSeleccionado)) {
                    objFormulario.StartPosition = FormStartPosition.CenterScreen;
                    objFormulario.ShowDialog();
                }

            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
