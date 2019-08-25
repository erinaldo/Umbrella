using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio.Granja;
using System.Linq;
using umbNegocio.Inventario;
using umbAplicacion.Inventario.Listado;
using umbNegocio.Finanzas;
using umbAplicacion.Finanzas.Listado;
using umbNegocio.Seguridad;
using umbAplicacion.Seguridad.Listado;
using umbAplicacion.Granja.Auxiliar;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManParTraslado : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        List<clsGraParTrasladoDet> objDetalle;

        public xfrmGraManParTraslado()
        {
            InitializeComponent();
        }
        public xfrmGraManParTraslado(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varDocCodigo = 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Procedimiento para la inicializacion del formulario
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Verificamos los acceso del usuario al formulario
                this.proAccesoFormulario();
                this.Text = "Parametrizacion de traslados";
                //Verificamos cual es la operacion seleccionada
                switch (varOpeCodigo) { 
                    case 1: //Opcion 1 para la operacion de insertar
                        this.cmbVariante.Text = "A";
                        //Debemos instanciar la clase para la grilla de detalles
                        this.objDetalle = new List<clsGraParTrasladoDet>();
                        this.objDetalle.Add(new clsGraParTrasladoDet(0));
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                    case 4: //Opcion 4 para la operacion de eliminar
                        //Recuperamos la informacion y asignamos a los respectivos objetos
                        foreach (clsGraParTrasladoCab csRegistro in clsGraParTrasladoCab.funListar(varRegCodigo)) {
                            this.txtCodigo.EditValue = varRegCodigo;
                            this.txtDocCodigo.EditValue = csRegistro.DocCodigo;
                            this.txtCodSalidaSAP.EditValue = csRegistro.SAPCodSerieSalida;
                            this.txtCodEntradaSAP.EditValue = csRegistro.SAPCodSerieEntrada;
                            this.txtCodDiarioSAP.EditValue = csRegistro.SAPCodSerieDiario;

                            this.txtNombre.Text = csRegistro.PtrDescripcion;
                            this.cmbVariante.Text = csRegistro.PtrVariante;
                            this.bedItem.Text = csRegistro.IteCodigo;
                            this.txtIteNombre.Text = csRegistro.IteNombre;
                            this.bedDocumento.Text = csRegistro.DocNombre;
                            this.txtDocDescripcion.Text = csRegistro.DocDescripcion;
                            this.txtNomSalidaSAP.Text = csRegistro.SAPNomSerieSalida;
                            this.txtNomEntradaSAP.Text = csRegistro.SAPNomSerieEntrada;
                            this.txtNomDiarioSAP.Text = csRegistro.SAPNomSerieDiario;
                            this.txtCtaCodigo.Text = csRegistro.CtaDesCodigo;
                            this.txtCtaNombre.Text = csRegistro.CtaDesNombre;
                            this.bedCtaContable.Text = csRegistro.CtaDesFormato;

                            //Debemos instanciar la clase para la grilla de ingreso de detalles
                            this.objDetalle = new List<clsGraParTrasladoDet>();
                            clsGraParTrasladoDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia
                            int varSecuencia = objDetalle.Max(p => p.PtrSecuencia);
                            this.objDetalle.Add(new clsGraParTrasladoDet(varSecuencia));
                            this.grcListado.DataSource = objDetalle;
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion guardar
        public override void proGrabar()
        {
            base.proGrabar();
            try {
                //Eliminamos las filas vacias del detalle
                objDetalle.RemoveAll(p => p.IteCodigo.Equals(""));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                //Asignamos los valores de la propiedades de la clase animal
                var csRegistro = new clsGraParTrasladoCab()
                {
                    PtrCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtDocCodigo.Text.Equals("") ? 0 : int.Parse(this.txtDocCodigo.Text),
                    SAPCodSerieSalida = this.txtCodSalidaSAP.Text.Equals("") ? 0 : int.Parse(this.txtCodSalidaSAP.Text),
                    SAPCodSerieEntrada = this.txtCodEntradaSAP.Text.Equals("") ? 0 : int.Parse(this.txtCodEntradaSAP.Text),
                    SAPCodSerieDiario = this.txtCodDiarioSAP.Text.Equals("") ? 0 : int.Parse(this.txtCodDiarioSAP.Text),

                    PtrDescripcion = this.txtNombre.Text,
                    PtrVariante = this.cmbVariante.Text,
                    IteCodigo = this.bedItem.Text,
                    IteNombre = this.txtIteNombre.Text,
                    DocNombre = this.bedDocumento.Text,
                    DocDescripcion = this.txtDocDescripcion.Text,
                    SAPNomSerieSalida = this.txtNomSalidaSAP.Text,
                    SAPNomSerieEntrada = this.txtNomEntradaSAP.Text,
                    SAPNomSerieDiario = this.txtNomDiarioSAP.Text,
                    CtaDesCodigo = this.txtCtaCodigo.Text,
                    CtaDesNombre = this.txtCtaNombre.Text,
                    CtaDesFormato = this.bedCtaContable.Text
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalle);
                //Si no hay ningun error procedemos a mostrar el mensaje respectivo
                switch (varOpeCodigo)
                {
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con la nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                this.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Eventos del formulario
        //Eventos para el item
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Recuperamos el codigo del item digitado
                string varIteCodigo = this.bedItem.Text.Trim();
                this.txtIteNombre.Text = "";
                //Verificamos si el codigo digitado es de 8 a mas digitos
                if (varIteCodigo.Length < 8) return;
                //Recuperamos la informacion del código digitado
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)) {
                    this.bedItem.EditValue = csRegistro.ItemCode;
                    this.txtIteNombre.Text = csRegistro.ItemName;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtIteNombre.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos para la cuenta contable de desviacion
        private void bedCtaContable_EditValueChanged(object sender, EventArgs e)
        {
            try {
                //Recuperamos el codigo de la cuenta contable digitado
                string varFormatCode = this.bedCtaContable.Text.Trim();
                this.txtCtaNombre.Text = "";
                this.txtCtaCodigo.Text = "";
                //Verificamos si el codigo digitado es de 14 a mas digitos
                if (varFormatCode.Length < 14) return;
                //Recuperamos la informacion del código digitado
                foreach (clsFinPlaCuenta csRegistro in clsFinPlaCuenta.funListar(varFormatCode)) {
                    this.txtCtaNombre.Text = csRegistro.CueNombre;
                    this.txtCtaCodigo.Text = csRegistro.CueCodigo;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCtaContable_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                //Instanciamos al formulario listado de plan de cuentas
                using (xfrmFinLisPlaCuenta frmFormulario = new xfrmFinLisPlaCuenta(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedCtaContable.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueFormato;
                        this.txtCtaNombre.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueNombre;
                        this.txtCtaCodigo.Text = ((clsFinPlaCuenta)frmFormulario.DrVarFila[0]).CueCodigo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos para el documento
        private void bedDocumento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Recuperamos el codigo del documento digitado
                string varDocNombre = this.bedDocumento.Text.Trim();
                this.txtDocCodigo.Text = "";
                this.txtCodSalidaSAP.Text = "";
                this.txtCodEntradaSAP.Text = "";
                this.txtCodDiarioSAP.Text = "";
                this.txtDocDescripcion.Text = "";
                this.txtNomSalidaSAP.Text = "";
                this.txtNomEntradaSAP.Text = "";
                this.txtNomDiarioSAP.Text = "";
                //Verificamos si el codigo digitado es de 7 a mas digitos
                if (varDocNombre.Length < 7) return;
                //Recuperamos la informacion del código digitado
                foreach (clsSegDocumento csRegistro in clsSegDocumento.funListar(string.Format("Where a.DocNombre = '{0}'", varDocNombre)))
                {
                    this.txtDocCodigo.EditValue = csRegistro.DocCodigo;
                    this.txtCodSalidaSAP.EditValue = csRegistro.DocCodSAPSalida;
                    this.txtCodEntradaSAP.EditValue = csRegistro.DocCodSAPEntrada;
                    this.txtCodDiarioSAP.EditValue = csRegistro.DocCodSAPDiario;
                    this.bedDocumento.Text = csRegistro.DocNombre;
                    this.txtDocDescripcion.Text = csRegistro.DocDescripcion;
                    this.txtNomSalidaSAP.Text = csRegistro.DocNomSAPSalida;
                    this.txtNomEntradaSAP.Text = csRegistro.DocNomSAPEntrada;
                    this.txtNomDiarioSAP.Text = csRegistro.DocNomSAPDiario;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedDocumento_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de documentos
                using (xfrmSegLisDocumento frmFormulario = new xfrmSegLisDocumento(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos del documento
                        this.txtDocCodigo.EditValue = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocCodigo;
                        this.txtCodSalidaSAP.EditValue =((clsSegDocumento)frmFormulario.DrVarFila[0]).DocCodSAPSalida;
                        this.txtCodEntradaSAP.EditValue = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocCodSAPEntrada;
                        this.txtCodDiarioSAP.EditValue = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocCodSAPDiario;
                        this.bedDocumento.Text = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocNombre;
                        this.txtDocDescripcion.Text = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocDescripcion;
                        this.txtNomSalidaSAP.Text = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocNomSAPSalida;
                        this.txtNomEntradaSAP.Text = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocNomSAPEntrada;
                        this.txtNomDiarioSAP.Text = ((clsSegDocumento)frmFormulario.DrVarFila[0]).DocNomSAPDiario;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Eventos para las operaciones de agregar, quitar, actualizar
        private void ibuAgregar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                clsGraParTrasladoDet objFilaDetalle = (clsGraParTrasladoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                xfrmGraAuxParTraslado objFormulario = new xfrmGraAuxParTraslado(objFilaDetalle, 1);
                if (objFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    //Recuperamos la ultima secuencia
                    int varSecuencia = objDetalle.Max(p => p.PtrSecuencia);
                    this.objDetalle.Add(new clsGraParTrasladoDet(varSecuencia));
                    this.grcListado.RefreshDataSource();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ibuQuitar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                clsGraParTrasladoDet objFilaDetalle = (clsGraParTrasladoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                if (!objFilaDetalle.IteNombre.Equals("")) {
                    objDetalle.Remove(objFilaDetalle);
                    this.grcListado.RefreshDataSource();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ibuActualizar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try {
                clsGraParTrasladoDet objFilaDetalle = (clsGraParTrasladoDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                xfrmGraAuxParTraslado objFormulario = new xfrmGraAuxParTraslado(objFilaDetalle, 2);
                if (objFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.grcListado.RefreshDataSource();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}
