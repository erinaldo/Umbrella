using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Costos.Mantenimiento;
using umbNegocio;
using umbNegocio.Costos;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Costos.Listado
{
    public partial class xfrmCosLisComCarnica : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmCosLisComCarnica()
        {
            InitializeComponent();
        }
        public xfrmCosLisComCarnica(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de costos compras carnicas";

                this.grcListado.DataSource = clsCosComCarnica.funListar();

                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisComCarnica";

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
                using (xfrmCosManComCarnica frmFormulario = new xfrmCosManComCarnica(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    this.grcListado.DataSource = clsCosComCarnica.funListar();
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
                    int varRegistro = ((clsCosComCarnica)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    using (xfrmCosManComCarnica frmFormulario = new xfrmCosManComCarnica(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                this.grcListado.DataSource = clsCosComCarnica.funListar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
