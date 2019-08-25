using umbNegocio;
using System;
using System.Collections.Generic;
using umbDatos;

namespace umbNegocio.Inventario
{
    public class clsInvMotivo
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        /// <summary>
        /// Cuenta contable codificada
        /// </summary>
        public string OACTCode { get; set; }
        public string OACTName { get; set; }
        public string OACTFormat { get; set; }
        /// <summary>
        /// Centro de Costo
        /// </summary>
        public string ListaCenCosto { get; set; }
        /// <summary>
        /// Proyecto
        /// </summary>
        public string ListaProyecto { get; set; }
        
        public string TipoMovimiento { get; set; }
        public string ListaBodega { get; set; }
        public bool Requerido { get; set; }
        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="Operacion">1=Inserción/actualización, 3=Eliminación</param>
        /// <returns></returns>
        public int ejecutarMantenimiento(int Operacion)
        {
            //Validaciones propias del formulario
            if (Operacion.Equals(1)) {
                if (!ListaProyecto.Equals("") && !ListaCenCosto.Equals("")) throw new Exception("El tipo de movimiento no puede controlar centros de costo y proyectos a la vez");
                if (OACTName.Equals("") && !OACTFormat.Equals("")) throw new Exception("La cuenta contable seleccionada no existe");
            }
            int res = -1;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            res = csAccesoDatos.GDatos.funEjecutar("dbo.SPINV_MOTIVO",
                Id, Nombre, OACTCode, OACTName, OACTFormat, ListaCenCosto, ListaProyecto, TipoMovimiento, ListaBodega, Requerido, Operacion, clsVariablesGlobales.varCodUsuario);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        /// Devuelve una lista según el tipo de movimiento
        /// </summary>
        /// <param name="tipoMovimiento"></param>
        /// <returns></returns>
        public static List<clsInvMotivo> Listar(string tipoMovimiento)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsInvMotivo> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPINV_MOTIVOListarPorTipo", tipoMovimiento).ToListOf<clsInvMotivo>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        /// Devuelve una lista de todos los objetos registrados
        /// </summary>
        /// <returns></returns>        
        public static List<clsInvMotivo> Listar()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsInvMotivo> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPINV_MOTIVOListar", DBNull.Value).ToListOf<clsInvMotivo>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        public static List<clsInvMotivo> Cargar(int vId)
        {

            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsInvMotivo> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPINV_MOTIVOListar", vId).ToListOf<clsInvMotivo>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        #endregion
    }
}
