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
using Umbrella;
using umbNegocio;
using umbNegocio.Seguridad;

namespace umbAplicacion.Plantillas.Listado
{
    public partial class xfrmPlaListado : DevExpress.XtraEditors.XtraForm
    {
        public int varCodFormulario = 0;
        public int varCodOperacion = 0;
        public int varCodDocumento = 0;
        public string varTitulo = "";
        public bool varBanListado = false;
        public bool varBanAcceso = true;
        public string varWhere = "";

        public xfrmPlaListado()
        {
            InitializeComponent();
        }
        private void xfrmPlaListado_Load(object sender, EventArgs e) { proIniciarFormulario(); }
        private void xfrmPlaListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnNuevo.PerformClick();
            else if (e.Control && e.KeyCode == Keys.M) btnModificar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.D) btnEliminar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.O) btnConsultar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Q) btnCerrar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.X) tsmExcel.PerformClick();
            else if (e.Control && e.KeyCode == Keys.W) tsmWord.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F) tsmPdf.PerformClick();
            else if (e.Control && e.KeyCode == Keys.H) tsmHtml.PerformClick();
        }

        private void btnNuevo_Click(object sender, EventArgs e) { proNuevo(); }
        private void btnModificar_Click(object sender, EventArgs e) { proModificar(); }
        private void btnEliminar_Click(object sender, EventArgs e) { proEliminar(); }
        private void btnConsultar_Click(object sender, EventArgs e) { proConsultar(); }
        private void btnCerrar_Click(object sender, EventArgs e) { proCerrar(); }
        private void tsmCopiar_Click(object sender, EventArgs e) { proCopiar(); }
        private void tsmExcel_Click(object sender, EventArgs e) { proExcel(); }
        private void tsmWord_Click(object sender, EventArgs e) { proWord(); }
        private void tsmPdf_Click(object sender, EventArgs e) { proPdf(); }
        private void tsmHtml_Click(object sender, EventArgs e) { proHtml(); }
        private void grcListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (varBanListado)
                {
                    if (this.grvListado.GetSelectedRows().Count().Equals(0))
                        DrVarFila.Add(this.grvListado.GetRow(this.grvListado.FocusedRowHandle));
                    else
                        foreach (int varPosicion in this.grvListado.GetSelectedRows())
                            DrVarFila.Add(this.grvListado.GetRow(varPosicion));
                    this.Close();
                }
                else
                    if (this.btnModificar.Enabled) proModificar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public virtual void proIniciarFormulario() {}
        public virtual void proNuevo() { varCodOperacion = 1; } //Operacion utilizada para nuevo 
        public virtual void proModificar() { 
            varCodOperacion = 2;
            //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
            int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 2);
            //Si ya ha sido enviado a SAP terminamos el proceso
            if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para modificar el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); varBanAcceso = false; }
        } //Operacion utilizada para modificar
        public virtual void proEliminar() { 
            varCodOperacion = 3;
            //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
            int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 3);
            //Si ya ha sido enviado a SAP terminamos el proceso
            if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para eliminar el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); varBanAcceso = false; }
        } //Operacion utilizada para eliminar
        public virtual void proConsultar() { 
            varCodOperacion = 4;
            //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
            int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 4);
            //Si ya ha sido enviado a SAP terminamos el proceso
            if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para consultar el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); varBanAcceso = false; }
        } //Operacion utilizada para consultar
        public virtual void proCerrar() { this.Close(); }
        public virtual void proCopiar() {  }
        
        public virtual void proExcel() 
        {
            try
            {
                this.saveFileDialog.FileName = "";
                this.saveFileDialog.Filter = "Microsoft Excel|*.xlsx";
                this.saveFileDialog.FilterIndex = 2;
                this.saveFileDialog.RestoreDirectory = true;

                Stream filename;
                string varNombre;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = this.saveFileDialog.OpenFile();
                    varNombre = this.saveFileDialog.FileName;

                    if (filename != null)
                    {
                        filename.Close();
                        this.grvListado.ExportToXlsx(varNombre);
                    }
                    proAbrirArchivo(varNombre);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public virtual void proWord()
        {
            try
            {
                PrintableComponentLink w = new DevExpress.XtraPrinting.PrintableComponentLink(new PrintingSystem());
                w.Component = grcListado;
                w.CreateReportHeaderArea += w_CreateReportHeaderArea;

                this.saveFileDialog.FileName = "";
                this.saveFileDialog.Filter = "Microsoft Word|*.doc";
                this.saveFileDialog.FilterIndex = 2;
                this.saveFileDialog.RestoreDirectory = true;

                Stream filename;
                string varNombre;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = this.saveFileDialog.OpenFile();
                    varNombre = this.saveFileDialog.FileName;

                    if (filename != null)
                    {
                        filename.Close();
                        w.ExportToRtf(varNombre);
                    }
                    proAbrirArchivo(varNombre);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public virtual void proPdf()
        {
            try
            {
                PrintableComponentLink y = new DevExpress.XtraPrinting.PrintableComponentLink(new PrintingSystem());
                y.Component = grcListado;
                y.CreateReportHeaderArea += y_CreateReportHeaderArea;

                this.saveFileDialog.FileName = "";
                this.saveFileDialog.Filter = "Adobe PDF|*.pdf";
                this.saveFileDialog.FilterIndex = 2;
                this.saveFileDialog.RestoreDirectory = true;

                Stream filename;
                string varNombre;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = this.saveFileDialog.OpenFile();
                    varNombre = this.saveFileDialog.FileName;

                    if (filename != null)
                    {
                        filename.Close();
                        y.ExportToPdf(varNombre);
                    }
                    proAbrirArchivo(varNombre);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public virtual void proHtml() 
        {
            try
            {
                this.saveFileDialog.FileName = "";
                this.saveFileDialog.Filter = "HTML Documents|*.html";
                this.saveFileDialog.FilterIndex = 2;
                this.saveFileDialog.RestoreDirectory = true;

                Stream filename;
                string varNombre;

                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = this.saveFileDialog.OpenFile();
                    varNombre = this.saveFileDialog.FileName;

                    if (filename != null)
                    {
                        filename.Close();
                        this.grvListado.ExportToHtml(varNombre);
                    }
                    proAbrirArchivo(varNombre);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void proAbrirArchivo(string varNombre)
        {
            try
            {
                if (MessageBox.Show("Desea abrir el archivo.... ", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) System.Diagnostics.Process.Start(varNombre);
            }
            catch (Exception) { throw; }
        }
        private void y_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
             e.Graph.DrawImage(global::umbAplicacion.Properties.Resources.imgLogoListado, new RectangleF(0, 0, 160, 50), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent);

             DevExpress.XtraPrinting.TextBrick brick;
             brick = e.Graph.DrawString(varTitulo, Color.Navy, new RectangleF(160, 0, 340, 50), DevExpress.XtraPrinting.BorderSide.None);
             brick.Font = new Font("Times New Roman", 16);
             brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);

        }
        private void w_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            e.Graph.DrawImage(global::umbAplicacion.Properties.Resources.imgLogoListado, new RectangleF(0, 0, 160, 50), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent);

            DevExpress.XtraPrinting.TextBrick brick;
            brick = e.Graph.DrawString(varTitulo, Color.Navy, new RectangleF(160, 0, 340, 50), DevExpress.XtraPrinting.BorderSide.None);
            brick.Font = new Font("Times New Roman", 16);
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);

        }

        public List<object> drVarFila = new List<object>();
        public List<object> DrVarFila
        {
            get { return drVarFila; }
            set { drVarFila = value; }
        }

        public void proAccesoFormulario()
        {
            try {
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
        

       

        

        
    }
}