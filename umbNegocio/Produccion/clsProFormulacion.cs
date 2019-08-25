using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Produccion
{
    public class clsProFormulacion
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int PrsCodigo { get; set; }
        
        public string DocNombre { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string CabArea { get; set; }
        public string CabVariante { get; set; }
        public string CabObservacion { get; set; }
        public string EstCodigo { get; set; }

        public bool CabProfundizar { get; set; }
        public bool CabRendimiento { get; set; }
        
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }
        
        public DataTable DetMaterial { get; set; }
        public DataTable DetRuta { get; set; }
        public DataTable DetMerma { get; set; }

        public static List<clsProFormulacion> funListar(string varWhere)
        {
            try
            {
                string varSql = string.Format("Select CabCodigo, a.DocCodigo, b.DocNombre, CabNumero, IteCodigo, Upper(IteNombre) as IteNombre, CabArea, CabVariante, CabProfundizar, CabRendimiento, IsNull(PrsCodigo, 0) as PrsCodigo,  CabObservacion, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From PRO_CABFORMULACION a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo {0}  Order by IteCodigo, CabVariante  ", varWhere);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsProFormulacion> funListarSql(string varSql)
        {
            try
            {
                List<clsProFormulacion> objLista = new List<clsProFormulacion>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsProFormulacion()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }

        public static clsProFormulacion funRegistro(DataRow drRegistro, clsProFormulacion objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.IteCodigo = drRegistro["IteCodigo"] == System.DBNull.Value ? "" : drRegistro["IteCodigo"].ToString();
            objRegistro.IteNombre = drRegistro["IteNombre"] == System.DBNull.Value ? "" : drRegistro["IteNombre"].ToString();
            objRegistro.CabArea = drRegistro["CabArea"] == System.DBNull.Value ? "" : drRegistro["CabArea"].ToString();
            objRegistro.CabVariante = drRegistro["CabVariante"] == System.DBNull.Value ? "" : drRegistro["CabVariante"].ToString();
            objRegistro.CabProfundizar = (bool)drRegistro["CabProfundizar"];
            objRegistro.CabRendimiento = (bool)drRegistro["CabRendimiento"];
            objRegistro.PrsCodigo = drRegistro["PrsCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["PrsCodigo"].ToString());
            objRegistro.CabObservacion = drRegistro["CabObservacion"] == System.DBNull.Value ? "" : drRegistro["CabObservacion"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsProFormulacion csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proPro_Formulacion", csRegistro.CabCodigo, csRegistro.DocCodigo, csRegistro.CabNumero, csRegistro.IteCodigo, csRegistro.IteNombre, csRegistro.CabArea, csRegistro.CabVariante, csRegistro.CabProfundizar, csRegistro.CabRendimiento, csRegistro.PrsCodigo, csRegistro.CabObservacion, csRegistro.EstCodigo, varOperacion, clsVariablesGlobales.varCodUsuario, csRegistro.DetMaterial, csRegistro.DetRuta, csRegistro.DetMerma);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }

        public static DataTable funListarMaterial(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetLinea, CabVariante, IteCodigo, Upper(IteNombre) as IteNombre, IteUndInventario, DetCantidad, DetCantidadPor, IsNull(DetPorcentaje, 0) as DetPorcentaje, IsNull(DetTipo, '') as DetTipo, IsNull(DetLineaRuta, 0) as DetLineaRuta " +
                                                                                                                                                                 "From PRO_DETFORMATERIAL " +
                                                                                                                                                                 "Where CabCodigo = {0}", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funListarRuta(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetLinea, CabVariante, OprCodigo, Upper(IsNull(OprNombre,'')) as OprNombre, a.RecCodigo, Upper(b.RecNombre) as RecNombre, DetTiempo,  " + 
                                                                                                                                                                "DetTiempoPor, IsNull(b.RecManObra, 0) as RecManObra, IsNull(b.RecGstFabricacion, 0) as RecGstFabricacion " + 
                                                                                                                                                                "From PRO_DETFORRUTA a inner join PRO_RECURSO b on a.RecCodigo = b.RecCodigo " + 
                                                                                                                                                                 "Where a.CabCodigo = {0}", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funListarMerma(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetLinea, CabVariante, a.MerCodigo, b.MerNombre, DetPorcentaje, DetTipo " +
                                                                                                                                                                 "From PRO_DETFORMERMA a inner join PRO_MERMA b on a.MerCodigo = b.MerCodigo " +
                                                                                                                                                                 "Where CabCodigo = {0}", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funListarVariante(string varIteCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.CabCodigo, a.IteCodigo, a.IteNombre,  a.CabVariante, a.CabProfundizar, a.PrsCodigo  From PRO_CABFORMULACION a Where a.IteCodigo = '{0}'", varIteCodigo));
            csAccesoDatos.proFinalizarSesion();
            return dtLista;
        }
        public static DataTable funRecForVariante(string varIteCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select b.Codigo " + 
                                                                                                                                                            "From PRO_CABFORMULACION a right join GEN_DICCIONARIO b on a.CabVariante = b.Codigo and a.IteCodigo = '{0}' " + 
                                                                                                                                                            "Where b.Tipo = 'PROFORVARIANTE' and a.CabCodigo is null  " , varIteCodigo));
            csAccesoDatos.proFinalizarSesion();
            return dtLista;
        }
    }

    
}
