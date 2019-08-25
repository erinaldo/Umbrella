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
    public partial class xfrmCosLisHojaHor : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmCosLisHojaHor()
        {
            InitializeComponent();
        }
        public xfrmCosLisHojaHor(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de hoja de costos horizontal";
                
                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisHojaHor";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var lisGeneral = new clsCosHojHorizontal();
                
                string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}'", clsSegAccFormulario.funAccesoDocumento(varCodFormulario), DateTime.Now.Year.ToString() + "/01/01", DateTime.Now.Year.ToString() + "/12/31");
                this.grcListado.DataSource = lisGeneral.funListar(varWhere);

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
                using (xfrmCosManHojaHor frmFormulario = new xfrmCosManHojaHor(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    var lisGeneral = new clsCosHojHorizontal();
                    
                    string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}'", clsSegAccFormulario.funAccesoDocumento(varCodFormulario), DateTime.Now.Year.ToString() + "/01/01", DateTime.Now.Year.ToString() + "/12/31");
                    this.grcListado.DataSource = lisGeneral.funListar(varWhere);
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
                    int varRegistro = ((clsCosHojHorizontal)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    using (xfrmCosManHojaHor frmFormulario = new xfrmCosManHojaHor(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
                }

                var lisGeneral = new clsCosHojHorizontal();
                
                string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}'", clsSegAccFormulario.funAccesoDocumento(varCodFormulario), DateTime.Now.Year.ToString() + "/01/01", DateTime.Now.Year.ToString() + "/12/31");
                this.grcListado.DataSource = lisGeneral.funListar(varWhere);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
        }
    }
}
