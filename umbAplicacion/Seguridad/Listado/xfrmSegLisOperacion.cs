using DevExpress.XtraEditors;
using umbDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;
using umbAplicacion.Seguridad.Mantenimiento;
using Umbrella;

namespace umbAplicacion.Seguridad.Listado
{
    public partial class xfrmSegLisOperacion : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmSegLisOperacion()
        {
            InitializeComponent();
        }
        public xfrmSegLisOperacion(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de operaciones";

                var lisGeneral = new clsSegOperacion();
                this.grcListado.DataSource = lisGeneral.funListar();

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisOperacion";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmSegManOperacion frmFormulario = new xfrmSegManOperacion(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    var lisGeneral = new clsSegOperacion();
                    this.grcListado.DataSource = lisGeneral.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar()
        {
            base.proModificar();
            try
            {
                foreach (int varPosicion in this.grvListado.GetSelectedRows())
                {
                    int varRegistro = ((clsSegOperacion)this.grvListado.GetRow(varPosicion)).OpeCodigo;
                    using (xfrmSegManOperacion frmFormulario = new xfrmSegManOperacion(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }
                
                var lisGeneral = new clsSegOperacion();
                this.grcListado.DataSource = lisGeneral.funListar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
            try
            {
                if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var lisGeneral = new clsSegOperacion();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsSegOperacion)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, 0, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = lisGeneral.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
