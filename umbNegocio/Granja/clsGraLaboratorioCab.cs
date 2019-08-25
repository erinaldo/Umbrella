using umbDatos;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data;
using umbNegocio.Seguridad;
using umbNegocio.Finanzas;
using umbNegocio.Inventario;

namespace umbNegocio.Granja
{
    public class clsGraLaboratorioCab
    {
        #region Propiedades
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int AnmCodigo { get; set; }
        public int CabDosis { get; set; }

        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string AnmAlternativo { get; set; }
        public string IteCodigo { get; set; }
        public string IteNombre { get; set; }
        public string CabLote { get; set; }
        public string BodCodigo { get; set; }
        public string CabComentario { get; set; }
        public string CabComenDiario { get; set; }
        public string EstCodigo { get; set; }

        public decimal CabCstInicial { get; set; }

        public Nullable<int> CabDocEntrySAPSalida { get; set; }
        public Nullable<int> CabNumeroSAPSalida { get; set; }
        public Nullable<int> CabDocEntrySAPEntrada { get; set; }
        public Nullable<int> CabNumeroSAPEntrada { get; set; }
        public Nullable<int> CabDocEntrySAPDiario { get; set; }
        public Nullable<int> CabNumeroSAPDiario { get; set; }
        #endregion
        
        #region Métodos públicos
        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="varOperacion">1=Inserción, 2=Actualización, 3=Eliminación</param>
        /// <param name="objDetalles">Detalles del laboratorio</param>
        /// <returns></returns>
        public int funMantenimiento(int varOperacion, List<clsGraLaboratorioDet> objDetalles)
        {

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detLaboratorio = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proGra_LaboratorioMantenimiento", CabCodigo, DocCodigo, CabNumero, AnmCodigo, CabDosis, CabFecha,
                                                                                                                                                                                                            AnmAlternativo, IteCodigo, IteNombre, CabLote, BodCodigo, CabCstInicial,
                                                                                                                                                                                                            CabComentario, CabComenDiario, varOperacion, clsVariablesGlobales.varCodUsuario,
                                                                                                                                                                                                            detLaboratorio);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar el listado de laboratorio
        /// </summary>
        /// <param name="varWhere">Condicion para el listado de laboratorio</param>
        /// <returns></returns>
        public static DataTable funListar(string varWhere)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_LaboratorioListar", DBNull.Value, varWhere);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Funcion utilizada para recuperar un registro del laboratorio
        /// </summary>
        /// <param name="vId">Codigo del laboratorio interno</param>
        /// <returns></returns>
        public static List<clsGraLaboratorioCab> funListar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsGraLaboratorioCab> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proGra_LaboratorioListar", vId, DBNull.Value).ToListOf<clsGraLaboratorioCab>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Procedimiento utilizado para anular los registros de laboratorio
        /// </summary>
        /// <param name="varCabCodigo">Codigo del registro de laboratorio interno</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proGra_LaboratorioAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
        #region Métodos para SAP
        //Funciones
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información de la salida de mercancia
        /// </summary>
        /// <returns></returns>
        public string funEnviarSalMercanciaSAP()
        {
            try
            {
                string mError = "";
                int iError = 0;
                int i = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtInventarioSAP = funVerificarSalInventarioSAP(DocNombre, CabNumero);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtInventarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    CabDocEntrySAPSalida = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    CabNumeroSAPSalida = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(CabDocEntrySAPSalida, CabNumeroSAPSalida, CabCodigo);
                    return mError;
                }
                else
                { //En caso de no encontrarse en SAP
                    //Instanciamos la variable con el objeto de SAP Salida de mercancias
                    SAPbobsCOM.Documents varOIGE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
                    //Recuperamos la informacion de la tabla de parametrizaciones para la activación del animal
                    int varSerie = clsSegDocumento.funRecNumSerieSAPSalida(DocCodigo); //Serie
                    int varCodMovimiento = int.Parse(clsGenOpciones.CargarValor("G.Lab.Salida.CodMov").ToString()); //Codigo movimiento
                    string varNomMovimiento = clsGenOpciones.CargarValor("G.Lab.Salida.NomMov"); //Movimientos
                    string varComenDiario = string.Format("Salida laboratorio nro: {0}-{1}", DocNombre, CabNumero);
                    //Datos de cabecera de la salida de mercancia SAP
                    varOIGE.Series = varSerie; //Serie
                    varOIGE.DocDate = (DateTime)CabFecha; //Fecha de contabilización
                    varOIGE.TaxDate = (DateTime)CabFecha; //Fecha de documento
                    varOIGE.Comments = CabComentario; //Comentarios
                    //varOIGE.JournalMemo = varComenDiario;//Comentario asiento contable
                    varOIGE.PaymentGroupCode = -2; //Lista de precios (Ultimo precio determinado)
                    //Valores del codigo y nombre del movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento; //Codigo movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento; //Movimientos
                    //Valores de la auditoria del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre; //Nombre del documento
                    varOIGE.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString(); //Numero del documento
                    //Datos de detalle de la salida de mercancia SAP
                    //Recuperamos informacion de los detalles del movimiento
                    List<clsGraLaboratorioDet> objDetalle = new List<clsGraLaboratorioDet>();
                    clsGraLaboratorioDet.proListar(CabCodigo, out objDetalle);
                    //Recorremos los detalles del movimiento
                    foreach (clsGraLaboratorioDet objFilaDetalle in objDetalle) {
                        string varCtaContable = clsFinPlaCuenta.GetAcctCodeDeMovimiento(objFilaDetalle.IteCodigo, varCodMovimiento);
                        //Validamos si hay cuenta contable para el movimiento utilizado
                        if (string.IsNullOrEmpty(varCtaContable)) return "No se pudo obtener la cuenta contable para el movimiento de salida";
                        //En caso de que la variable i se ha mayor a cero se debe agregar una nueva linea
                        if (!i.Equals(0)) varOIGE.Lines.Add();
                        varOIGE.Lines.SetCurrentLine(i);
                        varOIGE.Lines.WarehouseCode = BodCodigo; //Almacen
                        varOIGE.Lines.ItemCode = objFilaDetalle.IteCodigo; //Código
                        varOIGE.Lines.ItemDescription = objFilaDetalle.IteNombre; //Descripción
                        varOIGE.Lines.Quantity = double.Parse(objFilaDetalle.DetCantidad.ToString()); //Cantidad
                        varOIGE.Lines.AccountCode = varCtaContable; //Compensación de stocks reducir cuenta
                        int j = 0; //Variable utilizada para los lotes
                        //Verificamos si el item requiere lote
                        if (objFilaDetalle.IteTieLote.ToUpper().Equals("Y")) {
                            //Recuperamos la informacion de los lotes segun el item y la bodega
                            DataTable dtLote = clsInvItem.funRecLote(objFilaDetalle.IteCodigo, BodCodigo);
                            double varSaldo = dtLote.Rows.Count.Equals(0) ? 0 : double.Parse(dtLote.Compute("Sum(StkDisponible)", "").ToString());
                            double varCantidad = double.Parse(objFilaDetalle.DetCantidad.ToString());
                            //Verificamos si el saldo del item no cae en negativo con respecto a lo que se necesita
                            if (varCantidad > varSaldo) throw new Exception(string.Format("El Item {0} - {1} tiene un saldo de {2} y lo requerido es {3}", objFilaDetalle.IteCodigo, objFilaDetalle.IteNombre, varSaldo, varCantidad));
                            //Recorremos los lotes disponibles hasta cumplir con la candidad deseada
                            foreach (DataRow drLote in dtLote.Rows) {
                                string varLotCodigo = drLote["LotCodigo"].ToString(); //Recuperamos el codigo del lote
                                double varStkDisponible = double.Parse(drLote["StkDisponible"].ToString()); //Recuperamos la cantidad disponible de ese lote
                                //Agragamos una nueva linea de Lote
                                if (j > 0) varOIGE.Lines.BatchNumbers.Add();
                                varOIGE.Lines.BatchNumbers.SetCurrentLine(j); //Nos posicionamos en la linea del lote recien creada
                                varOIGE.Lines.BatchNumbers.BatchNumber = varLotCodigo; //Codigo del lote que vamos a utilizar
                                //Validamos si la cantidad que dispone el lote seleccionado es suficiente para la cantidad requerida
                                if (varCantidad <= varStkDisponible) {
                                    varOIGE.Lines.BatchNumbers.Quantity = varCantidad;
                                    break;
                                }
                                else {
                                    varOIGE.Lines.BatchNumbers.Quantity = varStkDisponible;
                                    varCantidad -= varStkDisponible;
                                    j++; //Secuencial utilizado para las lineas del lote
                                }
                            }
                        }
                        i++; //Secuencial utilizado para las lineas del detalle
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
                        CabDocEntrySAPSalida = varDocEntrySAPSalida;
                        CabNumeroSAPSalida = varDocNumSAPSalida;

                        //Actualizamos en el movimiento los datos de SAP
                        proActMovInventarioSalida(varDocEntrySAPSalida, varDocNumSAPSalida, CabCodigo);
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
        /// <param name="varDocNombre"Nombre del documento de laboratorio</param>
        /// <param name="varCabNumero">Codigo del registro de laboratorio</param>
        /// <returns></returns>
        public static DataTable funVerificarSalInventarioSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLaboratorio = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = {1}", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtLaboratorio;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información de la entrada de mercancia
        /// </summary>
        /// <returns></returns>
        public string funEnviarEntMercanciaSAP()
        {
            try
            {
                string mError = "";
                int iError = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtInventarioSAP = funVerificarEntInventarioSAP(DocNombre, CabNumero);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtInventarioSAP.Rows.Count > 0){
                    //Recuperamos en las variables los valores de SAP
                    CabDocEntrySAPEntrada = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    CabNumeroSAPEntrada = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(CabDocEntrySAPSalida, CabNumeroSAPSalida, CabCodigo);
                    return mError;
                }
                else {
                    //Instanciamos la variable con el objeto de SAP Entrada de mercancias
                    SAPbobsCOM.Documents varOIGN = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry);
                    //Recuperamos la informacion de la tabla de parametrizaciones para la activación del animal
                    int varSerie = clsSegDocumento.funRecNumSerieSAPEntrada(DocCodigo); //Serie
                    int varCodMovimiento = int.Parse(clsGenOpciones.CargarValor("G.Lab.Entrada.CodMov").ToString()); //Codigo movimiento
                    string varNomMovimiento = clsGenOpciones.CargarValor("G.Lab.Entrada.NomMov"); //Movimientos
                    string varComenDiario = string.Format("Entrada laboratorio: {0}-{1}", DocNombre, CabNumero); //Comentario, Comentario Diario
                    string varCtaContable = clsFinPlaCuenta.GetAcctCodeDeMovimiento(IteCodigo, varCodMovimiento); //Cuenta contable
                    string varIteTieLote = clsInvItem.funRecTieLote(IteCodigo); //Es gestionado por lote
                    decimal varCstAcumulado = clsGraCstAcumulado.funRecValorCstAcumulado(AnmCodigo, "Bla"); //Costo acumulado
                    decimal varCstStdAcumulado = clsGraCstStdAcumulado.funRecValorCstStdAcumulado(AnmCodigo, "Bla"); //Costo standar acumulado
                    decimal varCstSalida = funRecTotSalMercanciaSAP(CabDocEntrySAPSalida);
                    decimal varCstFormacion = CabCstInicial + varCstAcumulado + varCstStdAcumulado + varCstSalida;
                    decimal varCosto = decimal.Round(varCstFormacion / CabDosis, 4);
                    //Validamos si hay cuenta contable para el movimiento utilizado
                    if (string.IsNullOrEmpty(varCtaContable)) return "No se pudo obtener la cuenta contable para el movimiento de entrada";
                    //Datos de cabecera de la salida de mercancia SAP
                    varOIGN.Series = varSerie; //Serie
                    varOIGN.DocDate = (DateTime)CabFecha; //Fecha de contabilización
                    varOIGN.TaxDate = (DateTime)CabFecha; //Fecha de documento
                    varOIGN.Comments = CabComentario; //Comentarios
                    varOIGN.JournalMemo = varComenDiario;//Comentario asiento contable
                    varOIGN.PaymentGroupCode = -2; //Lista de precios (Ultimo precio determinado)
                    //Valores del codigo y nombre del movimiento
                    varOIGN.UserFields.Fields.Item("U_Ita_codmovimiento").Value = varCodMovimiento; //Codigo movimiento
                    varOIGN.UserFields.Fields.Item("U_Ita_movimiento").Value = varNomMovimiento; //Movimientos
                    //Valores de la auditoria del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                    varOIGN.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre; //Codigo del documento
                    varOIGN.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString(); //Niumero del documento
                    //Datos de detalle de la salida de mercancia SAP
                    varOIGN.Lines.SetCurrentLine(0);
                    varOIGN.Lines.WarehouseCode = BodCodigo; //Almacen
                    varOIGN.Lines.ItemCode = IteCodigo; //Código
                    varOIGN.Lines.ItemDescription = IteNombre; //Descripción
                    varOIGN.Lines.UserFields.Fields.Item("U_Ita_arete").Value = AnmAlternativo; //Arete
                    varOIGN.Lines.Quantity = double.Parse(CabDosis.ToString()); //Cantidad
                    varOIGN.Lines.UnitPrice = double.Parse(varCstFormacion.ToString()); //Costo
                    varOIGN.Lines.AccountCode = varCtaContable; //Compensación de stocks reducir cuenta
                    //Verificamos si el item requiere lote
                    if (varIteTieLote.ToUpper().Equals("Y")) {
                        varOIGN.Lines.BatchNumbers.SetCurrentLine(0); //Nos posicionamos en la linea del lote recien creada
                        varOIGN.Lines.BatchNumbers.BatchNumber = CabLote; //Lote
                        varOIGN.Lines.BatchNumbers.Quantity = double.Parse(CabDosis.ToString()); //Cantidad lote
                        varOIGN.Lines.BatchNumbers.AddmisionDate = (DateTime)CabFecha; //Fecha de admisión
                        varOIGN.Lines.BatchNumbers.ManufacturingDate = (DateTime)CabFecha; //Fecha de fabricación
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
                        proActMovInventarioEntrada(varDocEntrySAPEntrada, varDocNumSAPEntrada, CabCodigo);
                        //Actualizamos la depreciacion en el animal
                        clsGraAnimal.proActInfDepAcumulada(CabCstInicial, AnmCodigo);
                        return mError;
                    }
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
            finally { csAccesoDatos.proFinalizarSesionSAP(); }
        }
        /// <summary>
        /// Funcion utilizada para mandar a SAP la información del diario contable
        /// </summary>
        /// <returns></returns>
        public string funEnviarDiarioSAP()
        {
            try {
                string mError = "";
                int iError = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtDiarioSAP = funVerificarDiarioSAP(DocNombre, CabNumero);
                //Si el documento se encuentra en SAP actualizamos la información de este en la informacion del animal
                if (dtDiarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    CabDocEntrySAPDiario = int.Parse(dtDiarioSAP.Rows[0]["TransId"].ToString());
                    CabNumeroSAPDiario = int.Parse(dtDiarioSAP.Rows[0]["Number"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActDiario(CabDocEntrySAPDiario, CabNumeroSAPDiario, CabCodigo);
                    //Actualizamos  las lineas del detalle de actualizacion de costos
                    clsGraCstAcumulado.proActualizarCstAcumulado(AnmCodigo, CabFecha, "Bla", "GRA_DETLABORATORIO", "LABORATORIO", CabCodigo);
                    //Actualizamos  las lineas del detalle de actualizacion de costos standares
                    clsGraCstStdAcumulado.proActualizarCstStdAcumulado(AnmCodigo, CabFecha, "Bla", CabCodigo);
                    return mError;
                }
                else {
                    //Variable utilizadas para las cuentas contables parametrizadas
                    string varCodCtaContableWip = clsGenOpciones.CargarValor("G.Lab.Diario.CtaWip"); //Recuperamos el codigo de la cuenta contable para el costo inicial
                    string varCodCtaContableCstInicial = clsGenOpciones.CargarValor("G.Lab.Diario.CtaCstInicial"); //Recuperamos el codigo de la cuenta contable WIP
                    //Instanciamos en la variable varOJDT el objeto de SAP de diarios contables
                    SAPbobsCOM.JournalEntries varOJDT = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries);

                    //Cargamos informacion de la cabecera del diario contable
                    varOJDT.Series = clsSegDocumento.funRecNumSerieSAPDiario(DocCodigo);
                    varOJDT.ReferenceDate = CabFecha;
                    varOJDT.DueDate = CabFecha;
                    varOJDT.TaxDate = CabFecha;
                    varOJDT.Memo = string.Format("Diario de laboratorio: {0}-{1} {2}", DocNombre, CabNumero, CabComenDiario);
                    varOJDT.Reference3 = DocNombre + "-" + CabNumero;
                    varOJDT.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario;
                    varOJDT.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    varOJDT.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina;
                    varOJDT.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre;
                    varOJDT.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString();

                    //Cargamos informacion de los detalles del diario contable
                    decimal varCstTotal = 0;
                    int i = 0;
                    //Recuperamos la informacion del costo inicial
                    varOJDT.Lines.SetCurrentLine(i);
                    varOJDT.Lines.AccountCode = varCodCtaContableCstInicial;
                    varOJDT.Lines.Debit = 0;
                    varOJDT.Lines.Credit = double.Parse(CabCstInicial.ToString());
                    varOJDT.Lines.LineMemo = string.Format("Diario de laboratorio: {0}-{1} {2}", DocNombre, CabNumero, CabComenDiario);
                    varOJDT.Lines.Reference1 = "DEPRECIACION";
                    varOJDT.Lines.Reference2 = "";
                    varOJDT.Lines.ReferenceDate2 = CabFecha;
                    varOJDT.Lines.TaxDate = CabFecha;
                    varOJDT.Lines.DueDate = CabFecha;
                    varCstTotal += CabCstInicial;
                    i++;
                    //Recuperamos la informacion del costo acumulado
                    foreach (DataRow drFilaDetalle in clsGraCstAcumulado.funRecTableCstAcumulado(AnmCodigo, CabFecha, "Bla").Rows)
                    {
                        varOJDT.Lines.Add();
                        varOJDT.Lines.SetCurrentLine(i);
                        varOJDT.Lines.AccountCode = drFilaDetalle["CsaCtaCodigo"].ToString();
                        varOJDT.Lines.Debit = 0;
                        varOJDT.Lines.Credit = double.Parse(drFilaDetalle["CsaValor"].ToString());
                        varOJDT.Lines.LineMemo = string.Format("Diario de laboratorio: {0}-{1} {2}", DocNombre, CabNumero, CabComenDiario);
                        varOJDT.Lines.Reference1 = drFilaDetalle["CsaTipoSalida"].ToString();
                        varOJDT.Lines.Reference2 = "";
                        varOJDT.Lines.ReferenceDate2 = CabFecha;
                        varOJDT.Lines.TaxDate = CabFecha;
                        varOJDT.Lines.DueDate = CabFecha;
                        varCstTotal += decimal.Parse(drFilaDetalle["CsaValor"].ToString());
                        i++;
                    }
                    //Recuperamos la informacion del costo standar acumulado
                    foreach (DataRow drFilaDetalle in clsGraCstStdAcumulado.funRecTableCstStdAcumulado(AnmCodigo, CabFecha, "Bla").Rows)
                    {
                        varOJDT.Lines.Add();
                        varOJDT.Lines.SetCurrentLine(i);
                        varOJDT.Lines.AccountCode = drFilaDetalle["CdaCtaContableSalida"].ToString();
                        varOJDT.Lines.Debit = 0;
                        varOJDT.Lines.Credit = double.Parse(drFilaDetalle["CdaValor"].ToString());
                        varOJDT.Lines.LineMemo = string.Format("Diario de laboratorio: {0}-{1} {2}", DocNombre, CabNumero, CabComenDiario);
                        varOJDT.Lines.Reference1 = drFilaDetalle["CdaDetComentario"].ToString();
                        varOJDT.Lines.Reference2 = "";
                        varOJDT.Lines.ReferenceDate2 = CabFecha;
                        varOJDT.Lines.TaxDate = CabFecha;
                        varOJDT.Lines.DueDate = CabFecha;
                        varCstTotal += decimal.Parse(drFilaDetalle["CdaValor"].ToString());
                        i++;
                    }
                    //Informacion del haber
                    varOJDT.Lines.Add();
                    varOJDT.Lines.SetCurrentLine(i);
                    varOJDT.Lines.AccountCode = varCodCtaContableWip;
                    varOJDT.Lines.Debit = double.Parse(varCstTotal.ToString());
                    varOJDT.Lines.Credit = 0;
                    varOJDT.Lines.LineMemo = string.Format("Diario de laboratorio: {0}-{1} {2}", DocNombre, CabNumero, CabComenDiario);
                    varOJDT.Lines.Reference1 = "";
                    varOJDT.Lines.Reference2 = "";
                    varOJDT.Lines.ReferenceDate2 = CabFecha;
                    varOJDT.Lines.TaxDate = CabFecha;
                    varOJDT.Lines.DueDate = CabFecha;

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
                        proActDiario(varDocEntrySAPDiario, varDocNumSAPDiario, CabCodigo);
                        //Actualizamos  las lineas del detalle de actualizacion de costos
                        clsGraCstAcumulado.proActualizarCstAcumulado(AnmCodigo, CabFecha, "Bla", "GRA_DETLABORATORIO", "LABORATORIO", CabCodigo);
                        //Actualizamos  las lineas del detalle de actualizacion de costos standares
                        clsGraCstStdAcumulado.proActualizarCstStdAcumulado(AnmCodigo, CabFecha, "Bla", CabCodigo);
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
        /// <param name="varDocNombre"Nombre del documento de laboratorio</param>
        /// <param name="varCabNumero">Codigo del registro de laboratorio</param>
        /// <returns></returns>
        public static DataTable funVerificarEntInventarioSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = {1}", varDocNombre, varCabNumero));
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
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                decimal varSaldo = decimal.Parse(csAccesoDatos.GDatos.funTraerValorEscalarSql(string.Format("Select IsNull(Sum(b.Debit),0) as Total From OJDT a inner join JDT1 b on a.TransId = b.TransId Where a.TransType = 60 and a.CreatedBy = {0}", varDocEntrySalida)).ToString());
                csAccesoDatos.proFinalizarSesion();
                return varSaldo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe este diario
        /// </summary>
        /// <param name="varDocNombre">Nombre del documento de laboratorio</param>
        /// <param name="varCabNumero">Codigo del registro de laboratorio</param>
        /// <returns></returns>
        public static DataTable funVerificarDiarioSAP(string varDocNombre, int varCabNumero)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtDiario = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select TransId, Number From OJDT a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtDiario;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        //Procedimientos
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP el el registro de laboratorio
        /// </summary>
        /// <param name="varDocEntrySalida">Codigo interno de SAP</param>
        /// <param name="varDocNumSalida">Codigo del documento de SAP</param>
        /// <param name="varCabCodigo">Codigo interno del registro de laboratorio</param>
        public static void proActMovInventarioSalida(int? varDocEntrySalida, int? varDocNumSalida, int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_CABLABORATORIO set CabDocEntrySAPSalida = {0}, CabNumeroSAPSalida = {1} Where CabCodigo = {2}", varDocEntrySalida, varDocNumSalida, varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en el animal del sistema Umbrella
        /// </summary>
        /// <param name="varDocEntryEntrada">Codigo interno de SAP</param>
        /// <param name="varDocNumEntrada">Codigo del documento de SAP</param>
        /// <param name="varCabCodigo">Codigo interno del registro de laboratorio</param>
        public static void proActMovInventarioEntrada(int? varDocEntryEntrada, int? varDocNumEntrada, int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_CABLABORATORIO set CabDocEntrySAPEntrada = {0}, CabNumeroSAPEntrada = {1}, EstCodigo = 'Sap' Where CabCodigo = {2}", varDocEntryEntrada, varDocNumEntrada, varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar informacion de SAP en el sistema umbrella
        /// </summary>
        /// <param name="varDocEntryEntrada">Codigo interno de SAP</param>
        /// <param name="varDocNumEntrada">Codigo del documento de SAP</param>
        /// <param name="varCabCodigo">Codigo interno del registro de laboratorio</param>
        public static void proActDiario(int? varDocEntryDiario, int? varDocNumDiario, int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update GRA_CABLABORATORIO set CabDocEntrySAPDiario = {0}, CabNumeroSAPDiario = {1} Where CabCodigo = {2}", varDocEntryDiario, varDocNumDiario, varCabCodigo));
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar los costos del detalle de laboratorio
        /// </summary>
        /// <param name="varDocEntry">Codigo del documento SAP</param>
        /// <param name="varCabCodigo">Codigo del documento del movimiento de inventario</param>
        public static void proActCstAcumulado(int varDocEntry, int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proInv_MovimientoActCstDetalle", varDocEntry, varCabCodigo, clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
