using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Seguridad
{
    public class clsSegAccFormulario
    {
        public string UsuCodigo { get; set; }
        public DataTable dtAccFormulario { get; set; }
        public DataTable dtAccDocumento { get; set; }
        public DataTable dtAccOperacion { get; set; }
        public DataTable dtAccCampo { get; set; }

        public void funMantenimiento(clsSegAccFormulario csRegistro)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            csAccesoDatos.GDatos.funEjecutar("proSeg_AccFormulario", csRegistro.UsuCodigo, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, csRegistro.dtAccFormulario, csRegistro.dtAccDocumento, csRegistro.dtAccOperacion, csRegistro.dtAccCampo);
            csAccesoDatos.proFinalizarSesion();
        }
        public static DataTable funListarDtDocumento(string varUsuario, int varFormulario)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocCodigo, b.DocNombre, b.DocDescripcion From SEG_ACCDOCUMENTO a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1}", varUsuario, varFormulario));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw;}
        }
        public static DataTable funListarDtDocumento(string varUsuario, int varFormulario, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocCodigo, b.DocNombre, b.DocDescripcion, IsNull(b.DocCodSAPSalida, 0) DocCodSAPSalida,  IsNull(b.DocCodSAPEntrada, 0) DocCodSAPEntrada,  IsNull(b.DocCodSAPDiario, 0) DocCodSAPDiario From SEG_ACCOPERACION a inner join SEG_DOCUMENTO b on a.DocCodigo = b.DocCodigo Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1} And a.OpeCodigo = {2}", varUsuario, varFormulario, varOperacion));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funListarDtOperacion(string varUsuario, int varFormulario, int varDocumento)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.OpeCodigo, b.OpeNombre From SEG_ACCOPERACION a inner join SEG_OPERACION b on a.OpeCodigo = b.OpeCodigo Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1} And a.DocCodigo = {2}", varUsuario, varFormulario, varDocumento));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static DataTable funListarDtCampo(string varUsuario, int varFormulario, int varDocumento, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.CamCodigo, b.CamNombre From SEG_ACCCAMPO a inner join SEG_CAMPO b on a.CamCodigo = b.CamCodigo Where a.UsuCodigo = '{0}' And a.FrmCodigo = {1} And a.DocCodigo = {2} And a.OpeCodigo = {3}", varUsuario, varFormulario, varDocumento, varOperacion));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        public static string funAccesoDocumento(int varCodFormulario)
        {
            try
            {
                string varDocumentos = "";

                DataTable dtDocumentos = funListarDtDocumento(clsVariablesGlobales.varCodUsuario, varCodFormulario);

                int i = 0;
                foreach (DataRow drDocumento in dtDocumentos.Rows)
                {
                    if (i.Equals(0)) varDocumentos = drDocumento["DocCodigo"].ToString();
                    else varDocumentos = string.Format("{0},{1}", varDocumentos, drDocumento["DocCodigo"].ToString());
                    i++;
                }

                return varDocumentos;
            }
            catch (Exception) { throw; }
        }
        public static int funAccesoOperacion(string varUsuario, int varFormulario, int varDocumento, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Count(*) from SEG_ACCOPERACION where UsuCodigo = '{0}' and FrmCodigo = {1} and DocCodigo = {2} and OpeCodigo = {3}", varUsuario, varFormulario, varDocumento, varOperacion)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
