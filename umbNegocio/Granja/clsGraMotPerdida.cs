using umbNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using umbDatos;

namespace umbNegocio.Inventario
{
    public class clsGraMotPerdida
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="Operacion">1=Inserción/actualización, 3=Eliminación</param>
        /// <returns></returns>
        public int ejecutarMantenimiento(int Operacion)
        {
            int res = -1;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            try
            {
                res = csAccesoDatos.GDatos.funEjecutar("dbo.SPGRA_MOTIVOPERDIDA", Id, Nombre, Operacion, clsVariablesGlobales.varCodUsuario);
            }
            catch (Exception ) { }
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        ///  Devuelve Id, Nombre
        /// </summary>
        /// <returns></returns>
        public static DataTable Listar()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_MOTIVOPERDIDAListar", DBNull.Value);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        public static clsGraMotPerdida Cargar(string vId)
        {

            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            clsGraMotPerdida res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_MOTIVOPERDIDAListar", vId).ToListOf<clsGraMotPerdida>()[0];
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        #endregion
    }
}
