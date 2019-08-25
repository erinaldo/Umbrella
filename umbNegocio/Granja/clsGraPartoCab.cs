using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraPartoCab
    {
        #region Propiedades
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        
        public DateTime CabFecha { get; set; }
        public DateTime CabFecDesde { get; set; }
        public DateTime CabFecHasta { get; set; }

        public string DocNombre { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string CabLote { get; set; }
        public string BodCodigo { get; set; }
        public string CabComentario { get; set; }
        public string EstCodigo { get; set; }
        #endregion
        #region Métodos públicos
        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="varOperacion">1=Inserción, 2=Actualización, 3=Eliminación</param>
        /// <param name="objDetalles">Detalles del parto</param>
        /// <returns></returns>
        public int funMantenimiento(int varOperacion, List<clsGraPartoDet> objDetalles)
        {

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detParto = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_PartoMantenimiento", CabCodigo, DocCodigo, CabNumero, CabFecha, CabFecDesde, CabFecHasta,
                                                                                                                                                                                               IteCodigo, IteNombre, CabLote, BodCodigo, CabComentario, varOperacion, 
                                                                                                                                                                                               clsVariablesGlobales.varCodUsuario, detParto);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar el listado de parto
        /// </summary>
        /// <param name="varWhere">Condicion para el listado de parto</param>
        /// <returns></returns>
        public static DataTable funListar(string varWhere)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_PartoListar", DBNull.Value, varWhere);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Funcion utilizada para recuperar un registro del parto
        /// </summary>
        /// <param name="vId">Codigo del parto interno</param>
        /// <returns></returns>
        public static List<clsGraPartoCab> funListar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsGraPartoCab> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_PartooListar", vId, DBNull.Value).ToListOf<clsGraPartoCab>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Procedimiento utilizado para anular los registros de parto
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de parto interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_PartoAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
