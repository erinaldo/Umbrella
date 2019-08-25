using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Costos.Mantenimiento;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;
using umbNegocio.Costos;

namespace umbAplicacion.Costos.Listado
{
    public partial class xfrmCosLisHojaVer : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmCosLisHojaVer()
        {
            InitializeComponent();
        }
        public xfrmCosLisHojaVer(bool varBandera)
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

                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisHojaVer";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}'", clsSegAccFormulario.funAccesoDocumento(varCodFormulario), DateTime.Now.Year.ToString() + "/01/01", DateTime.Now.Year.ToString() + "/12/31");
                this.grcListado.DataSource = clsCosHojVertical.funListar(varWhere);

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
                using (xfrmCosManHojaVer frmFormulario = new xfrmCosManHojaVer(varCodFormulario, varCodOperacion, 0))
                {
                    frmFormulario.ShowDialog();
                    
                    string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}'", clsSegAccFormulario.funAccesoDocumento(varCodFormulario), DateTime.Now.Year.ToString() + "/01/01",DateTime.Now.Year.ToString() + "/12/31");
                    this.grcListado.DataSource = clsCosHojVertical.funListar(varWhere);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar()
        {
            base.proModificar();
            //try
            //{
            //    foreach (int varPosicion in this.grvListado.GetSelectedRows())
            //    {
            //        int varRegistro = ((clsProFormulacion)this.grvListado.GetRow(varPosicion)).CabCodigo;
            //        using (xfrmProManFormulacion frmFormulario = new xfrmProManFormulacion(varCodFormulario, varCodOperacion, varRegistro)) { frmFormulario.ShowDialog(); }
            //    }

            //    var lisGeneral = new clsProFormulacion();
            //    this.grcListado.DataSource = lisGeneral.funListar();
            //}
            //catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            base.proEliminar();
        }
        
    }
}
