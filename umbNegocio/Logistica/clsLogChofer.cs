using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class clsLogChofer
    {
        public int ChfCodigo { get; set; }
        public string ChfNombre { get; set; }
        public string ChfIdentificacion { get; set; }

        public static List<clsLogChofer> funListarSAP()
        {
            try
            {
                string varSql = "Select Code as ChfCodigo, Name as ChfNombre, U_ID_TRANSP as ChfIdentificacion From [@EXX_TRANSPORTISTAS] Order by Name";
                return funListarSqlSAP(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsLogChofer> funListarSAP(string varChfCodigo)
        {
            try
            {
                string varSql = string.Format("Select Code as ChfCodigo, Name as ChfNombre, U_ID_TRANSP as ChfIdentificacion From [@EXX_TRANSPORTISTAS] Where Code = '{0}' Order by Name ", varChfCodigo);
                return funListarSqlSAP(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsLogChofer> funListarSqlSAP(string varSql)
        {
            try
            {
                List<clsLogChofer> objLista = new List<clsLogChofer>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsLogChofer()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }
        public static clsLogChofer funRegistro(DataRow drRegistro, clsLogChofer objRegistro)
        {
            objRegistro.ChfCodigo = drRegistro["ChfCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["ChfCodigo"].ToString());
            objRegistro.ChfNombre = drRegistro["ChfNombre"] == System.DBNull.Value ? "" : drRegistro["ChfNombre"].ToString().ToUpper();
            objRegistro.ChfIdentificacion = drRegistro["ChfIdentificacion"] == System.DBNull.Value ? "" : drRegistro["ChfIdentificacion"].ToString();
            

            return objRegistro;
        }
    }
}
