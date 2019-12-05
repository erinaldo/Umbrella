using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.GestionBancos;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.GestionBancos.Listado
{
    public partial class xfrmGbaLisPagEfectuado : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        public xfrmGbaLisPagEfectuado() { InitializeComponent(); }
        public xfrmGbaLisPagEfectuado(bool varBandera) { InitializeComponent(); varBanListado = varBandera; }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Listado de pagos efectuados ";
                const string varNomFormulario = "umbAplicacion.GestionBancos.Listado.xfrmGbaLisPagEfectuado"; //Ubicación del formulario dentro del sistema
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Llenamos el listado de las cantidades permitidas para la facturación
                this.grcListado.DataSource = daoPagosEfectuados.getInstance().metListar();
                this.grvListado.OptionsBehavior.Editable = true;
                //Validaciones del listado
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoOperaciones(this, cmsMenuListado, clsVariablesGlobales.varCodUsuario, varCodFormulario, 1);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        private void btnEnviarSAP_Click(object sender, EventArgs e) {
            try {
                int varRegistro = 0;
                string varCheckNum = "";
                object[] objResultado = null;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((entOVPM)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocEntry;
                    varCheckNum = ((entOVPM)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CheckNum;
                    objResultado = daoPagosEfectuados.getInstance().metActualizarCommentario(varRegistro, varCheckNum);
                    if (objResultado[1].ToString().Equals("ok"))
                        clsMensajesSistema.metMsgInformativo("Registro actualizado");
                    else
                        clsMensajesSistema.metMsgError(objResultado[0].ToString());
                }
                foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((entOVPM)this.grvListado.GetRow(varPosicion)).DocEntry;
                    varCheckNum = ((entOVPM)this.grvListado.GetRow(varPosicion)).CheckNum;
                    objResultado = daoPagosEfectuados.getInstance().metActualizarCommentario(varRegistro, varCheckNum);
                    if (!objResultado[1].ToString().Equals("ok")) {
                        clsMensajesSistema.metMsgError(objResultado[0].ToString());
                        return;
                    }
                }
                clsMensajesSistema.metMsgInformativo("Registro actualizado");
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
