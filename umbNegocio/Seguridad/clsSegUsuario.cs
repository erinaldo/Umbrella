using umbDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Seguridad
{
    public class clsSegUsuario
    {
        public string UsuCodigo { get; set; }
        public string UsuNombre { get; set; }
        public int EmpCodigo { get; set; }
        public string UsuMail { get; set; }
        public string UsuTelefono { get; set; }
        public string UsuIdDispositivo { get; set; }
        public int ScrCodigo { get; set; }
        public int DepCodigo { get; set; }
        public string UsuPassword { get; set; }
        public string UsuConfirmar { get; set; }
        public bool UsuVence { get; set; }
        public bool UsuModificar { get; set; }
        public bool UsuBloqueo { get; set; }
        public bool UsuMovil { get; set; }
        public string EstCodigo { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsSegUsuario> funListar()
        {
            try
            {
                const string varSql = "Select UsuCodigo, UsuNombre, EmpCodigo, UsuMail, UsuTelefono, UsuIdDispositivo, ScrCodigo, DepCodigo, UsuPassword, UsuVence, UsuModificar, UsuBloqueo, UsuMovil, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica FROM dbo.SEG_USUARIO";
                return funListarSql(varSql, 0);
            }
            catch (Exception) { throw; }
        }
        public static List<clsSegUsuario> funListar(string varUsuCodigo)
        {
            try
            {
                string varSql = string.Format("Select UsuCodigo, UsuNombre, EmpCodigo, UsuMail, UsuTelefono, UsuIdDispositivo, ScrCodigo, DepCodigo, UsuPassword, UsuVence, UsuModificar, UsuBloqueo, UsuMovil, UsuCrea, UsuFechaCrea, UsuModifica, UsuFechaModifica From dbo.SEG_USUARIO Where UsuCodigo = '{0}'", varUsuCodigo);
                return funListarSql(varSql, 0);
            }
            catch (Exception) { throw; }
        }
        private static List<clsSegUsuario> funListarSql(string varSql, int varOpcion)
        {
            try
            {
                List<clsSegUsuario> objLista = new List<clsSegUsuario>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegUsuario(), varOpcion));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<clsSegUsuario> funListarSAP()
        {
            const string varSql = "Select USER_CODE as UsuCodigo, U_NAME as UsuNombre From OUSR a Where Locked = 'N'  And Department = 8 Order by a.U_NAME";
            return funListarSqlSAP(varSql, 1);
        }
        public static List<clsSegUsuario> funListarUsuSAP(string varUsuario)
        {
            string varSql = string.Format("Select USER_CODE as UsuCodigo, U_NAME as UsuNombre From OUSR a Where a.USER_CODE = '{0}'", varUsuario);
            return funListarSqlSAP(varSql, 1);
        }
        private static List<clsSegUsuario> funListarSqlSAP(string varSql, int varOpcion)
        {
            try
            {
                List<clsSegUsuario> objLista = new List<clsSegUsuario>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegUsuario(), varOpcion));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static clsSegUsuario funRegistro(DataRow drLista, clsSegUsuario objRegistro, int varOpcion)
        {
            objRegistro.UsuCodigo = drLista["UsuCodigo"].ToString();
            objRegistro.UsuNombre = drLista["UsuNombre"].ToString();
            if (varOpcion.Equals(0))
            {
                objRegistro.EmpCodigo = drLista["EmpCodigo"] == DBNull.Value ? 0 : int.Parse(drLista["EmpCodigo"].ToString());
                objRegistro.UsuMail = drLista["UsuMail"].ToString();
                objRegistro.UsuTelefono = drLista["UsuTelefono"].ToString();
                objRegistro.UsuIdDispositivo = drLista["UsuIdDispositivo"].ToString();
                objRegistro.ScrCodigo = drLista["ScrCodigo"] == DBNull.Value ? 0 : int.Parse(drLista["ScrCodigo"].ToString());
                objRegistro.DepCodigo = drLista["DepCodigo"] == DBNull.Value ? 0 : int.Parse(drLista["DepCodigo"].ToString());
                objRegistro.UsuPassword = drLista["UsuPassword"].ToString();
                objRegistro.UsuVence = (bool)drLista["UsuVence"];
                objRegistro.UsuModificar = (bool)drLista["UsuModificar"];
                objRegistro.UsuBloqueo = (bool)drLista["UsuBloqueo"];
                objRegistro.UsuMovil = (bool)drLista["UsuMovil"];
                objRegistro.UsuCrea = drLista["UsuCrea"].ToString();
                objRegistro.UsuFechaCrea = (DateTime)drLista["UsuFechaCrea"];
                objRegistro.UsuCrea = drLista["UsuModifica"].ToString();
                objRegistro.UsuFechaModifica = (DateTime)drLista["UsuFechaModifica"];
            }
            return objRegistro;
        }
        public static int funUsuVerificar(string varUsuario, string varContrasena) //Funcion utilizada para verificar si el usuario tiene acceso al sistema umbrella
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDbUmbrella");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proSeg_UsuarioLogeo", varUsuario, varContrasena);
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception) { throw; }
        }

        public void funMantenimiento(clsSegUsuario csRegistro, int varOperacion)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            csAccesoDatos.GDatos.funEjecutar("proSeg_Usuario", csRegistro.UsuCodigo, csRegistro.UsuNombre, csRegistro.EmpCodigo, csRegistro.UsuMail, 
                                                                                                                csRegistro.UsuTelefono, csRegistro.UsuIdDispositivo, csRegistro.ScrCodigo, csRegistro.DepCodigo,
                                                                                                                csRegistro.UsuPassword, csRegistro.UsuVence, csRegistro.UsuModificar, csRegistro.UsuBloqueo, 
                                                                                                                csRegistro.UsuMovil, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina);
            csAccesoDatos.proFinalizarSesion();
        }

    }
}
