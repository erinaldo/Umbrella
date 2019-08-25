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

namespace umbAplicacion.Granja.Auxiliar
{
    public partial class xfrmGraAuxDosis : DevExpress.XtraEditors.XtraForm
    {
        private List<clsGraDosisAplicadas> objDetalle;
        private int varSecuencia = 0;

        public xfrmGraAuxDosis()
        {
            InitializeComponent();
        }
        public xfrmGraAuxDosis(int anmCodigoMadre, string anmAlternativo, string IteNombre, bool varConsultar, bool varSinAsignar, int cabCodigo)
        {
            InitializeComponent();
            this.txtAnmCodigoMadre.Text = anmCodigoMadre.ToString();
            this.lblMadre.Text = anmAlternativo + " - " + IteNombre;
            this.datFecha.EditValue = DateTime.Now;
            this.grcListado.Location = new System.Drawing.Point(18, 181);
            this.grcListado.Size = new System.Drawing.Size(772, 242);
            objDetalle = new List<clsGraDosisAplicadas>();
            if (!varConsultar) {
                foreach (clsGraDosisAplicadas objFilaDetalle in clsGraDosisAplicadas.funListar(anmCodigoMadre))
                    objDetalle.Add(objFilaDetalle);
                this.grcListado.DataSource = objDetalle;
                //Recuperamos la ultima secuencia de las dosis aplicadas a la madre
                varSecuencia = clsGraDosisAplicadas.funRecSecuencia(anmCodigoMadre);
            }
            else if (varConsultar && varSinAsignar){
                foreach (clsGraDosisAplicadas objFilaDetalle in clsGraDosisAplicadas.funListar(anmCodigoMadre))
                    objDetalle.Add(objFilaDetalle);
                this.grcListado.DataSource = objDetalle;
                this.proBloquear();
            }
            else if (varConsultar && !varSinAsignar) {
                foreach (clsGraDosisAplicadas objFilaDetalle in clsGraDosisAplicadas.funListar(anmCodigoMadre, cabCodigo))
                    objDetalle.Add(objFilaDetalle);
                this.grcListado.DataSource = objDetalle;
                this.proBloquear();
            }
        }

        private void xfrmGraAuxDosis_Load(object sender, EventArgs e)
        {
            try {
                this.gluAnimal.Properties.DataSource = clsGraDosisAplicadas.funRecMachos();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void gluAnimal_EditValueChanged(object sender, EventArgs e)
        {
            try {
                GridLookUpEdit objGluAnimal = ((GridLookUpEdit)sender);
                object objFilaSeleccionada = objGluAnimal.GetSelectedDataRow();
                if (objFilaSeleccionada != null) {
                    this.txtAnimal.Text = ((System.Data.DataRowView)(objFilaSeleccionada)).Row.ItemArray[2].ToString();
                    this.lueLote.Properties.DataSource = clsGraDosisAplicadas.funRecLotes(((System.Data.DataRowView)(objFilaSeleccionada)).Row.ItemArray[0].ToString());
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lueLote_EditValueChanged(object sender, EventArgs e)
        {
            try {
                this.txtIteCodigo.Text = this.lueLote.GetColumnValue("IteCodigo") == null ? "" : this.lueLote.GetColumnValue("IteCodigo").ToString();
                this.txtIteNombre.Text = this.lueLote.GetColumnValue("IteNombre") == null ? "" : this.lueLote.GetColumnValue("IteNombre").ToString();
                this.txtIteUndInventario.Text = this.lueLote.GetColumnValue("IteUndInventario") == null ? "" : this.lueLote.GetColumnValue("IteUndInventario").ToString();
                this.txtIteTieLote.Text = this.lueLote.GetColumnValue("IteTieLote") == null ? "" : this.lueLote.GetColumnValue("IteTieLote").ToString();
                this.txtDosisDisponibles.Text = this.lueLote.GetColumnValue("IteUndInventario") == null ? "" : this.lueLote.GetColumnValue("StkDisponible").ToString();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            try {
                clsGraDosisAplicadas objFilaDetalle = new clsGraDosisAplicadas() {
                    DapSecuencia = varSecuencia + 1,
                    AnmCodigoMadre = int.Parse(this.txtAnmCodigoMadre.Text),
                    AnmCodigoPadre = gluAnimal.EditValue.ToString() == "" ? 0 : int.Parse(gluAnimal.EditValue.ToString()),
                    AnmAlternativoPadre = gluAnimal.Text,
                    DapDosis = this.txtDosisAplicadas.Text == "" ? 0 : int.Parse(this.txtDosisAplicadas.Text),
                    DapFecha = (DateTime)datFecha.EditValue,
                    IteCodigo = this.txtIteCodigo.Text,
                    IteNombre = this.txtIteNombre.Text,
                    IteUndInventario = this.txtIteUndInventario.Text,
                    IteTieLote = this.txtIteTieLote.Text,
                    DapLote = this.lueLote.Text
                };
                int varDosisAplicadas = 0;
                varDosisAplicadas = int.Parse(objDetalle.Where(p => p.AnmCodigoPadre == objFilaDetalle.AnmCodigoPadre && p.DapLote == objFilaDetalle.DapLote && p.DapNumeroSalidaSAP == null).Sum(p => p.DapDosis).ToString());
                varDosisAplicadas = int.Parse(this.txtDosisDisponibles.Text) - varDosisAplicadas;
                //Verificamos si la fila ingresada cumple con la condiciones
                string varMensaje = objFilaDetalle.funValidarFila(varDosisAplicadas);
                if (!varMensaje.Equals("")) { XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                varSecuencia++;
                objDetalle.Add(objFilaDetalle);
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                proLimpiar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proLimpiar()
        {
            this.datFecha.EditValue = DateTime.Now;
            this.gluAnimal.EditValue = DBNull.Value;
            this.lueLote.EditValue = DBNull.Value;
            this.lueLote.Properties.DataSource = null;
            this.txtAnimal.Text = "";
            this.txtIteNombre.Text = "";
            this.txtIteUndInventario.Text = "";
            this.txtIteTieLote.Text = "";
            this.txtIteCodigo.Text = "";
            this.txtDosisDisponibles.EditValue = 0;
            this.txtDosisAplicadas.EditValue = 0;
        }
        private void proBloquear()
        {
            this.datFecha.Enabled = false;
            this.gluAnimal.Enabled = false;
            this.txtDosisAplicadas.Enabled = false;
            this.lueLote.Enabled = false;
            this.grvListado.OptionsBehavior.ReadOnly = true;
            this.btnActivar.Enabled = false;
            this.butAgregar.Enabled = false;
        }
        private void btnActivar_Click(object sender, EventArgs e)
        {
            try {
                //Asignamos los detalle a un auxiliar 
                List<clsGraDosisAplicadas> objAuxDetalle = objDetalle;
                //Eliminamos las filas que ya han sido enviadas a SAP
                objAuxDetalle.RemoveAll(p => p.DapDocEntrySalidaSAP != null);
                //Enviamos la informacion a Umbrella
                var csRegistro = new clsGraDosisAplicadas();
                int varCodigo =  csRegistro.funMantenimiento(objAuxDetalle);
                //Enviamos la informacion a SAP
                foreach (clsGraDosisAplicadas objAuxFilaDetalle in objAuxDetalle)
                    objAuxFilaDetalle.funEnviarSalMercanciaSAP();
                XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

       
    }
}