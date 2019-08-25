using umbAplicacion.Granja.Mantenimiento;
using umbNegocio;
using umbNegocio.Granja;
using umbNegocio.Seguridad;
using Umbrella;
using System.Windows.Forms;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisLineaGenetica : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisLineaGenetica()
        {
            InitializeComponent();
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            //Asignamos el titulo que tendra el formulario
            this.Text = "Lineas geneticas de animales";
            const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisLineaGenetica";
            foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
            //Accesos del formulario para el usuario ingresado
            varCodDocumento = 1;
            this.proAccesoFormulario();    

            grcListado.DataSource = clsGraLineaGenetica.Listar();
        }

        public override void proNuevo()
        {
            base.proNuevo();
            xfrmGraManLineaGenetica frmFormulario = new xfrmGraManLineaGenetica(varCodFormulario, varCodOperacion, 0);
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsGraLineaGenetica.Listar();
        }

        public override void proModificar()
        {
            base.proModificar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows())
            {
                int varRegistro = ((clsGraLineaGenetica)this.grvListado.GetRow(varPosicion)).Id;
                xfrmGraManLineaGenetica frmFormulario = new xfrmGraManLineaGenetica(varCodFormulario, varCodOperacion, varRegistro);
                if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                    grcListado.DataSource = clsGraLineaGenetica.Listar();
            }
        }

      
        public override void proEliminar()
        {
           base.proEliminar();
           foreach (int varPosicion in this.grvListado.GetSelectedRows())
           {
               clsGraLineaGenetica obj = new clsGraLineaGenetica();
               obj.Id = ((clsGraLineaGenetica)this.grvListado.GetRow(varPosicion)).Id;
               if (MessageBox.Show("Desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                    && obj.ejecutarMantenimiento(3) >= 0)
                   grcListado.DataSource = clsGraLineaGenetica.Listar();
           }
        }

        private void grcListado_DoubleClick(object sender, System.EventArgs e)
        {
            if (!btnModificar.Enabled) return;
            int varRegistro = ((clsGraLineaGenetica)this.grvListado.GetRow(grvListado.FocusedRowHandle)).Id;
            Form frmFormulario = new xfrmGraManLineaGenetica(varCodFormulario, 2, varRegistro);
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsGraLineaGenetica.Listar();
        }
    }
}