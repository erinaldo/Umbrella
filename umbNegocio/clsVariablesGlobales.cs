using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio
{
    public class clsVariablesGlobales
    {
        ////Variables utilizadas para la conexion para lectura con Db_Umbrella
        //public static string varUmbIp { get; set; }
        //public static string varUmbSociedad { get; set; }
        //public static string varUmbUsuario { get; set; }
        //public static string varUmbPassword { get; set; }

        ////Variables utilizadas para la conexion para lectura con Db_Italimentos
        //public static string varItaIp { get; set; }
        //public static string varItaSociedad { get; set; }
        //public static string varItaUsuario { get; set; }
        //public static string varItaPassword { get; set; }

        ////Variables utilizadas para la conexion para escritura en SAP Bussines One
        //public static string varSapIp { get; set; }
        //public static string varSapSociedad { get; set; }
        //public static string varSapPrgUsuario { get; set; }
        //public static string varSapPrgPassword { get; set; }
        //public static string varSapBdUsuario { get; set; }
        //public static string varSapBdPassword { get; set; }

        //Variables utilizadas para la conexion con el sistema umbrella
        public static string varCodUsuario { get; set; }
        public static string varNomUsuario { get; set; }
        public static string varIpMaquina { get; set; }

        public static bool clsANIMALRecargar { get; set; }
        public static bool clsPARTORecargar { get; set; }
        public static bool clsMOVIMIENTORecargar { get; set; }


        //public clsVariablesGlobales()
        //{
        //    //Datos para Db_Umbrella
        //    varUmbIp = "192.168.10.13";
        //    varUmbSociedad = "Db_Umbrella_PRUEBAS";
        //    varUmbUsuario = "sa";
        //    varUmbPassword = "sapbbdd0192837465.";

        //    //Datos para Db_Italimentos
        //    varItaIp = "192.168.10.13";
        //    varItaSociedad = "ITALIMENTOS CIA. LTDA.";
        //    varItaUsuario = "sa";
        //    varItaPassword = "sapbbdd0192837465.";

        //    //Datos para Sap Bussiness One
        //    varSapIp = "192.168.10.13";
        //    varSapSociedad = "PRUEBAS_MAR2018";
        //    varSapPrgUsuario = "sup1";
        //    varSapPrgPassword = "1234";
        //    varSapBdUsuario = "sa";
        //    varSapBdPassword = "sapbbdd0192837465.";
        //}
    }
}
