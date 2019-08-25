using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using umbNegocio.Seguridad;

namespace umbNegocio.Granja
{
    public class clsGraEntCompra
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int CabEntrySap { get; set; }
        public int CabNumSap { get; set; }

        public DateTime CabFecha { get; set; }
        
        public string DocNombre { get; set; }
        public string PrvCodigo { get; set; }
        public string PrvNombre { get; set; }
        public string BodCodigo { get; set; }
        public string CabImportacion { get; set; }
        public string CabComentario { get; set; }
        public string EstCodigo { get; set; }

        public decimal CabSubtotal { get; set; }
        public decimal CabIva { get; set; }
        public decimal CabTotal { get; set; }
        
        public DataTable DetEntMercancia { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        //Funcion utilizada para recuperar las entradas de mercancias por compras
        public static List<clsGraEntCompra> funListar(string varWhere)
        {
            try {
                string varSql = string.Format("Select a.CabCodigo, a.DocCodigo, a.CabNumero, b.DocNombre, CabDocEntrySAPEntrada, CabNumeroSAPEntrada, CabFecha, PrvCodigo, " +
                                                               "PrvNombre, BodCodigo, CabImportacion, CabComentario, CabSubtotal, CabIva, CabTotal, EstCodigo, a.UsuCrea, " +
                                                               "a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica " +
                                                               "From GRA_CABENTMERCOMPRA a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo  {0}", varWhere);
                return funListarSql(varSql); 
            }
            catch (Exception) { throw; }
        }
        private static List<clsGraEntCompra> funListarSql(string varSql)
        {
            try
            {
                List<clsGraEntCompra> objLista = new List<clsGraEntCompra>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsGraEntCompra()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para asignar los valores recuperados de la consulta a las propiedades de las clases
        private static clsGraEntCompra funRegistro(DataRow drRegistro, clsGraEntCompra objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabEntrySap = drRegistro["CabDocEntrySAPEntrada"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabDocEntrySAPEntrada"].ToString());
            objRegistro.CabNumSap = drRegistro["CabNumeroSAPEntrada"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumeroSAPEntrada"].ToString());
            
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.PrvCodigo = drRegistro["PrvCodigo"] == System.DBNull.Value ? "" : drRegistro["PrvCodigo"].ToString();
            objRegistro.PrvNombre = drRegistro["PrvNombre"] == System.DBNull.Value ? "" : drRegistro["PrvNombre"].ToString();
            objRegistro.BodCodigo = drRegistro["BodCodigo"] == System.DBNull.Value ? "" : drRegistro["BodCodigo"].ToString();
            objRegistro.CabImportacion = drRegistro["CabImportacion"] == System.DBNull.Value ? "" : drRegistro["CabImportacion"].ToString();
            objRegistro.CabComentario = drRegistro["CabComentario"] == System.DBNull.Value ? "" : drRegistro["CabComentario"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.CabSubtotal = drRegistro["CabSubtotal"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabSubtotal"].ToString());
            objRegistro.CabIva = drRegistro["CabIva"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabIva"].ToString());
            objRegistro.CabTotal = drRegistro["CabTotal"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotal"].ToString());

            objRegistro.UsuCrea = drRegistro["UsuCrea"] == null ? "" : drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drRegistro["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuCrea = drRegistro["UsuModifica"] == null ? "" : drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drRegistro["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        //Funcion utilizada para recuperar el detalle de la orden de compra seleccionada
        public static DataTable funRecDetOrdCompraSAP(string varDocEntry)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select Isnull(a.U_num_importacion, '') as U_num_importacion, b.WhsCode, b.ItemCode, b.Dscription, c.InvntryUom, b.Quantity, Case when (isnull(b.U_ita_ped_pza, 0) = 0) then Case when lower(c.InvntryUom) = 'kilo' then Case when c.SWeight1 > 0 then round(b.Quantity / c.SWeight1, 0) else  0 end else 0 end else b.U_ita_ped_pza end as Pieza, b.Price, b.DiscPrcnt, b.LineTotal, a.ObjType, a.DocEntry, a.DocNum, b.LineNum, c.ManBtchNum, c.TaxCodeAP, c.SWeight1 " +
                                                                                                                                                                 "From OPOR a inner join POR1 b on a.DocEntry = b.DocEntry " +
			                                                                                                                                                     "                         inner join OITM c on b.ItemCode = c.ItemCode " +
                                                                                                                                                                 "Where b.LineStatus = 'O' And a.DocEntry in ({0})", varDocEntry));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        //Procedimiento almacenado utilizado para grabar las entradas de mercancia por compras
        public int funMantenimiento(clsGraEntCompra csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_EntMerCompraMantenimiento", csRegistro.CabCodigo, csRegistro.DocCodigo, csRegistro.CabNumero, csRegistro.CabEntrySap, csRegistro.CabNumSap,
                                                                                                                                                                        csRegistro.CabFecha, csRegistro.PrvCodigo, csRegistro.PrvNombre, csRegistro.BodCodigo, csRegistro.CabImportacion,
                                                                                                                                                                        csRegistro.CabComentario, csRegistro.CabSubtotal, csRegistro.CabIva, csRegistro.CabTotal, csRegistro.EstCodigo, varOperacion,
                                                                                                                                                                        clsVariablesGlobales.varCodUsuario, csRegistro.DetEntMercancia);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para recuperar los detalles de la entrada de mercancia
        public static DataTable funRecDetEntMercancia(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecuencia, DetFecha, IteCodigo, IteNombre, DetTieLote, IteUndInventario, IteIvaCompra, DetChapeta, " + 
                                                                                                                                                    "DetLote, DetPieza, DetCantidad, DetPeso, DetCosto, DetDsto, DetTotal, DecObjType, DecDocEntry, DecDocNum, " + 
                                                                                                                                                    "DecLineNum, EstCodigo, ItePsoStandar " + 
                                                                                                                                                    "From GRA_DETENTMERCOMPRA " + 
                                                                                                                                                    "Where CabCodigo = {0} " +
                                                                                                                                                    "Order by DetSecuencia ", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para verificar si el documento de entrada de mercancias OPDN ya fue ingresada a SAP
        public static DataTable funVerificarEntMercanciaSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtSalida = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OPDN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtSalida;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para enviar el documentos al sistema SAP
        public string funEnviarDocumentoSAP(clsGraEntCompra objRegistro, int varCabNumero)
        {
            try
            {
                string mError = "";
                int iError = 0;
                int i = 0;

                csAccesoDatos.proIniciarSesionSAP();
                //Declaramos la variables para obtener la informacion que vamos a utilizar
                int varCabCodigo = objRegistro.CabCodigo; //Codigo key del documento
                int varDocCodigo = objRegistro.DocCodigo; //Codigo del documento
                string varDocNombre = objRegistro.DocNombre; //Descripcion del documento
                string varCabComentario = objRegistro.CabComentario; //Comentario para el documento
                string varBodCodigo = objRegistro.BodCodigo; //Bodega donde se va ingresar el inventario
                //Recuperamos informacion con respecto a la entrada de mercancias OPDN enviada a SAP
                DataTable dtEntMercanciaSAP = funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                //Verificamos si existe una entrada de mercancias OPDN en SAP
                if (!dtEntMercanciaSAP.Rows.Count.Equals(0))
                {
                    //Actualizamos el documento de entrada de mercancia con la informacion de SAP del objeto OPDN
                    int varDocEntrySAPEntrada = int.Parse(dtEntMercanciaSAP.Rows[0]["DocEntry"].ToString());
                    int varDocNumSAPEntrada = int.Parse(dtEntMercanciaSAP.Rows[0]["DocNum"].ToString());
                    proActSAPEntMercancia(varDocEntrySAPEntrada, varDocNumSAPEntrada, varCabCodigo);

                    mError = "";
                }
                else
                {
                    //Recuperamos la informacion de los detalles de la entrada de mercancia 
                   DataTable dtDetEntMercancia = clsGraEntCompra.funRecDetEntMercancia(varCabCodigo);
                    //Instanciamos en la variable varOPDN el objeto de SAP entrada de mercancias
                    SAPbobsCOM.Documents varOPDN = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes);
                    //Cargamos informacion de la cabecera de la entrada de mercancias
                    varOPDN.Series = clsSegDocumento.funRecNumSerieSAPEntrada(varDocCodigo);
                    varOPDN.CardCode = objRegistro.PrvCodigo;
                    varOPDN.CardName = objRegistro.PrvNombre;
                    varOPDN.DocDate = (DateTime)objRegistro.CabFecha;
                    varOPDN.DocDueDate = (DateTime)objRegistro.CabFecha;
                    varOPDN.TaxDate = (DateTime)objRegistro.CabFecha;
                    varOPDN.Comments = objRegistro.CabComentario;
                    varOPDN.JournalMemo = varDocNombre + "-" + varCabNumero + "-" + objRegistro.CabComentario.Substring(0, objRegistro.CabComentario.Length > 20 ? 20 : objRegistro.CabComentario.Length);
                    varOPDN.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items;
                    varOPDN.UserFields.Fields.Item("U_num_importacion").Value = objRegistro.CabImportacion;
                    varOPDN.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                    varOPDN.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    varOPDN.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;
                    varOPDN.UserFields.Fields.Item("U_Ita_sysdocumento").Value = objRegistro.DocNombre;
                    varOPDN.UserFields.Fields.Item("U_Ita_sysnumero").Value = varCabNumero.ToString();

                    foreach (DataRow drEntMercancia in dtDetEntMercancia.Rows)
                    {
                        string varIteCodigo = drEntMercancia["IteCodigo"].ToString();  //Variable utilizada para el codigo del item
                        string varIteNombre = drEntMercancia["IteNombre"].ToString();  //Variable utilizada para el nombre del item
                        string varIteTieLote = drEntMercancia["DetTieLote"].ToString();  //Variable utilizada para determinar si el item esta gestionado por lote
                        string varIteIVACompra = drEntMercancia["IteIvaCompra"].ToString(); //Variable utilizada para el IVA de compra del item
                        string varDetChapeta = drEntMercancia["DetChapeta"].ToString(); //Variable utilizada para la chapeta
                        string varDetLote = drEntMercancia["DetLote"].ToString(); //Variable utilizada para el lote
                        double varDetCantidad =double.Parse(drEntMercancia["DetCantidad"].ToString()); //Variable utilizada para la cantidad a ingresar 
                        double varDetCosto = double.Parse(drEntMercancia["DetCosto"].ToString()); //Variable utilizada para el costo del item
                        double varDetDsto = double.Parse(drEntMercancia["DetDsto"].ToString()); //Variable utilizada para el descuento del item
                        double varDetPeso = double.Parse(drEntMercancia["DetPeso"].ToString()); //Variable utilizada para el descuento del item
                        int varDetPiezas = int.Parse(drEntMercancia["DetPieza"].ToString()); //Variable utilizada para el peso en caso de ser animal
                        int varBaseType = int.Parse(drEntMercancia["DecObjType"].ToString()) == 0 ? -1 : int.Parse(drEntMercancia["DecObjType"].ToString()); //Variable utilizada para la base del objeto "Orden de compra"
                        int varBaseEntry = int.Parse(drEntMercancia["DecDocEntry"].ToString()) ; //Variable utilizada para el codigo del documento BaseEntry
                        int varBaseLine = int.Parse(drEntMercancia["DecLineNum"].ToString()); //Variable utilizada para la linea del documento BaseLine

                        if (i > 0) varOPDN.Lines.Add();
                        varOPDN.Lines.SetCurrentLine(i); //Nos posicionamos en la linea recien creada
                        varOPDN.Lines.WarehouseCode = varBodCodigo; //Codigo de la bodega donde va a ingresar el item
                        varOPDN.Lines.ItemCode = varIteCodigo; //Codigo del item a ingresar
                        varOPDN.Lines.ItemDescription = varIteNombre; //Descripcion del item a ingresar
                        varOPDN.Lines.Quantity = varDetCantidad; //Cantidad a ingresar
                        varOPDN.Lines.UnitPrice = varDetCosto; //Costo del item a ingresar
                        varOPDN.Lines.DiscountPercent = varDetDsto; //Descuento para el item
                        varOPDN.Lines.TaxCode = varIteIVACompra; //IVA de compra del item
                        varOPDN.Lines.UserFields.Fields.Item("U_ita_ped_pza").Value = varDetPiezas; //Numero de piezas del item
                        varOPDN.Lines.BaseType = varBaseType; //Objeto base en caso de que este vinculado a una orden de compra
                        if (varBaseType != -1) varOPDN.Lines.BaseEntry = varBaseEntry; //Doc Entry en caso de que este vinculado a una orden de compra
                        if (varBaseType != -1) varOPDN.Lines.BaseLine = varBaseLine;//Line Num en caso de que este vinculado a una orden de compra
                        if (varDocNombre.Substring(4, 1).Equals("A")) varOPDN.Lines.UserFields.Fields.Item("U_Ita_arete").Value = varDetChapeta; //En caso de ser ingreso de animales ingresamos el codigo de la chapeta
                        if (varDocNombre.Substring(4, 1).Equals("A")) varOPDN.Lines.UserFields.Fields.Item("U_ita_pes_bas").Value = varDetPeso; //En caso de ser ingreso de animales ingresamos el codigo de la chapeta
                        //Verificamos si el item esta gestionado por lotes
                        if (varIteTieLote.Equals("Y"))
                        {
                            varOPDN.Lines.BatchNumbers.SetCurrentLine(0);
                            //Verificamos si el item a ingresar es un animal
                            if (varDocNombre.Substring(4, 1).Equals("A")) 
                                varOPDN.Lines.BatchNumbers.BatchNumber = varDetChapeta;
                            else
                                varOPDN.Lines.BatchNumbers.BatchNumber = varDetLote;
                            varOPDN.Lines.BatchNumbers.AddmisionDate = (DateTime)objRegistro.CabFecha;
                            varOPDN.Lines.BatchNumbers.Quantity = varDetCantidad;
                        }
                        i++;
                    }
                    iError = varOPDN.Add();
                    if (!iError.Equals(0)) {
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                        return mError;
                    }
                    else {
                        int varDocEntrySAPEntrada = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPEntrada);
                        varOPDN.GetByKey(varDocEntrySAPEntrada);
                        int varDocNumSAPEntrada = varOPDN.DocNum;

                        //Actualizamos el documento de entrada de mercancia con la informacion de SAP del objeto OPDN
                        proActSAPEntMercancia(varDocEntrySAPEntrada, varDocNumSAPEntrada, varCabCodigo);
                    }
                }
                return mError;
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        //Procedimiento utilizado para actualizar la informacion de SAP en la entrada de mercancia OPDN
        public static void proActSAPEntMercancia(int varDocEntrySAP, int varDocNumSAP, int varCabCodigo)
        {
            try
            {
                //Actualizamos la entrada de mercancias granja con el numero de SAP y el estado cambiamos a SAP
                string varSql = string.Format("Update GRA_CABENTMERCOMPRA Set CabDocEntrySAPEntrada = {0}, CabNumeroSAPEntrada = {1}, EstCodigo = 'Sap' Where CabCodigo = {2}", varDocEntrySAP, varDocNumSAP, varCabCodigo); ;
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(varSql);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Procedimiento almacenado utilizado para anular las actualizaciones de costo de productos
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_EntMerCompraAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
