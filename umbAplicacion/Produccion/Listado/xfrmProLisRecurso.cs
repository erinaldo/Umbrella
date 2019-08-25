using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Produccion.Mantenimiento;
using umbNegocio;
using umbNegocio.Produccion;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Produccion.Listado
{
    public partial class xfrmProLisRecurso : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmProLisRecurso()
        {
            InitializeComponent();
        }
        public xfrmProLisRecurso(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de recursos de produccion";

                this.grcListado.DataSource = clsProRecurso.funListar();

                const string varNomFormulario = "umbAplicacion.Produccion.Listado.xfrmProLisRecurso";

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
                using (xfrmProManRecurso frmFormulario = new xfrmProManRecurso(varCodFormulario, varCodOperacion, ""))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsProRecurso.funListar();
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
                    string varRegistro = ((clsProRecurso)this.grvListado.GetRow(varPosicion)).RecCodigo;
                    using (xfrmProManRecurso frmFormulario = new xfrmProManRecurso(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }
                this.grcListado.DataSource = clsProRecurso.funListar();
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
                    var lisGeneral = new clsProRecurso();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsProRecurso)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsProRecurso.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
