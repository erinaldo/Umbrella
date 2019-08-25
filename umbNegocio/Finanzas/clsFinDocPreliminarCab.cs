using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Finanzas
{
    public class clsFinDocPreliminarCab
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }

        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string CabRuta { get; set; }
        public string CabComentario { get; set; }
        public string CabReferencia1 { get; set; }
        public string CabReferencia2 { get; set; }
        public string EstCodigo { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsFinDocPreliminarCab> funListar(string varWhere)
        {
            try
            {
                List<clsFinDocPreliminarCab> objLista = new List<clsFinDocPreliminarCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proFin_DocPreliminarListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsFinDocPreliminarCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static List<clsFinDocPreliminarCab> funListar(int vId)
        {
            try {
                List<clsFinDocPreliminarCab> objLista = new List<clsFinDocPreliminarCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proFin_DocPreliminarListar", vId, DBNull.Value);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsFinDocPreliminarCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static clsFinDocPreliminarCab funRegistro(DataRow drRegistro, clsFinDocPreliminarCab objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.CabComentario = drRegistro["CabComentario"] == System.DBNull.Value ? "" : drRegistro["CabComentario"].ToString();
            objRegistro.CabReferencia1 = drRegistro["CabReferencia1"] == System.DBNull.Value ? "" : drRegistro["CabReferencia1"].ToString();
            objRegistro.CabReferencia2 = drRegistro["CabReferencia2"] == System.DBNull.Value ? "" : drRegistro["CabReferencia2"].ToString();
            objRegistro.CabRuta = drRegistro["CabRuta"] == System.DBNull.Value ? "" : drRegistro["CabRuta"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(int varOperacion, List<clsFinDocPreliminarDet> objDetalles)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detDocPreliminar = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proFin_DocPreliminarMantenimiento", CabCodigo, DocCodigo, CabNumero, CabFecha, CabComentario, CabReferencia1,
                                                                                                                                                                                                             CabReferencia2, CabRuta, EstCodigo, varOperacion, clsVariablesGlobales.varCodUsuario, 
                                                                                                                                                                                                             detDocPreliminar);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funVerificarDocPreliminarSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtDocPreliminar = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.TransId, a.BatchNum From OBTF a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtDocPreliminar;
            }
            catch (Exception) { throw; }
        }
        public string funEnviarDocPreliminarSAP()
        {
            try
            {
                string mError = "";
                int iError = 0;
                int i = 0;

                csAccesoDatos.proIniciarSesionSAP();
                DataTable objDtVerificarSAP = funVerificarDocPreliminarSAP(DocNombre, CabNumero);
                if (objDtVerificarSAP.Rows.Count > 0) {
                    //Actualizacion en el formulario de movimientos de inventario
                    int DocEntrySAPDiario = int.Parse(objDtVerificarSAP.Rows[0]["TransId"].ToString());
                    int NumeroSAPDiario = int.Parse(objDtVerificarSAP.Rows[0]["BatchNum"].ToString());
                    csAccesoDatos.funIniciarSesion("conDBUmbrella");
                    csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update FIN_CABDOCPRELIMINAR Set CabSap = {0}, EstCodigo = 'Sap'  Where DocCodigo = {1} and CabNumero = {2}", DocEntrySAPDiario, DocCodigo, CabNumero));
                    csAccesoDatos.proFinalizarSesion();
                    return mError;
                }
                else
                {
                    SAPbobsCOM.JournalVouchers varOBTF = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalVouchers);

                    varOBTF.JournalEntries.ReferenceDate = (DateTime)CabFecha;
                    varOBTF.JournalEntries.DueDate = (DateTime)CabFecha;
                    varOBTF.JournalEntries.TaxDate = (DateTime)CabFecha;
                    varOBTF.JournalEntries.Memo = CabComentario;
                    varOBTF.JournalEntries.Reference = CabReferencia1;
                    varOBTF.JournalEntries.Reference2 = CabReferencia2;
                    varOBTF.JournalEntries.Reference3 = DocNombre + " - " + CabNumero.ToString();
                    varOBTF.JournalEntries.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                    varOBTF.JournalEntries.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    varOBTF.JournalEntries.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;
                    varOBTF.JournalEntries.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre;
                    varOBTF.JournalEntries.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString();
                    //Recuperamos informacion de los detalles del movimiento
                    List<clsFinDocPreliminarDet> objDetalle = new List<clsFinDocPreliminarDet>();
                    clsFinDocPreliminarDet.proListar(CabCodigo, out objDetalle);

                    foreach (clsFinDocPreliminarDet objFilaDetalle in objDetalle) {
                        if (!i.Equals(0)) varOBTF.JournalEntries.Lines.Add();
                        varOBTF.JournalEntries.Lines.SetCurrentLine(i);
                        i++;
                        varOBTF.JournalEntries.Lines.AccountCode = objFilaDetalle.CueCodigo;
                        varOBTF.JournalEntries.Lines.Debit = double.Parse(objFilaDetalle.DetDebe.ToString());
                        varOBTF.JournalEntries.Lines.Credit = double.Parse(objFilaDetalle.DetHaber.ToString());
                        varOBTF.JournalEntries.Lines.LineMemo = objFilaDetalle.DetComentario;
                        varOBTF.JournalEntries.Lines.Reference1 = objFilaDetalle.DetReferencia1;
                        varOBTF.JournalEntries.Lines.Reference2 = objFilaDetalle.DetReferencia2;
                        varOBTF.JournalEntries.Lines.ReferenceDate2 = CabFecha;
                        varOBTF.JournalEntries.Lines.CostingCode = objFilaDetalle.CcoCodigo.Equals("") ? "" : objFilaDetalle.CcoCodigo.ToString().Substring(0, 2);
                        varOBTF.JournalEntries.Lines.CostingCode2 = objFilaDetalle.CcoCodigo.ToString().Equals("") ? "" : objFilaDetalle.CcoCodigo.ToString().Substring(0, 3);
                        varOBTF.JournalEntries.Lines.CostingCode3 = objFilaDetalle.CcoCodigo.ToString().Equals("") ? "" : objFilaDetalle.CcoCodigo.ToString().Substring(0, 4);
                        varOBTF.JournalEntries.Lines.TaxDate = CabFecha;
                        varOBTF.JournalEntries.Lines.DueDate = CabFecha;
                    }
                    iError = varOBTF.Add();
                    if (!iError.Equals(0)) {
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                        return mError;
                    }
                    else
                    {
                        int varCabEntrySap = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varCabEntrySap);
                       
                        csAccesoDatos.funIniciarSesion("conDBUmbrella");
                        csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update FIN_CABDOCPRELIMINAR Set CabSap = {0}, EstCodigo = 'Sap'  Where DocCodigo = {1} and CabNumero = {2}", varCabEntrySap, DocCodigo, CabNumero));
                        csAccesoDatos.proFinalizarSesion();
                    }
                    return mError;
                }
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Procedimiento utilizado para anular los registros de documento preliminar
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de laboratorio interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proFin_DocPreliminarAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
