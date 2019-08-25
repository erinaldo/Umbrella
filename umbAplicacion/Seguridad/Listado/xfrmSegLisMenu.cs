using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using umbNegocio.Seguridad;
using umbAplicacion.Seguridad.Mantenimiento;
using Umbrella;
using umbNegocio;

namespace umbAplicacion.Seguridad.Listado
{
    public partial class xfrmSegLisMenu : umbAplicacion.Plantillas.Listado.xfrmPlaLisArbol
    {
        public xfrmSegLisMenu()
        {
            InitializeComponent();
        }
        public xfrmSegLisMenu(bool varBandera)
        {
            varBanListado = varBandera;
            InitializeComponent();
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Listado de menu";

                this.treListado.DataSource = clsSegMenu.funListar();
                this.treListado.ParentFieldName = "MenPadre";
                this.treListado.KeyFieldName = "MenCodigo";
                this.treListado.ExpandAll();

                const string varNomFormulario = "umbAplicacion.Seguridad.Listado.xfrmSegLisMenu";

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
                object varCodigo = treListado.FocusedNode[treListado.KeyFieldName];
                object varNombre = treListado.FocusedNode[treMenNombre];
                using (xfrmSegManMenu frmFormulario = new xfrmSegManMenu(varCodFormulario, varCodOperacion, 0, varCodigo == null ? 0 : (int)varCodigo, varNombre == null ? "" : varNombre.ToString()))
                {
                    frmFormulario.ShowDialog();
                    this.treListado.DataSource = clsSegMenu.funListar();
                    this.treListado.ExpandAll();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar()
        {
            base.proModificar();
            try
            {
               
                foreach (TreeListNode varNodo in treListado.GetAllCheckedNodes())
                {
                    int varRegistro = int.Parse(varNodo[treListado.KeyFieldName].ToString());
                    using (xfrmSegManMenu frmFormulario = new xfrmSegManMenu(varCodFormulario, varCodOperacion, varRegistro, 0, "")) { frmFormulario.ShowDialog(); }
                }

                this.treListado.DataSource = clsSegMenu.funListar();
                this.treListado.ExpandAll();
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
                    var lisGeneral = new clsSegMenu();
                    foreach (TreeListNode varNodo in treListado.GetAllCheckedNodes())
                    {
                        lisGeneral = (clsSegMenu)this.treListado.GetDataRecordByNode(varNodo);
                        lisGeneral.funMantenimiento(lisGeneral, 0, varCodOperacion);
                    }

                    XtraMessageBox.Show("Registro ha sido eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.treListado.DataSource = clsSegMenu.funListar();
                    this.treListado.ExpandAll();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
