using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Inventario
{
    public class clsInvItem
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItmsGrpCod { get; set; }
        public string ItmsGrpNam { get; set; }
        public string PrchseItem { get; set; }
        public string BuyUnitMsr { get; set; }
        public string InvntItem { get; set; }
        public string InvntryUom { get; set; }
        public string SellItem { get; set; }
        public string SalUnitMsr { get; set; }
        public string ManBtchNum { get; set; }
        
        public int ItemCodLinea { get; set; }
        public string ItemNamLinea { get; set; }
        public int ItemCodFamilia { get; set; }
        public string ItemNamFamilia { get; set; }
        public int ItemCodClase { get; set; }
        public string ItemNamClase { get; set; }
        
        public decimal AvgPrice { get; set; }
        public decimal AvgMO { get; set; }
        public decimal AvgMOProyec { get; set; }
        public decimal AvgCIF { get; set; }
        public decimal AvgCIFProyec { get; set; }
        public decimal AvgReferencial { get; set; }
        public decimal AvgReferencialProyec { get; set; }
        public decimal AvgTotalmenteVariable { get; set; }
        public decimal GstOperacional { get; set; }
        public decimal GstOperacionalProyec { get; set; }
        public decimal MemMatPrima { get; set; }
        public decimal MemInsPrimario { get; set; }
        public decimal MemInsSecundario { get; set; }

        public decimal SWeight1 { get; set; }
        public string SWW { get; set; }
        public string TaxCodeAP { get; set; }
        public string TipoHojaCst { get; set; }
        public string GstCarnicoHojaCst { get; set; }
        public int OrdenHojaCst { get; set; }

        public static List<clsInvItem> funListar()
        {
            try
            {
                const string varSql = "Select	a.ItemCode, a.ItemName, a.ItmsGrpCod, b.ItmsGrpNam, a.PrchseItem, IsNull(a.BuyUnitMsr, '') as BuyUnitMsr, a.InvntItem, IsNull(a.InvntryUom,'') as InvntryUom, a.SellItem, IsNull(a.SalUnitMsr, '') as SalUnitMsr, " +
                                                      "            a.ManBtchNum, IsNull(a.U_Ita_linea,0) as ItemCodLinea, IsNull(c.Name, '') as ItemNamLinea, IsNull(a.U_Ita_familia,0) as ItemCodFamilia, IsNull(d.Name,'') as ItemNamFamilia, " +
                                                      "            IsNull(a.U_Ita_clase,0) as ItemCodClase, IsNull(e.Code, '') as ItemNamClase, a.AvgPrice, IsNull(a.U_Ita_cstMO,0) as AvgMO,  IsNull(a.U_Ita_cstMOProyec,0) as AvgMOProyec,  " +
                                                      "            IsNull(a.U_Ita_cstCIF,0) as AvgCIF,  IsNull(a.U_Ita_cstCIFProyec,0) as AvgCIFProyec,  IsNull(a.U_Ita_cstReferencial,0) as AvgReferencial,  IsNull(a.U_Ita_cstRefeProyec,0) as AvgReferencialProyec, " +
                                                      "            IsNull(a.U_Ita_ctv,0) as AvgTotalmenteVariable,  IsNull(a.U_Ita_gstOperacional,0) as GstOperacional,  IsNull(a.U_Ita_gstOperProyec,0) as GstOperacionalProyec, " +
                                                      "            IsNull(a.U_Ita_memMatPrima,0) as MemMatPrima,  IsNull(a.U_Ita_memInsPrimario,0) as MemInsPrimario,  IsNull(a.U_Ita_memInsSecunda,0) as MemInsSecundario, " +
                                                      "            IsNull(a.SWeight1,0) as SWeight1,  IsNull(a.SWW,'') as SWW, IsNull(TaxCodeAP, '') as TaxCodeAP, Isnull(b.U_ita_tipHojCst,'') as TipoHojaCst, Isnull(b.U_Ita_orden, 0) as OrdenHojaCst, Isnull(b.U_ita_gstCarnico, 'N') as GstCarnicoHojaCst  " +
                                                      "From OITM a	inner join OITB b on a.ItmsGrpCod = b.ItmsGrpCod " +
                                                      "                            left join [@ITA_LINEA] c on a.U_Ita_linea = c.Code " +
                                                      "                            left join [@ITA_FAMILIA] d on a.U_Ita_familia = d.Code " +
                                                      "                            left join [@ITA_CLASE] e on a.U_Ita_clase = e.Code " +
                                                      "Where a.frozenFor = 'N' ";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsInvItem> funListar(string varItem)
        {
            try
            {
                string varSql = string.Format("Select	a.ItemCode, a.ItemName, a.ItmsGrpCod, b.ItmsGrpNam, a.PrchseItem, IsNull(a.BuyUnitMsr, '') as BuyUnitMsr, a.InvntItem, IsNull(a.InvntryUom,'') as InvntryUom, a.SellItem, IsNull(a.SalUnitMsr, '') as SalUnitMsr, " +
                                                                    "            a.ManBtchNum, IsNull(a.U_Ita_linea,0) as ItemCodLinea, IsNull(c.Name, '') as ItemNamLinea, IsNull(a.U_Ita_familia,0) as ItemCodFamilia, IsNull(d.Name,'') as ItemNamFamilia, " +
                                                                    "            IsNull(a.U_Ita_clase,0) as ItemCodClase, IsNull(e.Code, '') as ItemNamClase, a.AvgPrice, IsNull(a.U_Ita_cstMO,0) as AvgMO,  IsNull(a.U_Ita_cstMOProyec,0) as AvgMOProyec,  " +
                                                                    "            IsNull(a.U_Ita_cstCIF,0) as AvgCIF,  IsNull(a.U_Ita_cstCIFProyec,0) as AvgCIFProyec,  IsNull(a.U_Ita_cstReferencial,0) as AvgReferencial,  IsNull(a.U_Ita_cstRefeProyec,0) as AvgReferencialProyec, " +
                                                                    "            IsNull(a.U_Ita_ctv,0) as AvgTotalmenteVariable,  IsNull(a.U_Ita_gstOperacional,0) as GstOperacional,  IsNull(a.U_Ita_gstOperProyec,0) as GstOperacionalProyec, " +
                                                                    "            IsNull(a.U_Ita_memMatPrima,0) as MemMatPrima,  IsNull(a.U_Ita_memInsPrimario,0) as MemInsPrimario,  IsNull(a.U_Ita_memInsSecunda,0) as MemInsSecundario, " +
                                                                    "            IsNull(a.SWeight1,0) as SWeight1,  IsNull(a.SWW,'') as SWW, IsNull(TaxCodeAP, '') as TaxCodeAP, Isnull(b.U_ita_tipHojCst,'') as TipoHojaCst, Isnull(b.U_Ita_orden, 0) as OrdenHojaCst, Isnull(b.U_ita_gstCarnico, 'N') as GstCarnicoHojaCst  " +
                                                                    "From OITM a	inner join OITB b on a.ItmsGrpCod = b.ItmsGrpCod " +
                                                                    "                            left join [@ITA_LINEA] c on a.U_Ita_linea = c.Code " +
                                                                    "                            left join [@ITA_FAMILIA] d on a.U_Ita_familia = d.Code " +
                                                                    "                            left join [@ITA_CLASE] e on a.U_Ita_clase = e.Code " +
                                                                    "Where a.frozenFor = 'N'  And a.ItemCode = '{0}'", varItem);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static  List<clsInvItem> funListarSql(string varSql)
        {
            try
            {
                List<clsInvItem> objLista = new List<clsInvItem>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsInvItem()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }

        private static clsInvItem funRegistro(DataRow drLista, clsInvItem objRegistro)
        {
            objRegistro.ItemCode = drLista["ItemCode"].ToString();
            objRegistro.ItemName = drLista["ItemName"].ToString();
            objRegistro.ItmsGrpCod = int.Parse(drLista["ItmsGrpCod"].ToString());
            objRegistro.ItmsGrpNam = drLista["ItmsGrpNam"].ToString();
            objRegistro.PrchseItem = drLista["PrchseItem"].ToString();
            objRegistro.BuyUnitMsr = drLista["BuyUnitMsr"].ToString();
            objRegistro.InvntItem = drLista["InvntItem"].ToString();
            objRegistro.InvntryUom = drLista["InvntryUom"].ToString();
            objRegistro.SellItem = drLista["SellItem"].ToString();
            objRegistro.SalUnitMsr = drLista["SalUnitMsr"].ToString();
            objRegistro.ManBtchNum = drLista["ManBtchNum"].ToString();

            objRegistro.ItemCodLinea = drLista["ItemCodLinea"].ToString().Equals("") ? 0: int.Parse(drLista["ItemCodLinea"].ToString());
            objRegistro.ItemNamLinea = drLista["ItemNamLinea"].ToString();
            objRegistro.ItemCodFamilia = drLista["ItemCodFamilia"].ToString().Equals("") ? 0 : int.Parse(drLista["ItemCodFamilia"].ToString());
            objRegistro.ItemNamFamilia = drLista["ItemNamFamilia"].ToString();
            objRegistro.ItemCodClase = drLista["ItemCodClase"].ToString().Equals("") ? 0 : int.Parse(drLista["ItemCodClase"].ToString());
            objRegistro.ItemNamClase = drLista["ItemNamClase"].ToString();

            objRegistro.AvgPrice = decimal.Parse(drLista["AvgPrice"].ToString());
            objRegistro.AvgMO = decimal.Parse(drLista["AvgMO"].ToString());
            objRegistro.AvgMOProyec = decimal.Parse(drLista["AvgMOProyec"].ToString());
            objRegistro.AvgCIF = decimal.Parse(drLista["AvgCIF"].ToString());
            objRegistro.AvgCIFProyec = decimal.Parse(drLista["AvgCIFProyec"].ToString());
            objRegistro.AvgReferencial = decimal.Parse(drLista["AvgReferencial"].ToString());
            objRegistro.AvgReferencialProyec = decimal.Parse(drLista["AvgReferencialProyec"].ToString());
            objRegistro.AvgTotalmenteVariable = decimal.Parse(drLista["AvgTotalmenteVariable"].ToString());
            objRegistro.GstOperacional = decimal.Parse(drLista["GstOperacional"].ToString());
            objRegistro.GstOperacionalProyec = decimal.Parse(drLista["GstOperacionalProyec"].ToString());
            objRegistro.MemMatPrima = decimal.Parse(drLista["MemMatPrima"].ToString());
            objRegistro.MemInsPrimario = decimal.Parse(drLista["MemInsPrimario"].ToString());
            objRegistro.MemInsSecundario = decimal.Parse(drLista["MemInsSecundario"].ToString());

            objRegistro.SWeight1 = decimal.Parse(drLista["SWeight1"].ToString());
            objRegistro.SWW = drLista["SWW"].ToString();
            objRegistro.TaxCodeAP = drLista["TaxCodeAP"].ToString();
            objRegistro.TipoHojaCst = drLista["TipoHojaCst"].ToString();
            objRegistro.GstCarnicoHojaCst = drLista["GstCarnicoHojaCst"].ToString();
            objRegistro.OrdenHojaCst = int.Parse(drLista["OrdenHojaCst"].ToString());

            return objRegistro;
        }
        public static decimal funPrecioItem(string varIteCodigo, int varPreCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            decimal varPrecio = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(Max(a.Price), 0) as Price From ITM1 a Where a.ItemCode = '{0}' and a.PriceList = {1}", varIteCodigo, varPreCodigo)).ToString());
            csAccesoDatos.proFinalizarSesion();
            return varPrecio;
        }

        public static string funRecTieLote(string varIteCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                string varTieLote = csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select  ManBtchNum as IteTieLote From OITM a Where a.ItemCode = '{0}'", varIteCodigo)).ToString();
                csAccesoDatos.proFinalizarSesion();
                return varTieLote;
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
        //Funcion utilizada para recuperar los lotes disponibles del item 
        public static DataTable funRecLote(string varIteCodigo, string varBodCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLote = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.ItemCode as IteCodigo, b.LocCode as BodCodigo, c.DistNumber as LotCodigo,  " + 
                                                                                                                                                                "c.InDate as FecCreacion, IsNull(c.ExpDate, c.InDate) as FecVencimiento, Sum(a.Quantity) as StkDisponible " + 
                                                                                                                                                                "From ITL1 a inner join OITL b on a.LogEntry = b.LogEntry " + 
                                                                                                                                                                "inner join OBTN c on a.ItemCode = c.ItemCode and a.SysNumber = c.SysNumber " + 
                                                                                                                                                                "Where a.ItemCode = '{0}' and b.LocCode = '{1}' " + 
                                                                                                                                                                "Group by a.ItemCode, c.DistNumber, b.LocCode, c.ExpDate, c.InDate " + 
                                                                                                                                                                "Having Sum(a.Quantity) > 0 " , varIteCodigo, varBodCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLote;
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
        public static DataTable funRecStock(string varIteCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            DataTable dtStock = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select b.WhsCode, b.OnHand From OITM a inner join OITW b on a.ItemCode = b.ItemCode and a.DfltWH = b.WhsCode Where a.ItemCode = '{0}' ", varIteCodigo));
            csAccesoDatos.proFinalizarSesion();
            return dtStock;
        }
        public static decimal funRecSaldo(string varIteCodigo, string varBodCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            decimal varSaldo = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select a.OnHand From OITW a Where a.ItemCode = '{0}' and a.WhsCode = '{1}'", varIteCodigo, varBodCodigo)).ToString());
            csAccesoDatos.proFinalizarSesion();
            return varSaldo;
        }
        //Funcion utilizada para recuperar el costo del item
        public static decimal funRecCosto(string varIteCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                decimal varCosto = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(AvgPrice, 0) as IteCosto From OITM Where ItemCode = '{0}'", varIteCodigo)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCosto;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Funcion utilizada para recuperar el codigo de la cuenta contable vinculada al item y movimiento
        public static string funRecCtaContable(string varIteCodigo, string varCodMovimiento)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                string res = "";
                DataTable tab = csAccesoDatos.GDatos.funTraerDataTable("PAUMBObtenerAcctCodeDeMovInventario", varIteCodigo, varCodMovimiento);
                csAccesoDatos.proFinalizarSesion();
                if (tab != null && tab.Rows.Count > 0)
                    res = tab.Rows[0][0].ToString();
                return res;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
