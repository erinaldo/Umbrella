using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Costos
{
    public class clsCosHojVertical
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int CabCodigoFrm { get; set; }
        public int CabPrecosteo { get; set; }
        public int EscCodigo { get; set; }
        public int CabTipoCosto { get; set; }

        public DateTime CabFecha { get; set; }

        public string EscNombre { get; set; }
        public string DocNombre { get; set; }
        public string CabVarianteFrm { get; set; }
        public string CabNomPrecosteo { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteNueCodigo { get; set; }
        public string IteNueNombre { get; set; }
        public string CabObservacion { get; set; }
        public bool CabRuta { get; set; }
        public string EstCodigo { get; set; }

        public decimal CabTotMatPrima { get; set; }
        public decimal CabTotEmpPrimario { get; set; }
        public decimal CabTotEmpSecundario { get; set; }
        public decimal CabTotProcesosMOD { get; set; }
        public decimal CabTotGstIndFabricacion { get; set; }
        public decimal CabTotCstProduccion { get; set; }
        public decimal CabTotGstAdmVta { get; set; }
        public decimal CabTotCstKilo { get; set; }
        public decimal CabTotCstPresentacion { get; set; }
        public decimal CabTotPrcBase { get; set; }
        public decimal CabTotPrcSugPVD { get; set; }
        public decimal CabTotPrcSugPVP { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public DataTable DetHojCstVertical { get; set; }

        public static List<clsCosHojVertical> funListar(string varWhere)
        {
            try
            {
                string varSql = string.Format("Select a.CabCodigo, a.DocCodigo, d.DocNombre, CabNumero, a.CabCodigoFrm, a.CabVarianteFrm, a.CabFecha, a.CabPrecosteo, b.Descripcion as CabNomPrecosteo, " +
                                                                    "    a.EscCodigo, IsNull(c.CabNombre, 'ESCENARIO ACTUAL') as EscNombre, a.IteCodigo, a.IteNombre, a.IteNueCodigo, a.IteNueNombre, a.CabTipoCosto," +
                                                                    "    a.CabTotMatPrima, a.CabTotEmpPrimario, a.CabTotEmpSecundario, a.CabTotProcesosMOD, a.CabTotGstIndFabricacion, a.CabTotCstProduccion," +
                                                                    "    a.CabTotGstAdmVta, a.CabTotCstKilo, a.CabTotCstPresentacion, a.CabTotPrcBase, a.CabTotPrcSugPVD, a.CabTotPrcSugPVP, a.CabObservacion, " +
                                                                    "    a.EstCodigo, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica" +
                                                                    " From COS_CABHOJAVER a inner join GEN_DICCIONARIO b on a.CabPrecosteo = b.Codigo and b.Tipo = 'PRECOSTEO' " +
                                                                    "  inner join SEG_DOCUMENTO d on a.DocCodigo = d.DocCodigo" +
                                                                    "  left join COS_CABESCENARIO c on a.EscCodigo = c.EstCodigo {0}", varWhere);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsCosHojVertical> funListarSql(string varSql)
        {
            try
            {
                List<clsCosHojVertical> objLista = new List<clsCosHojVertical>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsCosHojVertical()));
                }
                return objLista;
            }
            catch (Exception) { throw; }
        }
        public static clsCosHojVertical funRegistro(DataRow drRegistro, clsCosHojVertical objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());
            objRegistro.CabCodigoFrm = drRegistro["CabCodigoFrm"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigoFrm"].ToString());
            objRegistro.CabVarianteFrm = drRegistro["CabVarianteFrm"] == System.DBNull.Value ? "" : drRegistro["CabVarianteFrm"].ToString();
            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];
            objRegistro.CabPrecosteo = drRegistro["CabPrecosteo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabPrecosteo"].ToString());
            objRegistro.CabNomPrecosteo = drRegistro["CabNomPrecosteo"] == System.DBNull.Value ? "" : drRegistro["CabNomPrecosteo"].ToString();
            objRegistro.EscCodigo = drRegistro["EscCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["EscCodigo"].ToString());
            objRegistro.EscNombre = drRegistro["EscNombre"] == System.DBNull.Value ? "" : drRegistro["EscNombre"].ToString();
            objRegistro.IteCodigo = drRegistro["IteCodigo"] == System.DBNull.Value ? "" : drRegistro["IteCodigo"].ToString();
            objRegistro.IteNombre = drRegistro["IteNombre"] == System.DBNull.Value ? "" : drRegistro["IteNombre"].ToString();
            objRegistro.IteNueCodigo = drRegistro["IteNueCodigo"] == System.DBNull.Value ? "" : drRegistro["IteNueCodigo"].ToString();
            objRegistro.IteNueNombre = drRegistro["IteNueNombre"] == System.DBNull.Value ? "" : drRegistro["IteNueNombre"].ToString();
            objRegistro.CabTipoCosto = drRegistro["CabTipoCosto"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabTipoCosto"].ToString());

            objRegistro.CabTotMatPrima = drRegistro["CabTotMatPrima"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotMatPrima"].ToString());
            objRegistro.CabTotEmpPrimario = drRegistro["CabTotEmpPrimario"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotEmpPrimario"].ToString());
            objRegistro.CabTotEmpSecundario = drRegistro["CabTotEmpSecundario"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotEmpSecundario"].ToString());
            objRegistro.CabTotProcesosMOD = drRegistro["CabTotProcesosMOD"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotProcesosMOD"].ToString());
            objRegistro.CabTotGstIndFabricacion = drRegistro["CabTotGstIndFabricacion"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotGstIndFabricacion"].ToString());
            objRegistro.CabTotCstProduccion = drRegistro["CabTotCstProduccion"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotCstProduccion"].ToString());
            objRegistro.CabTotGstAdmVta = drRegistro["CabTotGstAdmVta"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotGstAdmVta"].ToString());
            objRegistro.CabTotCstKilo = drRegistro["CabTotCstKilo"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotCstKilo"].ToString());
            objRegistro.CabTotCstPresentacion = drRegistro["CabTotCstPresentacion"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotCstPresentacion"].ToString());
            objRegistro.CabTotPrcBase = drRegistro["CabTotPrcBase"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotPrcBase"].ToString());
            objRegistro.CabTotPrcSugPVD = drRegistro["CabTotPrcSugPVD"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotPrcSugPVD"].ToString());
            objRegistro.CabTotPrcSugPVP = drRegistro["CabTotPrcSugPVP"] == System.DBNull.Value ? 0 : decimal.Parse(drRegistro["CabTotPrcSugPVP"].ToString());

            objRegistro.CabObservacion = drRegistro["CabObservacion"] == System.DBNull.Value ? "" : drRegistro["CabObservacion"].ToString();
            objRegistro.CabRuta = drRegistro["CabRuta"] == System.DBNull.Value ? true : (bool)drRegistro["CabRuta"];
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuModifica = drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsCosHojVertical csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCos_HojVertical", csRegistro.CabCodigo, csRegistro.DocCodigo, csRegistro.CabNumero,
                                                                                                                                                                                    csRegistro.CabCodigoFrm, csRegistro.CabVarianteFrm, csRegistro.CabFecha, csRegistro.CabPrecosteo, 
                                                                                                                                                                                    csRegistro.EscCodigo,  csRegistro.IteCodigo, csRegistro.IteNombre, csRegistro.IteNueCodigo, 
                                                                                                                                                                                    csRegistro.IteNueNombre, csRegistro.CabTipoCosto, csRegistro.CabTotMatPrima, csRegistro.CabTotEmpPrimario,
                                                                                                                                                                                    csRegistro.CabTotEmpSecundario, csRegistro.CabTotProcesosMOD, csRegistro.CabTotGstIndFabricacion,
                                                                                                                                                                                    csRegistro.CabTotCstProduccion, csRegistro.CabTotGstAdmVta, csRegistro.CabTotCstKilo, 
                                                                                                                                                                                    csRegistro.CabTotCstPresentacion, csRegistro.CabTotPrcBase, csRegistro.CabTotPrcSugPVD, 
                                                                                                                                                                                    csRegistro.CabTotPrcSugPVP, csRegistro.CabObservacion, csRegistro.CabRuta, csRegistro.EstCodigo, varOperacion,
                                                                                                                                                                                    clsVariablesGlobales.varCodUsuario, csRegistro.DetHojCstVertical);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }

        public static DataTable funListarHojVertical(string parWhere)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecuencia, DetPadre, GpiCodigo, Upper(GpiNombre) as GpiNombre, IteCodigo, Upper(IteNombre) as IteNombre, IteUndInventario, " +
                                                                                                                                                              "DetMerma, DetCantEmp, DetCantidad, DetCosto, DetTotal, IsNull(DetPorcentaje, 0) as DetPorcentaje, IsNull(DetOrden, 0) as DetTipo, " +
                                                                                                                                                              "IsNull(DetColor, '') " +
                                                                                                                                                    "From COS_DETHOJAVER a " +
                                                                                                                                                    "{0}", parWhere));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
    }
}
