using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.GestionBancos
{
    public class clsGbaExtBancarioCab
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }

        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string CabDescripcion { get; set; }
        public string CabRuta { get; set; }
        public string CueCodigo { get; set; }
        public string CueNombre { get; set; }
        public string CueFormato { get; set; }
        public string EstCodigo { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsGbaExtBancarioCab> funListar(string varWhere)
        {
            try {
                List<clsGbaExtBancarioCab> objLista = new List<clsGbaExtBancarioCab>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGba_ExtBancarioListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsGbaExtBancarioCab()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static List<clsGbaExtBancarioCab> funListar(int vId)
        {
            List<clsGbaExtBancarioCab> objLista = new List<clsGbaExtBancarioCab>();
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGba_ExtBancarioListar", vId, DBNull.Value);
            csAccesoDatos.proFinalizarSesion();
            foreach (DataRow drLista in dtLista.Rows)
                objLista.Add(funRegistro(drLista, new clsGbaExtBancarioCab()));
            return objLista;
        }
        public static clsGbaExtBancarioCab funRegistro(DataRow drRegistro, clsGbaExtBancarioCab objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.CabDescripcion = drRegistro["CabDescripcion"] == System.DBNull.Value ? "" : drRegistro["CabDescripcion"].ToString();
            objRegistro.CabRuta = drRegistro["CabRuta"] == System.DBNull.Value ? "" : drRegistro["CabRuta"].ToString();
            objRegistro.CueCodigo = drRegistro["CueCodigo"] == System.DBNull.Value ? "" : drRegistro["CueCodigo"].ToString();
            objRegistro.CueNombre = drRegistro["CueNombre"] == System.DBNull.Value ? "" : drRegistro["CueNombre"].ToString();
            objRegistro.CueFormato = drRegistro["CueFormato"] == System.DBNull.Value ? "" : drRegistro["CueFormato"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(int varOperacion, List<clsGbaExtBancarioDet> objDetalles)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detExtBancario = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGba_ExtBancarioMantenimiento",  CabCodigo, DocCodigo, CabNumero, CabFecha, CabDescripcion,
                                                                                                                                                                                                            CabRuta, CueCodigo, CueNombre, CueFormato,  varOperacion, 
                                                                                                                                                                                                            clsVariablesGlobales.varCodUsuario, detExtBancario);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        private int funVerificarExtBancarioSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Count(AcctCode) From OBNK Where ExternCode =  '{0} - {1} - {2}'", varDocNombre, varCabNumero, varDetSecuencia));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static int funCuantosExtBancarioSAP(string varDocNombre, int varCabNumero)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Count(ExternCode) From OBNK Where ExternCode like '{0} - {1}%'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public string funEnviarExtBancarioSAP()
        {
            try
            {
                string mError = "";
                int iError = 0;

                csAccesoDatos.proIniciarSesionSAP();
                SAPbobsCOM.BankPages varOBNK = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBankPages);
                //Recuperamos informacion de los detalles del movimiento
                List<clsGbaExtBancarioDet> objDetalle = new List<clsGbaExtBancarioDet>();
                clsGbaExtBancarioDet.proListar(CabCodigo, out objDetalle);
                //Recorremos las lineas de detalle del extracto bancario
                foreach (clsGbaExtBancarioDet objFilaDetalle in objDetalle) {
                    if (funVerificarExtBancarioSAP(DocNombre, CabNumero, objFilaDetalle.DetSecuencia).Equals(0)) {
                        varOBNK.AccountCode = CueCodigo;
                        varOBNK.DueDate = objFilaDetalle.DetFecha;
                        varOBNK.Reference = objFilaDetalle.DetReferencia;
                        varOBNK.Memo = objFilaDetalle.DetComentario;
                        varOBNK.ExternalCode = DocNombre + " - " + CabNumero.ToString() + " - " + objFilaDetalle.DetSecuencia.ToString();
                        varOBNK.DebitAmount = double.Parse(objFilaDetalle.DetDebe.ToString());
                        varOBNK.CreditAmount = double.Parse(objFilaDetalle.DetHaber.ToString());

                        iError = varOBNK.Add();
                        if (!iError.Equals(0)) {
                            csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                            return mError;
                        }
                    }
                }
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GBA_CABEXTBANCARIO Set EstCodigo = 'Sap'  Where CabCodigo = {0}", CabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return mError;
            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
    }
}
