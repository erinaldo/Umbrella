using umbNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using umbDatos;

namespace umbNegocio.Inventario
{
    public class clsInvMovimientoDet
    {
        #region Propiedades
        public int DetSecuencia { get; set; }
        public Nullable<int> IdMotPerdida { get; set; }
        public Nullable<int> DetPieza { get; set; }

        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteUndInventario { get; set;}
        public string IteTieLote { get; set; }
        public string DetTipDestino { get; set; }
        public string DetIdDestino { get; set; }
        
        public decimal ItePsoStd { get; set; }
        public decimal DetCantidad { get; set; }
        public decimal DetPeso { get; set; }
        public decimal DetCosto { get; set; }
        public decimal DetValor { get; set; }

        #endregion

        #region Métodos públicos

        ///Constructores de la clase
        public clsInvMovimientoDet(){}
        public clsInvMovimientoDet(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            IdMotPerdida = null;
            DetPieza = 0;

            IteCodigo = "";
            IteNombre = "";
            IteUndInventario = "";
            IteTieLote = "N";
            DetTipDestino = "A";
            DetIdDestino = null;
            
            ItePsoStd = 0;
            DetCantidad = 0;
            DetPeso = 0;
            DetCosto = 0;
            DetValor = 0;
        }
        /// <summary>
        /// Función utilizada para validar la fila del detalle del inventario
        /// </summary>
        /// <returns></returns>
        public string funValidarFila(string varRazon, bool varReqChapetaLote)
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (IteNombre.Equals(""))  return varMensaje = "IteCodigo: El campo item es requerido";
            if (DetIdDestino == null && varReqChapetaLote) return varMensaje = "DetIdDestino: El campo chapeta/lote es requerido";
            if (DetCantidad.Equals(0)) return varMensaje = "DetCantidad: El campo cantidad debe ser mayor a cero";
            if (varRazon.ToLower().Equals("prd") && (IdMotPerdida == null || IdMotPerdida.Equals(""))) return varMensaje = "DetIdMotPerdida: El campo motivo de perdida es requerido";
            if (varRazon.ToLower().Equals("prd") && DetPeso == 0) return varMensaje = "DetPeso: El campo peso debe ser mayor a cero";
            return varMensaje;
        }
        /// <summary>
        /// Funcion utilizada para validar el detalle de movimientos
        /// </summary>
        /// <param name="objDetalle">Detalle de movimientos de inventario</param>
        /// <param name="varRazon">Razon del movimiento de inventario</param>
        /// <param name="varReqChapetaLote">Valor si el motivo requiere chapera/lote</param>
        /// <returns></returns>
        public static string funValidarDetalle(List<clsInvMovimientoDet> objDetalle, string varRazon, bool varReqChapetaLote)
        {
            string varMensaje = "";
            var objResultado = new clsInvMovimientoDet();
            //Verificamos que no exista campos de cantidad con valor cero en el detalle
            if (varMensaje.Equals("")) {
                objResultado = objDetalle.Where(p => p.DetCantidad == 0).ToList().Count > 0 ? objDetalle.Where(p => p.DetCantidad == 0).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo cantidad no puede tener valor 0 favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que no exista campos de item en vacion en el detalle 
            if (varMensaje.Equals("")) {
                objResultado = objDetalle.Where(p => p.IteCodigo == "").ToList().Count > 0 ? objDetalle.Where(p => p.IteCodigo == "").ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo item es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si tiene razon de baja de inventario(mortalidad) tenga un motivo de perdida en el detalle
            if (varMensaje.Equals("") && varRazon.ToLower().Equals("prd")) {
                objResultado = objDetalle.Where(p => p.IdMotPerdida == null).ToList().Count > 0 ? objDetalle.Where(p => p.IdMotPerdida == null).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo motivo de perdida es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si tiene razon de baja de inventario(mortalidad) tenga un peso de mortalidad
            if (varMensaje.Equals("") && varRazon.ToLower().Equals("prd")) {
                objResultado = objDetalle.Where(p => p.DetPeso == 0).ToList().Count > 0 ? objDetalle.Where(p => p.DetPeso == 0).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo peso no puede tener valor 0 favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que si el motivo requiere Chapeta/ Lote se encuentre en todos los detalles
            if (varMensaje.Equals("") && varReqChapetaLote) {
                objResultado = objDetalle.Where(p => p.DetIdDestino == null).ToList().Count > 0 ? objDetalle.Where(p => p.DetIdDestino == null).ToList()[0] : null;
                if (objResultado != null) varMensaje = string.Format("El campo chapeta/lote es requerido favor de revisar la linea nro. {0}", objResultado.DetSecuencia);
            }
            //Verificamos que existan al menos un detalle
            if (varMensaje.Equals("") && objDetalle.Count.Equals(0)) {
                varMensaje = "No se puede guardar no existe registros del detalle";
            }
            //Verificamos si hay dos veces ingresado el mismo item con la misma chapeta/lote
            if (varMensaje.Equals("") && varReqChapetaLote) {
                var objDuplicados = objDetalle.GroupBy(p => new { p.IteCodigo, p.IteNombre, p.DetIdDestino }).Where(g => g.Count() > 1).ToList();
                if (objDuplicados.Count > 0) {
                    string varResultado = String.Join(", ", objDuplicados.Select(p => p.Key));
                    String[] varLista = varResultado.Split(',');
                    varMensaje = string.Format("El item {0} - {1} con la chapeta/lote nro. {2} se encuentra duplicado", varLista[0].Substring(varLista[0].IndexOf('=') + 2, varLista[0].Length - varLista[0].IndexOf('=') - 2),
                                                                                                                                                                                                    varLista[1].Substring(varLista[1].IndexOf('=') + 2, varLista[1].Length - varLista[1].IndexOf('=') - 2),
                                                                                                                                                                                                    varLista[2].Substring(varLista[2].IndexOf('=') + 2, varLista[2].Length - varLista[2].IndexOf('=') - 2));
                }
            }
            //Verificamos si hay dos veces ingresado el mismo item
            if (varMensaje.Equals("") && !varReqChapetaLote)
            {
                var objDuplicados = objDetalle.GroupBy(p => new { p.IteCodigo, p.IteNombre}).Where(g => g.Count() > 1).ToList();
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
        public static void proListar(int varCabCodigo, out List<clsInvMovimientoDet> objDetalle)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("dbo.proInv_MovimientoListarDetalle", varCabCodigo).ToListOf<clsInvMovimientoDet>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
       
       
        
        #endregion
    }
}
