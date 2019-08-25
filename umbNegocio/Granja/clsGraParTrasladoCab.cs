using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraParTrasladoCab
    {
        #region Propiedades
        public int PtrCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int SAPCodSerieSalida { get; set; }
        public int SAPCodSerieEntrada { get; set; }
        public int SAPCodSerieDiario { get; set; }

        public string PtrDescripcion { get; set; }
        public string PtrVariante { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string DocNombre { get; set; }
        public string DocDescripcion { get; set; }
        public string SAPNomSerieSalida { get; set; }
        public string SAPNomSerieEntrada { get; set; }
        public string SAPNomSerieDiario { get; set; }
        public string CtaDesCodigo { get; set; }
        public string CtaDesNombre { get; set; }
        public string CtaDesFormato { get; set; }
        #endregion
        #region Métodos públicos
        /// <summary>
        /// Funcion utilizada para recuperar el registro segun su id
        /// </summary>
        /// <param name="vId">Codigo interno </param>
        /// <returns></returns>
        public static List<clsGraParTrasladoCab> funListar(int vId)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                List<clsGraParTrasladoCab> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_ParTrasladoListar", vId, DBNull.Value).ToListOf<clsGraParTrasladoCab>();
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception (ex.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar el listado segun una condicion
        /// </summary>
        /// <param name="varWhere"></param>
        /// <returns></returns>
        public static DataTable funListar(string varWhere)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_ParTrasladoListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para guardar en la base de datos segun la operacion de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="varOperacion">1=Inserción, 2=Actualización, 3=Eliminación</param>
        /// <param name="objDetalles">Detalles del documento</param>
        /// <returns></returns>
        public int funMantenimiento(int varOperacion, List<clsGraParTrasladoDet> objDetalles)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detParTraslado = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_ParTrasladoMantenimiento",   PtrCodigo, DocCodigo, SAPCodSerieSalida, SAPCodSerieEntrada, SAPCodSerieDiario,
                                                                                                                                                                                            PtrDescripcion, PtrVariante, IteCodigo, IteNombre,  DocNombre, DocDescripcion, 
                                                                                                                                                                                            SAPNomSerieSalida, SAPNomSerieEntrada, SAPNomSerieDiario, CtaDesCodigo,
                                                                                                                                                                                            CtaDesNombre, CtaDesFormato, varOperacion, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                                            detParTraslado);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
       /// <summary>
       /// Procedimiento utilizado para la eliminacion del registro
       /// </summary>
       /// <param name="varPtrCodigo">Codigo interno del registro</param>
        public static void proAnular(int varPtrCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_ParTrasladoAnulacion", varPtrCodigo);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
