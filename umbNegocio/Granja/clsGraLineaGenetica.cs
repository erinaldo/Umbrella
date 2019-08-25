using umbNegocio.Granja;
using System;
using System.Collections.Generic;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraLineaGenetica
    {
        #region Propiedades
        public int  Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Genero { get; set; }
        //public string Usuario { get; set; }
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
            res = csAccesoDatos.GDatos.funEjecutar("dbo.SPGRA_LINEAGENETICA", Id, Nombre, Especie, Genero, Operacion, clsVariablesGlobales.varCodUsuario);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        public static List<clsGraLineaGenetica> Listar()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsGraLineaGenetica> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_LINEAGENETICAListar", DBNull.Value).ToListOf<clsGraLineaGenetica>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        public clsGraLineaGenetica Cargar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            clsGraLineaGenetica res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_LINEAGENETICAListar", vId).ToListOf<clsGraLineaGenetica>()[0];
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        #endregion
    }
}
