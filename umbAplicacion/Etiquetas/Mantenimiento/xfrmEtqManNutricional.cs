using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Entidades;
using umbNegocio.Etiquetas;

namespace umbAplicacion.Etiquetas.Mantenimiento
{
    public partial class xfrmEtqManNutricional : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private DataTable dtNutricional;
        public xfrmEtqManNutricional() { InitializeComponent(); }
        public xfrmEtqManNutricional(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Mantenimiento de etiqueta nutricional";
                switch (varOpeCodigo) {
                    case 1: //Insertar
                        //Iniciamos los campos para poder ingresar la informacion
                        this.proIniciarCampos();
                        break;
                    case 2: //Modificar
                    case 4: //Consultar
                        //Inicializamos el plan de cuentas y centros de costo para los detalles
                        //this.gluPlanCuenta.DataSource = clsFinPlaCuenta.funListar();
                        //this.gluCenCosto.DataSource = clsFinCenCosto.funListar();

                        //objNormaReparto = new clsCosNormaReparto();
                        //objNormaReparto.metConsultar(varRegCodigo);
                        //if (objNormaReparto.DetCenCosto != null)
                        //{
                        //    this.txtCodigo.Text = objNormaReparto.CcrCodigo.ToString();
                        //    this.txtDescripcion.Text = objNormaReparto.CcrDescripcion;
                        //    this.bedCcoCodigo.EditValue = objNormaReparto.CcoCodigo;
                        //    this.txtCcoNombre.Text = objNormaReparto.CcoNombre;
                        //    this.chkActivo.Checked = objNormaReparto.CcrActivo.Equals("Activo") ? true : false;
                        //    //Plan de cuenta
                        //    dtDetPlanCuenta = new List<clsCosDetPlanCuenta>();
                        //    dtDetPlanCuenta = objNormaReparto.DetPlanCuenta;
                        //    this.grcDetPlanCuenta.DataSource = dtDetPlanCuenta;
                        //    //Centros de costo
                        //    dtDetCenCosto = new List<clsCosDetCenCosto>();
                        //    dtDetCenCosto = objNormaReparto.DetCenCosto;
                        //    this.grcDetCenCosto.DataSource = dtDetCenCosto;
                        //    //Verificamos si tiene mas de una linea el detalle 
                        //    if (this.grvDetPlanCuenta.RowCount > 1)
                        //    {
                        //        this.grvDetPlanCuenta.FocusedRowHandle = 1;
                        //        this.grvDetPlanCuenta.FocusedRowHandle = 0;
                        //    }
                        //}
                        break;
                }
                var csValidaciones = new Umbrella.clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        #region Procedimientos y funciones del formulario
        private void proIniciarCampos() {
            //Enceramos los campos
            this.txtCodigo.Text = "0";
            /*this.txtNombre.Text = "";
            this.memInformacion.Text = "";
            this.memRegistro.Text = "";
            this.memLeyenda1.Text = "";
            this.txtPeso.Text = "";
            this.txtCodBarra.Text = "";
            this.txtLeyenda2.Text = "";*/
            //Inicializamos la grilla
            this.proDtTablaNutricional();
            //Creamos las filas de la tabla nutricional
            this.proDrTablaNutricional();
        }
        private void proDtTablaNutricional() {
            dtNutricional = new DataTable() { TableName = "Nutricional" };
            dtNutricional.Columns.Add("EtnDescripcion", typeof(string));
            dtNutricional.Columns.Add("EtnLabelUndMedida", typeof(string));
            dtNutricional.Columns.Add("EtnValorUndMedida", typeof(string));
            dtNutricional.Columns.Add("EtnLabelPorcentaje", typeof(string));
            dtNutricional.Columns.Add("EtnValorPorcentaje", typeof(string));

            this.grcListado.DataSource = dtNutricional;
        }
        private void proDrTablaNutricional() {
            dtNutricional.Rows.Add("Tamaño por ración:", "Label7", "", "", "");
            dtNutricional.Rows.Add("Porciones por envase:", "Label8", "", "", "");
            dtNutricional.Rows.Add("Energía (Calorías):", "Label9", "", "", "");
            dtNutricional.Rows.Add("Energía (Calorías a la grasa):", "Label10", "", "", "");
            dtNutricional.Rows.Add("Grasa Total:", "Label11", "", "Label12", "");
            dtNutricional.Rows.Add("Acidos grasos saturados:", "Label13", "", "Label14", "");
            dtNutricional.Rows.Add("Acidos grasos trans:", "Label15", "", "Label16", "");
            dtNutricional.Rows.Add("Acidos grasos mono insaturados:", "Label17", "", "Label18", "");
            dtNutricional.Rows.Add("Acidos grasos poli insaturados:", "Label19", "", "Label20", "");
            dtNutricional.Rows.Add("Colesterol:", "Label21", "", "Label22", "");
            dtNutricional.Rows.Add("Sodio:", "Label23", "", "Label24", "");
            dtNutricional.Rows.Add("Carbohidratos Totales:", "Label25", "", "Label26", "");
            dtNutricional.Rows.Add("Fibra:", "Label27", "", "Label28", "");
            dtNutricional.Rows.Add("Azúcar:", "Label29", "", "Label30", "");
            dtNutricional.Rows.Add("Proteina:", "Label31", "", "Label32", "");

        }
        #endregion
        #region Procedimientos y funciones heredadas
        public override void proGrabar() {
            base.proGrabar();
            try {
                EntETQ_NUTRICIONAL objRegistro = new EntETQ_NUTRICIONAL();
                objRegistro.EtnCodigo = int.Parse(this.txtCodigo.Text);
                objRegistro.EtnLabel1 = this.txtNombre.Text;  //Nombre del producto
                objRegistro.EtnLabel2 = this.memInformacion.Text; //Información del producto
                objRegistro.EtnLabel3 = this.memRegistro.Text; //Registro sanitario
                objRegistro.EtnLabel4 = this.txtPeso.Text; //Peso
                objRegistro.EtnLabel5 = this.txtCodBarra.Text; //Codigo de barras
                objRegistro.EtnLabel6 = this.memLeyenda1.Text;  //Leyenda junto a la información nutricional
                objRegistro.EtnLabel7 = dtNutricional.Rows[0]["EtnValorUndMedida"].ToString(); //Tamaño por ración
                objRegistro.EtnLabel8 = dtNutricional.Rows[1]["EtnValorUndMedida"].ToString(); //Porciones por envase
                objRegistro.EtnLabel9 = dtNutricional.Rows[2]["EtnValorUndMedida"].ToString(); //Energía calorías
                objRegistro.EtnLabel10 = dtNutricional.Rows[3]["EtnValorUndMedida"].ToString(); //Energía calorías a la grasa
                objRegistro.EtnLabel11 = dtNutricional.Rows[4]["EtnValorUndMedida"].ToString(); //Grasa total gramos
                objRegistro.EtnLabel12 = dtNutricional.Rows[4]["EtnValorPorcentaje"].ToString(); //Grasa total porcentaje
                objRegistro.EtnLabel13 = dtNutricional.Rows[5]["EtnValorUndMedida"].ToString(); //Acidos grasos saturados gramos
                objRegistro.EtnLabel14 = dtNutricional.Rows[5]["EtnValorPorcentaje"].ToString(); //Acidos grasos saturados porcentaje
                objRegistro.EtnLabel15 = dtNutricional.Rows[6]["EtnValorUndMedida"].ToString(); //Acidos grasos trans gramos
                objRegistro.EtnLabel16 = dtNutricional.Rows[6]["EtnValorPorcentaje"].ToString(); //Acidos grasos trans porcentaje
                objRegistro.EtnLabel17 = dtNutricional.Rows[7]["EtnValorUndMedida"].ToString(); //Acidos grasos mono insaturados gramos
                objRegistro.EtnLabel18 = dtNutricional.Rows[7]["EtnValorPorcentaje"].ToString(); //Acidos grasos mono insaturados porcentaje
                objRegistro.EtnLabel19 = dtNutricional.Rows[8]["EtnValorUndMedida"].ToString(); //Acidos grasos poli insaturados gramos
                objRegistro.EtnLabel20 = dtNutricional.Rows[8]["EtnValorPorcentaje"].ToString(); //Acidos grasos poli insaturados porcentaje
                objRegistro.EtnLabel21 = dtNutricional.Rows[9]["EtnValorUndMedida"].ToString(); //Colesterol gramos
                objRegistro.EtnLabel22 = dtNutricional.Rows[9]["EtnValorPorcentaje"].ToString(); //Colesterol porcentaje
                objRegistro.EtnLabel23 = dtNutricional.Rows[10]["EtnValorUndMedida"].ToString(); //Sodio gramos
                objRegistro.EtnLabel24 = dtNutricional.Rows[10]["EtnValorPorcentaje"].ToString(); //Sodio porcentaje
                objRegistro.EtnLabel25 = dtNutricional.Rows[11]["EtnValorUndMedida"].ToString(); //Carbohidratos totales gramos
                objRegistro.EtnLabel26 = dtNutricional.Rows[11]["EtnValorPorcentaje"].ToString(); //Carbohidratos totales porcentaje
                objRegistro.EtnLabel27 = dtNutricional.Rows[12]["EtnValorUndMedida"].ToString(); //Fibra gramos
                objRegistro.EtnLabel28 = dtNutricional.Rows[12]["EtnValorPorcentaje"].ToString(); //Fibra porcentaje
                objRegistro.EtnLabel29 = dtNutricional.Rows[13]["EtnValorUndMedida"].ToString(); //Azucar gramos
                objRegistro.EtnLabel30 = dtNutricional.Rows[13]["EtnValorPorcentaje"].ToString(); //Azucar porcentaje
                objRegistro.EtnLabel31 = dtNutricional.Rows[14]["EtnValorUndMedida"].ToString(); //Proteina gramos
                objRegistro.EtnLabel32 = dtNutricional.Rows[14]["EtnValorPorcentaje"].ToString(); //Proteina porcentaje
                objRegistro.EtnLabel33 = txtLeyenda2.Text; //Leyenda 2 requiere cocción

                object[] objResultado = new object[2];
                switch (varOpeCodigo) {
                    case 1: //Insertar
                        objResultado = daoEtqNutricional.getInstance().metInsertar(objRegistro);
                        if (objResultado[0].Equals("ok")) {
                            clsMensajesSistema.metMsgInformativo(objResultado[1].ToString());
                            this.Close();
                        } else { clsMensajesSistema.metMsgError(objResultado[1].ToString()); }
                        break;
                    case 2:
                        objResultado = daoEtqNutricional.getInstance().metModificar(objRegistro);
                        if (objResultado[0].Equals("ok")) {
                            clsMensajesSistema.metMsgInformativo(objResultado[1].ToString());
                            this.Close();
                        }
                        else { clsMensajesSistema.metMsgError(objResultado[1].ToString()); }
                        break;
                    default:
                        break;
                }
                this.Close();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        #endregion
    }
}
