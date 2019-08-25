using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.General
{
    public class clsGenParametros
    {
        public static decimal funObtenerIvaSAP()
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                decimal varValor = (decimal)csAccesoDatos.GDatos.funTraerValorEscalarSql("Select Rate as IVA From OSTA Where Code = 'IVA'");
                csAccesoDatos.proFinalizarSesion();
                return varValor;
            }
            catch (Exception) { throw; }
        }
    }
}
