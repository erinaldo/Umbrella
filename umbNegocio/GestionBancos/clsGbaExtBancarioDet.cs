using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.GestionBancos
{
    public class clsGbaExtBancarioDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }

        public DateTime DetFecha { get; set; }

        public string DetReferencia { get; set; }
        public string DetComentario { get; set; }

        public decimal DetDebe { get; set; }
        public decimal DetHaber { get; set; }
        #endregion
        #region Métodos públicos
        public clsGbaExtBancarioDet() { }
        /// <summary>
        /// Instanciamos a la clase detalle de extractos bancarios
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsGbaExtBancarioDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;

            DetFecha = DateTime.Now;

            DetReferencia = "";
            DetComentario = "";

            DetDebe = 0;
            DetHaber = 0;
        }
        /// <summary>
        /// Función utilizada para validar la fila del detalle del extracto bancario
        /// </summary>
        /// <returns></returns>
        public string funValidarFila()
        {
            try {
                string varMensaje = "";
                //Validamos si la fila no tiene errores o inconsistencias
                if (DetReferencia.Length > 27) return varMensaje = string.Format("Error en el campo referencia en la linea {0} sobrepasa los 27 caracteres permitidos", DetSecuencia);
                return varMensaje;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle de los extractos bancarios
        /// </summary>
        /// <param name="varCabCodigo">Codigo del extracto bancario</param>
        /// <returns></returns>
        public static void proListar(int varCabCodigo, out List<clsGbaExtBancarioDet> objDetalle)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGba_ExtBancarioListarDetalle", varCabCodigo).ToListOf<clsGbaExtBancarioDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
