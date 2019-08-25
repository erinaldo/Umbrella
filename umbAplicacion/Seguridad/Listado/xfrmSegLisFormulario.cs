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
    public partial class xfrmSegLisFormulario : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        private ToolStripMenuItem tsmCampo = new ToolStripMenuItem();

        public xfrmSegLisFormulario()
        {
            InitializeComponent();
        }
        public xfrmSegLisFormulario(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de formularios";

                this.grcListado.DataSource = clsSegFormulario.funListar();

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisFormulario";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);

                cmsMenuListado.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });

                this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmCampo});
                this.agregarToolStripMenuItem.Image = global::umbAplicacion.Properties.Resources.imgAgregar24;
                this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
                this.agregarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
                this.agregarToolStripMenuItem.Text = "Agregar";
                // 
                // tsmCampo
                // 
                this.tsmCampo.Enabled = true;
                this.tsmCampo.Image = global::umbAplicacion.Properties.Resources.imgCampo24;
                this.tsmCampo.Name = "tsmCampo";
                this.tsmCampo.Size = new System.Drawing.Size(152, 22);
                this.tsmCampo.Text = "Campo";
                this.tsmCampo.Click += new System.EventHandler(this.tsmCampo_Click);

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmSegManFormulario frmFormulario = new xfrmSegManFormulario(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    
                    this.grcListado.DataSource = clsSegFormulario.funListar();
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
                    int varRegistro = ((clsSegFormulario)this.grvListado.GetRow(varPosicion)).FrmCodigo;
                    using (xfrmSegManFormulario frmFormulario = new xfrmSegManFormulario(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }
                
                this.grcListado.DataSource = clsSegFormulario.funListar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
            try
            {
                var lisGeneral = new clsSegFormulario();
                if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsSegFormulario)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, 0, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsSegFormulario.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void tsmCampo_Click(object sender, EventArgs e)
        {
            try
            {
                int varCodigo = ((clsSegFormulario)this.grvListado.GetFocusedRow()).FrmCodigo;
                using (xfrmSegLisCampo frmFormulario = new xfrmSegLisCampo(varCodigo)) frmFormulario.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
