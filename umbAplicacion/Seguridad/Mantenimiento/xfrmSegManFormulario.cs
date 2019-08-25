using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Seguridad.Mantenimiento
{
    public partial class xfrmSegManFormulario : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmSegManFormulario()
        {
            InitializeComponent();
        }
        public xfrmSegManFormulario(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Mantenimiento de formularios";
                switch (varOpeCodigo)
                {
                    case 2:
                         foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varRegCodigo)) 
                        { 
                            this.txtCodigo.Text = csRegistro.FrmCodigo.ToString();
                            this.txtRuta.Text = csRegistro.FrmRuta;
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
                var csRegistro = new clsSegFormulario() 
                { 
                    FrmCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text), 
                    FrmRuta = this.txtRuta.Text 
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
    }
}
