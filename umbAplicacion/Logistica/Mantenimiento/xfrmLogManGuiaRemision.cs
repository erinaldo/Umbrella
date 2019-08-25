using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Logistica;
using umbNegocio.Seguridad;
using Umbrella;
using System.Linq;

namespace umbAplicacion.Logistica.Mantenimiento
{
    public partial class xfrmLogManGuiaRemision : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        /// <summary>
        /// Historial de modificaciones
        /// 1 21/11/2016 CAMC  Por petición de Klever Sempertegui se procedio a que en la guia de remision tambien se guarde el ayudante
        /// </summary>
        //Mantenimiento de guias de logistica
        private List<clsLogGuiaRemisionDetFac> objDetalleFac;
        private List<clsLogGuiaRemisionDetTra> objDetalleTra;

        List<int> lstEliminados = new List<int>();

        public xfrmLogManGuiaRemision() { InitializeComponent(); }
        public xfrmLogManGuiaRemision(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
       }

        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Guias de remision";
               //Cargamos los listados de mantenimiento que vamos a utilizar
                this.gluUsuario.Properties.DataSource = clsSegUsuario.funListarSAP();
                this.gluChofer.Properties.DataSource = clsLogChofer.funListarSAP();
                this.gluAyudante.Properties.DataSource = clsLogChofer.funListarSAP(); //1
                this.gluTransporte.Properties.DataSource = clsLogTransporte.funListarSAP();

                switch (varOpeCodigo) {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text);
                        varDocNombre = this.txtNomSerie.Text;
                        //Iniciamos los campos con valores predefinidos
                        this.datFecha.DateTime = DateTime.Now;
                        this.datFecSalida.DateTime = DateTime.Now;
                        this.datFecLlegada.DateTime = DateTime.Now.AddDays(1);
                        this.cmbMotivo.SelectedIndex = -1;
                        this.cmbMotivo.SelectedIndex = 0;
                        this.cmbTurno.SelectedIndex = 0;
                        this.txtNumero.Text = "0";
                        //Debemos instanciar la clase a la grilla para el ingreso de detalles factura
                        this.objDetalleFac = new List<clsLogGuiaRemisionDetFac>();
                        this.objDetalleFac.Add(new clsLogGuiaRemisionDetFac(0));
                        this.grcFacturas.DataSource = objDetalleFac;

                        //Debemos instanciar la clase a la grilla para el ingreso de detalles transferencia
                        this.objDetalleTra = new List<clsLogGuiaRemisionDetTra>();
                        this.objDetalleTra.Add(new clsLogGuiaRemisionDetTra(0));
                        this.grcTransferencia.DataSource = objDetalleTra;
                        
                        break;
                    case 2: //Opcion 2 para la operacion de modificar 
                    case 4: //Opcion 4 para la operacion de consultar
                        this.cmbMotivo.SelectedIndex = -1;

