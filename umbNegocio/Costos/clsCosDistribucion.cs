using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using System.Web.Script.Serialization;

namespace umbNegocio.Costos
{
    public class clsCosDistribucion {
        private int propCabCodigo;
        private int propDocCodigo;
        private String propDocNombre;
        private int propCabNumero;
        private DateTime propCabFecha;
        private DateTime propCabFechaDesde;
        private DateTime propCabFechaHasta;
        private String propCabComentario;
        private String propCabReferencia1;
        private String propCabReferencia2;
        private int propCabNroSap;
        private List<clsCosDetDistribucion> propDetDistribucion = new List<clsCosDetDistribucion>();
        //Métodos get y set
        public int CabCodigo {
            get { return propCabCodigo; }
            set { propCabCodigo = value; }
        }
        public int DocCodigo {
            get { return propDocCodigo; }
            set { propDocCodigo = value; }
        }
        public string DocNombre {
            get { return propDocNombre; }
            set { propDocNombre = value; }
        }
        public int CabNumero {
            get { return propCabNumero; }
            set { propCabNumero = value; }
        }
        public DateTime CabFecha {
            get { return propCabFecha; }
            set { propCabFecha = value; }
        }
        public DateTime CabFechaDesde {
            get { return propCabFechaDesde; }
            set { propCabFechaDesde = value; }
        }
        public DateTime CabFechaHasta {
            get { return propCabFechaHasta; }
            set { propCabFechaHasta = value; }
        }
        public String CabComentario {
            get { return propCabComentario; }
            set { propCabComentario = value; }
        }
        public String CabReferencia1 {
            get { return propCabReferencia1; }
            set { propCabReferencia1 = value; }
        }
        public String CabReferencia2 {
            get { return propCabReferencia2; }
            set { propCabReferencia2 = value; }
        }
        public int CabNroSap {
            get { return propCabNroSap; }
            set { propCabNroSap = value; }
        }
        public List<clsCosDetDistribucion> DetDistribucion {
            get { return propDetDistribucion; }
            set { propDetDistribucion = value; }
        }
        public clsCosDistribucion() { }
        public clsCosDistribucion(int varCabCodigo, int varDocCodigo, String varDocNombre, int varCabNumero, DateTime varCabFecha, DateTime varCabFechaDesde, DateTime varCabFechaHasta,
                                                        String varCabComentario, String varCabReferencia1, String varCabReferencia2, int varCabNroSap, List<clsCosDetDistribucion> varDetDistribucion) {
            this.propCabCodigo = varCabCodigo;
            this.propDocCodigo = varDocCodigo;
            this.propDocNombre = varDocNombre;
            this.propCabNumero = varCabNumero;
            this.propCabFecha = varCabFecha;
            this.propCabFechaDesde = varCabFechaDesde;
            this.propCabFechaHasta = varCabFechaHasta;
            this.propCabComentario = varCabComentario;
            this.propCabReferencia1 = varCabReferencia1;
            this.propCabReferencia2 = varCabReferencia2;
            this.propCabNroSap = varCabNroSap;
            this.propDetDistribucion = varDetDistribucion;
        }
        public void metValidarDatos() {
            try {
                if (propCabFecha.Equals("") || propCabFecha == null)
                    throw new Exception("El campo fecha es requerido");
                if (propCabComentario.Equals(""))
                    throw new Exception("El campo comentario es requerido");
                if (propDetDistribucion != null && propDetDistribucion.Count == 0)
                    throw new Exception("Debe existir al menos una linea en el detalle de plan de cuentas");

                //Verificamos en la tabla de detalle centro de costo que por cada linea de la tabla detalle plan de cuentas lo siguiente
                //1. Debe existir al menos un si en el campo tomar diferencia 
                if (propDetDistribucion != null) {
                    decimal varSaldoDebe = propDetDistribucion.Sum(p => p.DetDebe);
                    decimal varSaldoHaber = propDetDistribucion.Sum(p => p.DetHaber);
                    if (varSaldoDebe != varSaldoHaber)
                        throw new Exception("El asiento generado no se encuentra cuadrado entre el valor del debe y haber");
                }
            } catch (Exception) { throw; }
        }
        public int metInsertar() {
            try {
                //Eliminamos las columnas que no necesitamos de las listas
                DataTable dtDistribucion = propDetDistribucion.ToDataTable();
                dtDistribucion.Columns.Remove("CccNombre");
                dtDistribucion.Columns.Remove("CccFormato");
                dtDistribucion.Columns.Remove("CcoNombre");

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_DistribucionInsertar", propDocCodigo, propCabFecha, propCabFechaDesde, propCabFechaHasta, propCabComentario,
                                                                                                                                                                                                             propCabReferencia1, propCabReferencia2, clsVariablesGlobales.varCodUsuario, dtDistribucion).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            }
            catch (Exception) { throw; }
        }
        public int metModificar() {
            try {
                //Eliminamos las columnas que no necesitamos de las listas
                DataTable dtDistribucion = propDetDistribucion.ToDataTable();
                dtDistribucion.Columns.Remove("CccNombre");
                dtDistribucion.Columns.Remove("CccFormato");
                dtDistribucion.Columns.Remove("CcoNombre");

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_DistribucionModificar", propCabCodigo, propCabFecha, propCabFechaDesde, propCabFechaHasta, propCabComentario,
                                                                                                                                                                                                                 propCabReferencia1, propCabReferencia2, clsVariablesGlobales.varCodUsuario, dtDistribucion).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            }
            catch (Exception) { throw; }
        }
        public int metEliminar() {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalar("proCos_DistribucionEliminar", propCabCodigo, propDocNombre, propCabNumero).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varResultado;
            } catch (Exception) { throw; }
        }
        public int metModificarNroSAP(int varDocCodigo, String varDocNombre, int varCabNumero) {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                int varResultado = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select isnull(max(BatchNum), 0) as Numero From OBTF Where U_Ita_sysdocumento = '{0}' and U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero)).ToString());
                csAccesoDatos.proFinalizarSesion();
                if (varResultado > 0) {
                    csAccesoDatos.funIniciarSesion("conDBUmbrella");
                    csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Update COS_CABDISTRIBUCION set CabNroSap = {2} Where DocCodigo = {0} and CabNumero = {1}", varDocCodigo, varCabNumero, varResultado));
                    csAccesoDatos.proFinalizarSesion();
                }
                return varResultado;
            }
            catch (Exception) { throw; }
        }
        public void metConsultar(int varRegistro) {
            try {
                string varSql = "";
                DataTable dtResultado;
                //Recuperamos los datos de cabecera
                varSql = string.Format("Select CabCodigo, a.DocCodigo, DocNombre, CabNumero, CabFecha, CabFechaDesde, CabFechaHasta, CabComentario, CabReferencia1, CabReferencia2, CabNroSap  From COS_CABDISTRIBUCION a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo Where CabCodigo = {0}", varRegistro);
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow varFila in dtResultado.Rows) {
                    propCabCodigo = varRegistro;
                    propDocCodigo = int.Parse(varFila["DocCodigo"].ToString());
                    propDocNombre = varFila["DocNombre"].ToString();
                    propCabNumero = int.Parse(varFila["CabNumero"].ToString());
                    propCabFecha = DateTime.Parse(varFila["CabFecha"].ToString());
                    propCabFechaDesde = DateTime.Parse(varFila["CabFechaDesde"].ToString());
                    propCabFechaHasta = DateTime.Parse(varFila["CabFechaHasta"].ToString());
                    propCabComentario = varFila["CabComentario"].ToString();
                    propCabReferencia1 = varFila["CabReferencia1"].ToString();
                    propCabReferencia2 = varFila["CabReferencia2"].ToString();
                    propCabNroSap = int.Parse(varFila["CabNroSap"].ToString());
                }
                //Recuperamos los datos del detalle del plan de cuenta
                propDetDistribucion.Clear();
                propDetDistribucion = clsCosDetDistribucion.metConsultar(varRegistro);
            }
            catch (Exception) { throw; }
        }
        public List<clsCosDistribucion> metConsultar(string varWhere) {

            //Recuperamos los datos de cabecera
            string varSql = string.Format("Select CabCodigo, a.DocCodigo, DocNombre, CabNumero, CabFecha, CabFechaDesde, CabFechaHasta, CabComentario, CabReferencia1, CabReferencia2, CabNroSap  From COS_CABDISTRIBUCION a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo {0} order by a.CabFecha desc", varWhere);
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
            csAccesoDatos.proFinalizarSesion();

            List<clsCosDistribucion> objListado = new List<clsCosDistribucion>();
            foreach (DataRow varFila in dtResultado.Rows) {
                objListado.Add(new clsCosDistribucion(
                                                                                            int.Parse(varFila["CabCodigo"].ToString()),
                                                                                            int.Parse(varFila["DocCodigo"].ToString()),
                                                                                            varFila["DocNombre"].ToString(),
                                                                                            int.Parse(varFila["CabNumero"].ToString()),
                                                                                            DateTime.Parse(varFila["CabFecha"].ToString()),
                                                                                            DateTime.Parse(varFila["CabFechaDesde"].ToString()),
                                                                                            DateTime.Parse(varFila["CabFechaHasta"].ToString()),
                                                                                            varFila["CabComentario"].ToString(),
                                                                                            varFila["CabReferencia1"].ToString(),
                                                                                            varFila["CabReferencia2"].ToString(),
                                                                                            int.Parse(varFila["CabNroSap"].ToString()),
                                                                                            null));
            }
            return objListado;
        }
        public int metEnviarDocumentoSAP() {
            try {
                int varNroSAP = metModificarNroSAP(propDocCodigo, propDocNombre, propCabNumero);
                if (varNroSAP.Equals(0)) {
                    swSAPDIAPI.clsJournalVouchers objDiario = new swSAPDIAPI.clsJournalVouchers();
                    objDiario.ReferenceDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                    objDiario.DueDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                    objDiario.TaxDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                    objDiario.Memo = "S-" + propCabComentario;
                    objDiario.Reference = "S-" + propCabReferencia1;
                    objDiario.Reference2 = "S-" + propCabReferencia2;
                    objDiario.Reference3 = "N-";
                    objDiario.CodUsuario = "S-" + clsVariablesGlobales.varCodUsuario;
                    objDiario.Fecha = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                    objDiario.Ip = "S-" + clsVariablesGlobales.varIpMaquina;
                    objDiario.Documento = "S-" + propDocNombre;
                    objDiario.Numero = "S-" + propCabNumero;
                    List<swSAPDIAPI.clsJournalVouchersDet> objDetalle = new List<swSAPDIAPI.clsJournalVouchersDet>();
                    foreach (clsCosDetDistribucion varFilaDistribucion in propDetDistribucion) {
                        swSAPDIAPI.clsJournalVouchersDet objDetalleDiario = new swSAPDIAPI.clsJournalVouchersDet();
                        objDetalleDiario.AccountCode = "S-" + varFilaDistribucion.CccCodigo;
                        objDetalleDiario.Debit = "S-" + varFilaDistribucion.DetDebe.ToString();
                        objDetalleDiario.Credit = "S-" + varFilaDistribucion.DetHaber.ToString();
                        objDetalleDiario.LineMemo = "S-" + propCabComentario;
                        objDetalleDiario.Reference1 = "S-" + propCabReferencia1;
                        objDetalleDiario.Reference2 = "S-" + propCabReferencia2;
                        objDetalleDiario.ReferenceDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                        objDetalleDiario.DueDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                        objDetalleDiario.TaxDate = "S-" + String.Format("{0:yyyy/MM/dd}", propCabFecha);
                        objDetalleDiario.CostingCode = "S-" + varFilaDistribucion.CcoCodigo.Substring(0, 2);
                        objDetalleDiario.CostingCode2 = "S-" + varFilaDistribucion.CcoCodigo.Substring(0, 3);
                        objDetalleDiario.CostingCode3 = "S-" + varFilaDistribucion.CcoCodigo;
                        objDetalle.Add(objDetalleDiario);
                    }
                    objDiario.JournalVouchersDet = objDetalle.ToArray();

                    swSAPDIAPI.Service wsServicio = new swSAPDIAPI.Service();
                    String varResultadoSAP = wsServicio.metWSInsertarJournalVouchers(new JavaScriptSerializer().Serialize(objDiario));
                    if (varResultadoSAP.Equals("ok")) {
                        int varNumeroSAP = metModificarNroSAP(propDocCodigo, propDocNombre, propCabNumero);
                        return varNumeroSAP;
                    }
                    else
                        return 0;
                }
                return varNroSAP;
            } catch (Exception) { throw; }
        }
    }
    public class clsCosDetDistribucion {
        private int propDetSecuencia;
        private int propCcrCodigo;
        private int propCdpLinea;
        private int propCdeLinea;
        private String propCccCodigo;
        private String propCccNombre;
        private String propCccFormato;
        private String propCcoCodigo;
        private String propCcoNombre;
        private decimal propDetDebe;
        private decimal propDetHaber;
        private decimal propDetPorcentaje;
        //Métodos get y set
        public int DetSecuencia {
            get { return propDetSecuencia; }
            set { propDetSecuencia = value; }
        }
        public int CcrCodigo {
            get { return propCcrCodigo; }
            set { propCcrCodigo = value; }
        }
        public int CdpLinea {
            get { return propCdpLinea; }
            set { propCdpLinea = value; }
        }
        public int CdeLinea {
            get { return propCdeLinea; }
            set { propCdeLinea = value; }
        }
        public String CccCodigo {
            get { return propCccCodigo; }
            set { propCccCodigo = value; }
        }
        public String CccNombre {
            get { return propCccNombre; }
            set { propCccNombre = value; }
        }
        public String CccFormato {
            get { return propCccFormato; }
            set { propCccFormato = value; }
        }
        public String CcoCodigo {
            get { return propCcoCodigo; }
            set { propCcoCodigo = value; }
        }
        public String CcoNombre {
            get { return propCcoNombre; }
            set { propCcoNombre = value; }
        }
        public decimal DetDebe {
            get { return propDetDebe; }
            set { propDetDebe = value; }
        }
        public decimal DetHaber {
            get { return propDetHaber; }
            set { propDetHaber = value; }
        }
        public decimal DetPorcentaje {
            get { return propDetPorcentaje; }
            set { propDetPorcentaje = value; }
        }
        public clsCosDetDistribucion() { }
        public clsCosDetDistribucion(int varDetSecuencia, int varCcrCodigo, int varCdpLinea, int varCdeLinea, String varCccCodigo, String varCccNombre, String varCccFormato,
                                                             String varCcoCodigo, String varCcoNombre, decimal varDetDebe, decimal varDetHaber, decimal varDetPorcentaje) {
            this.propDetSecuencia = varDetSecuencia;
            this.propCcrCodigo = varCcrCodigo;
            this.propCdpLinea = varCdpLinea;
            this.propCdeLinea = varCdeLinea;
            this.propCccCodigo = varCccCodigo;
            this.propCccNombre = varCccNombre;
            this.propCccFormato = varCccFormato;
            this.propCcoCodigo = varCcoCodigo;
            this.propCcoNombre = varCcoNombre;
            this.propDetDebe = varDetDebe;
            this.propDetHaber = varDetHaber;
            this.propDetPorcentaje = varDetPorcentaje;
        }
        public static List<clsCosDetDistribucion> metConsultar(int? varRegistro) {
            try {
                string varSql = string.Format("Select DetSecuencia, CcrCodigo, CdpLinea, CdeLinea, CccCodigo, AcctName as CccNombre, FormatCode as CccFormato, CcoCodigo, PrcName as CcoNombre, DetDebe, DetHaber, DetPorcentaje " +
                                                                    "From COS_DETDISTRIBUCION a inner join DB_Italimentos.dbo.OACT b on a.CccCodigo = b.AcctCode inner join DB_Italimentos.dbo.OPRC c on a.CcoCodigo = c.PrcCode " +
                                                                    "Where CabCodigo = {0}", varRegistro);

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();

                List<clsCosDetDistribucion> objListado = new List<clsCosDetDistribucion>();
                foreach (DataRow varFila in dtResultado.Rows) {
                    objListado.Add(new clsCosDetDistribucion(
                                                                                                    int.Parse(varFila["DetSecuencia"].ToString()),
                                                                                                    int.Parse(varFila["CcrCodigo"].ToString()),
                                                                                                    int.Parse(varFila["CdpLinea"].ToString()),
                                                                                                    int.Parse(varFila["CdeLinea"].ToString()),
                                                                                                    varFila["CccCodigo"].ToString(),
                                                                                                    varFila["CccNombre"].ToString(),
                                                                                                    varFila["CccFormato"].ToString(),
                                                                                                    varFila["CcoCodigo"].ToString(),
                                                                                                    varFila["CcoNombre"].ToString(),
                                                                                                    decimal.Parse(varFila["DetDebe"].ToString()),
                                                                                                    decimal.Parse(varFila["DetHaber"].ToString()),
                                                                                                    decimal.Parse(varFila["DetPorcentaje"].ToString())));
                }
                return objListado;
            } catch (Exception) { throw; }
        }
    }
}
