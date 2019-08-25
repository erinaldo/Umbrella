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

namespace umbAplicacion.Granja.Auxiliar
{
    public partial class xfrmGraAuxActivacion : DevExpress.XtraEditors.XtraForm
    {
        public DateTime varFecActivacion;
        public decimal varPsoActivacion;

        public xfrmGraAuxActivacion()
        {
            InitializeComponent();
            this.lblPsoFormacion.Location = new System.Drawing.Point(257, 23);
            datFecActivacion.EditValue = DateTime.Now;
            txtPsoFormacion.Text = "0";
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try {
                if (txtPsoFormacion.Text.Equals("0.000")) { XtraMessageBox.Show("El peso de activacion es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = System.Windows.Forms.DialogResult.None; return; }
                if (datFecActivacion.EditValue == null) { XtraMessageBox.Show("La fecha de activacion es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.DialogResult = System.Windows.Forms.DialogResult.None; return; }
                varFecActivacion = (DateTime)datFecActivacion.EditValue;
                varPsoActivacion = decimal.Parse(this.txtPsoFormacion.Text);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
    }
}