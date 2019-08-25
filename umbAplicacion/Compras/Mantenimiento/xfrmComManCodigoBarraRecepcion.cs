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
using umbNegocio.Compra;
using umbAplicacion.Compras.Impresion;

namespace umbAplicacion.Compras.Mantenimiento
{
    public partial class xfrmComManCodigoBarraRecepcion : DevExpress.XtraEditors.XtraForm
    {
        public xfrmComManCodigoBarraRecepcion()
        {
            InitializeComponent();
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try {
                string varCabNumero = this.txtNumero.Text.Trim();
                if (!varCabNumero.Equals("")) {
                    List<clsComCodigoBarraRep> objListado = clsComCodigoBarraRep.proListarEntMercanciaCompra(int.Parse(varCabNumero));
                    if (objListado.Count > 0) {
                        this.txtNomSerie.Text = objListado[0].DocNombre;
                        //this.txtCodigo.Text = objListado[0].PrvCodigo;
                        //this.txtNombre.Text = objListado[0].PrvNombre;
                        //this.txtFecha.Text = objListado[0].CabFecha.ToShortDateString();

                        this.grcDetalle.DataSource = objListado;
                    }
                    else { XtraMessageBox.Show("Documento de entrada de sap no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { XtraMessageBox.Show("Debe digitar el numero de entrada de sap para poder extraer la informacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ibuImpresion_Click(object sender, EventArgs e)
        {
            try {
                string varDocNombre = this.txtNomSerie.Text;
                int varCabNumero = int.Parse(this.txtNumero.Text);
                string varPrvCodigo = "";//this.txtCodigo.Text;
                string varPrvNombre = ""; // this.txtNombre.Text;
                DateTime varCabFecha = DateTime.Now;// DateTime.Parse(this.txtFecha.Text);
                string varIteCodigo = ((clsComCodigoBarraRep)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).IteCodigo;
                string varIteNombre = ((clsComCodigoBarraRep)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).IteNombre;
                string varDetLote = ((clsComCodigoBarraRep)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).DetLote;
                decimal varDetCantidad = ((clsComCodigoBarraRep)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).DetCantidad;
                int varNroImpresion = ((clsComCodigoBarraRep)grvDetalle.GetRow(grvDetalle.FocusedRowHandle)).DetNro;
                int varCodigoBarra = clsComCodigoBarraRep.funMantenimiento(varDocNombre, varCabNumero, varCabFecha, varPrvCodigo, varPrvNombre, varIteCodigo, varIteNombre, varDetLote, varDetCantidad);
                crtEtiquetaCarnesBPM objImpresionEtiquetaBPM = new crtEtiquetaCarnesBPM();
                DataTable dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiquetaBPM(varCodigoBarra);
                objImpresionEtiquetaBPM.SetDataSource(dtValoresEtiqueta);
                objImpresionEtiquetaBPM.PrintOptions.PrinterName = "ZDesigner ZT230-200dpi ZPL";
                objImpresionEtiquetaBPM.PrintToPrinter(varNroImpresion, false, 0, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}