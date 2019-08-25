using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Inventario.Listado;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Logistica;

namespace umbAplicacion.Logistica.Mantenimiento
{
    public partial class xfrmLogManCantPermitida : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmLogManCantPermitida() { InitializeComponent(); }
        public xfrmLogManCantPermitida(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        public override void proIniciarFormulario() {
            base.proIniciarFormulario();
            try {
                this.Text = "Mantenimiento de cantidades permitidas en facturación";
                switch (varOpeCodigo) {
                    case 2:
                        clsLogCantPermitida objRegistro = clsLogCantPermitida.metListarRegistro(varRegCodigo);
                        if (objRegistro !=  null) {
                            this.txtCodigo.Text = objRegistro.Id.ToString();
                            this.txtNroFactura.Text = objRegistro.FacNumero.ToString();
                            this.txtNroLinea.Text = objRegistro.FacLinea.ToString();
                            this.bedIteCodigo.EditValue = objRegistro.IteCodigo;
                            this.txtIteNombre.Text = objRegistro.IteNombre;
                            this.txtCantPermitida.Text = objRegistro.CantPermitida.ToString();
                        }
                        break;
                }

                var csValidaciones = new Umbrella.clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
        public override void proGrabar() {
            base.proGrabar();
            try {
                int varId = int.Parse(this.txtCodigo.Text);
                int varNroFactura = int.Parse(this.txtNroFactura.Text);
                int varNroLinea = int.Parse(this.txtNroLinea.Text);
                string varIteCodigo = this.bedIteCodigo.EditValue == null ? "" : this.bedIteCodigo.EditValue.ToString();
                string varIteNombre = this.txtIteNombre.Text;
                decimal varCantPermitida = decimal.Parse(this.txtCantPermitida.Text);

                clsLogCantPermitida objClsCantPermitida = new clsLogCantPermitida(varId, varNroFactura, varNroLinea, varIteCodigo, varIteNombre, varCantPermitida);
                int varResultado = varOpeCodigo.Equals(1) ? objClsCantPermitida.metInsertar() : objClsCantPermitida.metModificar();
                if (varResultado >= 0) {
                    if (varOpeCodigo.Equals(1))
                        clsMensajesSistema.metMsgInformativo(string.Format(clsMensajesSistema.msgGuardar, varResultado));
                    else if (varOpeCodigo.Equals(2))
                        clsMensajesSistema.metMsgInformativo(clsMensajesSistema.msgActualizar);
                    this.Close();
                } 
            }
            catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        private void bedIteCodigo_EditValueChanged(object sender, EventArgs e) {
            try {
                string varIteCodigo = this.bedIteCodigo.Text.Trim();
                this.txtIteNombre.Text = "";

                if (varIteCodigo.Length < 8) return;
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)) {
                    this.bedIteCodigo.EditValue = csRegistro.ItemCode;
                    this.txtIteNombre.Text = csRegistro.ItemName;
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }

        private void bedIteCodigo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de item
                        this.bedIteCodigo.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtIteNombre.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            } catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
        }
    }
}
