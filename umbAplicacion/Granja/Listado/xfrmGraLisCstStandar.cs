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
    public partial class xfrmGraLisCstStandar : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisCstStandar()
        {
            InitializeComponent();
        }
        #region Procedimientos heredados
        //Procedimiento de iniciacion del formulario
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                varCodDocumento = 1;
                //Asignamos el titulo que tendra el formulario
                this.Text = "Costos estandares";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisCstStandar";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion nuevo
        public override void proNuevo()
        {
            base.proNuevo();
            try {
                xfrmGraManCstStandar objFormulario = new xfrmGraManCstStandar(varCodFormulario, varCodOperacion, 0);
                objFormulario.ShowDialog();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion modificar
        public override void proModificar()
        {
            try
            {
                int varRegistro = 0;
                string varEstCodigo = "";

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verifico si el documento no haya sido anulado
                    if (varEstCodigo.ToUpper().Equals("ANU")){
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido anulado", varRegistro), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGraManCstStandar frmFormulario = new xfrmGraManCstStandar(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("ANU"))
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido anulado", varRegistro), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else{
                            //Instanciamos el formulario del mantenimiento de laboratorio
                            xfrmGraManCstStandar frmFormulario = new xfrmGraManCstStandar(varCodFormulario, varCodOperacion, varRegistro);
                            frmFormulario.ShowDialog();
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion consultar
        public override void proConsultar()
        {
            int varRegistro = 0;
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    xfrmGraManCstStandar frmFormulario = new xfrmGraManCstStandar(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        xfrmGraManCstStandar frmFormulario = new xfrmGraManCstStandar(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion eliminar
        public override void proEliminar()
        {
            try
            {
                int varRegistro = 0;
                string varEstCodigo = "";

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verifico si el documento no haya sido anulado
                    if (varEstCodigo.ToUpper().Equals("ACT")) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado, el mismo ya se encuentra activado", varRegistro), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsGraCstStandarCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0}  ha sido anulado", varRegistro), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verifico si el documento no haya sido anulado
                        if (varEstCodigo.ToUpper().Equals("ACT"))
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado, el mismo ya se encuentra activado", varRegistro), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsGraCstStandarCab.proAnular(varRegistro);
                                XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varRegistro), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
        #region Procedimiento
        private void proActListado()
        {
            try
            {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                this.grcListado.DataSource = clsGraCstStandarCab.funListar("");
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
