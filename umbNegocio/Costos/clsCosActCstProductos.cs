using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;

namespace umbNegocio.Granja
{
    public class clsCosActCstProductos
    {
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }

        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string BodCodigo { get; set; }
        public string BodNombre { get; set; }
        public string CabDescripcion { get; set; }
        public string CabComentario { get; set; }
        public string CabComenDiario { get; set; }
        public string EstCodigo { get; set; }

        public DataTable DetActCstFormulacion { get; set; }
        public DataTable DetActCstMaterial { get; set; }

        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        //Funcion utilizada para recuperar los documentos de actualizacion de costos de productos
        public static List<clsCosActCstProductos> funListar(string varWhere)
        {
            try {
                List<clsCosActCstProductos> objLista = new List<clsCosActCstProductos>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_ActCstProductosListar", DBNull.Value, varWhere);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsCosActCstProductos()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para recuperar el documento de actualizacion de costos de productos
        public static List<clsCosActCstProductos> funListar(int varId)
        {
            try {
                List<clsCosActCstProductos> objLista = new List<clsCosActCstProductos>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_ActCstProductosListar", varId, DBNull.Value);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                    objLista.Add(funRegistro(drLista, new clsCosActCstProductos()));
                return objLista;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //Funcion utilizada para asignar los valores recuperados de la consulta a las propiedades de las clases
        private static clsCosActCstProductos funRegistro(DataRow drRegistro, clsCosActCstProductos objRegistro)
        {
            objRegistro.CabCodigo = drRegistro["CabCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabCodigo"].ToString());
            objRegistro.DocCodigo = drRegistro["DocCodigo"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["DocCodigo"].ToString());
            objRegistro.DocNombre = drRegistro["DocNombre"] == System.DBNull.Value ? "" : drRegistro["DocNombre"].ToString();
            objRegistro.CabNumero = drRegistro["CabNumero"] == System.DBNull.Value ? 0 : int.Parse(drRegistro["CabNumero"].ToString());

            objRegistro.CabFecha = (DateTime)drRegistro["CabFecha"];

            objRegistro.BodCodigo = drRegistro["BodCodigo"] == System.DBNull.Value ? "" : drRegistro["BodCodigo"].ToString();
            objRegistro.BodNombre = drRegistro["BodNombre"] == System.DBNull.Value ? "" : drRegistro["BodNombre"].ToString();
            objRegistro.CabDescripcion = drRegistro["CabDescripcion"] == System.DBNull.Value ? "" : drRegistro["CabDescripcion"].ToString();
            objRegistro.CabComentario = drRegistro["CabComentario"] == System.DBNull.Value ? "" : drRegistro["CabComentario"].ToString();
            objRegistro.CabComenDiario = drRegistro["CabComenDiario"] == System.DBNull.Value ? "" : drRegistro["CabComenDiario"].ToString();
            objRegistro.EstCodigo = drRegistro["EstCodigo"] == System.DBNull.Value ? "" : drRegistro["EstCodigo"].ToString();

            objRegistro.UsuCrea = drRegistro["UsuCrea"] == null ? "" : drRegistro["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drRegistro["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaCrea"];
            objRegistro.UsuCrea = drRegistro["UsuModifica"] == null ? "" : drRegistro["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drRegistro["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drRegistro["UsuFechaModifica"];

            return objRegistro;
        }
        //Procedimiento almacenado utilizado para insertar y modificar las actualizaciones de costo de productos
        public int funMantenimiento(clsCosActCstProductos csRegistro, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_ActCstProductosMantenimiento", csRegistro.CabCodigo, csRegistro.DocCodigo, csRegistro.CabNumero,  csRegistro.CabFecha, 
                                                                                                                                                                                         csRegistro.BodCodigo, csRegistro.CabDescripcion, csRegistro.CabComentario, csRegistro.CabComenDiario,
                                                                                                                                                                                         csRegistro.EstCodigo, varOperacion, clsVariablesGlobales.varCodUsuario, csRegistro.DetActCstFormulacion, 
                                                                                                                                                                                         csRegistro.DetActCstMaterial);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
        //Procedimiento almacenado utilizado para anular las actualizaciones de costo de productos
        public static void proAnular(int varCabCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_ActCstProductosAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Procedimiento utilizado para actualizar la informacion de SAP en el detalle de actualizacion de costos de formulacion
        public static void proActSAPDetActCstFormulacion(int varDocEntrySAP, int varDocNumSAP, int varCabCodigo, int varDetSecuencia, int varOpcion, double varDetCosto)
        {
            try {
                string varSql = "";

                //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                switch (varOpcion) {
                    case 1: //Actualizamos la informacion de SAP de la salida de inventario
                        varSql = string.Format("Update GRA_DETACTCSTFORMULACION Set DetDocEntrySAPSalida = {0}, DetNumeroSAPSalida = {1} Where CabCodigo = {2} and DetSecuencia = {3}", varDocEntrySAP, varDocNumSAP, varCabCodigo, varDetSecuencia);
                        break;
                    case 2: //Actualizamos la informacion de SAP de la entrada de inventario
                        if (varDetCosto > 0)
                            varSql = string.Format("Update GRA_DETACTCSTFORMULACION Set DetDocEntrySAPEntrada = {0}, DetNumeroSAPEntrada = {1}, DetCosto = {4} Where CabCodigo = {2} and DetSecuencia = {3}", varDocEntrySAP, varDocNumSAP, varCabCodigo, varDetSecuencia,varDetCosto);
                        else
                            varSql = string.Format("Update GRA_DETACTCSTFORMULACION Set DetDocEntrySAPEntrada = {0}, DetNumeroSAPEntrada = {1} Where CabCodigo = {2} and DetSecuencia = {3}", varDocEntrySAP, varDocNumSAP, varCabCodigo, varDetSecuencia);
                        break;
                    case 3: //Actualizamos la informacion de SAP del diario contable
                        varSql = string.Format("Update GRA_DETACTCSTFORMULACION Set DetDocEntrySAPDiario = {0}, DetNumeroSAPDiario = {1} Where CabCodigo = {2} and DetSecuencia = {3}", varDocEntrySAP, varDocNumSAP, varCabCodigo, varDetSecuencia);
                        break;
                }
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(varSql);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Funcion utilizada para recuperar los detalles de la actualizacion de costos de formulacion
        public static DataTable funRecDetActCstFormulacion(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecuencia, DetFecha, IteCodigo, IteNombre, DetTieLote, IteUndInventario, CabFormula, CabVariante, DetLote, DetCantidad, DetSaco, ItePsoStd, " +
                                                                                                                                                                 "DetCosto, DetNumeroSAPSalida, DetNumeroSAPEntrada, DetNumeroSAPDiario, EstCodigo " +
                                                                                                                                                                 "From GRA_DETACTCSTFORMULACION " + 
                                                                                                                                                                 "Where CabCodigo = {0} " +
                                                                                                                                                                 "Order by DetSecuencia ", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para recuperar los detalles de la actualizacion de costos de materiales
        public static DataTable funRecDetActCstMaterial(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select DetSecItemProducir, DetSecuencia, IteCodigo, IteNombre, DetTieLote, IteUndInventario, BodCodigo, DetCantPlan, " +
                                                                                                                                                                 "DetCantReal, EstCodigo  " +
                                                                                                                                                                 "From GRA_DETACTCSTMATERIAL " + 
                                                                                                                                                                 "Where CabCodigo = {0} " +
                                                                                                                                                                 "Order by DetSecuencia ", varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtLista;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para verificar si el documento fue ingresado en SAP
        public static int funVerificarSAP(string varDocNombre, int varCabNumero)
        {
            try {
                 csAccesoDatos.funIniciarSesion("conDBItalimentos");
                int varCuantos = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Count(*) From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero like '{1} - %'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception ex){ throw new Exception(ex.Message); }
        }
        //Funcion utilizada para verificar si el documento de entrada de mercancias ya fue ingresada a SAP
        public static DataTable funVerificarSalMercanciaSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtSalida = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1} - {2}'", varDocNombre, varCabNumero, varDetSecuencia));
                csAccesoDatos.proFinalizarSesion();
                return dtSalida;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para verificar si el documento de entrada de mercancias ya fue ingresada a SAP
        public static DataTable funVerificarEntMercanciaSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtSalida = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1} - {2}'", varDocNombre, varCabNumero, varDetSecuencia));
                csAccesoDatos.proFinalizarSesion();
                return dtSalida;
            }
            catch (Exception) { throw; }
        }
        //Funcion utilizada para verificar si el documento de diario ya fue ingresada a SAP
        public static DataTable funVerificarDiarioSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtSalida = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select TransId, Number From OJDT a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1} - {2}'", varDocNombre, varCabNumero, varDetSecuencia));
                csAccesoDatos.proFinalizarSesion();
                return dtSalida;
            }
            catch (Exception) { throw; }
        }
        //Funcion para verificar si ya todos los items a producir fueron enviados a SAP y cerrar la orden
        public static int funVerificarDetItemProducirSAP(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCuantos = int.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Count(*) From GRA_DETACTCSTFORMULACION b left join GRA_DETACTCSTFORMULACION c on b.CabCodigo = c.CabCodigo and b.DetSecuencia = c.DetSecuencia and b.DetDocEntrySAPSalida <> 0 and b.DetDocEntrySAPEntrada <> 0 and b.DetDocEntrySAPDiario <> 0 Where b.CabCodigo = {0} and c.CabCodigo is null", varCabCodigo)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCuantos;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Funcion utilizada para recuperar el valor total de la salida de mercancia
        public static double funRecTotSalMercanciaSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                double varSaldo = double.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(Sum(b.Debit),0) as Total From OJDT a inner join JDT1 b on a.TransId = b.TransId Where a.TransType = 60 and a.CreatedBy = (Select c.DocEntry From OIGE c Where c.U_Ita_sysdocumento = '{0}' and c.U_Ita_sysnumero = '{1} - {2}')", varDocNombre, varCabNumero, varDetSecuencia)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varSaldo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Funcion utilizada para recuperar el valor total de la entrada de mercancia
        public static double funRecTotEntMercanciaSAP(string varDocNombre, int varCabNumero, int varDetSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                double varSaldo = double.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(Sum(b.Debit),0) as Total From OJDT a inner join JDT1 b on a.TransId = b.TransId Where a.TransType = 59 and a.CreatedBy = (Select c.DocEntry From OIGN c Where c.U_Ita_sysdocumento = '{0}' and c.U_Ita_sysnumero = '{1} - {2}')", varDocNombre, varCabNumero, varDetSecuencia)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varSaldo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
         //Funcion utilizada para enviar el documentos al sistema SAP
        public static string funEnviarDocumentoSAP(clsCosActCstProductos objRegistro, int varCabNumero)
        {
            try
            {
                string mError = "";
               
                csAccesoDatos.proIniciarSesionSAP();
                //Declaramos la variables para obtener la informacion que vamos a utilizar
                int varCabCodigo = objRegistro.CabCodigo; //Codigo key del documento
                int varDocCodigo = objRegistro.DocCodigo; //Codigo del documento
                string varDocNombre = objRegistro.DocNombre; //Descripcion del documento
                string varCabComentario = objRegistro.CabComentario; //Comentario para el documento
                string varCabComenDiario = objRegistro.CabComenDiario; //Comentario para el diario contable
                string varBodCodigo = objRegistro.BodCodigo; //Bodega donde se va ingresar el inventario
                                
                DateTime varCabFecha = objRegistro.CabFecha; //Fecha del documento
                                    
                //Recorremos el datatable de los items a producir
                foreach (DataRow drItemProducir in objRegistro.DetActCstFormulacion.Rows) {
                    int varDetSecuencia = int.Parse(drItemProducir["DetSecuencia"].ToString()); //Linea de detalle del documento
                    //Recuperamos la informacion con respecto a la salida de mercancia enviada a SAP
                    DataTable dtSalMercanciaSAP = funVerificarSalMercanciaSAP(varDocNombre, varCabNumero, varDetSecuencia);
                    //Verificamos si existe una salida en el sistema SAP del documento enviado
                    if (dtSalMercanciaSAP.Rows.Count.Equals(0))
                        mError = funEnviarSalidaSAP(mError, varCabCodigo, varCabNumero, varDocCodigo, varDetSecuencia, varDocNombre, varCabFecha, varCabComentario, varCabComenDiario, objRegistro.DetActCstMaterial, drItemProducir);
                    else {
                        //Verificamos si ya esta actualizado el campo de SAP salida
                        if (int.Parse(drItemProducir["DetNumeroSAPSalida"].ToString()).Equals(0)) {
                            //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                            int varDocEntrySAPSalida = int.Parse(dtSalMercanciaSAP.Rows[0]["DocEntry"].ToString());
                            int varDocNumSAPSalida = int.Parse(dtSalMercanciaSAP.Rows[0]["DocNum"].ToString());
                            proActSAPDetActCstFormulacion(varDocEntrySAPSalida, varDocNumSAPSalida, varCabCodigo, varDetSecuencia, 1, 0);

                            drItemProducir["DetNumeroSAPSalida"] = varDocNumSAPSalida;
                            drItemProducir.AcceptChanges();
                            mError = "";
                        }
                    }
                    //Verificamos que en el proceso de salida de mercancia no haya habido ningun error
                    if (mError.Equals("")) {
                        //Recuperamos la informacion con respecto a la entrada de mercancia enviada a SAP
                        DataTable dtEntMercanciaSAP = funVerificarEntMercanciaSAP(varDocNombre, varCabNumero, varDetSecuencia);
                        //Verificamos si existe una entrada en el sistema SAP del documento enviado
                        if (dtEntMercanciaSAP.Rows.Count.Equals(0))
                            mError = funEnviarEntradaSAP(mError, varCabCodigo, varCabNumero, varDocCodigo, varDetSecuencia, varDocNombre, varCabFecha, varCabComentario, varCabComenDiario, varBodCodigo, drItemProducir);
                        else {
                            if (int.Parse(drItemProducir["DetNumeroSAPEntrada"].ToString()).Equals(0)) {
                                //Actualizamos la linea del detalle con la informacion de SAP de la entrada de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                                int varDocEntrySAPEntrada = int.Parse(dtEntMercanciaSAP.Rows[0]["DocEntry"].ToString());
                                int varDocNumSAPEntrada = int.Parse(dtEntMercanciaSAP.Rows[0]["DocNum"].ToString());
                                proActSAPDetActCstFormulacion(varDocEntrySAPEntrada, varDocNumSAPEntrada, varCabCodigo, varDetSecuencia, 2, 0);

                                drItemProducir["DetNumeroSAPEntrada"] = varDocNumSAPEntrada;
                                drItemProducir.AcceptChanges();
                                mError = "";
                            }
                        }
                    }
                     //Verificamos que en el proceso de entrada de mercancia no haya habido ningun error
                    if (mError.Equals("")) {
                        //Recuperamos informacion con respecto a los totales para encontrar diferencias tanto en entrada como salida de mercancias
                        double varValorSalida = funRecTotSalMercanciaSAP(varDocNombre, varCabNumero, varDetSecuencia);
                        double varValorEntrada = funRecTotEntMercanciaSAP(varDocNombre, varCabNumero, varDetSecuencia);
                        double varValor = Math.Round(Math.Abs(varValorEntrada - varValorSalida), 2);

                        //Verificamos si existe diferencias entre los valores totales de entrada y salida de mercancia
                        if (varValorSalida != varValorEntrada) {
                            //Recuperamos la informacion con respecto a la entrada de mercancia enviada a SAP
                            DataTable dtDiarioSAP = funVerificarDiarioSAP(varDocNombre, varCabNumero, varDetSecuencia);
                            //Verificamos si existe un diario en el sistema SAP del documento enviado
                            if (dtDiarioSAP.Rows.Count.Equals(0)) {
                                if (varValorSalida < varValorEntrada)
                                    mError = funEnviarDiarioSAP(mError, varCabCodigo, varCabNumero, varDocCodigo, varDetSecuencia, varDocNombre, varCabFecha, varCabComenDiario, "Debe", varValor, drItemProducir);
                                else
                                    mError = funEnviarDiarioSAP(mError, varCabCodigo, varCabNumero, varDocCodigo, varDetSecuencia, varDocNombre, varCabFecha, varCabComenDiario, "Haber", varValor, drItemProducir);
                            }
                            else {
                                if (int.Parse(drItemProducir["DetNumeroSAPDiario"].ToString()).Equals(0)) {
                                    //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                                    int varDocEntrySAPDiario = int.Parse(dtDiarioSAP.Rows[0]["TransId"].ToString());
                                    int varDocNumSAPDiario = int.Parse(dtDiarioSAP.Rows[0]["Number"].ToString());
                                    proActSAPDetActCstFormulacion(varDocEntrySAPDiario, varDocNumSAPDiario, varCabCodigo, varDetSecuencia, 3, 0);

                                    drItemProducir["DetNumeroSAPDiario"] = varDocNumSAPDiario;
                                    drItemProducir.AcceptChanges();
                                    mError = "";
                                }
                            }
                        }
                        else {
                            //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                            proActSAPDetActCstFormulacion(-1, -1, varCabCodigo, varDetSecuencia, 3, 0);

                            drItemProducir["DetNumeroSAPDiario"] = -1;
                            drItemProducir.AcceptChanges();
                            mError = "";
                        }
                    }
                }

                //Validamos si todos los items a producir fueron enviados a SAP para cerrar la orden
                if (clsCosActCstProductos.funVerificarDetItemProducirSAP(varCabCodigo).Equals(0)) {
                    //Actualizamos el estado de la orden a SAP
                    csAccesoDatos.funIniciarSesion("conDBUmbrella");
                    csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_CABACTCSTPRODUCTOS Set EstCodigo = 'Sap' Where CabCodigo = {0}", varCabCodigo));
                    csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_DETACTCSTFORMULACION Set EstCodigo = 'Sap' Where CabCodigo = {0}", varCabCodigo));
                    csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_DETACTCSTMATERIAL Set EstCodigo = 'Sap' Where CabCodigo = {0}", varCabCodigo));
                    csAccesoDatos.proFinalizarSesion();
                }

                return "";
            }
            catch (Exception e)  { throw new Exception(e.Message); } 
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        //Funcion utilizada para enviar la salida de mercancia a SAP
        private static string funEnviarSalidaSAP(string mError, //parametro utilizado para obtener el mensaje en caso de error
                                                                     int varCabCodigo, //parametro utilizado para obtener el key del documento
                                                                     int varCabNumero, //parametro que contendra el numero del documento
                                                                     int varDocCodigo, //parametro que contendra el codigo del documento
                                                                     int varDetSecuencia, //parametro que contendra la secuencia del detalle del documento
                                                                     string varDocNombre, //parametro que contendra el nombre del documento
                                                                     DateTime varFecha, //parametro que contendra la fecha del documento
                                                                     string varComentario, //parametro que contendra el comentario general del documento
                                                                     string varComenDiario, //parametro que contendra el comentario del diario
                                                                     DataTable dtMateriales, //parametro que contendra todos los materiales utilizados 
                                                                     DataRow drItemProducir //Fila del item a producir
            ) {
            try
            {
                int iError = 0;
                int i = 0;
                string varCodMovimiento = clsGenOpciones.CargarValor("C.Acp.Salida.CodMov"); //Recuperamos el codigo del movimiento para la salida de mercancia
                string varNomMovimiento = clsGenOpciones.CargarValor("C.Acp.Salida.NomMov"); //Recuperamos el nombre del movimiento para la salida de mercancia

                //Instanciamos en la variable varOIGE el objeto de SAP salida de mercancias
                SAPbobsCOM.Documents varOIGE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);

                //Cargamos informacion de la cabecera de la salida de mercancias
                varOIGE.Series = clsSegDocumento.funRecNumSerieSAPSalida(varDocCodigo);
                varOIGE.DocDate = varFecha;
                varOIGE.DocDueDate = varFecha;
                varOIGE.TaxDate = varFecha;
                varOIGE.Comments = varComentario;
                varOIGE.JournalMemo = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia + " " + varComenDiario;
                varOIGE.PaymentGroupCode = -2;
                varOIGE.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento;
                varOIGE.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento;
                varOIGE.UserFields.Fields.Item("U_Ita_sysdocumento").Value = varDocNombre;
                varOIGE.UserFields.Fields.Item("U_Ita_sysnumero").Value = varCabNumero + " - " + varDetSecuencia;
                varOIGE.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                varOIGE.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                varOIGE.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;

                //Cargamos informacion de los detalles de la salida de mercancias
                foreach (DataRow drDetalle in dtMateriales.Select(string.Format("DetSecItemProducir = {0}", varDetSecuencia))) {
                    string varIteCodigo = drDetalle["IteCodigo"].ToString();  //Variable utilizada para el codigo del item
                    string varIteNombre = drDetalle["IteNombre"].ToString();  //Variable utilizada para el nombre del item
                    string varBodCodigo = drDetalle["BodCodigo"].ToString();  //Variable utilizada para el codigo de la bodega
                    string varIteTieLote = drDetalle["DetTieLote"].ToString();  //Variable utilizada para determinar si el item esta gestionado por lote
                    string varCtaContable = clsInvItem.funRecCtaContable(varIteCodigo, varCodMovimiento); //Variable utilizada para recuperar la cuenta contable 
                    double varDetCantReal = double.Parse(drDetalle["DetCantReal"].ToString());  //Variable utilizada para la cantidad a descargar
                    
                    //Validamos si existe una cuenta contable asignada a dicho movimiento segun el item
                    if (varCtaContable.Equals("")) throw new Exception(string.Format("El Item {0} - {1} con el Movimiento {2} - {3} no tiene asignado una cuenta contable", varIteCodigo, varIteNombre, varCodMovimiento, varNomMovimiento));

                    if ( i > 0 ) varOIGE.Lines.Add();

                    varOIGE.Lines.SetCurrentLine(i); //Nos posicionamos en la linea recien creada
                    varOIGE.Lines.ItemCode = varIteCodigo;  //Codigo del item a descargar
                    varOIGE.Lines.WarehouseCode = varBodCodigo;  //Bodega de donde se descargara el inventario
                    varOIGE.Lines.Quantity = varDetCantReal; //Cantidad a descargar
                    varOIGE.Lines.AccountCode = varCtaContable; //Cuenta contable asignada al movimiento 

                    int j = 0;
                    if (varIteTieLote.ToUpper().Equals("Y")) { //Verificamos si el item esta gestionado por lotes
                        //Recuperamos la informacion de los lotes segun el item y la bodega
                        DataTable dtLote = clsInvItem.funRecLote(varIteCodigo, varBodCodigo);
                        double varSaldo = dtLote.Rows.Count.Equals(0) ? 0 : double.Parse(dtLote.Compute("Sum(StkDisponible)", "").ToString());
                        //Verificamos si el saldo del item no cae en negativo con respecto a lo que se necesita
                        if (varDetCantReal > varSaldo) throw new Exception(string.Format("El Item {0} - {1} tiene un saldo de {2} y lo requerido es {3}", varIteCodigo, varIteNombre, varSaldo, varDetCantReal));

                        foreach (DataRow drLote in dtLote.Rows) {
                            string varLotCodigo = drLote["LotCodigo"].ToString(); //Recuperamos el codigo del lote
                            double varStkDisponible = double.Parse(drLote["StkDisponible"].ToString()); //Recuperamos la cantidad disponible de ese lote
                            

                            if (j > 0) varOIGE.Lines.BatchNumbers.Add();

                            varOIGE.Lines.BatchNumbers.SetCurrentLine(j); //Nos posicionamos en la linea del lote recien creada
                            varOIGE.Lines.BatchNumbers.BatchNumber = varLotCodigo; //Codigo del lote que vamos a utilizar
                            //Validamos si la cantidad que dispone el lote seleccionado es suficiente para la cantidad requerida
                            if (varDetCantReal <= varStkDisponible) {
                                varOIGE.Lines.BatchNumbers.Quantity = varDetCantReal;
                                break;
                            }
                            else {
                                varOIGE.Lines.BatchNumbers.Quantity = varStkDisponible;
                                varDetCantReal -= varStkDisponible;
                                j++;
                            }
                        }
                    }
                    i++;
                }
                iError = varOIGE.Add();
                if (!iError.Equals(0)) {
                    csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                    return mError;
                }
                else {
                    int varDocEntrySAPSalida = 0;
                    int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPSalida);
                    varOIGE.GetByKey(varDocEntrySAPSalida);
                    int varDocNumSAPSalida = varOIGE.DocNum;

                    //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                    proActSAPDetActCstFormulacion(varDocEntrySAPSalida, varDocNumSAPSalida, varCabCodigo, varDetSecuencia, 1, 0);

                    drItemProducir["DetNumeroSAPSalida"] = varDocNumSAPSalida;
                    drItemProducir.AcceptChanges();
                    return mError;
                }
            }
            catch (Exception e) { throw new Exception(e.Message); } 
           
        }
        //Funcion utilizada para enviar la entrada de mercancia a SAP
        private static string funEnviarEntradaSAP(string mError, //parametro utilizado para obtener el mensaje en caso de error
                                                                       int varCabCodigo, //parametro utilizado para obtener el key del documento
                                                                       int varCabNumero, //parametro que contendra el numero del documento
                                                                       int varDocCodigo, //parametro que contendra el codigo del documento
                                                                       int varDetSecuencia, //parametro que contendra la secuencia del detalle del documento
                                                                       string varDocNombre, //parametro que contendra el nombre del documento
                                                                       DateTime varFecha, //parametro que contendra la fecha del documento
                                                                       string varComentario, //parametro que contendra el comentario general del documento
                                                                       string varComenDiario, //parametro que contendra el comentario del diario
                                                                       string varBodCodigo,  //parametro que contendra el codigo de la bodega
                                                                       DataRow drItemProducir //parametro que contendra el item a producir
            )
        {
            try
            {
                int iError = 0;
                string varCodMovimiento = clsGenOpciones.CargarValor("C.Acp.Entrada.CodMov"); //Recuperamos el codigo del movimiento para la entrada de mercancia
                string varNomMovimiento = clsGenOpciones.CargarValor("C.Acp.Entrada.NomMov"); //Recuperamos el nombre del movimiento para la entrada de mercancia

                //Instanciamos en la variable varOIGN el objeto de SAP entrada de mercancias
                SAPbobsCOM.Documents varOIGN = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);

                //Cargamos informacion de la cabecera de la entrada de mercancias
                varOIGN.Series = clsSegDocumento.funRecNumSerieSAPEntrada(varDocCodigo);
                varOIGN.DocDate = varFecha;
                varOIGN.DocDueDate = varFecha;
                varOIGN.TaxDate = varFecha;
                varOIGN.Comments = varComentario;
                varOIGN.JournalMemo = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia + " " + varComenDiario;
                varOIGN.PaymentGroupCode = -2;
                varOIGN.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento;
                varOIGN.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento;
                varOIGN.UserFields.Fields.Item("U_Ita_sysdocumento").Value = varDocNombre;
                varOIGN.UserFields.Fields.Item("U_Ita_sysnumero").Value = varCabNumero + " - " + varDetSecuencia;
                varOIGN.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                varOIGN.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                varOIGN.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;

                //Cargamos informacion de los detalles de la entrada de mercancias
                string varIteCodigo = drItemProducir["IteCodigo"].ToString();  //Variable utilizada para el codigo del item
                string varIteNombre = drItemProducir["IteNombre"].ToString();  //Variable utilizada para el nombre del item
                string varIteTieLote = drItemProducir["DetTieLote"].ToString();  //Variable utilizada para determinar si el item esta gestionado por lote
                string varCtaContable = clsInvItem.funRecCtaContable(varIteCodigo, varCodMovimiento); //Variable utilizada para recuperar la cuenta contable 
                double varDetCantidad = double.Parse(drItemProducir["DetCantidad"].ToString());  //Variable utilizada para la cantidad a ingresar
                double varCosto = Math.Round(funRecTotSalMercanciaSAP(varDocNombre, varCabNumero, varDetSecuencia) / varDetCantidad, 4); //Variable utilizada para el costo del item a ingresar
                int varDetSaco = int.Parse(drItemProducir["DetSaco"].ToString());  //Variable utilizada para los sacos a ingresar

                //Validamos si existe una cuenta contable asignada a dicho movimiento segun el item
                if (varCtaContable.Equals("")) throw new Exception(string.Format("El Item {0} - {1} con el Movimiento {2} - {3} no tiene asignado una cuenta contable", varIteCodigo, varIteNombre, varCodMovimiento, varNomMovimiento));

                varOIGN.Lines.SetCurrentLine(0); //Nos posicionamos en la linea recien creada
                varOIGN.Lines.ItemCode = varIteCodigo;  //Codigo del item a ingresar
                varOIGN.Lines.WarehouseCode = varBodCodigo;  //Bodega de donde se va a ingresar el inventario
                varOIGN.Lines.Quantity = varDetCantidad; //Cantidad a ingresar
                varOIGN.Lines.UnitPrice = varCosto; //Costo del item
                varOIGN.Lines.AccountCode = varCtaContable; //Cuenta contable asignada al movimiento 
                varOIGN.Lines.UserFields.Fields.Item("U_ita_ped_pza").Value = varDetSaco; //La cantidad en unidades

                //Verificamos si el item esta gestionado por lotes
                if (varIteTieLote.ToUpper().Equals("Y")) { 
                    string varLotCodigo = drItemProducir["DetLote"].ToString(); //Recuperamos el codigo del lote

                    varOIGN.Lines.BatchNumbers.SetCurrentLine(0); //Nos posicionamos en la linea del lote recien creada
                    varOIGN.Lines.BatchNumbers.BatchNumber = varLotCodigo; //Codigo del lote que vamos a utilizar
                    varOIGN.Lines.BatchNumbers.Quantity = varDetCantidad;
                }

                iError = varOIGN.Add();
                if (!iError.Equals(0))
                {
                    csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                    return mError;
                }
                else
                {
                    int varDocEntrySAPEntrada = 0;
                    int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPEntrada);
                    varOIGN.GetByKey(varDocEntrySAPEntrada);
                    int varDocNumSAPEntrada = varOIGN.DocNum;

                    //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                    proActSAPDetActCstFormulacion(varDocEntrySAPEntrada, varDocNumSAPEntrada, varCabCodigo, varDetSecuencia, 2, varCosto);

                    drItemProducir["DetNumeroSAPEntrada"] = varDocNumSAPEntrada;
                    drItemProducir["DetCosto"] = varCosto;
                    drItemProducir.AcceptChanges();
                    return mError;
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }

        }
        //Funcion utilizada para enviar el diario a SAP
        private static string funEnviarDiarioSAP(string mError, //parametro utilizado para obtener el mensaje en caso de error
                                                                       int varCabCodigo, //parametro utilizado para obtener el key del documento
                                                                       int varCabNumero, //parametro que contendra el numero del documento
                                                                       int varDocCodigo, //parametro que contendra el codigo del documento
                                                                       int varDetSecuencia, //parametro que contendra la secuencia del detalle del documento
                                                                       string varDocNombre, //parametro que contendra el nombre del documento
                                                                       DateTime varFecha, //parametro que contendra la fecha del documento
                                                                       string varComenDiario, //parametro que contendra el comentario del diario
                                                                       string varMovimiento, //parametro que contendra el movimiento de la cuenta si es debe o haber
                                                                       double varValor, //parametro que contendra el valor del movimiento
                                                                       DataRow drItemProducir //parametro que contendra el item a producir
            )
        {
            try
            {
                int iError = 0;
                string varCodCtaContableWip = clsGenOpciones.CargarValor("C.Acp.Diario.CtaWip"); //Recuperamos el codigo de la cuenta contable WIP
                string varCodCtaContableDesviacion = clsGenOpciones.CargarValor("C.Acp.Diario.CtaDesv"); //Recuperamos el codigo de la cuenta contable DESVIACION
                string varCodCtaContableDebe = varMovimiento.Equals("Debe") ? varCodCtaContableWip : varCodCtaContableDesviacion; //Asignamos el codigo de la cuenta que va al debe
                string varCodCtaContableHaber = varMovimiento.Equals("Debe") ? varCodCtaContableDesviacion : varCodCtaContableWip; //Asignamos el codigo de la cuenta que va al haber

                //Instanciamos en la variable varOJDT el objeto de SAP de diarios contables
                SAPbobsCOM.JournalEntries varOJDT = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);

                //Cargamos informacion de la cabecera del diario contable
                varOJDT.Series = clsSegDocumento.funRecNumSerieSAPDiario(varDocCodigo);
                varOJDT.ReferenceDate = varFecha;
                varOJDT.DueDate = varFecha;
                varOJDT.TaxDate = varFecha;
                varOJDT.Memo = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia + " " + varComenDiario;
                varOJDT.Reference3 = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia;
                varOJDT.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                varOJDT.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                varOJDT.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;
                varOJDT.UserFields.Fields.Item("U_Ita_sysdocumento").Value = varDocNombre;
                varOJDT.UserFields.Fields.Item("U_Ita_sysnumero").Value = varCabNumero + " - " + varDetSecuencia;

                //Cargamos informacion de los detalles del diario contable
                
                //Informacion del debe
                varOJDT.Lines.SetCurrentLine(0);
                varOJDT.Lines.AccountCode = varCodCtaContableDebe;
                varOJDT.Lines.Debit = varValor;
                varOJDT.Lines.Credit = 0;
                varOJDT.Lines.LineMemo = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia + " " + varComenDiario;
                varOJDT.Lines.Reference1 = "";
                varOJDT.Lines.Reference2 = "";
                varOJDT.Lines.ReferenceDate2 = varFecha;
                varOJDT.Lines.TaxDate = varFecha;
                varOJDT.Lines.DueDate = varFecha;

                //Informacion del haber
                varOJDT.Lines.Add();
                varOJDT.Lines.SetCurrentLine(1);
                varOJDT.Lines.AccountCode = varCodCtaContableHaber;
                varOJDT.Lines.Debit = 0;
                varOJDT.Lines.Credit = varValor;
                varOJDT.Lines.LineMemo = varDocNombre + "-" + varCabNumero + "-" + varDetSecuencia + " " + varComenDiario;
                varOJDT.Lines.Reference1 = "";
                varOJDT.Lines.Reference2 = "";
                varOJDT.Lines.ReferenceDate2 = varFecha;
                varOJDT.Lines.TaxDate = varFecha;
                varOJDT.Lines.DueDate = varFecha;

                iError = varOJDT.Add();
                if (!iError.Equals(0))
                {
                    csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                    return mError;
                }
                else
                {
                    int varDocEntrySAPDiario = 0;
                    int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPDiario);
                    varOJDT.GetByKey(varDocEntrySAPDiario);
                    int varDocNumSAPDiario = varOJDT.Number;

                    //Actualizamos la linea del detalle con la informacion de SAP de la salida de mercancias en la tabla de detalle de actualizacion de costos de formulacion
                    proActSAPDetActCstFormulacion(varDocEntrySAPDiario, varDocNumSAPDiario, varCabCodigo, varDetSecuencia, 3, 0);

                    drItemProducir["DetNumeroSAPDiario"] = varDocNumSAPDiario;
                    drItemProducir.AcceptChanges();
                    return mError;
                }
            }
            catch (Exception e) { throw new Exception(e.Message); } 
        }
    }
}
