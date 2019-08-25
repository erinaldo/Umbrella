using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Logistica
{
    /// <summary>
    /// Historial de modificaciones
    /// 1 21/11/2016 CAMC  Por petición de Klever Sempertegui se procedio a que en la guia de remision tambien se guarde el ayudante
    /// </summary>
    
    public class clsLogGuiaRemisionCab
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }

        public DateTime CabFecha { get; set; }
        public DateTime CabFecSalida { get; set; }
        public DateTime CabFecLlegada { get; set; }

        public string DocNombre { get; set; }
        public int ChfCodigo { get; set; }
        public string ChfNombre { get; set; }
        public string ChfCedula { get; set; }
        public int AyuCodigo { get; set; } //1
        public string AyuNombre { get; set; } //1
        public string AyuCedula { get; set; } //1
        public string TrnCodigo { get; set; }
        public string TrnNombre { get; set; }
        public string TrnPlaca { get; set; }
        public string TrnTipo { get; set; }
        public string CabTurno { get; set; }
        public string CabMotTraslado { get; set; }
        public string CabEstado { get; set; }
        public string UsuCodigo { get; set; }
        public string UsuNombre { get; set; }
        public string EstCodigo { get; set; }
        public string CabDocEnviado { get; set; }
        public string CabDocTxt { get; set; }
        public string CabDocEstado { get; set; }
        public string CabDocError { get; set; }
        public string CabDocAutorizacion { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsLogGuiaRemisionCab> funListar(string varWhere)
        {
            try {
                List<clsLogGuiaRemisionCab> objLista = new List<clsLogGuiaRemisionCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proLog_GuiaRemisionListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsLogGuiaRemisionCab()));
                return objLista;
            }
            catch (Exception) { throw; }
        }
        public static List<clsLogGuiaRemisionCab> funListarValorada(int varOpcion, String varDocCodigo) {
            try {
                List<clsLogGuiaRemisionCab> objLista = new List<clsLogGuiaRemisionCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proLog_GuiaRemisionListarValorada", varOpcion, varDocCodigo);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsLogGuiaRemisionCab()));
                return objLista;
            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para recuperar las entradas de mercancias por documento
        public static List<clsLogGuiaRemisionCab> funListar(int vId)
        {
            try
            {
                List<clsLogGuiaRemisionCab> objLista = new List<clsLogGuiaRemisionCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proLog_GuiaRemisionListar", vId, DBNull.Value);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsLogGuiaRemisionCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        private static clsLogGuiaRemisionCab funRegistro(DataRow drRegistro, clsLogGuiaRemisionCab objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];
            objRegistro.CabFecSalida = (DateTime)drRegistro["CabFecSalida"];
            objRegistro.CabFecLlegada = (DateTime)drRegistro["CabFecLlegada"];

            objRegistro.ChfCodigo = drRegistro["ChfCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["ChfCodigo"].ToString());
            objRegistro.ChfNombre = drRegistro["ChfNombre"] == System.DBNull.Value ? "" : drRegistro["ChfNombre"].ToString();
            objRegistro.ChfCedula = drRegistro["ChfIdentificacion"] == System.DBNull.Value ? "" : drRegistro["ChfIdentificacion"].ToString();
            objRegistro.AyuCodigo = drRegistro["AyuCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["AyuCodigo"].ToString()); //1
            objRegistro.AyuNombre = drRegistro["AyuNombre"] == System.DBNull.Value ? "" : drRegistro["AyuNombre"].ToString(); //1
            objRegistro.AyuCedula = drRegistro["AyuIdentificacion"] == System.DBNull.Value ? "" : drRegistro["AyuIdentificacion"].ToString(); //1
            objRegistro.TrnCodigo = drRegistro["TrnCodigo"] == System.DBNull.Value ? "" : drRegistro["TrnCodigo"].ToString();
            objRegistro.TrnNombre = drRegistro["TrnNombre"] == System.DBNull.Value ? "" : drRegistro["TrnNombre"].ToString();
            objRegistro.TrnPlaca = drRegistro["TrnPlaca"] == System.DBNull.Value ? "" : drRegistro["TrnPlaca"].ToString();
            objRegistro.TrnTipo = drRegistro["TrnTipo"] == System.DBNull.Value ? "" : drRegistro["TrnTipo"].ToString();
            objRegistro.CabTurno = drRegistro["CabTurno"] == System.DBNull.Value ? "" : drRegistro["CabTurno"].ToString();
            objRegistro.CabMotTraslado = drRegistro["CabMotivo"] == System.DBNull.Value ? "" : drRegistro["CabMotivo"].ToString();
            objRegistro.CabEstado = drRegistro["CabEstado"] == System.DBNull.Value ? "" : drRegistro["CabEstado"].ToString();
            objRegistro.CabDocEnviado = drRegistro["CabDocEnviado"] == System.DBNull.Value ? "" : drRegistro["CabDocEnviado"].ToString();
            objRegistro.CabDocTxt = drRegistro["CabDocTxt"] == System.DBNull.Value ? "" : drRegistro["CabDocTxt"].ToString();
            objRegistro.CabDocEstado = drRegistro["CabDocEstado"] == System.DBNull.Value ? "" : drRegistro["CabDocEstado"].ToString();
            objRegistro.CabDocError = drRegistro["CabDocError"] == System.DBNull.Value ? "" : drRegistro["CabDocError"].ToString();
            objRegistro.CabDocAutorizacion = drRegistro["CabDocAutorizacion"] == System.DBNull.Value ? "" : drRegistro["CabDocAutorizacion"].ToString();
            objRegistro.UsuCodigo = drRegistro["UsuCodigo"] == System.DBNull.Value ? "" : drRegistro["UsuCodigo"].ToString();
            objRegistro.UsuNombre = drRegistro["UsuNombre"] == System.DBNull.Value ? "" : drRegistro["UsuNombre"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        //Procedimiento utilizado para grabar la guia de remision
        public int funMantenimiento(int varOperacion, List<clsLogGuiaRemisionDetFac> objDetalleFactura, List<clsLogGuiaRemisionDetTra> objDetalleTransferencia)
        {
            try
            {
                //Validaciones propias del formulario
                if (CabFecSalida > CabFecLlegada) throw new Exception("La fecha de salida no puede ser mayor a la fecha de llegada");
                DataTable DetGuiaFactura = null;
                DataTable DetGuiaTransferencia = null;
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                if (CabMotTraslado.Equals("V")) DetGuiaFactura = objDetalleFactura.ToDataTable();
                if (CabMotTraslado.Equals("T") || 
                        CabMotTraslado.Equals("C") ||
                        CabMotTraslado.Equals("I") ||
                        CabMotTraslado.Equals("R"))  DetGuiaTransferencia = objDetalleTransferencia.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaRemisionMantenimiento", CabCodigo, DocCodigo, CabNumero, CabFecha, CabFecSalida, CabFecLlegada,
                                                                                                                                                                                              ChfCodigo, ChfNombre, ChfCedula, 
                                                                                                                                                                                              AyuCodigo, AyuNombre, AyuCedula, //1
                                                                                                                                                                                              TrnCodigo, TrnNombre, TrnPlaca,
                                                                                                                                                                                              TrnTipo, CabTurno, CabMotTraslado, CabEstado, CabDocEnviado, CabDocTxt,
                                                                                                                                                                                              CabDocEstado, CabDocError, CabDocAutorizacion, "0", "I", UsuCodigo, UsuNombre, 
                                                                                                                                                                                              varOperacion, clsVariablesGlobales.varCodUsuario, DetGuiaFactura, DetGuiaTransferencia);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        } 
        //Procedimiento utilizado para actualizar las facturas eliminadas en la guian en el sistema SAP
        public void proActFacturasSAP(List<int> lstEliminados)
        {
            try
            {
                string mError = "";
                int iError = 0;

                csAccesoDatos.proIniciarSesionSAP();

                SAPbobsCOM.Documents varOINV = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices);
                foreach (int filEliminado in lstEliminados)
                {
                    varOINV.GetByKey(filEliminado);
                    varOINV.UserFields.Fields.Item("U_NUM_GUIA").Value = "";
                     iError = varOINV.Update();
                    if (!iError.Equals(0))
                    {
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                    }
                }
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Procedimiento utilizado para anular los registros de guias de remision
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de guia remision interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaRemisionAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para cerrar los registros de guias de remision
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de guia remision interno</param>
        public static void proCerrar(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaRemisionCerrar", varCabCodigo, "Cer", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para activar o inactivar los registros de guias de remision
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de guia remision interno</param>
        public static void proEstado(int varCabCodigo, string varCabEstado)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proLog_GuiaRemisionEstado", varCabCodigo, varCabEstado, clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }


}
