using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Costos
{
    public class clsCosNormaReparto {
        private int propCcrCodigo;
        private string propCcrDescripcion;
        private string propCcrActivo;
        private string propCcoCodigo;
        private string propCcoNombre;
        private List<clsCosDetPlanCuenta> propDetPlanCuenta = new List<clsCosDetPlanCuenta>();
        private List<clsCosDetCenCosto> propDetCenCosto = new List<clsCosDetCenCosto>();

        public clsCosNormaReparto() { }
        public clsCosNormaReparto(int varCcrCodigo, string varCcrDescripcion, string varCcrActivo, string varCcoCodigo, string varCcoNombre, List<clsCosDetPlanCuenta> varDetPlanCuenta, List<clsCosDetCenCosto> varDetCenCosto) {
            try {
                propCcrCodigo = varCcrCodigo;
                propCcrDescripcion = varCcrDescripcion;
                propCcrActivo = varCcrActivo;
                propCcoCodigo = varCcoCodigo;
                propCcoNombre = varCcoNombre;
                propDetPlanCuenta = varDetPlanCuenta;
                propDetCenCosto = varDetCenCosto;

                if (propCcrDescripcion.Equals(""))
                    throw new Exception("El campo descripción es requerido");
                if (propCcoCodigo.Equals(""))
                    throw new Exception("El campo centro de costo es requerido");
                if (propDetPlanCuenta != null && propDetPlanCuenta.Count == 0)
                    throw new Exception("Debe existir al menos una linea en el detalle de plan de cuentas");
                if (propDetCenCosto != null && propDetCenCosto.Count == 0)
                    throw new Exception("Debe existir al menos una linea en el detalle de centros de costo");
                //Verificamos en la tabla de detalle centro de costo que por cada linea de la tabla detalle plan de cuentas lo siguiente
                //1. Debe existir al menos un si en el campo tomar diferencia 
                if (propDetPlanCuenta != null) {
                    foreach (clsCosDetPlanCuenta filaDetPlanCuenta in propDetPlanCuenta) {
                        int varCuantos = (from tabDetCenCosto in propDetCenCosto
                                          where tabDetCenCosto.CdpLinea == filaDetPlanCuenta.CdpLinea &&
                                                      tabDetCenCosto.CdeDiferencia == true
                                          select tabDetCenCosto.CdpLinea).Count();
                        if (varCuantos > 1 || varCuantos.Equals(0))
                            throw new Exception(string.Format("Debe existir una fila con check en la tabla centro de costo para la cuenta {0} - {1}", filaDetPlanCuenta.CccFormato, filaDetPlanCuenta.CccNombre));
                    }
                }
                //2. Validamos que cuenta del plan de cuenta este con el 100%
                if (propDetPlanCuenta != null) {
                    foreach (clsCosDetPlanCuenta filaDetPlanCuenta in propDetPlanCuenta) {
                        if (filaDetPlanCuenta.CdpPorcentaje != 100)
                            throw new Exception(string.Format("La cuenta {0} - {1} no esta cuadrado, su porcentaje debe sumar 100%", filaDetPlanCuenta.CccFormato, filaDetPlanCuenta.CccNombre));
                    }
                }
            } catch (Exception) { throw; }
        }
        public int CcrCodigo {
            get { return propCcrCodigo; }
            set { propCcrCodigo = value; }
        }
        public string CcrDescripcion {
            get { return propCcrDescripcion; }
            set { propCcrDescripcion = value; }
        }
        public string CcrActivo {
            get { return propCcrActivo; }
            set { propCcrActivo = value; }
        }
        public string CcoCodigo {
            get { return propCcoCodigo; }
            set { propCcoCodigo = value; }
        }
        public string CcoNombre
        {
            get { return propCcoNombre; }
            set { propCcoNombre = value; }
        }
        public List<clsCosDetPlanCuenta> DetPlanCuenta {
            get { return propDetPlanCuenta; }
            set { propDetPlanCuenta = value; }
        }
        public List<clsCosDetCenCosto> DetCenCosto{
            get { return propDetCenCosto; }
            set { propDetCenCosto = value; }
        }

        public int metInsertar() {
            try {
                //Eliminamos las columnas que no necesitamos de las listas
                DataTable dtPlanCuentas = DetPlanCuenta.ToDataTable();
                dtPlanCuentas.Columns.Remove("CccNombre");
                dtPlanCuentas.Columns.Remove("CccFormato");
                dtPlanCuentas.Columns.Remove("CdpPorcentaje");
                DataTable dtCenCostos = DetCenCosto.ToDataTable();
                dtCenCostos.Columns.Remove("CcoNombre");

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_NormaRepartoInsertar", propCcrDescripcion, propCcrActivo.Equals("Activo") ? true : false, propCcoCodigo, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                                                                 dtPlanCuentas, dtCenCostos).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public int metModificar() {
            try {
                //Eliminamos las columnas que no necesitamos de las listas
                DataTable dtPlanCuentas = DetPlanCuenta.ToDataTable();
                dtPlanCuentas.Columns.Remove("CccNombre");
                dtPlanCuentas.Columns.Remove("CccFormato");
                dtPlanCuentas.Columns.Remove("CdpPorcentaje");
                DataTable dtCenCostos = DetCenCosto.ToDataTable();
                dtCenCostos.Columns.Remove("CcoNombre");

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_NormaRepartoModificar", propCcrCodigo, propCcrDescripcion, propCcrActivo.Equals("Activo") ? true : false, propCcoCodigo,
                                                                                                                                                                                                                    clsVariablesGlobales.varCodUsuario, dtPlanCuentas, dtCenCostos).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public int metEliminar(int? varRegistro) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_NormaRepartoEliminar", varRegistro).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public void metConsultar(int varRegistro) {
            try {
                string varSql = "";
                DataTable dtResultado;
                //Recuperamos los datos de cabecera
                varSql = string.Format("Select CcrDescripcion, CcrActivo, CcoCodigo, PrcName as CcoNombre From COS_CABREPARTO a inner join DB_Italimentos.dbo.OPRC b on a.CcoCodigo = b.PrcCode Where CcrCodigo = {0}", varRegistro);
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow varFila in dtResultado.Rows) {
                    propCcrCodigo = varRegistro;
                    propCcrDescripcion = varFila["CcrDescripcion"].ToString();
                    propCcrActivo = bool.Parse(varFila["CcrActivo"].ToString()) ? "Activo" : "Inactivo";
                    propCcoCodigo = varFila["CcoCodigo"].ToString();
                    propCcoNombre = varFila["CcoNombre"].ToString();
                }
                //Recuperamos los datos del detalle del plan de cuenta
                propDetPlanCuenta.Clear();
                propDetPlanCuenta = clsCosDetPlanCuenta.metConsultar(varRegistro);
                //Recuperamos los datos del detalle de centros de costo
                propDetCenCosto.Clear();
                propDetCenCosto = clsCosDetCenCosto.metConsultar(varRegistro);

            } catch (Exception) { throw; }
        }
        public decimal metConsultarSaldo(String varCcoCodigo, String varCccCodigo, DateTime varFecDesde, DateTime varFecHasta){
            try {
                string varSql = "";
                decimal varSaldo = 0;
                //Recuperamos los datos de cabecera
                varSql = string.Format("Select isnull(sum(b.Debit - b.Credit), 0) as Saldo From OJDT a inner join JDT1 b on a.TransId = b.TransId Where b.OcrCode3 = '{0}' and b.Account = '{1}' and a.RefDate between '{2}' and '{3}'", varCcoCodigo, varCccCodigo, varFecDesde, varFecHasta);
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                varSaldo = (decimal)csAccesoDatos.GDatos.funTraerValorEscalarSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                return varSaldo;
            } catch (Exception) { throw; }
        }
        public List<clsCosNormaReparto> metConsultar() {
            
            //Recuperamos los datos de cabecera
            string varSql = "Select CcrCodigo, CcrDescripcion, CcrActivo, CcoCodigo, PrcName as CcoNombre From COS_CABREPARTO a inner join DB_Italimentos.dbo.OPRC b on a.CcoCodigo = b.PrcCode";
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
            csAccesoDatos.proFinalizarSesion();

            List<clsCosNormaReparto> objListado = new List<clsCosNormaReparto>();
            foreach (DataRow varFila in dtResultado.Rows) {
                objListado.Add(new clsCosNormaReparto(   int.Parse(varFila["CcrCodigo"].ToString()),
                                                                                                varFila["CcrDescripcion"].ToString(),
                                                                                                bool.Parse(varFila["CcrActivo"].ToString()) ? "Activo" : "Inactivo",
                                                                                                varFila["CcoCodigo"].ToString(),
                                                                                                varFila["CcoNombre"].ToString(),
                                                                                                null,
                                                                                                null));
            }
            return objListado;
        }
    }
    public class clsCosDetPlanCuenta {
        private int propCdpLinea;
        private string propCccCodigo;
        private string propCccNombre;
        private string propCccFormato;
        private decimal propCdpPorcentaje;
        public clsCosDetPlanCuenta() { }
        public clsCosDetPlanCuenta(int varCdpLinea, string varCccCodigo, decimal varCdpPorcentaje, string varCccNombre, string varCccFormato) {
            try {
                this.propCdpLinea = varCdpLinea;
                this.propCccCodigo = varCccCodigo;
                this.propCdpPorcentaje = varCdpPorcentaje;
                this.propCccNombre = varCccNombre;
                this.propCccFormato = varCccFormato;
                
            } catch (Exception) { throw; }
        }
        public static List<clsCosDetPlanCuenta> metConsultar(int? varRegistro) {
            try {
                string varSql = string.Format("Select CdpLinea, CccCodigo, cast(100.00 as decimal) as CdpPorcentaje, AcctName as CccNombre, FormatCode as CccFormato " +
                                                         "From COS_DETPLANCUENTA a inner join DB_Italimentos.dbo.OACT b on a.CccCodigo = b.AcctCode " +
                                                         "Where CcrCodigo = {0}", varRegistro);
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();

                List<clsCosDetPlanCuenta> objListado = new List<clsCosDetPlanCuenta>();
                foreach (DataRow varFila in dtResultado.Rows) {
                    objListado.Add(new clsCosDetPlanCuenta(
                                                                                                    int.Parse(varFila["CdpLinea"].ToString()),
                                                                                                    varFila["CccCodigo"].ToString(),
                                                                                                    decimal.Parse(varFila["CdpPorcentaje"].ToString()),
                                                                                                    varFila["CccNombre"].ToString(),
                                                                                                    varFila["CccFormato"].ToString()));
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
        public int CdpLinea {
            get { return propCdpLinea; }
            set { propCdpLinea = value; }
        }
        public string CccCodigo
        {
            get { return propCccCodigo; }
            set { propCccCodigo = value; }
        }
        public string CccNombre
        {
            get { return propCccNombre; }
            set { propCccNombre = value; }
        }
        public string CccFormato {
            get { return propCccFormato; }
            set { propCccFormato = value; }
        }
        public decimal CdpPorcentaje {
            get { return propCdpPorcentaje; }
            set { propCdpPorcentaje = value; }
        }

    }
    public class clsCosDetCenCosto {
        private int propCdpLinea;
        private int propCdeLinea;
        private string propCcoCodigo;
        private string propCcoNombre;
        private decimal propCdePorcentaje;
        private bool propCdeDiferencia;

        public clsCosDetCenCosto() { }
        public clsCosDetCenCosto(int varCdpLinea, int varCdeLinea, string varCcoCodigo, string varCcoNombre, decimal varCdePorcentaje, bool varCdeDiferencia) {
            try {
                this.propCdpLinea = varCdpLinea;
                this.propCdeLinea = varCdeLinea;
                this.propCcoCodigo = varCcoCodigo;
                this.propCcoNombre = varCcoNombre;
                this.propCdePorcentaje = varCdePorcentaje;
                this.propCdeDiferencia = varCdeDiferencia;

            } catch (Exception) { throw; }
        }
        public static List<clsCosDetCenCosto> metConsultar(int? varRegistro) {
            try
            {
                string varSql = string.Format("Select CdpLinea, CdeLinea, CcoCodigo, PrcName as CcoNombre, CdePorcentaje, CdeDiferencia " +
                                                         "From COS_DETCENCOSTO a inner join DB_Italimentos.dbo.OPRC b on a.CcoCodigo = b.PrcCode " +
                                                         "Where CcrCodigo = {0}", varRegistro);
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();

                List<clsCosDetCenCosto> objListado = new List<clsCosDetCenCosto>();
                foreach (DataRow varFila in dtResultado.Rows) {
                    objListado.Add(new clsCosDetCenCosto(
                                                                                                    int.Parse(varFila["CdpLinea"].ToString()),
                                                                                                    int.Parse(varFila["CdeLinea"].ToString()),
                                                                                                    varFila["CcoCodigo"].ToString(),
                                                                                                    varFila["CcoNombre"].ToString(),
                                                                                                    decimal.Parse(varFila["CdePorcentaje"].ToString()),
                                                                                                    bool.Parse(varFila["CdeDiferencia"].ToString())));
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
        public static List<clsCosDetCenCosto> metConsultar(int? varRegistro, int? varCdpLinea) {
            try {
                string varSql = string.Format("Select CdpLinea, CdeLinea, CcoCodigo, PrcName as CcoNombre, CdePorcentaje, CdeDiferencia " +
                                                         "From COS_DETCENCOSTO a inner join DB_Italimentos.dbo.OPRC b on a.CcoCodigo = b.PrcCode " +
                                                         "Where CcrCodigo = {0} and CdpLinea = {1}", varRegistro, varCdpLinea);
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();

                List<clsCosDetCenCosto> objListado = new List<clsCosDetCenCosto>();
                foreach (DataRow varFila in dtResultado.Rows)
                {
                    objListado.Add(new clsCosDetCenCosto(
                                                                                                    int.Parse(varFila["CdpLinea"].ToString()),
                                                                                                    int.Parse(varFila["CdeLinea"].ToString()),
                                                                                                    varFila["CcoCodigo"].ToString(),
                                                                                                    varFila["CcoNombre"].ToString(),
                                                                                                    decimal.Parse(varFila["CdePorcentaje"].ToString()),
                                                                                                    bool.Parse(varFila["CdeDiferencia"].ToString())));
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
        public int CdpLinea {
            get { return propCdpLinea; }
            set { propCdpLinea = value; }
        }
        public int CdeLinea {
            get { return propCdeLinea; }
            set { propCdeLinea = value; }
        }
        public string CcoCodigo {
            get { return propCcoCodigo; }
            set { propCcoCodigo = value; }
        }
        public string CcoNombre
        {
            get { return propCcoNombre; }
            set { propCcoNombre = value; }
        }
        public decimal CdePorcentaje {
            get { return propCdePorcentaje; }
            set { propCdePorcentaje = value; }
        }
        public bool CdeDiferencia {
            get { return propCdeDiferencia; }
            set { propCdeDiferencia = value; }
        }
    }
}
