using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Umbrella;
using umbNegocio;

namespace umbAplicacion.Plantillas.Mantenimiento
{
    public partial class xfrmPlaMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        public int varDocCodigo = 0;
        public int varForCodigo = 0;
        public int varOpeCodigo = 0;
        public int varRegCodigo = 0;
        //Variable utilizada para determinar si las validaciones del formulario son correctas
        public bool varBanValidaciones = true;
        
        public string varRegCodigoStr = "";
        public string varDocNombre = "";

        public xfrmPlaMantenimiento()
        {
            InitializeComponent();
        }
        private void xfrmPlaMantenimiento_Load(object sender, EventArgs e) { proIniciarFormulario(); }
        private void xfrmPlaMantenimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G) proGrabar();
            else if (e.Control && e.KeyCode == Keys.Q) proCancelar();
        }

        private void btnNuevo_Click(object sender, EventArgs e) { proGrabar(); }
        private void btnModificar_Click(object sender, EventArgs e) { proCancelar(); }

        public virtual void proGrabar() {
            string varMensaje = "";
            varBanValidaciones = true;
            //Validaciones de campos requeridos
            var csValidaciones = new clsValidacionesControles();
            varMensaje = csValidaciones.funControlRequerido(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo, dxError);
            if (!varMensaje.Equals("")) varBanValidaciones = false; 
        }
        public virtual void proCancelar() { this.Close();  }
        public virtual void proIniciarFormulario() { }
        public void proAccesoFormulario()
        {
            try {
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
    }
}