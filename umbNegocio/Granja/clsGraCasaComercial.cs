using umbNegocio;
using System;
using System.Collections.Generic;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraCasaComercial
    {
        //JMPC Programacion de las casas comerciales
        #region Propiedades
        public string Id { get; set; }
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
            res = csAccesoDatos.GDatos.funEjecutar("dbo.SPGRA_CASACOMERCIAL", Id, Nombre, Operacion, clsVariablesGlobales.varCodUsuario);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        public static List<clsGraCasaComercial> Listar()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsGraCasaComercial> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_CASACOMERCIALListar", DBNull.Value).ToListOf<clsGraCasaComercial>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        public clsGraCasaComercial Cargar(string vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            clsGraCasaComercial res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_CASACOMERCIALListar", vId).ToListOf<clsGraCasaComercial>()[0];
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        #endregion
    }
}
