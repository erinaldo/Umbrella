using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using umbNegocio.Finanzas;

namespace umbNegocio.Granja
{
    public class clsGraDosisAplicadas
    {
        #region Propiedades

        public int DapSecuencia { get; set; }
        public int AnmCodigoMadre { get; set; }
        public int AnmCodigoPadre { get; set; }
        public int DapDosis { get; set; }
        public Nullable<int> DapDocEntrySalidaSAP { get; set; }
        public Nullable<int> DapNumeroSalidaSAP { get; set; }
        public Nullable<int> CabCodigo { get; set; }

        public DateTime DapFecha { get; set; }

        public string AnmAlternativoPadre { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteUndInventario { get; set; }
        public string IteTieLote { get; set; }
        public string DapLote { get; set; }
        public string DapTipo { get; set; }

        #endregion
        #region Métodos
        /// <summary>
        /// Funcion utilizada para recuperar los registros de dosis aplicadas segun la madre
        /// </summary>
        /// <param name="anmCodigoMadre">Codigo de la chapeta de la madre</param>
        /// <returns></returns>
        public static List<clsGraDosisAplicadas> funListar(int anmCodigoMadre)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                List<clsGraDosisAplicadas> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_DosisAplicadasListar", anmCodigoMadre, DBNull.Value, false).ToListOf<clsGraDosisAplicadas>();
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar los registros de dosis aplicadas segun la madre y parto
        /// </summary>
        /// <param name="anmCodigoMadre">Codigo de la chapeta de la madre</param>
        /// <param name="cabCodigo">Codigo del parto</param>
        /// <returns></returns>
        public static List<clsGraDosisAplicadas> funListar(int anmCodigoMadre, int cabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                List<clsGraDosisAplicadas> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_DosisAplicadasListar", anmCodigoMadre, cabCodigo, true).ToListOf<clsGraDosisAplicadas>();
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Función utilizada para validar la fila de las dosis aplicadas
        /// </summary>
        /// <returns></returns>
        public string funValidarFila(int varDosisDisponibles)
        {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (AnmCodigoPadre.Equals(0)) return varMensaje = "El campo chapeta padre es requerido";
            if (IteCodigo.Equals("")) return varMensaje = "El campo item es requerido";
            if (DapLote.Equals("")) return varMensaje = "El campo lote es requerido";
            if (DapDosis.Equals(0)) return varMensaje = "El campo dosis aplicadas debe ser mayor a cero";
            if (DapDosis > varDosisDisponibles) return varMensaje = "El campo dosis aplicadas no puede ser mayor al de dosis disponibles";
            return varMensaje;
        }
        /// <summary>
        /// Funcion utilizada para recuperar los machos que tiene dosis disponibles
        /// </summary>
        /// <returns></returns>
        public static DataTable funRecMachos()
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_DosisAplicadasListarMachos");
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar los lotes del macho seleccionado
        /// </summary>
        /// <returns></returns>
        public static DataTable funRecLotes(string varAnmAlternativo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_DosisAplicadasListarLotes", varAnmAlternativo);
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recupera la ultima secuencia de las dosis aplicadas a la madre
        /// </summary>
        /// <param name="varAnmCodigo">Codigo interno de la madre</param>
        /// <returns></returns>
        public static int funRecSecuencia(int varAnmCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int res = (int)csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select Isnull(Max(DapSecuencia), 0) as Secuencia From GRA_DETAPLDOSIS a Where a.AnmCodigoMadre = {0}", varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="objDetalles">Detalles de las dosis aplicadas</param>
        /// <returns></returns>
        public int funMantenimiento(List<clsGraDosisAplicadas> objDetalles)
        {

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detDosisAplicadas = objDetalles.ToDataTable();
                int varCodigo = csAccesoDatos.GDatos.funTraerValorEscalar("proGra_DosisAplicadasMantenimiento", clsVariablesGlobales.varCodUsuario, detDosisAplicadas) == null ? 0 : 0;
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
        #region Métodos SAP
        //Funciones
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información de la salida de mercancia
        /// </summary>
        /// <returns></returns>
        public string funEnviarSalMercanciaSAP()
        {
            try {
                string mError = "";
                int iError = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtInventarioSAP = funVerificarSalInventarioSAP(AnmCodigoMadre, DapSecuencia);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtInventarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    DapDocEntrySalidaSAP = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    DapNumeroSalidaSAP = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(DapDocEntrySalidaSAP, DapNumeroSalidaSAP, AnmCodigoMadre, DapSecuencia);
                    return mError;
                }
                else
                { //En caso de no encontrarse en SAP
                    //Instanciamos la variable con el objeto de SAP Salida de mercancias
                    SAPbobsCOM.Documents varOIGE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
                    //Recuperamos la informacion de la tabla de parametrizaciones para la activación del animal
                    int varSerie = int.Parse(clsGenOpciones.CargarValor("G.Dos.Salida.CodSerie").ToString()); //Serie
                    int varCodMovimiento = int.Parse(clsGenOpciones.CargarValor("G.Dos.Salida.CodMov").ToString()); //Codigo movimiento
                    string varNomMovimiento = clsGenOpciones.CargarValor("G.Dos.Salida.NomMov"); //Movimientos
                    string varCodBodega = clsGenOpciones.CargarValor("G.Dos.Salida.CodBod"); //Bodega
                    string varComentario = "Salida por aplicacion de dosis";
                    string varCtaContable = clsFinPlaCuenta.GetAcctCodeDeMovimiento(IteCodigo, varCodMovimiento);
                    //Validamos si hay cuenta contable para el movimiento utilizado
                    if (string.IsNullOrEmpty(varCtaContable)) return "No se pudo obtener la cuenta contable para el movimiento de salida";
                    //Datos de cabecera de la salida de mercancia SAP
                    varOIGE.Series = varSerie; //Serie
                    varOIGE.DocDate = (DateTime)DapFecha; //Fecha de contabilización
                    varOIGE.TaxDate = (DateTime)DapFecha; //Fecha de documento
                    varOIGE.Comments = varComentario; //Comentarios
                    varOIGE.JournalMemo = varComentario;//Comentario asiento contable
                    varOIGE.PaymentGroupCode = -2; //Lista de precios (Ultimo precio determinado)
                    //Valores del codigo y nombre del movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento; //Codigo movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento; //Movimientos
                    //Valores de la auditoria del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysdocumento").Value = AnmCodigoMadre.ToString(); //Codigo interno del animal
                    varOIGE.UserFields.Fields.Item("U_Ita_sysnumero").Value = DapSecuencia.ToString(); //Chapeta del animal
                    //Datos de detalle de la salida de mercancia SAP
                    varOIGE.Lines.SetCurrentLine(0);
                    varOIGE.Lines.WarehouseCode = varCodBodega; //Almacen
                    varOIGE.Lines.ItemCode = IteCodigo; //Código
                    varOIGE.Lines.ItemDescription = IteNombre; //Descripción
                    varOIGE.Lines.UserFields.Fields.Item("U_Ita_arete").Value = AnmAlternativoPadre; //Arete
                    varOIGE.Lines.Quantity = double.Parse(DapDosis.ToString()); //Cantidad
                    varOIGE.Lines.AccountCode = varCtaContable; //Compensación de stocks reducir cuenta
                    //Verificamos si el item requiere lote
                    if (IteTieLote.ToUpper().Equals("Y"))
                    {
                        varOIGE.Lines.BatchNumbers.SetCurrentLine(0); //Nos posicionamos en la linea del lote recien creada
                        varOIGE.Lines.BatchNumbers.BatchNumber = DapLote; //Lote
                        varOIGE.Lines.BatchNumbers.Quantity = double.Parse(DapDosis.ToString()); //Cantidad lote
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
                        //Asignamos los valores obtenidos a los atributos de la clase
                        DapDocEntrySalidaSAP = varDocEntrySAPSalida;
                        DapNumeroSalidaSAP = varDocNumSAPSalida;

                        //Actualizamos en el movimiento los datos de SAP
                        proActMovInventarioSalida(varDocEntrySAPSalida, varDocNumSAPSalida, AnmCodigoMadre, DapSecuencia);
                        return mError;
                    }
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe esta salida
        /// </summary>
        /// <param name="varAnmCodigoMadre">Codigo interno de la madre</param>
        /// <param name="varDapSecuencia">Secuencial</param>
        /// <returns></returns>
        public static DataTable funVerificarSalInventarioSAP(int varAnmCodigoMadre, int varDapSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varAnmCodigoMadre, varDapSecuencia));
                csAccesoDatos.proFinalizarSesion();
                return dtMovimiento;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en la dosis aplicadas
        /// </summary>
        /// <param name="varDocEntrySalida">Codigo interno de SAP</param>
        /// <param name="varDocNumSalida">Codigo del documento de SAP</param>
        /// <param name="varAnmCodigoMadre">Codigo interno de la madre</param>
        /// <param name="varDapSecuencia">Secuencial</param>
        public static void proActMovInventarioSalida(int? varDocEntrySalida, int? varDocNumSalida, int varAnmCodigoMadre, int varDapSecuencia)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_DETAPLDOSIS set DapDocEntrySalidaSAP = {0}, DapNumeroSalidaSAP = {1}, EstCodigo = 'Sap' Where AnmCodigoMadre = {2} and DapSecuencia = {3}", varDocEntrySalida, varDocNumSalida, varAnmCodigoMadre, varDapSecuencia));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
