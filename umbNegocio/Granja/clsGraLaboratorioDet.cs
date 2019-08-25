using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace umbNegocio.Granja
{
    public class clsGraLaboratorioDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }

        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteUndInventario { get; set; }
        public string IteTieLote { get; set; }

        public decimal ItePsoStd { get; set; }
        public decimal DetCantidad { get; set; }
        public decimal DetCosto { get; set; }
        public decimal DetValor { get; set; }
        #endregion

        #region Métodos públicos

        public clsGraLaboratorioDet(){}
        /// <summary>
        /// Instanciamos a la clase detalle de laboratorio
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsGraLaboratorioDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            
            IteCodigo = "";
            IteNombre = "";
            IteUndInventario = "";
            IteTieLote = "N";
            
            ItePsoStd = 0;
            DetCantidad = 0;
            DetCosto = 0;
            DetValor = 0;
        }
        /// <summary>
        /// Función utilizada para validar la fila del detalle de laboratorio
        /// </summary>
        /// <returns></returns>
        public string funValidarFila()
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (IteCodigo.Equals("")) return varMensaje = "IteCodigo: El campo item es requerido";
            if (DetCantidad.Equals(0)) return varMensaje = "DetCantidad: El campo cantidad debe ser mayor a cero";
            return varMensaje;
        }
        /// <summary>
        /// Funcion utilizada para validar el detalle de laboratorio
        /// </summary>
        /// <param name="objDetalle">Detalle de movimientos de inventario</param>
       /// <returns></returns>
        public static string funValidarDetalle(List<clsGraLaboratorioDet> objDetalle)
        {
            string varMensaje = "";
            var objResultado = new clsGraLaboratorioDet();
            //Verificamos que no exista campos de cantidad con valor cero en el detalle
            if (varMensaje.Equals(""))
            {
                objResultado = objDetalle.Where(p => p.DetCantidad == 0).ToList().Count > 0 ? objDetalle.Where(p => p.DetCantidad == 0).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo cantidad no puede tener valor 0 favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que no exista campos de item en vacion en el detalle 
            if (varMensaje.Equals(""))
            {
                objResultado = objDetalle.Where(p => p.IteCodigo == "").ToList().Count > 0 ? objDetalle.Where(p => p.IteCodigo == "").ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo item es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos si hay dos veces ingresado el mismo item
            if (varMensaje.Equals(""))
            {
                var objDuplicados = objDetalle.GroupBy(p => new { p.IteCodigo, p.IteNombre }).Where(g => g.Count() > 1).ToList();
                if (objDuplicados.Count > 0)
                {
                    string varResultado = String.Join(", ", objDuplicados.Select(p => p.Key));
                    String[] varLista = varResultado.Split(',');
                    varMensaje = string.Format("El item {0} - {1} se encuentra duplicado", varLista[0].Substring(varLista[0].IndexOf('=') + 2, varLista[0].Length - varLista[0].IndexOf('=') - 2),
                                                                                                                                                   varLista[1].Substring(varLista[1].IndexOf('=') + 2, varLista[1].Length - varLista[1].IndexOf('=') - 2));
                }
            }
            return varMensaje;
        }
        /// <summary>
        /// Procedimiento utilizado para recuperar los valores del detalle del movimiento de inventario
        /// </summary>
        /// <param name="varCabCodigo">Codigo del documento de movimiento de inventario</param>
        /// <returns></returns>
        public static void proListar(int varCabCodigo, out List<clsGraLaboratorioDet> objDetalle)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_LaboratorioListarDetalle", varCabCodigo).ToListOf<clsGraLaboratorioDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}


