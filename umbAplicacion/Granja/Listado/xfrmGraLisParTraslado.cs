using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Granja.Mantenimiento;
using umbNegocio.Granja;
using umbNegocio.Seguridad;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisParTraslado : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisParTraslado()
        {
            InitializeComponent();
        }
        //Procedimiento para inicializar el formulario
        public override void proIniciarFormulario()
        {
            try {
                base.proIniciarFormulario();
                //Asignamos el titulo que tendra el formulario
                this.Text = "Parametrizacion de traslados";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisParTraslado";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                varCodDocumento = 1;
                this.proAccesoFormulario();
                //Actualizamos los datos de listado despues de realizar los cambios
                grcListado.DataSource = clsGraParTrasladoCab.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion nuevo
        public override void proNuevo()
        {
            base.proNuevo();
            try {
                xfrmGraManParTraslado objFormulario = new xfrmGraManParTraslado(varCodFormulario, varCodOperacion, 0);
                objFormulario.ShowDialog();
                //Actualizamos los datos de listado despues de realizar los cambios
                grcListado.DataSource = clsGraParTrasladoCab.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion modificar
        public override void proModificar()
        {
            try {
                //Recuperamos el codigo del documento
                varCodDocumento = 1;
                base.proModificar();
                if (!varBanAcceso) return;

                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["PtrCodigo"].ToString());
                    //Instanciamos el formulario del mantenimiento de laboratorio
                    xfrmGraManParTraslado objFormulario = new xfrmGraManParTraslado(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["PtrCodigo"].ToString());
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGraManParTraslado objFormulario = new xfrmGraManParTraslado(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                grcListado.DataSource = clsGraParTrasladoCab.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion consultar
        public override void proConsultar()
        {
            try {
                //Recuperamos el codigo del documento
                varCodDocumento = 1;
                base.proConsultar();
                if (!varBanAcceso) return;

                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["PtrCodigo"].ToString());
                    //Instanciamos el formulario del mantenimiento de laboratorio
                    xfrmGraManParTraslado objFormulario = new xfrmGraManParTraslado(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["PtrCodigo"].ToString());
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGraManParTraslado objFormulario = new xfrmGraManParTraslado(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion eliminar
        public override void proEliminar()
        {
            try {
                //Recuperamos el codigo del documento
                varCodDocumento = 1;
                base.proEliminar();
                if (!varBanAcceso) return;

                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["PtrCodigo"].ToString());
                    if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                        clsGraParTrasladoCab.proAnular(varRegistro);
                        XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varRegistro), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["PtrCodigo"].ToString());
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsGraParTrasladoCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varRegistro), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                grcListado.DataSource = clsGraParTrasladoCab.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
