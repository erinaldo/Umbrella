using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Produccion
{
    public class clsProRecurso
    {
        public string RecCodigo { get; set; }
        public string RecNombre { get; set; }
        public string RecGrupo { get; set; }
        public string RecNomGrupo { get; set; }
        public DateTime RecFecha { get; set; }
        public bool RecEvaluar { get; set; }
        public string CcoCodigo  { get; set; }
        public string CcoNombre { get; set; }
        public decimal RecManObra { get; set; }
        public decimal RecGstFabricacion { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsProRecurso> funListar()
        {
            try
            {
                const string varSql = "Select a.RecCodigo, a.RecNombre, a.RecGrupo, b.Descripcion as RecNomGrupo, a.RecFecha,  " + 
                                                      "a.RecEvaluar, a.CcoCodigo, a.RecManObra, a.RecGstFabricacion, a.UsuCrea, a.UsuFechaCrea, " + 
                                                      "a.UsuModifica, a.UsuFechaModifica " + 
                                                      "From PRO_RECURSO a inner join GEN_DICCIONARIO b on a.RecGrupo = b.Codigo and b.Tipo = 'PRORECURSO' " +
                                                      "Order by b.Descripcion";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsProRecurso> funListar(string varRecCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.RecCodigo, a.RecNombre, a.RecGrupo, b.Descripcion as RecNomGrupo, a.RecFecha,  " +
                                                      "a.RecEvaluar, a.CcoCodigo, a.RecManObra, a.RecGstFabricacion, a.UsuCrea, a.UsuFechaCrea, " +
                                                      "a.UsuModifica, a.UsuFechaModifica " +
                                                      "From PRO_RECURSO a inner join GEN_DICCIONARIO b on a.RecGrupo = b.Codigo and b.Tipo = 'PRORECURSO' Where RecCodigo = '{0}'", varRecCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsProRecurso> funListarSql(string varSql)
        {
            try
            {
                List<clsProRecurso> objLista = new List<clsProRecurso>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsProRecurso()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static clsProRecurso funRegistro(DataRow drRegistro, clsProRecurso objRegistro)
        {
            objRegistro.RecCodigo = drRegistro["RecCodigo"] == System.DBNull.Value ? "" : drRegistro["RecCodigo"].ToString();
            objRegistro.RecNombre = drRegistro["RecNombre"] == System.DBNull.Value ? "" : drRegistro["RecNombre"].ToString();
            objRegistro.RecGrupo = drRegistro["RecGrupo"] == System.DBNull.Value ? "" : drRegistro["RecGrupo"].ToString();
            objRegistro.RecNomGrupo = drRegistro["RecNomGrupo"] == System.DBNull.Value ? "" : drRegistro["RecNomGrupo"].ToString();
            objRegistro.RecFecha = drRegistro["RecFecha"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["RecFecha"];
            objRegistro.RecEvaluar = drRegistro["RecEvaluar"] == System.DBNull.Value ? false : (bool)drRegistro["RecEvaluar"];
            objRegistro.CcoCodigo = drRegistro["CcoCodigo"] == System.DBNull.Value ? "" : drRegistro["CcoCodigo"].ToString();
            objRegistro.RecManObra = drRegistro["RecManObra"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["RecManObra"].ToString());
            objRegistro.RecGstFabricacion = drRegistro["RecGstFabricacion"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["RecGstFabricacion"].ToString());

            objRegistro.UsuCrea = drRegistro["UsuCrea"] == null ? "" : drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drRegistro["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"] == null ? "" : drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drRegistro["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaModifica"];
            
            return objRegistro;
        }
        public string funMantenimiento(clsProRecurso csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                string varCodigo = csAccesoDatos.GDatos.funTraerValorEscalar("proPro_Recurso", csRegistro.RecCodigo, csRegistro.RecNombre, csRegistro.RecGrupo, csRegistro.RecFecha, 
                                                                                                                                                                       csRegistro.RecEvaluar, csRegistro.CcoCodigo, csRegistro.RecManObra, csRegistro.RecGstFabricacion, 
                                                                                                                                                                       varOperacion, clsVariablesGlobales.varCodUsuario).ToString();
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
