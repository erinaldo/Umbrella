using System.Windows.Forms;
using umbAplicacion.Granja.Mantenimiento;
using umbNegocio;
using umbNegocio.Granja;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisCasaComercial : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisCasaComercial()
        {
            InitializeComponent();
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            //Asignamos el titulo que tendra el formulario
            this.Text = "Casas comerciales de animales";
            const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisCasaComercial";
            foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
            //Accesos del formulario para el usuario ingresado
            varCodDocumento = 1;
            this.proAccesoFormulario();

            grcListado.DataSource = clsGraCasaComercial.Listar();
        }

        public override void proNuevo()
        {
            base.proNuevo();
            xfrmGraManCasaComercial frmFormulario = new xfrmGraManCasaComercial(varCodFormulario, varCodOperacion, "");
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsGraCasaComercial.Listar();
        }

        public override void proModificar()
        {
            base.proModificar();
             foreach (int varPosicion in this.grvListado.GetSelectedRows())
            {
                string varRegistro = ((clsGraCasaComercial)this.grvListado.GetRow(varPosicion)).Id;
                xfrmGraManCasaComercial frmFormulario = new xfrmGraManCasaComercial(varCodFormulario, varCodOperacion, varRegistro);
                if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                    grcListado.DataSource = clsGraCasaComercial.Listar();
            }
        }

      
        public override void proEliminar()
        {
           base.proEliminar();
           clsGraCasaComercial obj = new clsGraCasaComercial();
           foreach (int varPosicion in this.grvListado.GetSelectedRows())
           {
               obj.Id = ((clsGraCasaComercial)this.grvListado.GetRow(varPosicion)).Id;
               if (MessageBox.Show("Desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                    && obj.ejecutarMantenimiento(3) >= 0)
                   grcListado.DataSource = clsGraCasaComercial.Listar();
           }
        }

        private void grcListado_DoubleClick(object sender, System.EventArgs e)
        {
            if (!btnModificar.Enabled) return;
            string varRegistro = ((clsGraCasaComercial)this.grvListado.GetRow(grvListado.FocusedRowHandle)).Id;
            Form frmFormulario = new xfrmGraManCasaComercial(varCodFormulario, 2, varRegistro);
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsGraCasaComercial.Listar();
        }
    }
}