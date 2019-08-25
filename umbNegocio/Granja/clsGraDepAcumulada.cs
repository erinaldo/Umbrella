using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraDepAcumulada
    {
        /// <summary>
        /// Funcion utilizada para recuperar el diario mensual de las depreciaciones acumuladas
        /// </summary>
        /// <param name="varDacFecha"Fecha del documento</param>
        /// <returns></returns>
        public static DataTable funRecDiarioDepreciacion(DateTime varDacFecha)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtDepAcumulada = csAccesoDatos.GDatos.funTraerDataTable("proGra_DepAcumuladaDiario", varDacFecha);
                csAccesoDatos.proFinalizarSesion();
                return dtDepAcumulada;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
