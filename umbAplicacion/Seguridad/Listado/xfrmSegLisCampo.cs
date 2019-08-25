using DevExpress.XtraEditors;
using umbDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;
using umbAplicacion.Seguridad.Mantenimiento;
using Umbrella;

namespace umbAplicacion.Seguridad.Listado
{
    public partial class xfrmSegLisCampo : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        int varFormularioPadre = 0; 
        
        public xfrmSegLisCampo(int varFormulario)
        {
            InitializeComponent();
            varFormularioPadre = varFormulario;
        }
        public xfrmSegLisCampo(bool varBandera, int varFormulario)
        {
            InitializeComponent();
            varBanListado = varBandera;
            varFormularioPadre = varFormulario;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de campos";

                var lisGeneral = new clsSegCampo();
                this.grcListado.DataSource = lisGeneral.funListar(varFormularioPadre);

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisCampo";

                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, null, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmSegManCampo frmFormulario = new xfrmSegManCampo(varCodFormulario, varCodOperacion, 0, varFormularioPadre))
                {
                    frmFormulario.ShowDialog();
                    var lisGeneral = new clsSegCampo();
                    this.grcListado.DataSource = lisGeneral.funListar(varFormularioPadre);
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
                    int varRegistro = ((clsSegCampo)this.grvListado.GetRow(varPosicion)).CamCodigo;
                    using (xfrmSegManCampo frmFormulario = new xfrmSegManCampo(varCodFormulario, varCodOperacion, varRegistro, varFormularioPadre)) { frmFormulario.ShowDialog(); }
                }

                var lisGeneral = new clsSegCampo();
                this.grcListado.DataSource = lisGeneral.funListar(varFormularioPadre);
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
                    var lisGeneral = new clsSegCampo();
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        lisGeneral = (clsSegCampo)this.grvListado.GetRow(varPosicion);
                        lisGeneral.funMantenimiento(lisGeneral, 0, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grcListado.DataSource = lisGeneral.funListar(varFormularioPadre);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
