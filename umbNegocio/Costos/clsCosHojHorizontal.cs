using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Costos
{
    public class clsCosHojHorizontal
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }

        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string CabDescripcion { get; set; }
        public string CabObservacion { get; set; }
        public string EstCodigo { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public DataTable DetHojCstHorizontal { get; set; }

        public List<clsCosHojHorizontal> funListar(string varWhere)
        {
            try
            {
                string varSql = string.Format("Select a.CabCodigo, a.DocCodigo, b.DocNombre, a.CabNumero, a.CabFecha, a.CabDescripcion, a.CabObservacion, a.EstCodigo, " +
                                                                    "a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica   " +
                                                                    "From COS_CABHOJAHOR a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo {0}", varWhere);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private List<clsCosHojHorizontal> funListarSql(string varSql)
        {
            try
            {
                List<clsCosHojHorizontal> objLista = new List<clsCosHojHorizontal>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsCosHojHorizontal()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }
        public clsCosHojHorizontal funRegistro(DataRow drRegistro, clsCosHojHorizontal objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.CabDescripcion = drRegistro["CabDescripcion"] == System.DBNull.Value ? "" : drRegistro["CabDescripcion"].ToString();
            objRegistro.CabObservacion = drRegistro["CabObservacion"] == System.DBNull.Value ? "" : drRegistro["CabObservacion"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public string funEnviarPreciosSAP(DataTable dtPrecios)
        {
            try
            {
                string mError = "";
                int iError = 0;
                
                csAccesoDatos.proIniciarSesionSAP();
                SAPbobsCOM.Items varOITM = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);
                
                foreach (DataRow drPrecios in dtPrecios.Rows)
                {
                    if (varOITM.GetByKey(drPrecios["IteCodigo"].ToString()))
                    {
                        for (int p = 0; p < varOITM.PriceList.Count; p++)
                        {
                            varOITM.PriceList.SetCurrentLine(p);
                            if (varOITM.PriceList.PriceList == int.Parse(drPrecios["LisPrecio"].ToString()))
                            {
                                varOITM.PriceList.Price = double.Parse(drPrecios["ItePrecio"].ToString());
                                break;
                            }
                        }
                        iError = varOITM.Update();
                        if (!iError.Equals(0)) 
                        {
                            csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                            return mError;
                        }
                    }
                }
                return mError;

            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        public string funEnviarCostosSAP(DataTable dtPrecios)
        {
            try
            {
                string mError = "";
                int iError = 0;

                csAccesoDatos.proIniciarSesionSAP();
                SAPbobsCOM.Items varOITM = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);

                foreach (DataRow drPrecios in dtPrecios.Rows)
                {
                    if (varOITM.GetByKey(drPrecios["IteCodigo"].ToString()))
                    {
                        varOITM.UserFields.Fields.Item("U_Ita_cstReferencial").Value = double.Parse(drPrecios["ItePrecio"].ToString());
                        iError = varOITM.Update();
                        if (!iError.Equals(0))
                        {
                            csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                            return mError;
                        }
                    }
                }
                return mError;

            }
            catch (Exception) { throw; }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        public int funMantenimiento(clsCosHojHorizontal csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCos_HojHorizontal", csRegistro.CabCodigo, csRegistro.DocCodigo, csRegistro.CabNumero,
                                                                                                                                                                                    csRegistro.CabFecha,  csRegistro.CabDescripcion, csRegistro.CabObservacion, 
                                                                                                                                                                                    csRegistro.EstCodigo, varOperacion, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                                    csRegistro.DetHojCstHorizontal);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
