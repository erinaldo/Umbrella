using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Granja
{
    public class clsGraPartoDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }
        public int AnmCodigo { get; set; }
        public int DetNroVivos { get; set; }
        public int DetNroMuertos { get; set; }
        public int DetNroMomificados { get; set; }
        public int DetNroTotal { get; set; }

        public DateTime DetFecha { get; set; }
        public Nullable<DateTime> DetFecNacimiento { get; set; }

        public string AnmAlternativo { get; set; }
        public string IteNombre { get; set; }
        public string EstCodigo { get; set; }
        
        public decimal DetTotalKg { get; set; }
        public decimal DetPromedioKg { get; set; }
        public decimal DetCstInicial { get; set; }
        public Nullable<decimal> DetCstNacimiento { get; set; }

        public Nullable<int> DetDocEntrySAPEntrada { get; set; }
        public Nullable<int> DetNumeroSAPEntrada { get; set; }
        #endregion
        #region Métodos públicos
        public clsGraPartoDet(){}
        /// <summary>
        /// Instanciamos a la clase detalle de parto
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsGraPartoDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            AnmCodigo = 0;
            DetNroVivos = 0;
            DetNroMomificados = 0;
            DetNroMuertos = 0;
            DetNroTotal = 0;
            
            DetFecha = DateTime.Now;
            DetFecNacimiento = null;

            AnmAlternativo = "";
            IteNombre = "";
            EstCodigo = "";

            DetTotalKg = 0;
            DetPromedioKg = 0;
            DetCstInicial = 0;
        }
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle de partos
        /// </summary>
        /// <param name="varCabCodigo">Codigo del documento de partos</param>
        /// <returns></returns>
        public static void proListar(int varCabCodigo, out List<clsGraPartoDet> objDetalle)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_PartoListarDetalle", varCabCodigo).ToListOf<clsGraPartoDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Función utilizada para validar la fila del detalle de parto
        /// </summary>
        /// <returns></returns>
        public string funValidarFila()
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (AnmCodigo.Equals(0)) return varMensaje = "AnmAlternativo: El campo chapeta es requerido";
            if (DetNroTotal > 0 && DetFecNacimiento == null) return varMensaje = "DetFecNacimiento: El campo fec. nacimiento es requerido";
            if (DetNroTotal > 0 && DetTotalKg.Equals(0)) return varMensaje = "DetTotalKg: El campo total kg. debe ser mayor a cero";
            if (DetFecNacimiento != null && DetNroTotal.Equals(0)) return varMensaje = "DetNroTotal: Se debe registrar el nro de animales del parto";
            return varMensaje;
        }
        /// <summary>
        /// Funcion utilizada para validar el detalle de partos
        /// </summary>
        /// <param name="objDetalle">Detalle de partos</param>
        /// <returns></returns>
        public static string funValidarDetalle(List<clsGraPartoDet> objDetalle)
        {
            string varMensaje = "";
            var objResultado = new clsGraPartoDet();
            //Verificamos que no exista campos de item en vacion en el detalle 
            if (varMensaje.Equals("")) {
                objResultado = objDetalle.Where(p => p.AnmCodigo == 0).ToList().Count > 0 ? objDetalle.Where(p => p.AnmCodigo == 0).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo chapeta es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si existe animales registrados haya fecha de nacimiento
            if (varMensaje.Equals("")){
                objResultado = objDetalle.Where(p => p.DetNroTotal > 0 && p.DetFecNacimiento == null).ToList().Count > 0 ? objDetalle.Where(p => p.DetNroTotal > 0 && p.DetFecNacimiento == null).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo fec. nacimiento es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si existe animales registrados haya total peso en kg
            if (varMensaje.Equals("")) {
                objResultado = objDetalle.Where(p => p.DetNroTotal > 0 && p.DetTotalKg == 0).ToList().Count > 0 ? objDetalle.Where(p => p.DetNroTotal > 0 && p.DetTotalKg == 0).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo total kg. es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si existe fecha de nacimiento tambien exista el registro de animaels
            if (varMensaje.Equals("")){
                objResultado = objDetalle.Where(p => p.DetNroTotal == 0 && p.DetFecNacimiento != null).ToList().Count > 0 ? objDetalle.Where(p => p.DetNroTotal == 0 && p.DetFecNacimiento != null).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("Se debe registrar los animales del parto favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos si hay dos veces ingresado la misma chapeta
            if (varMensaje.Equals("")) {
                var objDuplicados = objDetalle.GroupBy(p => new { p.AnmAlternativo, p.IteNombre }).Where(g => g.Count() > 1).ToList();
                if (objDuplicados.Count > 0){
                    string varResultado = String.Join(", ", objDuplicados.Select(p => p.Key));
                    String[] varLista = varResultado.Split(',');
                    varMensaje = string.Format("La chapeta {0} - {1} se encuentra duplicado", varLista[0].Substring(varLista[0].IndexOf('=') + 2, varLista[0].Length - varLista[0].IndexOf('=') - 2),
                                                                                                                                                   varLista[1].Substring(varLista[1].IndexOf('=') + 2, varLista[1].Length - varLista[1].IndexOf('=') - 2));
                }
            }
            return varMensaje;
        }
        #endregion
    }
}
