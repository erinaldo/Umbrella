using System;
using System.Data;

namespace umbDatos
{
    public abstract class csConexion
    {
        #region "Declaración de Variables"

        protected string varServidor = "";
        protected string varBaseDatos = "";
        protected string varUsuario = "";
        protected string varContraseña = "";
        protected string varCadenaConexion = "";
        protected IDbConnection varConexion;
        //protected  SAPbobsCOM.Company varConexionSap;

        #endregion

        #region "sets y gets"

        // Nombre del equipo servidor de datos. 
        public string Servidor
        {
            get { return varServidor; }
            set { varServidor = value; }
        } // end Servidor
        // Nombre de la base de datos a utilizar.
        public string BaseDatos
        {
            get { return varBaseDatos; }
            set { varBaseDatos = value; }
        } // end Base
        // Nombre del Usuario de la BD. 
        public string Usuario
        {
            get { return varUsuario; }
            set { varUsuario = value; }
        } // end Usuario
        // Password del Usuario de la BD. 
        public string Contraseña
        {
            get { return varContraseña; }
            set { varContraseña = value; }
        } // end Password
        // Cadena de conexión completa a la base.
        public  string CadenaConexion
        { get; set; }



        #endregion
        #region "Privadas"

        // Crea u obtiene un objeto para conectarse a la base de datos. 
        protected IDbConnection idbConexion
        {
            get
            {
                // si aun no tiene asignada la cadena de conexion lo hace
                if (varConexion == null)
                    varConexion = idbCrearConexion(CadenaConexion);

                // si no esta abierta aun la conexion, lo abre
                if (varConexion.State != ConnectionState.Open)
                    varConexion.Open();

                // retorna la conexion en modo interfaz, para que se adapte a cualquier implementacion de los distintos fabricantes de motores de bases de datos
                return varConexion;
            } // end get
        } // end Conexion

        #endregion

        #region "Lecturas"

        // Obtiene un DataSet a partir de un Procedimiento Almacenado.
        public DataSet funTraerDataSet(string varProcedimientoAlmacenado)
        {
            var dsDataSet = new DataSet();
            idaCrearDataAdapter(varProcedimientoAlmacenado).Fill(dsDataSet);
            return dsDataSet;
        } // end TraerDataset
        //Obtiene un DataSet a partir de un Procedimiento Almacenado y sus parámetros. 
        public DataSet funTraerDataSet(string varProcedimientoAlmacenado, params Object[] args)
        {
            var dsDataSet = new DataSet();
            idaCrearDataAdapter(varProcedimientoAlmacenado, args).Fill(dsDataSet);
            return dsDataSet;
        } // end TraerDataset
        // Obtiene un DataSet a partir de un Query Sql.
        public DataSet funTraerDataSetSql(string varComandoSql)
        {
            var dsDataSet = new DataSet();
            idaCrearDataAdapterSql(varComandoSql).Fill(dsDataSet);
            return dsDataSet;
        } // end TraerDataSetSql

        // Obtiene un DataTable a partir de un Procedimiento Almacenado.
        public DataTable funTraerDataTable(string varProcedimientoAlmacenado)
        { return funTraerDataSet(varProcedimientoAlmacenado).Tables[0].Copy(); } // end TraerDataTable
        //Obtiene un DataSet a partir de un Procedimiento Almacenado y sus parámetros. 
        public DataTable funTraerDataTable(string varProcedimientoAlmacenado, params Object[] args)
        { return funTraerDataSet(varProcedimientoAlmacenado, args).Tables[0].Copy(); } // end TraerDataTable
        //Obtiene un DataTable a partir de un Query SQL
        public DataTable funTraerDataTableSql(string varComandoSql)
        { return funTraerDataSetSql(varComandoSql).Tables[0].Copy(); } // end TraerDataTableSql

        // Obtiene un DataReader a partir de un Procedimiento Almacenado. 
        public IDataReader funTraerDataReader(string varProcedimientoAlmacenado)
        {
            var idrComando = idbComando(varProcedimientoAlmacenado);
            return idrComando.ExecuteReader();
        } // end TraerDataReader 
        // Obtiene un DataReader a partir de un Procedimiento Almacenado y sus parámetros. 
        public IDataReader funTraerDataReader(string varProcedimientoAlmacenado, params object[] args)
        {
            var idrComando = idbComando(varProcedimientoAlmacenado);
            proCargarParametros(idrComando, args);
            return idrComando.ExecuteReader();
        } // end TraerDataReader
        // Obtiene un DataReader a partir de un Procedimiento Almacenado. 
        public IDataReader funTraerDataReaderSql(string varComandoSql)
        {
            var idrComando = idbComandoSql(varComandoSql);
            return idrComando.ExecuteReader();
        } // end TraerDataReaderSql 

        // Obtiene un Valor Escalar a partir de un Procedimiento Almacenado. Solo funciona con SP's que tengan
        // definida variables de tipo output, para funciones escalares mas abajo se declara un metodo
        public object funTraerValorOutput(string varProcedimientoAlmacenado)
        {
            // asignar el string sql al command
            var com = idbComando(varProcedimientoAlmacenado);
            // ejecutar el command
            com.ExecuteNonQuery();
            // declarar variable de retorno
            Object resp = null;