                        foreach (clsLogGuiaRemisionCab objRegistro in clsLogGuiaRemisionCab.funListar(varRegCodigo)) {
                            this.txtCodigo.EditValue = objRegistro.CabCodigo;
                            this.txtCodSerie.EditValue = objRegistro.DocCodigo;
                            this.txtNumero.EditValue = objRegistro.CabNumero;
                            this.txtCodSerie.EditValue = varDocCodigo = objRegistro.DocCodigo;

                            this.datFecha.EditValue = (DateTime)objRegistro.CabFecha;
                            this.datFecSalida.EditValue = (DateTime)objRegistro.CabFecSalida;
                            this.datFecLlegada.EditValue = (DateTime)objRegistro.CabFecLlegada;

                            this.txtNomSerie.Text = objRegistro.DocNombre;
                            this.gluUsuario.EditValue = objRegistro.UsuCodigo;
                            this.gluChofer.EditValue = objRegistro.ChfCodigo;
                            this.gluAyudante.EditValue = objRegistro.AyuCodigo; //1
                            this.gluTransporte.EditValue = objRegistro.TrnCodigo;
                            this.cmbTurno.Text = objRegistro.CabTurno;
                            this.cmbMotivo.Text = objRegistro.CabMotTraslado.Equals("V") ? "V - VENTA" : 
                                                                  objRegistro.CabMotTraslado.Equals("T") ? "T - TRANSFERENCIA" :
                                                                  objRegistro.CabMotTraslado.Equals("C") ? "C - SALIDA A CUENCA" :
                                                                  objRegistro.CabMotTraslado.Equals("I") ? "I - SALIDA A STA. ISABEL" : "R - SALIDA A STA. ROSA";

                            if (objRegistro.CabMotTraslado.Equals("V")) {
                                //Debemos instanciar la clase a la grilla para el ingreso de detalles
                                this.objDetalleFac = new List<clsLogGuiaRemisionDetFac>();
                                clsLogGuiaRemisionDetFac.proListar(varRegCodigo, out objDetalleFac);
                                //Verifico si el usuario a ingresado en el sistema SAP facturas vinculadas a la guia actual y si lo ha hecho verifico si ya se encuentra en la guia 
                                //en caso de no encontrarse en la guia agrego
                                int varCuantos = 0;
                                int varSecuencia = objDetalleFac.Count.Equals(0) ? 0 : objDetalleFac.Max(p => p.DetSecuencia);
                                foreach (DataRow objDetFactura in clsLogGuiaRemisionDetFac.funRecFacturaSAP (objRegistro.CabNumero).Rows){
                                    varCuantos = this.objDetalleFac.Where(p => p.DetFactura == int.Parse(objDetFactura["DetFactura"].ToString())).Count();
                                    if (varCuantos.Equals(0)) {
                                        clsLogGuiaRemisionDetFac objFilaFactura = new clsLogGuiaRemisionDetFac();
                                        objFilaFactura.DetSecuencia = ++varSecuencia;
                                        objFilaFactura.DetFactura = int.Parse(objDetFactura["DetFactura"].ToString());
                                        objFilaFactura.DetCodCliente = objDetFactura["DetCodCliente"].ToString();
                                        objFilaFactura.DetNomCliente = objDetFactura["DetNomCliente"].ToString();
                                        objFilaFactura.DetCredito = decimal.Parse(objDetFactura["DetCredito"].ToString());
                                        objFilaFactura.DetContado = decimal.Parse(objDetFactura["DetContado"].ToString());
                                        objFilaFactura.DetPeso = decimal.Parse(objDetFactura["DetPeso"].ToString());
                                        objFilaFactura.DetDocEntry = int.Parse(objDetFactura["DetDocEntry"].ToString());
                                        objDetalleFac.Add(objFilaFactura);
                                    }
                                }
                                this.objDetalleFac.Add(new clsLogGuiaRemisionDetFac(varSecuencia));
                                this.grcFacturas.DataSource = this.objDetalleFac;
                            }
                            else if (objRegistro.CabMotTraslado.Equals("T") || 
                                        objRegistro.CabMotTraslado.Equals("C") ||
                                        objRegistro.CabMotTraslado.Equals("I") ||
                                        objRegistro.CabMotTraslado.Equals("R")) {
                                //Debemos instanciar la clase a la grilla para el ingreso de detalles
                                this.objDetalleTra = new List<clsLogGuiaRemisionDetTra>();
                                clsLogGuiaRemisionDetTra.proListar(varRegCodigo, out objDetalleTra);
                                int varSecuencia = objDetalleTra.Count.Equals(0) ? 0 : objDetalleTra.Max(p => p.DetSecuencia);
                                this.objDetalleTra.Add(new clsLogGuiaRemisionDetTra(varSecuencia));
                                this.grcTransferencia.DataSource = this.objDetalleTra;
                            }
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        break;
                    default:
                        break;
                }
                //Verificamos los acceso del usuario al formulario\
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion guardar
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                //Eliminacion de los registros en blanco para las facturas
                if (this.cmbMotivo.Text.Substring(0, 1).Equals("V")) {
                    objDetalleFac.RemoveAll(p => p.DetCodCliente.Equals(""));
                    this.grcFacturas.RefreshDataSource();
                }
                //Eliminacion de los registros en blanco para las transferencias
                if (this.cmbMotivo.Text.Substring(0, 1).Equals("T") || 
                        this.cmbMotivo.Text.Substring(0, 1).Equals("C") ||
                        this.cmbMotivo.Text.Substring(0, 1).Equals("I") ||
                        this.cmbMotivo.Text.Substring(0, 1).Equals("R")) {
                    objDetalleTra.RemoveAll(p => p.DetCodBodOrigen.Equals(""));
                    this.grcTransferencia.RefreshDataSource();
                }
                //Verificamos las validaciones de los campos requeridos

