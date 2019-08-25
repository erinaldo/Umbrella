using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Seguridad
{
    public class clsSegCampo
    {
        public int CamCodigo { get; set; }
        public string CamNombre { get; set; }
        public bool CamRequerido { get; set; }
        public string CamError { get; set; }
        public string CamTipo { get; set; }
        public int FrmCodigo { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public List<clsSegCampo> funListar(int varFrmCodigo)
        {
            try
            {
                string varSql = string.Format("Select CamCodigo,  CamNombre, CamRequerido, CamError, CamTipo,  FrmCodigo, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_CAMPO Where FrmCodigo = {0}", varFrmCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public List<clsSegCampo> funListar(int varFrmCodigo, int varCamCodigo)
        {
            try
            {
                string varSql = string.Format("Select CamCodigo,  CamNombre, CamRequerido, CamError, CamTipo, FrmCodigo, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_CAMPO Where CamCodigo = {0} And FrmCodigo = {1}", varCamCodigo, varFrmCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private List<clsSegCampo> funListarSql(string varSql)
        {
            try
            {
                List<clsSegCampo> objLista = new List<clsSegCampo>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegCampo()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public clsSegCampo funRegistro(DataRow drLista, clsSegCampo objRegistro)
        {
            objRegistro.CamCodigo = int.Parse(drLista["CamCodigo"].ToString());
            objRegistro.CamNombre = drLista["CamNombre"].ToString();
            objRegistro.CamRequerido = (bool)drLista["CamRequerido"];
            objRegistro.CamError = drLista["CamError"].ToString();
            objRegistro.CamTipo = drLista["CamTipo"].ToString();
            objRegistro.FrmCodigo = int.Parse(drLista["FrmCodigo"].ToString());
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsSegCampo csRegistro, int varCodigo, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                object sdrProcedimiento = csAccesoDatos.GDatos.funTraerValorOutput("proSeg_Campo", csRegistro.CamCodigo, csRegistro.CamNombre, csRegistro.CamRequerido, csRegistro.CamError, csRegistro.CamTipo, csRegistro.FrmCodigo, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, 0);
                varCodigo = int.Parse(sdrProcedimiento.ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
