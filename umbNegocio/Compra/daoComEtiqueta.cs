using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using umbNegocio.Entidades;

namespace umbNegocio.Compra
{
    public class daoComEtiqueta {
        private static daoComEtiqueta objInstancia;
        private object[] objResultado = new object[2];
        public daoComEtiqueta() { } //Implementación del constructor
        public static daoComEtiqueta getInstance() {
            //Implementación del método getInstance
            if (objInstancia == null)
                objInstancia = new daoComEtiqueta();
            return objInstancia;
        }
        public DataTable funImprimirEtiqueta15X10(string varIteCodigo, string varLote, string varFecha, string varLeyenda1, string varLeyenda2, string varLeyenda3, string varCantidad) {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtEtiqueta = csAccesoDatos.GDatos.funTraerDataTable("proCBA_Etiqueta1Impresion", varIteCodigo, varLote, varFecha, varLeyenda1, varLeyenda2, varCantidad, varLeyenda3, "", "", "");
            csAccesoDatos.proFinalizarSesion();
            return dtEtiqueta;
        }
    }
}
