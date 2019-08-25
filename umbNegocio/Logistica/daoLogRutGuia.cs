using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica {
    public class daoLogRutGuia {
        private static daoLogRutGuia objInstancia;
        public static daoLogRutGuia getInstance() {
            if (objInstancia == null)
                objInstancia = new daoLogRutGuia();
            return objInstancia;
        }
        public clsLogRutGuia metListar(int varId) {
            try {
                clsLogRutGuia objRegistro = null;

                string varSql = string.Format("Select RguCodigo, RguNombre From LOG_RUTGUIA Where RguCodigo = {0}", varId);
                DataTable dtRegistro = funConsulta(varSql);

                foreach (DataRow drFila in dtRegistro.Rows) {
                    objRegistro = new clsLogRutGuia();
                    objRegistro.AtrRguCodigo = int.Parse(drFila["RguCodigo"].ToString());
                    objRegistro.AtrRguNombre = drFila["RguNombre"].ToString();
                }
                return objRegistro;
            }
            catch (Exception) { throw; }
        }
        public List<clsLogRutGuia> metListar() {
            try {
                List<clsLogRutGuia> objListado = new List<clsLogRutGuia>();
                clsLogRutGuia objRegistro = null;

                string varSql = "Select RguCodigo, RguNombre From LOG_RUTGUIA";
                DataTable dtRegistro = funConsulta(varSql);

                foreach (DataRow drFila in dtRegistro.Rows) {
                    objRegistro = new clsLogRutGuia();
                    objRegistro.AtrRguCodigo = int.Parse(drFila["RguCodigo"].ToString());
                    objRegistro.AtrRguNombre = drFila["RguNombre"].ToString();
                    
                    objListado.Add(objRegistro);
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
        private static DataTable funConsulta(string varSql) {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
            csAccesoDatos.proFinalizarSesion();
            return dtResultado;
        }
    }
}
