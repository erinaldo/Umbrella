using umbNegocio;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Data;
using umbDatos;
using umbNegocio.Seguridad;

namespace umbNegocio.Inventario
{
    public class clsInvMovimientoCab
    {
        #region Propiedades
        public int CabCodigo { get; set; }
        public int DocCodigo { get; set; }
        public int CabNumero { get; set; }
        public int IdMotivo { get; set; }
        
        public DateTime CabFecha { get; set; }

        public string DocNombre { get; set; }
        public string CabTipMovimiento { get; set; }
        public string BodCodigo { get; set; }
        public string CabRazon { get; set; }
        public string CabComentario { get; set; }
        public string CabComenDiario { get; set; }
        public string CcoCodigo { get; set; }
        public string PryCodigo { get; set; }
        public string EstCodigo { get; set; }
        public string Motivo { get; set; }
        public string CtaContable { get; set; }

        public Nullable<int> CabDocEntrySAP { get; set; }
        public Nullable<int> CabNumeroSAP { get; set; }

        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve el número de registros afectados luego de la tarea de inserción, actualización o eliminación de registro
        /// </summary>
        /// <param name="varOperacion">1=Inserción, 2=Actualización, 3=Eliminación</param>
        /// <param name="objDetalles">Detalles del movimiento de inventario</param>
        /// <returns></returns>
        public int funMantenimiento(int varOperacion, List<clsInvMovimientoDet> objDetalles)
        {

            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable detMovimiento = objDetalles.ToDataTable();
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proInv_MovimientoMantenimiento", CabCodigo, DocCodigo, CabNumero, IdMotivo, CabFecha, CabTipMovimiento, BodCodigo, CabRazon,
                                                                                                                                                                                                            CabComentario, CabComenDiario, CcoCodigo, PryCodigo, varOperacion, clsVariablesGlobales.varCodUsuario, 
                                                                                                                                                                                                            detMovimiento);
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Funcion utilizada para recuperar el listado de movimientos de inventario
        /// </summary>
        /// <param name="varWhere">Condicion para el listado de movimientos de inventario</param>
        /// <returns></returns>
        public static DataTable funListar(string varWhere)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proInv_MovimientoListar", DBNull.Value, varWhere);
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Funcion utilizada para recuperar un registro de los movimientos de inventario
        /// </summary>
        /// <param name="vId">Codigo del movimiento de inventario</param>
        /// <returns></returns>
        public static List<clsInvMovimientoCab> funListar(int vId)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            List<clsInvMovimientoCab> res = csAccesoDatos.GDatos.funTraerDataTable("dbo.proInv_MovimientoListar", vId, DBNull.Value).ToListOf<clsInvMovimientoCab>();
            csAccesoDatos.proFinalizarSesion();
            return res;
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe esta entrada de inventario
        /// </summary>
        /// <param name="varDocNombre">Nombre del documento</param>
        /// <param name="varCabNumero">Numero del documento</param>
        /// <returns></returns>
        public static DataTable funVerificarEntInventarioSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtEntrada = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGN a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtEntrada;
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Funcion utilizada para verificar si en SAP existe esta salida de inventario
        /// </summary>
        /// <param name="varDocNombre">Nombre del documento</param>
        /// <param name="varCabNumero">Numero del documento</param>
        /// <returns></returns>
        public static DataTable funVerificarSalInventarioSAP(string varDocNombre, int varCabNumero)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtMovimiento = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.DocEntry, a.DocNum From OIGE a Where a.U_Ita_sysdocumento = '{0}' and a.U_Ita_sysnumero = '{1}'", varDocNombre, varCabNumero));
                csAccesoDatos.proFinalizarSesion();
                return dtMovimiento;
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Procedimiento utilizado para anular los movimientos del inventario
        /// </summary>
        /// <param name="varCabCodigo">Codigo del movimiento del inventario</param>
        public static void proAnular(int varCabCodigo)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proInv_MovimientoAnulacion", varCabCodigo, "Anu", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        /// <summary>
        /// Procedimiento utilizado para actualizar los campos de SAP en los movimientos de inventario
        /// </summary>
        /// <param name="CabDocEntrySAP">Codigo docentry de SAP</param>
        /// <param name="CabNumeroSAP">Numero de SAP</param>
        /// <param name="DocCodigo">Codigo del documento</param>
        /// <param name="CabNumero">Numero del documento</param>
        public static void proActMovInventarioSalida(int? CabDocEntrySAP, int? CabNumeroSAP, int CabCodigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            csAccesoDatos.GDatos.funEjecutarSql(string.Format("Update INV_CABMOVIMIENTO Set CabDocEntrySap = {0}, CabNumeroSap = {1}, EstCodigo = 'Sap' Where CabCodigo = {2}", CabDocEntrySAP, CabNumeroSAP, CabCodigo));
            csAccesoDatos.proFinalizarSesion();
        }
        public string funEnviarSalMercanciaSAP()
        {
            try {
                string mError = "";
                int iError = 0;
                int i = 0;
                //Realizamos la conexion a SAP
                csAccesoDatos.proIniciarSesionSAP();
                //Verificamos si el documento ya se encuentra en SAP
                DataTable dtInventarioSAP = funVerificarSalInventarioSAP(DocNombre, CabNumero);
                if (dtInventarioSAP.Rows.Count > 0) {
                    //Recuperamos en las variables los valores de SAP
                    CabDocEntrySAP = int.Parse(dtInventarioSAP.Rows[0]["DocEntry"].ToString());
                    CabNumeroSAP = int.Parse(dtInventarioSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos en el movimiento los datos de SAP
                    proActMovInventarioSalida(CabDocEntrySAP, CabNumeroSAP, CabCodigo);
                    return mError;
                }
                else {
                    //Instanciamos la variable con el objeto de SAP Salida de mercancias
                    SAPbobsCOM.Documents varOIGE = csConexionSap.objConexionSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit);
                    
                    varOIGE.Series = clsSegDocumento.funRecNumSerieSAPSalida(DocCodigo); //Serie
                    varOIGE.DocDate = (DateTime)CabFecha; //Fecha de contabilización
                    varOIGE.TaxDate = (DateTime)CabFecha; //Fecha de documento
                    varOIGE.Comments = CabComentario; //Comentarios
                    varOIGE.JournalMemo = DocNombre + "-" + CabNumero + " " + CabComenDiario; //Comentario asiento contable
                    varOIGE.PaymentGroupCode = -2; //Lista de precios (Ultimo precio determinado)
                    //Valores del codigo y nombre del movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_codmovimiento").Value = IdMotivo.ToString(); //Codigo movimiento
                    varOIGE.UserFields.Fields.Item("U_Ita_movimiento").Value = Motivo; //Movimientos
                    //Valores de la auditoria del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysusuario").Value = clsVariablesGlobales.varCodUsuario; //Usuario del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysfecha").Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); //Fecha del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysip").Value = clsVariablesGlobales.varIpMaquina; //Ip del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysdocumento").Value = DocNombre; //Documento del sistema umbrella
                    varOIGE.UserFields.Fields.Item("U_Ita_sysnumero").Value = CabNumero.ToString(); //Numero del sistema umbrella
                    //Recuperamos informacion de los detalles del movimiento
                    List<clsInvMovimientoDet> objDetalle = new List<clsInvMovimientoDet>();
                   clsInvMovimientoDet.proListar(CabCodigo, out objDetalle);
                    //Recorremos los detalles del movimiento
                   foreach (clsInvMovimientoDet objFilaDetalle in objDetalle) {
                       //En caso de que la variable i se ha mayor a cero se debe agregar una nueva linea
                       if (!i.Equals(0)) varOIGE.Lines.Add();
                       varOIGE.Lines.SetCurrentLine(i);
                       varOIGE.Lines.WarehouseCode = BodCodigo; //Almacen
                       varOIGE.Lines.ItemCode = objFilaDetalle.IteCodigo; //Código
                       varOIGE.Lines.ItemDescription = objFilaDetalle.IteNombre; //Descripción
                       //Informacion de la chapeta en caso de que sea requerido la chapeta/lote
                       if (objFilaDetalle.DetIdDestino != null) {
                           if (objFilaDetalle.DetTipDestino.Equals("A")) varOIGE.Lines.UserFields.Fields.Item("U_Ita_arete").Value = objFilaDetalle.DetIdDestino; //Arete
                           else if (objFilaDetalle.DetTipDestino.Equals("L")) varOIGE.Lines.UserFields.Fields.Item("U_Ita_lote").Value = objFilaDetalle.DetIdDestino; //Lote
                       }
                       //Informacion de los valores del detalle
                       varOIGE.Lines.Quantity = double.Parse(objFilaDetalle.DetCantidad.ToString()); //Cantidad
                       varOIGE.Lines.AccountCode = CtaContable; //Compensación de stocks reducir cuenta
                       //Verificamos si tiene centro de costo
                       if (!CcoCodigo.Equals("")) varOIGE.Lines.CostingCode = CcoCodigo.Substring(0,2); //Centro de responsabilidad
                       if (!CcoCodigo.Equals("")) varOIGE.Lines.CostingCode2 = CcoCodigo.Substring(0, 3); //Centro de actividad
                       if (!CcoCodigo.Equals("")) varOIGE.Lines.CostingCode3 = CcoCodigo; //Centro de costo
                       //Verificamos si tiene proyecto
                       if (!PryCodigo.Equals("")) varOIGE.Lines.ProjectCode = PryCodigo; //Proyecto
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
                       //Actualizamos los costos de los movimientoes de inventario
                       proActCstAcumulado(varDocEntrySAPSalida, CabCodigo);
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
        /// Procedimiento utilizado para actualizar los costos del detalle de movimientos
        /// </summary>
        /// <param name="varDocEntry">Codigo del documento SAP</param>
        /// <param name="varCabCodigo">Codigo del documento del movimiento de inventario</param>
        public static void proActCstAcumulado(int? varDocEntry, int varCabCodigo)
        {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proInv_MovimientoActCstDetalle", varDocEntry, varCabCodigo, clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        
        #endregion


                
    }
}