            // recorrer los parametros del SP
            foreach (IDbDataParameter par in com.Parameters)
                // si tiene parametros de tipo IO/Output retornar ese valor
                if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
                    resp = par.Value;
            return resp;
        } // end TraerValor
        // Obtiene un Valor a partir de un Procedimiento Almacenado, y sus parámetros. 
        public object funTraerValorOutput(string varProcedimientoAlmacenado, params Object[] args)
        {
            // asignar el string sql al command
            var com = idbComando(varProcedimientoAlmacenado);
            // cargar los parametros del SP
            proCargarParametros(com, args);
            // ejecutar el command
            com.ExecuteNonQuery();
            // declarar variable de retorno
            Object resp = null;

            // recorrer los parametros del SP
            foreach (IDbDataParameter par in com.Parameters)
                // si tiene parametros de tipo IO/Output retornar ese valor
                if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
                    resp = par.Value;
            return resp;
        } // end TraerValor
        // Obtiene un Valor Escalar a partir de un Procedimiento Almacenado. 
        public object funTraerValorOutputSql(string varComadoSql)
        {
            // asignar el string sql al command
            var com = idbComandoSql(varComadoSql);
            // ejecutar el command
            com.ExecuteNonQuery();
            // declarar variable de retorno
            Object resp = null;

            // recorrer los parametros del Query (uso tipico envio de varias sentencias sql en el mismo command)
            foreach (IDbDataParameter par in com.Parameters)
                // si tiene parametros de tipo IO/Output retornar ese valor
                if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
                    resp = par.Value;
            return resp;
        } // end TraerValor
        // Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado. 
        public object funTraerValorEscalar(string varProcedimientoAlmacenado)
        {
            var com = idbComando(varProcedimientoAlmacenado);
            return com.ExecuteScalar();
        } // end TraerValorEscalar
        /// Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado, con Params de Entrada
        public Object funTraerValorEscalar(string varProcedimientoAlmacenado, params object[] args)
        {
            var com = idbComando(varProcedimientoAlmacenado);
            proCargarParametros(com, args);
            return com.ExecuteScalar();
        } // end TraerValorEscalar
        // Obtiene un Valor de una funcion Escalar a partir de un Query SQL
        public object funTraerValorEscalarSql(string varComandoSql)
        {
            var com = idbComandoSql(varComandoSql);
            return com.ExecuteScalar();
        } // end TraerValorEscalarSql

        #endregion

        #region "Acciones"

        protected abstract IDbConnection idbCrearConexion(string varCadena);
        protected abstract IDbCommand idbComando(string varProcedimientoAlmacenado);
        protected abstract IDbCommand idbComandoSql(string varComandoSql);
        protected abstract IDataAdapter idaCrearDataAdapter(string varProcedimientoAlmacenado, params Object[] args);
        protected abstract IDataAdapter idaCrearDataAdapterSql(string varComandoSql);
        protected abstract void proCargarParametros(IDbCommand idbComando, Object[] args);

        // metodo sobrecargado para autenticarse contra el motor de BBDD
        public bool funAutenticar()
        {
            if (idbConexion.State != ConnectionState.Open)
                idbConexion.Open();
            return true;
        }// end Autenticar
        // metodo sobrecargado para autenticarse contra el motor de BBDD
        public bool funAutenticar(string vUsuario, string vPassword)
        {
            varUsuario = vUsuario;
            varContraseña = vPassword;
            varConexion = idbCrearConexion(CadenaConexion);

            varConexion.Open();
            return true;
        }// end Autenticar
        // cerrar conexion
        public void proCerrarConexion()
        {
            if (idbConexion.State != ConnectionState.Closed)
                varConexion.Close();
        }

        // end CerrarConexion
      
        // Ejecuta un Procedimiento Almacenado en la base. 
        public int funEjecutar(string varProcedimientoAlmacenado)
        { return idbComando(varProcedimientoAlmacenado).ExecuteNonQuery(); } // end Ejecutar
        // Ejecuta un query sql
        public int funEjecutarSql(string varComandoSql)
        { return idbComandoSql(varComandoSql).ExecuteNonQuery(); } // end Ejecutar
        //Ejecuta un Procedimiento Almacenado en la base, utilizando los parámetros. 
        public int funEjecutar(string varProcedimientoAlmacenado, params  Object[] args)
        {
            var com = idbComando(varProcedimientoAlmacenado);
            proCargarParametros(com, args);
            var resp = com.ExecuteNonQuery();
            for (var i = 0; i < com.Parameters.Count; i++)
            {
                var par = (IDbDataParameter)com.Parameters[i];
                if (par.Direction == ParameterDirection.InputOutput || par.Direction == ParameterDirection.Output)
                    args.SetValue(par.Value, i - 1);
            }// end for
            return resp;
        } // end Ejecutar


        #endregion

        #region "Transacciones"

        protected IDbTransaction idbTransaccion;
        protected bool varEndTransaccion;

        //Comienza una Transacción en la base en uso. 
        public void proIniciarTransaccion()
        {
            try
            {
                idbTransaccion = idbConexion.BeginTransaction();
                varEndTransaccion = true;
            }// end try
            finally
            { varEndTransaccion = false; }
        }// end IniciarTransaccion
        //Confirma la transacción activa. 
        public void proTerminarTransaccion()
        {
            try
            { idbTransaccion.Commit(); }
            finally
            {
                idbTransaccion = null;
                varEndTransaccion = false;
            }// end finally
        }// end TerminarTransaccion
        //Cancela la transacción activa.
        public void proAbortarTransaccion()
        {
            try
            { idbTransaccion.Rollback(); }
            finally
            {
                idbTransaccion = null;
                varEndTransaccion = false;
            }// end finally
        }// end AbortarTransaccion


        #endregion

    }// end class gDatos
}// end namespace
