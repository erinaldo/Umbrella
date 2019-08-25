using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class clsLogGuiaRemisionDetTra
    {
        public int DetSecuencia { get; set; }
        public int DetNumero { get; set; }
        public string DetCodBodOrigen { get; set; }
        public string DetNomBodOrigen { get; set; }
        public string DetCodBodDestino { get; set; }
        public string DetNomBodDestino { get; set; }
        public decimal DetPeso { get; set; }
        public int DetPieza { get; set; }
        public int DetDocEntry { get; set; }
        public clsLogGuiaRemisionDetTra() { }
        /// <summary>
        /// Instanciamos a la clase detalle de transferencia
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
        public clsLogGuiaRemisionDetTra(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;

            DetNumero = 0;
            DetCodBodOrigen = "";
            DetNomBodOrigen = "";
            DetCodBodDestino = "";
            DetNomBodDestino = "";

            DetPeso = 0;
            DetPieza = 0;
            DetDocEntry = 0;
        }
        //Funcion utilizada para recuperar las transferencias del sistema SAP
        public static DataTable funRecTransferencia(int varNumero) {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("PALOGguiaremisionrectransferencia", varNumero);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        // Funcion utilizada para recuperar el detalle de transferencias ingresada a las guias
        public static void proListar(int varCabCodigo, out List<clsLogGuiaRemisionDetTra> objDetalle)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("proLog_GuiaRemisionListarTransferencia", varCabCodigo).ToListOf<clsLogGuiaRemisionDetTra>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //Funcion utilizada para recuperar las salidas del sistema SAP
        public static DataTable funRecSalida(int varNumero) {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("PALOGguiaremisionrecsalida", varNumero);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
