using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.General;
using umbNegocio.Granja;
using umbNegocio.Inventario;
using umbNegocio.Produccion;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManActCstProductos : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private DataTable dtItemsProducir;
        private DataTable dtMateriales;
        private DataTable dtStockMovimientos;

        private string varOldIteCodigo = "";
        private decimal varOldCantidad = 0;

        public xfrmCosManActCstProductos()
        {
            InitializeComponent();
        }
        public xfrmCosManActCstProductos(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        //Procedimientos heredados
        public override void proIniciarFormulario()
        {
            try
            {
                this.Text = "Actualizacion de costos de productos";

                //Recuperacion a la base de datos de la informacion que va hacer utilizada en el sistema
                this.lueBodega.Properties.DataSource = clsDiccionario.Listar("COSACTBODEGA");
                this.gluItem.DataSource = clsInvItem.funListar();
                this.iluBodega.DataSource = clsGenBodega.funListar();

                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNombre.Text;
                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.lueBodega.ItemIndex = 0;
                        this.proDtActCstProducto();
                        //Agregamos la primera linea del detalle el documento
                        this.dtItemsProducir.Rows.Add(1, "", "", "", 0, "",  0, "", "", 0, 0, 0, 0, 0, 0, "Nor");              
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de consultar
                        foreach (clsCosActCstProductos csRegistro in clsCosActCstProductos.funListar(string.Format("Where CabCodigo = {0}", varRegCodigo))) {
                            varDocCodigo = csRegistro.DocCodigo;
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.Text = csRegistro.DocCodigo.ToString();
                            this.txtNomSerie.Text = csRegistro.DocNombre.ToString();
                            this.txtNumero.Text = csRegistro.CabCodigo.ToString();
                            this.datFecha.EditValue = csRegistro.CabFecha;
                            this.txtNombre.Text = csRegistro.CabDescripcion;
                            this.lueBodega.EditValue = csRegistro.BodCodigo;
                            this.memObsDocumento.Text = csRegistro.CabComentario;
                            this.memObsDiario.Text = csRegistro.CabComenDiario;
                            
                            //Iniciamos los objetos datatable
                            this.proDtActCstProducto();

                            //Recuperamos los datos de los detalles de formulacion y materiales
                            DataTable dtRecFormulacion = clsCosActCstProductos.funRecDetActCstFormulacion(varRegCodigo);
                            DataTable deRecMaterial = clsCosActCstProductos.funRecDetActCstMaterial(varRegCodigo);

                            foreach (DataRow drFormulacion in dtRecFormulacion.Rows) {
                                //Variable que contendra el codigo del item a producir
                                int varDetSecItemProducir = int.Parse(drFormulacion["DetSecuencia"].ToString());
                                //Verificamos si existe la salida de SAP en el item a producir
                                DataTable objDtVerificarSalMercanciaSAP = clsCosActCstProductos.funVerificarSalMercanciaSAP(csRegistro.DocNombre, csRegistro.CabNumero, varDetSecItemProducir);
                                //Variable que contendra el valor del estado del material el cual sera Nor si no ha sido enviado a SAP o Sap si fue enviado
                                string varEstCodigo = (drFormulacion["EstCodigo"].ToString().Equals("Nor") && objDtVerificarSalMercanciaSAP.Rows.Count > 0) ? "Sap" : drFormulacion["EstCodigo"].ToString();

                                this.dtItemsProducir.Rows.Add(int.Parse(drFormulacion["DetSecuencia"].ToString()),                                //Secuencia de la tabla item a producir
                                                                                         drFormulacion["IteCodigo"].ToString(),                                                         //Codigo del item a producir
                                                                                         drFormulacion["IteNombre"].ToString(),                                                        //Nombre del item a producir
                                                                                         drFormulacion["IteUndInventario"].ToString(),                                            //Abreviatura del item a producir
                                                                                         int.Parse(drFormulacion["CabFormula"].ToString()),                                   //Codigo de la formula
                                                                                         drFormulacion["CabVariante"].ToString(),                                                     //Variante de la formula
                                                                                         decimal.Parse(drFormulacion["DetCantidad"].ToString()),                         //Cantidad 
                                                                                         drFormulacion["DetLote"].ToString(),                                                            //Codigo del lote
                                                                                         drFormulacion["DetTieLote"].ToString(),                                                      //Determina si el item es gestionado por lote
                                                                                         int.Parse(drFormulacion["DetSaco"].ToString()),                                          //Numero de sacos
                                                                                         decimal.Parse(drFormulacion["ItePsoStd"].ToString()),                               //Peso estandar del item
                                                                                         decimal.Parse(drFormulacion["DetCosto"].ToString()),                               //Costo del item a producir
                                                                                         int.Parse(drFormulacion["DetNumeroSAPSalida"].ToString()),                  //Codigo de salida de SAP
                                                                                         int.Parse(drFormulacion["DetNumeroSAPEntrada"].ToString()),               //Codigo de entrada de SAP
                                                                                         int.Parse(drFormulacion["DetNumeroSAPDiario"].ToString()),                  //Codigo de diario de SAP
                                                                                         varEstCodigo);                                                                                                    //Estado de la secuencia


                                foreach (DataRow drMaterial in deRecMaterial.Select(string.Format("DetSecItemProducir = {0}", int.Parse(drFormulacion["DetSecuencia"].ToString())))) {
                                    //Recuperamos el saldo del item en su respectiva bodega
                                    decimal varSaldo = clsInvItem.funRecSaldo(drMaterial["IteCodigo"].ToString(), drMaterial["BodCodigo"].ToString());
                                    

                                    this.dtMateriales.Rows.Add(int.Parse(drMaterial["DetSecItemProducir"].ToString()),                              //Secuencia del item a producir
                                                                                       int.Parse(drMaterial["DetSecuencia"].ToString()),                                         //Secuencia de la lista de materiales
                                                                                       drMaterial["IteCodigo"].ToString(),                                                                 //Codigo del item de la lista de materiales
                                                                                       drMaterial["IteNombre"].ToString(),                                                                //Nombre del item de la lista de materiales
                                                                                       drMaterial["IteUndInventario"].ToString(),                                                    //Unidad de inventario del item de la lista de materiales
                                                                                       drMaterial["DetTieLote"].ToString(),                                                               //Determina si el item esta gestionado por lotes
                                                                                       drMaterial["BodCodigo"].ToString(),                                                               //Bodega por defecto del item de la lista de materiales
                                                                                       decimal.Parse(drMaterial["DetCantPlan"].ToString()),                                  //Cantidad planificada del item de la lista de materiales
                                                                                       decimal.Parse(drMaterial["DetCantReal"].ToString()),                                  //Cantidad real del item de la lista de materiales
                                                                                       varSaldo,                                                                                                               //Stock de almacen
                                                                                       varSaldo - decimal.Parse(drMaterial["DetCantReal"].ToString()),
                                                                                       varEstCodigo);                                                                                                    //Estado del material

                                    
                                    //Verificamos si no existe la salida de mercancia vincualda a este documento
                                    if (int.Parse(drFormulacion["DetNumeroSAPSalida"].ToString()).Equals(0) && objDtVerificarSalMercanciaSAP.Rows.Count.Equals(0)) {
                                        string varIteCodProducir = drFormulacion["IteCodigo"].ToString();
                                        string varIteNomProducir = drFormulacion["IteNombre"].ToString();
                                        string varIteCodigo = drMaterial["IteCodigo"].ToString();
                                        string varBodCodigo = drMaterial["BodCodigo"].ToString();
                                        decimal varSalInicial = clsInvItem.funRecSaldo(varIteCodigo, varBodCodigo);
                                        decimal varCantidad = decimal.Parse(drMaterial["DetCantReal"].ToString());

                                        //Instanciamos el objeto para obtener los datos de stock de movimientos
                                        DataRow[] dtConsultaStock;

                                        dtConsultaStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> {2}", varIteCodigo, varBodCodigo, varDetSecItemProducir));
                                        if (dtConsultaStock.Length.Equals(0))
                                            //Si no existe datos insertamos los datos de la secuecia con el saldo inicial
                                            this.proDisponibilidadStock(1, varIteCodigo, varBodCodigo, varDetSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                                        else
                                            //Si existe datos insertamos solo los datos de la secuencia
                                            this.proDisponibilidadStock(2, varIteCodigo, varBodCodigo, varDetSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                                    }
                                }
                            }
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) this.btnGrabar.Enabled = false;
                        break;
                }
                //Verificamos los acceso del usuario al formulario
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                DataRow[] dtValidaciones = dtItemsProducir.Select("IteCodigo = ''");
                foreach (DataRow drValidaciones in dtValidaciones) drValidaciones.Delete();
                this.dtItemsProducir.AcceptChanges();

                dtValidaciones = dtItemsProducir.Select("DetCantidad = 0");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de cantidad favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                dtValidaciones = dtItemsProducir.Select("DetLote = '' and DetTieLote = 'Y'");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El item {0}-{1} requiere numero de lote", dtValidaciones[0].ItemArray[1], dtValidaciones[0].ItemArray[2]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                dtValidaciones = dtItemsProducir.Select("DetLote <> '' and DetTieLote = 'N'");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El item {0}-{1} no requiere numero de lote", dtValidaciones[0].ItemArray[1], dtValidaciones[0].ItemArray[2]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                dtValidaciones = dtMateriales.Select("DetStock - DetComprometido < 0");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El material {0}-{1} en la bodega {2} tiene stock negativo", dtValidaciones[0].ItemArray[2], dtValidaciones[0].ItemArray[3], dtValidaciones[0].ItemArray[6]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                
                dtValidaciones = dtMateriales.Select("DetCantReal = 0");
                if (dtValidaciones.Length > 0) { XtraMessageBox.Show(string.Format("El material {0}-{1} del nro {2} de la tabla item a actualizar costo tiene cant real en cero", dtValidaciones[0].ItemArray[2], dtValidaciones[0].ItemArray[3], dtValidaciones[0].ItemArray[0]), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                var csRegistro = new clsCosActCstProductos()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    DocNombre = this.txtNomSerie.Text,
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    CabFecha = (DateTime)this.datFecha.EditValue,
                    BodCodigo = this.lueBodega.EditValue.ToString(),
                    CabDescripcion = this.txtNombre.Text,
                    CabComentario = this.memObsDocumento.Text,
                    CabComenDiario = this.memObsDiario.Text,
                    EstCodigo = "Nor",
                    DetActCstFormulacion = this.dtItemsProducir,
                    DetActCstMaterial = this.dtMateriales
                };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Procedimiento y funciones del formulario
        private void proDtActCstProducto() {
            dtItemsProducir = new DataTable { TableName = "ItemsProducir" };
            dtItemsProducir.Columns.Add("DetSecuencia", typeof(int));
            dtItemsProducir.Columns.Add("IteCodigo", typeof(string));
            dtItemsProducir.Columns.Add("IteNombre", typeof(string));
            dtItemsProducir.Columns.Add("IteUndInventario", typeof(string));
            dtItemsProducir.Columns.Add("CabFormula", typeof(int));
            dtItemsProducir.Columns.Add("CabVariante", typeof(string));
            dtItemsProducir.Columns.Add("DetCantidad", typeof(decimal));
            dtItemsProducir.Columns.Add("DetLote", typeof(string));
            dtItemsProducir.Columns.Add("DetTieLote", typeof(string));
            dtItemsProducir.Columns.Add("DetSaco", typeof(int));
            dtItemsProducir.Columns.Add("ItePsoStd", typeof(decimal));
            dtItemsProducir.Columns.Add("DetCosto", typeof(decimal));
            dtItemsProducir.Columns.Add("DetSAPSalida", typeof(int));
            dtItemsProducir.Columns.Add("DetSAPEntrada", typeof(int));
            dtItemsProducir.Columns.Add("DetSAPDiario", typeof(int));
            dtItemsProducir.Columns.Add("EstCodigo", typeof(string));
            this.grcListado.DataSource = dtItemsProducir;

            dtMateriales = new DataTable { TableName = "Materiales" };
            dtMateriales.Columns.Add("DetSecItemProducir", typeof(int));
            dtMateriales.Columns.Add("DetSecuencia", typeof(int));
            dtMateriales.Columns.Add("IteCodigo", typeof(string));
            dtMateriales.Columns.Add("IteNombre", typeof(string));
            dtMateriales.Columns.Add("IteUndInventario", typeof(string));
            dtMateriales.Columns.Add("DetTieLote", typeof(string));
            dtMateriales.Columns.Add("BodCodigo", typeof(string));
            dtMateriales.Columns.Add("DetCantPlan", typeof(decimal));
            dtMateriales.Columns.Add("DetCantReal", typeof(decimal));
            dtMateriales.Columns.Add("DetStock", typeof(decimal));
            dtMateriales.Columns.Add("DetComprometido", typeof(decimal));
            dtMateriales.Columns.Add("EstCodigo", typeof(string));
            this.grcMateriales.DataSource = dtMateriales;

            dtStockMovimientos = new DataTable { TableName = "StockMovimientos" };
            dtStockMovimientos.Columns.Add("IteCodMaterial", typeof(string));
            dtStockMovimientos.Columns.Add("BodCodMaterial", typeof(string));
            dtStockMovimientos.Columns.Add("DetSecuencia", typeof(int));
            dtStockMovimientos.Columns.Add("IteCodigo", typeof(string));
            dtStockMovimientos.Columns.Add("IteNombre", typeof(string));
            dtStockMovimientos.Columns.Add("DetCantidad", typeof(decimal));
            this.gluDetStock.DataSource = dtStockMovimientos;
            
        }
        private void proCargarMateriales(int varDetSecItemProducir, string varIteCodProducir, string varIteNomProducir,  int varCabFormula, decimal varDetCantItemProducir)
        {
            try
            {
                foreach (DataRow drRecMaterial in clsProFormulacion.funListarMaterial(varCabFormula).Rows)
                {
                    //Variables para el procedimiento
                    decimal varDetCantidad = decimal.Parse(drRecMaterial["DetCantidad"].ToString());
                    decimal varDetCantidadPor = decimal.Parse(drRecMaterial["DetCantidadPor"].ToString());
                    decimal varCantidad = decimal.Round((varDetCantItemProducir * varDetCantidad) / varDetCantidadPor,4);
                    decimal varSalInicial = 0;
                    string varBodega = "";
                    string varIteTieLote = "";

                    DataRow[] dtConsultaStock;

                    int varCuantos = dtMateriales.Select(string.Format("DetSecItemProducir = {0} and IteCodigo = '{1}'", varDetSecItemProducir, drRecMaterial["IteCodigo"].ToString())).Length;
                    if (varCuantos.Equals(0))
                    {
                        //Recupero la ultima secuencia ingresada en el detalle de materiales
                        int varSecuencia = this.dtMateriales.Rows.Count.Equals(0) ? 0 : int.Parse(this.dtMateriales.Compute("Max(DetSecuencia)", "").ToString());
                        //Recuperar informacion sobre le stock y la  bodega predeterminada del item
                        DataTable dtRecStock = clsInvItem.funRecStock(drRecMaterial["IteCodigo"].ToString());
                        if (dtRecStock.Rows.Count > 0)
                        {
                            varBodega = dtRecStock.Rows[0]["WhsCode"].ToString();
                            varSalInicial = decimal.Parse(dtRecStock.Rows[0]["OnHand"].ToString());
                        }

                        List<clsInvItem> dtTieLote = clsInvItem.funListar(drRecMaterial["IteCodigo"].ToString());
                        if (dtTieLote.Count > 0) varIteTieLote = dtTieLote[0].ManBtchNum;
                            
                        this.dtMateriales.Rows.Add(varDetSecItemProducir,                                               //Secuencia del item a producir
                                                                            ++varSecuencia,                                                           //Secuencia de la lista de materiales
                                                                            drRecMaterial["IteCodigo"].ToString(),                   //Codigo del item de la lista de materiales
                                                                            drRecMaterial["IteNombre"].ToString(),                  //Nombre del item de la lista de materiales
                                                                            drRecMaterial["IteUndInventario"].ToString(),      //Unidad de inventario del item de la lista de materiales
                                                                            varIteTieLote,                                                               //Determina si el item esta gestionado por lotes
                                                                            varBodega,                                                                    //Bodega por defecto del item de la lista de materiales
                                                                            varCantidad,                                                                 //Cantidad planificada del item de la lista de materiales
                                                                            varCantidad,                                                                 //Cantidad real del item de la lista de materiales
                                                                            varSalInicial,                                                                 //Stock de almacen
                                                                            0,
                                                                            "Nor");                                                                          //Estado del material

                        dtConsultaStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> {2}", drRecMaterial["IteCodigo"].ToString(), varBodega, varDetSecItemProducir));
                        if (dtConsultaStock.Length.Equals(0))
                            //Si no existe datos insertamos los datos de la secuecia con el saldo inicial
                            this.proDisponibilidadStock(1, drRecMaterial["IteCodigo"].ToString(), varBodega, varDetSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                        else
                            //Si existe datos insertamos solo los datos de la secuencia
                            this.proDisponibilidadStock(2, drRecMaterial["IteCodigo"].ToString(), varBodega, varDetSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                    }
                    else
                    {
                        DataRow drMaterial = dtMateriales.Select(string.Format("DetSecItemProducir = {0} and IteCodigo = '{1}'", varDetSecItemProducir, drRecMaterial["IteCodigo"].ToString()))[0];
                        string varBodCodMaterial = drMaterial["BodCodigo"].ToString();
                        
                        drMaterial["DetCantPlan"] = varCantidad;
                        drMaterial["DetCantReal"] = varCantidad;
                        drMaterial.AcceptChanges();

                        this.proDisponibilidadStock(5, drRecMaterial["IteCodigo"].ToString(), varBodCodMaterial, varDetSecItemProducir, "", "", 0, varCantidad);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proDisponibilidadStock(int varOpcion, string varIteCodMaterial, string varBodCodMaterial, int varSecItemProducir, string varIteCodProducir, string varIteNomProducir, decimal varSalInicial, decimal varCantidad)
        {
            try
            {
                switch (varOpcion)
                {
                    case 1:
                     
                            this.dtStockMovimientos.Rows.Add(varIteCodMaterial,          //Item de la lista de materiales
                                                                                              varBodCodMaterial,        //Bodega por defecto del item de la lista de materiales
                                                                                              0,                                         //Secuencia del item a producir
                                                                                              "",                                       //Codigo del item a producir
                                                                                              "Saldo inicial",                  //Nombre del item a producir
                                                                                              varSalInicial);                    //Cantidad del item e la lista de materiales
                        this.dtStockMovimientos.Rows.Add(varIteCodMaterial,              //Item de la lista de materiales
                                                                                           varBodCodMaterial,           //Bodega por defecto del item de la lista de materiales
                                                                                            varSecItemProducir,          //Secuencia del item a producir
                                                                                            varIteCodProducir,            //Codigo del item a producir
                                                                                            varIteNomProducir,           //Nombre del item a producir
                                                                                            varCantidad * -1);              //Cantidad del item e la lista de materiales
                        break;
                    case 2: //Solo insertamos los datos de la secuencia sin saldo inicial
                        this.dtStockMovimientos.Rows.Add(varIteCodMaterial,              //Item de la lista de materiales
                                                                                        varBodCodMaterial,              //Bodega por defecto del item de la lista de materiales
                                                                                        varSecItemProducir,              //Secuencia del item a producir
                                                                                        varIteCodProducir,                //Codigo del item a producir
                                                                                        varIteNomProducir,               //Nombre del item a producir
                                                                                        varCantidad * -1);                  //Cantidad del item e la lista de materiales
                        break;
                    case 3: //Eliminar todo de la tabla Stock Movimiento segun el item y la bodega
                        foreach (DataRow drStock in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodCodMaterial)))
                            drStock.Delete();
                        break;
                    case 4: //Eliminamos solo una fila debido a q ese item tambien esta en otra secuencia con la bodega actual
                        foreach (DataRow drStock in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia = {2}", varIteCodMaterial, varBodCodMaterial, varSecItemProducir)))
                            drStock.Delete();
                        break;
                    case 5:
                        foreach (DataRow drStock in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia = {2}", varIteCodMaterial, varBodCodMaterial, varSecItemProducir))) {
                            drStock["DetCantidad"] = varCantidad * -1;
                            drStock.AcceptChanges();
                        }
                        break;
                    default:
                        break;
                }
                if (this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> 0", varIteCodMaterial, varBodCodMaterial, varSecItemProducir)).Length > 0)
                {
                    decimal varSaldo = decimal.Parse(this.dtStockMovimientos.Compute("Sum(DetCantidad)", string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> 0", varIteCodMaterial, varBodCodMaterial, varSecItemProducir)).ToString());
                    foreach (DataRow drSaldo in this.dtMateriales.Select(string.Format("IteCodigo = '{0}' and BodCodigo = '{1}'", varIteCodMaterial, varBodCodMaterial)))
                        drSaldo["DetComprometido"] = varSaldo * -1;
                    this.dtMateriales.AcceptChanges();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos del formulario
        private void gluItem_Leave(object sender, EventArgs e)
        {
            try
            {
                string varIteCodigo = (sender as GridLookUpEdit).Text;
                if (varIteCodigo.Equals("")) return;
                if (varOldIteCodigo == varIteCodigo) return;

                List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);

                int varFila = this.grvListado.FocusedRowHandle;
                if (!lisItem.Equals(null))
                {
                    foreach (var regItem in lisItem)
                    {
                        this.grvListado.SetRowCellValue(varFila, colIteCodigo, regItem.ItemCode);
                        this.grvListado.SetRowCellValue(varFila, colIteNombre, regItem.ItemName);
                        this.grvListado.SetRowCellValue(varFila, colIteUndInventario, regItem.InvntryUom);
                        this.grvListado.SetRowCellValue(varFila, colDetTieLote, regItem.ManBtchNum);
                        this.grvListado.SetRowCellValue(varFila, colItePsoStd, regItem.SWeight1);
                        //Recupero las variantes de formula q tiene el item seleccionado
                        DataTable dtVariantes =  clsProFormulacion.funListarVariante(regItem.ItemCode);
                        if (dtVariantes.Rows.Count > 0) {
                            this.iluVariante.DataSource = dtVariantes;
                            this.grvListado.SetRowCellValue(varFila, colCabFormula, int.Parse(dtVariantes.Rows[0]["CabCodigo"].ToString()));
                            this.grvListado.SetRowCellValue(varFila, colCabVariante, dtVariantes.Rows[0]["CabVariante"]);
                            this.grvListado.SetRowCellValue(varFila, colDetCantidad, 0);
                            this.grvListado.SetRowCellValue(varFila, colDetSaco, 0);
                            this.grvListado.SetRowCellValue(varFila, colDetLote, "");

                            //Eliminamos los registros de materiales vinculados a la secuencia modificada del item
                            foreach (DataRow objDrMaterial in this.dtMateriales.Select(string.Format("DetSecItemProducir = {0}", int.Parse(this.grvListado.GetRowCellValue(varFila, colDetSecuencia).ToString()))))
                                objDrMaterial.Delete();

                            this.dtMateriales.AcceptChanges();
                        }
                        else {
                            this.grvListado.SetRowCellValue(varFila, colCabFormula, 0);
                            this.grvListado.SetRowCellValue(varFila, colCabVariante, "");
                        }
                    }
                }
                else
                {
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, "");
                    this.grvListado.SetRowCellValue(varFila, colDetTieLote, "");
                    this.grvListado.SetRowCellValue(varFila, colItePsoStd, 0);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluItem_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void iluVariante_EditValueChanged(object sender, EventArgs e)
        {
            try {
                DataRow drFila = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                if (drFila == null) return;

                int varSecItemProducir =  int.Parse(drFila["DetSecuencia"].ToString());
                drFila["CabFormula"] = ((System.Data.DataRowView)(((LookUpEdit)sender).EditValue)).Row.ItemArray[0].ToString();
                drFila["CabVariante"] = ((System.Data.DataRowView)(((LookUpEdit)sender).EditValue)).Row.ItemArray[3].ToString();
                drFila["DetCantidad"] = 0;
                drFila.AcceptChanges();

                //Programacion utilizada en caso de que cambie de variante y ya exista informacion en la tabla de stock en movimientos
                foreach (DataRow drMaterial in this.dtMateriales.Select(string.Format("DetSecItemProducir = {0}", varSecItemProducir)))
                {
                    string varIteCodMaterial = drMaterial["IteCodigo"].ToString();
                    string varBodCodMaterial = drMaterial["BodCodigo"].ToString();
                    
                    int varCuantos = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodCodMaterial)).Length;
                    if (varCuantos <= 2)
                        foreach (DataRow drStockEliminar in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodCodMaterial)))
                            drStockEliminar.Delete();
                    else
                        foreach (DataRow drStockEliminar in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia", varIteCodMaterial, varBodCodMaterial, varSecItemProducir)))
                            drStockEliminar.Delete();

                    drMaterial.Delete();
                }
                this.dtMateriales.AcceptChanges();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void itxDecimalesCuatro_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.grvListado.FocusedColumn == colDetCantidad)
                {
                    DataRow drFila = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                    if (drFila == null) return;
                    string varIteUndInventario = drFila["IteUndInventario"].ToString();
                    decimal varCantidad = decimal.Parse(((TextEdit)sender).Text);
                    decimal varItePsoStd = decimal.Parse(drFila["ItePsoStd"].ToString());

                    //Validamos que exista una modificacion entra la cantidad ingresada y la antigua
                    if (varOldCantidad.Equals(varCantidad)) return;

                    if (varIteUndInventario.ToLower().Equals("kilo")) drFila["DetSaco"] = Math.Truncate(varCantidad / varItePsoStd);

                    proCargarMateriales(int.Parse(drFila["DetSecuencia"].ToString()),   //Nro de secuencia del item a producir
                                                         drFila["IteCodigo"].ToString(),                            //Codigo del item a producir
                                                         drFila["IteNombre"].ToString(),                           //Nombre del item a producir
                                                         int.Parse(drFila["CabFormula"].ToString()),      //Codigo de la formula del item a producir
                                                         varCantidad);                                                          //Cantidad a producir
                    drFila.AcceptChanges();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void iluBodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow drFilaProducir = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                if (drFilaProducir == null) return;

                DataRow drFilaMaterial = ((System.Data.DataRowView)(this.grvMateriales.GetFocusedRow())).Row;
                if (drFilaMaterial == null) return;

                int varSecItemProducir = int.Parse(drFilaMaterial["DetSecItemProducir"].ToString());
                string varIteCodMaterial = drFilaMaterial["IteCodigo"].ToString();
                string varBodCodMaterial = drFilaMaterial["BodCodigo"].ToString();
                string varIteCodProducir = drFilaProducir["IteCodigo"].ToString();
                string varIteNomProducir = drFilaProducir["IteNombre"].ToString();
                string varBodega =		((LookUpEdit)sender).EditValue.ToString();
                decimal varSalInicial = clsInvItem.funRecSaldo(varIteCodMaterial, varBodega);
                decimal varCantidad = decimal.Parse(drFilaMaterial["DetCantReal"].ToString());
                DataRow[] dtConsultaStock;
                drFilaMaterial["BodCodigo"] = varBodega;
                drFilaMaterial["DetStock"] = varSalInicial;
                drFilaMaterial.AcceptChanges();

                dtConsultaStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> {2}", varIteCodMaterial, varBodCodMaterial, varSecItemProducir));
                //Preguntamos si la tabla de Stock Movimientos tiene un registro se debera borrar los datos de esa bodega hasta el saldo inicial
                if (dtConsultaStock.Length.Equals(1)) {
                    //Eliminamos los datos de la anterior bodega 
                    this.proDisponibilidadStock(3, varIteCodMaterial, varBodCodMaterial, 0, "", "", 0, 0);
                    dtConsultaStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia <> {2}", varIteCodMaterial, varBodega, varSecItemProducir));
                    if (dtConsultaStock.Length.Equals(0))
                        //Si no existe datos insertamos los datos de la secuecia con el saldo inicial
                       this.proDisponibilidadStock(1, varIteCodMaterial, varBodega, varSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                    else
                        //Si existe datos insertamos solo los datos de la secuencia
                        this.proDisponibilidadStock(2, varIteCodMaterial, varBodega, varSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                }
                else {
                    //Eliminamos los datos de la anterior bodega pero solo de esa secuencia 
                    this.proDisponibilidadStock(4, varIteCodMaterial, varBodCodMaterial, varSecItemProducir, "", "", 0, 0);
                    //Verificamos si no existe datos para la nueva bodega
                    dtConsultaStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodega));
                    if (dtConsultaStock.Length.Equals(0))
                        //Si no existe datos insertamos los datos de la secuecia con el saldo inicial
                        this.proDisponibilidadStock(1, varIteCodMaterial, varBodega, varSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                    else
                        //Si existe datos insertamos solo los datos de la secuencia
                        this.proDisponibilidadStock(2, varIteCodMaterial, varBodega, varSecItemProducir, varIteCodProducir, varIteNomProducir, varSalInicial, varCantidad);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void itxDecimalesCuatroM_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.grvMateriales.FocusedColumn == colDetCantReal)
                {
                    DataRow drFila = ((System.Data.DataRowView)(this.grvMateriales.GetFocusedRow())).Row;
                    if (drFila == null) return;
                    string varIteCodMaterial = drFila["IteCodigo"].ToString();
                    string varBodCodMaterial = drFila["BodCodigo"].ToString();

                    int varSecItemProducir = int.Parse(drFila["DetSecItemProducir"].ToString());
                    decimal varCantidad = decimal.Parse(((TextEdit)sender).Text);

                    //Actualizamos la cantidad de la tabla Stock Movimientos
                     this.proDisponibilidadStock(5, varIteCodMaterial, varBodCodMaterial, varSecItemProducir, "", "", 0, varCantidad);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void xfrmCosManActCstProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter)) {
                    if (!grvListado.IsFocusedView) return;
                    if (!(grvListado.FocusedColumn.Equals(colDetLote) || grvListado.FocusedColumn.Equals(colDetCantidad))) return;
                    if (grvListado.RowCount.Equals(0)) return;

                    grvListado.FocusedRowHandle = grvListado.RowCount - 1;
                    grvListado.FocusedColumn = grvListado.Columns["DetSAPSalida"];

                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1)) {
                        int varPosicion = this.grvListado.FocusedRowHandle;
                        int varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetSecuencia).ToString()) + 1;

                        string varIteCodigo = this.grvListado.GetRowCellValue(varPosicion, colIteCodigo).ToString();
                        string varTieLote = this.grvListado.GetRowCellValue(varPosicion, colDetTieLote).ToString();
                        string varDetLote = this.grvListado.GetRowCellValue(varPosicion, colDetLote).ToString();

                        decimal varCantidad = decimal.Parse(this.grvListado.GetRowCellValue(varPosicion, colDetCantidad).ToString());

                        if (varIteCodigo.Equals("")) { this.grvListado.SetColumnError(colIteCodigo, "Debe ingresar el codigo del item"); return; }
                        if (varCantidad.Equals(0)) { this.grvListado.SetColumnError(colDetCantidad, "La cantidad debe ser mayor a cero"); return; }
                        if (varTieLote.Equals("Y") && varDetLote.Equals("")) { this.grvListado.SetColumnError(colDetLote, "Debe ingresar el nro de lote"); return; }

                        this.dtItemsProducir.Rows.Add(varLinea,                 //Secuencia de la tabla item a producir
                                                                                 "",                            //Codigo del item a producir
                                                                                 "",                            //Nombre del item a producir
                                                                                 "",                            //Abreviatura del item a producir
                                                                                 0,                              //Codigo de la formula
                                                                                 "",                            //Variante de la formula
                                                                                 0,                              //Cantidad 
                                                                                 "",                            //Codigo del lote
                                                                                 "",                            //Determina si el item es gestionado por lote
                                                                                 0,                              //Numero de sacos
                                                                                 0,                              //Peso standar del item
                                                                                 0,                              //Costo del item a producir
                                                                                 0,                              //Codigo de salida de SAP
                                                                                 0,                              //Codigo de entrada de SAP
                                                                                 0,                              //Codigo de diario de SAP
                                                                                 "Nor");                    //Estado de la secuencia


                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        this.grvListado.FocusedColumn = colIteCodigo;
                    }
                }
                //Condicion que utilizamos para actualizar los datos
                else if (e.KeyCode.Equals(Keys.F5)) {
                    //Actualizacion de saldos iniciales de los items de la tabla stock movimientos
                    foreach (DataRow drFila in dtStockMovimientos.Select("DetSecuencia = 0")){
                        string varIteCodMaterial = drFila["IteCodMaterial"].ToString();
                        string varBodCodMaterial = drFila["BodCodMaterial"].ToString();
                        decimal varSaldo = clsInvItem.funRecSaldo(varIteCodMaterial, varBodCodMaterial);
                        drFila["DetCantidad"] = varSaldo;

                        //Actualizamos en el campo de stock de la tabla materiales
                        foreach (DataRow drMaterial in dtMateriales.Select(string.Format("IteCodigo = '{0}' and BodCodigo = '{1}'", varIteCodMaterial, varBodCodMaterial)))
                            drMaterial["DetStock"] = varSaldo;
                        this.dtMateriales.AcceptChanges();
                    }
                    this.dtStockMovimientos.AcceptChanges();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (this.grvListado.RowCount > 0 && grvListado.GetFocusedRow() != null && this.grvListado.FocusedRowHandle >= 0)
                {
                    DataRow drFila = this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle);
                    this.grvMateriales.ActiveFilterString = string.Format("DetSecItemProducir = {0}", int.Parse(drFila["DetSecuencia"].ToString()));
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvMateriales_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.grvMateriales.FocusedColumn != colDetBodStock) return;

                if (this.grvMateriales.RowCount > 0 && grvMateriales.GetFocusedRow() != null && this.grvMateriales.FocusedRowHandle >= 0)
                {
                    DataRow drFila = this.grvMateriales.GetDataRow(this.grvMateriales.FocusedRowHandle);
                    string varEstCodigo = drFila["EstCodigo"].ToString();

                    if (varEstCodigo.Equals("Sap")) this.colDetBodStock.OptionsColumn.ReadOnly = true;
                    else {
                        this.colDetBodStock.OptionsColumn.ReadOnly = false;
                        this.grvDetStock.ViewCaption = drFila["IteCodigo"].ToString() + " - " + drFila["IteNombre"].ToString();
                        DataTable dtStock = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", drFila["IteCodigo"].ToString(), drFila["BodCodigo"].ToString())).CopyToDataTable();
                        dtStock.DefaultView.Sort = "DetSecuencia asc";
                        this.gluDetStock.DataSource = dtStock;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void smiBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grvListado.IsFocusedView)
                {
                    DataRow drFila = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                    int varSecItemProducir = int.Parse(drFila["DetSecuencia"].ToString());
                    int varSAPSalida = int.Parse(drFila["DetSAPSalida"].ToString());
                    string varEstCodigo = drFila["EstCodigo"].ToString();

                    string varDocNombre = this.txtNomSerie.Text;
                    int varCabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(txtNumero.Text);

                    //Validamos si existe el numero de salida de SAP si la afirmacion es positiva no se puede borrar la linea
                    if (varEstCodigo.Equals("Sap") || !varSAPSalida.Equals(0) || clsCosActCstProductos.funVerificarSalMercanciaSAP(varDocNombre, varCabNumero, varSecItemProducir).Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("No se puede borrar el registro nro. '{0}', el mismo ha sido enviado a SAP", varSecItemProducir), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        drFila["EstCodigo"] = "Sap";
                        drFila.AcceptChanges();
                        return;
                    }

                    this.dtItemsProducir.Rows.Remove(drFila);
                    this.dtItemsProducir.AcceptChanges();

                    //Programacion utilizada en caso de que cambie de variante y ya exista informacion en la tabla de stock en movimientos
                    foreach (DataRow drMaterial in this.dtMateriales.Select(string.Format("DetSecItemProducir = {0}", varSecItemProducir)))
                    {
                        string varIteCodMaterial = drMaterial["IteCodigo"].ToString();
                        string varBodCodMaterial = drMaterial["BodCodigo"].ToString();

                        int varCuantos = this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodCodMaterial)).Length;
                        if (varCuantos <= 2)
                            foreach (DataRow drStockEliminar in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}'", varIteCodMaterial, varBodCodMaterial)))
                                drStockEliminar.Delete();
                        else
                            foreach (DataRow drStockEliminar in this.dtStockMovimientos.Select(string.Format("IteCodMaterial = '{0}' and BodCodMaterial = '{1}' and DetSecuencia = {2}", varIteCodMaterial, varBodCodMaterial, varSecItemProducir)))
                                drStockEliminar.Delete();

                        drMaterial.Delete();
                    }
                    this.dtMateriales.AcceptChanges();
                    
                    //Validamos si en el detalle de items a producir no existe filas creamos una  nueva
                    if (this.grvListado.RowCount.Equals(0))
                        this.dtItemsProducir.Rows.Add(1,                         //Secuencia de la tabla item a producir
                                                                            "",                            //Codigo del item a producir
                                                                            "",                            //Nombre del item a producir
                                                                            "",                            //Abreviatura del item a producir
                                                                            0,                              //Codigo de la formula
                                                                            "",                            //Variante de la formula
                                                                            0,                              //Cantidad 
                                                                            "",                            //Codigo del lote
                                                                            "",                            //Determina si el item es gestionado por lote
                                                                            0,                              //Numero de sacos
                                                                            0,                              //Peso estandar del item
                                                                            0,                              //Costo del item a producir
                                                                            0,                             //Codigo de salida de SAP
                                                                            0,                             //Codigo de entrada de SAP
                                                                            0,                             //Codigo de diario de SAP
                                                                            "Nor");                   //Estado de la secuencia

                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                //Verificamos que la fila seleccionada no haya sido enviada al SAP
                string varEstCodigo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colEstCodigo).ToString();

                //Recuperamos los valores antiguos para cuando haya una modificacion
                if (this.grvListado.FocusedColumn.Equals(colIteCodigo))
                    varOldIteCodigo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colIteCodigo).ToString();
                if (this.grvListado.FocusedColumn.Equals(colDetCantidad))
                    varOldCantidad = decimal.Parse(this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colDetCantidad).ToString());

                //En caso de que haya sido enviada a sap bloqueamos las columnas para cualquier edicion
                if (varEstCodigo.Equals("Sap")) {
                    this.colIteCodigo.OptionsColumn.ReadOnly = true;
                    this.colDetOpcion.OptionsColumn.ReadOnly = true;
                    this.colDetCantidad.OptionsColumn.ReadOnly = true;
                    this.colDetLote.OptionsColumn.ReadOnly = true;
                    this.colDetSaco.OptionsColumn.ReadOnly = true;
                }
                else {
                    this.colIteCodigo.OptionsColumn.ReadOnly = false;
                    this.colDetOpcion.OptionsColumn.ReadOnly = false; ;
                    this.colDetCantidad.OptionsColumn.ReadOnly = false;
                    this.colDetLote.OptionsColumn.ReadOnly = false;
                    this.colDetSaco.OptionsColumn.ReadOnly = false;

                    if (this.grvListado.FocusedColumn.Equals(colIteCodigo)) {
                        if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0)
                            this.gluItem.ImmediatePopup = true;
                        else
                            this.colIteCodigo.OptionsColumn.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
