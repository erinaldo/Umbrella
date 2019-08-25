using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraCstStandarCab
    {
        #region Propiedades
        public int CabCodigo { get; set; }

        public DateTime CabFecha { get; set; }
        public DateTime CabFechaDesde { get; set; }
        public Nullable<DateTime> CabFechaHasta { get; set; }

        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string CabComentario { get; set; }
        public string EstCodigo { get; set; }
        #endregion
        #region Métodos públicos
        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="varOperacion">1=Inserción, 2=Actualización, 3=Eliminación</param>
        /// <param name="objDetalles">Detalles del laboratorio</param>
        /// <returns></returns>
        public int funMantenimiento(int varOperacion, List<clsGraCstStandarDet> objDetalles)
        {

            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detCstStandar = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_CstStandarMantenimiento", CabCodigo, CabFecha, CabFechaDesde, CabFechaHasta, IteCodigo, 
                                                                                                                                                                                                         IteNombre, CabComentario, varOperacion, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                                                         detCstStandar);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar el listado de costos standares
        /// </summary>
        /// <param name="varWhere">Condicion para el listado de costos standares</param>
        /// <returns></returns>
        public static DataTable funListar(string varWhere)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_CstStandarListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar un registro de costos standares
        /// </summary>
        /// <param name="vId">Codigo de costo standares interno</param>
        /// <returns></returns>
        public static List<clsGraCstStandarCab> funListar(int vId)
        {
            try{
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                List<clsGraCstStandarCab> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_CstStandarListar", vId, DBNull.Value).ToListOf<clsGraCstStandarCab>();
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para anular los costos estandares
        /// </summary>
        /// <param name="varCabCodigo">Codigo del costo estandar interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_CstStandarAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
