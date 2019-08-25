using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Seguridad.Mantenimiento
{
    public partial class xfrmSegManDocumento : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmSegManDocumento()
        {
            InitializeComponent();
        }
        public xfrmSegManDocumento(int varFormulario, int varOperacion, int varRegistro)
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
                this.Text = "Mantenimiento de documentos";
                this.txtCodigo.Text = "0";
                //Recuperamos la informacion de los documentos de SAP
                this.lueDocSAPSalida.Properties.DataSource = clsSegDocumento.funDocSap();
                this.lueDocSAPEntrada.Properties.DataSource = clsSegDocumento.funDocSap();
                this.lueDocSAPDiario.Properties.DataSource = clsSegDocumento.funDocSap();
                
                switch (varOpeCodigo)
                {
                    case 1:
                        this.lueDocSAPSalida.ItemIndex = 0;
                        this.lueDocSAPEntrada.ItemIndex = 0;
                        this.lueDocSAPDiario.ItemIndex = 0;
                        this.txtNumInicial.EditValue = 1;
                        this.txtNumProximo.EditValue = 1;
                        break;
                    case 2:

                        foreach (clsSegDocumento csRegistro in clsSegDocumento.funListar(varRegCodigo))
                         {
                             this.txtCodigo.Text = csRegistro.DocCodigo.ToString();
                             this.txtNombre.Text = csRegistro.DocNombre;
                             this.txtDescripcion.Text = csRegistro.DocDescripcion;
                             this.txtNumInicial.EditValue = csRegistro.DocNumInicial;
                             this.txtNumProximo.EditValue = csRegistro.DocNumProximo;
                             this.lueDocSAPSalida.ItemIndex = lueDocSAPSalida.Properties.GetDataSourceRowIndex(lueDocSAPSalida.Properties.ValueMember, csRegistro.DocCodSAPSalida);
                             this.lueDocSAPEntrada.ItemIndex = lueDocSAPSalida.Properties.GetDataSourceRowIndex(lueDocSAPSalida.Properties.ValueMember, csRegistro.DocCodSAPEntrada);
                             this.lueDocSAPDiario.ItemIndex = lueDocSAPSalida.Properties.GetDataSourceRowIndex(lueDocSAPSalida.Properties.ValueMember, csRegistro.DocCodSAPDiario);

                             if (csRegistro.DocNumProximo > csRegistro.DocNumInicial)
                             {
                                 this.txtNumInicial.Enabled = false;
                                 this.txtNumProximo.Enabled = false;
                             }
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
                var csRegistro = new clsSegDocumento() 
                { 
                    DocCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text), 
                    DocNombre = this.txtNombre.Text,
                    DocDescripcion = this.txtDescripcion.Text,
                    DocNumInicial = int.Parse(this.txtNumInicial.EditValue.ToString()),
                    DocNumProximo = int.Parse(this.txtNumProximo.EditValue.ToString()),
                    DocCodSAPSalida = int.Parse(this.lueDocSAPSalida.EditValue.ToString()),
                    DocCodSAPEntrada = int.Parse(this.lueDocSAPEntrada.EditValue.ToString()),
                    DocCodSAPDiario = int.Parse(this.lueDocSAPDiario.EditValue.ToString())
                };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, 0, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varRegCodigo, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtNumInicial_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (varOpeCodigo.Equals(1))
                    this.txtNumProximo.Text = this.txtNumInicial.Text;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

       
    }
}
