using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Seguridad.Mantenimiento;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Seguridad.Listado
{
    public partial class xfrmSegLisUsuario : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public System.Windows.Forms.ToolStripMenuItem accesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        private ToolStripMenuItem tsmMenu = new ToolStripMenuItem();
        private ToolStripMenuItem tsmFormulario = new ToolStripMenuItem();


        public xfrmSegLisUsuario()
        {
            InitializeComponent();
        }
        public xfrmSegLisUsuario(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de usuarios";

                this.grcListado.DataSource = clsSegUsuario.funListar();

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisUsuario";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);

                cmsMenuListado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { accesosToolStripMenuItem });

                this.accesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmMenu,
                this.tsmFormulario});
                this.accesosToolStripMenuItem.Image = global::umbAplicacion.Properties.Resources.imgCandado24;
                this.accesosToolStripMenuItem.Name = "accesoToolStripMenuItem";
                this.accesosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
                this.accesosToolStripMenuItem.Text = "Acceso";
                // 
                // tsmMenu
                // 
                this.tsmMenu.Enabled = true;
                this.tsmMenu.Image = global::umbAplicacion.Properties.Resources.imgMenu24;
                this.tsmMenu.Name = "tsmMenu";
                this.tsmMenu.Size = new System.Drawing.Size(152, 22);
                this.tsmMenu.Text = "Menu";
                this.tsmMenu.Click += new System.EventHandler(this.tsmMenu_Click);
                //
                // tsmFormulario
                // 
                this.tsmFormulario.Enabled = true;
                this.tsmFormulario.Image = global::umbAplicacion.Properties.Resources.imgFormulario24;
                this.tsmFormulario.Name = "tsmFormulario";
                this.tsmFormulario.Size = new System.Drawing.Size(152, 22);
                this.tsmFormulario.Text = "Formulario";
                this.tsmFormulario.Click += new System.EventHandler(this.tsmFormulario_Click);

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmSegManUsuario frmFormulario = new xfrmSegManUsuario(varCodFormulario, varCodOperacion, ""))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsSegUsuario.funListar();
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
                    string varRegistro = ((clsSegUsuario)this.grvListado.GetRow(varPosicion)).UsuCodigo;
                    using (xfrmSegManUsuario frmFormulario = new xfrmSegManUsuario(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                this.grcListado.DataSource = clsSegUsuario.funListar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
            try
            {
                if(this.grvListado.GetSelectedRows().Length == 0) return;
                if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var lisGeneral = new clsSegUsuario();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsSegUsuario)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsSegUsuario.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void tsmMenu_Click(object sender, EventArgs e) 
        {
            try
            {
                string varCodigo = ((clsSegUsuario)this.grvListado.GetFocusedRow()).UsuCodigo;
                string varNombre = ((clsSegUsuario)this.grvListado.GetFocusedRow()).UsuNombre;
                using (frmAccMenu frmFormulario = new frmAccMenu(varCodigo, varNombre)) frmFormulario.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void tsmFormulario_Click(object sender, EventArgs e) 
        {
            try
            {
                string varCodigo = ((clsSegUsuario)this.grvListado.GetFocusedRow()).UsuCodigo;
                string varNombre = ((clsSegUsuario)this.grvListado.GetFocusedRow()).UsuNombre;
                using (frmAccFormulario frmFormulario = new frmAccFormulario(varCodigo, varNombre)) frmFormulario.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }    
        }
    }
}
