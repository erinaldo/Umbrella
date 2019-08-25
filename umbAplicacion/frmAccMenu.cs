using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio.Seguridad;

namespace umbAplicacion
{
    public partial class frmAccMenu : Form
    {
        private string varUsuCodigo = "";
        private string varUsuNombre = "";
        private DataTable dtAccMenu;

        public frmAccMenu()
        {
            InitializeComponent();
        }
        public frmAccMenu(string varCodigo, string varNombre)
        {
            InitializeComponent();
            varUsuCodigo = varCodigo;
            varUsuNombre = varNombre;
        }
        private void frmAccMenu_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Acceso de menus";
                this.txtCodigo.Text = varUsuCodigo;
                this.txtNombre.Text = varUsuNombre;

                var lisGeneral = new clsSegAccMenu();
                this.grcListado.DataSource = lisGeneral.funListarMenuFor(varUsuCodigo);

                this.proDtAccMenu();
                foreach (clsSegAccMenu drRegistro in lisGeneral.funListar(varUsuCodigo))
                {
                        this.dtAccMenu.Rows.Add(drRegistro.MenCodigo,
                                                                           drRegistro.MenNombre,
                                                                           drRegistro.MenPadre);
                }
                dtAccMenu.DefaultView.Sort = "MenCodigo";
                treListado.DataSource = dtAccMenu;
                treListado.ExpandAll();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
        private void proDtAccMenu()
        {
            dtAccMenu = new DataTable { TableName = "AccMenu" };
            dtAccMenu.Columns.Add("MenCodigo", typeof(int));
            dtAccMenu.Columns.Add("MenNombre", typeof(string));
            dtAccMenu.Columns.Add("MenPadre", typeof(int));
        }

        private void ickAcceso_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                var lisGeneral = new clsSegMenu();
                int varMenCodigo = ((clsSegAccMenu)this.grvListado.GetFocusedRow()).MenCodigo;

                if (((DevExpress.XtraEditors.CheckEdit)(sender)).Checked)
                {
                    do
                    {
                        foreach (clsSegMenu drRegistro in clsSegMenu.funListar(varMenCodigo))
                        {
                            if (this.dtAccMenu.Select(string.Format("MenCodigo = {0}", varMenCodigo)).Length == 0)
                            {
                                this.dtAccMenu.Rows.Add(drRegistro.MenCodigo,
                                                                                   drRegistro.MenNombre,
                                                                                   drRegistro.MenPadre);

                            }
                            varMenCodigo = drRegistro.MenPadre;
                        }
                    } while (varMenCodigo >= 1);
                }
                else
                {
                    do
                    {
                        foreach (DataRow drFila in this.dtAccMenu.Select(string.Format("MenCodigo = {0}", varMenCodigo)))
                        {
                            varMenCodigo = int.Parse(drFila["MenPadre"].ToString());
                            dtAccMenu.Rows.Remove(drFila);
                        }
                        if (this.dtAccMenu.Select(string.Format("MenPadre = {0}", varMenCodigo)).Length > 0) varMenCodigo = 0;
                    } while (varMenCodigo >= 1);
                }

                dtAccMenu.DefaultView.Sort = "MenCodigo";
                treListado.DataSource = dtAccMenu;
                treListado.ExpandAll();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var csRegistro = new clsSegAccMenu()
                {
                    UsuCodigo = this.txtCodigo.Text,
                    dtAccMenu = dtAccMenu
                };

                csRegistro.funMantenimiento(csRegistro);
                XtraMessageBox.Show("Registro guardado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
