using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.General;
using umbNegocio.Inventario;
using Umbrella;
using umbAplicacion.Finanzas.Listado;
using umbNegocio.Finanzas;

namespace umbAplicacion.Inventario.Mantenimiento
{
    public partial class xfrmInvManMotivo : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private clsInvMotivo obj = new clsInvMotivo();

        public xfrmInvManMotivo()
        {
            InitializeComponent();
        }
        public xfrmInvManMotivo(int varFormulario, int varOperacion, int varRegistro)
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
            this.Text = "Tipos de movimiento";
            switch (varOpeCodigo)
            {
                case 1: // New
                    this.cmbTipo.SelectedIndex = 0;
                    this.chkRequerido.Checked = false;
                    break;
                case 2: // Edit
                case 4: //Find
                    obj = clsInvMotivo.Cargar(varRegCodigo)[0];
                    if (obj != null)
                    {
                        txtId.Text = obj.Id.ToString();
                        txtNombre.Text = obj.Nombre;
                        bedCtaContable.Text = obj.OACTFormat;
                        txtCtaContable.Text = obj.OACTName;
                        txtCodCtaContable.Text = obj.OACTCode;
                        txtCenCosto.Text = obj.ListaCenCosto;
                        txtProyecto.Text = obj.ListaProyecto;
                        cmbTipo.Text = obj.TipoMovimiento;
                        txtBodega.Text = obj.ListaBodega;
                        chkRequerido.Checked = obj.Requerido;
                    }
                    break;
                case 3:
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
                obj.Id = int.Parse(txtId.Text);
                obj.Nombre = this.txtNombre.Text;
                obj.OACTCode = this.txtCodCtaContable.Text;
                obj.OACTName = this.txtCtaContable.Text;
                obj.OACTFormat = this.bedCtaContable.Text;
                obj.ListaCenCosto = this.txtCenCosto.Text;
                obj.ListaProyecto = this.txtProyecto.Text;
                obj.TipoMovimiento = this.cmbTipo.Text;
                obj.ListaBodega = this.txtBodega.Text;
                obj.Requerido = this.chkRequerido.Checked;

                if (obj.ejecutarMantenimiento(varOpeCodigo) >= 0) {
                    XtraMessageBox.Show("Registro grabado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else MessageBox.Show("No se pudo realizar la operación solicitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCtaContable_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de cuentas contables
                using (xfrmFinLisPlaCuenta frmFormulario = new xfrmFinLisPlaCuenta(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedCtaContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueFormato;
                        this.txtCtaContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueNombre;
                        this.txtCodCtaContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueCodigo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCtaContable_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varFormatCode = this.bedCtaContable.Text.Trim();

                this.txtCtaContable.Text = "";
                this.txtCodCtaContable.Text = "";
                if (varFormatCode.Length < 14) return;

                foreach (clsFinPlaCuenta csRegistro in clsFinPlaCuenta.funListar(varFormatCode)) {
                    this.txtCtaContable.Text = csRegistro.CueNombre;
                    this.txtCodCtaContable.Text = csRegistro.CueCodigo;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
