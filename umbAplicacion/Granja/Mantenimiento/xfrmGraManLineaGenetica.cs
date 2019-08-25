using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Granja;
using Umbrella;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManLineaGenetica : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private clsGraLineaGenetica obj = new clsGraLineaGenetica();
        public xfrmGraManLineaGenetica()
        {
            InitializeComponent();
        }

        public xfrmGraManLineaGenetica(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varDocCodigo = 1;
            varRegCodigo = varRegistro;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            //Verificamos los acceso del usuario al formulario
            this.proAccesoFormulario();
            this.Text = "Lineas geneticas de animales";

            lueEspecie.Properties.DataSource = clsDiccionario.Listar("GRAESPECIE");
            switch (varOpeCodigo )
            {
                case 1: // New
                    this.lueEspecie.ItemIndex = 0;
                    this.cmbGenero.SelectedIndex = 0;
                    break;
                case 2: // Edit
                    txtCodigo.Enabled = false;
                    obj = obj.Cargar(varRegCodigo);
                    if (obj != null)
                    {
                        txtCodigo.EditValue = obj.Id;
                        txtNombre.Text = obj.Nombre;
                        lueEspecie.EditValue = obj.Especie;
                        cmbGenero.Text = obj.Genero;
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
            obj.Id = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Especie = lueEspecie.EditValue.ToString();
            obj.Genero = cmbGenero.Text;

            if (obj.ejecutarMantenimiento(varOpeCodigo) >= 0)
                DialogResult = DialogResult.OK;
            else MessageBox.Show("No se pudo realizar la operación solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
