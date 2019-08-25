using System;
using System.Data;
using System.Data.SqlClient;

namespace umbDatos.BaseDatos
{
    public class csSqlServer : csConexion
    {
        /*
         * Continuaremos con el método Comando, procediendo de igual forma que en los anteriores. 
         * En este caso, además, implementaremos un mecanismo de “preservación” de los Comandos creados,
         * para acelerar su utilización. Esto es, cada procedimiento que sea accedido, se guardará 
         * en memoria hasta que la instancia del objeto se destruya. Para ello, declararemos una variable 
         * como HashTable para la clase, con el modificador Shared (compartida) que permite 
         * persistir la misma entre creaciones de objetos
         */
        static readonly System.Collections.Hashtable ColComandos = new System.Collections.Hashtable();

        //public override sealed string CadenaConexion
        //{
        //    get
        //    {
        //        if (varCadenaConexion.Length == 0)
        //        {
        //            if (varBaseDatos.Length != 0 && varServidor.Length != 0)
        //            {
        //                var sCadena = new System.Text.StringBuilder("");
        //                sCadena.Append("data source=<SERVIDOR>;");
        //                sCadena.Append("initial catalog=<BASE>;");
        //                sCadena.Append("user id=<USER>;");
        //                sCadena.Append("password=<PASSWORD>;");
        //                sCadena.Append("persist security info=True;");
        //                sCadena.Append("user id=sa;packet size=4096");
        //                sCadena.Replace("<SERVIDOR>", Servidor);
        //                sCadena.Replace("<BASE>", BaseDatos);
        //                sCadena.Replace("<USER>", Usuario);
        //                sCadena.Replace("<PASSWORD>", Contraseña);

        //                return sCadena.ToString();
        //            }
        //            throw new Exception("No se puede establecer la cadena de conexión en la clase DatosSQLServer");
        //        }
        //        return varCadenaConexion = CadenaConexion;

        //    }// end get
        //    set
        //    { varCadenaConexion = value; } // end set
        //}// end CadenaConexion
        /*	
         * Agregue ahora la definición del procedimiento CargarParametros, el cual deberá asignar cada valor 
         * al parámetro que corresponda (considerando que, en el caso de SQLServer©, el parameter 0 
         * siempre corresponde al “return Value” del Procedimiento Almacenado). Por otra parte, en algunos casos,
         * como la ejecución de procedimientos almacenados que devuelven un valor como parámetro de salida, 
         * la cantidad de elementos en el vector de argumentos, puede no corresponder con la cantidad de parámetros. 
         * Por ello, se decide comparar el indicador con la cantidad de argumentos recibidos, antes de asignar el valor.
         * protected override void CargarParametros(System.Data.IDbCommand Com, System.Object[] Args)
         */
        protected override void proCargarParametros(System.Data.IDbCommand com, Object[] args)
        {
            //string[] lstNomEstructura = new string[4];
            //int[] lstPosEstructura = new int[4];
            //int p = 0;
            //for (int i = 1; i < com.Parameters.Count; i++)
            //{
            //    var t = (System.Data.SqlClient.SqlParameterCollection)com.Parameters;

            //    if (t[i].ParameterName.Contains("@det"))
            //    {
            //        lstNomEstructura[p] = t[i].ParameterName;
            //        lstPosEstructura[p] = i;

            //        p++;
            //    }
            //    else t[i].Value = (i <= args.Length ? args[i - 1] ?? DBNull.Value : null);


            //} // end for
            //for (int q = 0; q <= lstNomEstructura.Length - 1; q++)
            //{
            //    if (!(lstNomEstructura[q] == null))
            //    {
            //        var t = (System.Data.SqlClient.SqlParameterCollection)com.Parameters;
            //        t.Remove(t[lstPosEstructura[0]]);
            //        t.AddWithValue(lstNomEstructura[q], args[lstPosEstructura[q] - 1]);
            //    }
            //}
            int i = 0;
            foreach (SqlParameter objParametro in com.Parameters) {
                if (objParametro.Direction != ParameterDirection.ReturnValue) {
                    objParametro.SqlValue = args[i];
                    if (objParametro.SqlDbType == SqlDbType.Structured) objParametro.TypeName = "";
                    i++;
                }
            }
        } // end CargarParametros


