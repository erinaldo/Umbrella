using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Inventario.Listado
{
    public partial class xfrmInvLisProducto : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmInvLisProducto()
        {
            InitializeComponent();
        }
        public xfrmInvLisProducto(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de productos";

                this.grcListado.DataSource = clsInvItem.funListar();

                const string varNomFormulario = "umbAplicacion.Inventario.Listado.xfrmInvLisProducto";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
