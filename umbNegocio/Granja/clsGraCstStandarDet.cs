using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraCstStandarDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }

        public string CueCodigo { get; set; }
        public string CueNombre { get; set; }
        public string CueFormato { get; set; }

        public decimal DetValor { get; set; }

        public string DetComentario { get; set; }
        #endregion
        #region Métodos públicos
         public clsGraCstStandarDet(){}
        /// <summary>
        /// Instanciamos a la clase detalle de costos standares
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
         public clsGraCstStandarDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            
            CueCodigo = "";
            CueNombre = "";
            CueFormato = "";
            
             DetValor = 0;

             DetComentario = "";
        }
         /// <summary>
         /// Función utilizada para validar la fila del detalle de costos acumulados
         /// </summary>
         /// <returns></returns>
         public string funValidarFila()
         {
             string varMensaje = "";
             //Validamos si la fila no tiene errores o inconsistencias
             if (CueCodigo.Equals("")) return varMensaje = "CueCodigo: El campo cuenta contable es requerido";
             if (DetValor.Equals(0)) return varMensaje = "DetValor: El campo valor debe ser mayor a cero";
             if (DetComentario.Equals("")) return varMensaje = "DetComentario: El campo comentario es requerido";
             return varMensaje;
         }
         /// <summary>
         /// Funcion utilizada para validar el detalle de costos standares
         /// </summary>
         /// <param name="objDetalle">Detalle de costos standares</param>
         /// <returns></returns>
         public static string funValidarDetalle(List<clsGraCstStandarDet> objDetalle)
         {
             string varMensaje = "";
             var objResultado = new clsGraCstStandarDet();
             //Verificamos que no exista campos de valor con cero en el detalle
             if (varMensaje.Equals("")){
                 objResultado = objDetalle.Where(p => p.DetValor == 0).ToList().Count > 0 ? objDetalle.Where(p => p.DetValor == 0).ToList()[0] : null;
                 if (objResultado != null) varMensaje = string.Format("El campo valor debe ser mayor a cero favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
             }
             //Verificamos que no exista campos de cuenta contable en vacios en el detalle 
             if (varMensaje.Equals("")) {
                 objResultado = objDetalle.Where(p => p.CueCodigo == "").ToList().Count > 0 ? objDetalle.Where(p => p.CueCodigo == "").ToList()[0] : null;
                 if (objResultado != null) varMensaje = string.Format("El campo cuenta contable es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
             }
             //Verificamos que no exista campos de comentario en vacios en el detalle 
             if (varMensaje.Equals("")) {
                 objResultado = objDetalle.Where(p => p.DetComentario == "").ToList().Count > 0 ? objDetalle.Where(p => p.DetComentario == "").ToList()[0] : null;
                 if (objResultado != null) varMensaje = string.Format("El campo comentario es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
             }
             //Verificamos si hay dos veces ingresado la misma cuenta contable
             if (varMensaje.Equals("")){
                 var objDuplicados = objDetalle.GroupBy(p => new { p.CueCodigo, p.CueNombre, p.CueFormato }).Where(g => g.Count() > 1).ToList();
                 if (objDuplicados.Count > 0) {
                     string varResultado = String.Join(", ", objDuplicados.Select(p => p.Key));
                     String[] varLista = varResultado.Split(',');
                     varMensaje = string.Format("La cuenta contable {0} - {1} se encuentra duplicado", varLista[0].Substring(varLista[0].IndexOf('=') + 2, varLista[0].Length - varLista[0].IndexOf('=') - 2),
                                                                                                                                                                          varLista[1].Substring(varLista[1].IndexOf('=') + 2, varLista[1].Length - varLista[1].IndexOf('=') - 2));
                 }
             }
             return varMensaje;
         }
         /// <summary>
         /// Procedimiento utilizado para recuperar los valores del detalle de costos standares
         /// </summary>
         /// <param name="varCabCodigo">Codigo del documento de costos standares</param>
         /// <returns></returns>
         public static void proListar(int varCabCodigo, out List<clsGraCstStandarDet> objDetalle)
         {
             try {
                 csAccesoDatos.funIniciarSesion("conDBUmbrella");
                 objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_CstStandarListarDetalle", varCabCodigo).ToListOf<clsGraCstStandarDet>();
                 csAccesoDatos.proFinalizarSesion();
             }
             catch (Exception e) { throw new Exception(e.Message); }
         }
        #endregion
    }
}
