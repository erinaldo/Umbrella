using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Seguridad
{
    public class clsSegFormulario
    {
        public int FrmCodigo { get; set; }
        public string FrmRuta { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsSegFormulario> funListar()
        {
            try
            {
                const string varSql = "Select FrmCodigo,  FrmRuta, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_FORMULARIO";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsSegFormulario> funListar(int varForCodigo)
        {
            try
            {
                string varSql = string.Format("Select FrmCodigo,  FrmRuta, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_FORMULARIO Where FrmCodigo = {0}", varForCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsSegFormulario> funListar(string varForRuta)
        {
            try
            {
                string varSql = string.Format("Select FrmCodigo,  FrmRuta, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_FORMULARIO Where FrmRuta = '{0}'", varForRuta);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsSegFormulario> funListarSql(string varSql)
        {
            try
            {
                List<clsSegFormulario> objLista = new List<clsSegFormulario>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegFormulario()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static clsSegFormulario funRegistro(DataRow drLista, clsSegFormulario objRegistro)
        {
            objRegistro.FrmCodigo = int.Parse(drLista["FrmCodigo"].ToString());
            objRegistro.FrmRuta = drLista["FrmRuta"].ToString();
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea =  drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"]; 

            return objRegistro;
        }
        public int funMantenimiento(clsSegFormulario csRegistro, int varCodigo, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                object sdrProcedimiento = csAccesoDatos.GDatos.funTraerValorOutput("proSeg_Formulario", csRegistro.FrmCodigo, csRegistro.FrmRuta, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, 0);
                varCodigo = int.Parse(sdrProcedimiento.ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }

    }
}
