using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using System.Net;
using umbNegocio.Seguridad;

namespace umbAplicacion
{
    public partial class frmLogeo : DevExpress.XtraEditors.XtraForm
    {
        public frmLogeo()
        {
            InitializeComponent();
            this.txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.txtUsuario.Text = "manager";
                //this.txtContrasena.Text = "mayra22021986";

                //Verificacion de los campos requeridos
                string varUsuario = this.txtUsuario.Text;
                string varContrasena = this.txtContrasena.Text;

                if (varUsuario.Trim().Equals("")) { XtraMessageBox.Show("El id de usuario es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (varContrasena.Trim().Equals("")) { XtraMessageBox.Show("La clave de acceso es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                //Validacion si el usuario tiene acceso para ingresar
                if (clsSegUsuario.funUsuVerificar(varUsuario, varContrasena).Equals(0)) { XtraMessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                
                clsVariablesGlobales.varCodUsuario = varUsuario;
                clsVariablesGlobales.varNomUsuario = clsSegUsuario.funListar(varUsuario)[0].UsuNombre;

                foreach (IPAddress ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork") 
                        clsVariablesGlobales.varIpMaquina = ip.ToString();
                }
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}