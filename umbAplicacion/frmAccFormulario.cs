using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Seguridad.Listado;
using umbNegocio.Seguridad;

namespace umbAplicacion
{
    public partial class frmAccFormulario : Form
    {
        private string varUsuCodigo = "";
        private string varUsuNombre = "";
        private DataTable dtAccMenu;
        private DataTable dtAccFormulario;
        private DataTable dtAccDocumento;
        private DataTable dtAccOperacion;
        private DataTable dtAccCampo;

        public frmAccFormulario()
        {
            InitializeComponent();
        }
        public frmAccFormulario(string varCodigo, string varNombre)
        {
            InitializeComponent();
            varUsuCodigo = varCodigo;
            varUsuNombre = varNombre;
        }
        private void frmAccMenu_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Acceso de formularios";
                this.txtCodigo.Text = varUsuCodigo;
                this.txtNombre.Text = varUsuNombre;

                this.proDtAccMenu();
                this.proDtAccFormulario();
                this.proDtAccDocumento();
                this.proDtAccOperacion();
                this.proDtAccCampo();

                var lisGeneral = new clsSegAccMenu();
                this.grcListado.DataSource = lisGeneral.funListarDt(varUsuCodigo);

                this.proCargarFormularios(lisGeneral, 0);
                foreach (DataRow drFilaFormulario in dtAccMenu.Select("MenNombre = 'Documentos'")) this.proCargarDocumentos(int.Parse(drFilaFormulario["FrmCodigo"].ToString()), int.Parse(drFilaFormulario["MenCodigo"].ToString()), int.Parse(dtAccMenu.Compute("Max(MenCodigo)","").ToString()) + 1);
                foreach (DataRow drFilaDocumento in dtAccMenu.Select("MenNombre = 'Operaciones'")) this.proCargarOperaciones(int.Parse(drFilaDocumento["FrmCodigo"].ToString()), int.Parse(drFilaDocumento["DocCodigo"].ToString()), int.Parse(drFilaDocumento["MenCodigo"].ToString()), int.Parse(dtAccMenu.Compute("Max(MenCodigo)", "").ToString()) + 1);
                foreach (DataRow drFilaOperacion in dtAccMenu.Select("MenNombre = 'Campos bloqueados'")) this.proCargarCampos(int.Parse(drFilaOperacion["FrmCodigo"].ToString()), int.Parse(drFilaOperacion["DocCodigo"].ToString()), int.Parse(drFilaOperacion["OpeCodigo"].ToString()), int.Parse(drFilaOperacion["MenCodigo"].ToString()), int.Parse(dtAccMenu.Compute("Max(MenCodigo)", "").ToString()) + 1);
                
                
                DataRow drFila = this.grvListado.GetDataRow(0);

                dtAccMenu.DefaultView.Sort = "MenCodigo";
                int varFormulario = int.Parse(drFila["FrmCodigo"].ToString());
                treListado.DataSource = dtAccMenu.Select( string.Format("FrmCodigo = {0}", varFormulario)).CopyToDataTable().DefaultView;
                treListado.ExpandAll();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var csRegistro = new clsSegAccFormulario()
                {
                    UsuCodigo = this.txtCodigo.Text,
                    dtAccFormulario = dtAccFormulario,
                    dtAccDocumento = dtAccDocumento,
                    dtAccOperacion = dtAccOperacion,
                    dtAccCampo = dtAccCampo
                };

