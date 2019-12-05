using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.GestionBancos
{
    public class daoPagosEfectuados {
        private static daoPagosEfectuados objInstancia;
        private object[] objResultado = new object[2];
        public static daoPagosEfectuados getInstance() {
            if (objInstancia == null)
                objInstancia = new daoPagosEfectuados();
            return objInstancia;
        }
        public List<entOVPM> metListar() {
            try {
                List<entOVPM> objListado = new List<entOVPM>();
                entOVPM objPagoEfectuado = null;

                DateTime varFecDesde = DateTime.Now.AddDays(-3);
                DateTime varFecHasta = DateTime.Now;

                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtRegistro = csAccesoDatos.GDatos.funTraerDataTable("PAGBApagosefectuadoscomments", varFecDesde, varFecHasta);
                csAccesoDatos.proFinalizarSesion();

                foreach (DataRow drFilaCabecera in dtRegistro.Rows) {
                    objPagoEfectuado = new entOVPM();
                    objPagoEfectuado.DocEntry = int.Parse(drFilaCabecera["DocEntry"].ToString());
                    objPagoEfectuado.DocNum = int.Parse(drFilaCabecera["DocNum"].ToString());
                    objPagoEfectuado.DocDate = (DateTime)drFilaCabecera["DocDate"];
                    objPagoEfectuado.CardCode = drFilaCabecera["CardCode"].ToString();
                    objPagoEfectuado.CardName = drFilaCabecera["CardName"].ToString();
                    objPagoEfectuado.DocTotal = decimal.Parse(drFilaCabecera["Valor"].ToString());
                    objPagoEfectuado.PayType = drFilaCabecera["Tipo de pago"].ToString();
                    objPagoEfectuado.PayAccount = drFilaCabecera["Cta. Bancaria"].ToString();
                    objPagoEfectuado.CheckNum = drFilaCabecera["CounterRef"].ToString();
                    objListado.Add(objPagoEfectuado);
                }
                return objListado;
            }
            catch (Exception) { throw; }
        }
        public object[] metActualizarCommentario(int varDocEntry, string varCheckNum) {
            try
            {
                string mError = "";
                int iError = 0;

                csAccesoDatos.proIniciarSesionSAP();
                SAPbobsCOM.Payments varOVPM = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oVendorPayments);
                //Recuperamos informacion de los detalles del movimiento
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable objDetalle = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select T0.CardName, FolioNum, CounterRef From OVPM T0 inner join VPM2 T1 on T0.DocNum = T1.DocNum inner join OPCH T2 on T1.DocEntry = T2.DocEntry Where T0.DocNum = '{0}'", varDocEntry));
                csAccesoDatos.proFinalizarSesion();
                //Recorremos las lineas de detalle del extracto bancario
                int i = 0;
                String varComentario = "";
                String varMemo = "";
                String varCounterRef = "";
                foreach (DataRow objFilaDetalle in objDetalle.Rows) {
                    if (i.Equals(0)) {
                        varCounterRef = varCheckNum != "" ? varCheckNum : objFilaDetalle["CounterRef"].ToString();
                        varComentario = "CAN FAC " + objFilaDetalle["FolioNum"].ToString();
                        if (varCounterRef != "")
                            varMemo = objFilaDetalle["CardName"].ToString() + " CHQ " + varCounterRef;
                        else
                            varMemo = objFilaDetalle["CardName"].ToString() + " CAN FAC " + objFilaDetalle["FolioNum"].ToString();
                    }
                    else {
                        varComentario = varComentario + ", " + objFilaDetalle["FolioNum"].ToString();
                        if (varCounterRef.Equals(""))
                            varMemo = varMemo + ", "  + objFilaDetalle["FolioNum"].ToString();
                    }
                    i++;
                }

                varOVPM.GetByKey(varDocEntry);
                varOVPM.CounterReference = varCounterRef;
                varOVPM.JournalRemarks = varMemo.Length > 50 ? varMemo.Substring(1,50) : varMemo; 
                varOVPM.Remarks = varComentario.Length > 254 ? varComentario.Substring(1,254) : varComentario;

                iError = varOVPM.Update();

                if (!iError.Equals(0)) {
                    csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                    objResultado[0] = iError + mError;
                    objResultado[1] = "error";
                } else {
                    objResultado[0] = varDocEntry;
                    objResultado[1] = "ok";
                }
                return objResultado;
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
    }
}
