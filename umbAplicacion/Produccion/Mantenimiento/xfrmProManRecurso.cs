using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Finanzas.Listado;
using umbNegocio;
using umbNegocio.Finanzas;
using umbNegocio.Produccion;
using Umbrella;

namespace umbAplicacion.Produccion.Mantenimiento
{
    public partial class xfrmProManRecurso : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmProManRecurso()
        {
            InitializeComponent();
        }
        public xfrmProManRecurso(int varFormulario, int varOperacion, string varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigoStr = varRegistro;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Mantenimiento de recursos";
                this.lueGrupo.Properties.DataSource = clsDiccionario.Listar("PRORECURSO");
                
                switch (varOpeCodigo)
                {
                    case 1:
                        this.lueGrupo.ItemIndex = 0;
                        this.chkEvaluar.Checked = true;
                        this.datFecha.EditValue = DateTime.Now;
                        break;
                    case 2:
                        foreach (clsProRecurso csRegistro in clsProRecurso.funListar(varRegCodigoStr))
                        {
                            this.txtCodigo.Text = csRegistro.RecCodigo;
                            this.txtNombre.Text = csRegistro.RecNombre;
                            this.lueGrupo.EditValue = csRegistro.RecGrupo;
                            
                            this.datFecha.EditValue = csRegistro.RecFecha;
                            this.chkEvaluar.Checked = csRegistro.RecEvaluar;
                            this.bedCenCosto.EditValue = csRegistro.CcoCodigo;
                            this.txtMO.EditValue = csRegistro.RecManObra;
                            this.txtGIF.EditValue = csRegistro.RecGstFabricacion;
                        }
                        break;
                }

                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, 1, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                var csRegistro = new clsProRecurso()
                {
                    RecCodigo = this.txtCodigo.Text,
                    RecNombre = this.txtNombre.Text,
                    RecGrupo = this.lueGrupo.EditValue.ToString(),
                    RecFecha = (DateTime)this.datFecha.EditValue,
                    RecEvaluar = this.chkEvaluar.Checked,
                    CcoCodigo = this.bedCenCosto.EditValue.ToString(),
                    RecManObra = decimal.Parse(this.txtMO.Text),
                    RecGstFabricacion = decimal.Parse(this.txtGIF.Text)
                };

                string varCodigo = "";

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el codigo: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bedCenCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varCcoCodigo = this.bedCenCosto.Text.Trim();

                if (varCcoCodigo.Length < 4) { this.txtNomCenCosto.Text = ""; return; }

                this.txtNomCenCosto.Text = ""; 
                foreach (clsFinCenCosto csRegistro in clsFinCenCosto.funListar(varCcoCodigo))
                    this.txtNomCenCosto.Text = csRegistro.CcoNombre;
                   
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedCenCosto_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmFinLisCenCosto frmFormulario = new xfrmFinLisCenCosto(true))
                {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count != 0) this.bedCenCosto.Text = ((clsFinCenCosto)frmFormulario.DrVarFila[0]).CcoCodigo;
                    else this.bedCenCosto.Text = "";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
