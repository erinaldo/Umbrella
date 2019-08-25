using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Seguridad;
using umbAplicacion.Seguridad.Listado;
using Umbrella;

namespace umbAplicacion.Seguridad.Mantenimiento
{
    public partial class xfrmSegManMenu : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private int varPadCodigo = 0;
        private string varPadNombre = "";

        public xfrmSegManMenu()
        {
            InitializeComponent();
        }
        public xfrmSegManMenu(int varFormulario, int varOperacion, int varRegistro, int varPadre, string varNombre)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varPadCodigo = varPadre == -1 ? 0 : varPadre;
                varPadNombre = varNombre;

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Mantenimiento de menus";
                switch (varOpeCodigo)
                {
                    case 1:
                        this.txtPadre.Text = varPadCodigo.ToString();
                        this.bedNomPadre.Text = varPadNombre;
                        break;
                    case 2:
                        var csMenu = new clsSegMenu();
                        foreach (clsSegMenu csRegistro in clsSegMenu.funListar(varRegCodigo))
                        {
                            this.txtCodigo.Text = csRegistro.MenCodigo.ToString();
                            this.txtNombre.Text = csRegistro.MenNombre.ToString();
                            this.txtPadre.Text = csRegistro.MenPadre.ToString();
                            this.bedNomPadre.Text = csRegistro.MenNomPadre.ToString();
                            this.txtFormulario.Text = csRegistro.FrmCodigo.ToString();
                            this.bedRuta.Text = csRegistro.FrmRuta;
                            this.chkVisible.Checked = csRegistro.MenVisible;
                        }
                        break;
                }
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                var csRegistro = new clsSegMenu()
                {
                    MenCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    MenNombre = this.txtNombre.Text,
                    MenPadre = this.txtPadre.Text.Equals("") ? 0 : int.Parse(this.txtPadre.Text),
                    MenNomPadre = this.bedNomPadre.Text,
                    FrmCodigo = this.txtFormulario.Text.Equals("") ? 0 : int.Parse(this.txtFormulario.Text),
                    FrmRuta = this.bedRuta.Text,
                    MenVisible = this.chkVisible.Checked
                };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, 0, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varRegCodigo, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bedNomPadre_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (e.Button.Index)
                {
                    case 0:
                        using (xfrmSegLisMenu frmFormulario = new xfrmSegLisMenu(true))
                        {
                            frmFormulario.ShowDialog();
                            if (frmFormulario.DrVarFila != null)
                            {
                                this.txtPadre.Text = ((clsSegMenu)frmFormulario.DrVarFila).MenCodigo.ToString();
                                this.bedNomPadre.Text = ((clsSegMenu)frmFormulario.DrVarFila).MenNombre.ToString();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (e.Button.Index)
                {
                    case 0:
                        using (xfrmSegLisFormulario frmFormulario = new xfrmSegLisFormulario(true))
                        {
                            frmFormulario.ShowDialog();
                            if (frmFormulario.DrVarFila != null)
                            {
                                this.txtFormulario.Text = ((clsSegFormulario)frmFormulario.DrVarFila[0]).FrmCodigo.ToString();
                                this.bedRuta.Text = ((clsSegFormulario)frmFormulario.DrVarFila[0]).FrmRuta.ToString();
                            }
                        }
                        break;
                    case 1:
                        this.txtFormulario.Text = "0";
                        this.bedRuta.Text = "";
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
