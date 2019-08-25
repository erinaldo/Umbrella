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
    public partial class xfrmGraLisParto : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGraLisParto()
        {
            InitializeComponent();
        }
        #region Procedimientos heredados
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Registro de partos";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisParto";
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
            try
            {
                xfrmGraManParto objFormulario = new xfrmGraManParto(varCodFormulario, varCodOperacion, 0);
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
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                    {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //Instanciamos el formulario del mantenimiento de laboratorio
                        xfrmGraManLaboratorio frmFormulario = new xfrmGraManLaboratorio(varCodFormulario, varCodOperacion, varRegistro);
                        frmFormulario.ShowDialog();
                    }
                }
                else
                {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows())
                    {
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
                        else
                        {
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
        #endregion
        #region Procedimiento
        private void proActListado()
        {
            try
            {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0}) ", varDocumento);
                this.grcListado.DataSource = clsGraPartoCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
