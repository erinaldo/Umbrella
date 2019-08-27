using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Etiquetas.Mantenimiento;
using umbNegocio;
using umbNegocio.Entidades;
using umbNegocio.Etiquetas;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Etiquetas.Listado
{
    public partial class xfrmEtqLisNutricional : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmEtqLisNutricional() { InitializeComponent(); }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Listado de etiquetas nutricionales"; //Nombre del listado
                const string varNomFormulario = "umbAplicacion.Etiquetas.Listado.xfrmEtqLisNutricional"; //Ubicación del formulario dentro del sistema
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = daoEtqNutricional.getInstance().metListar();
                //Validaciones del listado
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proNuevo() {
            base.proNuevo();
            try {
                //Llamamos al mantenimiendo de cantidades permitidas para la opcion de insertar
                xfrmEtqManNutricional objFormulario = new xfrmEtqManNutricional(varCodFormulario, varCodOperacion, 1);
                objFormulario.ShowDialog();
                this.grcListado.DataSource = daoEtqNutricional.getInstance().metListar();
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
                    varRegistro = ((EntETQ_NUTRICIONAL)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EtnCodigo;
                    //Llamamos al mantenimiendo de etiquetas nutricionales opcion de modificar
                    xfrmEtqManNutricional objFormulario = new xfrmEtqManNutricional(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                } else {
                    foreach (int varPosicion in grvListado.GetSelectedRows()) {
                        //Recuperamos el id del registro seleccionado
                        varRegistro = ((EntETQ_NUTRICIONAL)this.grvListado.GetRow(varPosicion)).EtnCodigo;
                        //Llamamos al mantenimiendo de etiquetas nutricionales opcion de modificar
                        xfrmEtqManNutricional objFormulario = new xfrmEtqManNutricional(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                //Llenamos el listado de las etiquetas nutricionales
                this.grcListado.DataSource = daoEtqNutricional.getInstance().metListar();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
