using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Compra
{
    public class clsComEntMercanciasAbr
    {
        #region Propiedades
        public string AenCodigo { get; set; }
        public string IteCodigo { get; set; }
        public decimal AenTara { get; set; }
        #endregion 
        #region Métodos públicos
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle de entrada de mercancias
        /// </summary>
        /// <param name="varCabCodigo">Codigo del documento de entrada de mercancias</param>
        /// <returns></returns>
        public static void proListar(out List<clsComEntMercanciasAbr> objDetalle)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_EntMercanciaListarAbreviatura").ToListOf<clsComEntMercanciasAbr>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
