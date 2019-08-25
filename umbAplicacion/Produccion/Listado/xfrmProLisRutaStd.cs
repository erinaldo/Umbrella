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
    public partial class xfrmProLisRutaStd : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
       public xfrmProLisRutaStd()
        {
            InitializeComponent();
        }
       public xfrmProLisRutaStd(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de rutas estandares";

                this.grcListado.DataSource = clsProRutaStd.funListar();

                const string varNomFormulario = "umbAplicacion.Produccion.Listado.xfrmProLisRutaStd";

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
                using (xfrmProManRutaStd frmFormulario = new xfrmProManRutaStd(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsProRutaStd.funListar();
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
                    int varRegistro = ((clsProRutaStd)this.grvListado.GetRow(varPosicion)).PrsCodigo;
                    using (xfrmProManRutaStd frmFormulario = new xfrmProManRutaStd(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                this.grcListado.DataSource = clsProRutaStd.funListar();
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
                    var lisGeneral = new clsProRutaStd();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsProRutaStd)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = clsProRutaStd.funListar();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
