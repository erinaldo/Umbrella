using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Produccion
{
    public class clsProRutaStd
    {
        public int PrsCodigo { get; set; }
        public string PrsNombre { get; set; }
        public decimal PrsManoObra { get; set; }
        public decimal PrsCstFabricacion { get; set; }
        public decimal PrsGstOperacional { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsProRutaStd> funListar()
        {
            try
            {
                const string varSql = "Select PrsCodigo,  Upper(PrsNombre) as PrsNombre, PrsManoObra, PrsCstFabricacion, PrsGstOperacional, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From PRO_RUTASTD " + 
                                                      "Union all " + 
                                                      "Select 0, 'NO ESPECIFICADO', 0, 0, 0, 'manager', Getdate(), 'manager', Getdate() " + 
                                                      "Order by PrsCodigo " ;
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsProRutaStd> funListar(int varPrsCodigo)
        {
            try
            {
                string varSql = string.Format("Select PrsCodigo,  Upper(PrsNombre) as PrsNombre, PrsManoObra, PrsCstFabricacion, PrsGstOperacional, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From PRO_RUTASTD Where PrsCodigo = {0}", varPrsCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsProRutaStd> funListarSql(string varSql)
        {
            try
            {
                List<clsProRutaStd> objLista = new List<clsProRutaStd>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsProRutaStd()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static clsProRutaStd funRegistro(DataRow drLista, clsProRutaStd objRegistro)
        {
            objRegistro.PrsCodigo = int.Parse(drLista["PrsCodigo"].ToString());
            objRegistro.PrsNombre = drLista["PrsNombre"].ToString();
            objRegistro.PrsManoObra = decimal.Parse(drLista["PrsManoObra"].ToString());
            objRegistro.PrsCstFabricacion = decimal.Parse(drLista["PrsCstFabricacion"].ToString());
            objRegistro.PrsGstOperacional = drLista["PrsGstOperacional"] == DBNull.Value ? 0 : decimal.Parse(drLista["PrsGstOperacional"].ToString());
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsProRutaStd csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proPro_RutaStd", csRegistro.PrsCodigo, csRegistro.PrsNombre, csRegistro.PrsManoObra, csRegistro.PrsCstFabricacion, csRegistro.PrsGstOperacional,  varOperacion, clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
