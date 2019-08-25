using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Costos
{
    public class clsCosComCarnica
    {
        public int CabCodigo { get; set; }

        public DateTime CabFecDesde { get; set; }
        public DateTime CabFecHasta { get; set; }

        public string IteCodDesde { get; set; }
        public string IteNomDesde { get; set; }
        public string IteCodHasta { get; set; }
        public string IteNomHasta { get; set; }
        public string CabBodega { get; set; }
        public string CabDescripcion { get; set; }
        public string EstCodigo { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public DataTable DetComCarnica { get; set; }

        public static List<clsCosComCarnica> funListar()
        {
            try
            {
                const string varSql = "Select CabCodigo, CabFecDesde, CabFecHasta, IteCodDesde, IteNomDesde, IteCodHasta, IteNomHasta, CabBodega, CabDescripcion, EstCodigo, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From COS_CABCOMCARNICA Order By CabFecDesde";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsCosComCarnica> funListar(int varCabCodigo)
        {
            try
            {
                string varSql = string.Format("Select CabCodigo, CabFecDesde, CabFecHasta, IteCodDesde, IteNomDesde, IteCodHasta, IteNomHasta, CabBodega, CabDescripcion, EstCodigo, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From COS_CABCOMCARNICA  Where CabCodigo = {0}", varCabCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsCosComCarnica> funListarSql(string varSql)
        {
            try
            {
                List<clsCosComCarnica> objLista = new List<clsCosComCarnica>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsCosComCarnica()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }

        public static clsCosComCarnica funRegistro(DataRow drRegistro, clsCosComCarnica objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());

            objRegistro.CabFecDesde = (DateTime)drRegistro["CabFecDesde"];
            objRegistro.CabFecHasta = (DateTime)drRegistro["CabFecHasta"];

            objRegistro.IteCodDesde = drRegistro["IteCodDesde"] == System.DBNull.Value ? "" : drRegistro["IteCodDesde"].ToString();
            objRegistro.IteNomDesde = drRegistro["IteNomDesde"] == System.DBNull.Value ? "" : drRegistro["IteNomDesde"].ToString();
            objRegistro.IteCodHasta = drRegistro["IteCodHasta"] == System.DBNull.Value ? "" : drRegistro["IteCodHasta"].ToString();
            objRegistro.IteNomHasta = drRegistro["IteNomHasta"] == System.DBNull.Value ? "" : drRegistro["IteNomHasta"].ToString();
            objRegistro.CabBodega = drRegistro["CabBodega"] == System.DBNull.Value ? "" : drRegistro["CabBodega"].ToString();
            objRegistro.CabDescripcion = drRegistro["CabDescripcion"] == System.DBNull.Value ? "" : drRegistro["CabDescripcion"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public static DataTable funExtCstCarnico(DateTime varFecDesde, DateTime varFecHasta, string varIteDesde, string varIteHasta, string varBodega)
        {
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            DataTable dtTable = csAccesoDatos.GDatos.funTraerDataTable("PACOScomprasmpcarnica", varFecDesde, varFecHasta, varIteDesde, varIteHasta, varBodega);
            csAccesoDatos.proFinalizarSesion();
            return dtTable;
        }
        public static DataTable funRecDetComCarnica(int varCabCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            try
            {

                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecuencia, IteCodigo, IteNombre, DetCantidad, DetValor, DetCosto From COS_DETCOMCARNICA " +
                                                                                                                                                    "Where CabCodigo = {0}", varCabCodigo));
                
                return dtLista;
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesion(); }
        }

        public int funMantenimiento(clsCosComCarnica csRegistro, int varOperacion)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            try
            {
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCos_ComCarnica", csRegistro.CabCodigo, csRegistro.CabFecDesde, csRegistro.CabFecHasta, csRegistro.IteCodDesde,
                                                                                                                                                                  csRegistro.IteNomDesde, csRegistro.IteCodHasta, csRegistro.IteNomHasta, csRegistro.CabBodega,
                                                                                                                                                                  csRegistro.CabDescripcion, csRegistro.EstCodigo, varOperacion, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                  csRegistro.DetComCarnica);
                return varCodigo;
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesion(); }
        }
    }
}
