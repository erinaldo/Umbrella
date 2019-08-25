using umbNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using umbNegocio.General;
using umbDatos;
using umbNegocio.Finanzas;
using umbNegocio.Inventario;

namespace umbNegocio.Granja
{
    public class clsGraAnimal
    {
       // #region Propiedades
        public int AnmCodigo { get; set; }
        public int IdLinea { get; set; }
        public int IdCasaOrigen { get; set; }
        public Nullable<int> AnmVidaUtil { get; set; }
        public Nullable<int> AnmDiasFormacion { get; set; }
        public Nullable<int> AnmDocEntrySAPEntrada { get; set; }
        public Nullable<int> AnmNumeroSAPEntrada { get; set; }
        public Nullable<int> AnmDocEntrySAPSalida { get; set; }
        public Nullable<int> AnmNumeroSAPSalida { get; set; }
        public Nullable<int> AnmDocEntrySAPDiario { get; set; }
        public Nullable<int> AnmNumeroSAPDiario { get; set; }

        public string BodCodigo { get; set; }
        public string AnmAlternativo { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string IteCodigoInicial { get; set; }
        public string IteNombreInicial { get; set; }
        public string BodCodigoInicial { get; set; }
        public string AnmIdPadre { get; set; }
        public string AnmIdMadre { get; set; }
        public string AnmObservacion { get; set; }
        public string IteCodigoActivacion { get; set; }
        public string IteNombreActivacion { get; set; }
        public string BodCodigoActivacion { get; set; }
        public string CcoCodigoActivacion { get; set; }
        public string AnmTipValorResidual { get; set; }
        public string AnmMotivoBaja { get; set; }
        public string AnmEstDesarrollo { get; set; }
        public string AnmEstCiclo { get; set; }
        public string EstCodigo { get; set; }
        public string Genero { get; set; }

        public DateTime AnmFecLlegada { get; set; }
        public Nullable<DateTime> AnmFecNacimiento { get; set; }
        public Nullable<DateTime> AnmFecActivacion { get; set; }
        public Nullable<DateTime> AnmFecBaja { get; set; }

        public decimal AnmCosto { get; set; }
        public Nullable<decimal> AnmNroTomasPartos { get; set; }
        public decimal AnmCstInicial { get; set; }
        public Nullable<decimal> AnmCstFormacion { get; set; }
        public Nullable<decimal> AnmCstBaja { get; set; }
        public decimal AnmPsoInicial { get; set; }
        public Nullable<decimal> AnmPsoFormacion { get; set; }
        public Nullable<decimal> AnmPsoVivo { get; set; }
        public Nullable<decimal> AnmPsoCanal { get; set; }
        public Nullable<decimal> AnmPorcenValorResidual { get; set; }
        public Nullable<decimal> AnmValorResidual { get; set; }
        public Nullable<decimal> AnmValorDepreciable { get; set; }
        public Nullable<decimal> AnmTPValorDepreciable { get; set; }
        public Nullable<decimal> AnmAcumValorDepreciable { get; set; }
        

        //Procedimiento utilizado para grabar la informacion de los animales
        public int funMantenimiento(int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                if (AnmFecNacimiento >= AnmFecLlegada) throw new Exception("El campo Fec nacimiento no puede ser mayor al campo Fec Llegada");
                if (AnmValorResidual == null && AnmPorcenValorResidual == null) throw new Exception("El campo Valor residual tiene que ser mayor a cero"); 
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_Animal",  AnmCodigo, IdLinea, IdCasaOrigen, AnmVidaUtil, AnmDiasFormacion, AnmAlternativo, IteCodigo, IteNombre,
                                                                                                                                                                              IteCodigoInicial, IteNombreInicial, BodCodigoInicial, AnmIdPadre, AnmIdMadre, AnmObservacion, 
                                                                                                                                                                              IteCodigoActivacion, IteNombreActivacion, BodCodigoActivacion, CcoCodigoActivacion, AnmTipValorResidual, AnmMotivoBaja, 
                                                                                                                                                                              AnmEstDesarrollo, AnmEstCiclo, EstCodigo, BodCodigo, AnmFecNacimiento, AnmFecLlegada, AnmFecActivacion, AnmFecBaja, AnmCosto,
                                                                                                                                                                              AnmNroTomasPartos, AnmCstInicial, AnmCstFormacion, AnmCstBaja, AnmPsoInicial, AnmPsoFormacion, AnmPsoVivo, 
                                                                                                                                                                              AnmPsoCanal, AnmPorcenValorResidual, AnmValorResidual, AnmValorDepreciable, AnmTPValorDepreciable,  varOperacion, 
                                                                                                                                                                              clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Funcion utilizada para recuperar la informacion del animal seleccionado
        public static List<clsGraAnimal> funListar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsGraAnimal> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_AnimalListar", vId, DBNull.Value).ToListOf<clsGraAnimal>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        //Funcion utilizada para recuperar la informacion de todos los animales
        public static DataTable funListar(string varWhere)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_AnimalListar", DBNull.Value, varWhere);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        //Function utilizada para recuperar los codigos de chapetas de los animales
        public static DataTable funRecAnimalesInventario()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTableSql("Select AnmAlternativo as DetBatchNro, 1 as DetBatchCantidad, IteCodigo as DetBatchIteCodigo From GRA_ANIMAL a Where a.EstCodigo = 'ACT'");
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Funcion utilizada para recuperar los animales machos
        /// </summary>
        /// <returns></returns>
        public static DataTable funRecAnimalesMachos()
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable res = csAccesoDatos.GDatos.funTraerDataTableSql("Select AnmCodigo, AnmAlternativo, AnmTPValorDepreciable, AnmValorDepreciable, isnull(AnmAcumValorDepreciable, 0) as AnmAcumValorDepreciable From GRA_ANIMAL a inner join GRA_LINEAGENETICA b on a.IdLinea = b.id and b.Genero = 'MACHO' Where a.AnmEstDesarrollo = 'PRODUCCION'");
                csAccesoDatos.proFinalizarSesion();
                return res;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #region Métodos para SAP
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
                DataTable dtInventarioSAP = funVerificarSalInventarioSAP(AnmCodigo, AnmAlternativo);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtInventarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    AnmDocEntrySAPSalida = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    AnmNumeroSAPSalida = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(AnmDocEntrySAPSalida, AnmNumeroSAPSalida, AnmCodigo);
                    return mError;
                }
                else { //En caso de no encontrarse en SAP
                    //Instanciamos la variable con el objeto de SAP Salida de mercancias
                    SAPbobsCOM.Documents varOIGE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
                    //Recuperamos la informacion de la tabla de parametrizaciones para la activación del animal
                    int varSerie = int.Parse(clsGenOpciones.CargarValor("G.Aca.Salida.CodSerie").ToString()); //Serie
                    int varCodMovimiento = int.Parse(clsGenOpciones.CargarValor("G.Aca.Salida.CodMov").ToString()); //Codigo movimiento
                    string varNomMovimiento = clsGenOpciones.CargarValor("G.Aca.Salida.NomMov"); //Movimientos
                    string varComentario = string.Format("Salida act animal chapeta nro: {0}", AnmAlternativo);
                    string varCtaContable = clsFinPlaCuenta.GetAcctCodeDeMovimiento(IteCodigoInicial, varCodMovimiento);
                    string varIteTieLote = clsInvItem.funRecTieLote(IteCodigoInicial);
                    //Validamos si hay cuenta contable para el movimiento utilizado
                    if (string.IsNullOrEmpty(varCtaContable)) return "No se pudo obtener la cuenta contable para el movimiento de salida";
                    //Datos de cabecera de la salida de mercancia SAP
                    varOIGE.Series = varSerie; //Serie
                    varOIGE.DocDate = (DateTime)AnmFecActivacion; //Fecha de contabilización
                    varOIGE.TaxDate = (DateTime)AnmFecActivacion; //Fecha de documento
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
                    varOIGE.UserFields.Fields.Item("U_Ita_sysdocumento").Value = AnmAlternativo; //Chapeta del animal
                    varOIGE.UserFields.Fields.Item("U_Ita_sysnumero").Value = AnmCodigo.ToString(); //Codigo interno del animal
                    //Datos de detalle de la salida de mercancia SAP
                    varOIGE.Lines.SetCurrentLine(0);
                    varOIGE.Lines.WarehouseCode = BodCodigoInicial; //Almacen
                    varOIGE.Lines.ItemCode = IteCodigoInicial; //Código
                    varOIGE.Lines.ItemDescription = IteNombreInicial; //Descripción
                    varOIGE.Lines.UserFields.Fields.Item("U_Ita_arete").Value = AnmAlternativo; //Arete
                    varOIGE.Lines.Quantity = (double)1; //Cantidad
                    varOIGE.Lines.AccountCode = varCtaContable; //Compensación de stocks reducir cuenta
                    //Verificamos si el item requiere lote
                    if (varIteTieLote.ToUpper().Equals("Y")) {
                        varOIGE.Lines.BatchNumbers.SetCurrentLine(0); //Nos posicionamos en la linea del lote recien creada
                        varOIGE.Lines.BatchNumbers.BatchNumber = AnmAlternativo; //Lote
                        varOIGE.Lines.BatchNumbers.Quantity = 1; //Cantidad lote
                    }
                    iError = varOIGE.Add();
                    if (!iError.Equals(0)){
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                        return mError;
                    }
                    else {
                        int varDocEntrySAPSalida = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPSalida);
                        varOIGE.GetByKey(varDocEntrySAPSalida);
                        int varDocNumSAPSalida = varOIGE.DocNum;
                        //Asignamos los valores obtenidos a los atributos de la clase
                        AnmDocEntrySAPSalida = varDocEntrySAPSalida;
                        AnmNumeroSAPSalida = varDocNumSAPSalida;

                        //Actualizamos en el movimiento los datos de SAP
                        proActMovInventarioSalida(varDocEntrySAPSalida, varDocNumSAPSalida, AnmCodigo);
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
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        /// <param name="varAnmAlternativo">Codigo de la chapeta del animal</param>
        /// <returns></returns>
        public static DataTable funVerificarSalInventarioSAP(int varAnmCodigo, string varAnmAlternativo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varAnmAlternativo, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtMovimiento;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información de la entrada de mercancia
        /// </summary>
        /// <returns></returns>
        public string funEnviarEntMercanciaSAP()
        {
            try {
                string mError = "";
                int iError = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtInventarioSAP = funVerificarEntInventarioSAP(AnmCodigo, AnmAlternativo);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtInventarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    AnmDocEntrySAPEntrada = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    AnmNumeroSAPEntrada = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(AnmDocEntrySAPSalida, AnmNumeroSAPSalida, AnmCodigo);
                    return mError;
                }
                else {
                    //Instanciamos la variable con el objeto de SAP Entrada de mercancias
                    SAPbobsCOM.Documents varOIGN = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);
                    //Recuperamos la informacion de la tabla de parametrizaciones para la activación del animal
                    int varSerie = int.Parse(clsGenOpciones.CargarValor("G.Aca.Entrada.CodSerie").ToString()); //Serie
                    int varCodMovimiento = int.Parse(clsGenOpciones.CargarValor("G.Aca.Entrada.CodMov").ToString()); //Codigo movimiento
                    string varNomMovimiento = clsGenOpciones.CargarValor("G.Aca.Entrada.NomMov"); //Movimientos
                    string varComentario = string.Format("Entrada act animal chapeta nro: {0}", AnmAlternativo); //Comentario, Comentario Diario
                    string varCtaContable = clsFinPlaCuenta.GetAcctCodeDeMovimiento(IteCodigoActivacion, varCodMovimiento); //Cuenta contable
                    string varIteTieLote = clsInvItem.funRecTieLote(IteCodigoInicial); //Es gestionado por lote
                    decimal varCstAcumulado = clsGraCstAcumulado.funRecValorCstAcumulado(AnmCodigo, "Bac"); //Costo acumulado
                    decimal varCstFormacion = AnmCstInicial + varCstAcumulado;
                    //Validamos si hay cuenta contable para el movimiento utilizado
                    if (string.IsNullOrEmpty(varCtaContable)) return "No se pudo obtener la cuenta contable para el movimiento de entrada";
                    //Datos de cabecera de la salida de mercancia SAP
                    varOIGN.Series = varSerie; //Serie
                    varOIGN.DocDate = (DateTime)AnmFecActivacion; //Fecha de contabilización
                    varOIGN.TaxDate = (DateTime)AnmFecActivacion; //Fecha de documento
                    varOIGN.Comments = varComentario; //Comentarios
                    varOIGN.JournalMemo = varComentario;//Comentario asiento contable
                    varOIGN.PaymentGroupCode = -2; //Lista de precios (Ultimo precio determinado)
                    //Valores del codigo y nombre del movimiento
                    varOIGN.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento; //Codigo movimiento
                    varOIGN.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento; //Movimientos
                    //Valores de la auditoria del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysdocumento").Value = AnmAlternativo; //Chapeta del animal 
                    varOIGN.UserFields.Fields.Item("U_Ita_sysnumero").Value = AnmCodigo.ToString(); //Codigo interno del animal
                    //Datos de detalle de la salida de mercancia SAP
                    varOIGN.Lines.SetCurrentLine(0);
                    varOIGN.Lines.WarehouseCode = BodCodigoActivacion; //Almacen
                    varOIGN.Lines.ItemCode = IteCodigoActivacion; //Código
                    varOIGN.Lines.ItemDescription = IteNombreActivacion; //Descripción
                    varOIGN.Lines.UserFields.Fields.Item("U_Ita_arete").Value = AnmAlternativo; //Arete
                    varOIGN.Lines.Quantity = (double)1; //Cantidad
                    varOIGN.Lines.UnitPrice = double.Parse(varCstFormacion.ToString()); //Costo
                    varOIGN.Lines.AccountCode = varCtaContable; //Compensación de stocks reducir cuenta
                    //Verificamos si el item requiere lote
                    if (varIteTieLote.ToUpper().Equals("Y")) {
                        varOIGN.Lines.BatchNumbers.SetCurrentLine(0); //Nos posicionamos en la linea del lote recien creada
                        varOIGN.Lines.BatchNumbers.BatchNumber = AnmAlternativo; //Lote
                        varOIGN.Lines.BatchNumbers.Quantity = 1; //Cantidad lote
                        varOIGN.Lines.BatchNumbers.AddmisionDate = (DateTime)AnmFecActivacion; //Fecha de admisión
                        varOIGN.Lines.BatchNumbers.ManufacturingDate = (DateTime)AnmFecActivacion; //Fecha de fabricación
                    }
                    iError = varOIGN.Add();
                    if (!iError.Equals(0)) {
                        csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                        return mError;
                    }
                    else {
                        int varDocEntrySAPEntrada = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPEntrada);
                        varOIGN.GetByKey(varDocEntrySAPEntrada);
                        int varDocNumSAPEntrada = varOIGN.DocNum;

                        //Actualizamos en el movimiento los datos de SAP
                        proActMovInventarioEntrada(varDocEntrySAPEntrada, varDocNumSAPEntrada, AnmCodigo);
                        //Actualizamos la informacion de la activacion
                        proActInfActivacion(AnmCodigo, IteCodigoActivacion, IteNombreActivacion, BodCodigoActivacion, AnmFecActivacion, varCstFormacion, AnmPsoFormacion, AnmValorResidual, AnmNroTomasPartos, AnmFecLlegada);
                        return mError;
                    }
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe esta entrada
        /// </summary>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        /// <param name="varAnmAlternativo">Codigo de la chapeta del animal</param>
        /// <returns></returns>
        public static DataTable funVerificarEntInventarioSAP(int varAnmCodigo, string varAnmAlternativo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varAnmAlternativo, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtMovimiento;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información del diario contable
        /// </summary>
        /// <returns></returns>
        public string funEnviaDiaContableSAP()
        {
            try {
                string mError = "";
                int iError = 0;
                //Recuperamos el valor del animal antes de los costos acumulados
                decimal varCstSalida = funRecTotSalMercanciaSAP(AnmDocEntrySAPSalida);
                //Verificamos si el costo inicial es diferente del costo de salida
                if (!AnmCstInicial.Equals(varCstSalida)) {
                    //Realizamos la conexion a SAP
                    csAccesoDatos.proIniciarSesionSAP();
                    //Verificamos si el documento ya se encuentra en SAP
                    DataTable dtDiarioSAP = funVerificarDiarioSAP(AnmCodigo, AnmAlternativo);
                    //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                    if (dtDiarioSAP.Rows.Count > 0) {
                        //Recuperamos en las variables los valores de SAP
                        AnmDocEntrySAPDiario = int.Parse(dtDiarioSAP.Rows[0]["TransId"].ToString());
                        AnmNumeroSAPDiario = int.Parse(dtDiarioSAP.Rows[0]["Number"].ToString());
                        //Actualizamos en el movimiento los datos de SAP
                        proActMovInventarioDiario(AnmDocEntrySAPSalida, AnmNumeroSAPSalida, AnmCodigo);
                        return mError;
                    }
                    else {
                        //Recuperamos información de la tabla de parametrizaciones para el diario contable
                        int varSerie = int.Parse(clsGenOpciones.CargarValor("G.Aca.Diario.CodSerie").ToString()); //Serie
                        string varCodCtaContableWip = clsGenOpciones.CargarValor("G.Aca.Diario.CtaWip"); //Cuenta contable WIP
                        string varCodCtaContableDesviacion = clsGenOpciones.CargarValor("G.Aca.Diario.CtaDesv"); //Cuenta contable DESVIACION
                        string varCodCtaContableDebe = AnmCstInicial > varCstSalida ? varCodCtaContableDesviacion : varCodCtaContableWip; //Cuenta contable para el debe
                        string varCodCtaContableHaber = AnmCstInicial > varCstSalida ? varCodCtaContableWip : varCodCtaContableDesviacion; //Cuenta contable para el haber
                        string varComentario = string.Format("Diario act animal chapeta nro: {0}", AnmAlternativo); //Comentario, Comentario Diario
                        double varValor = AnmCstInicial > varCstSalida ? double.Parse((AnmCstInicial - varCstSalida).ToString()) : double.Parse((varCstSalida - AnmCstInicial).ToString()); //Valor
                        //Instanciamos en la variable varOJDT el objeto de SAP de diarios contables
                        SAPbobsCOM.JournalEntries varOJDT = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);
                        //Cargamos informacion de la cabecera del diario contable
                        varOJDT.Series = varSerie; //Serie
                        varOJDT.ReferenceDate = (DateTime)AnmFecActivacion; //Fecha de contabilizacion
                        varOJDT.DueDate = (DateTime)AnmFecActivacion; //Fecha de vencimiento
                        varOJDT.TaxDate = (DateTime)AnmFecActivacion; //Fecha de documento
                        varOJDT.Memo = varComentario; //Comentario
                        varOJDT.Reference3 = AnmAlternativo; //Referencia 3
                        //Valores de la auditoria del sistema umbrella
                        varOJDT.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                        varOJDT.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                        varOJDT.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                        varOJDT.UserFields.Fields.Item("U_Ita_sysdocumento").Value = AnmAlternativo; //Codigo de la chapeta del animal
                        varOJDT.UserFields.Fields.Item("U_Ita_sysnumero").Value = AnmCodigo.ToString(); //Codigo interno del animal
                        //Cargamos información del detalle del diario contable
                        //Debe
                        varOJDT.Lines.SetCurrentLine(0);
                        varOJDT.Lines.AccountCode = varCodCtaContableDebe; //Cuenta contable
                        varOJDT.Lines.Debit = AnmCstInicial > varCstSalida ? varValor : 0; //Debe
                        varOJDT.Lines.Credit = AnmCstInicial > varCstSalida ? 0 : varValor; //Haber
                        varOJDT.Lines.LineMemo = varComentario; //Comentario
                        varOJDT.Lines.ReferenceDate2 = (DateTime)AnmFecActivacion; //Fecha de contabilizacion
                        varOJDT.Lines.TaxDate = (DateTime)AnmFecActivacion; //Fecha de documento
                        varOJDT.Lines.DueDate = (DateTime)AnmFecActivacion; //Fecha de vencimiento
                        //Haber
                        varOJDT.Lines.Add();
                        varOJDT.Lines.SetCurrentLine(1);
                        varOJDT.Lines.AccountCode = varCodCtaContableHaber; //Cuenta contable
                        varOJDT.Lines.Debit = AnmCstInicial > varCstSalida ? 0 : varValor; //Debe
                        varOJDT.Lines.Credit = AnmCstInicial > varCstSalida ? varValor : 0; //Haber
                        varOJDT.Lines.LineMemo = varComentario; //Comentario
                        varOJDT.Lines.ReferenceDate2 = (DateTime)AnmFecActivacion; //Fecha de contabilizacion
                        varOJDT.Lines.TaxDate = (DateTime)AnmFecActivacion; //Fecha de documento
                        varOJDT.Lines.DueDate = (DateTime)AnmFecActivacion; //Fecha de vencimiento

                        iError = varOJDT.Add();
                        if (!iError.Equals(0)) {
                            csConexionSap.objConexionSap.GetLastError(out iError, out mError);
                            return mError;
                        }
                        else {
                            int varDocEntrySAPDiario = 0;
                            int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey().ToString(), out varDocEntrySAPDiario);
                            varOJDT.GetByKey(varDocEntrySAPDiario);
                            int varDocNumSAPDiario = varOJDT.Number;

                            //Asignamos los valores obtenidos a los atributos de la clase
                            AnmDocEntrySAPSalida = varDocEntrySAPDiario;
                            AnmNumeroSAPSalida = varDocNumSAPDiario;

                            //Actualizamos en el movimiento los datos de SAP
                            proActMovInventarioDiario(varDocEntrySAPDiario, varDocNumSAPDiario, AnmCodigo);
                            return mError;
                        }
                    }
                }
                return mError;
            }
            catch (Exception e) { throw new Exception(e.Message); }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe este diario
        /// </summary>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        /// <param name="varAnmAlternativo">Codigo de la chapeta del animal</param>
        /// <returns></returns>
        public static DataTable funVerificarDiarioSAP(int varAnmCodigo, string varAnmAlternativo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.TransId, a.Number From OJDT a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varAnmAlternativo, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
                return dtMovimiento;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion para recuperar el valor de la salida de mercancia
        /// </summary>
        /// <param name="varDocEntrySalida">Codigo interno del documento de salida</param>
        /// <returns></returns>
        public static decimal funRecTotSalMercanciaSAP(int? varDocEntrySalida)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                decimal varSaldo = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(Sum(b.Debit),0) as Total From OJDT a inner join JDT1 b on a.TransId = b.TransId Where a.TransType = 60 and a.CreatedBy = {0}", varDocEntrySalida)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varSaldo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Procedimientos
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en el animal del sistema Umbrella
        /// </summary>
        /// <param name="varDocEntrySalida">Codigo interno de SAP</param>
        /// <param name="varDocNumSalida">Codigo del documento de SAP</param>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        public static void proActMovInventarioSalida(int? varDocEntrySalida, int? varDocNumSalida, int varAnmCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL set AnmDocEntrySAPSalida = {0}, AnmNumeroSAPSalida = {1} Where AnmCodigo = {2}", varDocEntrySalida, varDocNumSalida, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en el animal del sistema Umbrella
        /// </summary>
        /// <param name="varDocEntryEntrada">Codigo interno de SAP</param>
        /// <param name="varDocNumEntrada">Codigo del documento de SAP</param>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        public static void proActMovInventarioEntrada(int? varDocEntryEntrada, int? varDocNumEntrada, int varAnmCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL set AnmDocEntrySAPEntrada = {0}, AnmNumeroSAPEntrada = {1} Where AnmCodigo = {2}", varDocEntryEntrada, varDocNumEntrada, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en el animal del sistema Umbrella
        /// </summary>
        /// <param name="varDocEntryDiario">Codigo interno de SAP</param>
        /// <param name="varDocNumDiario">Codigo del documento de SAP</param>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        public static void proActMovInventarioDiario(int? varDocEntryDiario, int? varDocNumDiario, int varAnmCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL set AnmDocEntrySAPDiario = {0}, AnmNumeroSAPDiario = {1} Where AnmCodigo = {2}", varDocEntryDiario, varDocNumDiario, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procemiento utilizado para actualizar informacion de la activacion del animal
        /// </summary>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        /// <param name="varIteCodigo">Codigo del item de activacion</param>
        /// <param name="varIteNombre">Nombre del item de activacion</param>
        /// <param name="varBodCodigo">Codigo de la bodega de activacion</param>
        /// <param name="varFecha">Fecha de activacion</param>
        /// <param name="varCosto">Costo de activacion</param>
        /// <param name="varPeso">Peso de activacion</param>
        /// <param name="varResidual">Valor residual</param>
        /// <param name="varTomasPartos">Numero de tomas o partos</param>
        /// <param name="varFecLlegada">Fecha de llegada</param>
        public static void proActInfActivacion(int varAnmCodigo, string varIteCodigo, string varIteNombre, string varBodCodigo, DateTime? varFecha, decimal? varCosto, decimal? varPeso, decimal? varResidual, decimal? varTomasPartos, DateTime varFecLlegada)
        {
            try {

                decimal? varValDepreciable = varCosto - varResidual;
                decimal? varValDepreciableNroTomasPartos = varValDepreciable / varTomasPartos;
                TimeSpan varTiempo = (TimeSpan)(varFecha - varFecLlegada);
                int varDiasFormacion = varTiempo.Days;

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL Set IteCodigo = '{0}', IteNombre = '{1}', BodCodigo = '{2}', AnmCosto = {3}, AnmFecActivacion = '{4}', AnmCstFormacion = {3} , AnmPsoFormacion = {5}, AnmValorDepreciable = {7}, AnmTPValorDepreciable = {8}, AnmDiasFormacion = {9} Where AnmCodigo = '{6}'", varIteCodigo, varIteNombre, varBodCodigo, varCosto, varFecha, varPeso, varAnmCodigo, varValDepreciable, varValDepreciableNroTomasPartos, varDiasFormacion));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento para actulizar el estado de desarrollo
        /// </summary>
        /// <param name="varAnmCodigo">Codigo interno del animal</param>
        public static void proActEstDesarrollo(int varAnmCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL Set AnmEstDesarrollo = 'PRODUCCION' Where AnmCodigo = '{0}'", varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public static void proActInfDepAcumulada(decimal varValor, int varAnmCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_ANIMAL set AnmAcumValorDepreciable = isnull(AnmAcumValorDepreciable, 0) + {0} Where AnmCodigo = {1}", varValor, varAnmCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        #endregion
        /*
        
        
        public string Estado { get; set; }
        /// <summary>
        /// Código SAP OIGN de la entrada de mercadería
        /// </summary>
        public string OIGNActivaProduccion { get; set; }
        /// <summary>
        /// Código SAP OIGE de la salida de mercadería
        /// </summary>
        public string OIGEActivaProduccion { get; set; }

        public string UsuCrea { get; private set; }
        public string UsuIPCrea { get; private set; }
        public string Error { get; private set; }
        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve el Id del registro luego de la tarea de inserción, actualización o eliminación.
        /// Si es nuevo registro el estado siempre se guardará como ACTIVO.
        /// </summary>
        /// <param name="Operacion">1=Inserción/actualización, 3=Eliminación</param>
        /// <returns></returns>
        public int ejecutarMantenimiento(int Operacion)
        {
            int res = -1;
            try
            {
                Error = "";
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                res = (int)csAccesoDatos.GDatos.funTraerValorEscalar("dbo.SPGRA_ANIMAL", Id, IdAlternativo, OITMCode, IdLinea, IdCasaOrigen,
                    Nombre, Notas, FechaNacimiento, FechaIngreso, PesoKgIngreso, CostoInicial, IdPadre, IdMadre, Estado,
                    VidaUtilDias, CostoFormacion, PesoKgFormacion, TipoValorResidual, PorcentajeValorResidual, ValorResidual, 
                    PesoVivo, PesoCanal, FechaBaja, MotivoBaja,
                    Operacion, clsVariablesGlobales.varCodUsuario);
            }
            catch (Exception ex) { Error = ex.Message; }
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

       

        public DataTable ListarParaMovimientosInventario()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_ANIMALListarParaMovInventario");
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        public clsGraAnimal Cargar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            clsGraAnimal res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_ANIMALCargar", vId).ToListOf<clsGraAnimal>()[0];
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        /// Devuelve IdAlternativo y Descripcion de los animales que pueden ser padres de la misma especie. No se incluirá al animal actual.
        /// </summary>
        /// <param name="vIdActual">Id del animal actual. Nuevo=0</param>
        /// <returns></returns>
        public DataTable ListarPadres(int vIdActual, string vIdLineaGen)
        {

            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_ANIMALListarPadres", vIdActual, vIdLineaGen);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        /// Devuelve IdAlternativo y Descripcion de los animales que pueden ser madres de la misma especie. No se incluirá al animal actual.
        /// </summary>
        /// <param name="vIdActual">Id del animal actual. Nuevo=0</param>
        /// <returns></returns>
        public DataTable ListarMadres(int vIdActual, string vIdLinea)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGRA_ANIMALListarMadres", vIdActual, vIdLinea);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        /// <summary>
        /// Genera una orden de salida y entrada de mercaderías en SAP. Si la operación fue correcta devuelve OK.
        /// </summary>
        public string ActivarParaProduccion()
        {
            string res = "";
            DateTime hoy = DateTime.Now;
            
            csAccesoDatos.proIniciarSesionSAP();
            try
            {
                // Obtener códigos de cuentas contables para entrada y salida
                int paymentGroupNum = int.Parse(clsGenOpciones.CargarValor("A.Act.ListaPrecios"));
                string codMovSalida = clsGenOpciones.CargarValor("A.Act.Salida.CodMov");
                string codMovEntrada = clsGenOpciones.CargarValor("A.Act.Entrada.CodMov");
                string ctaContableSalida = clsFinPlaCuenta.GetAcctCodeDeMovimiento(OITMCode, codMovSalida);
                string ctaContableEntrada = clsFinPlaCuenta.GetAcctCodeDeMovimiento(OITMCode, codMovEntrada);
                if (string.IsNullOrEmpty(ctaContableSalida) || string.IsNullOrEmpty(ctaContableEntrada))
                {
                    return "No se pudo obtener la cuenta contable para el movimiento de salida y/o entrada";
                }

                if (Id > 0 && string.IsNullOrEmpty(OIGEActivaProduccion) && string.IsNullOrEmpty(OIGNActivaProduccion))
                {
                    // SALIDA DE MERCANCÍA OIGE
                    SAPbobsCOM.Documents oExit = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
                    // Header
                    oExit.DocDate = hoy;
                    oExit.TaxDate = hoy;
                    oExit.Series = int.Parse(clsGenOpciones.CargarValor("A.Act.Salida.Serie"));
                    oExit.PaymentGroupCode = paymentGroupNum;
                    oExit.UserFields.Fields.Item("U_Ita_sysip").Value = UsuIPCrea;
                    oExit.UserFields.Fields.Item("U_Ita_sysfecha").Value = hoy.ToString("dd/MM/yyyy");
                    oExit.UserFields.Fields.Item("U_Ita_sysusuario").Value = UsuCrea;
                    oExit.UserFields.Fields.Item("U_Ita_sysnumero").Value = Id.ToString();
                    oExit.UserFields.Fields.Item("U_Ita_codmovimiento").Value = codMovSalida;
                    oExit.UserFields.Fields.Item("U_Ita_movimiento").Value = clsGenOpciones.CargarValor("A.Act.Salida.NomMov");

                    //Recuperamos informacion el Item
                    clsInvItem objClsItem = clsInvItem.funListar(OITMCode)[0];

                    // Detalle 1 línea
                    oExit.Lines.SetCurrentLine(0);
                    oExit.Lines.ItemCode = OITMCode;
                    oExit.Lines.ItemDescription = Nombre;
                    oExit.Lines.Quantity = 1;
                    oExit.Lines.Price = double.Parse(objClsItem.AvgPrice.ToString());
                    oExit.Lines.WarehouseCode = clsGenOpciones.CargarValor("A.Act.Salida.Bodega");
                    oExit.Lines.AccountCode = ctaContableSalida;

                    // Lote (si el Item es batch)
                    if (objClsItem.ManBtchNum.Equals("Y"))
                    {
                        oExit.Lines.BatchNumbers.SetCurrentLine(0);
                        oExit.Lines.BatchNumbers.BatchNumber = IdAlternativo;
                        oExit.Lines.BatchNumbers.Quantity = 1;
                    }
                    
                    int iErrorExit = oExit.Add();

                    string sErrorExit = "";
                    if (iErrorExit != 0)
                    {
                        csConexionSap.objConexionSap.GetLastError(out iErrorExit, out sErrorExit);
                        res = string.Format("{0}: {1}", iErrorExit, sErrorExit);
                    }
                    else
                    {
                        // registrar asiento de desviación de costo si los el inicial y promedio son diferentes
                        double desviacionCosto = (double)(CostoInicial) - double.Parse(objClsItem.AvgPrice.ToString());
                        if (desviacionCosto != 0)
                        {
                            SAPbobsCOM.JournalEntries objJE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);
                            objJE.DueDate = objJE.ReferenceDate = objJE.TaxDate = hoy;
                            // Debe
                            objJE.Lines.SetCurrentLine(0);
                            objJE.Lines.Debit = Math.Abs(desviacionCosto);
                            if (desviacionCosto > 0)
                                objJE.Lines.AccountCode = clsGenOpciones.CargarValor("A.Act.CuentaWIP"); // CTA WIP
                            else
                                objJE.Lines.AccountCode = clsGenOpciones.CargarValor("A.Act.CuentaActBioF");  // CTA DESVIACIÓN

                            // Haber
                            objJE.Lines.Add();
                            objJE.Lines.SetCurrentLine(1);
                            objJE.Lines.Credit = Math.Abs(desviacionCosto);
                            if (desviacionCosto > 0)
                                objJE.Lines.AccountCode = clsGenOpciones.CargarValor("A.Act.CuentaActBioF"); // CTA DESVIACIÓN
                            else
                                objJE.Lines.AccountCode = clsGenOpciones.CargarValor("A.Act.CuentaWIP"); // CTA WIP

                            int iErrorDesviacion = objJE.Add();
                            string sErrorDesviacion = "";
                            if (iErrorDesviacion != 0)
                            {
                                csConexionSap.objConexionSap.GetLastError(out iErrorDesviacion, out sErrorDesviacion);
                                return "Se registró la salida de mercancía en SAP pero no se pudo registrar el asiento de desviación de costo.\n" + sErrorDesviacion;
                            }
                        }

                        // Actualizar el registro con OIGE.DocNum
                        int newDocExit = 0;
                        int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey(), out newDocExit);
                        oExit.GetByKey(newDocExit);
                        if (MarcarComoActivadoProdSalida(newDocExit))
                        {
                            // ENTRADA DE MERCANCÍA OIGN
                            SAPbobsCOM.Documents oEntry = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);
                            // Header
                            oEntry.DocDate = hoy;
                            oEntry.TaxDate = hoy;
                            oEntry.Series = int.Parse(clsGenOpciones.CargarValor("A.Act.Entrada.Serie"));
                            oEntry.PaymentGroupCode = paymentGroupNum;
                            oEntry.UserFields.Fields.Item("U_Ita_sysip").Value = UsuIPCrea;
                            oEntry.UserFields.Fields.Item("U_Ita_sysfecha").Value = hoy.ToString("dd/MM/yyyy");
                            oEntry.UserFields.Fields.Item("U_Ita_sysusuario").Value = UsuCrea;
                            oEntry.UserFields.Fields.Item("U_Ita_sysnumero").Value = Id.ToString();
                            oEntry.UserFields.Fields.Item("U_Ita_codmovimiento").Value = codMovEntrada;
                            oEntry.UserFields.Fields.Item("U_Ita_movimiento").Value = clsGenOpciones.CargarValor("A.Act.Entrada.NomMov");

                            // Detail 1 linea
                            decimal costosAcumulados = getTotalCostos("A", IdAlternativo);

                            oEntry.Lines.SetCurrentLine(0);
                            oEntry.Lines.ItemCode = OITMCode;
                            oEntry.Lines.ItemDescription = Nombre;
                            oEntry.Lines.AccountCode = ctaContableEntrada;
                            oEntry.Lines.Quantity = 1;
                            oEntry.Lines.UnitPrice = (double)CostoInicial + (double)costosAcumulados;
                            oEntry.Lines.WarehouseCode = clsGenOpciones.CargarValor("A.Act.Entrada.Bodega");

                            // Lote
                            if (objClsItem.ManBtchNum.Equals("Y"))
                            {
                                oEntry.Lines.BatchNumbers.SetCurrentLine(0);
                                oEntry.Lines.BatchNumbers.BatchNumber = IdAlternativo;
                                oEntry.Lines.BatchNumbers.Quantity = 1;
                            }

                            int iErrorEntry = oEntry.Add();

                            string sErrorEntry = "";
                            if (iErrorEntry != 0)
                            {
                                csConexionSap.objConexionSap.GetLastError(out iErrorEntry, out sErrorEntry);
                                res = string.Format("Se creó la salida de mercancía # {2} en SAP pero no se pudo crear la entrada. {0}: {1}", iErrorEntry, sErrorEntry, newDocExit);
                            }
                            else
                            {
                                // Actualizar el registro con OIGN.DocNum
                                int newDocEntry = 0;
                                int.TryParse(csConexionSap.objConexionSap.GetNewObjectKey(), out newDocEntry);
                                oEntry.GetByKey(newDocEntry);
                                if (MarcarComoActivadoProdEntrada(newDocEntry))
                                    res = "OK";
                                else
                                    res = string.Format("Se creó la salida de mercancía # {0} y entrada # {1} en SAP pero no se pudo registrar este número en el sistema local", newDocExit, newDocEntry);

                                oEntry = null;
                            }
                        }
                        else
                            res = string.Format("Se creó la salida de mercancía # {0} en SAP pero no se pudo registrar este número en el sistema local", newDocExit);

                        oExit = null;                        
                    }
                }
                else
                {
                    res = "El animal ya ha sido activado anteriormente";
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }

            csAccesoDatos.proFinalizarSesionSAP();
            return res;
        }

        public decimal getTotalCostos(string tipoDestino, string idDestino)
        {
            decimal res = 0;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable tab = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPCOS_COSTOMOVIMIENTOObtenerTotal", tipoDestino, idDestino);
            csAccesoDatos.proFinalizarSesion();
            if (tab != null && tab.Rows.Count > 0)
                res = decimal.Parse(tab.Rows[0][0].ToString());

            return res;
        }
        
        #endregion

        #region Metodos privados
        //20160624 JP
        /// <summary>
        /// Guarda el código generado al haber enviado una entrada de mercadería en SAP.
        /// La grabación de los valores OIGEActivaProduccion y OIGNActivaProduccion indica que el animal está activado para producción
        /// </summary>
        private bool MarcarComoActivadoProdEntrada(int newOIGNDocNum)
        {
            int res = 0;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            res = (int)csAccesoDatos.GDatos.funTraerValorEscalar("dbo.SPGRA_ANIMALMarcarComoEnviadoEntrada", Id, newOIGNDocNum, clsVariablesGlobales.varCodUsuario);
            csAccesoDatos.proFinalizarSesion();
            return (res > 0);
        }

        /// <summary>
        /// Guarda el código generado al haber enviado una salida de mercadería en SAP. 
        /// La grabación de los valores OIGEActivaProduccion y OIGNActivaProduccion indica que el animal está activado para producción
        /// </summary>
        private bool MarcarComoActivadoProdSalida(int newOIGEDocNum)
        {
            int res = 0;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            res = (int)csAccesoDatos.GDatos.funTraerValorEscalar("dbo.SPGRA_ANIMALMarcarComoEnviadoSalida", Id, newOIGEDocNum, clsVariablesGlobales.varCodUsuario);
            csAccesoDatos.proFinalizarSesion();
            return (res > 0);
        }
        #endregion
         
         */
    }
        
}
