namespace umbAplicacion.Compras.Mantenimiento
{
    partial class xfrmComManCodigoBarraRecepcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmComManCodigoBarraRecepcion));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colDetCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.lblSerie = new DevExpress.XtraEditors.LabelControl();
            this.grcDetalle = new DevExpress.XtraGrid.GridControl();
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuenciaRes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetPiezas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetNro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxNro = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetImprimir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ibuImpresion = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDetLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetUndMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.bedProveedor = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxNro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibuImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.Caption = "Cantidad";
            this.colDetCantidad.DisplayFormat.FormatString = "{0:0.0000}";
            this.colDetCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantidad.FieldName = "DetCantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.OptionsColumn.AllowEdit = false;
            this.colDetCantidad.Visible = true;
            this.colDetCantidad.VisibleIndex = 5;
            this.colDetCantidad.Width = 70;
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(635, 20);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(68, 22);
            this.txtNumero.TabIndex = 640;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Enabled = false;
            this.txtNomSerie.Location = new System.Drawing.Point(554, 20);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Properties.ReadOnly = true;
            this.txtNomSerie.Size = new System.Drawing.Size(80, 22);
            this.txtNomSerie.TabIndex = 639;
            // 
            // lblSerie
            // 
            this.lblSerie.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Appearance.Options.UseFont = true;
            this.lblSerie.Location = new System.Drawing.Point(522, 23);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(26, 15);
            this.lblSerie.TabIndex = 638;
            this.lblSerie.Text = "Serie:";
            // 
            // grcDetalle
            // 
            this.grcDetalle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcDetalle.Location = new System.Drawing.Point(24, 191);
            this.grcDetalle.MainView = this.grvDetalle;
            this.grcDetalle.Name = "grcDetalle";
            this.grcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ibuImpresion,
            this.itxNro});
            this.grcDetalle.Size = new System.Drawing.Size(710, 184);
            this.grcDetalle.TabIndex = 657;
            this.grcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetalle});
            // 
            // grvDetalle
            // 
            this.grvDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvDetalle.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvDetalle.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDetalle.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvDetalle.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDetalle.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvDetalle.Appearance.DetailTip.Options.UseFont = true;
            this.grvDetalle.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.grvDetalle.Appearance.Empty.Options.UseFont = true;
            this.grvDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.EvenRow.Options.UseFont = true;
            this.grvDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FixedLine.Options.UseFont = true;
            this.grvDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvDetalle.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvDetalle.Appearance.GroupButton.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvDetalle.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvDetalle.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.grvDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDetalle.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.HorzLine.Options.UseFont = true;
            this.grvDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.OddRow.Options.UseFont = true;
            this.grvDetalle.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.grvDetalle.Appearance.Preview.Options.UseFont = true;
            this.grvDetalle.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.Row.Options.UseBackColor = true;
            this.grvDetalle.Appearance.Row.Options.UseFont = true;
            this.grvDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvDetalle.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDetalle.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDetalle.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.VertLine.Options.UseFont = true;
            this.grvDetalle.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvDetalle.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetalle.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvDetalle.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDetalle.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.grvDetalle.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grvDetalle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetSecuenciaRes,
            this.colIteCodigo,
            this.colIteNombre,
            this.colDetPiezas,
            this.colDetCantidad,
            this.colDetNro,
            this.colDetImprimir,
            this.colDetLote,
            this.colDetUndMedida});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDetCantidad;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "D";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colDetCantidad;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "A";
            this.grvDetalle.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.grvDetalle.GridControl = this.grcDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsCustomization.AllowColumnMoving = false;
            this.grvDetalle.OptionsCustomization.AllowColumnResizing = false;
            this.grvDetalle.OptionsCustomization.AllowFilter = false;
            this.grvDetalle.OptionsCustomization.AllowGroup = false;
            this.grvDetalle.OptionsCustomization.AllowSort = false;
            this.grvDetalle.OptionsDetail.EnableMasterViewMode = false;
            this.grvDetalle.OptionsFilter.AllowFilterEditor = false;
            this.grvDetalle.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvDetalle.OptionsFind.AllowFindPanel = false;
            this.grvDetalle.OptionsFind.ShowClearButton = false;
            this.grvDetalle.OptionsFind.ShowCloseButton = false;
            this.grvDetalle.OptionsFind.ShowFindButton = false;
            this.grvDetalle.OptionsView.ColumnAutoWidth = false;
            this.grvDetalle.OptionsView.ShowDetailButtons = false;
            this.grvDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // colDetSecuenciaRes
            // 
            this.colDetSecuenciaRes.Caption = "Nro";
            this.colDetSecuenciaRes.FieldName = "DetSecuencia";
            this.colDetSecuenciaRes.Name = "colDetSecuenciaRes";
            this.colDetSecuenciaRes.OptionsColumn.AllowEdit = false;
            this.colDetSecuenciaRes.OptionsColumn.TabStop = false;
            this.colDetSecuenciaRes.Visible = true;
            this.colDetSecuenciaRes.VisibleIndex = 0;
            this.colDetSecuenciaRes.Width = 30;
            // 
            // colIteCodigo
            // 
            this.colIteCodigo.Caption = "Item";
            this.colIteCodigo.FieldName = "IteCodigo";
            this.colIteCodigo.Name = "colIteCodigo";
            this.colIteCodigo.OptionsColumn.AllowEdit = false;
            this.colIteCodigo.Visible = true;
            this.colIteCodigo.VisibleIndex = 1;
            this.colIteCodigo.Width = 80;
            // 
            // colIteNombre
            // 
            this.colIteNombre.Caption = "Descripcion";
            this.colIteNombre.FieldName = "IteNombre";
            this.colIteNombre.Name = "colIteNombre";
            this.colIteNombre.OptionsColumn.AllowEdit = false;
            this.colIteNombre.OptionsColumn.TabStop = false;
            this.colIteNombre.Visible = true;
            this.colIteNombre.VisibleIndex = 2;
            this.colIteNombre.Width = 190;
            // 
            // colDetPiezas
            // 
            this.colDetPiezas.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetPiezas.AppearanceHeader.Options.UseFont = true;
            this.colDetPiezas.Caption = "Piezas";
            this.colDetPiezas.DisplayFormat.FormatString = "{0:0}";
            this.colDetPiezas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetPiezas.FieldName = "DetPiezas";
            this.colDetPiezas.Name = "colDetPiezas";
            this.colDetPiezas.OptionsColumn.AllowEdit = false;
            this.colDetPiezas.Visible = true;
            this.colDetPiezas.VisibleIndex = 4;
            this.colDetPiezas.Width = 70;
            // 
            // colDetNro
            // 
            this.colDetNro.Caption = "Nro";
            this.colDetNro.ColumnEdit = this.itxNro;
            this.colDetNro.FieldName = "DetNro";
            this.colDetNro.Name = "colDetNro";
            this.colDetNro.Visible = true;
            this.colDetNro.VisibleIndex = 7;
            this.colDetNro.Width = 40;
            // 
            // itxNro
            // 
            this.itxNro.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxNro.Appearance.Options.UseFont = true;
            this.itxNro.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxNro.AppearanceDisabled.Options.UseFont = true;
            this.itxNro.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxNro.AppearanceFocused.Options.UseFont = true;
            this.itxNro.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxNro.AppearanceReadOnly.Options.UseFont = true;
            this.itxNro.AutoHeight = false;
            this.itxNro.DisplayFormat.FormatString = "n0";
            this.itxNro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.itxNro.EditFormat.FormatString = "n0";
            this.itxNro.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.itxNro.Mask.EditMask = "n0";
            this.itxNro.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxNro.Name = "itxNro";
            // 
            // colDetImprimir
            // 
            this.colDetImprimir.ColumnEdit = this.ibuImpresion;
            this.colDetImprimir.Name = "colDetImprimir";
            this.colDetImprimir.Visible = true;
            this.colDetImprimir.VisibleIndex = 8;
            this.colDetImprimir.Width = 40;
            // 
            // ibuImpresion
            // 
            this.ibuImpresion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibuImpresion.Appearance.Options.UseFont = true;
            this.ibuImpresion.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibuImpresion.AppearanceDisabled.Options.UseFont = true;
            this.ibuImpresion.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibuImpresion.AppearanceFocused.Options.UseFont = true;
            this.ibuImpresion.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibuImpresion.AppearanceReadOnly.Options.UseFont = true;
            this.ibuImpresion.AutoHeight = false;
            editorButtonImageOptions1.Image = global::umbAplicacion.Properties.Resources.imgImprimir16;
            this.ibuImpresion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ibuImpresion.Name = "ibuImpresion";
            this.ibuImpresion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ibuImpresion.Click += new System.EventHandler(this.ibuImpresion_Click);
            // 
            // colDetLote
            // 
            this.colDetLote.Caption = "Lote";
            this.colDetLote.FieldName = "DetLote";
            this.colDetLote.Name = "colDetLote";
            this.colDetLote.OptionsColumn.AllowEdit = false;
            this.colDetLote.Visible = true;
            this.colDetLote.VisibleIndex = 6;
            this.colDetLote.Width = 70;
            // 
            // colDetUndMedida
            // 
            this.colDetUndMedida.Caption = "Und. Medida";
            this.colDetUndMedida.FieldName = "DetUndMedida";
            this.colDetUndMedida.Name = "colDetUndMedida";
            this.colDetUndMedida.OptionsColumn.AllowEdit = false;
            this.colDetUndMedida.Visible = true;
            this.colDetUndMedida.VisibleIndex = 3;
            this.colDetUndMedida.Width = 70;
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Appearance.Options.UseFont = true;
            this.lblFecha.Location = new System.Drawing.Point(48, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(31, 15);
            this.lblFecha.TabIndex = 659;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.EditValue = "";
            this.txtProveedor.EnterMoveNextControl = true;
            this.txtProveedor.Location = new System.Drawing.Point(206, 43);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Properties.Appearance.Options.UseFont = true;
            this.txtProveedor.Properties.AutoHeight = false;
            this.txtProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProveedor.Properties.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(275, 23);
            this.txtProveedor.TabIndex = 663;
            this.txtProveedor.TabStop = false;
            // 
            // bedProveedor
            // 
            this.bedProveedor.EditValue = "";
            this.bedProveedor.Location = new System.Drawing.Point(106, 43);
            this.bedProveedor.Name = "bedProveedor";
            this.bedProveedor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedProveedor.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedProveedor.Properties.Appearance.Options.UseBackColor = true;
            this.bedProveedor.Properties.Appearance.Options.UseFont = true;
            this.bedProveedor.Properties.AutoHeight = false;
            this.bedProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.bedProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bedProveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedProveedor.Size = new System.Drawing.Size(101, 23);
            this.bedProveedor.TabIndex = 662;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 15);
            this.labelControl1.TabIndex = 664;
            this.labelControl1.Text = "Proveedor:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(106, 20);
            this.datFecha.Name = "datFecha";
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
            this.datFecha.Size = new System.Drawing.Size(101, 22);
            this.datFecha.TabIndex = 665;
            // 
            // xfrmComManCodigoBarraRecepcion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 402);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.bedProveedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.grcDetalle);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.lblSerie);
            this.Name = "xfrmComManCodigoBarraRecepcion";
            this.Text = "Generación de Codigo de Barras Recepción";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxNro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibuImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl lblSerie;
        public DevExpress.XtraGrid.GridControl grcDetalle;
        public DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuenciaRes;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPiezas;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDetNro;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxNro;
        private DevExpress.XtraGrid.Columns.GridColumn colDetImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ibuImpresion;
        private DevExpress.XtraGrid.Columns.GridColumn colDetLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDetUndMedida;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.ButtonEdit bedProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit datFecha;
    }
}