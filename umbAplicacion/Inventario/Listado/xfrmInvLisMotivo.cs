using umbAplicacion.Inventario.Mantenimiento;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;
using Umbrella;
using System.Windows.Forms;
using System;
using DevExpress.XtraEditors;

namespace umbAplicacion.Inventario.Listado
{
    public partial class xfrmInvLisMotivo : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmInvLisMotivo()
        {
            InitializeComponent();
        }
        public xfrmInvLisMotivo(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            //Asignamos el titulo que tendra el formulario
            this.Text = "Tipos de movimiento";
            const string varNomFormulario = "umbAplicacion.Inventario.Listado.xfrmInvLisMotivo";
            foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
            //Accesos del formulario para el usuario ingresado
            varCodDocumento = 1;
            this.proAccesoFormulario();

            grcListado.DataSource = clsInvMotivo.Listar();
        }
        public override void proNuevo()
        {
            base.proNuevo();
            xfrmInvManMotivo frmFormulario = new xfrmInvManMotivo(varCodFormulario, varCodOperacion, 0);
            if (frmFormulario.ShowDialog(this) == DialogResult.OK)
                grcListado.DataSource = clsInvMotivo.Listar();
        }
        public override void proModificar()
        {
            base.proModificar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                int varRegistro = ((clsInvMotivo)this.grvListado.GetRow(varPosicion)).Id;
                xfrmInvManMotivo frmFormulario = new xfrmInvManMotivo(varCodFormulario, varCodOperacion, varRegistro);
                frmFormulario.ShowDialog(this);
            }
            this.grvListado.ClearSelection();
            grcListado.DataSource = clsInvMotivo.Listar();
        }
        public override void proEliminar()
        {
            base.proEliminar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                clsInvMotivo obj = new clsInvMotivo();
                obj.Id = ((clsInvMotivo)this.grvListado.GetRow(varPosicion)).Id;
                if (XtraMessageBox.Show(string.Format("Esta seguro de eliminar los registro nro {0}", obj.Id), "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes &&
                    obj.ejecutarMantenimiento(3) >=0)
                    XtraMessageBox.Show("El registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            grcListado.DataSource = clsInvMotivo.Listar();
        }
        public override void proConsultar()
        {
            base.proConsultar();
            foreach (int varPosicion in this.grvListado.GetSelectedRows())
            {
                int varRegistro = ((clsInvMotivo)this.grvListado.GetRow(varPosicion)).Id;
                xfrmInvManMotivo frmFormulario = new xfrmInvManMotivo(varCodFormulario, varCodOperacion, varRegistro);
                frmFormulario.ShowDialog(this);
                this.grvListado.ClearSelection();
            }
        }
    }
}