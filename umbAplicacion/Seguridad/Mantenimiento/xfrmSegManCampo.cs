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
    public partial class xfrmSegManCampo : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        int varFormularioPadre = 0;

        public xfrmSegManCampo()
        {
            InitializeComponent();
        }
        public xfrmSegManCampo(int varFormulario, int varOperacion, int varRegistro, int varForPadre)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varFormularioPadre = varForPadre;

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varFormulario, 1, varOperacion);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varFormulario, 1, varOperacion);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Mantenimiento de campos";
                switch (varOpeCodigo)
                {
                    case 2:
                         var csFormulario = new clsSegCampo();
                         foreach (clsSegCampo csRegistro in csFormulario.funListar(varFormularioPadre, varRegCodigo))
                         {
                             this.txtCodigo.Text = csRegistro.CamCodigo.ToString();
                             this.txtNombre.Text = csRegistro.CamNombre;
                             this.cmbTipo.EditValue = csRegistro.CamTipo;
                             this.chkRequerido.Checked = csRegistro.CamRequerido;
                             this.txtError.Text = csRegistro.CamError;
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
                var csRegistro = new clsSegCampo() 
                { 
                    CamCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text), 
                    CamNombre = this.txtNombre.Text ,
                    CamTipo = this.cmbTipo.Text,
                    CamRequerido = this.chkRequerido.Checked,
                    CamError = this.txtError.Text,
                    FrmCodigo = varFormularioPadre
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
