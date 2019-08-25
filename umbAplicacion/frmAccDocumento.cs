using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella
{
    public partial class frmAccDocumento : Form
    {
        public frmAccDocumento(DataTable dtDocumentos)
        {
            InitializeComponent();
            this.grcListado.DataSource = dtDocumentos;
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grvListado.GetRow(this.grvListado.FocusedRowHandle) != null)
                {
                    DrVarFila = this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                    this.Close();
                }
                else XtraMessageBox.Show( "Debe selecionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public Object drVarFila;
        public Object DrVarFila
        {
            get { return drVarFila; }
            set { drVarFila = value; }
        }
    }
}
