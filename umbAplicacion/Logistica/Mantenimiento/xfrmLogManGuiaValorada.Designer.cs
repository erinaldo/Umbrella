namespace umbAplicacion.Logistica.Mantenimiento
{
    partial class xfrmLogManGuiaValorada
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmLogManGuiaValorada));
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCantPermitida = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.grcDetalle = new DevExpress.XtraGrid.GridControl();
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtrDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetDocNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetCabNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetCabFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetChfNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetAyuNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetTrnPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtrDetValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxValor = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.lblRuta = new DevExpress.XtraEditors.LabelControl();
            this.lueRuta = new DevExpress.XtraEditors.LookUpEdit();
            this.chkAgrupado = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAgrupado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            // 
            // btnGrabar
            // 
            this.btnGrabar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Appearance.Options.UseFont = true;
            this.btnGrabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.Image")));
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 568);
            this.panel1.Size = new System.Drawing.Size(1095, 46);
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(148, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo.TabIndex = 572;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Appearance.Options.UseForeColor = true;
            this.lblCodigo.Location = new System.Drawing.Point(97, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 15);
            this.lblCodigo.TabIndex = 573;
            this.lblCodigo.Text = "Codigo:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = new System.DateTime(2016, 5, 3, 17, 6, 17, 0);
            this.datFecha.Location = new System.Drawing.Point(355, 7);
            this.datFecha.Name = "datFecha";
            this.datFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.datFecha.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecha.Properties.Appearance.Options.UseFont = true;
            this.datFecha.Properties.AutoHeight = false;
            this.datFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFecha.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFecha.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFecha.Size = new System.Drawing.Size(80, 22);
            this.datFecha.TabIndex = 626;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(318, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 15);
            this.labelControl3.TabIndex = 627;
            this.labelControl3.Text = "Fecha:";
            // 
            // lblCantPermitida
            // 
            this.lblCantPermitida.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPermitida.Appearance.Options.UseFont = true;
            this.lblCantPermitida.Location = new System.Drawing.Point(97, 59);
            this.lblCantPermitida.Name = "lblCantPermitida";
            this.lblCantPermitida.Size = new System.Drawing.Size(29, 15);
            this.lblCantPermitida.TabIndex = 629;
            this.lblCantPermitida.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.EditValue = "";
            this.txtValor.EnterMoveNextControl = true;
            this.txtValor.Location = new System.Drawing.Point(148, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseBackColor = true;
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValor.Properties.AutoHeight = false;
            this.txtValor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtValor.Properties.Mask.EditMask = "n2";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.MaxLength = 180;
            this.txtValor.Size = new System.Drawing.Size(81, 22);
            this.txtValor.TabIndex = 628;
            // 
            // grcDetalle
            // 
            this.grcDetalle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcDetalle.Location = new System.Drawing.Point(22, 83);
            this.grcDetalle.MainView = this.grvDetalle;
            this.grcDetalle.Name = "grcDetalle";
            this.grcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itxValor});
            this.grcDetalle.Size = new System.Drawing.Size(1029, 478);
            this.grcDetalle.TabIndex = 649;
            this.grcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetalle});
            // 
            // grvDetalle
            // 
            this.grvDetalle.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDetalle.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDetalle.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDetalle.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.DetailTip.Options.UseFont = true;
            this.grvDetalle.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Empty.Options.UseFont = true;
            this.grvDetalle.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.EvenRow.Options.UseFont = true;
            this.grvDetalle.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDetalle.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FixedLine.Options.UseFont = true;
            this.grvDetalle.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDetalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDetalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDetalle.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupButton.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.grvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDetalle.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.HorzLine.Options.UseFont = true;
            this.grvDetalle.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.OddRow.Options.UseFont = true;
            this.grvDetalle.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Preview.Options.UseFont = true;
            this.grvDetalle.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Row.Options.UseFont = true;
            this.grvDetalle.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDetalle.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDetalle.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDetalle.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.VertLine.Options.UseFont = true;
            this.grvDetalle.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDetalle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAtrDetSecuencia,
            this.colAtrDetDocNombre,
            this.colAtrDetCabNumero,
            this.colAtrDetCabFecha,
            this.colAtrDetChfNombre,
            this.colAtrDetAyuNombre,
            this.colAtrDetTrnPlaca,
            this.colAtrDetValor});
            this.grvDetalle.GridControl = this.grcDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsCustomization.AllowColumnMoving = false;
            this.grvDetalle.OptionsCustomization.AllowColumnResizing = false;
            this.grvDetalle.OptionsCustomization.AllowGroup = false;
            this.grvDetalle.OptionsCustomization.AllowSort = false;
            this.grvDetalle.OptionsDetail.EnableMasterViewMode = false;
            this.grvDetalle.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvDetalle.OptionsFind.AllowFindPanel = false;
            this.grvDetalle.OptionsFind.ShowClearButton = false;
            this.grvDetalle.OptionsFind.ShowCloseButton = false;
            this.grvDetalle.OptionsFind.ShowFindButton = false;
            this.grvDetalle.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDetalle.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grvDetalle.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDetalle.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvDetalle.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvDetalle.OptionsSelection.MultiSelect = true;
            this.grvDetalle.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvDetalle.OptionsView.ColumnAutoWidth = false;
            this.grvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.grvDetalle.OptionsView.ShowDetailButtons = false;
            this.grvDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            this.grvDetalle.ViewCaption = "Productos";
            // 
            // colAtrDetSecuencia
            // 
            this.colAtrDetSecuencia.Caption = "Nro";
            this.colAtrDetSecuencia.FieldName = "AtrDetSecuencia";
            this.colAtrDetSecuencia.Name = "colAtrDetSecuencia";
            this.colAtrDetSecuencia.OptionsColumn.AllowEdit = false;
            this.colAtrDetSecuencia.Visible = true;
            this.colAtrDetSecuencia.VisibleIndex = 1;
            this.colAtrDetSecuencia.Width = 30;
            // 
            // colAtrDetDocNombre
            // 
            this.colAtrDetDocNombre.Caption = "Documento";
            this.colAtrDetDocNombre.FieldName = "AtrDetDocNombre";
            this.colAtrDetDocNombre.Name = "colAtrDetDocNombre";
            this.colAtrDetDocNombre.Visible = true;
            this.colAtrDetDocNombre.VisibleIndex = 2;
            this.colAtrDetDocNombre.Width = 80;
            // 
            // colAtrDetCabNumero
            // 
            this.colAtrDetCabNumero.Caption = "Numero";
            this.colAtrDetCabNumero.FieldName = "AtrDetCabNumero";
            this.colAtrDetCabNumero.Name = "colAtrDetCabNumero";
            this.colAtrDetCabNumero.OptionsColumn.AllowEdit = false;
            this.colAtrDetCabNumero.OptionsColumn.TabStop = false;
            this.colAtrDetCabNumero.Visible = true;
            this.colAtrDetCabNumero.VisibleIndex = 3;
            this.colAtrDetCabNumero.Width = 80;
            // 
            // colAtrDetCabFecha
            // 
            this.colAtrDetCabFecha.Caption = "Fecha";
            this.colAtrDetCabFecha.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colAtrDetCabFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAtrDetCabFecha.FieldName = "AtrDetCabFecha";
            this.colAtrDetCabFecha.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colAtrDetCabFecha.Name = "colAtrDetCabFecha";
            this.colAtrDetCabFecha.OptionsColumn.AllowEdit = false;
            this.colAtrDetCabFecha.OptionsColumn.TabStop = false;
            this.colAtrDetCabFecha.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "DetNomCliente", "TOTALES:")});
            this.colAtrDetCabFecha.Visible = true;
            this.colAtrDetCabFecha.VisibleIndex = 4;
            this.colAtrDetCabFecha.Width = 80;
            // 
            // colAtrDetChfNombre
            // 
            this.colAtrDetChfNombre.Caption = "Chofer";
            this.colAtrDetChfNombre.FieldName = "AtrDetChfNombre";
            this.colAtrDetChfNombre.Name = "colAtrDetChfNombre";
            this.colAtrDetChfNombre.OptionsColumn.AllowEdit = false;
            this.colAtrDetChfNombre.Visible = true;
            this.colAtrDetChfNombre.VisibleIndex = 5;
            this.colAtrDetChfNombre.Width = 250;
            // 
            // colAtrDetAyuNombre
            // 
            this.colAtrDetAyuNombre.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAtrDetAyuNombre.AppearanceHeader.Options.UseFont = true;
            this.colAtrDetAyuNombre.Caption = "Ayudante";
            this.colAtrDetAyuNombre.FieldName = "AtrDetAyuNombre";
            this.colAtrDetAyuNombre.Name = "colAtrDetAyuNombre";
            this.colAtrDetAyuNombre.OptionsColumn.AllowEdit = false;
            this.colAtrDetAyuNombre.Visible = true;
            this.colAtrDetAyuNombre.VisibleIndex = 6;
            this.colAtrDetAyuNombre.Width = 250;
            // 
            // colAtrDetTrnPlaca
            // 
            this.colAtrDetTrnPlaca.Caption = "Placa";
            this.colAtrDetTrnPlaca.FieldName = "AtrDetTrnPlaca";
            this.colAtrDetTrnPlaca.Name = "colAtrDetTrnPlaca";
            this.colAtrDetTrnPlaca.OptionsColumn.AllowEdit = false;
            this.colAtrDetTrnPlaca.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DetPeso", "{0:0.00}")});
            this.colAtrDetTrnPlaca.Visible = true;
            this.colAtrDetTrnPlaca.VisibleIndex = 7;
            this.colAtrDetTrnPlaca.Width = 80;
            // 
            // colAtrDetValor
            // 
            this.colAtrDetValor.AppearanceCell.Options.UseTextOptions = true;
            this.colAtrDetValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAtrDetValor.Caption = "Valor";
            this.colAtrDetValor.ColumnEdit = this.itxValor;
            this.colAtrDetValor.FieldName = "AtrDetValor";
            this.colAtrDetValor.Name = "colAtrDetValor";
            this.colAtrDetValor.Visible = true;
            this.colAtrDetValor.VisibleIndex = 8;
            // 
            // itxValor
            // 
            this.itxValor.AutoHeight = false;
            this.itxValor.Mask.EditMask = "c";
            this.itxValor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxValor.Mask.UseMaskAsDisplayFormat = true;
            this.itxValor.Name = "itxValor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = global::umbAplicacion.Properties.Resources.imgAdd16;
            this.btnAgregar.Location = new System.Drawing.Point(1057, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(25, 23);
            this.btnAgregar.TabIndex = 650;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = global::umbAplicacion.Properties.Resources.imgBorrar16;
            this.btnEliminar.Location = new System.Drawing.Point(1057, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(25, 23);
            this.btnEliminar.TabIndex = 651;
            this.btnEliminar.Text = "simpleButton2";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblRuta.Appearance.Options.UseFont = true;
            this.lblRuta.Appearance.Options.UseForeColor = true;
            this.lblRuta.Location = new System.Drawing.Point(97, 35);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(26, 15);
            this.lblRuta.TabIndex = 653;
            this.lblRuta.Text = "Ruta:";
            // 
            // lueRuta
            // 
            this.lueRuta.Location = new System.Drawing.Point(148, 31);
            this.lueRuta.Name = "lueRuta";
            this.lueRuta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRuta.Properties.Appearance.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueRuta.Properties.AutoHeight = false;
            this.lueRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRuta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AtrRguCodigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AtrRguNombre", "Ruta", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueRuta.Properties.DisplayMember = "AtrRguNombre";
            this.lueRuta.Properties.NullText = "";
            this.lueRuta.Properties.ValueMember = "AtrRguCodigo";
            this.lueRuta.Size = new System.Drawing.Size(287, 22);
            this.lueRuta.TabIndex = 679;
            // 
            // chkAgrupado
            // 
            this.chkAgrupado.EditValue = true;
            this.chkAgrupado.Location = new System.Drawing.Point(345, 54);
            this.chkAgrupado.Name = "chkAgrupado";
            this.chkAgrupado.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgrupado.Properties.Appearance.Options.UseFont = true;
            this.chkAgrupado.Properties.Caption = "Agrupar guias:";
            this.chkAgrupado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkAgrupado.Size = new System.Drawing.Size(93, 19);
            this.chkAgrupado.TabIndex = 680;
            this.chkAgrupado.CheckedChanged += new System.EventHandler(this.chkAgrupado_CheckedChanged);
            // 
            // xfrmLogManGuiaValorada
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1095, 614);
            this.Controls.Add(this.chkAgrupado);
            this.Controls.Add(this.lueRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grcDetalle);
            this.Controls.Add(this.lblCantPermitida);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "xfrmLogManGuiaValorada";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.lblCantPermitida, 0);
            this.Controls.SetChildIndex(this.grcDetalle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.lblRuta, 0);
            this.Controls.SetChildIndex(this.lueRuta, 0);
            this.Controls.SetChildIndex(this.chkAgrupado, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAgrupado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblCantPermitida;
        private DevExpress.XtraEditors.TextEdit txtValor;
        public DevExpress.XtraGrid.GridControl grcDetalle;
        public DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetDocNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetCabNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetCabFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetChfNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetAyuNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetTrnPlaca;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxValor;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.LabelControl lblRuta;
        private DevExpress.XtraEditors.LookUpEdit lueRuta;
        private DevExpress.XtraEditors.CheckEdit chkAgrupado;
        private DevExpress.XtraGrid.Columns.GridColumn colAtrDetValor;
    }
}