        /*
         * En el procedimiento Comando, se buscará primero si ya existe el comando en dicha Hashtable para retornarla 
         * (convertida en el tipo correcto). Caso contrario, se procederá a la creación del mismo, 
         * y su agregado en el repositorio. Dado que cabe la posibilidad de que ya estemos dentro de una transacción,
         * es necesario abrir una segunda conexión a la base de datos, para obtener la definición de los parámetros 
         * del procedimiento Almacenado (caso contrario da error, por intentar leer sin tener asignado el
         * objeto Transaction correspondiente). Además, el comando, obtenido por cualquiera de los mecanismos 
         * debe recibir la conexión y la transacción correspondientes (si no hay Transacción, la variable es null, 
         * y ese es el valor que se le pasa al objeto Command)
         */
        protected override System.Data.IDbCommand idbComando(string varProcedimientoAlmacenado)
        {
            System.Data.SqlClient.SqlCommand com;
            if (ColComandos.Contains(varProcedimientoAlmacenado))
                com = (System.Data.SqlClient.SqlCommand)ColComandos[varProcedimientoAlmacenado];
            else
            {
                var con2 = new System.Data.SqlClient.SqlConnection(CadenaConexion);
                con2.Open();
                com = new System.Data.SqlClient.SqlCommand(varProcedimientoAlmacenado, con2) { CommandType = System.Data.CommandType.StoredProcedure };
                System.Data.SqlClient.SqlCommandBuilder.DeriveParameters(com);
                con2.Close();
                con2.Dispose();
                ColComandos.Add(varProcedimientoAlmacenado, com);
            }//end else
            com.Connection = (System.Data.SqlClient.SqlConnection)idbConexion;
            com.Transaction = (System.Data.SqlClient.SqlTransaction)idbTransaccion;
            return com;
        }// end Comando
        protected override System.Data.IDbCommand idbComandoSql(string varComandoSql)
        {
            var com = new System.Data.SqlClient.SqlCommand(varComandoSql, (System.Data.SqlClient.SqlConnection)idbConexion, (System.Data.SqlClient.SqlTransaction)idbTransaccion);
            return com;
        }// end Comando


        /* 
         * Luego implementaremos CrearConexion, donde simplemente se devuelve una nueva instancia del 
         * objeto Conexión de SqlClient, utilizando la cadena de conexión del objeto.
         */
        protected override System.Data.IDbConnection idbCrearConexion(string varCadenaConexion)
        { return new System.Data.SqlClient.SqlConnection(varCadenaConexion); }
        //Finalmente, es el turno de definir CrearDataAdapter, el cual aprovecha el método Comando para crear el comando necesario.
        protected override System.Data.IDataAdapter idaCrearDataAdapter(string varProcedimientoAlmacenado, params Object[] args)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)idbComando(varProcedimientoAlmacenado));
            if (args.Length != 0)
                proCargarParametros(da.SelectCommand, args);
            return da;
        } // end CrearDataAdapter
        //Finalmente, es el turno de definir CrearDataAdapter, el cual aprovecha el método Comando para crear el comando necesario.
        protected override System.Data.IDataAdapter idaCrearDataAdapterSql(string varComandoSql)
        {
            var da = new System.Data.SqlClient.SqlDataAdapter((System.Data.SqlClient.SqlCommand)idbComandoSql(varComandoSql));
            return da;
        } // end CrearDataAdapterSql

        /*
         * Definiremos dos constructores especializados, uno que reciba como argumentos los valores de Nombre del Servidor 
         * y de base de datos que son necesarios para acceder a datos, y otro que admita directamente la cadena de conexión completa.
         * Los constructores se definen como procedimientos públicos de nombre New.
         */
        public csSqlServer()
        {
            BaseDatos = "";
            Servidor = "";
            Usuario = "";
            Contraseña = "";
        }// end DatosSQLServer
        public csSqlServer(string vCadenaConexion)
        {
            CadenaConexion = vCadenaConexion;
        }// end DatosSQLServer

        public csSqlServer(string vServidor, string vBase)
        {
            BaseDatos = vBase;
            Servidor = vServidor;
        }// end DatosSQLServer
        public csSqlServer(string vServidor, string vBase, string vUsuario, string vContraseña)
        {
            BaseDatos = vBase;
            Servidor = vServidor;
            Usuario = vUsuario;
            Contraseña = vContraseña;
        }// end DatosSQLServer
    }// end class DatosSQLServer
}

