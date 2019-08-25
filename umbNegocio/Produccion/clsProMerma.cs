using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Produccion
{
    public class clsProMerma
    {
        public int MerCodigo { get; set; }
        public string MerNombre { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsProMerma> funListar()
        {
            try
            {
                const string varSql = "Select MerCodigo,  Upper(MerNombre) as MerNombre, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From PRO_MERMA";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsProMerma> funListar(int varMerCodigo)
        {
            try
            {
                string varSql = string.Format("Select MerCodigo,  Upper(MerNombre) as MerNombre, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From PRO_MERMA Where MerCodigo = {0}", varMerCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsProMerma> funListarSql(string varSql)
        {
            try
            {
                List<clsProMerma> objLista = new List<clsProMerma>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsProMerma()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static clsProMerma funRegistro(DataRow drLista, clsProMerma objRegistro)
        {
            objRegistro.MerCodigo = int.Parse(drLista["MerCodigo"].ToString());
            objRegistro.MerNombre = drLista["MerNombre"].ToString();
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsProMerma csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proPro_Merma", csRegistro.MerCodigo, csRegistro.MerNombre, varOperacion, clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
