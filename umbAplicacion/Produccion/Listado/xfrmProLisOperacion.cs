using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Produccion.Mantenimiento;
using umbNegocio;
using umbNegocio.Produccion;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Produccion.Listado
{
    public partial class xfrmProLisOperacion : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmProLisOperacion()
        {
            InitializeComponent();
        }
        public xfrmProLisOperacion(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de operaciones de produccion";

                this.grcListado.DataSource = clsProOperacion.funListar();

                const string varNomFormulario = "umbAplicacion.Produccion.Listado.xfrmProLisOperacion";

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
                using (xfrmProManOperacion frmFormulario = new xfrmProManOperacion(varCodFormulario, varCodOperacion, ""))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsProOperacion.funListar();
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
                    string varRegistro = ((clsProOperacion)this.grvListado.GetRow(varPosicion)).OppCodigo;
                    using (xfrmProManOperacion frmFormulario = new xfrmProManOperacion(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                this.grcListado.DataSource = clsProOperacion.funListar();
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
                    var lisGeneral = new clsProOperacion();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsProOperacion)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsProOperacion.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
