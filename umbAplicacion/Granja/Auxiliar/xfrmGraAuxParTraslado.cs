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
using umbNegocio.Granja;
using umbNegocio.Inventario;
using umbAplicacion.Inventario.Listado;
using umbNegocio.Finanzas;
using umbAplicacion.Finanzas.Listado;
using umbNegocio.General;

namespace umbAplicacion.Granja.Auxiliar
{
    public partial class xfrmGraAuxParTraslado : DevExpress.XtraEditors.XtraForm
    {
        clsGraParTrasladoDet objFilaDetalle;

        public xfrmGraAuxParTraslado()
        {
            InitializeComponent();
        }
        public xfrmGraAuxParTraslado(clsGraParTrasladoDet objFila, int varOperacion)
        {
            try {
                InitializeComponent();
                //Asignamos a la variable global la clase instanciada 
                objFilaDetalle = objFila;
                this.lueBodega.Properties.DataSource = clsGenBodega.funListar();
                //Verificamos la operacion a realizar por el usuario
                switch (varOperacion) {
                    case 1: //Operacion de agregar
                        this.cmbMovTipo.SelectedIndex = 0;
                        this.cmbMovUndTipo.SelectedIndex = 0;
                        this.cmbDiaTipo.SelectedIndex = 0;
                        this.lueBodega.ItemIndex = 0;
                        break;
                    case 2: //Operacion de actualizar
                        this.cmbMovTipo.Text = objFilaDetalle.PtrMovTipo;
                        this.bedMovimiento.EditValue = objFilaDetalle.MovCodigo;
                        this.txtMovNombre.Text = objFilaDetalle.MovNombre;
                        this.bedItem.Text = objFilaDetalle.IteCodigo;
                        this.txtIteNombre.Text = objFilaDetalle.IteNombre;
                        this.lueBodega.EditValue = objFilaDetalle.BodCodigo;
                        this.txtCtaCodigo.Text = objFilaDetalle.CtaMovCodigo;
                        this.txtCtaFormato.Text = objFilaDetalle.CtaMovFormato;
                        this.txtCtaNombre.Text = objFilaDetalle.CtaMovNombre;
                        this.cmbMovUndTipo.Text = objFilaDetalle.PtrMovTipoUnidad;
                        this.txtMovCosto.Text = objFilaDetalle.PtrMovCstCalculo;
                        this.txtMovObservacion.Text = objFilaDetalle.PtrMovObservacion;
                        this.cmbDiaTipo.Text = objFilaDetalle.PtrDiaTipo;
                        this.bedCtaContable.Text = objFilaDetalle.CtaDiaFormato;
                        this.txtCtaCodigoDes.Text = objFilaDetalle.CtaDiaCodigo;
                        this.txtCtaNombreDes.Text = objFilaDetalle.CtaDiaNombre;
                        this.txtDiaCalculaDebe.Text = objFilaDetalle.PtrDiaDebeCalculo;
                        this.txtDiaCalculoHaber.Text = objFilaDetalle.PtrDiaHaberCalculo;
                        this.txtDiaObservacion.Text = objFilaDetalle.PtrDiaObservacion;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Eventos del formulario
        //Eventos para confirmar los cambios
        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                objFilaDetalle.PtrMovTipo = this.cmbMovTipo.Text;
                objFilaDetalle.MovCodigo = this.bedMovimiento.EditValue.ToString().Equals("") ? 0 : int.Parse(this.bedMovimiento.EditValue.ToString());
                objFilaDetalle.MovNombre = this.txtMovNombre.Text;
                objFilaDetalle.IteCodigo = this.bedItem.Text;
                objFilaDetalle.IteNombre = this.txtIteNombre.Text;
                objFilaDetalle.BodCodigo =  this.lueBodega.EditValue == null || this.lueBodega.EditValue.ToString().Equals("")  ? 0 : int.Parse(lueBodega.EditValue.ToString());
                objFilaDetalle.BodNombre = this.lueBodega.Text;
                objFilaDetalle.CtaMovCodigo = this.txtCtaCodigo.Text;
                objFilaDetalle.CtaMovFormato = this.txtCtaFormato.Text;
                objFilaDetalle.CtaMovNombre = this.txtCtaNombre.Text;
                objFilaDetalle.PtrMovTipoUnidad = this.cmbMovUndTipo.Text;
                objFilaDetalle.PtrMovCstCalculo = this.txtMovCosto.Text;
                objFilaDetalle.PtrMovObservacion = this.txtMovObservacion.Text;
                objFilaDetalle.PtrDiaTipo = this.cmbDiaTipo.Text;
                objFilaDetalle.CtaDiaFormato = this.bedCtaContable.Text;
                objFilaDetalle.CtaDiaCodigo = this.txtCtaCodigoDes.Text;
                objFilaDetalle.CtaDiaNombre = this.txtCtaNombreDes.Text;
                objFilaDetalle.PtrDiaDebeCalculo = this.txtDiaCalculaDebe.Text;
                objFilaDetalle.PtrDiaHaberCalculo = this.txtDiaCalculoHaber.Text;
                objFilaDetalle.PtrDiaObservacion = this.txtDiaObservacion.Text;
                string varMensaje = objFilaDetalle.funValidarFila();
                if (!varMensaje.Equals("")) {
                    XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = System.Windows.Forms.DialogResult.None; 
                    return;
                }
            }
            catch (Exception ex) { 
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.None; 
            }
        }
        //Eventos para el movimiento
        private void bedMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos el codigo del movimiento digitado
                int varMovCodigo = int.Parse(this.bedMovimiento.Text.Trim());
                this.txtMovNombre.Text = "";
                this.txtCtaCodigo.Text = "";
                this.txtCtaNombre.Text = "";
                this.txtCtaFormato.Text = "";
               //Recuperamos la informacion del código digitado
                foreach (clsInvMotivo csRegistro in clsInvMotivo.Cargar(varMovCodigo)) {
                    this.bedMovimiento.EditValue = csRegistro.Id;
                    this.txtMovNombre.Text = csRegistro.Nombre;
                    this.txtCtaCodigo.Text = csRegistro.OACTCode;
                    this.txtCtaNombre.Text = csRegistro.OACTName;
                    this.txtCtaFormato.Text = csRegistro.OACTFormat;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedMovimiento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisMotivo frmFormulario = new xfrmInvLisMotivo(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedMovimiento.EditValue = ((clsInvMotivo)frmFormulario.DrVarFila[0]).Id;
                        this.txtMovNombre.Text = ((clsInvMotivo)frmFormulario.DrVarFila[0]).Nombre;
                        this.txtCtaCodigo.Text = ((clsInvMotivo)frmFormulario.DrVarFila[0]).OACTCode;
                        this.txtCtaNombre.Text = ((clsInvMotivo)frmFormulario.DrVarFila[0]).OACTName;
                        this.txtCtaFormato.Text = ((clsInvMotivo)frmFormulario.DrVarFila[0]).OACTFormat;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos para el item
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos el codigo del item digitado
                string varIteCodigo = this.bedItem.Text.Trim();
                this.txtIteNombre.Text = "";
                //Verificamos si el codigo digitado es de 8 a mas digitos
                if (varIteCodigo.Length < 8) return;
                //Recuperamos la informacion del código digitado
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)) {
                    this.bedItem.EditValue = csRegistro.ItemCode;
                    this.txtIteNombre.Text = csRegistro.ItemName;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtIteNombre.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos para la cuenta contable de desviacion
        private void bedCtaContable_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos el codigo de la cuenta contable digitado
                string varFormatCode = this.bedCtaContable.Text.Trim();
                this.txtCtaNombreDes.Text = "";
                this.txtCtaCodigoDes.Text = "";
                //Verificamos si el codigo digitado es de 14 a mas digitos
                if (varFormatCode.Length < 14) return;
                //Recuperamos la informacion del código digitado
                foreach (clsFinPlaCuenta csRegistro in clsFinPlaCuenta.funListar(varFormatCode)) {
                    this.txtCtaNombreDes.Text = csRegistro.CueNombre;
                    this.txtCtaCodigoDes.Text = csRegistro.CueCodigo;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCtaContable_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de plan de cuentas
                using (xfrmFinLisPlaCuenta frmFormulario = new xfrmFinLisPlaCuenta(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedCtaContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueFormato;
                        this.txtCtaNombreDes.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueNombre;
                        this.txtCtaCodigoDes.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueCodigo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}