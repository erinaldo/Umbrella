using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class clsLogGuiaRemisionDetFac
    {
        public int DetSecuencia { get; set; }
        public int DetFactura { get; set; }
        public string DetCodCliente { get; set; }
        public string DetNomCliente { get; set; }
        public decimal DetCredito { get; set; }
        public decimal DetContado { get; set; }
        public decimal DetPeso { get; set; }
        public int DetDocEntry { get; set; }

         public clsLogGuiaRemisionDetFac(){}
        /// <summary>
        /// Instanciamos a la clase detalle de factura
        /// </summary>
        /// <param name="varDetLinea">Nro de secuencia actual</param>
         public clsLogGuiaRemisionDetFac(int varDetLinea)
        {
            DetSecuencia = varDetLinea + 1;
            
            DetFactura = 0;
            DetCodCliente = "";
            DetNomCliente = "";
            
            DetCredito = 0;
            DetContado = 0;
            DetPeso = 0;
            DetDocEntry = 0;
        }
        // Funcion utilizada para recuperar la factura del sistema SAP
        public static DataTable funRecFactura(int varNroFactura)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("PALOGguiaremisionrecfactura", varNroFactura);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para recuperar las transferencias del sistema SAP
        public static DataTable funRecFacturaSAP(int varNroGuia)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("PALOGguiaremisionrecguia", varNroGuia);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        // Funcion utilizada para recuperar el detalle de facturas ingresada a las guias
        public static void proListar(int? varCabCodigo, out List<clsLogGuiaRemisionDetFac> objDetalle)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("proLog_GuiaRemisionListarFacturas", varCabCodigo).ToListOf<clsLogGuiaRemisionDetFac>();
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception ex) { throw new Exception (ex.Message); }
        }


    }
}
