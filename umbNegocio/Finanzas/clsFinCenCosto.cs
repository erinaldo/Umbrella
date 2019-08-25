using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Finanzas
{
    public class clsFinCenCosto
    {
        public string CcoCodigo {get; set;}
        public string CcoNombre { get; set; }

        public static List<clsFinCenCosto> funListar()
        {
            try
            {
                const string varSql = "Select a.PrcCode, a.PrcName From OPRC a Where a.Active = 'Y' and DimCode = 3 and a.Locked = 'N' ";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsFinCenCosto> funListar(string varCcoCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.PrcCode, a.PrcName From OPRC a Where a.Active = 'Y' and DimCode = 3 and a.Locked = 'N' And a.PrcCode = '{0}'", varCcoCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsFinCenCosto> funListarSql(string varSql)
        {
            try
            {
                List<clsFinCenCosto> objLista = new List<clsFinCenCosto>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsFinCenCosto()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static clsFinCenCosto funRegistro(DataRow drRegistro, clsFinCenCosto objRegistro)
        {
            objRegistro.CcoCodigo = drRegistro["PrcCode"] == System.DBNull.Value ? "" : drRegistro["PrcCode"].ToString();
            objRegistro.CcoNombre = drRegistro["PrcName"] == System.DBNull.Value ? "" : drRegistro["PrcName"].ToString();

            return objRegistro;
        }
        //Recuperamos los centros de costo  de la lista
        public static DataTable funListar(string[] ListaCenCosto)
        {
            StringBuilder strCenCosto = new StringBuilder("''");
            foreach (string thisItem in ListaCenCosto)
                strCenCosto.AppendFormat(", '{0}'", thisItem.Replace("'", "").Trim());
            
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTableSql(
                string.Format("Select PrcCode, PrcName From OPRC With(NoLock) Where PrcCode IN ({0}) Order by PrcCode", strCenCosto.ToString()));
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
    }
}
