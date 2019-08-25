using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraCstStdAcumulado
    {
        public static decimal funRecValorCstStdAcumulado(int varAnmCodigo, string varEstado)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                decimal varCosto = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Isnull(Sum(CdaDetValorSalida), 0) as CstAnumulado From GRA_CSTSTDACUMULADOCHAPETA Where CdaAnmCodigo = {0} and EstCodigo = '{1}'", varAnmCodigo, varEstado)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCosto;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public static DataTable funRecTableCstStdAcumulado(int varAnmCodigo, DateTime? varFecha, string varEstado)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtCstAcumulado = csAccesoDatos.GDatos.funTraerDataTable("proGra_CstStdAcumuladoChapetaListar", varAnmCodigo, varFecha, varEstado);
                csAccesoDatos.proFinalizarSesion();
                return dtCstAcumulado;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public static void proActualizarCstStdAcumulado(int varAnmCodigo, DateTime? varFecha, string varEstado, int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutar("proGra_CstStdAcumuladoChapetaActualizar", varAnmCodigo, varFecha, varEstado, varCabCodigo);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
