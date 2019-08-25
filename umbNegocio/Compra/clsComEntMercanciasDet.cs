using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Compra
{
    public class clsComEntMercanciasDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteUndInventario { get; set; }
        public decimal DetCantBruta { get; set; }
        public decimal DetTara { get; set; }
        public decimal DetCantNeta { get; set; }
        public string DetLote { get; set; }
        public string DetTieLote { get; set; }
        public string DetAbreviatura { get; set; }
        public decimal DetTolerancia { get; set; }
        public decimal DetTotTara { get; set; }
        public int DetUnidad { get; set; }
        public decimal DetCantidad { get; set; }
        public decimal DetCosto { get; set; }
        public decimal DetTotal { get; set; }
        #endregion
        #region Métodos públicos
        public clsComEntMercanciasDet() { }
        /// <summary>
        /// Instanciamos a la clase detalle de entrada de mercancias
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsComEntMercanciasDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            IteCodigo = "";
            IteNombre = "";
            IteUndInventario = "";
            DetCantBruta = 0;
            DetTara = 3;
            DetCantNeta = 0;
            DetLote = "";
            DetTieLote = "N";
            DetAbreviatura = "";
            DetTolerancia = 0;
            DetTotTara = 0;
            DetUnidad = 0;
            DetCantidad = 0;
            DetCosto = 0;
            DetTotal = 0;
        }
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle de entrada de mercancias
        /// </summary>
        /// <param name="varCabCodigo">Codigo del documento de entrada de mercancias</param>
        /// <returns></returns>
        public static void proListar(int varCabCodigo, out List<clsComEntMercanciasDet> objDetalle)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_EntMercanciaListarDetalle", varCabCodigo).ToListOf<clsComEntMercanciasDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Función utilizada para validar la fila del detalle de entrada de mercancia
        /// </summary>
        /// <returns></returns>
        public string funValidarFila()
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (IteCodigo.Equals("")) return varMensaje = "IteCodigo: El campo item es requerido";
            if (DetCantBruta.Equals(0)) return varMensaje = "DetCantBruta: El campo cantidad bruta no fue capturado correctamente";
            return varMensaje;
        }

        #endregion
    }
}
