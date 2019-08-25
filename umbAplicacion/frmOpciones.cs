using System;
using System.Drawing;
using System.Windows.Forms;
using umbNegocio;

namespace umbAplicacion
{
    public partial class frmOpciones : DevExpress.XtraEditors.XtraForm
    {
        clsGenOpciones obj = new clsGenOpciones();

        public frmOpciones()
        {
            InitializeComponent();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            dtgLista.DataSource = obj.Listar();
        }

        private void dtgLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dtgLista.Rows[e.RowIndex].Cells["colT"].Value.ToString() == "Grupo")
                {
                    dtgLista.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        dtgLista.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
                    dtgLista.Rows[e.RowIndex].DefaultCellStyle.ForeColor =
                        dtgLista.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void dtgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dtgLista.Rows[e.RowIndex];

                if (row.Cells["colT"].Value.ToString() != "Grupo")
                {
                    if (new frmOpcionEdit(row.Cells["colId"].Value.ToString(),
                        row.Cells["colD"].Value.ToString().Trim(),
                        row.Cells["colT"].Value.ToString(),
                        int.Parse(row.Cells["colML"].Value.ToString())).ShowDialog(this) == DialogResult.OK)
                    {
                        dtgLista.DataSource = obj.Listar();
                    }
                }
            }
        }
    }
}
