using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Inventario;
using Umbrella;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManMotivoPerdida : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private clsGraMotPerdida obj = new clsGraMotPerdida();
        
        public xfrmGraManMotivoPerdida()
        {
            InitializeComponent();
        }
        public xfrmGraManMotivoPerdida(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varDocCodigo = 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void Page_Load(object sender, EventArgs e)
        {
            //Verificamos los acceso del usuario al formulario
            this.proAccesoFormulario();
            this.Text = "Motivos de mortalidad (perdidas)";
            switch (varOpeCodigo )
            {
                case 1: // New

                    break;
                case 2: // Edit
                    obj = clsGraMotPerdida.Cargar(varRegCodigo.ToString());
                    if (obj != null)
                    {
                        txtId.Text = obj.Id.ToString();
                        txtNombre.Text = obj.Nombre;
                    }
                    break;
                case 3: // Delete

                    break;
            }
            if (varOpeCodigo.Equals(4)) this.btnGrabar.Enabled = false;
        }
        public override void proGrabar()
        {
            try
            {
                base.proGrabar();
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                if (varOpeCodigo == 2) varOpeCodigo = 1;
                obj.Id = txtId.Text.Equals("") ? 0 : int.Parse(txtId.Text);
                obj.Nombre = txtNombre.Text;
                if (obj.ejecutarMantenimiento(varOpeCodigo) >= 0) {
                    XtraMessageBox.Show("Registro grabado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else MessageBox.Show("No se pudo realizar la operación solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
