using System;
using System.Windows.Forms;
using umbNegocio;

namespace umbAplicacion
{
    //20160701 JP

    public partial class frmOpcionEdit : Form
    {
        string selCodigo = "";
        string selDesc = "";
        string selTipo = "";
        int selMaxLength = 0;
        byte[] curValueBin = null;
        clsGenOpciones obj = new clsGenOpciones();

        public frmOpcionEdit(string Codigo, string Descripcion, string Tipo, int MaxLength)
        {
            InitializeComponent();
            selCodigo = Codigo;
            selDesc = Descripcion;
            selTipo = Tipo;
            selMaxLength = MaxLength;
        }

        private void frmOpcionEdit_Load(object sender, EventArgs e)
        {
            lblDesc.Text = selDesc;
            string curValue = clsGenOpciones.CargarValor(selCodigo);

            switch (selTipo)
            {
                case "Impresora":
                    csvVal.ControlToValidate = txtVal;
                    txtVal.Text = curValue;
                    curValueBin = obj.CargarValorBinary(selCodigo);
                    // TODO: Convertir a configuraciones de impresora y cargar pdgVal
                    if (pdgVal.ShowDialog() == DialogResult.OK)
                    {
                        // TODO: Set curValueBin = config impresora
                    }

                    break;

                case "SiNo":
                    csvVal.ControlToValidate = cboValSiNo;
                    cboValSiNo.Visible = true;
                    cboValSiNo.SelectedIndex = 0;
                    if (curValue.ToLower() == "no") cboValSiNo.SelectedIndex = 1;
                    break;

                default:
                    if (selTipo.StartsWith("DIC_"))
                    {
                        csvVal.ControlToValidate = cboValDiccionario;
                        cboValDiccionario.Visible = true;
                        cboValDiccionario.DataSource = clsDiccionario.Listar(selTipo.Substring(4));
                        cboValDiccionario.SelectedValue = curValue;
                    }
                    else //Texto, Num_Entero, Num_Decimal
                    {
                        txtVal.Visible = true;
                        csvVal.ControlToValidate = txtVal;
                        txtVal.MaxLength = selMaxLength;
                        txtVal.Text = curValue;
                    }
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            bool res = false;
            if (IsValid())
            {
                try
                {
                    string newValue = "";
                    switch (selTipo)
                    {
                        case "Impresora":
                            newValue = txtVal.Text;
                            res = obj.GrabarBinary(selCodigo, curValueBin);
                            break;

                        case "SiNo":
                            newValue = (cboValSiNo.SelectedIndex == 0) ? "Sí" : "No";
                            break;

                        default:
                            if (selTipo.StartsWith("DIC_"))
                            {
                                newValue = cboValDiccionario.SelectedValue.ToString();
                            }
                            else //Texto, Num_Entero, Num_Decimal
                            {
                                newValue = txtVal.Text;
                            }
                            break;
                    }
                    if (obj.Grabar(selCodigo, newValue))
                        DialogResult = DialogResult.OK;
                    else throw new Exception();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar. " + ex.Message);
                }
            }
        }

        private bool IsValid()
        {
            ValidateChildren();
            return csvVal.IsValid;
        }

        private void csvVal_Validating(object sender, WinValidators.ValidatingCancelEventArgs e)
        {
            e.IsValid = false;

            switch (selTipo)
            {
                case "Num_Entero":
                    int intToTest = 0;
                    e.IsValid = int.TryParse(txtVal.Text, out intToTest);
                    break;

                case "Num_Decimal":
                    decimal decToTest = 0;
                    e.IsValid = decimal.TryParse(txtVal.Text, out decToTest);
                    break;

                default: //Texto
                    e.IsValid = true;
                    break;
            }
        }
    }
}
