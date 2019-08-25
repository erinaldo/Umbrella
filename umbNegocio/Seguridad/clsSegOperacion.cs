using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Seguridad
{
    public class clsSegOperacion
    {
        public int OpeCodigo { get; set; }
        public string OpeNombre { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public List<clsSegOperacion> funListar()
        {
            try
            {
                const string varSql = "Select OpeCodigo,  OpeNombre, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_OPERACION";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public List<clsSegOperacion> funListar(int varOpeCodigo)
        {
            try
            {
                string varSql = string.Format("Select OpeCodigo,  OpeNombre, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From SEG_OPERACION Where OpeCodigo = {0}", varOpeCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private List<clsSegOperacion> funListarSql(string varSql)
        {
            try
            {
                List<clsSegOperacion> objLista = new List<clsSegOperacion>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegOperacion()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public clsSegOperacion funRegistro(DataRow drLista, clsSegOperacion objRegistro)
        {
            objRegistro.OpeCodigo = int.Parse(drLista["OpeCodigo"].ToString());
            objRegistro.OpeNombre = drLista["OpeNombre"].ToString();
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea =  drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"]; 

            return objRegistro;
        }
        public int funMantenimiento(clsSegOperacion csRegistro, int varCodigo, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                object sdrProcedimiento = csAccesoDatos.GDatos.funTraerValorOutput("proSeg_Operacion", csRegistro.OpeCodigo, csRegistro.OpeNombre, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, 0);
                varCodigo = int.Parse(sdrProcedimiento.ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }

    }
}
