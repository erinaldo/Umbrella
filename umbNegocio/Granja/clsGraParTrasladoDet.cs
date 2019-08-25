using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraParTrasladoDet
    {
        #region Propiedades
        public int PtrSecuencia { get; set; }
        public int MovCodigo { get; set; }
        public int BodCodigo { get; set; }

        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string MovNombre { get; set; }
        public string BodNombre { get; set; }
        public string CtaMovCodigo { get; set; }
        public string CtaMovNombre { get; set; }
        public string CtaMovFormato { get; set; }
        public string CtaDiaCodigo { get; set; }
        public string CtaDiaNombre { get; set; }
        public string CtaDiaFormato { get; set; }
        public string PtrMovTipo { get; set; }
        public string PtrMovTipoUnidad { get; set; }
        public string PtrMovCstCalculo { get; set; }
        public string PtrMovObservacion { get; set; }
        public string PtrDiaTipo { get; set; }
        public string PtrDiaDebeCalculo { get; set; }
        public string PtrDiaHaberCalculo { get; set; }
        public string PtrDiaObservacion { get; set; }
        #endregion
        #region Métodos públicos
         public clsGraParTrasladoDet(){}
        /// <summary>
        /// Instanciamos a la clase detalle de laboratorio
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
         public clsGraParTrasladoDet(int varDetLinea)
         {
             PtrSecuencia = varDetLinea + 1;
             MovCodigo = 0;
             BodCodigo = 0;

             IteCodigo = "";
             IteNombre = "";
             MovNombre = "";
             BodNombre = "";
             CtaMovCodigo = "";
             CtaMovNombre = "";
             CtaMovFormato = "";
             CtaDiaCodigo = "";
             CtaDiaNombre = "";
             CtaDiaFormato = "";
             PtrMovTipo = "";
             PtrMovTipoUnidad = "";
             PtrMovCstCalculo = "";
             PtrMovObservacion = "";
             PtrDiaTipo = "";
             PtrDiaDebeCalculo = "";
             PtrDiaHaberCalculo = "";
             PtrDiaObservacion = "";
         }
        /// <summary>
        /// Procedimiento utilizado para listar el detalle
        /// </summary>
        /// <param name="varPtrCodigo">Codigo interno del documento</param>
        /// <param name="objDetalle">Objeto que contendra el listado del detalle</param>
         public static void proListar(int varPtrCodigo, out List<clsGraParTrasladoDet> objDetalle)
         {
             try {
                 csAccesoDatos.funIniciarSesion("conDBUmbrella");
                 objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_ParTrasladoListarDetalle", varPtrCodigo).ToListOf<clsGraParTrasladoDet>();
                 csAccesoDatos.proFinalizarSesion();
             }
             catch (Exception e) { throw new Exception(e.Message); }
         }

         public string funValidarFila()
         {
             try {
                 string varMensaje = "";
                 //Validamos si la fila no tiene errores o inconsistencias
                 if (!PtrMovTipo.Equals("DIARIO") && MovNombre.Equals("")) return varMensaje = "El campo movimiento es requerido";
                 if (!PtrMovTipo.Equals("DIARIO") && IteNombre.Equals("")) return varMensaje = "El campo item es requerido";
                 if (!PtrMovTipo.Equals("DIARIO") && BodNombre.Equals("")) return varMensaje = "El campo bodega es requerido";
                 if (!PtrMovTipo.Equals("DIARIO") && CtaMovNombre.Equals("")) return varMensaje = "El campo cta. de movimiento es requerido";
                 if (!PtrMovTipo.Equals("DIARIO") && PtrMovCstCalculo.Equals("")) return varMensaje = "El campo costo es requerido";
                 if (PtrMovTipo.Equals("DIARIO") && CtaDiaNombre.Equals("")) return varMensaje = "El campo cta. de diario es requerido";
                 if (PtrMovTipo.Equals("DIARIO") && PtrDiaTipo.Equals("DEBE") && PtrDiaDebeCalculo.Equals("")) return varMensaje = "El campo calculo valor debe es requerido";
                 if (PtrMovTipo.Equals("DIARIO") && PtrDiaTipo.Equals("HABER") && PtrDiaHaberCalculo.Equals("")) return varMensaje = "El campo calculo valor haber es requerido";
                 return varMensaje;
             }
             catch (Exception e) { throw new Exception(e.Message); }
         }
        #endregion
    }
}
