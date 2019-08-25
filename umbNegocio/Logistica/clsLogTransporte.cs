using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class clsLogTransporte
    {
        public int TrnCodigo { get; set; }
        public string TrnNombre { get; set; }
        public string TrnPlaca { get; set; }
        public string TrnTipo { get; set; }

        public static List<clsLogTransporte> funListarSAP()
        {
            try
            {
                string varSql = "Select Code as TrnCodigo, Name as TrnNombre, U_PLACA as TrnPlaca, (Case When U_TIPO_TRANSP = 'I' Then 'Interno' Else 'Externo' End) as TrnTipo From [@EXXIS_TRANSPORTE] Order by Name";
                return funListarSqlSAP(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsLogTransporte> funListarSAP(string varTrnCodigo)
        {
            try
            {
                string varSql = string.Format("Select Code as TrnCodigo, Name as TrnNombre, U_PLACA as TrnPlaca, (Case When U_TIPO_TRANSP = 'I' Then 'Interno' Else 'Externo' End) as TrnTipo From [@EXXIS_TRANSPORTE] Where Code = '{0}' Order by Name", varTrnCodigo);
                return funListarSqlSAP(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsLogTransporte> funListarSqlSAP(string varSql)
        {
            try
            {
                List<clsLogTransporte> objLista = new List<clsLogTransporte>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsLogTransporte()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }
        public static clsLogTransporte funRegistro(DataRow drRegistro, clsLogTransporte objRegistro)
        {
            objRegistro.TrnCodigo = drRegistro["TrnCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["TrnCodigo"].ToString());
            objRegistro.TrnNombre = drRegistro["TrnNombre"] == System.DBNull.Value ? "" : drRegistro["TrnNombre"].ToString().ToUpper();
            objRegistro.TrnPlaca = drRegistro["TrnPlaca"] == System.DBNull.Value ? "" : drRegistro["TrnPlaca"].ToString().ToUpper();
            objRegistro.TrnTipo = drRegistro["TrnTipo"] == System.DBNull.Value ? "" : drRegistro["TrnTipo"].ToString();

            return objRegistro;
        }
    }
}
