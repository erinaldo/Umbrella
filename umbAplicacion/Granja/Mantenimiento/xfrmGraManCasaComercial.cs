using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Granja;
using Umbrella;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManCasaComercial : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private string selId;
        private clsGraCasaComercial obj = new clsGraCasaComercial();
        public xfrmGraManCasaComercial()
        {
            InitializeComponent();
        }

        public xfrmGraManCasaComercial(int varFormulario, int varOperacion, string varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varDocCodigo = 1;
                selId = varRegistro;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Page_Load(object sender, EventArgs e)
        {
            //Verificamos los acceso del usuario al formulario
            this.proAccesoFormulario();
            this.Text = "Casas comerciales de animales";
            switch (varOpeCodigo )
            {
                case 1: // New

                    break;
                case 2: // Edit
                    txtCodigo.Enabled = false;
                    obj = obj.Cargar(selId);
                    if (obj != null)
                    {
                        txtCodigo.Text = obj.Id;
                        txtNombre.Text = obj.Nombre;
                    }
                    break;
            }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            //Verificamos las validaciones de los campos requeridos
            if (!varBanValidaciones) return;
            if (varOpeCodigo == 2) varOpeCodigo = 1;
            obj.Id = txtCodigo.Text;
            obj.Nombre = txtNombre.Text;
            if (obj.ejecutarMantenimiento(varOpeCodigo) >= 0) 
                DialogResult = DialogResult.OK;
            else MessageBox.Show("No se pudo realizar la operación solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
