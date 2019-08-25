using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Compra
{
    public class clsComEntMercanciasRes
    {
        #region Propiedades
        public int DetSecuencia { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public int DetPiezas { get; set; }
        public int DetUnidad { get; set; }
        public decimal DetCantidad { get; set; }
        public decimal DetCosto { get; set; }
        public decimal DetTotal { get; set; }
        public string DetLote { get; set; }
        public int DetNro { get; set; }
        #endregion
        #region Métodos públicos
        // Funcion utilizada para recuperar el resumen de detalles
        public static void proListar(int varCabCodigo, out List<clsComEntMercanciasRes> objDetalle) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("proCom_EntMercanciaListarResumen", varCabCodigo).ToListOf<clsComEntMercanciasRes>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

       
        #endregion
    }
}
