using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class clsLogCantPermitida {
        private int propId;
        private int propFacNumero;
        private int propFacLinea;
        private string propIteCodigo;
        private string propIteNombre;
        private decimal propCantPermitida;

        public clsLogCantPermitida() { }
        public clsLogCantPermitida(int varId, int varNroFactura, int varNroLinea, string varIteCodigo, string varIteNombre, decimal varCantPermitida) {
            try {
                this.propId = varId;
                this.propFacNumero = varNroFactura;
                this.propFacLinea = varNroLinea;
                this.propIteCodigo = varIteCodigo;
                this.propIteNombre = varIteNombre;
                this.propCantPermitida = varCantPermitida;

                if (this.propFacNumero <= 0)
                    throw new Exception("El nro. de la factura es requerido");
                else if (this.propFacLinea < 0)
                    throw new Exception("El nro. de la linea es requerido");
                else if (this.propIteCodigo.Equals(""))
                    throw new Exception("El item es requerido");
                else if (this.propCantPermitida <= 0)
                    throw new Exception("La cantidad permitida es requerida");
            } catch (Exception) { throw; }
        }

        public int Id {
            get { return propId; }
            set { propId = value; }
        }
        public int FacNumero {
            get { return propFacNumero; }
            set { propFacNumero = value; }
        }
        public int FacLinea {
            get { return propFacLinea; }
            set { propFacLinea = value; }
        }
        public string IteCodigo {
            get { return propIteCodigo; }
            set { propIteCodigo = value; }
        }
        public string IteNombre {
            get { return propIteNombre; }
            set { propIteNombre = value; }
        }
        public decimal CantPermitida {
            get { return propCantPermitida; }
            set { propCantPermitida = value; }
        }

        public static List<clsLogCantPermitida> metListar() {
            try {
                List<clsLogCantPermitida> objListado = new List<clsLogCantPermitida>();
                string varSql = "Select Id, FacNumero, FacLinea, IteCodigo, isnull(IteNombre, '') as IteNombre, CantPermitida From LOG_CANTPERMITIDA";
                DataTable dtRegistro = funConsulta(varSql);

                clsLogCantPermitida objRegistro = null;
                foreach (DataRow drRegisro in dtRegistro.Rows) {
                    objRegistro = new clsLogCantPermitida();
                    objRegistro.Id = int.Parse(drRegisro["Id"].ToString());
                    objRegistro.FacNumero = int.Parse(drRegisro["FacNumero"].ToString());
                    objRegistro.FacLinea = int.Parse(drRegisro["FacLinea"].ToString());
                    objRegistro.IteCodigo = drRegisro["IteCodigo"].ToString();
                    objRegistro.IteNombre = drRegisro["IteNombre"].ToString();
                    objRegistro.CantPermitida = decimal.Parse(drRegisro["CantPermitida"].ToString());
                    objListado.Add(objRegistro);
                }
                return objListado;
            } catch (Exception) { throw; }
        }
        public static clsLogCantPermitida metListarRegistro(int varRegistro) {
            try {
                clsLogCantPermitida objRegistro = new clsLogCantPermitida();
                string varSql = string.Format("Select Id, FacNumero, FacLinea, IteCodigo, isnull(IteNombre, '') as IteNombre, CantPermitida From LOG_CANTPERMITIDA Where Id = {0}", varRegistro);
                DataTable dtRegistro = funConsulta(varSql);

                if (dtRegistro.Rows.Count > 0) {
                    objRegistro.Id = int.Parse(dtRegistro.Rows[0]["Id"].ToString());
                    objRegistro.FacNumero = int.Parse(dtRegistro.Rows[0]["FacNumero"].ToString());
                    objRegistro.FacLinea = int.Parse(dtRegistro.Rows[0]["FacLinea"].ToString());
                    objRegistro.IteCodigo = dtRegistro.Rows[0]["IteCodigo"].ToString();
                    objRegistro.IteNombre = dtRegistro.Rows[0]["IteNombre"].ToString();
                    objRegistro.CantPermitida = decimal.Parse(dtRegistro.Rows[0]["CantPermitida"].ToString());
                }
                return objRegistro;
            } catch (Exception) { throw; }
        }
        public int metInsertar() {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proLog_CantPermitidaInsertar", propFacNumero, propFacLinea, propIteCodigo, 
                                                                                                                                                                                                                propIteNombre, propCantPermitida,  
                                                                                                                                                                                                                clsVariablesGlobales.varCodUsuario).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public int metModificar() {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proLog_CantPermitidaModificar", propId, propFacNumero, propFacLinea, 
                                                                                                                                                                                                                    propIteCodigo, propIteNombre, propCantPermitida,
                                                                                                                                                                                                                    clsVariablesGlobales.varCodUsuario).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public static int metEliminar(int varRegistro) {
            try{
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proLog_CantPermitidaEliminar", varRegistro).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        private static DataTable funConsulta(string varSql) {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
            csAccesoDatos.proFinalizarSesion();
            return dtResultado;
        }
    }
}
