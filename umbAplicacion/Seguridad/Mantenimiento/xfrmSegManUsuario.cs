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
using Umbrella;

namespace umbAplicacion.Seguridad.Mantenimiento
{
    public partial class xfrmSegManUsuario : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string varCodRegistro = "";

        public xfrmSegManUsuario()
        {
            InitializeComponent();
        }
        public xfrmSegManUsuario(int varFormulario, int varOperacion, string varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varCodRegistro = varRegistro;

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
                this.Text = "Mantenimiento de usuarios";
                switch (varOpeCodigo)
                {
                    case 2:
                        foreach (clsSegUsuario csRegistro in clsSegUsuario.funListar(varCodRegistro)) 
                        { 
                             this.txtCodigo.Text = csRegistro.UsuCodigo;
                             this.txtNombre.Text = csRegistro.UsuNombre;
                             this.lueEmpleado.EditValue = csRegistro.EmpCodigo;
                             this.txtEmail.Text = csRegistro.UsuMail;
                             this.txtTelefono.Text = csRegistro.UsuTelefono;
                             this.txtIdMovil.Text = csRegistro.UsuIdDispositivo;
                             this.lueSucursal.EditValue = csRegistro.ScrCodigo;
                             this.lueDepartamento.EditValue = csRegistro.DepCodigo;
                             this.txtPassword.Text = csRegistro.UsuPassword;
                             this.txtConfirmar.Text = csRegistro.UsuPassword;
                             this.chkVence.Checked = (bool)csRegistro.UsuVence;
                             this.chkModificar.Checked = (bool)csRegistro.UsuModificar;
                             this.chkBloqueado.Checked = (bool)csRegistro.UsuBloqueo;
                             this.chkMovil.Checked = (bool)csRegistro.UsuMovil;
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
                var csRegistro = new clsSegUsuario() 
                { 
                    UsuCodigo = this.txtCodigo.Text, 
                    UsuNombre = this.txtNombre.Text,
                    EmpCodigo = lueDepartamento.EditValue == null ? 0 : (int)lueDepartamento.EditValue,
                    UsuMail = this.txtEmail.Text,
                    UsuTelefono = this.txtTelefono.Text,
                    UsuIdDispositivo = this.txtIdMovil.Text,
                    ScrCodigo = lueSucursal.EditValue == null ? 0 : (int)lueSucursal.EditValue,
                    DepCodigo = lueDepartamento.EditValue == null ? 0 : (int)lueDepartamento.EditValue,
                    UsuPassword = this.txtPassword.Text,
                    UsuVence = this.chkVence.Checked,
                    UsuModificar = this.chkModificar.Checked,
                    UsuBloqueo = this.chkBloqueado.Checked,
                    UsuMovil = this.chkMovil.Checked
                };

                if (!this.txtPassword.Text.Equals(this.txtConfirmar.Text)) { XtraMessageBox.Show("El campo contraseña debe ser igual al campo confirmar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                switch (varOpeCodigo)
                {
                    case 1:
                        csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ingresado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
