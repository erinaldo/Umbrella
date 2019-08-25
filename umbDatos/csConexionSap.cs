using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace umbDatos
{
    public class csConexionSap
    {
        public csConexionSap()
        {
            varServidorLicencia = ConfigurationManager.AppSettings["ServidorLicencia"];
            varServidorSap = ConfigurationManager.AppSettings["IPServidorSAP"];
            varBaseDatosSap = ConfigurationManager.AppSettings["BDSap"];
            varUsuarioSap = ConfigurationManager.AppSettings["UsuarioSociedadSap"];
            varContraseñaSap = ConfigurationManager.AppSettings["PassSociedadSap"];
            varUsuarioBD = ConfigurationManager.AppSettings["UsuarioBDSap"];
            varContraseñaBD = ConfigurationManager.AppSettings["PassBDSap"];
        }

        #region "Declaración de Variables"

        protected static string varServidorSap = "";
        protected static string varServidorLicencia = "";
        protected static string varBaseDatosSap = "";
        protected static string varUsuarioSap = "";
        protected static string varContraseñaSap = "";
        protected static string varUsuarioBD = "";
        protected static string varContraseñaBD = "";
        public static int iError = 0;
        protected static string varMensaje = "";

        public static SAPbobsCOM.Company objConexionSap;
        #endregion
        private static void swProConectarSap()
        {
            try
            {
                objConexionSap = new SAPbobsCOM.Company()
                {
                    Server = varServidorSap,
                    DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014,
                    LicenseServer = varServidorLicencia,
                    CompanyDB = varBaseDatosSap,
                    UserName = varUsuarioSap,
                    Password = varContraseñaSap,
                    
                    DbUserName = varUsuarioBD,
                    DbPassword = varContraseñaBD,
                    UseTrusted = false
                };
                iError = objConexionSap.Connect();
                if (iError != 0)
                {
                    objConexionSap.GetLastError(out iError, out varMensaje);
                    throw new Exception(varMensaje);
                }
            }
            catch (Exception) { throw; }
        }
        public void proConectarBDSap()
        {
            try
            {
                if (objConexionSap == null || !objConexionSap.Connected)
                    swProConectarSap();
            }
            catch (Exception) { throw;}
        }
        public void proDesconectarBDSap()
        {
            try
            {
                if (objConexionSap.Connected )
                    objConexionSap.Disconnect();
            }
            catch (Exception) { throw; }
        }
    }// end class gDatos
}// end namespace
