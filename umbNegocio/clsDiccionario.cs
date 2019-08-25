using System;
using System.Collections.Generic;
using System.Data;
using umbDatos;

namespace umbNegocio
{
    public static class clsDiccionario
    {
        #region Propiedades
        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve Codigo, Descripción del diccionario de items
        /// </summary>
        /// <param name="Tipo"></param>
        /// <returns></returns>
        public static DataTable Listar(string Tipo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtDiccionario = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGEN_DICCIONARIOListar", Tipo);
            csAccesoDatos.proFinalizarSesion();
            return dtDiccionario;
        }
        #endregion
    }
}
