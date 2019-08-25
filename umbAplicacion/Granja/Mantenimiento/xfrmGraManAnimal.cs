using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.General;
using umbNegocio.Granja;
using Umbrella;
using umbNegocio.Inventario;
using umbAplicacion.Inventario.Listado;

namespace umbAplicacion.Granja.Mantenimiento
{
    public partial class xfrmGraManAnimal : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private clsValidacionesControles ctl = new clsValidacionesControles();
        public xfrmGraManAnimal()
        {
            InitializeComponent();
        }
        public xfrmGraManAnimal(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                varDocCodigo = 1;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Verificamos los acceso del usuario al formulario
                this.proAccesoFormulario();
                this.Text = "Informacion de animales";
                // Cargar combos, padres y madres se cargan luego de cboLinea.
                this.lueCasa.Properties.DataSource = clsGraCasaComercial.Listar();
                this.lueLinea.Properties.DataSource = clsGraLineaGenetica.Listar();
                this.lueBodIngreso.Properties.DataSource = clsGenBodega.funListar();
                this.lueBodActivacion.Properties.DataSource = clsGenBodega.funListar();
                this.lueBodega.Properties.DataSource = clsGenBodega.funListar();
                this.lueCcoActivacion.Properties.DataSource = clsDiccionario.Listar("GRAANIMALCENCOSTO");
                this.lueCcoActivacion.ItemIndex = 0;

                switch (varOpeCodigo)
                {
                    case 1:  //Opcion 1 para la operacion de insertar
                        this.txtEstCodigo.Text = "ACTIVO";
                        this.txtEstDesarrollo.Text = "FORMACION";
                        this.txtEstCiclo.Text = "VACIO";
                        this.lueCasa.ItemIndex = 0;
                        this.lueLinea.ItemIndex = 0;
                        this.datFecLlegada.EditValue = DateTime.Now;
                        this.cmbTipo.SelectedIndex = 0;
                        this.txtCstInicial.Text = "0";
                        this.txtCstFormacion.Text = "0";
                        this.txtCstBaja.Text = "0";
                        this.txtPsoInicial.Text = "0";
                        this.txtPsoFormacion.Text = "0";
                        this.txtPsoVivo.Text = "0";
                        this.txtPsoCanal.Text = "0";
                        this.txtVidaUtil.Text = "0";
                        this.txtDiasFormacion.Text = "0";
                        this.txtValDepreciableTP.Text = "0";
                        this.txtPorcenValorResidual.Text = "0";
                        this.txtValorResidual.Text = "0";
                        this.txtValDepreciable.Text = "0";
                        break;
                    case 2:  //Opcion 2 para la operacion de modificar
                    case 4:  //Opcion 4 para la operacion de consultar
                        //Recuperamos la informacion y asisgnamos a los respectivos objetos
                        foreach (clsGraAnimal csRegistro in clsGraAnimal.funListar(varRegCodigo))
                        {
                            this.txtId.Text = csRegistro.AnmCodigo.ToString();
                            this.lueLinea.EditValue = csRegistro.IdLinea;
                            this.lueCasa.EditValue = csRegistro.IdCasaOrigen.ToString();
                            this.txtVidaUtil.Text = csRegistro.AnmVidaUtil.ToString();
                            this.txtDiasFormacion.Text = csRegistro.AnmDiasFormacion.ToString();

                            this.txtIdAlt.Text = csRegistro.AnmAlternativo;
                            this.bedItemSAP.EditValue = csRegistro.IteCodigo;
                            this.txtItemNombreSAP.Text = csRegistro.IteNombre;
                            this.bedItemIngresoSAP.EditValue = csRegistro.IteCodigoInicial;
                            this.txtItemIngresoSAP.Text = csRegistro.IteNombreInicial;
                            this.lueBodIngreso.EditValue = csRegistro.BodCodigoInicial;
                            this.txtIdPadre.Text = csRegistro.AnmIdPadre;
                            this.txtIdMadre.Text = csRegistro.AnmIdMadre;
                            this.memObservacion.Text = csRegistro.AnmObservacion;
                            this.bedItemActivacionSAP.EditValue = csRegistro.IteCodigoActivacion;
                            this.txtItemActivacionSAP.Text = csRegistro.IteNombreActivacion;
                            this.lueBodActivacion.EditValue = csRegistro.BodCodigoActivacion;
                            this.lueCcoActivacion.EditValue = csRegistro.CcoCodigoActivacion;
                            this.cmbTipo.Text = csRegistro.AnmTipValorResidual.ToString();
                            this.txtMotivoBaja.Text = csRegistro.AnmMotivoBaja;
                            this.txtEstDesarrollo.Text = csRegistro.AnmEstDesarrollo.Equals("") ? "FORMACION" : csRegistro.AnmEstDesarrollo;
                            this.txtEstCiclo.Text = csRegistro.AnmEstCiclo.Equals("") ? "VACIO" : csRegistro.AnmEstCiclo;
                            this.txtEstCodigo.Text = csRegistro.EstCodigo.Equals("") ? "ACTIVO" : csRegistro.EstCodigo.ToUpper();
                            this.lueBodega.EditValue = csRegistro.BodCodigo;

                            this.datFecLlegada.EditValue = csRegistro.AnmFecLlegada;
                            this.datFecNacimiento.EditValue = csRegistro.AnmFecNacimiento;
                            this.datFecActivacion.EditValue = csRegistro.AnmFecActivacion;
                            this.datFecBaja.EditValue = csRegistro.AnmFecBaja;

                            this.txtNroTomasPartos.Text = csRegistro.AnmNroTomasPartos == null ? "0" : csRegistro.AnmNroTomasPartos.ToString();
                            this.txtCstInicial.Text = csRegistro.AnmCstInicial.ToString();
                            this.txtCstFormacion.Text = csRegistro.AnmCstFormacion == null ? "0" : csRegistro.AnmCstFormacion.ToString();
                            this.txtCstBaja.Text = csRegistro.AnmCstBaja == null ? "0" : csRegistro.AnmCstBaja.ToString();
                            this.txtPsoInicial.Text = csRegistro.AnmPsoInicial.ToString();
                            this.txtPsoFormacion.Text = csRegistro.AnmPsoFormacion == null ? "0" : csRegistro.AnmPsoFormacion.ToString();
                            this.txtPsoVivo.Text = csRegistro.AnmPsoVivo == null ? "0" : csRegistro.AnmPsoVivo.ToString();
                            this.txtPsoCanal.Text = csRegistro.AnmPsoCanal == null ? "0" : csRegistro.AnmPsoCanal.ToString();
                            this.txtPorcenValorResidual.Text = csRegistro.AnmPorcenValorResidual == null ? "0" : csRegistro.AnmPorcenValorResidual.ToString();
                            this.txtValorResidual.Text = csRegistro.AnmValorResidual == null ? "0" : csRegistro.AnmValorResidual.ToString();
                            this.txtValDepreciable.Text = csRegistro.AnmValorDepreciable == null ? "0" : csRegistro.AnmValorDepreciable.ToString();
                            this.txtValDepreciableTP.Text = csRegistro.AnmTPValorDepreciable == null ? "0" : csRegistro.AnmTPValorDepreciable.ToString();
                            this.txtValDepreciableAcum.Text = csRegistro.AnmAcumValorDepreciable == null ? "0" : csRegistro.AnmAcumValorDepreciable.ToString();
                            this.txtCosto.Text = csRegistro.AnmCosto.ToString();
                            //En caso de que el item haya sido puesto en produccion ya no puede modificar los siguietnes campos
                            if (csRegistro.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION")) {
                                this.bedItemActivacionSAP.Enabled = false;
                                this.txtItemActivacionSAP.Enabled = false;
                                this.lueBodActivacion.Enabled = false;
                                this.txtDiasFormacion.Enabled = false;
                                this.txtVidaUtil.Enabled = false;
                                this.txtNroTomasPartos.Enabled = false;
                                this.cmbTipo.Enabled = false;
                                this.txtPorcenValorResidual.Enabled = false;
                                this.txtValorResidual.Enabled = false;
                                this.txtValDepreciable.Enabled = false;
                            }
                            //Validamos los colores en caso de que este activo o inactivo
                            if (csRegistro.EstCodigo.ToUpper().Equals("ACT")) this.txtEstCodigo.ForeColor = System.Drawing.Color.Black;
                            else this.txtEstCodigo.ForeColor = System.Drawing.Color.Red;
                        }
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try {
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Asignamos los valores de la propiedades de la clase animal
                var csRegistro = new clsGraAnimal() {
                    AnmCodigo = this.txtId.Text.Equals("") ? 0 : int.Parse(this.txtId.Text),
                    IdLinea = int.Parse(lueLinea.EditValue.ToString()),
                    IdCasaOrigen = int.Parse(lueCasa.EditValue.ToString()),
                    AnmVidaUtil = this.txtVidaUtil.Text.Equals("0") ? (int?)null : int.Parse(this.txtVidaUtil.Text),
                    AnmDiasFormacion = this.txtDiasFormacion.Text.Equals("0") ? (int?)null : int.Parse(this.txtDiasFormacion.Text),

                    AnmAlternativo = this.txtIdAlt.Text,
                    IteCodigo = this.bedItemSAP.Text,
                    IteNombre = this.txtItemNombreSAP.Text,
                    IteCodigoInicial = this.bedItemIngresoSAP.Text,
                    IteNombreInicial = this.txtItemIngresoSAP.Text,
                    BodCodigoInicial = this.lueBodIngreso.EditValue.ToString(),
                    AnmIdPadre = this.txtIdPadre.Text.Equals("") ? null : this.txtIdPadre.Text,
                    AnmIdMadre = this.txtIdMadre.Text.Equals("") ? null : this.txtIdMadre.Text,
                    AnmObservacion = this.memObservacion.Text.Equals("") ? null : this.memObservacion.Text,
                    IteCodigoActivacion = this.bedItemActivacionSAP.Text.Equals("") ? null : this.bedItemActivacionSAP.Text,
                    IteNombreActivacion = this.txtItemActivacionSAP.Text.Equals("") ? null : this.txtItemActivacionSAP.Text,
                    BodCodigoActivacion = this.lueBodActivacion.EditValue.Equals("") ? null : this.lueBodActivacion.EditValue.ToString(),
                    CcoCodigoActivacion = this.lueCcoActivacion.EditValue.Equals("") ? null : this.lueCcoActivacion.EditValue.ToString(),
                    AnmTipValorResidual = this.cmbTipo.Text,
                    AnmMotivoBaja = this.txtMotivoBaja.Text.Equals("") ? null : this.txtMotivoBaja.Text,
                    AnmEstDesarrollo = this.txtEstDesarrollo.Text,
                    AnmEstCiclo = this.txtEstCiclo.Text,
                    EstCodigo = this.txtEstCodigo.Text.Substring(0,3),
                    BodCodigo = this.lueBodega.EditValue.Equals("") ? null : this.lueBodega.EditValue.ToString(),

                    AnmFecLlegada = (DateTime)this.datFecLlegada.EditValue,
                    AnmFecNacimiento = this.datFecNacimiento.EditValue == null ? (DateTime?)null : DateTime.Parse(this.datFecNacimiento.EditValue.ToString()),
                    AnmFecActivacion = this.datFecActivacion.EditValue == null ? (DateTime?)null : DateTime.Parse(this.datFecActivacion.EditValue.ToString()),
                    AnmFecBaja = this.datFecBaja.EditValue == null ? (DateTime?)null : DateTime.Parse(this.datFecBaja.EditValue.ToString()),

                    AnmNroTomasPartos = this.txtNroTomasPartos.Text.Equals("0") ? (decimal?)null : decimal.Parse(this.txtNroTomasPartos.Text),
                    AnmCstInicial = decimal.Parse(this.txtCstInicial.Text),
                    AnmCstFormacion = this.txtCstFormacion.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtCstFormacion.Text),
                    AnmCstBaja = this.txtCstBaja.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtCstBaja.Text),
                    AnmPsoInicial = decimal.Parse(this.txtPsoInicial.Text),
                    AnmPsoFormacion = this.txtPsoFormacion.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtPsoFormacion.Text),
                    AnmPsoVivo = this.txtPsoVivo.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtPsoVivo.Text),
                    AnmPsoCanal = this.txtPsoCanal.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtPsoCanal.Text),
                    AnmPorcenValorResidual = this.txtPorcenValorResidual.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtPorcenValorResidual.Text),
                    AnmValorResidual = this.txtValorResidual.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtValorResidual.Text),
                    AnmValorDepreciable = this.txtValDepreciable.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtValDepreciable.Text),
                    AnmTPValorDepreciable = this.txtValDepreciableTP.EditValue.ToString().Equals("0") ? (decimal?)null : decimal.Parse(this.txtValDepreciableTP.Text),
                    AnmCosto = this.txtCosto.EditValue.ToString().Equals("0") ? 0 : decimal.Parse(this.txtCosto.Text)
                };
                //Enviamos la informacion a la base de datos
                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo);
                //Si no hay ningun error procedemos a mostrar el mensaje respectivo
                switch (varOpeCodigo)
                {
                    case 1:
                        XtraMessageBox.Show(string.Format("Registro ingresado con la chapeta nro: {0}", csRegistro.AnmAlternativo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /*
        private void btnG_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (varOpeCodigo == 2) varOpeCodigo = 1;
                clsGraAnimal obj = new clsGraAnimal();
                obj.Id = varRegCodigo;
                obj.IdAlternativo = txtIdAlt.Text;
                obj.OITMCode = lookItem.EditValue.ToString();
                obj.IdLinea = cboLinea.SelectedValue.ToString();
                obj.IdCasaOrigen = cboCasa.SelectedValue.ToString();
                obj.Nombre = lookItem.Text;
                obj.Notas = txtNotas.Text;
                obj.FechaNacimiento = null;
                if (chkFNac.Checked) obj.FechaNacimiento = dtpFNac.Value.Date;
                obj.FechaIngreso = dtpFIng.Value;
                if (!string.IsNullOrEmpty(txtPeso.Text))
                    obj.PesoKgIngreso = decimal.Parse(txtPeso.Text);
                if (!string.IsNullOrEmpty(txtCostoInicial.Text))
                    obj.CostoInicial = decimal.Parse(txtCostoInicial.Text);
                obj.IdPadre = null;
                if (txtPadre.Text.Trim() != "") obj.IdPadre = txtPadre.Text;
                obj.IdMadre = null;
                if (txtMadre.Text.Trim() != "") obj.IdMadre = txtMadre.Text;
                obj.Estado = lblEstado.Text;

                // Guardar datos de depreciación
                if (txtVidaUtil.Text != "")
                    obj.VidaUtilDias = int.Parse(txtVidaUtil.Text.Replace(",", "").Replace(".", ""));
                else obj.VidaUtilDias = null;

                if (txtCostoForm.Text != "")
                    obj.CostoFormacion = decimal.Parse(txtCostoForm.Text);
                else obj.CostoFormacion = null;

                if (txtPesoForm.Text != "")
                    obj.PesoKgFormacion = decimal.Parse(txtPesoForm.Text);
                else obj.PesoKgFormacion = null;

                if (txtPesoVivo.Text != "")
                    obj.PesoVivo = decimal.Parse(txtPesoVivo.Text);
                else obj.PesoVivo = null;

                if (txtPesoCanal.Text != "")
                    obj.PesoCanal = decimal.Parse(txtPesoCanal.Text);
                else obj.PesoCanal = null;

                obj.TipoValorResidual = cboValResidual.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(txtValResidual.Text))
                    obj.ValorResidual = decimal.Parse(txtValResidual.Text);
                if (!string.IsNullOrEmpty(txtValResidualP.Text))
                    obj.PorcentajeValorResidual = decimal.Parse(txtValResidualP.Text);

                if (chkFechaBaja.Checked)
                {
                    obj.FechaBaja = dtpFechaBaja.Value.Date;
                    obj.MotivoBaja = cboMotivoBaja.SelectedValue.ToString();
                }

                if (obj.ejecutarMantenimiento(varOpeCodigo) >= 0)
                {
                    clsVariablesGlobales.clsANIMALRecargar = true;
                    //DialogResult = DialogResult.OK;
                    Close();
                }
                else MessageBox.Show("No se pudo realizar la operación solicitada. " + obj.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValid()
        {
            ValidateChildren();
            if (!csvValResidual.IsValid) tabDet.SelectTab(0);
            return rfvId.IsValid && csvNombre.IsValid && csvFechas.IsValid && csvActivacion.IsValid
                && cpvCosto.IsValid && csvValResidual.IsValid;
        }

        private void csvActivacion_Validating(object sender, WinValidators.ValidatingCancelEventArgs e)
        {
            e.IsValid = true;
            // Activación: línea, casa origen y fecha nacimiento son requeridos
            if (lblEstado.Text == "A")
            {
                if ((cboLinea.SelectedValue ?? "0").ToString() == "0" ||
                    (cboCasa.SelectedValue ?? "0").ToString() == "0" ||
                    !chkFNac.Checked)
                {
                    e.IsValid = false;
                }
            }
        }

        private void csvFechas_Validating(object sender, WinValidators.ValidatingCancelEventArgs e)
        {
            e.IsValid = true;
            if ((chkFNac.Checked && dtpFNac.Value.Date > dtpFIng.Value.Date)
                || dtpFIng.Value.Date > DateTime.Today)
            {
                e.IsValid = false;
            }
        }

        private void csvNombre_Validating(object sender, WinValidators.ValidatingCancelEventArgs e)
        {
            e.IsValid = !string.IsNullOrEmpty(lookItem.EditValue.ToString());
        }

        private void chkNoFNac_CheckedChanged(object sender, EventArgs e)
        {
            dtpFNac.Enabled = chkFNac.Checked;
        }

        private void csvValResidual_Validating(object sender, WinValidators.ValidatingCancelEventArgs e)
        {
            decimal testValue = 0;

            if (cboValResidual.SelectedValue.ToString() == "V") // Por valor
                decimal.TryParse(txtValResidual.Text, out testValue);
            else
                decimal.TryParse(txtValResidualP.Text, out testValue);

            e.IsValid = testValue > 0;
        }

        private void dtgDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abrir detalle de parto al hacer clic en el botón
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                (e.RowIndex >= 0 && e.RowIndex < dtgDet.Rows.Count - 1))
            {
                //Form frmDet = new xfrmGraManParto(0, 2, (int)dtgDet.Rows[e.RowIndex].Cells["colIdParto"].Value);
                //frmDet.MdiParent = this.MdiParent;
                //frmDet.Show();
            }
        }

        private void cboValResidual_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValResidualP.Enabled = lblValResidual.Enabled =
                txtValResidual.Enabled = txtValResidualP.Enabled = false;

            if (cboValResidual.SelectedValue.ToString() == "V") // Por valor
            {
                lblValResidual.Enabled = txtValResidual.Enabled = true;
                txtValResidualP.Text = "0";
            }
            else
            {
                lblValResidualP.Enabled = txtValResidualP.Enabled = true;
                calcularValorResidual();
            }
        }

        private void calcularValorResidual()
        {
            decimal costoIni = 0;
            decimal porcent = 0;
            decimal.TryParse(txtCostoInicial.Text, out costoIni);
            decimal.TryParse(txtValResidualP.Text, out porcent);

            txtValResidual.Text = (costoIni * porcent / 100).ToString("0.00");
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (chkFNac.Checked)
            {
                txtDiasForm.Text = (240 - (dtpFIng.Value.Date - dtpFNac.Value.Date).Days).ToString();
                dtpFechaAct.Value = dtpFNac.Value.AddDays(240);
            }
        }

        private void chkFechaBaja_CheckedChanged(object sender, EventArgs e)
        {
            cboMotivoBaja.Enabled = dtpFechaBaja.Enabled = chkFechaBaja.Checked;
        }

        private void txtValResidualP_KeyUp(object sender, KeyEventArgs e)
        {
            calcularValorResidual();
        }

        */
        /// <summary>
        /// CAMC - 2016/10/14   Programación del campo que contendra el item de SAP del animal este item variara 
        ///                                      deacuerdo a si el animal esta en formacion o ya ha sido activado
        /// </summary>
        private void bedItemSAP_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varIteCodigo = this.bedItemSAP.Text.Trim();

                this.txtItemNombreSAP.Text = "";
                if (varIteCodigo.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo)){
                    this.bedItemIngresoSAP.EditValue = csRegistro.ItemCode;
                    this.txtItemIngresoSAP.Text = csRegistro.ItemName;
                    this.txtItemNombreSAP.Text = csRegistro.ItemName;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemSAP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true)) {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null) {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItemSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtItemNombreSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                        this.bedItemIngresoSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtItemIngresoSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// CAMC - 2016/10/14 Programación del campo que contendra el item de ingreso del animal el cual servira de vinculo con SAP
        /// </summary>
        private void bedItemIngreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varIteCodigo = this.bedItemIngresoSAP.Text.Trim();

                this.txtItemIngresoSAP.Text = "";
                if (varIteCodigo.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo))
                    this.txtItemIngresoSAP.Text = csRegistro.ItemName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemIngreso_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null)
                    {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItemIngresoSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtItemIngresoSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// CAMC - 2016/10/14 Programación del campo que contendra el item de activacion del animal el cual servira de vinculo con SAP
        /// </summary>
        private void bedItemActivacionSAP_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varIteCodigo = this.bedItemActivacionSAP.Text.Trim();

                this.txtItemActivacionSAP.Text = "";
                if (varIteCodigo.Length < 8) return;

                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo))
                    this.txtItemActivacionSAP.Text = csRegistro.ItemName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemActivacionSAP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Instanciamos al formulario listado de items
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.ShowDialog();
                    if (!frmFormulario.DrVarFila.Count.Equals(0) && frmFormulario.DrVarFila != null)
                    {
                        //Asignamos los valores obtenidos del listado a las diferentes objetos de proveedor
                        this.bedItemActivacionSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtItemActivacionSAP.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// CAMC - 2016/10/14 Programacion del campo linea genetica el cual nos servira para determinar si el animal es macho y hembra
        ///                                     y dependiendo de eso habilitar o deshabilitar los tabs de detalles de laboratorio y detalles de parto
        /// </summary>
        private void lueLinea_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.xtpDetalleParto.PageVisible = false;
                this.xtpDetLaboratorio.PageVisible = false;

                var varGenero = lueLinea.GetColumnValue("Genero");
                if (!varGenero.Equals(""))
                    this.txtGenero.Text = varGenero.ToString();
                else
                    return;

                if (varGenero.ToString().ToLower().Equals("macho"))
                    this.xtpDetLaboratorio.PageVisible = true;
                else
                    this.xtpDetalleParto.PageVisible = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var objCombo = ((ComboBoxEdit)sender).SelectedItem;
                if (objCombo == null) return;
                if (objCombo.ToString().Equals("POR VALOR")) {
                    this.txtPorcenValorResidual.Enabled = false;
                    this.txtValorResidual.Enabled = true;
                }
                else {
                    this.txtPorcenValorResidual.Enabled = true;
                    this.txtValorResidual.Enabled = false;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
