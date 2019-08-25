using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.GestionBancos.Mantenimiento;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;
using umbNegocio.GestionBancos;

namespace umbAplicacion.GestionBancos.Listado
{
    public partial class xfrmGbaLisExtBancario : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGbaLisExtBancario()
        {
            InitializeComponent();
        }
        public xfrmGbaLisExtBancario(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        //Procedimiento de iniciacion del formulario
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Extractos bancarios";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.GestionBancos.Listado.xfrmGbaLisExtBancario";
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
                xfrmGbaManExtBancario objFormulario = new xfrmGbaManExtBancario(varCodFormulario, varCodOperacion, 0);
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
                 //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    int varCuantos = clsGbaExtBancarioCab.funCuantosExtBancarioSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varCuantos > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGbaManExtBancario objFormulario = new xfrmGbaManExtBancario(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                else {
                     foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                         //Recuperamos el codigo del documento seleccionado
                         varCodDocumento = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                         base.proModificar();
                         if (!varBanAcceso) return;
                         //Recuperamos en la variable registro el codigo del documento
                         varRegistro = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                         varCabNumero = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                         varDocNombre = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).DocNombre;
                         //Verificamos si el documento ya ha sido ingresado en SAP
                         int varCuantos = clsGbaExtBancarioCab.funCuantosExtBancarioSAP(varDocNombre, varCabNumero);
                         //Verifico si el documento no haya sido enviado a SAP
                         if (varCuantos > 0) {
                             XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                         else {
                             //Instanciamos el formulario del mantenimiento de laboratorio
                             xfrmGbaManExtBancario objFormulario = new xfrmGbaManExtBancario(varCodFormulario, varCodOperacion, varRegistro);
                             objFormulario.ShowDialog();
                         }
                     }
                }
                proActListado();
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
                    varCodDocumento = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;

                    varRegistro = ((clsGbaExtBancarioCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    //Instanciamos el formulario del mantenimiento de laboratorio
                    xfrmGbaManExtBancario objFormulario = new xfrmGbaManExtBancario(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGbaManExtBancario objFormulario = new xfrmGbaManExtBancario(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int varPosicion in this.grvListado.GetSelectedRows())
                {
                    int varRegistro = ((clsGbaExtBancarioCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    clsGbaExtBancarioCab csGbaExtBancario = clsGbaExtBancarioCab.funListar(varRegistro)[0];
                    string varMensaje = csGbaExtBancario.funEnviarExtBancarioSAP();
                    
                    if (varMensaje.Equals(""))
                        XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", csGbaExtBancario.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}",csGbaExtBancario.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Procedimiento
        private void proActListado()
        {
            try
            {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0})", varDocumento);
                this.grcListado.DataSource = clsGbaExtBancarioCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
