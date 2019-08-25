using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Inventario.Listado;
using umbNegocio;
using umbNegocio.Costos;
using umbNegocio.Inventario;
using Umbrella;

namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManComCarnica : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        DataTable dtComCarnica;

        public xfrmCosManComCarnica()
        {
            InitializeComponent();
        }
        public xfrmCosManComCarnica(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;

            var csValidaciones = new clsValidacionesControles();
            csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varFormulario, 1, varOperacion);
            csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varFormulario, 1, varOperacion);
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Informacion de costos de materia prima carnica";
                this.chkBodega.DataSource = clsDiccionario.Listar("COSCOMCARNICA");

                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                        this.datFecDesde.EditValue = DateTime.Now;
                        this.datFecHasta.EditValue = DateTime.Now;

                        for (int i = 0; i < ((System.Data.DataTable)(this.chkBodega.DataSource)).Rows.Count; i++)
                            chkBodega.SetItemChecked(i, true);
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                        foreach (clsCosComCarnica csRegistro in clsCosComCarnica.funListar(varRegCodigo))
                        {
                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.datFecDesde.EditValue = csRegistro.CabFecDesde;
                            this.datFecHasta.EditValue = csRegistro.CabFecHasta;
                            this.bedItemDesde.EditValue = csRegistro.IteCodDesde;
                            this.txtNomItemDesde.Text = csRegistro.IteNomDesde;
                            this.bedItemHasta.EditValue = csRegistro.IteCodHasta;
                            this.txtNomItemHasta.Text = csRegistro.IteNomHasta;
                            this.txtDescripcion.Text = csRegistro.CabDescripcion;

                            String[] lstBodega = csRegistro.CabBodega.Split(',');
                            foreach (var varBodega in lstBodega)
                            {
                                for (int i = 0; i < this.chkBodega.ItemCount; i++)
                                    if (varBodega.Equals(chkBodega.GetItemValue(i))) chkBodega.SetItemChecked(i, true);
                            }

                             //Recuperamos la informacion del detalle de entradas de mercancia
                            this.proDtComCarnica();
                            foreach (DataRow objDetCarnica in clsCosComCarnica.funRecDetComCarnica(csRegistro.CabCodigo).Rows)
                            {
                                this.dtComCarnica.Rows.Add(int.Parse(objDetCarnica["DetSecuencia"].ToString()),
                                                                                 objDetCarnica["IteCodigo"].ToString(),
                                                                                 objDetCarnica["IteNombre"].ToString(),
                                                                                 decimal.Parse(objDetCarnica["DetCantidad"].ToString()),
                                                                                 decimal.Parse(objDetCarnica["DetValor"].ToString()),
                                                                                 decimal.Parse(objDetCarnica["DetCosto"].ToString()));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                //Programacion utilizada para cambiar la posicion de la fila en la que se encuentra el usuario
                this.grvListado.FocusedRowHandle = this.grvListado.RowCount -1;
                this.grvListado.FocusedRowHandle = 0;

                string varBodega = "";

                int i = 0;
                foreach (object item in chkBodega.CheckedItems)
                {
                    DataRowView row = item as DataRowView;
                    if (!row["Codigo"].ToString().Equals("00"))
                        if (i.Equals(0)) varBodega = row["Codigo"].ToString();
                        else varBodega = "," + row["Codigo"].ToString();
                }

                var csRegistro = new clsCosComCarnica()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    CabFecDesde = (DateTime)datFecDesde.EditValue,
                    CabFecHasta = (DateTime)datFecHasta.EditValue,
                    IteCodDesde = this.bedItemDesde.Text,
                    IteNomDesde = this.txtNomItemDesde.Text,
                    IteCodHasta = this.bedItemHasta.Text,
                    IteNomHasta = this.txtNomItemHasta.Text,
                    CabBodega = varBodega,
                    CabDescripcion = this.txtDescripcion.Text,
                    EstCodigo= "Nor",
                    DetComCarnica = this.dtComCarnica
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

        private void bedItemDesde_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0)
                    {
                        this.bedItemDesde.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtNomItemDesde.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                        this.bedItemDesde.Focus();
                    }
                    else
                        this.txtNomItemDesde.Text = "";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemDesde_EditValueChanged(object senDet, EventArgs e)
        {
            try
            {
                string varIteCodigo = this.bedItemDesde.Text.Trim();

                if (varIteCodigo.Length < 8) { this.txtNomItemDesde.Text = ""; return; }

                this.txtNomItemDesde.Text = "";
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo))
                    this.txtNomItemDesde.Text = csRegistro.ItemName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemHasta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0)
                    {
                        this.bedItemHasta.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        this.txtNomItemHasta.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemName;
                        this.bedItemHasta.Focus();
                    }
                    else
                        this.txtNomItemHasta.Text = "";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItemHasta_EditValueChanged(object senDet, EventArgs e)
        {
            try
            {
                string varIteCodigo = this.bedItemHasta.Text.Trim();

                if (varIteCodigo.Length < 8) { this.txtNomItemHasta.Text = ""; return; }

                this.txtNomItemHasta.Text = "";
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varIteCodigo))
                    this.txtNomItemHasta.Text = csRegistro.ItemName;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                this.proDtComCarnica();

                string varIteDesde = "";
                string varIteHasta = "";
                string varBodega = "";
                DateTime varFecDesde;
                DateTime varFecHasta;

                if (!this.txtNomItemDesde.Text.Equals("")) varIteDesde = this.bedItemDesde.Text;
                if (!this.txtNomItemHasta.Text.Equals("")) varIteHasta = this.bedItemHasta.Text;
                varFecDesde = (DateTime)datFecDesde.EditValue;
                varFecHasta = (DateTime)datFecHasta.EditValue;

                int i = 0;
                foreach (object item in chkBodega.CheckedItems)
                {
                    DataRowView row = item as DataRowView;
                    if (!row["Codigo"].ToString().Equals("00"))
                        if (i.Equals(0)) varBodega = row["Codigo"].ToString() ;
                        else varBodega = "," + row["Codigo"].ToString() ;
                }

                if (varIteDesde.Equals("")) { XtraMessageBox.Show("El item desde es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (varIteHasta.Equals("")) { XtraMessageBox.Show("El item hasta es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (varBodega.Equals("")) { XtraMessageBox.Show("La bodega es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                DataTable dtExtComCarnica = clsCosComCarnica.funExtCstCarnico(varFecDesde, varFecHasta, varIteDesde, varIteHasta, varBodega);

                int x = 0;
                foreach (DataRow drExtComCarnica in dtExtComCarnica.Rows)
                {
                    dtComCarnica.Rows.Add(++x,
                                                              drExtComCarnica["ItemCode"].ToString(),
                                                              drExtComCarnica["ItemName"].ToString(),
                                                              drExtComCarnica["ItemQuantity"] == System.DBNull.Value ? 0 : decimal.Parse(drExtComCarnica["ItemQuantity"].ToString()),
                                                              drExtComCarnica["ItemValue"] == System.DBNull.Value ? 0 : decimal.Parse(drExtComCarnica["ItemValue"].ToString()),
                                                              drExtComCarnica["ItemCosto"] == System.DBNull.Value ? 0 : decimal.Parse(drExtComCarnica["ItemCosto"].ToString())
                                                                );
                }
                XtraMessageBox.Show("Informacion extraida con exito!!!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void proDtComCarnica()
        {
            dtComCarnica = new DataTable() { TableName = "ComCarnica" };
            dtComCarnica.Columns.Add("DetSecuencia", typeof(int));
            dtComCarnica.Columns.Add("IteCodigo", typeof(string));
            dtComCarnica.Columns.Add("IteNombre", typeof(string));
            dtComCarnica.Columns.Add("DetCantidad", typeof(decimal));
            dtComCarnica.Columns.Add("DetValor", typeof(decimal));
            dtComCarnica.Columns.Add("DetCosto", typeof(decimal));

            this.grcListado.DataSource = dtComCarnica;
        }
    }
}
