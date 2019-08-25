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
    public partial class frmAccVariante : Form
    {
        public frmAccVariante(DataTable dtVariantes)
        {
            InitializeComponent();
            this.grcListado.DataSource = dtVariantes;
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
                else XtraMessageBox.Show( "Debe selecionar una variante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
