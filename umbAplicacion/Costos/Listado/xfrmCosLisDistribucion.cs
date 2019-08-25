using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Costos.Mantenimiento;
using umbNegocio;
using umbNegocio.Costos;
using umbNegocio.Seguridad;


namespace umbAplicacion.Costos.Listado
{
    public partial class xfrmCosLisDistribucion : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        clsCosDistribucion objDistribucion = new clsCosDistribucion();
        public xfrmCosLisDistribucion() {
            InitializeComponent();
        }
        public xfrmCosLisDistribucion(bool varBandera) {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Listado de distribución de centros de costo";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisDistribucion";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
                //Bloqueamos las operaciones de insertar y modificar
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void proActListado() {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { clsMensajesSistema.metMsgError("El usuario no tiene acceso al formulario seleccionado"); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0})", varDocumento);
                
                this.grcListado.DataSource = objDistribucion.metConsultar(varWhere);
            } catch (Exception e) { throw new Exception(e.Message); }
        }
        private void btnEnviarSAP_Click(object sender, EventArgs e) {
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    int varNroSAP = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNroSap;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { clsMensajesSistema.metMsgError("El usuario no tiene acceso para enviar a SAP el documento seleccionado"); return; }
                    //Recuperamos el codigo interno 
                    if (varNroSAP.Equals(0)) {
                        varRegistro = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                        if (!splashScreenManager1.IsSplashFormVisible) splashScreenManager1.ShowWaitForm();
                        objDistribucion.metConsultar(varRegistro);
                        int varNroSap = objDistribucion.metEnviarDocumentoSAP();
                        splashScreenManager1.CloseWaitForm();
                        if (varNroSap > 0)
                            clsMensajesSistema.metMsgInformativo("Registro enviado a sap");
                        else
                            clsMensajesSistema.metMsgError("Ocurrio un error el documento no fue enviado a SAP");
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        int varNroSAP = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).CabNroSap;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { clsMensajesSistema.metMsgError("El usuario no tiene acceso para enviar a SAP el documento seleccionado"); return; }
                        if (varNroSAP.Equals(0)) {
                            //Recuperamos el codigo interno del registro de laboratorio
                            varRegistro = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).CabCodigo;
                            if (!splashScreenManager1.IsSplashFormVisible) splashScreenManager1.ShowWaitForm();
                            objDistribucion.metConsultar(varRegistro);
                            int varNroSap = objDistribucion.metEnviarDocumentoSAP();
                            splashScreenManager1.CloseWaitForm();
                            if (varNroSap > 0)
                                clsMensajesSistema.metMsgInformativo("Registro enviado a sap");
                            else
                                clsMensajesSistema.metMsgError("Ocurrio un error el documento no fue enviado a SAP");
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); splashScreenManager1.CloseWaitForm(); }
        }
        public override void proConsultar() {
            int varRegistro = 0;
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    xfrmCosManDistribucion objFormulario = new xfrmCosManDistribucion(varCodFormulario, varCodOperacion, varRegistro, null);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        xfrmCosManDistribucion objFormulario = new xfrmCosManDistribucion(varCodFormulario, varCodOperacion, varRegistro, null);
                        objFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proEliminar()
        {
            try {
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    objDistribucion.CabCodigo = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    objDistribucion.DocNombre = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    objDistribucion.CabNumero = ((clsCosDistribucion)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar los registro seleccionados") == System.Windows.Forms.DialogResult.Yes) {
                        objDistribucion.metEliminar();
                        clsMensajesSistema.metMsgInformativo("El registro eliminado con exito");
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        objDistribucion.CabCodigo = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        objDistribucion.DocNombre = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).DocNombre;
                        objDistribucion.CabNumero = ((clsCosDistribucion)this.grvListado.GetRow(varPosicion)).CabNumero;
                        if (clsMensajesSistema.metMsgPregunta("Esta seguro de eliminar los registro seleccionados") == System.Windows.Forms.DialogResult.Yes) {
                            objDistribucion.metEliminar();
                            clsMensajesSistema.metMsgInformativo("El registro eliminado con exito");
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
