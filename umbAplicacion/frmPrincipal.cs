using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;

namespace umbAplicacion
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm 
    {
        private Dictionary<string, XtraForm> insFormulario = new Dictionary<string, XtraForm>();

        
        public frmPrincipal()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            frmLogeo frm = new frmLogeo() { Location = new Point(450, 250) };
            frm.ShowDialog();

            if (clsVariablesGlobales.varCodUsuario == null) { this.Close(); return; }

            this.acoMain.Elements.Clear();
            this.acoMain.Focus();
            this.acoMain.ShowFilterControl = ShowFilterControl.Always;
            this.acoMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.lblSistema.Visible = true;
            this.lblEmpresa.Visible = true;
            this.lblUsuario.Visible = true;
            this.lblUsuario.Text = "[" + clsVariablesGlobales.varCodUsuario.ToUpper() + "]";
            try
            {
                int i = 0;
                List<clsSegMenu> menuGroups = clsSegMenu.funListarGrupos(clsVariablesGlobales.varCodUsuario);
                foreach (clsSegMenu group in menuGroups)
                {
                    AccordionControlElement acoGrpMenu = new AccordionControlElement();
                    acoGrpMenu.Text = group.MenNombre;
                    acoGrpMenu.Style = ElementStyle.Group;
                    
                    if (group.MenCodigo.Equals(1)) acoGrpMenu.ImageIndex = 0;
                    if (group.MenCodigo.Equals(9)) acoGrpMenu.ImageIndex = 1;
                    if (group.MenCodigo.Equals(14)) acoGrpMenu.ImageIndex = 2;
                    if (group.MenCodigo.Equals(19)) acoGrpMenu.ImageIndex = 3;
                    if (group.MenCodigo.Equals(29)) acoGrpMenu.ImageIndex = 4;
                    if (group.MenCodigo.Equals(31)) acoGrpMenu.ImageIndex = 5;
                    if (group.MenCodigo.Equals(33)) acoGrpMenu.ImageIndex = 6;
                    if (group.MenCodigo.Equals(35)) acoGrpMenu.ImageIndex = 7;
                    if (group.MenCodigo.Equals(73)) acoGrpMenu.ImageIndex = 8;
                    acoMain.Elements.Add(acoGrpMenu);
                    
                    List<clsSegMenu> menuItems = clsSegMenu.funListarPorGrupo(clsVariablesGlobales.varCodUsuario, group.MenCodigo);
                    proExtSubMenus(acoGrpMenu, group.MenCodigo, menuItems);
                    i++;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void acoItem_Click(object sender, EventArgs e)
        {
            AccordionControlElement acoItem = (AccordionControlElement)sender;
            if (acoItem.Style == ElementStyle.Group) return;
            XtraForm xfrmFormulario;
            if (!insFormulario.TryGetValue(acoItem.Tag.ToString(), out xfrmFormulario) || xfrmFormulario.IsDisposed)
            {
                xfrmFormulario = (XtraForm)Activator.CreateInstance(null, acoItem.Tag.ToString()).Unwrap();
                insFormulario[acoItem.Tag.ToString()] = xfrmFormulario;
                xfrmFormulario.ShowInTaskbar = false;
                xfrmFormulario.MdiParent = this;
                xfrmFormulario.Show();
            }
            xfrmFormulario.Focus();
        }

        private void proExtSubMenus(AccordionControlElement acoGrp, int varCodPadre, List<clsSegMenu> menuItems)
        {
            try
            {
                int varCuantos = 0;
                foreach (clsSegMenu mItem in menuItems)
                {
                    List<clsSegMenu> menuSub = clsSegMenu.funListarPorGrupo(clsVariablesGlobales.varCodUsuario, mItem.MenCodigo);
                    varCuantos = menuSub.Count();
                    AccordionControlElement acoItem = new AccordionControlElement();
                    acoItem.Text = mItem.MenNombre;
                    acoItem.Tag = mItem.FrmRuta;
                    acoItem.Style = varCuantos > 0 ?  ElementStyle.Group : ElementStyle.Item;
                    acoItem.Click += acoItem_Click;
                    acoGrp.Elements.Add(acoItem);
                    if (varCuantos > 0) 
                        proExtSubMenus(acoItem, mItem.MenCodigo, menuSub);                    
                }
            }
            catch (Exception) { throw; }
        }
    }
}
