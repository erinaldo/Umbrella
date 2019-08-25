using umbDatos.BaseDatos;
using System.Configuration;

namespace umbDatos
{
    public class csAccesoDatos
    {
        public static csConexion GDatos;
        public static csConexionSap GDatosSAP;

        /// <summary>
        /// Establece una conexión a la base de datos según los parámetros especificados.
        /// </summary>
        /// <param name="nombreServidor"></param>
        /// <param name="baseDatos"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        // JP 20151204 Soporte para ConnectionString desde archivo de configuración
        /// <summary>
        /// Crea una conexión según la cadena ConnectionString establecida en el archivo de configuración (.config)
        /// </summary>
        /// <param name="connstringName"></param>
        /// <returns></returns>
        public static bool funIniciarSesion(string connstringName)
        {
            GDatos = new csSqlServer(ConfigurationManager.ConnectionStrings[connstringName].ConnectionString);
            return GDatos.funAutenticar();
        } //fin inicializa sesion

        public static void proFinalizarSesion()
        {
            GDatos.proCerrarConexion();
        } //fin FinalizaSesion

        public static void proIniciarSesionSAP()
        {
            GDatosSAP = new csConexionSap();
            GDatosSAP.proConectarBDSap();
        }
        public static void proFinalizarSesionSAP()
        {
            GDatosSAP.proDesconectarBDSap();
        }
    }//end class util
}//end namespace