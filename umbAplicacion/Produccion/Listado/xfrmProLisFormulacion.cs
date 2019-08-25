using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Produccion.Mantenimiento;
using umbNegocio;
using umbNegocio.Produccion;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Produccion.Listado
{
    public partial class xfrmProLisFormulacion : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmProLisFormulacion()
        {
            InitializeComponent();
        }
        public xfrmProLisFormulacion(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de materiales";

                const string varNomFormulario = "umbAplicacion.Produccion.Listado.xfrmProLisFormulacion";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsProFormulacion.funListar(varWhere);

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 0);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmProManFormulacion frmFormulario = new xfrmProManFormulacion(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();

                    string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                    string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                    this.grcListado.DataSource = clsProFormulacion.funListar(varWhere);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar()
        {
            base.proModificar();
            try
            {
                foreach (int varPosicion in this.grvListado.GetSelectedRows())
                {
                    int varRegistro = ((clsProFormulacion)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    using (xfrmProManFormulacion frmFormulario = new xfrmProManFormulacion(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsProFormulacion.funListar(varWhere);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
        }
    }
}
