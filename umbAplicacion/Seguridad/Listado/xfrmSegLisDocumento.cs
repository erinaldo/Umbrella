using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Seguridad.Mantenimiento;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Seguridad.Listado
{
    public partial class xfrmSegLisDocumento : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmSegLisDocumento()
        {
            InitializeComponent();
        }
        public xfrmSegLisDocumento(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de documentos";

                this.grcListado.DataSource = clsSegDocumento.funListar("");

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisDocumento";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmSegManDocumento frmFormulario = new xfrmSegManDocumento(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsSegDocumento.funListar("");
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
                    int varRegistro = ((clsSegDocumento)this.grvListado.GetRow(varPosicion)).DocCodigo;
                    using (xfrmSegManDocumento frmFormulario = new xfrmSegManDocumento(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }
                
                this.grcListado.DataSource = clsSegDocumento.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
            try
            {
                if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var lisGeneral = new clsSegDocumento();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsSegDocumento)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, 0, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsSegDocumento.funListar("");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
