using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Compra
{
    public class clsComCodigoBarraRep {
        #region Propiedades
        public string DocNombre { get; set; }
        public int CabNumero { get; set; }
        public DateTime CabFecha { get; set; }
        public string PrvCodigo { get; set; }
        public string PrvNombre { get; set; }
        public int DetSecuencia { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public int DetPiezas { get; set; }
        public string DetLote { get; set; }
        public decimal DetCantidad { get; set; }
        public string DetUndMedida { get; set; }
        public int DetNro { get; set; }
        #endregion

        public static List<clsComCodigoBarraRep> proListarEntMercanciaCompra(int varDocNum) {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                List<clsComCodigoBarraRep> objDetalle = new List<clsComCodigoBarraRep>();
                objDetalle = csAccesoDatos.GDatos.funTraerDataTable("PACOMentmercaderias", varDocNum).ToListOf<clsComCodigoBarraRep>();
                csAccesoDatos.proFinalizarSesion();

                return objDetalle;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        //Procedimiento almacenado utilizado para grabar las entradas de mercancia por compras
        public static int funMantenimiento(string varDocNombre, int varCabNumero, DateTime varCabFecha, string varPrvCodigo, string varPrvNombre, string varIteCodigo, string varIteNombre, string varDetLote, decimal varDetCantidad)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                 int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proBPM_CodigoBarrasMantenimiento",  varDocNombre, varCabNumero, varCabFecha, varPrvCodigo, varPrvNombre, varIteCodigo, varIteNombre, varDetLote, varDetCantidad);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
