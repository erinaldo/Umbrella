using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Seguridad
{
    public class clsSegDocumento
    {
        public int DocCodigo { get; set; }
        public int DocNumInicial { get; set; }
        public int DocNumProximo { get; set; }
        public int DocCodSAPSalida { get; set; }
        public int DocCodSAPEntrada { get; set; }
        public int DocCodSAPDiario { get; set; }
        public string DocNombre { get; set; }
        public string DocDescripcion { get; set; }
        public string DocNomSAPSalida { get; set; }
        public string DocNomSAPEntrada { get; set; }
        public string DocNomSAPDiario { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsSegDocumento> funListar(string varWhere)
        {
            try{
                List<clsSegDocumento> objLista = new List<clsSegDocumento>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proSeg_DocumentoListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsSegDocumento()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception (ex.Message); }
        }
        public static List<clsSegDocumento> funListar(int varDocCodigo)
        {
            try {
                List<clsSegDocumento> objLista = new List<clsSegDocumento>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proSeg_DocumentoListar", varDocCodigo, DBNull.Value);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsSegDocumento()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        private static List<clsSegDocumento> funListarSql(string varSql)
        {
            try
            {
                List<clsSegDocumento> objLista = new List<clsSegDocumento>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegDocumento()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static clsSegDocumento funRegistro(DataRow drLista, clsSegDocumento objRegistro)
        {
            objRegistro.DocCodigo = int.Parse(drLista["DocCodigo"].ToString());
            objRegistro.DocNombre = drLista["DocNombre"].ToString();
            objRegistro.DocDescripcion = drLista["DocDescripcion"].ToString();
            objRegistro.DocNumInicial = int.Parse(drLista["DocNumInicial"].ToString());
            objRegistro.DocNumProximo = int.Parse(drLista["DocNumProximo"].ToString());
            objRegistro.DocCodSAPSalida = int.Parse(drLista["DocCodSAPSalida"].ToString());
            objRegistro.DocCodSAPEntrada = int.Parse(drLista["DocCodSAPEntrada"].ToString());
            objRegistro.DocCodSAPDiario = int.Parse(drLista["DocCodSAPDiario"].ToString());
            objRegistro.DocNomSAPSalida = drLista["DocNomSAPSalida"].ToString();
            objRegistro.DocNomSAPEntrada = drLista["DocNomSAPEntrada"].ToString();
            objRegistro.DocNomSAPDiario = drLista["DocNomSAPDiario"].ToString();
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsSegDocumento csRegistro, int varCodigo, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                object sdrProcedimiento = csAccesoDatos.GDatos.funTraerValorOutput("proSeg_Documento", csRegistro.DocCodigo, csRegistro.DocNombre, csRegistro.DocDescripcion, csRegistro.DocNumInicial, csRegistro.DocNumProximo, csRegistro.DocCodSAPSalida, csRegistro.DocCodSAPEntrada, csRegistro.DocCodSAPDiario, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, 0);
                varCodigo = int.Parse(sdrProcedimiento.ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funDocProveedor(string varTabla, string varProveedor)
        {
            try
            {
                string varSql =  string.Format("Select a.DocEntry, a.DocNum, A.DocDate, a.CardName, a.Comments From {0} a Where a.DocStatus = 'O' And a.DocType = 'I' And a.CardCode = '{1}'", varTabla, varProveedor);
                
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funDocSap()
        {
            try
            {
                const string varSql = "Select * From (Select -1 as Series, '- Ninguno' as SeriesName Union all Select Series, SeriesName From NNM1 Where SeriesName <> 'SAL_INI' and SeriesName <> 'Primario' and SeriesName <> 'Manual' ) as tabSerie Order by SeriesName";

                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static int funRecNumSerieSAPSalida(int varDocCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(DocCodSAPSalida, 0) as DocCodSAPSalida  From SEG_DOCUMENTO a Where a.DocCodigo = {0}", varDocCodigo));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception) { throw; }
        }
        public static int funRecNumSerieSAPEntrada(int varDocCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(DocCodSAPEntrada, 0) as DocCodSAPEntrada  From SEG_DOCUMENTO a Where a.DocCodigo = {0}", varDocCodigo));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception) { throw; }
        }
        public static int funRecNumSerieSAPDiario(int varDocCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(DocCodSAPDiario, 0) as DocCodSAPDiario  From SEG_DOCUMENTO a Where a.DocCodigo = {0}", varDocCodigo));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception) { throw; }
        }
    }
}
