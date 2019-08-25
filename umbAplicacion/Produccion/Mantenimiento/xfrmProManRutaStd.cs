using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Produccion;
using Umbrella;

namespace umbAplicacion.Produccion.Mantenimiento
{
    public partial class xfrmProManRutaStd : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmProManRutaStd()
        {
            InitializeComponent();
        }
        public xfrmProManRutaStd(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            try
            {
                varForCodigo = varFormulario;
                varOpeCodigo = varOperacion;
                varRegCodigo = varRegistro;
                               
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Mantenimiento de rutas estandares";
                switch (varOpeCodigo)
                {
                    case 2:
                         foreach (clsProRutaStd csRegistro in clsProRutaStd.funListar(varRegCodigo))
                         {
                             this.txtCodigo.Text = csRegistro.PrsCodigo.ToString();
                             this.txtNombre.Text = csRegistro.PrsNombre;
                             this.txtMO.Text = csRegistro.PrsManoObra.ToString();
                             this.txtCIF.Text = csRegistro.PrsCstFabricacion.ToString();
                             this.txtGO.Text = csRegistro.PrsGstOperacional.ToString();
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
                var csRegistro = new clsProRutaStd() 
                { 
                    PrsCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text), 
                    PrsNombre = this.txtNombre.Text ,
                    PrsManoObra = this.txtMO.Text.Equals("") ? 0 : decimal.Parse(this.txtMO.Text),
                    PrsCstFabricacion = this.txtCIF.Text.Equals("") ? 0 : decimal.Parse(this.txtCIF.Text),
                    PrsGstOperacional = this.txtGO.Text.Equals("") ? 0 : decimal.Parse(this.txtGO.Text)
                };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