                if (!varBanValidaciones) return;
               
                var csRegistro = new clsLogGuiaRemisionCab()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    DocNombre = this.txtNomSerie.Text,
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    CabFecha = (DateTime)this.datFecha.EditValue,
                    CabFecSalida = (DateTime)this.datFecSalida.EditValue,
                    CabFecLlegada = (DateTime)this.datFecLlegada.EditValue,
                    ChfCodigo = int.Parse(this.gluChofer.EditValue.ToString()),
                    ChfNombre = this.gluChofer.Text,
                    ChfCedula = clsLogChofer.funListarSAP(this.gluChofer.EditValue.ToString())[0].ChfIdentificacion,
                    AyuCodigo = int.Parse(this.gluAyudante.EditValue.ToString()), //1
                    AyuNombre = this.gluAyudante.Text, //1
                    AyuCedula = clsLogChofer.funListarSAP(this.gluAyudante.EditValue.ToString()).Count == 0 ? "" : clsLogChofer.funListarSAP(this.gluAyudante.EditValue.ToString())[0].ChfIdentificacion, //1
                    TrnCodigo = this.gluTransporte.EditValue.ToString(),
                    TrnNombre = this.gluTransporte.Text,
                    TrnPlaca = clsLogTransporte.funListarSAP(this.gluTransporte.EditValue.ToString())[0].TrnPlaca,
                    TrnTipo = clsLogTransporte.funListarSAP(this.gluTransporte.EditValue.ToString())[0].TrnTipo,
                    CabTurno = this.cmbTurno.Text,
                    CabMotTraslado = this.cmbMotivo.Text.Substring(0,1),
                    CabEstado = "A",
                    UsuCodigo = this.gluUsuario.EditValue.ToString(),
                    UsuNombre = this.gluUsuario.Text,
                    CabDocEnviado = "N",
                    CabDocTxt = "",
                    CabDocEstado = "0",
                    CabDocError = "",
                    CabDocAutorizacion = "",
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalleFac, objDetalleTra);

                switch (varOpeCodigo)
                {
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        if(lstEliminados.Count > 0) csRegistro.proActFacturasSAP(lstEliminados);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbMotivo.Text.Equals("V - VENTA")){
                    this.grcFacturas.Visible = true;
                    this.grcTransferencia.Visible = false;
                }
                else if (this.cmbMotivo.Text.Equals("T - TRANSFERENCIA") ||
                            this.cmbMotivo.Text.Equals("C - SALIDA A CUENCA") ||
                            this.cmbMotivo.Text.Equals("I - SALIDA A STA. ISABEL") ||
                            this.cmbMotivo.Text.Equals("R - SALIDA A STA. ROSA")) {
                    this.grcFacturas.Visible = false;
                    this.grcTransferencia.Visible = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluUsuario_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.gluUsuario.Properties.ImmediatePopup = true;
        }
        private void gluChofer_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.gluChofer.Properties.ImmediatePopup = true;
        }
        private void gluTransporte_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.gluTransporte.Properties.ImmediatePopup = true;
        }
        private void itxFactura_Leave(object sender, EventArgs e) {
            try {
                int varNroFactura = int.Parse((sender as TextEdit).Text);
                if (varNroFactura.Equals("") || varNroFactura.Equals(0)) return;
                if (this.colDetFactura.OptionsColumn.ReadOnly) return;
                if (this.objDetalleFac.Where(p => p.DetFactura == varNroFactura).Count() > 1) {
                    XtraMessageBox.Show("La factura ingresada ya se encuentra ingresada en la guia actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.grvFacturas.FocusedColumn = colDetSecuencia;
                    return;
                }
                DataTable dtFactura = clsLogGuiaRemisionDetFac.funRecFactura(varNroFactura);
                if (dtFactura.Rows.Count.Equals(0)) {
                    XtraMessageBox.Show("La factura ingresada no fue encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.grvFacturas.FocusedColumn = colDetSecuencia;
                    return;
                }
                else {
                    DataRow drFactura = dtFactura.Rows[0];  //Obtengo la primera fila de la consulta
                    clsLogGuiaRemisionDetFac objFilaFactura = (clsLogGuiaRemisionDetFac)this.grvFacturas.GetRow(this.grvFacturas.FocusedRowHandle);  //Obtengo la fila en la que se encuentra posicionado el usuario
                    objFilaFactura.DetCodCliente = drFactura["DetCodCliente"].ToString();
                    objFilaFactura.DetNomCliente = drFactura["DetNomCliente"].ToString();
                    objFilaFactura.DetCredito = (decimal)drFactura["DetCredito"];
                    objFilaFactura.DetContado = (decimal)drFactura["DetContado"];
                    objFilaFactura.DetPeso = (decimal)drFactura["DetPeso"];
                    objFilaFactura.DetDocEntry = (int)drFactura["DetDocEntry"];
                    
                    int varPosicionFila = this.grvFacturas.FocusedRowHandle;
                    int varNumeroFila = objDetalleFac.Max(p => p.DetSecuencia);
                    object varFilaNueva = this.grvFacturas.GetRowCellValue(this.grvFacturas.RowCount - 1, colDetSecuencia);

                    if (varFilaNueva == null || varFilaNueva == DBNull.Value){
                        if (this.grvFacturas.RowCount - 1 == 0)
                            this.objDetalleFac.Add(new clsLogGuiaRemisionDetFac(0));
                    }
                    else if (this.grvFacturas.FocusedRowHandle == this.grvFacturas.RowCount - 1)
                        this.objDetalleFac.Add(new clsLogGuiaRemisionDetFac(varNumeroFila));

                    if (varPosicionFila != this.grvFacturas.RowCount - 2) { 
                        this.grvFacturas.FocusedRowHandle = varPosicionFila; 
                        this.grvFacturas.FocusedColumn = colDetSecuencia; 
                    }
                    else { 
                        this.grvFacturas.FocusedRowHandle = varPosicionFila + 1; 
                        this.grvFacturas.FocusedColumn = colDetSecuencia; 
                    }
                    this.grcFacturas.RefreshDataSource();
                }

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvFacturas_ShowingEditor(object sender, CancelEventArgs e)
        {
            try {
                if (this.grvFacturas.FocusedColumn.Equals(colDetFactura)) {
                    if (this.grvFacturas.FocusedRowHandle.Equals(this.grvFacturas.RowCount - 1) || this.grvFacturas.FocusedRowHandle < 0)
                        this.colDetFactura.OptionsColumn.ReadOnly = false;
                    else
                        this.colDetFactura.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void itxTransferencia_Leave(object sender, EventArgs e) {
            try {
                int varNumero = int.Parse((sender as TextEdit).Text);
                if (varNumero.Equals("") || varNumero.Equals(0)) return;
                if (this.colDetNumero.OptionsColumn.ReadOnly) return;
                if (this.objDetalleTra.Where(p => p.DetNumero == varNumero).Count() > 1) {
                    XtraMessageBox.Show("El documento ingresado ya se encuentra en la guia actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.grvTransferencia.FocusedColumn = colDetSecuenciaTrf;
                    return;
                }

                DataTable dtTransferencia = null;
                if (this.cmbMotivo.Text.Equals("T - TRANSFERENCIA"))
                    dtTransferencia = clsLogGuiaRemisionDetTra.funRecTransferencia(varNumero);
                else
                    dtTransferencia = clsLogGuiaRemisionDetTra.funRecSalida(varNumero);

                if (dtTransferencia.Rows.Count.Equals(0)) {
                    XtraMessageBox.Show("El documento ingresado no fue encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.grvTransferencia.FocusedColumn = colDetSecuenciaTrf;
                    return;
                }
                else {
                    DataRow drTransferencia = dtTransferencia.Rows[0];                                                                                                      //Obtengo la primera fila de la consulta
                    clsLogGuiaRemisionDetTra objFilaTransferencia = (clsLogGuiaRemisionDetTra)this.grvTransferencia.GetRow(this.grvTransferencia.FocusedRowHandle);  //Obtengo la fila en la que se encuentra posicionado el usuario
                    objFilaTransferencia.DetCodBodOrigen = drTransferencia["DetCodBodOrigen"].ToString();
                    objFilaTransferencia.DetNomBodOrigen = drTransferencia["DetNomBodOrigen"].ToString();
                    objFilaTransferencia.DetCodBodDestino = drTransferencia["DetCodBodDestino"].ToString();
                    objFilaTransferencia.DetNomBodDestino = drTransferencia["DetNomBodDestino"].ToString();
                    objFilaTransferencia.DetPeso = (decimal)drTransferencia["DetPeso"];
                    objFilaTransferencia.DetPieza = int.Parse(drTransferencia["DetPieza"].ToString());
                    objFilaTransferencia.DetDocEntry = (int)drTransferencia["DetDocEntry"];

                    int varPosicionFila = this.grvTransferencia.FocusedRowHandle;
                    int varNumeroFila = objDetalleTra.Max(p => p.DetSecuencia);
                    object varFilaNueva = this.grvTransferencia.GetRowCellValue(this.grvTransferencia.RowCount - 1, colDetSecuencia);

                    if (varFilaNueva == null || varFilaNueva == DBNull.Value) {
                        if (this.grvTransferencia.RowCount - 1 == 0)
                            this.objDetalleTra.Add(new clsLogGuiaRemisionDetTra(0));
                    }
                    else if (this.grvTransferencia.FocusedRowHandle == this.grvTransferencia.RowCount - 1)
                        this.objDetalleTra.Add(new clsLogGuiaRemisionDetTra(varNumeroFila));

                    if (varPosicionFila != this.grvTransferencia.RowCount - 2) {
                        this.grvTransferencia.FocusedRowHandle = varPosicionFila;
                        this.grvTransferencia.FocusedColumn = colDetSecuencia; 
                    }
                    else { 
                        this.grvTransferencia.FocusedRowHandle = varPosicionFila + 1; 
                        this.grvTransferencia.FocusedColumn = colDetSecuencia; 
                    }
                    this.grcTransferencia.RefreshDataSource();
                }

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvTransferencia_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.grvTransferencia.FocusedColumn.Equals(colDetNumero))
                {
                    if (this.grvTransferencia.FocusedRowHandle.Equals(this.grvTransferencia.RowCount - 1) || this.grvTransferencia.FocusedRowHandle < 0)
                        this.colDetNumero.OptionsColumn.ReadOnly = false;
                    else
                        this.colDetNumero.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void smiEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grvFacturas.IsFocusedView) {
                    clsLogGuiaRemisionDetFac objFilaFactura = (clsLogGuiaRemisionDetFac)this.grvFacturas.GetRow(this.grvFacturas.FocusedRowHandle);
                    lstEliminados.Add(objFilaFactura.DetDocEntry);
                    objDetalleFac.Remove(objFilaFactura);
                    this.grcFacturas.RefreshDataSource();
                }
                else if (this.grvTransferencia.IsFocusedView) {
                    clsLogGuiaRemisionDetTra objFilaTransferencia = (clsLogGuiaRemisionDetTra)this.grvTransferencia.GetRow(this.grvTransferencia.FocusedRowHandle);
                    objDetalleTra.Remove(objFilaTransferencia);
                    this.grcTransferencia.RefreshDataSource();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
