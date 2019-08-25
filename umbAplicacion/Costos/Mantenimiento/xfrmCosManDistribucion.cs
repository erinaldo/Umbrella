using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio.Costos;
using Umbrella;
using System.Linq;
using umbNegocio;
using System.Web.Script.Serialization;


namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManDistribucion : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        List<int> objCodNormasReparto;
        List<clsCosDetDistribucion> dtDetDistribucion;
        public xfrmCosManDistribucion() { InitializeComponent(); }
        public xfrmCosManDistribucion(int varFormulario, int varOperacion, int varRegistro, List<int> varLisNormaReparto) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
            objCodNormasReparto = varLisNormaReparto;
        }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Mantenimiento de distribución de costos";
                switch (varOpeCodigo) {
                    case 1:
                        this.proIniciarCampos();
                        break;
                    case 4:
                        clsCosDistribucion objDistribucion = new clsCosDistribucion();
                        objDistribucion.metConsultar(varRegCodigo);
                        if (objDistribucion.DetDistribucion != null) {
                            varDocCodigo = objDistribucion.DocCodigo;
                            this.txtCodigo.Text = objDistribucion.CabCodigo.ToString();
                            this.txtCodSerie.Text = objDistribucion.DocCodigo.ToString();
                            this.txtNomSerie.Text = objDistribucion.DocNombre;
                            this.txtNumero.Text = objDistribucion.CabNumero.ToString();
                            this.datFecha.EditValue = objDistribucion.CabFecha;
                            this.datFechaDesde.EditValue = objDistribucion.CabFechaDesde;
                            this.datFechaHasta.EditValue = objDistribucion.CabFechaHasta;
                            this.txtComentario.Text = objDistribucion.CabComentario;
                            this.txtReferencia1.Text = objDistribucion.CabReferencia1;
                            this.txtReferencia2.Text = objDistribucion.CabReferencia2;
                            this.txtSapNumero.Text = objDistribucion.CabNroSap.ToString();
                            //Detalles de distribución
                            dtDetDistribucion = new List<clsCosDetDistribucion>();
                            dtDetDistribucion = objDistribucion.DetDistribucion;
                            this.grcDetDistribucion.DataSource = dtDetDistribucion;
                        }
                        break;
                    default:
                        break;
                }
                //Verificamos los acceso del usuario al formulario\
                this.proAccesoFormulario();
                if (varOpeCodigo.Equals(4)) {
                    btnGrabar.Enabled = false;
                    btnExtraer.Enabled = false;
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        private void proIniciarCampos()
        {
            // Procedimiento para que el usuario escoja el documento a ingresar la informacion
            clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
            //Asignamos los valores recuperados del codigo del documento y nombre del documento
            varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text);
            varDocNombre = this.txtNomSerie.Text;
            //Iniciamos los campos con valores predefinidos
            this.txtCodigo.Text = "0";
            this.datFechaDesde.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); 
            this.datFechaHasta.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1).AddDays(-1);
            this.datFecha.DateTime = DateTime.Now;
            this.txtNumero.Text = "0";
            this.txtComentario.Text = "";
            this.txtReferencia1.Text = "";
            this.txtReferencia2.Text = "";
            this.txtSapNumero.Text = "0";
            //Iniciamos el objeto para el detalle de distribucion
            dtDetDistribucion = new List<clsCosDetDistribucion>();
            this.grcDetDistribucion.DataSource = dtDetDistribucion;
        }
        private void btnExtraer_Click(object sender, EventArgs e) {
            try {
                splashScreenManager1.ShowWaitForm();
                int i = 1;
                foreach (int varCcrCodigo in objCodNormasReparto) {
                    clsCosNormaReparto objNormaReparto = new clsCosNormaReparto();
                    objNormaReparto.metConsultar(varCcrCodigo);
                    //Recuperamos las cuentas contables vinculadas a la norma de reparto
                    List<clsCosDetPlanCuenta> objLisPlanCuenta = clsCosDetPlanCuenta.metConsultar(objNormaReparto.CcrCodigo);
                    foreach (clsCosDetPlanCuenta varFilaPlanCuenta in objLisPlanCuenta) {
                        //Recuperamos el saldo de la cuenta
                        DateTime varFecDesde = (DateTime)datFechaDesde.EditValue;
                        DateTime varFecHasta = (DateTime)datFechaHasta.EditValue;
                        decimal varSaldo = objNormaReparto.metConsultarSaldo(objNormaReparto.CcoCodigo, varFilaPlanCuenta.CccCodigo, varFecDesde, varFecHasta);
                        if (varSaldo > 0) {
                            //Insertamos en el listado la cuenta contable al haber
                            dtDetDistribucion.Add(new clsCosDetDistribucion(i, objNormaReparto.CcrCodigo, varFilaPlanCuenta.CdpLinea, 1, varFilaPlanCuenta.CccCodigo,
                                                                                                                        varFilaPlanCuenta.CccNombre, varFilaPlanCuenta.CccFormato, objNormaReparto.CcoCodigo,
                                                                                                                        objNormaReparto.CcoNombre, 0, varSaldo, decimal.Parse(String.Format("{0:0.00}", 100))));
                            i++;
                            //Recuperamos los centros de costo vinculados a la norma de reparto
                            List<clsCosDetCenCosto> objLisCenCosto = clsCosDetCenCosto.metConsultar(objNormaReparto.CcrCodigo, varFilaPlanCuenta.CdpLinea).OrderBy(p => p.CdeDiferencia).ToList();
                            decimal varSaldoAcumulado = varSaldo;
                            decimal varSaldoCenCosto = 0;
                            foreach (clsCosDetCenCosto varFilaCenCosto in objLisCenCosto) {
                                if (!varFilaCenCosto.CdeDiferencia) {
                                    varSaldoCenCosto = decimal.Round(varSaldo * (varFilaCenCosto.CdePorcentaje / 100), 2);
                                    varSaldoAcumulado = varSaldoAcumulado - varSaldoCenCosto;
                                }
                                else
                                    varSaldoCenCosto = varSaldoAcumulado;

                                //Insertamos en el listado la cuenta contable al haber
                                dtDetDistribucion.Add(new clsCosDetDistribucion(i, objNormaReparto.CcrCodigo, varFilaCenCosto.CdpLinea, varFilaCenCosto.CdeLinea,
                                                                                                                            varFilaPlanCuenta.CccCodigo, varFilaPlanCuenta.CccNombre, varFilaPlanCuenta.CccFormato,
                                                                                                                            varFilaCenCosto.CcoCodigo, varFilaCenCosto.CcoNombre, varSaldoCenCosto, 0,
                                                                                                                            varFilaCenCosto.CdePorcentaje));
                                i++;
                            }
                        }
                    }
                }
                this.grvDetDistribucion.RefreshData();
                splashScreenManager1.CloseWaitForm();
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proGrabar() {
            base.proGrabar();
            try{
                int varCabCodigo = int.Parse(this.txtCodigo.Text);
                int varDocCodigo = int.Parse(this.txtCodSerie.Text);
                String varDocNombre = this.txtNomSerie.Text;
                int varCabNumero = int.Parse(this.txtNumero.Text);
                int varCabNroSAP = int.Parse(this.txtSapNumero.Text);
                DateTime varCabFecha = (DateTime)this.datFecha.EditValue;
                DateTime varCabFechaDesde = (DateTime)this.datFechaDesde.EditValue;
                DateTime varCabFechaHasta = (DateTime)this.datFechaHasta.EditValue;
                String varCabComentario = this.txtComentario.Text;
                String varCabReferencia1 = this.txtReferencia1.Text;
                String varCabReferencia2 = this.txtReferencia2.Text;
                //Recuperamos y validamos los detalles de la distribucion de centros de costos
                List<clsCosDetDistribucion> objDetDistribucion = dtDetDistribucion.Where<clsCosDetDistribucion>(p => p.CccNombre != "").ToList();
                clsCosDistribucion objDistribucion = new clsCosDistribucion(varCabCodigo, varDocCodigo, varDocNombre, varCabNumero, varCabFecha, varCabFechaDesde, varCabFechaHasta, varCabComentario, varCabReferencia1, varCabReferencia2, varCabNroSAP, objDetDistribucion);
                objDistribucion.metValidarDatos();
                int varResultado = varOpeCodigo.Equals(1) ? objDistribucion.metInsertar() : objDistribucion.metModificar();
                if (varResultado >= 0) {
                    clsMensajesSistema.metMsgInformativo("Registro ingresado con exito");
                    splashScreenManager1.ShowWaitForm();
                    objDistribucion.metConsultar(varResultado);
                    int varNroSap = objDistribucion.metEnviarDocumentoSAP();
                    splashScreenManager1.CloseWaitForm();
                    if (varNroSap > 0)
                        clsMensajesSistema.metMsgInformativo("Registro enviado a sap");
                    else
                        clsMensajesSistema.metMsgError("Ocurrio un error el documento no fue enviado a SAP");
                } else if (varOpeCodigo.Equals(2))
                    clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgActualizar);
                this.Close();
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message);  splashScreenManager1.CloseWaitForm(); this.Close(); }
        }
    }
}
