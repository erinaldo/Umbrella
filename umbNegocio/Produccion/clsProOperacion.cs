using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Produccion
{
    public class clsProOperacion
    {
        public string OppCodigo{ get; set; }
        public string OppNombre { get; set; }
        public int OppTipo { get; set; }
        public string OppNomTipo { get; set; }
        public string OppArea { get; set; }
        public string OppNomArea { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsProOperacion> funListar()
        {
            try
            {
                const string varSql = "Select a.OppCodigo, a.OppNombre, a.OppTipo, b.Descripcion as OppNomTipo, a.OppArea, c.Descripcion as OppNomArea, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica " + 
                                                      "From PRO_OPERACION a inner join GEN_DICCIONARIO b on a.OppTipo = b.Codigo and b.Tipo = 'PROTIPOPERACION' " + 
                                                      "inner join GEN_DICCIONARIO c on a.OppArea = c.Codigo and c.Tipo = 'PROFORMULACION' " +
                                                      "Order by c.Descripcion";

                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsProOperacion> funListar(string varOppCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.OppCodigo, a.OppNombre, a.OppTipo, b.Descripcion as OppNomTipo, a.OppArea, c.Descripcion as OppNomArea, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica " +
                                                                    "From PRO_OPERACION a inner join GEN_DICCIONARIO b on a.OppTipo = b.Codigo and b.Tipo = 'PROTIPOPERACION' " +
                                                                    "inner join GEN_DICCIONARIO c on a.OppArea = c.Codigo and c.Tipo = 'PROFORMULACION'  Where a.OppCodigo = '{0}'", varOppCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsProOperacion> funListarSql(string varSql)
        {
            try
            {
                List<clsProOperacion> objLista = new List<clsProOperacion>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsProOperacion()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static clsProOperacion funRegistro(DataRow drRegistro, clsProOperacion objRegistro)
        {
            objRegistro.OppCodigo = drRegistro["OppCodigo"] == System.DBNull.Value ? "" : drRegistro["OppCodigo"].ToString();
            objRegistro.OppNombre = drRegistro["OppNombre"] == System.DBNull.Value ? "" : drRegistro["OppNombre"].ToString();
            objRegistro.OppTipo = drRegistro["OppTipo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["OppTipo"].ToString());
            objRegistro.OppNomTipo = drRegistro["OppNomTipo"] == System.DBNull.Value ? "" : drRegistro["OppNomTipo"].ToString();
            objRegistro.OppArea = drRegistro["OppArea"] == System.DBNull.Value ? "" : drRegistro["OppArea"].ToString();
            objRegistro.OppNomArea = drRegistro["OppNomArea"] == System.DBNull.Value ? "" : drRegistro["OppNomArea"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"] == null ? "" : drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drRegistro["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"] == null ? "" : drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drRegistro["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public string funMantenimiento(clsProOperacion csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                string varCodigo = csAccesoDatos.GDatos.funTraerValorEscalar("proPro_Operacion", csRegistro.OppCodigo, csRegistro.OppNombre, OppTipo, OppArea, varOperacion, clsVariablesGlobales.varCodUsuario).ToString();
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
