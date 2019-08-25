using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Finanzas
{
    public class clsFinProyecto
    {
        public string PryCodigo { get; set; }
        public string PryNombre { get; set; }

        public static List<clsFinProyecto> funListar()
        {
            try
            {
                const string varSql = "Select PrjCode, PrjName From OPRJ Where Active = 'Y' and U_beas_status is null";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsFinProyecto> funListar(string varPryCodigo)
        {
            try
            {
                string varSql = string.Format("Select PrjCode, PrjName From OPRJ Where Active = 'Y' and U_beas_status is null and PrjCode = '{0}'", varPryCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsFinProyecto> funListarSql(string varSql)
        {
            try
            {
                List<clsFinProyecto> objLista = new List<clsFinProyecto>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsFinProyecto()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static clsFinProyecto funRegistro(DataRow drRegistro, clsFinProyecto objRegistro)
        {
            objRegistro.PryCodigo = drRegistro["PrjCode"] == System.DBNull.Value ? "" : drRegistro["PrjCode"].ToString();
            objRegistro.PryNombre = drRegistro["PrjName"] == System.DBNull.Value ? "" : drRegistro["PrjName"].ToString();

            return objRegistro;
        }
        public static DataTable funListar(string[] ListaProyecto)
        {
            StringBuilder strProyecto = new StringBuilder("''");
            foreach (string thisItem in ListaProyecto)
                strProyecto.AppendFormat(", '{0}'", thisItem.Replace("'", "").Trim());

            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTableSql(
                string.Format("Select PrjCode, PrjName From OPRJ With(NoLock) Where PrjCode IN ({0}) Order by PrjCode", strProyecto.ToString()));
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
    }
}
