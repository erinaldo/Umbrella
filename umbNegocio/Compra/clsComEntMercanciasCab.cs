using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using umbDatos;
using umbNegocio.Seguridad;

namespace umbNegocio.Compra
{
    public class clsComEntMercanciasCab
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int CabEntrySap { get; set; }
        public int CabNumSap { get; set; }
        public int CabLstPrecio { get; set; }

        public DateTime CabFecha { get; set; }
        
        public string DocNombre { get; set; }
        public string PrvCodigo { get; set; }
        public string PrvNombre { get; set; }
        public string BodCodigo { get; set; }
        public string CabImportacion { get; set; }
        public string CabComentario { get; set; }
        public string CabLote { get; set; }
        public string CabTipCompra { get; set; }
        public string EstCodigo { get; set; }

        public decimal CabTotNeto { get; set; }
        public decimal CabTotCamal { get; set; }
        public decimal CabDiferencia { get; set; }
        public decimal CabTolerancia { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }



        //Funcion utilizada para recuperar las entradas de mercancias por compras listado
        public static List<clsComEntMercanciasCab> funListar(string varWhere)
        {
            try {
                List<clsComEntMercanciasCab> objLista = new List<clsComEntMercanciasCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_EntMercanciaListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsComEntMercanciasCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para recuperar las entradas de mercancias por documento
        public static List<clsComEntMercanciasCab> funListar(int vId)
        {
            try {
                List<clsComEntMercanciasCab> objLista = new List<clsComEntMercanciasCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_EntMercanciaListar", vId, DBNull.Value);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsComEntMercanciasCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para asignar los valores recuperados de la consulta a las propiedades de las clases
        private static clsComEntMercanciasCab funRegistro(DataRow drRegistro, clsComEntMercanciasCab objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabEntrySap = drRegistro["CabEntrySap"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabEntrySap"].ToString());
            objRegistro.CabNumSap = drRegistro["CabNumSap"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumSap"].ToString());
            objRegistro.CabLstPrecio = drRegistro["CabLstPrecio"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabLstPrecio"].ToString());

            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.PrvCodigo = drRegistro["PrvCodigo"] == System.DBNull.Value ? "" : drRegistro["PrvCodigo"].ToString();
            objRegistro.PrvNombre = drRegistro["PrvNombre"] == System.DBNull.Value ? "" : drRegistro["PrvNombre"].ToString();
            objRegistro.BodCodigo = drRegistro["BodCodigo"] == System.DBNull.Value ? "" : drRegistro["BodCodigo"].ToString();
            objRegistro.CabImportacion = drRegistro["CabImportacion"] == System.DBNull.Value ? "" : drRegistro["CabImportacion"].ToString();
            objRegistro.CabComentario = drRegistro["CabComentario"] == System.DBNull.Value ? "" : drRegistro["CabComentario"].ToString();
            objRegistro.CabLote = drRegistro["CabLote"] == System.DBNull.Value ? "" : drRegistro["CabLote"].ToString();
            objRegistro.CabTipCompra = drRegistro["CabTipCompra"] == System.DBNull.Value ? "" : drRegistro["CabTipCompra"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.CabTotNeto = drRegistro["CabTotNeto"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotNeto"].ToString());
            objRegistro.CabTotCamal = drRegistro["CabTotCamal"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotCamal"].ToString());
            objRegistro.CabDiferencia = drRegistro["CabDiferencia"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabDiferencia"].ToString());
            objRegistro.CabTolerancia = drRegistro["CabTolerancia"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTolerancia"].ToString());

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        // Funcion utilizada para recuperar el detalle de entrada de mercancias
        public static DataTable funRecDetEntMercancia(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecuencia, IteCodigo, IteNombre, IteUndInventario, DetCantBruta, DetTara, DetCantNeta, " + 
                                                                                                                                                    "DetLote, DetTieLote, DetAbreviatura, DetTolerancia, DetTotTara, DetUnidad, DetCantidad, DetCosto, " + 
                                                                                                                                                    "DetTotal " + 
                                                                                                                                                    "From COM_DETENTRADA a " + 
                                                                                                                                                    "Where a.CabCodigo = {0} " +
                                                                                                                                                    "Order  by IteCodigo", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        // Funcion utilizada para recuperar el resumen de detalles
        public static DataTable funRecDetLote(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("proCom_EntMercanciaListarLote", varCabCodigo);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        //Procedimiento almacenado utilizado para grabar las entradas de mercancia por compras
        public int funMantenimiento(int varOperacion, List<clsComEntMercanciasDet> objDetalles)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detEntMercancias = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCom_EntMercanciaMantenimiento",   CabCodigo, DocCodigo, CabNumero, CabEntrySap, CabNumSap, CabLstPrecio, 
                                                                                                                                                                                       CabFecha, PrvCodigo, PrvNombre, BodCodigo, CabImportacion, CabComentario,
                                                                                                                                                                                       CabLote, CabTipCompra, CabTotNeto, CabTotCamal, CabDiferencia, CabTolerancia, 
                                                                                                                                                                                       varOperacion, clsVariablesGlobales.varCodUsuario, detEntMercancias);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para verificar si el documento de entrada de mercancias ya fue ingresada a SAP
        public static DataTable funVerificarEntMercanciaSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtEntMercaderia = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OPDN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtEntMercaderia;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para enviar el documentos al sistema SAP
        public string funEnviarDocPreliminarSAP()
        {
            try
            {
                string mError = "";
                int iError = 0;
                int i = 0;

                csAccesoDatos.proIniciarSesionSAP();
                DataTable objDtVerificarSAP = funVerificarEntMercanciaSAP(DocNombre, CabNumero);
                if (objDtVerificarSAP.Rows.Count > 0) {
                    //Actualizacion en el formulario de movimientos de inventario
                    int DocEntrySAPEntrada = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                    int NumeroSAPEntrada = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                    csAccesoDatos.funIniciarSesion("conDBUmbrella");
                    csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update COM_CABENTRADA Set CabEntrySap = {0}, CabNumSap = {1}, EstCodigo = 'Sap' Where DocCodigo = {2} and CabNumero = {3}", DocEntrySAPEntrada, NumeroSAPEntrada, DocCodigo, CabNumero));
                    csAccesoDatos.proFinalizarSesion();
                    return mError;
                }
                else
                {
                    //Recuperamos la informacion del resumen de entrada de mercancias
                    List<clsComEntMercanciasRes> objResumen = new List<clsComEntMercanciasRes>();
                    clsComEntMercanciasRes.proListar(CabCodigo, out objResumen);
                    DataTable dtDetLote = clsComEntMercanciasCab.funRecDetLote(CabCodigo);

                    SAPbobsCOM.Documents varOPDN = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseDeliveryNotes);

                    varOPDN.Series = clsSegDocumento.funRecNumSerieSAPEntrada(DocCodigo); //Serie
                    varOPDN.CardCode =PrvCodigo; //Codigo del proveedor
                    varOPDN.CardName = PrvNombre; //Nombre
                    varOPDN.DocDate = (DateTime)CabFecha; //Fecha contabilizacion
                    varOPDN.DocDueDate = (DateTime)CabFecha; //Fecha vencimiento
                    varOPDN.TaxDate = (DateTime)CabFecha; //Fecha documento
                    varOPDN.Comments = CabComentario; //Comentario
                    varOPDN.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario 
                    varOPDN.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha de auditoria
                    varOPDN.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip de la maquina
                    varOPDN.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre; //Serie del documento umbrella
                    varOPDN.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString(); //Numero del documento umbrella
                    varOPDN.DocType = SAPbobsCOM.BoDocumentTypes.dDocument_Items;
                    //Detalle de la entrada de mercancia
                    foreach (clsComEntMercanciasRes objFilaResumen in objResumen) {
                        if (!i.Equals(0)) varOPDN.Lines.Add();
                        varOPDN.Lines.SetCurrentLine(i);
                        i++;
                        varOPDN.Lines.WarehouseCode = BodCodigo;
                        varOPDN.Lines.ItemCode = objFilaResumen.IteCodigo;
                        varOPDN.Lines.ItemDescription = objFilaResumen.IteNombre;
                        varOPDN.Lines.Quantity = double.Parse(objFilaResumen.DetCantidad.ToString());
                        varOPDN.Lines.Price = double.Parse(objFilaResumen.DetCosto.ToString());
                        varOPDN.Lines.UserFields.Fields.Item("U_ita_ped_pza").Value = objFilaResumen.DetUnidad;
                        int j = 0;

                        foreach (DataRow drLote in dtDetLote.Select(string.Format("IteCodigo = '{0}' And DetLote <> ''", objFilaResumen.IteCodigo))) {
                            if (!j.Equals(0)) varOPDN.Lines.BatchNumbers.Add();
                            varOPDN.Lines.BatchNumbers.BatchNumber = drLote["DetLote"].ToString();
                            varOPDN.Lines.BatchNumbers.Quantity = double.Parse(drLote["DetCantidad"].ToString());
                            j++;
                        }
                    }
                    iError = varOPDN.Add();
                    if (!iError.Equals(0)) {
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                        return mError;
                    }
                    else {
                        int varCabEntrySap = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varCabEntrySap);
                        varOPDN.GetByKey(varCabEntrySap);
                        int varCabNumSap = varOPDN.DocNum;

                        csAccesoDatos.funIniciarSesion("conDBUmbrella");
                        csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update COM_CABENTRADA Set  CabEntrySap = {0}, CabNumSap = {1}, EstCodigo = 'Sap' Where DocCodigo = {2} and CabNumero = {3}", varCabEntrySap, varCabNumSap, DocCodigo, CabNumero));
                        csAccesoDatos.proFinalizarSesion();
                    }
                    return mError;
                }
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Procedimiento utilizado para anular los registros de entrada de mercancia compra
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de entrada de mercancia interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proCom_EntMercanciaAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar el estado del documento
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de entrada de mercancia interno</param>
        public static void proActEstado(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proCom_EntMercanciaActEstado", varCabCodigo, "Sap", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public static DataTable funImprimirEtiqueta(string varCodProveedor, string varProveedor, DateTime varFecha, string varTotalNeto) {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtEtiqueta = csAccesoDatos.GDatos.funTraerDataTable("proCom_EntMercanciaImpresionEtiqueta", varCodProveedor, varProveedor, varFecha, varTotalNeto);
            csAccesoDatos.proFinalizarSesion();
            return dtEtiqueta;
        }

        public static DataTable funImprimirEtiquetaBPM(int varCodigo) {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtEtiqueta = csAccesoDatos.GDatos.funTraerDataTable("proBPM_CodigoBarrasImpresionEtiqueta", varCodigo);
            csAccesoDatos.proFinalizarSesion();
            return dtEtiqueta;
        }

        public static int funRecuperarCodigoBarra(string varDocNombre, int varCabNumero, string varIteCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select isnull(max(codigo), 0) From BPM_CODIGOBARRAS Where relacion = '{0}-{1}-{2}'", varDocNombre, varCabNumero, varIteCodigo));
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
