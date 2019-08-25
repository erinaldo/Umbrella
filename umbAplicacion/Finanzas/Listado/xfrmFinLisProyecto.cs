using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio.Finanzas;
using umbNegocio.Seguridad;

namespace umbAplicacion.Finanzas.Listado
{
    public partial class xfrmFinLisProyecto : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmFinLisProyecto()
        {
            InitializeComponent();
        }
        public xfrmFinLisProyecto(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Proyectos";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Finanzas.Listado.xfrmFinLisProyecto";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos del listado despues de realizar los cambios
                this.grcListado.DataSource = clsFinProyecto.funListar();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
