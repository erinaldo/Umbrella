using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Granja.Mantenimiento;
using umbNegocio;
using umbNegocio.Granja;
using umbNegocio.Seguridad;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisLaboratorio : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisLaboratorio()
        {
            InitializeComponent();
        }
        #region Procedimientos heredados
        //Procedimiento de iniciacion del formulario
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Registro de laboratorio";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisLaboratorio";
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
                xfrmGraManLaboratorio objFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, 0);
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
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocCodigo"].ToString());
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    varCabNumero = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabNumero"].ToString());
                    varDocNombre = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocNombre"].ToString();
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsGraLaboratorioCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGraManLaboratorio frmFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        varCabNumero = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabNumero"].ToString());
                        varDocNombre = this.grvListado.GetDataRow(varPosicion)["DocNombre"].ToString();
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsGraLaboratorioCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) 
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            //Instanciamos el formulario del mantenimiento de laboratorio
                            xfrmGraManLaboratorio frmFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, varRegistro);
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
            try
            {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocCodigo"].ToString());
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    xfrmGraManLaboratorio frmFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        xfrmGraManLaboratorio frmFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, varRegistro);
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
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocCodigo"].ToString());
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    varCabNumero = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabNumero"].ToString());
                    varDocNombre = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocNombre"].ToString();
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsGraLaboratorioCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsGraLaboratorioCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        varCabNumero = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabNumero"].ToString());
                        varDocNombre = this.grvListado.GetDataRow(varPosicion)["DocNombre"].ToString();
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsGraLaboratorioCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsGraLaboratorioCab.proAnular(varRegistro);
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
        #endregion
        #region Procedimiento
        private void proActListado()
        {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsGraLaboratorioCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        private void proEnviarSAP(int varRegistro)
        {
            try {
                string varMensaje = "";
                int varDocEntry = 0;
                int varDocNum = 0;
                //Instanciamos la clase de laboratorio
                clsGraLaboratorioCab objLaboratorioCab = new clsGraLaboratorioCab();
                //Recuperamos la informacion de cabecera del registro de laboratorio
                objLaboratorioCab = clsGraLaboratorioCab.funListar(varRegistro)[0];
                //Verificamos que nos exista valores en cero en los costos acumulados
                if (clsGraCstAcumulado.funVerificarCstAcumulado(objLaboratorioCab.AnmCodigo, objLaboratorioCab.CabFecha) > 0) {
                    XtraMessageBox.Show(string.Format("Favor de verificar que los movimientos de inventario relacionados con la chapeta: {0} se encuentren enviados a SAP", objLaboratorioCab.AnmAlternativo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Verificamos si el documento ya ha sido ingresado en SAP
                DataTable objDtVerificarSAP;
                objDtVerificarSAP = clsGraLaboratorioCab.funVerificarSalInventarioSAP(objLaboratorioCab.DocNombre, objLaboratorioCab.CabNumero);

                //Verifico si el documento no haya sido enviado a SAP
                if (objLaboratorioCab.EstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                    //Actualizacion en el formulario de movimientos de inventario
                    varDocEntry = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                    varDocNum = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                    clsGraLaboratorioCab.proActMovInventarioSalida(varDocEntry, varDocNum, objLaboratorioCab.CabCodigo);
                    clsGraLaboratorioCab.proActCstAcumulado(varDocEntry, objLaboratorioCab.CabCodigo);
                    XtraMessageBox.Show(string.Format("El registro nro. {0} ya ha sido enviado a SAP", objLaboratorioCab.CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else varMensaje = objLaboratorioCab.funEnviarSalMercanciaSAP();

                //Verifico si el documento de diario no haya sido enviado a SAP
                objDtVerificarSAP = clsGraLaboratorioCab.funVerificarDiarioSAP(objLaboratorioCab.DocNombre, objLaboratorioCab.CabNumero);
                //Verifico si el documento no haya sido enviado a SAP
                if (objLaboratorioCab.EstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                    //Actualizacion en el formulario de movimientos de inventario
                    varDocEntry = int.Parse(objDtVerificarSAP.Rows[0]["TransId"].ToString());
                    varDocNum = int.Parse(objDtVerificarSAP.Rows[0]["Number"].ToString());
                    clsGraLaboratorioCab.proActDiario(varDocEntry, varDocNum, objLaboratorioCab.CabCodigo);
                    //Actualizamos  las lineas del detalle de actualizacion de costos
                    clsGraCstAcumulado.proActualizarCstAcumulado(objLaboratorioCab.AnmCodigo, objLaboratorioCab.CabFecha, "Bla", "GRA_DETLABORATORIO", "LABORATORIO", objLaboratorioCab.CabCodigo);
                    //Actualizamos  las lineas del detalle de actualizacion de costos standares
                    clsGraCstStdAcumulado.proActualizarCstStdAcumulado(objLaboratorioCab.AnmCodigo, objLaboratorioCab.CabFecha, "Bla", objLaboratorioCab.CabCodigo);
                    XtraMessageBox.Show(string.Format("El registro nro. {0} ya ha sido enviado a SAP", objLaboratorioCab.CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else varMensaje = objLaboratorioCab.funEnviarDiarioSAP();

                objDtVerificarSAP = clsGraLaboratorioCab.funVerificarEntInventarioSAP(objLaboratorioCab.DocNombre, objLaboratorioCab.CabNumero);
                //Verifico si el documento no haya sido enviado a SAP
                if (objLaboratorioCab.EstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0){
                    //Actualizacion en el formulario de movimientos de inventario
                    varDocEntry = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                    varDocNum = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                    clsGraLaboratorioCab.proActMovInventarioEntrada(varDocEntry, varDocNum, objLaboratorioCab.CabCodigo);
                    XtraMessageBox.Show(string.Format("El registro nro. {0} ya ha sido enviado a SAP", objLaboratorioCab.CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else varMensaje = objLaboratorioCab.funEnviarEntMercanciaSAP();

                if (varMensaje.Equals("")) XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", objLaboratorioCab.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objLaboratorioCab.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
        #region Eventos del formulario
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try
            {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocCodigo"].ToString());
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = int.Parse(grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    //Verificamos que los costos acumulados esten cerrados
                    proEnviarSAP(varRegistro);
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos el codigo interno del registro de laboratorio
                        varRegistro = int.Parse(grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        proEnviarSAP(varRegistro);
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}
