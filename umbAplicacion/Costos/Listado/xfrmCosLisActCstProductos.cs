using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Costos.Mantenimiento;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;
using umbNegocio.Granja;

namespace umbAplicacion.Costos.Listado
{
    public partial class xfrmCosLisActCstProductos : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmCosLisActCstProductos()
        {
            InitializeComponent();
        }
        #region Procedimientos heredados
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Actualizacion costo de items";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Costos.Listado.xfrmCosLisActCstProductos";
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
                xfrmCosManActCstProductos frmFormulario = new xfrmCosManActCstProductos(varCodFormulario, varCodOperacion, 0);
                frmFormulario.ShowDialog();
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
                string varEstCodigo = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varEstCodigo = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP")) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario de la actualizacion de costos de items
                        xfrmCosManActCstProductos frmFormulario = new xfrmCosManActCstProductos(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varEstCodigo = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        if (varEstCodigo.ToUpper().Equals("SAP"))
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            //Instanciamos el formulario de la actualizacion de costos de items
                            xfrmCosManActCstProductos frmFormulario = new xfrmCosManActCstProductos(varCodFormulario, varCodOperacion, varRegistro);
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
            try {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    //Instanciamos el formulario de la actualizacion de costos de items
                    xfrmCosManActCstProductos frmFormulario = new xfrmCosManActCstProductos(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        //Instanciamos el formulario de la actualizacion de costos de items
                        xfrmCosManActCstProductos frmFormulario = new xfrmCosManActCstProductos(varCodFormulario, varCodOperacion, varRegistro);
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
                int varCuantos = 0;
                string varDocNombre = "";
                string varEstCodigo = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    varCuantos = clsCosActCstProductos.funVerificarSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || varCuantos > 0)
                    {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (XtraMessageBox.Show("Esta seguro de eliminar el registro seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clsCosActCstProductos.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsGraEntCompra)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        varCuantos = clsCosActCstProductos.funVerificarSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || varCuantos > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (XtraMessageBox.Show("Esta seguro de eliminar el registro seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                clsCosActCstProductos.proAnular(varRegistro);
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
        #region Procedimientos
        //Procedimentos para listar los documentos 
        private void proActListado()
        {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsCosActCstProductos.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        private void proEnviarSAP(int varRegistro)
        {
                try {
                    string varMensaje = "";
                    //Instanciamos la clase de actualizacion de costos de items
                    clsCosActCstProductos objActCstProductos = new clsCosActCstProductos();
                    //Recuperamos la informacion de cabecera del registro de actualizacion de costos de items
                    objActCstProductos = clsCosActCstProductos.funListar(varRegistro)[0];
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (objActCstProductos.EstCodigo.ToUpper().Equals("SAP"))
                        XtraMessageBox.Show(string.Format("El registro nro. {0} ya ha sido enviado a SAP", objActCstProductos.CabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        objActCstProductos.DetActCstFormulacion = clsCosActCstProductos.funRecDetActCstFormulacion(varRegistro);
                        objActCstProductos.DetActCstMaterial = clsCosActCstProductos.funRecDetActCstMaterial(varRegistro);

                        varMensaje = clsCosActCstProductos.funEnviarDocumentoSAP(objActCstProductos, objActCstProductos.CabNumero);

                        if (varMensaje.Equals(""))
                            XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", objActCstProductos.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objActCstProductos.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
        #region Eventos del formulario
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try {
                int varRegistro = 0;
                  //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Obtenemos informacion de si el usuario tiene acceso al documento con la operacion seleccionada
                    varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
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
                        varCodDocumento = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos el codigo interno del registro de laboratorio
                        varRegistro = ((clsCosActCstProductos)this.grvListado.GetRow(varPosicion)).CabCodigo;
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
