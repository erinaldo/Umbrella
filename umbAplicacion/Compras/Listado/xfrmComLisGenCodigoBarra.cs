using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Compras.Impresion;
using umbAplicacion.Compras.Mantenimiento;
using umbNegocio;
using umbNegocio.Compra;
using umbNegocio.Entidades;
using umbNegocio.Seguridad;

namespace umbAplicacion.Compras.Listado
{
    public partial class xfrmComLisGenCodigoBarra : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmComLisGenCodigoBarra() { InitializeComponent(); }
        public xfrmComLisGenCodigoBarra(bool varBandera) {
            InitializeComponent();
            varBanListado = varBandera;
        }
        private void btnImprimir_Click(object sender, EventArgs e) {
            int varRegistro = 0;
            int varCabNumero = 0;
            string varDocNombre = "";
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 12);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para imprimir el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabCodigo;
                    varDocNombre = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocNombre;
                    varCabNumero = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabNumero;
                    proImprimir(daoComGenCodigoBarra.getInstance().metConsultarDetalle(varRegistro), varDocNombre, varCabNumero);
                } else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocCodigo;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 12);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos el codigo interno del registro de laboratorio
                        varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabCodigo;
                        varDocNombre = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocNombre;
                        varCabNumero = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabNumero;
                        proImprimir(daoComGenCodigoBarra.getInstance().metConsultarDetalle(varRegistro), varDocNombre, varCabNumero);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region Procedimientos heredados


        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Generación de codigos de barra en recepción de carnes";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Compras.Listado.xfrmComLisGenCodigoBarra";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo() {  //Operación para insertar
            base.proNuevo();
            try {
                xfrmComManGenCodigoBarra objFormulario = new xfrmComManGenCodigoBarra(varCodFormulario, varCodOperacion, 0);
                objFormulario.ShowDialog();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar() {
            try {
                int varRegistro = 0;
               
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabCodigo;
                    xfrmComManGenCodigoBarra objFormulario = new xfrmComManGenCodigoBarra(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                } else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabCodigo;
                        xfrmComManGenCodigoBarra objFormulario = new xfrmComManGenCodigoBarra(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proConsultar() {
            int varRegistro = 0;
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabCodigo;
                    xfrmComManGenCodigoBarra objFormulario = new xfrmComManGenCodigoBarra(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                } else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabCodigo;
                        xfrmComManGenCodigoBarra objFormulario = new xfrmComManGenCodigoBarra(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar() {
            try {
                object[] objResultado = new object[2];
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabCodigo;
                    varCabNumero = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrCabNumero;
                    varDocNombre = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).atrDocNombre;
                    if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                        objResultado = daoComGenCodigoBarra.getInstance().metEliminar(varRegistro);
                        proEnviarMensaje(objResultado, varDocNombre, varCabNumero);
                    }
                } else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabCodigo;
                        varCabNumero = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrCabNumero;
                        varDocNombre = ((EntCOM_CABGENCODBARRA)this.grvListado.GetRow(varPosicion)).atrDocNombre;
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            objResultado = daoComGenCodigoBarra.getInstance().metEliminar(varRegistro);
                            proEnviarMensaje(objResultado, varDocNombre, varCabNumero);
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            } catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Procedimientos
        private void proActListado() {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                this.grcListado.DataSource = daoComGenCodigoBarra.getInstance().metListar();
            } catch (Exception e) { throw new Exception(e.Message); }
        }
        private void proEnviarMensaje(object[] objResultado, string varDocNombre, int varCabNumero) {
            if (objResultado[0].Equals("ok"))
                XtraMessageBox.Show(string.Format(objResultado[1].ToString(), varDocNombre, varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show(objResultado[1].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void proImprimir(List<EntCOM_DETGENCODBARRA> objDetalle, string varDocNombre, int varCabNumero) {
            crtEtiquetaCarnesBPM objImpresionEtiquetaBPM;
            int varCodigoBarra;
            DataTable dtValoresEtiqueta;
            foreach (EntCOM_DETGENCODBARRA objFilaDetalle in objDetalle) {
                varCodigoBarra = clsComEntMercanciasCab.funRecuperarCodigoBarra(varDocNombre, varCabNumero, objFilaDetalle.atrIteCodigo);
                dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiquetaBPM(varCodigoBarra);

                objImpresionEtiquetaBPM = new crtEtiquetaCarnesBPM();
                objImpresionEtiquetaBPM.SetDataSource(dtValoresEtiqueta);
                objImpresionEtiquetaBPM.PrintOptions.PrinterName = ConfigurationManager.AppSettings["ImpresoraEtiqueta"];
                
                objImpresionEtiquetaBPM.PrintToPrinter(objFilaDetalle.atrDetNroImpresion, false, 0, 1);
            }
        }
        #endregion

        
    }
}
