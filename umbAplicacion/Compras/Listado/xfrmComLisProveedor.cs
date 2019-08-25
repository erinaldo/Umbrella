using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Compra;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Compras.Listado
{
    public partial class xfrmComLisProveedor : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmComLisProveedor()
        {
            InitializeComponent();
        }
        public xfrmComLisProveedor(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de proveedores";

                this.grcListado.DataSource = clsComProveedor.funListar();

                const string varNomFormulario = "umbAplicacion.Compra.Listado.xfrmComLisProveedor";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
