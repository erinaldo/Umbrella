using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbNegocio;
using umbNegocio.Produccion;
using Umbrella;

namespace umbAplicacion.Produccion.Mantenimiento
{
    public partial class xfrmProManOperacion : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmProManOperacion()
        {
            InitializeComponent();
        }
        public xfrmProManOperacion(int varFormulario, int varOperacion, string varRegistro)
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
                this.Text = "Mantenimiento de operaciones";
                this.lueArea.Properties.DataSource = clsDiccionario.Listar("PROFORMULACION");
                this.lueTipo.Properties.DataSource = clsDiccionario.Listar("PROTIPOPERACION");

                switch (varOpeCodigo)
                {
                    case 2:
                        foreach (clsProOperacion csRegistro in clsProOperacion.funListar(varRegCodigoStr))
                        {
                            this.txtCodigo.Text = csRegistro.OppCodigo;
                            this.txtNombre.Text = csRegistro.OppNombre;
                            this.lueTipo.EditValue = csRegistro.OppTipo.ToString();
                            this.lueArea.EditValue = csRegistro.OppArea;
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
                var csRegistro = new clsProOperacion() 
                { 
                    OppCodigo = this.txtCodigo.Text, 
                    OppNombre = this.txtNombre.Text,
                    OppTipo = this.lueTipo.Text.Equals("") ? 0 : int.Parse(this.lueTipo.EditValue.ToString()),
                    OppArea = this.lueArea.EditValue.ToString()
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
    }
}
