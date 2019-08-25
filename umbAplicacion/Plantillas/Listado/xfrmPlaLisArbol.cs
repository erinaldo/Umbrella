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
using System.IO;
using DevExpress.XtraPrinting;

namespace umbAplicacion.Plantillas.Listado
{
    public partial class xfrmPlaLisArbol : DevExpress.XtraEditors.XtraForm
    {
        public int varCodFormulario = 0;
        public int varCodOperacion = 0;
        public string varTitulo = "";
        public bool varBanListado = false;
        
        public xfrmPlaLisArbol()
        {
            InitializeComponent();
        }
        private void xfrmPlaLisArbol_Load(object sender, EventArgs e) { proIniciarFormulario(); }
        private void xfrmPlaLisArbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnNuevo.PerformClick();
            else if (e.Control && e.KeyCode == Keys.M) btnModificar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.D) btnEliminar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.O) btnConsultar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Q) btnCerrar.PerformClick();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e) { proNuevo(); }
        private void btnModificar_Click(object sender, EventArgs e) { proModificar(); }
        private void btnEliminar_Click(object sender, EventArgs e) { proEliminar(); }
        private void btnConsultar_Click(object sender, EventArgs e) { proConsultar(); }
        private void btnCerrar_Click(object sender, EventArgs e) { proCerrar(); }
        private void treListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (varBanListado)
                {
                    DrVarFila = this.treListado.GetDataRecordByNode(treListado.FocusedNode);
                    this.Close();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        public virtual void proIniciarFormulario() { }
        public virtual void proNuevo() { varCodOperacion = 1; } //Operacion utilizada para nuevo 
        public virtual void proModificar() { varCodOperacion = 2; } //Operacion utilizada para modificar
        public virtual void proEliminar() { varCodOperacion = 3; } //Operacion utilizada para eliminar
        public virtual void proConsultar() { varCodOperacion = 4; } //Operacion utilizada para consultar
        public virtual void proCerrar() { this.Close(); }
        public virtual void proCopiar() {  }

        public Object drVarFila;
        public Object DrVarFila
        {
            get { return drVarFila; }
            set { drVarFila = value; }
        }

        

        

        
    }
}