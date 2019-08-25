using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.General
{
    public class clsGenBodega
    {
        public string WhsCode { get; set; }
        public string WhsName { get; set; }

        public static List<clsGenBodega> funListar()
        {
            try
            {
                const string varSql = "Select WhsCode, WhsName From OWHS a ";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsGenBodega> funListar(string varBodega)
        {
            try
            {
                string varSql = string.Format("Select WhsCode, WhsName From OWHS a Where a.WhsCode = '{0}' ", varBodega);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsGenBodega> funListarSql(string varSql)
        {
            try
            {
                List<clsGenBodega> objLista = new List<clsGenBodega>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsGenBodega()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static clsGenBodega funRegistro(DataRow drLista, clsGenBodega objRegistro)
        {
            objRegistro.WhsCode = drLista["WhsCode"].ToString();
            objRegistro.WhsName = drLista["WhsName"].ToString();

            return objRegistro;
        }
        //Funcion utilizada para saber que bodegas de SAP tiene acceso el usuario
        public static DataTable funRecUsuarioBodega(string varUsuCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtBodega = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select WhsCode, WhsName  " + 
                                                                                                                                                                      "From OWHS " + 
                                                                                                                                                                      "Where (Select USERID From OUSR Where USER_CODE = '{0}' ) in (Select * From dbo.fun_string_to_array(U_ita_responsable,',')) " + 
                                                                                                                                                                      "Order by WhsCode ", varUsuCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtBodega;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Recuperamos las bodegas de la lista
        public static DataTable funListar(string[] ListaBodegas)
        {
            StringBuilder strBodegas = new StringBuilder("''");
            foreach (string thisItem in ListaBodegas)
            {
                strBodegas.AppendFormat(", '{0}'", thisItem.Replace("'", "").Trim());
            }
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTableSql(
                string.Format("SELECT WhsCode, WhsName FROM OWHS WITH(NOLOCK) WHERE WhsCode IN ({0}) ORDER BY WhsCode", strBodegas.ToString()));
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
    }
}
