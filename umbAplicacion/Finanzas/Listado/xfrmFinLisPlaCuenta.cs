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
    public partial class xfrmFinLisPlaCuenta : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmFinLisPlaCuenta()
        {
            InitializeComponent();
        }
        public xfrmFinLisPlaCuenta(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de cuentas contables";

                this.grcListado.DataSource = clsFinPlaCuenta.funListar();

                const string varNomFormulario = "umbAplicacion.Finanzas.Listado.xfrmFinLisPlaCuenta";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
