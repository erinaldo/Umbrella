using umbAplicacion.Inventario.Mantenimiento;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;
using Umbrella;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace umbAplicacion.Inventario.Listado
{
    public partial class xfrmInvLisMovimiento : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        //private clsCABMOVIMIENTO obj = new clsCABMOVIMIENTO();
        public xfrmInvLisMovimiento()
        {
            InitializeComponent();
        }
        #region Procedimientos heredados
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Entrada/Salida de mercancias";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Inventario.Listado.xfrmInvLisMovimiento";
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
                xfrmInvManMovimiento objFormulario = new xfrmInvManMovimiento(varCodFormulario, varCodOperacion, 0);
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
                int varCabNumero = 0;
                string varDocNombre = "";
                string varTipMovimiento = "";
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
                    varTipMovimiento = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabTipMovimiento"].ToString();
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    if (varTipMovimiento.ToUpper().Equals("ENTRADA")) objDtVerificarSAP = clsInvMovimientoCab.funVerificarEntInventarioSAP(varDocNombre, varCabNumero);
                    else objDtVerificarSAP = clsInvMovimientoCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de entrada de mercancias
                        xfrmInvManMovimiento frmFormulario = new xfrmInvManMovimiento(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        varCabNumero = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabNumero"].ToString());
                        varDocNombre = this.grvListado.GetDataRow(varPosicion)["DocNombre"].ToString();
                        varTipMovimiento = this.grvListado.GetDataRow(varPosicion)["CabTipMovimiento"].ToString();
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        if (varTipMovimiento.ToUpper().Equals("ENTRADA")) objDtVerificarSAP = clsInvMovimientoCab.funVerificarEntInventarioSAP(varDocNombre, varCabNumero);
                        else objDtVerificarSAP = clsInvMovimientoCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            //Instanciamos el formulario del mantenimiento de entrada de mercancias
                            xfrmInvManMovimiento frmFormulario = new xfrmInvManMovimiento(varCodFormulario, varCodOperacion, varRegistro);
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
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["DocCodigo"].ToString());
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabCodigo"].ToString());
                    xfrmInvManMovimiento frmFormulario = new xfrmInvManMovimiento(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.ShowDialog();
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = int.Parse(this.grvListado.GetDataRow(varPosicion)["DocCodigo"].ToString());
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = int.Parse(this.grvListado.GetDataRow(varPosicion)["CabCodigo"].ToString());
                        xfrmInvManMovimiento frmFormulario = new xfrmInvManMovimiento(varCodFormulario, varCodOperacion, varRegistro);
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
            try {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varTipMovimiento = "";
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
                    varTipMovimiento = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["CabTipMovimiento"].ToString();
                    varEstCodigo = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["EstCodigo"].ToString();
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    if (varTipMovimiento.ToUpper().Equals("ENTRADA")) objDtVerificarSAP = clsInvMovimientoCab.funVerificarEntInventarioSAP(varDocNombre, varCabNumero);
                    else objDtVerificarSAP = clsInvMovimientoCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                             clsInvMovimientoCab.proAnular(varRegistro);
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
                        varTipMovimiento = this.grvListado.GetDataRow(varPosicion)["CabTipMovimiento"].ToString();
                        varEstCodigo = this.grvListado.GetDataRow(varPosicion)["EstCodigo"].ToString();
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        if (varTipMovimiento.ToUpper().Equals("ENTRADA")) objDtVerificarSAP = clsInvMovimientoCab.funVerificarEntInventarioSAP(varDocNombre, varCabNumero);
                        else objDtVerificarSAP = clsInvMovimientoCab.funVerificarSalInventarioSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsInvMovimientoCab.proAnular(varRegistro);
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
            try
            {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsInvMovimientoCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Procedimiento para enviar a SAP la informacion
        private void proEnviarSAP(int varRegistro)
        {
            try{
               string  varMensaje = "";
               //Instanciamos la clase de movimientos de inventario
               clsInvMovimientoCab objMovimientoCab = new clsInvMovimientoCab();
               //Recuperamos la informacion de cabecera de movimientos de inventario
               objMovimientoCab = clsInvMovimientoCab.funListar(varRegistro)[0];
               //Verificamos si el documento ya ha sido ingresado en SAP
               DataTable objDtVerificarSAP;
               if (objMovimientoCab.CabTipMovimiento.ToUpper().Equals("ENTRADA")) objDtVerificarSAP = clsInvMovimientoCab.funVerificarEntInventarioSAP(objMovimientoCab.DocNombre, objMovimientoCab.CabNumero);
               else objDtVerificarSAP = clsInvMovimientoCab.funVerificarSalInventarioSAP(objMovimientoCab.DocNombre, objMovimientoCab.CabNumero);
               //Verifico si el documento no haya sido enviado a SAP
               if (objMovimientoCab.EstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                   //Actualizacion en el formulario de movimientos de inventario
                   objMovimientoCab.CabDocEntrySAP = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                   objMovimientoCab.CabNumeroSAP = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                   clsInvMovimientoCab.proActMovInventarioSalida(objMovimientoCab.CabDocEntrySAP, objMovimientoCab.CabNumeroSAP, objMovimientoCab.CabCodigo);
                   clsInvMovimientoCab.proActCstAcumulado(objMovimientoCab.CabDocEntrySAP, objMovimientoCab.CabCodigo);
                   XtraMessageBox.Show(string.Format("El registro nro. {0} ya ha sido enviado a SAP", objMovimientoCab.CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else {
                   if (objMovimientoCab.CabTipMovimiento.ToUpper().Equals("ENTRADA")) { }
                   else
                   {
                       varMensaje = objMovimientoCab.funEnviarSalMercanciaSAP();
                       if (varMensaje.Equals("")) {
                           XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", objMovimientoCab.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       else
                           XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objMovimientoCab.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
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
                    proEnviarSAP(varRegistro);
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
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
        
    }
}