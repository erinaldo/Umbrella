using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Finanzas;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Finanzas.Listado
{
    public partial class xfrmFinLisCenCosto : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmFinLisCenCosto()
        {
            InitializeComponent();
        }
        public xfrmFinLisCenCosto(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de centros de costo";

                this.grcListado.DataSource = clsFinCenCosto.funListar();

                const string varNomFormulario = "umbAplicacion.Finanzas.Listado.xfrmFinLisCenCosto";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
