using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraCstAcumulado
    {
        public static decimal funRecValorCstAcumulado(int varAnmCodigo, string varEstado)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                decimal varCosto = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Isnull(Sum(CsaValorSalida), 0) as CstAnumulado From GRA_CSTACUMULADOCHAPETA Where CsaAnmCodigo = {0} and EstCodigo = '{1}'", varAnmCodigo, varEstado)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCosto;
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
        public static DataTable funRecTableCstAcumulado(int varAnmCodigo, DateTime? varFecha, string varEstado)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtCstAcumulado = csAccesoDatos.GDatos.funTraerDataTable("proGra_CstAcumuladoChapetaListar", varAnmCodigo, varFecha, varEstado);
                csAccesoDatos.proFinalizarSesion();
                return dtCstAcumulado;
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
        public static int funVerificarCstAcumulado(int varAnmCodigo, DateTime? varFecha)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Isnull(Count(CsaValorSalida), 0) as CstCuantos From GRA_CSTACUMULADOCHAPETA Where CsaAnmCodigo = {0} and CsaFechaSalida <= '{1}' and CsaValorSalida = 0", varAnmCodigo, varFecha)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
        public static void proActualizarCstAcumulado(int varAnmCodigo, DateTime? varFecha, string varEstado, string varCabTabla, string varCabTipo, int varCabCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutar("proGra_CstAcumuladoChapetaActualizar", varAnmCodigo, varFecha, varEstado, varCabTabla, varCabTipo, varCabCodigo);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
    }
}
