using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umbNegocio;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using umbNegocio.Seguridad;

namespace Umbrella
{
    public class clsValidacionesControles
    {
        DataTable dtCampos;
        DataTable dtOperacion;

        public void proControlColor(XtraForm frmFormulario, string varCodUsuario, int varCodFormulario, int varCodDocumento, int varCodOperacion)
        {
            try
            {
                this.proDtCampos(varCodUsuario, varCodFormulario, varCodDocumento, varCodOperacion);
                foreach (DataRow drRegistro in dtCampos.Select("CamRequerido = true And CamBloqueado = false"))
                {
                    string varCamTipo = drRegistro["CamTipo"].ToString();
                    string varCamNombre = drRegistro["CamNombre"].ToString();
                    switch (varCamTipo)
                    {
                        case "TextEdit":
                            ((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        case "ButtonEdit":
                            ((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        case "GridLookUpEdit":
                            ((GridLookUpEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        case "LookUpEdit":
                            ((LookUpEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        case "DateEdit":
                            ((DateEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).BackColor = Color.FromArgb(255, 255, 192);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception) { throw; }
        }
        public void proAccesoOperaciones(XtraForm frmFormulario, ContextMenuStrip cmsMenu, string varCodUsuario, int varCodFormulario, int varCodDocumento)
        {
            try
            {
                this.proDtOperacion(varCodUsuario, varCodFormulario, varCodDocumento);
                foreach (DataRow drRegistro in dtOperacion.Rows)
                {
                    string varOpeTipo = drRegistro["OpeTipo"].ToString();
                    string varOpeNombre = drRegistro["OpeNombre"].ToString();
                    switch (varOpeTipo)
                    {
                        case "SimpleButton":
                            ((SimpleButton)frmFormulario.Controls.Find(varOpeNombre, true)[0]).Enabled = true;
                            break;
                        case "ToolStripMenuItem":
                            ((ToolStripMenuItem)cmsMenu.Items.Find(varOpeNombre, true)[0]).Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception) { throw; }
        }
        public void proAccesoCampos(XtraForm frmFormulario, string varCodUsuario, int varCodFormulario, int varCodDocumento, int varCodOperacion)
        {
            try
            {
                this.proDtCampos(varCodUsuario, varCodFormulario, varCodDocumento, varCodOperacion);
                foreach (DataRow drRegistro in dtCampos.Select("CamBloqueado = true"))
                {
                    string varCamTipo = drRegistro["CamTipo"].ToString();
                    string varCamNombre = drRegistro["CamNombre"].ToString();
                    switch (varCamTipo)
                    {
                        case "TextEdit":
                            ((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "MemoEdit":
                             ((MemoEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "ButtonEdit":
                            ((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "ComboBoxEdit":
                            ((ComboBoxEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "DateEdit":
                            ((DateEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "LookUpEdit":
                             ((LookUpEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "GridLookUpEdit":
                            ((GridLookUpEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).Enabled = false;
                            break;
                        case "GridControl":
                            foreach (GridView view in ((GridControl)frmFormulario.Controls.Find(varCamNombre, true)[0]).Views)
                                view.OptionsBehavior.ReadOnly = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception) { throw; }
        }
        
        private void proDtCampos(string varCodUsuario, int varCodFormulario, int varCodDocumento, int varCodOperacion)
        {
            dtCampos = new DataTable { TableName = "TabCampos" };
            dtCampos.Columns.Add("CamNombre", typeof(string));
            dtCampos.Columns.Add("CamTipo", typeof(string));
            dtCampos.Columns.Add("CamBloqueado", typeof(bool));
            dtCampos.Columns.Add("CamRequerido", typeof(bool));
            dtCampos.Columns.Add("CamError", typeof(string));

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select CamNombre, CamRequerido, CamTipo, CamError, " +
                                                                                                                                                    "           Case When b.CamCodigo is null Then 'false' Else 'true' End  as CamBloqueado " +
                                                                                                                                                    "From SEG_CAMPO a Left Join SEG_ACCCAMPO b on a.CamCodigo = b.CamCodigo And b.UsuCodigo = '{0}' And " +
                                                                                                                                                    "                                                                                                               b.FrmCodigo = {1} And b.DocCodigo = {2} And OpeCodigo = {3} " +
                                                                                                                                                    "Where a.FrmCodigo = {1}", varCodUsuario, varCodFormulario, varCodDocumento, varCodOperacion));
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drRegistro in dtLista.Rows)
                {
                    dtCampos.Rows.Add(drRegistro["CamNombre"].ToString(),
                                                           drRegistro["CamTipo"].ToString(),
                                                           bool.Parse(drRegistro["CamBloqueado"].ToString()),
                                                           (bool)drRegistro["CamRequerido"],
                                                           drRegistro["CamError"].ToString());
                }
            }
            catch (Exception) { throw; }
        }
        private void proDtOperacion(string varCodUsuario, int varCodFormulario, int varCodDocumento)
        {
            dtOperacion = new DataTable { TableName = "TabOperacion" };
            dtOperacion.Columns.Add("OpeNombre", typeof(string));
            dtOperacion.Columns.Add("OpeTipo", typeof(string));

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                string varSql = "";
                if (varCodDocumento.Equals(0))
                    varSql = string.Format("Select Distinct b.OpeNombre, b.OpeTipo " +
                                                             "From SEG_ACCOPERACION a Inner Join SEG_OPERACION b on a.OpeCodigo = b.OpeCodigo " +
                                                             "Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1}", varCodUsuario, varCodFormulario);
                else
                    varSql = string.Format("Select Distinct b.OpeNombre, b.OpeTipo " +
                                                            "From SEG_ACCOPERACION a Inner Join SEG_OPERACION b on a.OpeCodigo = b.OpeCodigo " +
                                                            "Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1} And a.DocCodigo = {2} ", varCodUsuario, varCodFormulario, varCodDocumento);
                
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drRegistro in dtLista.Rows)
                {
                    dtOperacion.Rows.Add(drRegistro["OpeNombre"].ToString(),
                                                               drRegistro["OpeTipo"].ToString());
                }
            }
            catch (Exception) { throw; }
        }

        //Procedimiento utilizado para determinar cual campo es requerido
        public string funControlRequerido(XtraForm frmFormulario, string varCodUsuario, int varCodFormulario, int varCodDocumento, int varCodOperacion, DXErrorProvider dxError)
        {
            try
            {
                string varMensaje = "";
                this.proDtCampos(varCodUsuario, varCodFormulario, varCodDocumento, varCodOperacion);
                foreach (DataRow drRegistro in dtCampos.Select("CamRequerido = true And CamBloqueado = false"))
                {
                    string varCamTipo = drRegistro["CamTipo"].ToString();
                    string varCamNombre = drRegistro["CamNombre"].ToString();
                    switch (varCamTipo)
                    {
                        case "TextEdit":
                            if (((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).EditValue.Equals("") || ((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).EditValue.Equals("0"))
                            {
                                dxError.SetError(((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), drRegistro["CamError"].ToString(), ErrorType.Critical);
                                varMensaje = drRegistro["CamError"].ToString();
                            }
                            else dxError.SetError(((TextEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), String.Empty);
                            break;
                        case "ButtonEdit":
                            if (((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).EditValue.Equals("")) {
                                dxError.SetError(((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), drRegistro["CamError"].ToString(), ErrorType.Critical);
                                varMensaje = drRegistro["CamError"].ToString();
                            }
                            else dxError.SetError(((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), String.Empty);
                            break;
                        case "DateEdit":
                            if (((DateEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]).EditValue == null){
                                dxError.SetError(((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), drRegistro["CamError"].ToString(), ErrorType.Critical);
                                varMensaje = drRegistro["CamError"].ToString();
                            }
                            else dxError.SetError(((ButtonEdit)frmFormulario.Controls.Find(varCamNombre, true)[0]), String.Empty);
                            break;
                        case "GridLookUpEdit":
                            DevExpress.XtraEditors.GridLookUpEdit objGridLookUpEdit = (DevExpress.XtraEditors.GridLookUpEdit)frmFormulario.Controls.Find(varCamNombre, true)[0];
                            if (objGridLookUpEdit.EditValue == null || objGridLookUpEdit.EditValue.ToString() == "") {
                                dxError.SetError(objGridLookUpEdit, drRegistro["CamError"].ToString(), ErrorType.Critical);
                                varMensaje = drRegistro["CamError"].ToString();
                            }
                            else dxError.SetError(objGridLookUpEdit, String.Empty);
                            break;
                        default:
                            break;
                    }
                    if (!varMensaje.Equals("")) return varMensaje;
                }
                return varMensaje;
            }
            catch (Exception) { throw; }
        }
        //Procedimiento utilizado para determinar los documentos a los que tiene acceso el usuario 
        public static void proAccUsuarioDocumento(TextEdit txtCodSerie, TextEdit txtNomSerie, SimpleButton btnCancelar, int varForCodigo, int varOpeCodigo) {
            //Validamos que documentos tiene acceso el usuario
            DataTable dtDocumentos = clsSegAccFormulario.funListarDtDocumento(clsVariablesGlobales.varCodUsuario, varForCodigo, varOpeCodigo);
            //Verificamos si tiene acceso a un solo documento 
            if (dtDocumentos.Rows.Count.Equals(1)) {
                txtCodSerie.EditValue = int.Parse(dtDocumentos.Rows[0]["DocCodigo"].ToString());
                txtNomSerie.Text = dtDocumentos.Rows[0]["DocNombre"].ToString();
            }// En caso de que el usuario tenga acceso a mas de un documento le mostraremos un formulario para q escoja el documento
            else {
                var frmFormulario = new frmAccDocumento(dtDocumentos) { StartPosition = FormStartPosition.CenterParent };
                frmFormulario.ShowDialog();

                if (frmFormulario.DrVarFila == null) { btnCancelar.PerformClick(); return; }

                txtCodSerie.EditValue = int.Parse(((DataRowView)frmFormulario.DrVarFila)["DocCodigo"].ToString());
                txtNomSerie.Text = ((DataRowView)frmFormulario.DrVarFila)["DocNombre"].ToString();
            }
        }
        
    }
}
