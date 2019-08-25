using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Finanzas.Mantenimiento;
using umbNegocio;
using umbNegocio.Finanzas;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Finanzas.Listado
{
    public partial class xfrmFinLisDocPreliminar : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmFinLisDocPreliminar()
        {
            InitializeComponent();
        }
        public xfrmFinLisDocPreliminar(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Documentos preliminares";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Finanzas.Listado.xfrmFinLisDocPreliminar";
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
                xfrmFinManDocPreliminar objFormulario = new xfrmFinManDocPreliminar(varCodFormulario, varCodOperacion, 0);
                objFormulario.ShowDialog();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion modificar
        public override void proModificar()
        {
            try {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)){
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsFinDocPreliminarCab.funVerificarDocPreliminarSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmFinManDocPreliminar objFormulario = new xfrmFinManDocPreliminar(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsFinDocPreliminarCab.funVerificarDocPreliminarSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            //Instanciamos el formulario del mantenimiento de laboratorio
                            xfrmFinManDocPreliminar objFormulario = new xfrmFinManDocPreliminar(varCodFormulario, varCodOperacion, varRegistro);
                            objFormulario.ShowDialog();
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
            try
            {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    xfrmFinManDocPreliminar objFormulario = new xfrmFinManDocPreliminar(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        xfrmFinManDocPreliminar objFormulario = new xfrmFinManDocPreliminar(varCodFormulario, varCodOperacion, varRegistro);
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
            try
            {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsFinDocPreliminarCab.funVerificarDocPreliminarSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsFinDocPreliminarCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsFinDocPreliminarCab.funVerificarDocPreliminarSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsFinDocPreliminarCab.proAnular(varRegistro);
                                XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    clsFinDocPreliminarCab csFinDocPreliminar = clsFinDocPreliminarCab.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                    string varMensaje = csFinDocPreliminar.funEnviarDocPreliminarSAP();

                    if (varMensaje.Equals(""))
                        XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", csFinDocPreliminar.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", csFinDocPreliminar.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos el codigo interno del registro de laboratorio
                        varRegistro = ((clsFinDocPreliminarCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        clsFinDocPreliminarCab csFinDocPreliminar = clsFinDocPreliminarCab.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                        string varMensaje = csFinDocPreliminar.funEnviarDocPreliminarSAP();

                        if (varMensaje.Equals(""))
                            XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", csFinDocPreliminar.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", csFinDocPreliminar.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Procedimiento
        private void proActListado()
        {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0})", varDocumento);
                this.grcListado.DataSource = clsFinDocPreliminarCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
