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
        private DataTable dtColores;
        public xfrmEtqManNutricional() { InitializeComponent(); }
        public xfrmEtqManNutricional(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        
        
        #region Procedimientos y funciones del formulario
        private void proIniciarCampos() {
            //Enceramos los campos
            this.txtCodigo.Text = "0";
            /*
            this.txtIdProducto.Text = "";
            this.txtNombre.Text = "";
            this.memInformacion.Text = "";
            this.memRegistro.Text = "";
            this.memLeyenda1.Text = "";
            this.txtPeso.Text = "";
            this.txtCodBarra.Text = "";
            this.txtLeyenda2.Text = "";
            this.txtSemaforo1.Text = "";
            this.txtSemaforo2.Text = "";
            this.txtSemaforo3.Text = "";
            this.lueSemaforo1.ItemIndex = 0;
            this.lueSemaforo2.ItemIndex = 0;
            this.lueSemaforo3.ItemIndex = 0;
            */
            //Inicializamos la grilla
            this.proDtTablaNutricional();
            //Creamos las filas de la tabla nutricional
            this.proDrTablaNutricional();
            //Inicializamos el datatable de colores
            this.proDtColores();
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
        private void proDtColores() {
            dtColores = new DataTable() { TableName = "Colores" };
            dtColores.Columns.Add("ColCodigo", typeof(string));
            dtColores.Columns.Add("ColNombre", typeof(string));

            dtColores.Rows.Add("T", "Transparente");
            dtColores.Rows.Add("R", "Rojo");
            dtColores.Rows.Add("A", "Amarillo");
            dtColores.Rows.Add("V", "Verde");

            this.lueSemaforo1.Properties.DataSource = dtColores;
            this.lueSemaforo2.Properties.DataSource = dtColores;
            this.lueSemaforo3.Properties.DataSource = dtColores;

            this.lueSemaforo1.ItemIndex = 0;
            this.lueSemaforo2.ItemIndex = 0;
            this.lueSemaforo3.ItemIndex = 0;
        }
        private EntETQ_NUTRICIONAL funCargarEtqNutricional() {
            EntETQ_NUTRICIONAL objRegistro = new EntETQ_NUTRICIONAL();

            try { 
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
                objRegistro.EtnSemaforo1 = this.txtSemaforo1.Text; //Descripcion del semáforo 1
                objRegistro.EtnColor1 = this.lueSemaforo1.Text; //Color del semáforo 1
                objRegistro.EtnSemaforo2 = this.txtSemaforo2.Text; //Descripcion del semáforo 2
                objRegistro.EtnColor2 = this.lueSemaforo2.Text; //Color del semáforo 2
                objRegistro.EtnSemaforo3 = this.txtSemaforo3.Text; //Descripcion del semáforo 3
                objRegistro.EtnColor3 = this.lueSemaforo3.Text; //Color del semáforo 3
                objRegistro.EtnIdProducto = this.txtIdProducto.Text; //Código de SAP del producto
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
            return objRegistro;
        }
        private void proRecuperarEtqNutricional(int varOpeCodigo) {
            try{
                EntETQ_NUTRICIONAL objRegistro = daoEtqNutricional.getInstance().metConsultar(varRegCodigo);
                if (objRegistro != null) {
                    this.txtCodigo.EditValue =  varOpeCodigo.Equals(2) || varOpeCodigo.Equals(4) ? objRegistro.EtnCodigo : 0;
                    this.txtNombre.Text = objRegistro.EtnLabel1;  //Nombre del producto
                    this.memInformacion.Text = objRegistro.EtnLabel2; //Información del producto
                    this.memRegistro.Text = objRegistro.EtnLabel3; //Registro sanitario
                    this.txtPeso.Text = objRegistro.EtnLabel4; //Peso
                    this.txtCodBarra.Text = objRegistro.EtnLabel5; //Codigo de barras
                    this.memLeyenda1.Text = objRegistro.EtnLabel6;  //Leyenda junto a la información nutricional
                    dtNutricional.Rows[0]["EtnValorUndMedida"] = objRegistro.EtnLabel7; //Tamaño por ración
                    dtNutricional.Rows[1]["EtnValorUndMedida"] = objRegistro.EtnLabel8; //Porciones por envase
                    dtNutricional.Rows[2]["EtnValorUndMedida"] = objRegistro.EtnLabel9; //Energía calorías
                    dtNutricional.Rows[3]["EtnValorUndMedida"] = objRegistro.EtnLabel10; //Energía calorías a la grasa
                    dtNutricional.Rows[4]["EtnValorUndMedida"] = objRegistro.EtnLabel11; //Grasa total gramos
                    dtNutricional.Rows[4]["EtnValorPorcentaje"] = objRegistro.EtnLabel12; //Grasa total porcentaje
                    dtNutricional.Rows[5]["EtnValorUndMedida"] = objRegistro.EtnLabel13; //Acidos grasos saturados gramos
                    dtNutricional.Rows[5]["EtnValorPorcentaje"] = objRegistro.EtnLabel14; //Acidos grasos saturados porcentaje
                    dtNutricional.Rows[6]["EtnValorUndMedida"] = objRegistro.EtnLabel15; //Acidos grasos trans gramos
                    dtNutricional.Rows[6]["EtnValorPorcentaje"] = objRegistro.EtnLabel16; //Acidos grasos trans porcentaje
                    dtNutricional.Rows[7]["EtnValorUndMedida"] = objRegistro.EtnLabel17; //Acidos grasos mono insaturados gramos
                    dtNutricional.Rows[7]["EtnValorPorcentaje"] = objRegistro.EtnLabel18; //Acidos grasos mono insaturados porcentaje
                    dtNutricional.Rows[8]["EtnValorUndMedida"] = objRegistro.EtnLabel19; //Acidos grasos poli insaturados gramos
                    dtNutricional.Rows[8]["EtnValorPorcentaje"] = objRegistro.EtnLabel20; //Acidos grasos poli insaturados porcentaje
                    dtNutricional.Rows[9]["EtnValorUndMedida"] = objRegistro.EtnLabel21; //Colesterol gramos
                    dtNutricional.Rows[9]["EtnValorPorcentaje"] = objRegistro.EtnLabel22; //Colesterol porcentaje
                    dtNutricional.Rows[10]["EtnValorUndMedida"] = objRegistro.EtnLabel23; //Sodio gramos
                    dtNutricional.Rows[10]["EtnValorPorcentaje"] = objRegistro.EtnLabel24; //Sodio porcentaje
                    dtNutricional.Rows[11]["EtnValorUndMedida"] = objRegistro.EtnLabel25; //Carbohidratos totales gramos
                    dtNutricional.Rows[11]["EtnValorPorcentaje"] = objRegistro.EtnLabel26; //Carbohidratos totales porcentaje
                    dtNutricional.Rows[12]["EtnValorUndMedida"] = objRegistro.EtnLabel27; //Fibra gramos
                    dtNutricional.Rows[12]["EtnValorPorcentaje"] = objRegistro.EtnLabel28; //Fibra porcentaje
                    dtNutricional.Rows[13]["EtnValorUndMedida"] = objRegistro.EtnLabel29; //Azucar gramos
                    dtNutricional.Rows[13]["EtnValorPorcentaje"] = objRegistro.EtnLabel30; //Azucar porcentaje
                    dtNutricional.Rows[14]["EtnValorUndMedida"] = objRegistro.EtnLabel31; //Proteina gramos
                    dtNutricional.Rows[14]["EtnValorPorcentaje"] = objRegistro.EtnLabel32; //Proteina porcentaje
                    txtLeyenda2.Text = objRegistro.EtnLabel33; //Leyenda 2 requiere cocción
                    this.txtSemaforo1.Text = objRegistro.EtnSemaforo1; //Descripcion del semáforo 1
                    this.lueSemaforo1.Text = objRegistro.EtnColor1; //Color del semáforo 1
                    this.txtSemaforo2.Text = objRegistro.EtnSemaforo2; //Descripcion del semáforo 2
                    this.lueSemaforo2.Text = objRegistro.EtnColor2; //Color del semáforo 2
                    this.txtSemaforo3.Text = objRegistro.EtnSemaforo3; //Descripcion del semáforo 3
                    this.lueSemaforo3.Text = objRegistro.EtnColor3; //Color del semáforo 3
                    this.txtIdProducto.Text = objRegistro.EtnIdProducto; //Código de SAP del producto
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
            

        }
        #endregion

        #region Procedimientos y funciones heredadas
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
                        //Inicializamos los campos para poder ingresar la informacion
                        this.proIniciarCampos();
                        //Recuperamos la informacion de la base de datos
                        this.proRecuperarEtqNutricional(varOpeCodigo);
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        break;
                    case 5:
                        //Iniciamos los campos para poder ingresar la informacion
                        this.proIniciarCampos();
                        //Recuperamos la informacion de la base de datos
                        this.proRecuperarEtqNutricional(varOpeCodigo);
                        break;
                }
                var csValidaciones = new Umbrella.clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proGrabar() {
            base.proGrabar();
            try {
                //Cargamos los datos en el objeto para mandar a grabar 
                EntETQ_NUTRICIONAL objRegistro = funCargarEtqNutricional();

                object[] objResultado = new object[2];
                switch (varOpeCodigo) {
                    case 1: //Insertar
                    case 5: //Copiar
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

        private void btnVisualizar_Click(object sender, EventArgs e) {
            try {
                EntETQ_NUTRICIONAL objRegistro = funCargarEtqNutricional();
                new xfrmPreview(objRegistro).ShowDialog(this);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void lueSemaforo1_EditValueChanged(object sender, EventArgs e) {
            String varColor = this.lueSemaforo1.Text;
            if (varColor.Equals("R")) this.txtSemaforo1.BackColor = Color.Red;
            else if (varColor.Equals("A")) this.txtSemaforo1.BackColor = Color.Yellow;
            else if (varColor.Equals("V")) this.txtSemaforo1.BackColor = Color.Green;
            else txtSemaforo1.BackColor = Color.Transparent;
        }
        private void lueSemaforo2_EditValueChanged(object sender, EventArgs e) {
            String varColor = this.lueSemaforo2.Text;
            if (varColor.Equals("R")) this.txtSemaforo2.BackColor = Color.Red;
            else if (varColor.Equals("A")) this.txtSemaforo2.BackColor = Color.Yellow;
            else if (varColor.Equals("V")) this.txtSemaforo2.BackColor = Color.Green;
            else txtSemaforo2.BackColor = Color.Transparent;
        }
        private void lueSemaforo3_EditValueChanged(object sender, EventArgs e) {
            String varColor = this.lueSemaforo3.Text;
            if (varColor.Equals("R")) this.txtSemaforo3.BackColor = Color.Red;
            else if (varColor.Equals("A")) this.txtSemaforo3.BackColor = Color.Yellow;
            else if (varColor.Equals("V")) this.txtSemaforo3.BackColor = Color.Green;
            else txtSemaforo3.BackColor = Color.Transparent;
        }
    }
}
