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
using umbAplicacion.Inventario.Listado;
using umbNegocio.Inventario;
using umbAplicacion.Compras.Impresion;
using umbNegocio.Compra;
using System.Configuration;

namespace umbAplicacion.Compras.Otros
{
    public partial class xfrmComEtiqueta15X10 : DevExpress.XtraEditors.XtraForm
    {
        public xfrmComEtiqueta15X10() {
            InitializeComponent();
            this.datFecProduccion.EditValue = DateTime.Now;
            this.memLeyenda1.EditValue = "TIEMPO MAXIMO DE CONSUMO 12 MESES";
            this.memLeyenda2.EditValue = "MANTENERSE EN CONGELACIÓN";
            this.txtNroImpresion.EditValue = 1;
            this.txtCantidad.EditValue = 1;
        }
        private void bedItemSAP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e){
            try {
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null) this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                    else bedItem.Text = "";
                }
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_EditValueChanged(object sender, EventArgs e) {
            try {
                string varItemCode = this.bedItem.Text.Trim();

                this.txtItemNombre.EditValue = "";
                if (varItemCode.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varItemCode))
                    this.txtItemNombre.EditValue = csRegistro.ItemName;

            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            try {
                string varIteNombre = this.txtItemNombre.EditValue.ToString();
                string varLote = this.txtLote.Text;
                string varFecha = ((DateTime)this.datFecProduccion.EditValue).ToString("dd/MM/yyyy");
                string varLeyenda1 = this.memLeyenda1.EditValue.ToString();
                string varLeyenda2 = this.memLeyenda2.EditValue.ToString();
                string varLeyenda3 = this.memLeyenda3.EditValue.ToString();
                string varCantidad = ((int)this.txtCantidad.EditValue).ToString();
                int varNroImpresion = (int)this.txtNroImpresion.EditValue;
                crtEtiquetaCarnesCartones objImpresion = new crtEtiquetaCarnesCartones();
                DataTable dtValoresEtiqueta = daoComEtiqueta.getInstance().funImprimirEtiqueta15X10(varIteNombre, varLote, varFecha, varLeyenda1, varLeyenda2, varLeyenda3, varCantidad);
                objImpresion.SetDataSource(dtValoresEtiqueta);
                objImpresion.PrintOptions.PrinterName = ConfigurationManager.AppSettings["ImpresoraEtiquetaCaja"];
                objImpresion.PrintToPrinter(varNroImpresion, false, 0, 1);
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}