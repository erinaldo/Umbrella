using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Granja.Mantenimiento;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisMotivoPerdida : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisMotivoPerdida()
        {
            InitializeComponent();
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            //Asignamos el titulo que tendra el formulario
            this.Text = "Motivos de mortalidad (perdidas)";
            const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisMotivoPerdida";
            foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
            //Accesos del formulario para el usuario ingresado
            varCodDocumento = 1;
            this.proAccesoFormulario();
            grcListado.DataSource = clsGraMotPerdida.Listar();
        }
        public override void proNuevo()
        {
            base.proNuevo();
            xfrmGraManMotivoPerdida frmFormulario = new xfrmGraManMotivoPerdida(varCodFormulario, varCodOperacion, 0);
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsGraMotPerdida.Listar();
        }
        public override void proModificar()
        {
            base.proModificar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                int varRegistro = ((clsGraMotPerdida)this.grvListado.GetRow(varPosicion)).Id;
                xfrmGraManMotivoPerdida frmFormulario = new xfrmGraManMotivoPerdida(varCodFormulario, varCodOperacion, varRegistro);
                frmFormulario.ShowDialog(this);
            }
            this.grvListado.ClearSelection();
            grcListado.DataSource = clsGraMotPerdida.Listar();
        }
        public override void proEliminar()
        {
           base.proEliminar();
           foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
               clsGraMotPerdida obj = new clsGraMotPerdida();
               obj.Id = ((clsGraMotPerdida)this.grvListado.GetRow(varPosicion)).Id;
               if (XtraMessageBox.Show(string.Format("Esta seguro de eliminar los registro nro {0}", obj.Id), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes &&
                    obj.ejecutarMantenimiento(3) >= 0)
                   XtraMessageBox.Show("El registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           grcListado.DataSource = clsGraMotPerdida.Listar();
        }
        public override void proConsultar()
        {
            base.proConsultar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows())
            {
                int varRegistro = ((clsGraMotPerdida)this.grvListado.GetRow(varPosicion)).Id;
                xfrmGraManMotivoPerdida frmFormulario = new xfrmGraManMotivoPerdida(varCodFormulario, varCodOperacion, varRegistro);
                frmFormulario.ShowDialog(this);
                this.grvListado.ClearSelection();
            }
        }
        
    }
}