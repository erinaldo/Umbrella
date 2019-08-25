using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Logistica.Mantenimiento;
using umbNegocio;
using umbNegocio.Logistica;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Logistica.Listado
{
    public partial class xfrmLogLisGuiaRemision : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmLogLisGuiaRemision()
        {
            InitializeComponent();
        }
        public xfrmLogLisGuiaRemision(bool varBandera) {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Guias de remision";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Logistica.Listado.xfrmLogLisGuiaRemision";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos del listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion nuevo
        public override void proNuevo()
        {
            base.proNuevo();
            try {
                using (xfrmLogManGuiaRemision objFormulario = new xfrmLogManGuiaRemision(varCodFormulario, varCodOperacion, 0))
                {
                    objFormulario.StartPosition = FormStartPosition.CenterScreen;
                    objFormulario.ShowDialog();
                    //Actualizamos los datos de listado despues de realizar los cambios
                    this.proActListado();
                }
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
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(varRegistro)[0];
                    if (objVerificarGuiaRemision.EstCodigo.ToUpper().Equals("CER")){
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido cerrado", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        xfrmLogManGuiaRemision objFormulario = new xfrmLogManGuiaRemision(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                else{
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                        if (objVerificarGuiaRemision.EstCodigo.ToUpper().Equals("CER")) {
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido cerrado", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else {
                            xfrmLogManGuiaRemision objFormulario = new xfrmLogManGuiaRemision(varCodFormulario, varCodOperacion, varRegistro);
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
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    xfrmLogManGuiaRemision objFormulario = new xfrmLogManGuiaRemision(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()){
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        xfrmLogManGuiaRemision objFormulario = new xfrmLogManGuiaRemision(varCodFormulario, varCodOperacion, varRegistro);
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

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(varRegistro)[0];
                    if (objVerificarGuiaRemision.EstCodigo.ToUpper().Equals("CER")) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido cerrado", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsLogGuiaRemisionCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(varRegistro)[0];
                        if (objVerificarGuiaRemision.EstCodigo.ToUpper().Equals("CER")) {
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido cerrado", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsLogGuiaRemisionCab.proAnular(varRegistro);
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
        #region Procedimiento
        private void proActListado()
        {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);
                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                this.grcListado.DataSource = varBanListado ? clsLogGuiaRemisionCab.funListarValorada(1, varDocumento) : clsLogGuiaRemisionCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try {
                int varRegistro = 0;
                int varCabNumero = 0;
                 //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
                    varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                    if (objVerificarGuiaRemision.CabEstado.ToUpper().Equals("I")) {
                        clsLogGuiaRemisionCab.proCerrar(varRegistro);
                        XtraMessageBox.Show(string.Format("El registro nro: {0} ha sido enviado a SAP", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        XtraMessageBox.Show(string.Format("El registro nro: {0} debe estar inactivo para ser enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        clsLogGuiaRemisionCab objVerificarGuiaRemision = clsLogGuiaRemisionCab.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                        if (objVerificarGuiaRemision.CabEstado.ToUpper().Equals("I")) {
                            clsLogGuiaRemisionCab.proCerrar(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro: {0} ha sido enviado a SAP", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            XtraMessageBox.Show(string.Format("El registro nro: {0} debe estar inactivo para ser enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnEstado_Click(object sender, EventArgs e)
        {
            try {
                //Verificamos que existan filas en el detalle y q la fila seleccionada este con datos
                if (this.grvListado.RowCount > 0 && this.grvListado.GetFocusedRow() != null)
                {
                    string varEstado = "";
                    int varCabCodigo = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    int varCabNumero = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;

                    clsLogGuiaRemisionCab csRegistro = new clsLogGuiaRemisionCab();
                    csRegistro = clsLogGuiaRemisionCab.funListar(varCabCodigo)[0];

                    if (this.btnEstado.Text.Equals("&Inactivar")) { csRegistro.CabEstado = "I"; varEstado = "Inactivado"; }
                    else { csRegistro.CabEstado = "A"; varEstado = "Activado"; }

                    clsLogGuiaRemisionCab.proEstado(varCabCodigo, csRegistro.CabEstado);
                    XtraMessageBox.Show(string.Format("El registro nro: {0} ha sido {1}", varCabNumero, varEstado), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Actualizamos los datos de listado despues de realizar los cambios
                    this.proActListado();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
        private void grvListado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            try {
                //Verificamos que existan filas en el detalle y q la fila seleccionada este con datos
                if (this.grvListado.RowCount > 0 && this.grvListado.GetFocusedRow() != null)
                {
                    string varCabEstado = ((clsLogGuiaRemisionCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabEstado;
                    if (varCabEstado.Equals("A"))
                    {
                        this.btnEstado.Text = "&Inactivar";
                        this.btnEstado.Image = global::umbAplicacion.Properties.Resources.imgBorrar16;
                    }
                    else
                    {
                        this.btnEstado.Text = "&Activar";
                        this.btnEstado.Image = global::umbAplicacion.Properties.Resources.imgConfirmar16;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
