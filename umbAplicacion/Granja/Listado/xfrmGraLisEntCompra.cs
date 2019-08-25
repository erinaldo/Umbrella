using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Seguridad;
using umbAplicacion.Granja.Mantenimiento;
using Umbrella;
using umbNegocio.Granja;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisEntCompra : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisEntCompra()
        {
            InitializeComponent();
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Entrada de mercancia (Compra)";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisEntCompra";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos del listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proNuevo()
        {
            base.proNuevo();
            try
            {
                using (xfrmGraManEntCompra frmFormulario = new xfrmGraManEntCompra(varCodFormulario, 1, 0))
                {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    //Actualizamos los datos de listado despues de realizar los cambios
                    this.proActListado();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proModificar()
        {
            int varRegistro = 0;
            int varCabNumero = 0;
            string varDocNombre = "";
            try
            {
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de entrada de mercancias
                        xfrmGraManEntCompra frmFormulario = new xfrmGraManEntCompra(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocNombre;
                        DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).EstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            //Instanciamos el formulario del mantenimiento de entrada de mercancias
                            xfrmGraManEntCompra frmFormulario = new xfrmGraManEntCompra(varCodFormulario, varCodOperacion, varRegistro);
                            frmFormulario.ShowDialog();
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proConsultar()
        {
            int varRegistro = 0;
            try
            {
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    xfrmGraManEntCompra frmFormulario = new xfrmGraManEntCompra(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.ShowDialog();
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        xfrmGraManEntCompra frmFormulario = new xfrmGraManEntCompra(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proEliminar()
        {
            try {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser eliminado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsGraEntCompra.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                foreach (int varPosicion in this.grvListado.GetSelectedRows())
                {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabNumero;
                    varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocNombre;
                    varEstCodigo = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).EstCodigo;
                    DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser eliminado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsGraEntCompra.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proActListado()
        {
            try
            {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0}) And a.CabFecha between '{1}' And '{2}' and a.EstCodigo = 'Nor'", varDocumento, DateTime.Now.Year.ToString() + "/01/01", DateTime.Now.Year.ToString() + "/12/31");
                this.grcListado.DataSource = clsGraEntCompra.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try
            {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";
                string varMensaje = "";
                        
                //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
                varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                //Si ya ha sido enviado a SAP terminamos el proceso
                if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser eliminado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        clsGraEntCompra csGraEntMercancias = clsGraEntCompra.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];
                        //Enviamos el documento a SAP
                        varMensaje = csGraEntMercancias.funEnviarDocumentoSAP(csGraEntMercancias, csGraEntMercancias.CabNumero);
                        if (varMensaje.Equals(""))
                            XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", varCabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).EstCodigo;
                         DataTable objDtVerificarEntMercanciaSAP = clsGraEntCompra.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                         //Verifico si el documento no haya sido enviado a SAP
                         if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarEntMercanciaSAP.Rows.Count > 0) {
                             XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser eliminado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                         else {
                             clsGraEntCompra csGraEntMercancias = clsGraEntCompra.funListar(string.Format("Where a.CabCodigo = {0}", varRegistro))[0];

                             varMensaje = csGraEntMercancias.funEnviarDocumentoSAP(csGraEntMercancias, varCabNumero);
                             if (varMensaje.Equals(""))
                                 XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP",varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             else
                                 XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", varCabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
