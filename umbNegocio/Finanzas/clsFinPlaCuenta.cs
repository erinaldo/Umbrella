using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Finanzas
{
    public class clsFinPlaCuenta
    {
        public string CueCodigo { get; set; }
        public string CueNombre { get; set; }
        public string CueFormato { get; set; }

        public static List<clsFinPlaCuenta> funListar()
        {
            try
            {
                const string varSql = "Select a.AcctCode as CueCodigo, a.AcctName as CueNombre, a.FormatCode as CueFormato From OACT a Where a.Postable = 'Y' Order by a.FormatCode";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsFinPlaCuenta> funListar(string varCueFormato)
        {
            try
            {
                string varSql = string.Format("Select a.AcctCode as CueCodigo, a.AcctName as CueNombre, a.FormatCode as CueFormato From OACT a Where a.FormatCode = '{0}'", varCueFormato);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsFinPlaCuenta> funListarSql(string varSql)
        {
            try
            {
                List<clsFinPlaCuenta> objLista = new List<clsFinPlaCuenta>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsFinPlaCuenta()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static clsFinPlaCuenta funRegistro(DataRow drRegistro, clsFinPlaCuenta objRegistro)
        {
            objRegistro.CueCodigo = drRegistro["CueCodigo"] == System.DBNull.Value ? "" : drRegistro["CueCodigo"].ToString();
            objRegistro.CueNombre = drRegistro["CueNombre"] == System.DBNull.Value ? "" : drRegistro["CueNombre"].ToString();
            objRegistro.CueFormato = drRegistro["CueFormato"] == System.DBNull.Value ? "" : drRegistro["CueFormato"].ToString();

            return objRegistro;
        }
        /// <summary>
        /// Devuelve OACT.AcctCode del item y código de movimiento
        /// </summary>
        /// <param name="OITMCode"></param>
        /// <param name="CodMovimiento"></param>
        /// <returns></returns>
        public static string GetAcctCodeDeMovimiento(string OITMCode, int CodMovimiento)
        {
            csAccesoDatos.funIniciarSesion("conDBItalimentos");
            string res = "";
            DataTable tab = csAccesoDatos.GDatos.funTraerDataTable("PAUMBObtenerAcctCodeDeMovInventario", OITMCode, CodMovimiento);
            csAccesoDatos.proFinalizarSesion();
            if (tab != null && tab.Rows.Count > 0)
            {
                res = tab.Rows[0][0].ToString();
            }
            return res;
        }
    }
}