                csRegistro.funMantenimiento(csRegistro);
                XtraMessageBox.Show("Registro guardado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grvListado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (this.grvListado.RowCount > 0 && grvListado.GetFocusedRow() != null && this.grvListado.FocusedRowHandle >= 0)
                {
                    DataRow drFila = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle);
                    if (dtAccMenu.Rows.Count <= 0) return;
                    dtAccMenu.DefaultView.Sort = "MenCodigo";
                    int varFormulario = int.Parse(drFila["FrmCodigo"].ToString());
                    treListado.DataSource = dtAccMenu.Select(string.Format("FrmCodigo = {0}", varFormulario)).CopyToDataTable().DefaultView;
                    treListado.ExpandAll();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                object varCodigo = treListado.FocusedNode[treListado.KeyFieldName];
                object varFormulario = treListado.FocusedNode[treFrmCodigo];
                object varDocumento = treListado.FocusedNode[treDocCodigo];
                object varOperacion = treListado.FocusedNode[treOpeCodigo];
                object varNombre = treListado.FocusedNode[treMenNombre];

                string varParametro = varNombre.ToString();

                switch (varParametro)
                {
                    case "Documentos":
                        using (xfrmSegLisDocumento frmFormulario = new xfrmSegLisDocumento(true))
                        {
                            frmFormulario.ShowDialog();
                            if (frmFormulario.DrVarFila != null)
                                proAgregarDocumentos(int.Parse(varCodigo.ToString()),
                                                                             int.Parse(varFormulario.ToString()),
                                                                             ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocCodigo,
                                                                             ((clsSegDocumento)frmFormulario.drVarFila[0]).DocDescripcion);


                        }
                        break;
                    case "Operaciones":
                        if (!varNombre.ToString().Equals("Operaciones")) return;
                        using (xfrmSegLisOperacion frmFormulario = new xfrmSegLisOperacion(true))
                        {
                            frmFormulario.ShowDialog();
                            if (frmFormulario.DrVarFila.Count > 0)
                                foreach (var objOperacion in frmFormulario.DrVarFila) {
                                    proAgregarOperacion(int.Parse(varCodigo.ToString()),
                                                                            int.Parse(varFormulario.ToString()),
                                                                            int.Parse(varDocumento.ToString()),
                                                                            ((clsSegOperacion)objOperacion).OpeCodigo,
                                                                            ((clsSegOperacion)objOperacion).OpeNombre);
                                }
                        }
                        break;
                    case "Campos bloqueados":
                        if (!varNombre.ToString().Equals("Campos bloqueados")) return;
                        using (xfrmSegLisCampo frmFormulario = new xfrmSegLisCampo(true, (int)varFormulario))
                        {
                            frmFormulario.ShowDialog();
                            if (frmFormulario.DrVarFila.Count > 0)
                                foreach (var objCampo in frmFormulario.DrVarFila) {
                                    proAgregarCampo(int.Parse(varCodigo.ToString()),
                                                                  int.Parse(varFormulario.ToString()),
                                                                  int.Parse(varDocumento.ToString()),
                                                                  int.Parse(varOperacion.ToString()),
                                                                  ((clsSegCampo)objCampo).CamCodigo,
                                                                  ((clsSegCampo)objCampo).CamNombre);
                                }
                                
                        }
                        break;
                }
                dtAccMenu.DefaultView.Sort = "MenCodigo";
                treListado.DataSource = dtAccMenu.Select(string.Format("FrmCodigo = {0}", varFormulario)).CopyToDataTable().DefaultView;
                treListado.ExpandAll();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void quitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                object varPadre = treListado.FocusedNode[treListado.ParentFieldName];
                object varFormulario = treListado.FocusedNode[treFrmCodigo];
                object varDocumento = treListado.FocusedNode[treDocCodigo];
                object varOperacion = treListado.FocusedNode[treOpeCodigo];
                object varCampo = treListado.FocusedNode[treCamCodigo];

                string varParametro = this.dtAccMenu.Select(string.Format("MenCodigo = {0}", int.Parse(varPadre.ToString())))[0]["MenNombre"].ToString();

                switch (varParametro)
                {
                    case "Documentos":
                        proQuitarDocumento(int.Parse(varFormulario.ToString()),
                                                               int.Parse(varDocumento.ToString()));
                        break;
                    case "Operaciones":
                        proQuitarOperacion(int.Parse(varFormulario.ToString()),
                                                             int.Parse(varDocumento.ToString()),
                                                             int.Parse(varOperacion.ToString()));
                        break;
                    case "Campos bloqueados":
                        proQuitarCampo(int.Parse(varFormulario.ToString()),
                                                       int.Parse(varDocumento.ToString()),
                                                       int.Parse(varOperacion.ToString()),
                                                       int.Parse(varCampo.ToString()));
                        break;
                }
                dtAccMenu.DefaultView.Sort = "MenCodigo";
                treListado.DataSource = dtAccMenu.Select(string.Format("FrmCodigo = {0}", varFormulario)).CopyToDataTable().DefaultView;
                treListado.ExpandAll();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void proDtAccMenu()
        {
            dtAccMenu = new DataTable { TableName = "AccMenu" };
            dtAccMenu.Columns.Add("MenCodigo", typeof(int));
            dtAccMenu.Columns.Add("MenNombre", typeof(string));
            dtAccMenu.Columns.Add("MenPadre", typeof(int));
            dtAccMenu.Columns.Add("FrmCodigo", typeof(int));
            dtAccMenu.Columns.Add("DocCodigo", typeof(int));
            dtAccMenu.Columns.Add("OpeCodigo", typeof(int));
            dtAccMenu.Columns.Add("CamCodigo", typeof(int));

        }
        private void proDtAccFormulario()
        {
            dtAccFormulario = new DataTable { TableName = "AccFormulario" };
            dtAccFormulario.Columns.Add("UsuCodigo", typeof(string));
            dtAccFormulario.Columns.Add("FrmCodigo", typeof(int));
        }
        private void proDtAccDocumento()
        {
            dtAccDocumento = new DataTable { TableName = "AccDocumento" };
            dtAccDocumento.Columns.Add("UsuCodigo", typeof(string));
            dtAccDocumento.Columns.Add("FrmCodigo", typeof(int));
            dtAccDocumento.Columns.Add("DocCodigo", typeof(int));
        }
        private void proDtAccOperacion()
        {
            dtAccOperacion = new DataTable { TableName = "AccOperacion" };
            dtAccOperacion.Columns.Add("UsuCodigo", typeof(string));
            dtAccOperacion.Columns.Add("FrmCodigo", typeof(int));
            dtAccOperacion.Columns.Add("DocCodigo", typeof(int));
            dtAccOperacion.Columns.Add("OpeCodigo", typeof(int));
        }
        private void proDtAccCampo()
        {
            dtAccCampo = new DataTable { TableName = "AccCampo" };
            dtAccCampo.Columns.Add("UsuCodigo", typeof(string));
            dtAccCampo.Columns.Add("FrmCodigo", typeof(int));
            dtAccCampo.Columns.Add("DocCodigo", typeof(int));
            dtAccCampo.Columns.Add("OpeCodigo", typeof(int));
            dtAccCampo.Columns.Add("CamCodigo", typeof(int));
        }
        private void proAgregarDocumentos(int varCodigo, int varFrmCodigo, int varDocCodigo, string varDocNombre)
        {
            try
            {
                if (dtAccDocumento.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo)).Length > 0)
                {
                    XtraMessageBox.Show("El documentos seleccionado ya se encuentra ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.dtAccDocumento.Rows.Add(this.txtCodigo.Text, varFrmCodigo, varDocCodigo);

                int varSecuencia = int.Parse(this.dtAccMenu.Compute("Max(MenCodigo)", "").ToString());

                this.dtAccMenu.Rows.Add(++varSecuencia,
                                                                   varDocNombre,
                                                                   varCodigo,
                                                                   varFrmCodigo,
                                                                   varDocCodigo,
                                                                   0,
                                                                   0);
                
                int varCodPadre = varSecuencia;
                this.dtAccMenu.Rows.Add(++varSecuencia,
                                                                   "Operaciones",
                                                                   varCodPadre,
                                                                   varFrmCodigo,
                                                                   varDocCodigo,
                                                                   0,
                                                                   0);
            }
            catch (Exception) {throw;}
        }
        private void proAgregarOperacion(int varCodigo, int varFrmCodigo, int varDocCodigo, int varOpeCodigo, string varOpeNombre)
        {
            try
            {
                if (dtAccOperacion.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2} And OpeCodigo = {3}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo)).Length > 0)
                {
                    XtraMessageBox.Show("La operacion seleccionada ya se encuentra ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.dtAccOperacion.Rows.Add(this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo);

                int varSecuencia = int.Parse(this.dtAccMenu.Compute("Max(MenCodigo)", "").ToString());

                this.dtAccMenu.Rows.Add(++varSecuencia,
                                                                   varOpeNombre,
                                                                   varCodigo,
                                                                   varFrmCodigo,
                                                                   varDocCodigo,
                                                                   varOpeCodigo,
                                                                   0);

                int varCodPadre = varSecuencia;
                this.dtAccMenu.Rows.Add(++varSecuencia,
                                                                   "Campos bloqueados",
                                                                   varCodPadre,
                                                                   varFrmCodigo,
                                                                   varDocCodigo,
                                                                   varOpeCodigo,
                                                                   0);
            }
            catch (Exception) { throw; }
        }
        private void proAgregarCampo(int varCodigo, int varFrmCodigo, int varDocCodigo, int varOpeCodigo, int varCamCodigo, string varCamNombre)
        {
            try
            {
                if (dtAccCampo.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2} And OpeCodigo = {3} And CamCodigo = {4}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo, varCamCodigo)).Length > 0)
                {
                    XtraMessageBox.Show("El campo seleccionado ya se encuentra ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.dtAccCampo.Rows.Add(this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo, varCamCodigo);

                int varSecuencia = int.Parse(this.dtAccMenu.Compute("Max(MenCodigo)", "").ToString());

                this.dtAccMenu.Rows.Add(++varSecuencia,
                                                                   varCamNombre,
                                                                   varCodigo,
                                                                   varFrmCodigo,
                                                                   varDocCodigo,
                                                                   varOpeCodigo,
                                                                   varCamCodigo);

               
            }
            catch (Exception) { throw; }
        }
        private void proQuitarDocumento(int varFrmCodigo, int varDocCodigo)
        {
            try
            {
                foreach (DataRow drFila in dtAccDocumento.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccOperacion.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccCampo.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccMenu.Select(string.Format("FrmCodigo = {0} And DocCodigo = {1}", varFrmCodigo, varDocCodigo))) drFila.Delete();
            }
            catch (Exception) { throw; }
        }
        private void proQuitarOperacion(int varFrmCodigo, int varDocCodigo, int varOpeCodigo)
        {
            try
            {
                foreach (DataRow drFila in dtAccOperacion.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2} And OpeCodigo = {3}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccCampo.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2} And OpeCodigo = {3}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccMenu.Select(string.Format("FrmCodigo = {0} And DocCodigo = {1} And OpeCodigo = {2}",  varFrmCodigo, varDocCodigo, varOpeCodigo))) drFila.Delete();
            }
            catch (Exception) { throw; }
        }
        private void proQuitarCampo(int varFrmCodigo, int varDocCodigo, int varOpeCodigo, int varCamCodigo)
        {
            try
            {
                foreach (DataRow drFila in dtAccCampo.Select(string.Format("UsuCodigo = '{0}' And FrmCodigo = {1} And DocCodigo = {2} And OpeCodigo = {3} And CamCodigo = {4}", this.txtCodigo.Text, varFrmCodigo, varDocCodigo, varOpeCodigo, varCamCodigo))) drFila.Delete();
                foreach (DataRow drFila in dtAccMenu.Select(string.Format("FrmCodigo = {0} And DocCodigo = {1} And OpeCodigo = {2} And CamCodigo = {3}", varFrmCodigo, varDocCodigo, varOpeCodigo, varCamCodigo))) drFila.Delete();
            }
            catch (Exception) { throw; }
        }
        private void proCargarFormularios(clsSegAccMenu lisGeneral, int varCodigo)
        {
            try
            {
                foreach (DataRow drRegistro in lisGeneral.funListarDt(varUsuCodigo).Rows)
                {
                    this.dtAccFormulario.Rows.Add(varUsuCodigo, int.Parse(drRegistro["FrmCodigo"].ToString()));

                    this.dtAccMenu.Rows.Add(varCodigo,
                                                                       "Documentos",
                                                                       -1,
                                                                       int.Parse(drRegistro["FrmCodigo"].ToString()),
                                                                       0,
                                                                       0,
                                                                       0);
                    varCodigo++;
                }
            }
            catch (Exception) { throw; }
        }
        private void proCargarDocumentos(int varFormulario, int varCodPadre, int varCodigo)
        {
            try
            {
                foreach (DataRow drRegDocumento in clsSegAccFormulario.funListarDtDocumento(varUsuCodigo, varFormulario).Rows)
                {
                    this.dtAccDocumento.Rows.Add(varUsuCodigo, varFormulario, int.Parse(drRegDocumento["DocCodigo"].ToString()));

                    this.dtAccMenu.Rows.Add(varCodigo,
                                                                      drRegDocumento["DocDescripcion"].ToString(),
                                                                      varCodPadre,
                                                                      varFormulario,
                                                                      int.Parse(drRegDocumento["DocCodigo"].ToString()),
                                                                      0,
                                                                      0);

                    this.dtAccMenu.Rows.Add(varCodigo + 1,
                                                                      "Operaciones",
                                                                      varCodigo,
                                                                      varFormulario,
                                                                      int.Parse(drRegDocumento["DocCodigo"].ToString()),
                                                                      0,
                                                                      0);

                    varCodigo++;
                    varCodigo++;
                }
            }
            catch (Exception) { throw; }
        }
        private void proCargarOperaciones(int varFormulario, int varDocumento, int varCodPadre, int varCodigo)
        {
            try
            {
                foreach (DataRow drRegOperacion in clsSegAccFormulario.funListarDtOperacion(varUsuCodigo, varFormulario, varDocumento).Rows)
                {
                    this.dtAccOperacion.Rows.Add(varUsuCodigo, varFormulario, varDocumento, int.Parse(drRegOperacion["OpeCodigo"].ToString()));

                    this.dtAccMenu.Rows.Add(varCodigo,
                                                                   drRegOperacion["OpeNombre"].ToString(),
                                                                   varCodPadre,
                                                                   varFormulario,
                                                                   varDocumento,
                                                                   int.Parse(drRegOperacion["OpeCodigo"].ToString()),
                                                                   0);

                    this.dtAccMenu.Rows.Add(varCodigo + 1,
                                                                   "Campos bloqueados",
                                                                   varCodigo,
                                                                   varFormulario,
                                                                   varDocumento,
                                                                   int.Parse(drRegOperacion["OpeCodigo"].ToString()),
                                                                   0);

                    varCodigo++;
                    varCodigo++;
                }
            }
            catch (Exception) { throw; }
        }
        private void proCargarCampos(int varFormulario, int varDocumento, int varOperacion, int varCodPadre, int varCodigo)
        {
            try
            {
                foreach (DataRow drRegCampo in clsSegAccFormulario.funListarDtCampo(varUsuCodigo, varFormulario, varDocumento, varOperacion).Rows)
                {
                    this.dtAccCampo.Rows.Add(varUsuCodigo, varFormulario, varDocumento,varOperacion, int.Parse(drRegCampo["CamCodigo"].ToString()));

                    this.dtAccMenu.Rows.Add(varCodigo,
                                                                   drRegCampo["CamNombre"].ToString(),
                                                                   varCodPadre,
                                                                   varFormulario,
                                                                   varDocumento,
                                                                   varOperacion,
                                                                   int.Parse(drRegCampo["CamCodigo"].ToString()));

                    varCodigo++;
                }
            }
            catch (Exception) { throw; }
        }
    }
}
