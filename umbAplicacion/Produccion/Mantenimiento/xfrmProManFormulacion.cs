using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using umbAplicacion.Inventario.Listado;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Produccion;
using Umbrella;
using System.Linq;
using umbNegocio.Seguridad;

namespace umbAplicacion.Produccion.Mantenimiento
{
    public partial class xfrmProManFormulacion : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        DataTable dtMateriales;
        DataTable dtRuta;
        DataTable dtMerma;

        List<string> lstVariante = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public xfrmProManFormulacion()
        {
            InitializeComponent();
        }
        public xfrmProManFormulacion(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;

        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Lista de materiales";
                this.lueArea.Properties.DataSource = clsDiccionario.Listar("PROFORMULACION");
                this.iluTipo.DataSource = clsDiccionario.Listar("COSTIPHOJCOSTO");

                this.gluItem.DataSource = clsInvItem.funListar();
                this.gluOperacion.DataSource = clsProOperacion.funListar();
                this.gluRecurso.DataSource = clsProRecurso.funListar();
                this.iluMerma.DataSource = clsProMerma.funListar();
                this.lueRuta.Properties.DataSource = clsProRutaStd.funListar();
                
                this.proDtMateriales();
                this.proDtRuta();
                this.proDtMerma();

                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar
                         DataTable dtDocumentos = clsSegAccFormulario.funListarDtDocumento(clsVariablesGlobales.varCodUsuario, varForCodigo, varOpeCodigo);

                        if (dtDocumentos.Rows.Count.Equals(1))
                        {
                            this.txtCodSerie.EditValue = varDocCodigo = int.Parse(dtDocumentos.Rows[0]["DocCodigo"].ToString());
                            this.txtNomSerie.Text = varDocNombre = dtDocumentos.Rows[0]["DocNombre"].ToString();
                        }
                        else
                        {
                            var frmFormulario = new frmAccDocumento(dtDocumentos) { StartPosition = FormStartPosition.CenterParent };
                            frmFormulario.ShowDialog();

                            if (frmFormulario.DrVarFila == null) { this.btnCancelar.PerformClick(); return; }

                            this.txtCodSerie.EditValue = varDocCodigo = int.Parse(((DataRowView)frmFormulario.DrVarFila)["DocCodigo"].ToString());
                            this.txtNomSerie.Text = varDocNombre = ((DataRowView)frmFormulario.DrVarFila)["DocNombre"].ToString();
                        }

                        this.lueRuta.ItemIndex = 0;
                        this.lueArea.ItemIndex = 0;
                        this.chkProfundizar.Checked = true;
                        this.chkRendimiento.Checked = false;
                        this.dtMateriales.Rows.Add(1, this.cmbVariante.Text, "", "", "", 0, 0, 0, "");
                        this.dtRuta.Rows.Add(1, this.cmbVariante.Text, "", "", "", 0, 0);
                        this.dtMerma.Rows.Add(1, this.cmbVariante.Text, 0, 0);
                        this.cmbVariante.Properties.Items.Clear();
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                        foreach (clsProFormulacion csRegistro in clsProFormulacion.funListar(string.Format("Where a.CabCodigo = {0}",varRegCodigo)))
                        {
                            this.cmbVariante.Properties.Items.Clear();
                            foreach (string varVariante in lstVariante)
                                this.cmbVariante.Properties.Items.Add(varVariante);

                            this.txtCodigo.Text = varRegCodigo.ToString();
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.txtNomSerie.Text = csRegistro.DocNombre;
                            this.txtNumero.EditValue = csRegistro.CabNumero;
                            this.bedItem.Text = csRegistro.IteCodigo;
                            this.txtNombre.Text = csRegistro.IteNombre;
                            this.lueArea.EditValue = csRegistro.CabArea;
                            this.cmbVariante.Text = csRegistro.CabVariante;
                            this.chkProfundizar.Checked = csRegistro.CabProfundizar;
                            this.chkRendimiento.Checked = csRegistro.CabRendimiento;
                            this.lueRuta.EditValue = csRegistro.PrsCodigo;
                            this.memObservacion.Text = csRegistro.CabObservacion;

                            foreach (clsInvItem csItem in clsInvItem.funListar(csRegistro.IteCodigo))
                            {
                                this.txtGrupo.Text = csItem.ItmsGrpNam;
                                this.txtUndInventario.Text = csItem.InvntryUom;
                                this.txtUndVenta.Text = csItem.SalUnitMsr;
                                this.txtPsoStdVenta.Text = csItem.SWeight1.ToString();
                            }

                            int varFila = 0;

                            foreach (DataRow drMaterial in clsProFormulacion.funListarMaterial(csRegistro.CabCodigo).Rows) { this.proAñadirDtMateriales(int.Parse(drMaterial["DetLinea"].ToString()), drMaterial["CabVariante"].ToString(), drMaterial["IteCodigo"].ToString(), drMaterial["IteNombre"].ToString(), drMaterial["IteUndInventario"].ToString(), decimal.Parse(drMaterial["DetCantidad"].ToString()), decimal.Parse(drMaterial["DetCantidadPor"].ToString()), decimal.Parse(drMaterial["DetPorcentaje"].ToString()), drMaterial["DetTipo"].ToString(), int.Parse(drMaterial["DetLineaRuta"].ToString())); }
                            varFila = (dtMateriales.Compute("Max(DfmLinea)", "") == DBNull.Value ? 0 : int.Parse(dtMateriales.Compute("Max(DfmLinea)", "").ToString())) + 1;
                            if (dtMateriales.Rows.Count.Equals(0)) this.dtMateriales.Rows.Add(varFila, this.cmbVariante.Text, "", "", "", 0, 0);

                            foreach (DataRow drRuta in clsProFormulacion.funListarRuta(csRegistro.CabCodigo).Rows) { this.proAñadirDtRuta(int.Parse(drRuta["DetLinea"].ToString()), drRuta["CabVariante"].ToString(), drRuta["OprCodigo"].ToString(), drRuta["OprNombre"].ToString(), drRuta["RecCodigo"].ToString(), drRuta["RecNombre"].ToString(), decimal.Parse(drRuta["DetTiempo"].ToString()), decimal.Parse(drRuta["DetTiempoPor"].ToString())); }
                            varFila = (dtRuta.Compute("Max(DfrLinea)", "") == DBNull.Value ? 0 : int.Parse(dtRuta.Compute("Max(DfrLinea)", "").ToString())) + 1;
                            if (dtRuta.Rows.Count.Equals(0)) this.dtRuta.Rows.Add(varFila, this.cmbVariante.Text, "", "", "", 0, 0);

                            foreach (DataRow drMerma in clsProFormulacion.funListarMerma(csRegistro.CabCodigo).Rows) { this.proAñadirDtMerma(int.Parse(drMerma["DetLinea"].ToString()), drMerma["CabVariante"].ToString(), int.Parse(drMerma["MerCodigo"].ToString()), decimal.Parse(drMerma["DetPorcentaje"].ToString()), drMerma["DetTipo"] == DBNull.Value ? "" : drMerma["DetTipo"].ToString()); }
                            varFila = (dtMerma.Compute("Max(DfeLinea)", "") == DBNull.Value ? 0 : int.Parse(dtMerma.Compute("Max(DfeLinea)", "").ToString())) + 1;
                            if (dtMerma.Rows.Count.Equals(0)) this.dtMerma.Rows.Add(varFila, this.cmbVariante.Text, 0, 0, "");
                        }
                        break;
                    default:
                        break;
                }
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
                base.proGrabar();
                try
                {
                    //Eliminacion de los registros en blanco para la pestaña de materiales
                    foreach (DataRow drValidaciones in dtMateriales.Select("ItemCode = ''")) drValidaciones.Delete();
                    this.dtMateriales.AcceptChanges();

                    //Eliminacion de los registros en blanco para la pestaña de rutas
                    foreach (DataRow drValidaciones in dtRuta.Select("OprCodigo = ''")) drValidaciones.Delete();
                    this.dtRuta.AcceptChanges();

                    //Eliminacion de los registros en blanco para la pestaña de mermas
                    foreach (DataRow drValidaciones in dtMerma.Select("MerCodigo = 0")) drValidaciones.Delete();
                    this.dtMerma.AcceptChanges();

                    if (dtMateriales.Select("DfmCantidad = 0").Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de cantidad favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que la cantidad en materiales no sea 0
                    if (dtMateriales.Select("DfmCantidadPor = 0").Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de cantidadpor favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que la cantidadpor en materiales no sea 0
                    if (dtRuta.Select("DfrTiempo = 0 And OprNombre <> 'ADMINISTRACION'").Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de tiempo favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que el tiempo en rutas no sea 0
                    if (dtRuta.Select("DfrTiempoPor = 0 And OprNombre <> 'ADMINISTRACION'").Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de tiempopor favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que el tiempopor en rutas no sea 0
                    if (dtMerma.Select("DfePorcentaje = 0").Length > 0) { XtraMessageBox.Show("Existe valores en cero en la columna de porcentaje favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que el porcentaje en mermas no sea 0
                    if (dtMerma.Select("DfeTipo = ''").Length > 0) { XtraMessageBox.Show("Existe valores vacios en la columna de tipo favor de verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //Validacion para que el porcentaje en mermas no sea 0

                    var dupMaterial =   from b in dtMateriales.AsEnumerable()
                                                      group b by b.Field<string>("ItemCode") into g
                                                      where g.Count() > 1
                                                      select new
                                                      {
                                                          IteCodigo = g.Key,
                                                      };
                    foreach (var vMaterial in dupMaterial) { XtraMessageBox.Show(string.Format("El item {0} se encuentra duplicado en la pestaña de lista de materiales", vMaterial.IteCodigo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                    var dupRuta = from b in dtRuta.AsEnumerable()
                                      group b by b.Field<string>("OprCodigo") into g
                                      where g.Count() > 1
                                      select new
                                      {
                                          OprCodigo = g.Key,
                                      };
                    foreach (var vRuta in dupRuta) { XtraMessageBox.Show(string.Format("La operacion {0} se encuentra duplicado en la pestaña de operaciones", vRuta.OprCodigo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } 

                    var csRegistro = new clsProFormulacion()
                    {
                        CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                        DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                        CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                        IteCodigo = this.bedItem.Text,
                        IteNombre = this.txtNombre.Text,
                        CabArea = this.lueArea.EditValue.ToString(),
                        CabVariante = this.cmbVariante.Text,
                        CabProfundizar = this.chkProfundizar.Checked,
                        CabRendimiento = this.chkRendimiento.Checked,
                        PrsCodigo = int.Parse(this.lueRuta.EditValue.ToString()),
                        CabObservacion = this.memObservacion.Text,
                        DetMaterial = this.dtMateriales,
                        DetRuta = this.dtRuta,
                        DetMerma = this.dtMerma
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

        private void proDtMateriales()
        {
            dtMateriales = new DataTable { TableName = "Materiales" };
            dtMateriales.Columns.Add("DfmLinea", typeof(int));
            dtMateriales.Columns.Add("CfoVariante", typeof(string));
            dtMateriales.Columns.Add("ItemCode", typeof(string));
            dtMateriales.Columns.Add("ItemName", typeof(string));
            dtMateriales.Columns.Add("InvntryUom", typeof(string));
            dtMateriales.Columns.Add("DfmCantidad", typeof(decimal));
            dtMateriales.Columns.Add("DfmCantidadPor", typeof(decimal));
            dtMateriales.Columns.Add("DfmPorcentaje", typeof(decimal));
            dtMateriales.Columns.Add("DfmTipo", typeof(string));
            dtMateriales.Columns.Add("DfmLineaRuta", typeof(int));
            this.grcListado.DataSource = dtMateriales;
        }
        private void proAñadirDtMateriales(int varDfmLinea, string varCfoVariante, string varItemCode, string varItemName, string varInvntryUom, decimal varDfmCantidad, decimal varDfmCantidadPor, decimal varDfmPorcentaje, string varDfmTipo, int varDfmLineaRuta)
        {
            try
            {
                this.dtMateriales.Rows.Add(varDfmLinea,     
                                                                    varCfoVariante,
                                                                    varItemCode,                     
                                                                    varItemName,                    
                                                                    varInvntryUom,
                                                                    varDfmCantidad,      
                                                                    varDfmCantidadPor,
                                                                    varDfmPorcentaje,
                                                                    varDfmTipo,
                                                                    varDfmLineaRuta);
            }
            catch (Exception) { throw; }
        }
        private void proDtRuta()
        {
            dtRuta = new DataTable { TableName = "Ruta" };
            dtRuta.Columns.Add("DfrLinea", typeof(int));
            dtRuta.Columns.Add("CfoVariante", typeof(string));
            dtRuta.Columns.Add("OprCodigo", typeof(string));
            dtRuta.Columns.Add("OprNombre", typeof(string));
            dtRuta.Columns.Add("RecCodigo", typeof(string));
            dtRuta.Columns.Add("RecNombre", typeof(string));
            dtRuta.Columns.Add("DfrTiempo", typeof(decimal));
            dtRuta.Columns.Add("DfrTiempoPor", typeof(decimal));
            this.grcRuta.DataSource = dtRuta;
        }
        private void proAñadirDtRuta(int varDfrLinea, string varCfoVariante, string varOprCodigo,  string varOprNombre, string varRecCodigo, string varRecNombre, decimal varDfrTiempo, decimal varDfrTiempoPor)
        {
            try
            {
                this.dtRuta.Rows.Add(varDfrLinea,
                                                                    varCfoVariante,
                                                                    varOprCodigo,
                                                                    varOprNombre,
                                                                    varRecCodigo,
                                                                    varRecNombre,
                                                                    varDfrTiempo,
                                                                    varDfrTiempoPor);
            }
            catch (Exception) { throw; }
        }
        private void proDtMerma()
        {
            dtMerma = new DataTable { TableName = "Merma" };
            dtMerma.Columns.Add("DfeLinea", typeof(int));
            dtMerma.Columns.Add("CfoVariante", typeof(string));
            dtMerma.Columns.Add("MerCodigo", typeof(int));
            dtMerma.Columns.Add("DfePorcentaje", typeof(decimal));
            dtMerma.Columns.Add("DfeTipo", typeof(string));
            this.grcMerma.DataSource = dtMerma;
        }
        private void proAñadirDtMerma(int varDfeLinea, string varCfoVariante, int varMerCodigo, decimal varDfePorcentaje, string varTipo)
        {
            try
            {
                this.dtMerma.Rows.Add(varDfeLinea,
                                                             varCfoVariante,
                                                             varMerCodigo,
                                                             varDfePorcentaje,
                                                             varTipo);
            }
            catch (Exception) { throw; }
        }

        private void xfrmProManFormulacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!e.KeyCode.Equals(Keys.Enter)) return;
                GridColumn colEnfoque;
                int varPosicion, varLinea;
                
                if (grvListado.IsFocusedView)
                {
                    if (!(grvListado.FocusedColumn.Equals(colDfmCantidadPor) || grvListado.FocusedColumn.Equals(colDfmCantidad) || grvListado.FocusedColumn.Equals(colDfmPorcentaje))) return;
                    if (grvListado.RowCount.Equals(0)) return;

                    colEnfoque = this.grvListado.FocusedColumn;
                    this.grvListado.FocusedRowHandle = grvListado.RowCount - 1;
                    this.grvListado.FocusedColumn = grvListado.Columns["DfmLinea"];
                    this.grvListado.FocusedColumn = colEnfoque;

                    if (grvListado.FocusedRowHandle.Equals(grvListado.RowCount - 1))
                    {
                        varPosicion = this.grvListado.FocusedRowHandle;
                        varLinea = int.Parse(this.grvListado.GetRowCellValue(varPosicion, colDfmLinea).ToString()) + 1;

                        string varItemCode = this.grvListado.GetRowCellValue(varPosicion, colItemCode).ToString();

                        decimal varCantidad = decimal.Parse(this.grvListado.GetRowCellValue(varPosicion, colDfmCantidad).ToString());
                        decimal varCantidadPor = decimal.Parse(this.grvListado.GetRowCellValue(varPosicion, colDfmCantidadPor).ToString());

                        if (varItemCode.Equals("")) { this.grvListado.SetColumnError(colItemCode, "Debe ingresar el codigo del item"); return; }
                        if (varCantidad.Equals(0)) { this.grvListado.SetColumnError(colDfmCantidad, "La cantidad debe ser mayor a cero"); return; }
                        if (varCantidadPor.Equals(0)) { this.grvListado.SetColumnError(colDfmCantidadPor, "El cantidad por debe ser mayor a cero"); return; }

                        this.proAñadirDtMateriales(varLinea, this.cmbVariante.Text, "", "", "", 0, varCantidadPor, 0, "", 0);
                        this.grvListado.FocusedRowHandle = varPosicion + 1;
                        this.grvListado.FocusedColumn = colItemCode;

                    }
                }
                else if (this.grvRuta.IsFocusedView)
                {
                    if (!(grvRuta.FocusedColumn.Equals(colDfrTiempoPor) || grvRuta.FocusedColumn.Equals(colDfrTiempo))) return;
                    if (grvRuta.RowCount.Equals(0)) return;

                    colEnfoque = this.grvRuta.FocusedColumn;
                    this.grvRuta.FocusedRowHandle = grvRuta.RowCount - 1;
                    this.grvRuta.FocusedColumn = grvRuta.Columns["DfrLinea"];
                    this.grvRuta.FocusedColumn = colEnfoque;

                    if (grvRuta.FocusedRowHandle.Equals(grvRuta.RowCount - 1))
                    {
                        varPosicion = this.grvRuta.FocusedRowHandle;
                        varLinea = int.Parse(this.grvRuta.GetRowCellValue(varPosicion, colDfrLinea).ToString()) + 1;

                        string varOpeCodigo = this.grvRuta.GetRowCellValue(varPosicion, colOprCodigo).ToString();
                        string varRecCodigo = this.grvRuta.GetRowCellValue(varPosicion, colRecCodigo).ToString();

                        decimal varTiempo = decimal.Parse(this.grvRuta.GetRowCellValue(varPosicion, colDfrTiempo).ToString());
                        decimal varTiempoPor = decimal.Parse(this.grvRuta.GetRowCellValue(varPosicion, colDfrTiempoPor).ToString());

                        if (varOpeCodigo.Equals("")) { this.grvRuta.SetColumnError(colOprCodigo, "Debe ingresar el codigo de la operacion"); return; }
                        if (varRecCodigo.Equals("")) { this.grvRuta.SetColumnError(colRecCodigo, "Debe ingresar el codigo del recurso"); return; }
                        if (varTiempo.Equals(0)) { this.grvRuta.SetColumnError(colDfrTiempo, "El tiempo debe ser mayor a cero"); return; }
                        if (varTiempoPor.Equals(0)) { this.grvRuta.SetColumnError(colDfrTiempoPor, "El tiempo por debe ser mayor a cero"); return; }

                        this.proAñadirDtRuta(varLinea, this.cmbVariante.Text, "", "","", "", 0, varTiempoPor);
                        this.grvRuta.FocusedRowHandle = varPosicion + 1;
                        this.grvRuta.FocusedColumn = colOprCodigo;
                    }
                }
                else if (this.grvMerma.IsFocusedView)
                {
                    if (!grvMerma.FocusedColumn.Equals(colDfePorcentaje)) return;
                    if (grvMerma.RowCount.Equals(0)) return;

                    colEnfoque = this.grvMerma.FocusedColumn;
                    this.grvMerma.FocusedRowHandle = grvMerma.RowCount - 1;
                    this.grvMerma.FocusedColumn = grvMerma.Columns["DfeLinea"];
                    this.grvMerma.FocusedColumn = colEnfoque;

                    if (grvMerma.FocusedRowHandle.Equals(grvMerma.RowCount - 1))
                    {
                        varPosicion = this.grvMerma.FocusedRowHandle;
                        varLinea = int.Parse(this.grvMerma.GetRowCellValue(varPosicion, colDfeLinea).ToString()) + 1;

                        int varMerCodigo = int.Parse(this.grvMerma.GetRowCellValue(varPosicion, colMerCodigo).ToString());
                        
                        decimal varPorcentaje = decimal.Parse(this.grvMerma.GetRowCellValue(varPosicion, colDfePorcentaje).ToString());
                        string varTipo = this.grvMerma.GetRowCellValue(varPosicion, colDfeTipo).ToString();

                        if (varMerCodigo.Equals(0)) { this.grvMerma.SetColumnError(colMerCodigo, "Debe ingresar el codigo de la merma"); return; }
                        if (varPorcentaje.Equals(0)) { this.grvMerma.SetColumnError(colDfePorcentaje, "El porcentaje debe ser diferente de cero"); return; }
                        if (varTipo.Equals(0)) { this.grvMerma.SetColumnError(colDfeTipo, "El tipo es requerido"); return; }

                        this.proAñadirDtMerma(varLinea, this.cmbVariante.Text, 0, 0, "");
                        this.grvMerma.FocusedRowHandle = varPosicion + 1;
                        this.grvMerma.FocusedColumn = colMerCodigo;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null)
                    {
                        this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                        foreach (clsInvItem csRegistro in clsInvItem.funListar(((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode))
                        {
                            this.txtNombre.Text = csRegistro.ItemName;
                            this.txtGrupo.Text = csRegistro.ItmsGrpNam;
                            this.txtUndInventario.Text = csRegistro.InvntryUom;
                            this.txtUndVenta.Text = csRegistro.SalUnitMsr;
                            this.txtPsoStdVenta.Text = csRegistro.SWeight1.ToString();

                            if (!varOpeCodigo.Equals(1)) return;
                            this.cmbVariante.Properties.Items.Clear();
                            foreach (DataRow drVariante in clsProFormulacion.funRecForVariante(((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode).Rows) 
                                this.cmbVariante.Properties.Items.Add(drVariante["Codigo"].ToString());

                            this.cmbVariante.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varItemCode = this.bedItem.Text.Trim();

                if (varItemCode.Length < 8) return;
                this.txtNombre.Text = "";
                this.txtGrupo.Text = "";
                this.txtUndInventario.Text = "";
                this.txtUndVenta.Text = "";
                this.txtPsoStdVenta.Text = "0";
                
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varItemCode))
                {
                    this.txtNombre.Text = csRegistro.ItemName;
                    this.txtGrupo.Text = csRegistro.ItmsGrpNam;
                    this.txtUndInventario.Text = csRegistro.InvntryUom;
                    this.txtUndVenta.Text = csRegistro.SalUnitMsr;
                    this.txtPsoStdVenta.Text = csRegistro.SWeight1.ToString();

                    if (!varOpeCodigo.Equals(1)) return;
                    this.cmbVariante.Properties.Items.Clear();
                    foreach (DataRow drVariante in clsProFormulacion.funRecForVariante(varItemCode).Rows)
                        this.cmbVariante.Properties.Items.Add(drVariante["Codigo"].ToString());

                    this.cmbVariante.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.grvListado.FocusedColumn.Equals(colItemCode))
                {
                    if (this.grvListado.FocusedRowHandle.Equals(this.grvListado.RowCount - 1) || this.grvListado.FocusedRowHandle < 0)
                    {
                        this.colItemCode.OptionsColumn.ReadOnly = false;
                        this.gluItem.ImmediatePopup = true;
                    }
                    else
                        this.colItemCode.OptionsColumn.ReadOnly = true;
                }
                if (this.grvListado.FocusedColumn.Equals(colDfmPorcentaje))
                {
                    string varTipo = this.grvListado.GetRowCellValue(this.grvListado.FocusedRowHandle, colDfmTipo).ToString();
                    if (varTipo.Equals("EMP1") || varTipo.Equals("EMP2"))
                        this.colDfmPorcentaje.OptionsColumn.ReadOnly = false;
                    else
                        this.colDfmPorcentaje.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            try
            {
                e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Handled = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvRuta_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.grvRuta.FocusedColumn.Equals(colOprCodigo) || this.grvRuta.FocusedColumn.Equals(colRecCodigo))
                {
                    if (this.grvRuta.FocusedRowHandle.Equals(this.grvRuta.RowCount - 1) || this.grvRuta.FocusedRowHandle < 0)
                    {
                        this.colOprCodigo.OptionsColumn.ReadOnly = false;
                        this.gluOperacion.ImmediatePopup = true;
                    }
                    else
                        this.colOprCodigo.OptionsColumn.ReadOnly = true;
                }
                else if (this.grvRuta.FocusedColumn.Equals(colRecCodigo))
                {
                    if (this.grvRuta.FocusedRowHandle.Equals(this.grvRuta.RowCount - 1) || this.grvRuta.FocusedRowHandle < 0)
                    {
                        this.colRecCodigo.OptionsColumn.ReadOnly = false;
                        this.gluRecurso.ImmediatePopup = true;
                    }
                    else
                        this.colRecCodigo.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvRuta_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            try
            {
                e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Handled = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvMerma_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.grvMerma.FocusedColumn.Equals(colMerCodigo))
                    if (this.grvMerma.FocusedRowHandle.Equals(this.grvMerma.RowCount - 1) || this.grvMerma.FocusedRowHandle < 0)
                        this.colMerCodigo.OptionsColumn.ReadOnly = false;
                    else
                        this.colMerCodigo.OptionsColumn.ReadOnly = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvMerma_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            try
            {
                e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Handled = true;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluItem_Leave(object sender, EventArgs e)
        {
            try
            {
                string varItemCode = (sender as GridLookUpEdit).Text;
                if (varItemCode.Equals("")) return;

                List<clsInvItem> lisItem = clsInvItem.funListar(varItemCode);

                int varFila = this.grvListado.FocusedRowHandle;
                if (!lisItem.Equals(null))
                {
                    foreach (var regItem in lisItem)
                    {
                        this.grvListado.SetRowCellValue(varFila, colItemCode, regItem.ItemCode);
                        this.grvListado.SetRowCellValue(varFila, colItemName, regItem.ItemName);
                        this.grvListado.SetRowCellValue(varFila, colInvntryUom, regItem.InvntryUom);
                        this.grvListado.SetRowCellValue(varFila, colDfmTipo, regItem.TipoHojaCst);
                    }
                }
                else
                {
                    this.grvListado.SetRowCellValue(varFila, colItemName, "");
                    this.grvListado.SetRowCellValue(varFila, colInvntryUom, "");
                    this.grvListado.SetRowCellValue(varFila, colDfmTipo, "");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluItem_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluRecurso_Leave(object sender, EventArgs e)
        {
            try
            {
                string varRecCodigo = (sender as GridLookUpEdit).Text;
                if (varRecCodigo.Equals("")) return;

                List<clsProRecurso> lisRecurso = clsProRecurso.funListar(varRecCodigo);

                int varFila = this.grvRuta.FocusedRowHandle;
                if (!lisRecurso.Equals(null))
                {
                    foreach (var regRecurso in lisRecurso)
                    {
                        this.grvRuta.SetRowCellValue(varFila, colRecCodigo, regRecurso.RecCodigo);
                        this.grvRuta.SetRowCellValue(varFila, colRecNombre, regRecurso.RecNombre);
                    }
                }
                else
                    this.grvRuta.SetRowCellValue(varFila, colRecNombre, "");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluRecurso_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluOperacion_Leave(object sender, EventArgs e)
        {
            try
            {
                string varOpeCodigo = (sender as GridLookUpEdit).Text;
                if (varOpeCodigo.Equals("")) return;

                List<clsProOperacion> lisOperacion = clsProOperacion.funListar(varOpeCodigo);

                int varFila = this.grvRuta.FocusedRowHandle;
                if (!lisOperacion.Equals(null))
                {
                    foreach (var regOperacion in lisOperacion)
                    {
                        this.grvRuta.SetRowCellValue(varFila, colOprCodigo, regOperacion.OppCodigo);
                        this.grvRuta.SetRowCellValue(varFila, colOprNombre, regOperacion.OppNombre);
                    }
                }
                else
                    this.grvRuta.SetRowCellValue(varFila, colOprNombre, "");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void gluOperacion_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void smiBorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grvListado.IsFocusedView)
                {
                    DataRow drMaterial = ((System.Data.DataRowView)(this.grvListado.GetFocusedRow())).Row;
                    this.dtMateriales.Rows.Remove(drMaterial);
                    this.dtMateriales.AcceptChanges();
                }
                else if (this.grvRuta.IsFocusedView)
                {
                    DataRow drRuta = ((System.Data.DataRowView)(this.grvRuta.GetFocusedRow())).Row;
                    this.dtRuta.Rows.Remove(drRuta);
                    this.dtRuta.AcceptChanges();
                }
                else if (this.grvMerma.IsFocusedView)
                {
                    DataRow drMerma = ((System.Data.DataRowView)(this.grvMerma.GetFocusedRow())).Row;
                    this.dtMerma.Rows.Remove(drMerma);
                    this.dtMerma.AcceptChanges();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void chkRuta_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (varOpeCodigo.Equals(1) || varOpeCodigo.Equals(2))
                {
                    if (((CheckEdit)sender).CheckState == CheckState.Checked)
                        this.lueRuta.ReadOnly = false;
                    else
                    {
                        this.lueRuta.ReadOnly = true;
                        this.lueRuta.EditValue = 0;
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void itxCantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                this.dtMateriales.AcceptChanges();
                if (this.dtMateriales.Rows.Count.Equals(0)) return;
                if (this.dtMateriales.Select("DfmTipo = 'INGR'").Length.Equals(0)) return;

                decimal varCantidadPor = this.dtMateriales.Compute("Sum(DfmCantidad)", "DfmTipo = 'INGR'") == null ? 0 : decimal.Parse(this.dtMateriales.Compute("Sum(DfmCantidad)", "DfmTipo = 'INGR'").ToString());
                foreach (DataRow drMaterial in this.dtMateriales.Select("DfmTipo = 'INGR'")) drMaterial["DfmCantidadPor"] = varCantidadPor;
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
