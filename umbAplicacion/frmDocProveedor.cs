using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umbrella
{
    public partial class frmDocProveedor : Form
    {
        public frmDocProveedor(DataTable dtDocumentos)
        {
            InitializeComponent();
            this.grcListado.DataSource = dtDocumentos;
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvListado.GetSelectedRows().Count() > 0)
                {
                    int x = 0;
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        if (x.Equals(0))
                            DrVarFila = this.grvListado.GetDataRow(varPosicion)["DocEntry"].ToString();
                        else
                            DrVarFila = DrVarFila + "," + this.grvListado.GetDataRow(varPosicion)["DocEntry"].ToString();
                        x++;
                    }
                    this.Close();
                }
                else XtraMessageBox.Show( "Debe selecionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public string drVarFila;
        public string DrVarFila
        {
            get { return drVarFila; }
            set { drVarFila = value; }
        }
    }
}
