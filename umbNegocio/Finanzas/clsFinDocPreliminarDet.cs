using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Finanzas
{
    public class clsFinDocPreliminarDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }

        public string CueCodigo { get; set; }
        public string CueNombre { get; set; }
        public string CueFormato { get; set; }
        public string CcoCodigo { get; set; }
        public string CcoNombre { get; set; }
        public string DetComentario { get; set; }
        public string DetReferencia1 { get; set; }
        public string DetReferencia2 { get; set; }

        public decimal DetDebe { get; set; }
        public decimal DetHaber { get; set; }
        #endregion
        public clsFinDocPreliminarDet() { }
        /// <summary>
        /// Instanciamos la clase detalle de documentos preliminares
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsFinDocPreliminarDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea++;

            CueCodigo = "";
            CueNombre = "";
            CueFormato = "";
            CcoCodigo = "";
            CcoNombre = "";
            DetComentario = "";
            DetReferencia1 = "";
            DetReferencia2 = "";

            DetDebe = 0;
            DetHaber = 0;
        }
       
        /// <summary>
        /// Función utilizada para validar la fila del detalle del inventario
        /// </summary>
        /// <returns></returns>
        public string funValidarFila()
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (DetComentario.Trim().Length > 50) return varMensaje = string.Format("Error en el campo comentario en la linea {0} sobrepasa los 50 caracteres permitidos", DetSecuencia);
            if (DetReferencia1.Trim().Length > 100) return varMensaje = string.Format("Error en el campo referencia 1 en la linea {0} sobrepasa los 100 caracteres permitidos", DetSecuencia);
            if (DetReferencia2.Trim().Length > 100) return varMensaje = string.Format("Error en el campo referencia 2 en la linea {0} sobrepasa los 100 caracteres permitidos", DetSecuencia);
            if (DetDebe > 0 && DetHaber > 0) return varMensaje = string.Format("Error en el campo debe y haber en la linea {0} no puede tener ambos campos valores mayores a cero", DetSecuencia);
            if (!CueCodigo.Equals("") && CueNombre.Equals("")) return varMensaje = string.Format("Error en el campo cuenta contable en la linea {0} la cuenta no existe", DetSecuencia);
            if (!CcoCodigo.Equals("") && CcoNombre.Equals("")) return varMensaje = string.Format("Error en el campo centro de costo en la linea {0} el centro de costo no existe", DetSecuencia);
            return varMensaje;
        }
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle de los documentos preliminares
        /// </summary>
        /// <param name="varCabCodigo">Codigo del documento preliminar</param>
        /// <returns></returns>
        public static void proListar(int varCabCodigo, out List<clsFinDocPreliminarDet> objDetalle)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proFin_DocPreliminarListarDetalle", varCabCodigo).ToListOf<clsFinDocPreliminarDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
