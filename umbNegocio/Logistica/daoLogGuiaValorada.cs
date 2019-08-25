using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    public class daoLogGuiaValorada {
        private static daoLogGuiaValorada objInstancia;

        public static daoLogGuiaValorada getInstance() {
            if (objInstancia == null)
                objInstancia = new daoLogGuiaValorada();
            return objInstancia;
        }
        public String metInsertar(clsLogGuiaValorada entTabla) {
            try {
                //Validamos los datos
                if (entTabla.AtrCabValor.Equals(0) && entTabla.AtrCabAgrupado) throw new Exception("Debe ingresar un valor mayor que cero");
                DataTable dtDetalle = new DataTable();
                dtDetalle = entTabla.AtrDetalle.ToDataTable<clsLogDetGuiaValorada>();
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaValoradaInsertar", entTabla.AtrCabFecha, entTabla.AtrCabValor, entTabla.AtrCabAgrupado, entTabla.AtrCabRuta.AtrRguCodigo, dtDetalle, clsVariablesGlobales.varCodUsuario);
                return "Ok";
            }
            catch (Exception) { throw; }
        }
        public String metModificar(clsLogGuiaValorada entTabla, int varId) {
            try {
                //Validamos los datos
                if (entTabla.AtrCabValor.Equals(0)) throw new Exception("Debe ingresar un valor mayor que cero");
                DataTable dtDetalle = new DataTable();
                dtDetalle = entTabla.AtrDetalle.ToDataTable<clsLogDetGuiaValorada>();
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaValoradaModificar", varId, entTabla.AtrCabFecha, entTabla.AtrCabValor, entTabla.AtrCabRuta.AtrRguCodigo,  dtDetalle, clsVariablesGlobales.varCodUsuario);
                return "Ok";
            }
            catch (Exception) { throw; }
        }
        public String metEliminar(int varId) {
            try {
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaValoradaEliminar", varId);
                return "Ok";
            }
            catch (Exception) { throw; }
        }
        public clsLogGuiaValorada metListar(int varId) {
            try {
                clsLogGuiaValorada objGuiaValorada = new clsLogGuiaValorada();
                List<clsLogDetGuiaValorada> objDetalle = new List<clsLogDetGuiaValorada>();

                DataTable dtRegistro = funConsulta("dbo.proLog_GuiaValoradaListar", varId);

                if (dtRegistro.Rows.Count > 0) {
                    objGuiaValorada.AtrCabCodigo = int.Parse(dtRegistro.Rows[0]["CabCodigo"].ToString());
                    objGuiaValorada.AtrCabFecha = (DateTime)dtRegistro.Rows[0]["CabFecha"];
                    objGuiaValorada.AtrCabValor = decimal.Parse(dtRegistro.Rows[0]["CabValor"].ToString());
                    objGuiaValorada.AtrCabGuias = dtRegistro.Rows[0]["CabGuias"].ToString();
                    objGuiaValorada.AtrCabRuta = daoLogRutGuia.getInstance().metListar(int.Parse(dtRegistro.Rows[0]["RguCodigo"].ToString()));

                    string varSqlDetalle = string.Format("Select DetSecuencia, DetCabGuia, DocNombre, CabNumero, b.CabFecha, ChfNombre, AyuNombre, TrnPlaca   " +
                                                                               "From LOG_DETGUIAVALORADA a inner join LOG_CABGUIAREMISION b on a.DetCabGuia = b.CabCodigo inner join SEG_DOCUMENTO c on b.DocCodigo = c.DocCodigo " +
                                                                               "Where a.CabCodigo = {0}", varId);
                    DataTable dtRegistroDetalle = funConsulta(varSqlDetalle, -1);

                    foreach (DataRow drFila in dtRegistroDetalle.Rows) 
                        objDetalle.Add(funAddDetalle(drFila));

                    objGuiaValorada.AtrDetalle = objDetalle;
                }
                return objGuiaValorada;
            }
            catch (Exception) { throw; }
        }
        public List<clsLogGuiaValorada> metListar() {
            try {
                List<clsLogGuiaValorada> objListado = new List<clsLogGuiaValorada>();
                List<clsLogDetGuiaValorada> objDetalle = new List<clsLogDetGuiaValorada>();
                clsLogGuiaValorada objGuiaValorada= null;
                
                DataTable dtRegistro = funConsulta("dbo.proLog_GuiaValoradaListar", 0);

                foreach (DataRow drFilaCabecera in dtRegistro.Rows) {
                    objGuiaValorada = new clsLogGuiaValorada();
                    objGuiaValorada.AtrCabCodigo = int.Parse(drFilaCabecera["CabCodigo"].ToString());
                    objGuiaValorada.AtrCabFecha = (DateTime)drFilaCabecera["CabFecha"];
                    objGuiaValorada.AtrCabValor = decimal.Parse(drFilaCabecera["CabValor"].ToString());
                    objGuiaValorada.AtrCabGuias = drFilaCabecera["CabGuias"].ToString();
                    objGuiaValorada.AtrCabRuta = daoLogRutGuia.getInstance().metListar(int.Parse(drFilaCabecera["RguCodigo"].ToString()));

                    string varSqlDetalle = string.Format("Select DetSecuencia, DetCabGuia, DocNombre, CabNumero, b.CabFecha, ChfNombre, AyuNombre, TrnPlaca   " +
                                                                               "From LOG_DETGUIAVALORADA a inner join LOG_CABGUIAREMISION b on a.DetCabGuia = b.CabCodigo inner join SEG_DOCUMENTO c on b.DocCodigo = c.DocCodigo " +
                                                                               "Where a.CabCodigo = {0}", objGuiaValorada.AtrCabCodigo);
                    DataTable dtRegistroDetalle = funConsulta(varSqlDetalle, -1);
                    
                    foreach (DataRow drFila in dtRegistroDetalle.Rows) 
                        objDetalle.Add(funAddDetalle(drFila));
                    
                    objGuiaValorada.AtrDetalle = objDetalle;
                    objListado.Add(objGuiaValorada);
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
       
        private static DataTable funConsulta(string varSql, int varId) { 
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtResultado = null;
            if (varId.Equals(-1))
                dtResultado = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
            else if (varId.Equals(0))
                dtResultado = csAccesoDatos.GDatos.funTraerDataTable(varSql, DBNull.Value);
            else
                dtResultado = csAccesoDatos.GDatos.funTraerDataTable(varSql, varId);
            csAccesoDatos.proFinalizarSesion();
            return dtResultado;
        }
        private static clsLogDetGuiaValorada funAddDetalle(DataRow drFila) {
            int varAtrDetSecuencia = int.Parse(drFila["DetSecuencia"].ToString());
            int varAtrDetCabGuia = int.Parse(drFila["DetCabGuia"].ToString());
            String varAtrDetDocNombre = drFila["DocNombre"].ToString();
            int varAtrDetCabNumero = int.Parse(drFila["CabNumero"].ToString());
            DateTime varAtrDetCabFecha = (DateTime)drFila["CabFecha"];
            String varAtrDetChfNombre = drFila["ChfNombre"].ToString();
            String varAtrDetAyuNombre = drFila["AyuNombre"].ToString();
            String varAtrDetTrnPlaca = drFila["TrnPlaca"].ToString();
            
            return new clsLogDetGuiaValorada(varAtrDetSecuencia, varAtrDetCabGuia, varAtrDetDocNombre, varAtrDetCabNumero, varAtrDetCabFecha, varAtrDetChfNombre, varAtrDetAyuNombre, varAtrDetTrnPlaca, 0);
        }
    }
}
