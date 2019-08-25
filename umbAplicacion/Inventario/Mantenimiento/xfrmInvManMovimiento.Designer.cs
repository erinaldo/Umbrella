namespace umbAplicacion.Inventario.Mantenimiento
{
    partial class xfrmInvManMovimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmInvManMovimiento));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItmItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItmItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItmInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItmManBtchNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItmAvgPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteUndInventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetTipDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluTipoDestino = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDetIdDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ibeBatch = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDetOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluBatch = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.glvBatch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetBatchNro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetBatchCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetBatchIteCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxDecimalCuatro = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetPieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotPerdida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluMotPerdida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxNumero = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteTieLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItePsoStd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lueMotivo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblMotivo = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoMovimiento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueRazon = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueBodega = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueProyecto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lueCenCosto = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCenCosto = new DevExpress.XtraEditors.TextEdit();
            this.txtProyecto = new DevExpress.XtraEditors.TextEdit();
            this.txtSapNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.memObsDocumento = new DevExpress.XtraEditors.MemoEdit();
            this.lblObsDocumento = new DevExpress.XtraEditors.LabelControl();
            this.memObsDiario = new DevExpress.XtraEditors.MemoEdit();
            this.lblObsDiario = new DevExpress.XtraEditors.LabelControl();
            this.btnExtraer = new DevExpress.XtraEditors.SimpleButton();
            this.butExaminar = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluTipoDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluMotPerdida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoMovimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCenCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProyecto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDiario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.TabIndex = 0;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Appearance.Options.UseFont = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 624);
            this.panel1.Size = new System.Drawing.Size(1146, 46);
            this.panel1.TabIndex = 9;
            // 
            // grcListado
            // 
            this.grcListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcListado.ContextMenuStrip = this.cmsMenu;
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(23, 145);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluItem,
            this.itxNumero,
            this.gluBatch,
            this.iluTipoDestino,
            this.itxDecimalCuatro,
            this.iluMotPerdida,
            this.ibeBatch});
            this.grcListado.Size = new System.Drawing.Size(1101, 393);
            this.grcListado.TabIndex = 14;
            this.grcListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListado});
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBorrar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(203, 26);
            // 
            // smiBorrar
            // 
            this.smiBorrar.Image = ((System.Drawing.Image)(resources.GetObject("smiBorrar.Image")));
            this.smiBorrar.Name = "smiBorrar";
            this.smiBorrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.smiBorrar.Size = new System.Drawing.Size(202, 22);
            this.smiBorrar.Text = "Borrar detalle";
            this.smiBorrar.Click += new System.EventHandler(this.smiBorrar_Click);
            // 
            // grvListado
            // 
            this.grvListado.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvListado.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.DetailTip.Options.UseFont = true;
            this.grvListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Empty.Options.UseFont = true;
            this.grvListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.EvenRow.Options.UseFont = true;
            this.grvListado.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterPanel.Options.UseFont = true;
            this.grvListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FixedLine.Options.UseFont = true;
            this.grvListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedCell.Options.UseFont = true;
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedRow.Options.UseFont = true;
            this.grvListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FooterPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupButton.Options.UseFont = true;
            this.grvListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupFooter.Options.UseFont = true;
            this.grvListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupRow.Options.UseFont = true;
            this.grvListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HorzLine.Options.UseFont = true;
            this.grvListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.OddRow.Options.UseFont = true;
            this.grvListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Preview.Options.UseFont = true;
            this.grvListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Row.Options.UseFont = true;
            this.grvListado.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.RowSeparator.Options.UseFont = true;
            this.grvListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.SelectedRow.Options.UseFont = true;
            this.grvListado.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.TopNewRow.Options.UseFont = true;
            this.grvListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.VertLine.Options.UseFont = true;
            this.grvListado.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ViewCaption.Options.UseFont = true;
            this.grvListado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetSecuencia,
            this.colIteCodigo,
            this.colIteNombre,
            this.colIteUndInventario,
            this.colDetTipDestino,
            this.colDetIdDestino,
            this.colDetOpcion,
            this.colDetCantidad,
            this.colDetPieza,
            this.colIdMotPerdida,
            this.colCosto,
            this.colValor,
            this.colIteTieLote,
            this.colItePsoStd,
            this.colDetPeso});
            this.grvListado.GridControl = this.grcListado;
            this.grvListado.Name = "grvListado";
            this.grvListado.OptionsCustomization.AllowColumnMoving = false;
            this.grvListado.OptionsCustomization.AllowColumnResizing = false;
            this.grvListado.OptionsCustomization.AllowGroup = false;
            this.grvListado.OptionsCustomization.AllowSort = false;
            this.grvListado.OptionsDetail.EnableMasterViewMode = false;
            this.grvListado.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvListado.OptionsFind.AllowFindPanel = false;
            this.grvListado.OptionsFind.ShowClearButton = false;
            this.grvListado.OptionsFind.ShowCloseButton = false;
            this.grvListado.OptionsFind.ShowFindButton = false;
            this.grvListado.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvListado.OptionsView.ColumnAutoWidth = false;
            this.grvListado.OptionsView.ShowDetailButtons = false;
            this.grvListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvListado.OptionsView.ShowFooter = true;
            this.grvListado.OptionsView.ShowGroupPanel = false;
            this.grvListado.ViewCaption = "Items";
            this.grvListado.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvListado_ShowingEditor);
            // 
            // colDetSecuencia
            // 
            this.colDetSecuencia.Caption = "Nro";
            this.colDetSecuencia.FieldName = "DetSecuencia";
            this.colDetSecuencia.Name = "colDetSecuencia";
            this.colDetSecuencia.OptionsColumn.AllowEdit = false;
            this.colDetSecuencia.Visible = true;
            this.colDetSecuencia.VisibleIndex = 0;
            this.colDetSecuencia.Width = 30;
            // 
            // colIteCodigo
            // 
            this.colIteCodigo.Caption = "Item";
            this.colIteCodigo.ColumnEdit = this.gluItem;
            this.colIteCodigo.FieldName = "IteCodigo";
            this.colIteCodigo.Name = "colIteCodigo";
            this.colIteCodigo.Visible = true;
            this.colIteCodigo.VisibleIndex = 1;
            this.colIteCodigo.Width = 90;
            // 
            // gluItem
            // 
            this.gluItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluItem.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.Appearance.Image")));
            this.gluItem.Appearance.Options.UseFont = true;
            this.gluItem.Appearance.Options.UseImage = true;
            this.gluItem.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceDisabled.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceDisabled.Image")));
            this.gluItem.AppearanceDisabled.Options.UseFont = true;
            this.gluItem.AppearanceDisabled.Options.UseImage = true;
            this.gluItem.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceDropDown.Image")));
            this.gluItem.AppearanceDropDown.Options.UseFont = true;
            this.gluItem.AppearanceDropDown.Options.UseImage = true;
            this.gluItem.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceFocused.Image")));
            this.gluItem.AppearanceFocused.Options.UseFont = true;
            this.gluItem.AppearanceFocused.Options.UseImage = true;
            this.gluItem.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceReadOnly.Image")));
            this.gluItem.AppearanceReadOnly.Options.UseFont = true;
            this.gluItem.AppearanceReadOnly.Options.UseImage = true;
            this.gluItem.AutoHeight = false;
            this.gluItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluItem.DisplayMember = "ItemCode";
            this.gluItem.ImmediatePopup = true;
            this.gluItem.Name = "gluItem";
            this.gluItem.NullText = "";
            this.gluItem.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluItem.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluItem.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluItem.ValueMember = "ItemCode";
            this.gluItem.View = this.igvItem;
            this.gluItem.Popup += new System.EventHandler(this.gluItem_Popup);
            this.gluItem.Leave += new System.EventHandler(this.gluItem_Leave);
            // 
            // igvItem
            // 
            this.igvItem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.igvItem.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.igvItem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.igvItem.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.igvItem.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.igvItem.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.igvItem.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.DetailTip.Options.UseBackColor = true;
            this.igvItem.Appearance.DetailTip.Options.UseFont = true;
            this.igvItem.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Empty.Options.UseBackColor = true;
            this.igvItem.Appearance.Empty.Options.UseFont = true;
            this.igvItem.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.EvenRow.Options.UseBackColor = true;
            this.igvItem.Appearance.EvenRow.Options.UseFont = true;
            this.igvItem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.igvItem.Appearance.FilterCloseButton.Options.UseFont = true;
            this.igvItem.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FilterPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.FilterPanel.Options.UseFont = true;
            this.igvItem.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FixedLine.Options.UseBackColor = true;
            this.igvItem.Appearance.FixedLine.Options.UseFont = true;
            this.igvItem.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FocusedCell.Options.UseBackColor = true;
            this.igvItem.Appearance.FocusedCell.Options.UseFont = true;
            this.igvItem.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.igvItem.Appearance.FocusedRow.Options.UseFont = true;
            this.igvItem.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FooterPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.igvItem.Appearance.FooterPanel.Options.UseFont = true;
            this.igvItem.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupButton.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupButton.Options.UseFont = true;
            this.igvItem.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupFooter.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupFooter.Options.UseFont = true;
            this.igvItem.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupPanel.Options.UseFont = true;
            this.igvItem.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupRow.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupRow.Options.UseFont = true;
            this.igvItem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.HeaderPanel.Options.UseFont = true;
            this.igvItem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.igvItem.Appearance.HideSelectionRow.Options.UseFont = true;
            this.igvItem.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HorzLine.Options.UseFont = true;
            this.igvItem.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.OddRow.Options.UseBackColor = true;
            this.igvItem.Appearance.OddRow.Options.UseFont = true;
            this.igvItem.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Preview.Options.UseBackColor = true;
            this.igvItem.Appearance.Preview.Options.UseFont = true;
            this.igvItem.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Row.Options.UseBackColor = true;
            this.igvItem.Appearance.Row.Options.UseFont = true;
            this.igvItem.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.RowSeparator.Options.UseBackColor = true;
            this.igvItem.Appearance.RowSeparator.Options.UseFont = true;
            this.igvItem.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.igvItem.Appearance.SelectedRow.Options.UseFont = true;
            this.igvItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this.igvItem.Appearance.TopNewRow.Options.UseFont = true;
            this.igvItem.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.VertLine.Options.UseFont = true;
            this.igvItem.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ViewCaption.Options.UseBackColor = true;
            this.igvItem.Appearance.ViewCaption.Options.UseFont = true;
            this.igvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItmItemCode,
            this.colItmItemName,
            this.colItmInvntryUom,
            this.colItmManBtchNum,
            this.colItmAvgPrice});
            this.igvItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.igvItem.Name = "igvItem";
            this.igvItem.OptionsCustomization.AllowColumnMoving = false;
            this.igvItem.OptionsCustomization.AllowColumnResizing = false;
            this.igvItem.OptionsCustomization.AllowGroup = false;
            this.igvItem.OptionsCustomization.AllowSort = false;
            this.igvItem.OptionsFind.AllowFindPanel = false;
            this.igvItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.igvItem.OptionsView.ColumnAutoWidth = false;
            this.igvItem.OptionsView.ShowAutoFilterRow = true;
            this.igvItem.OptionsView.ShowDetailButtons = false;
            this.igvItem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.igvItem.OptionsView.ShowGroupPanel = false;
            // 
            // colItmItemCode
            // 
            this.colItmItemCode.Caption = "Codigo";
            this.colItmItemCode.FieldName = "ItemCode";
            this.colItmItemCode.Name = "colItmItemCode";
            this.colItmItemCode.OptionsColumn.AllowEdit = false;
            this.colItmItemCode.Visible = true;
            this.colItmItemCode.VisibleIndex = 0;
            this.colItmItemCode.Width = 80;
            // 
            // colItmItemName
            // 
            this.colItmItemName.Caption = "Item";
            this.colItmItemName.FieldName = "ItemName";
            this.colItmItemName.Name = "colItmItemName";
            this.colItmItemName.OptionsColumn.AllowEdit = false;
            this.colItmItemName.Visible = true;
            this.colItmItemName.VisibleIndex = 1;
            this.colItmItemName.Width = 300;
            // 
            // colItmInvntryUom
            // 
            this.colItmInvntryUom.Caption = "Unidad";
            this.colItmInvntryUom.FieldName = "InvntryUom";
            this.colItmInvntryUom.Name = "colItmInvntryUom";
            this.colItmInvntryUom.Visible = true;
            this.colItmInvntryUom.VisibleIndex = 2;
            this.colItmInvntryUom.Width = 50;
            // 
            // colItmManBtchNum
            // 
            this.colItmManBtchNum.Caption = "Loteable";
            this.colItmManBtchNum.FieldName = "ManBtchNum";
            this.colItmManBtchNum.Name = "colItmManBtchNum";
            this.colItmManBtchNum.Visible = true;
            this.colItmManBtchNum.VisibleIndex = 3;
            this.colItmManBtchNum.Width = 50;
            // 
            // colItmAvgPrice
            // 
            this.colItmAvgPrice.Caption = "Costo";
            this.colItmAvgPrice.FieldName = "AvgPrice";
            this.colItmAvgPrice.Name = "colItmAvgPrice";
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
            this.colIteNombre.Width = 250;
            // 
            // colIteUndInventario
            // 
            this.colIteUndInventario.Caption = "Und.";
            this.colIteUndInventario.FieldName = "IteUndInventario";
            this.colIteUndInventario.Name = "colIteUndInventario";
            this.colIteUndInventario.OptionsColumn.AllowEdit = false;
            this.colIteUndInventario.OptionsColumn.TabStop = false;
            this.colIteUndInventario.Visible = true;
            this.colIteUndInventario.VisibleIndex = 3;
            this.colIteUndInventario.Width = 50;
            // 
            // colDetTipDestino
            // 
            this.colDetTipDestino.Caption = "Tipo destino";
            this.colDetTipDestino.ColumnEdit = this.iluTipoDestino;
            this.colDetTipDestino.FieldName = "DetTipDestino";
            this.colDetTipDestino.Name = "colDetTipDestino";
            this.colDetTipDestino.Width = 90;
            // 
            // iluTipoDestino
            // 
            this.iluTipoDestino.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iluTipoDestino.Appearance.Options.UseFont = true;
            this.iluTipoDestino.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipoDestino.AppearanceDisabled.Options.UseFont = true;
            this.iluTipoDestino.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipoDestino.AppearanceDropDown.Options.UseFont = true;
            this.iluTipoDestino.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipoDestino.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluTipoDestino.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipoDestino.AppearanceFocused.Options.UseFont = true;
            this.iluTipoDestino.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipoDestino.AppearanceReadOnly.Options.UseFont = true;
            this.iluTipoDestino.AutoHeight = false;
            this.iluTipoDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluTipoDestino.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 80, "Descripcion"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.iluTipoDestino.DisplayMember = "Descripcion";
            this.iluTipoDestino.Name = "iluTipoDestino";
            this.iluTipoDestino.NullText = "";
            this.iluTipoDestino.Tag = "";
            this.iluTipoDestino.ValueMember = "Codigo";
            this.iluTipoDestino.EditValueChanged += new System.EventHandler(this.iluTipoDestino_EditValueChanged);
            // 
            // colDetIdDestino
            // 
            this.colDetIdDestino.Caption = "Chapeta/Lote";
            this.colDetIdDestino.ColumnEdit = this.ibeBatch;
            this.colDetIdDestino.FieldName = "DetIdDestino";
            this.colDetIdDestino.Name = "colDetIdDestino";
            this.colDetIdDestino.Width = 120;
            // 
            // ibeBatch
            // 
            this.ibeBatch.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibeBatch.Appearance.Options.UseFont = true;
            this.ibeBatch.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.ibeBatch.AppearanceDisabled.Options.UseFont = true;
            this.ibeBatch.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.ibeBatch.AppearanceFocused.Options.UseFont = true;
            this.ibeBatch.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.ibeBatch.AppearanceReadOnly.Options.UseFont = true;
            this.ibeBatch.AutoHeight = false;
            this.ibeBatch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("ibeBatch.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.ibeBatch.Name = "ibeBatch";
            this.ibeBatch.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ibeBatch.Click += new System.EventHandler(this.ibeBatch_Click);
            // 
            // colDetOpcion
            // 
            this.colDetOpcion.Caption = " ";
            this.colDetOpcion.ColumnEdit = this.gluBatch;
            this.colDetOpcion.Name = "colDetOpcion";
            this.colDetOpcion.Width = 20;
            // 
            // gluBatch
            // 
            this.gluBatch.AutoHeight = false;
            this.gluBatch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluBatch.DisplayMember = "BatchNum";
            this.gluBatch.Name = "gluBatch";
            this.gluBatch.PopupFormMinSize = new System.Drawing.Size(250, 200);
            this.gluBatch.PopupFormSize = new System.Drawing.Size(250, 200);
            this.gluBatch.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gluBatch.ValueMember = "BatchNum";
            this.gluBatch.View = this.glvBatch;
            this.gluBatch.EditValueChanged += new System.EventHandler(this.gluBatch_EditValueChanged);
            // 
            // glvBatch
            // 
            this.glvBatch.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.glvBatch.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.glvBatch.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.glvBatch.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.DetailTip.Options.UseFont = true;
            this.glvBatch.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.Empty.Options.UseFont = true;
            this.glvBatch.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.EvenRow.Options.UseFont = true;
            this.glvBatch.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FilterCloseButton.Options.UseFont = true;
            this.glvBatch.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FilterPanel.Options.UseFont = true;
            this.glvBatch.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FixedLine.Options.UseFont = true;
            this.glvBatch.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FocusedCell.Options.UseFont = true;
            this.glvBatch.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FocusedRow.Options.UseFont = true;
            this.glvBatch.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.FooterPanel.Options.UseFont = true;
            this.glvBatch.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.GroupButton.Options.UseFont = true;
            this.glvBatch.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.GroupFooter.Options.UseFont = true;
            this.glvBatch.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.GroupPanel.Options.UseFont = true;
            this.glvBatch.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.glvBatch.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.GroupRow.Options.UseBackColor = true;
            this.glvBatch.Appearance.GroupRow.Options.UseFont = true;
            this.glvBatch.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.HeaderPanel.Options.UseFont = true;
            this.glvBatch.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.HideSelectionRow.Options.UseFont = true;
            this.glvBatch.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.HorzLine.Options.UseFont = true;
            this.glvBatch.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.OddRow.Options.UseFont = true;
            this.glvBatch.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.Preview.Options.UseFont = true;
            this.glvBatch.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.Row.Options.UseFont = true;
            this.glvBatch.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.RowSeparator.Options.UseFont = true;
            this.glvBatch.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.SelectedRow.Options.UseFont = true;
            this.glvBatch.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.TopNewRow.Options.UseFont = true;
            this.glvBatch.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.VertLine.Options.UseFont = true;
            this.glvBatch.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.glvBatch.Appearance.ViewCaption.Options.UseFont = true;
            this.glvBatch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetBatchNro,
            this.colDetBatchCantidad,
            this.colDetBatchIteCodigo});
            this.glvBatch.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glvBatch.Name = "glvBatch";
            this.glvBatch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glvBatch.OptionsView.ShowGroupPanel = false;
            // 
            // colDetBatchNro
            // 
            this.colDetBatchNro.Caption = "Chapeta";
            this.colDetBatchNro.FieldName = "DetBatchNro";
            this.colDetBatchNro.Name = "colDetBatchNro";
            this.colDetBatchNro.Visible = true;
            this.colDetBatchNro.VisibleIndex = 0;
            this.colDetBatchNro.Width = 180;
            // 
            // colDetBatchCantidad
            // 
            this.colDetBatchCantidad.Caption = "Cantidad";
            this.colDetBatchCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetBatchCantidad.FieldName = "DetBatchCantidad";
            this.colDetBatchCantidad.Name = "colDetBatchCantidad";
            this.colDetBatchCantidad.OptionsColumn.AllowEdit = false;
            this.colDetBatchCantidad.Visible = true;
            this.colDetBatchCantidad.VisibleIndex = 1;
            this.colDetBatchCantidad.Width = 204;
            // 
            // colDetBatchIteCodigo
            // 
            this.colDetBatchIteCodigo.Caption = "Item";
            this.colDetBatchIteCodigo.FieldName = "DetBatchIteCodigo";
            this.colDetBatchIteCodigo.Name = "colDetBatchIteCodigo";
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetCantidad.AppearanceHeader.Options.UseFont = true;
            this.colDetCantidad.Caption = "Cantidad";
            this.colDetCantidad.ColumnEdit = this.itxDecimalCuatro;
            this.colDetCantidad.DisplayFormat.FormatString = "{0:0.####}";
            this.colDetCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantidad.FieldName = "DetCantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.Visible = true;
            this.colDetCantidad.VisibleIndex = 4;
            // 
            // itxDecimalCuatro
            // 
            this.itxDecimalCuatro.AutoHeight = false;
            this.itxDecimalCuatro.Mask.EditMask = "n4";
            this.itxDecimalCuatro.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxDecimalCuatro.Name = "itxDecimalCuatro";
            // 
            // colDetPieza
            // 
            this.colDetPieza.Caption = "Pieza";
            this.colDetPieza.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetPieza.FieldName = "DetPieza";
            this.colDetPieza.Name = "colDetPieza";
            this.colDetPieza.Visible = true;
            this.colDetPieza.VisibleIndex = 5;
            // 
            // colIdMotPerdida
            // 
            this.colIdMotPerdida.Caption = "Motivo de pérdida";
            this.colIdMotPerdida.ColumnEdit = this.iluMotPerdida;
            this.colIdMotPerdida.FieldName = "IdMotPerdida";
            this.colIdMotPerdida.Name = "colIdMotPerdida";
            this.colIdMotPerdida.Width = 150;
            // 
            // iluMotPerdida
            // 
            this.iluMotPerdida.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.Appearance.Options.UseFont = true;
            this.iluMotPerdida.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.AppearanceDisabled.Options.UseFont = true;
            this.iluMotPerdida.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.AppearanceDropDown.Options.UseFont = true;
            this.iluMotPerdida.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluMotPerdida.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.AppearanceFocused.Options.UseFont = true;
            this.iluMotPerdida.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMotPerdida.AppearanceReadOnly.Options.UseFont = true;
            this.iluMotPerdida.AutoHeight = false;
            this.iluMotPerdida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluMotPerdida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 120, "Mot. Perdida")});
            this.iluMotPerdida.DisplayMember = "Nombre";
            this.iluMotPerdida.Name = "iluMotPerdida";
            this.iluMotPerdida.NullText = "";
            this.iluMotPerdida.Tag = "";
            this.iluMotPerdida.ValueMember = "Id";
            // 
            // colCosto
            // 
            this.colCosto.Caption = "Costo";
            this.colCosto.ColumnEdit = this.itxNumero;
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.OptionsColumn.AllowEdit = false;
            this.colCosto.OptionsColumn.TabStop = false;
            // 
            // itxNumero
            // 
            this.itxNumero.AutoHeight = false;
            this.itxNumero.Mask.EditMask = "f0";
            this.itxNumero.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxNumero.Name = "itxNumero";
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.ColumnEdit = this.itxNumero;
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.OptionsColumn.TabStop = false;
            // 
            // colIteTieLote
            // 
            this.colIteTieLote.Caption = "Tiene Lote";
            this.colIteTieLote.FieldName = "IteTieLote";
            this.colIteTieLote.Name = "colIteTieLote";
            // 
            // colItePsoStd
            // 
            this.colItePsoStd.Caption = "Pso. Standar";
            this.colItePsoStd.FieldName = "ItePsoStd";
            this.colItePsoStd.Name = "colItePsoStd";
            // 
            // colDetPeso
            // 
            this.colDetPeso.Caption = "Peso";
            this.colDetPeso.ColumnEdit = this.itxDecimalCuatro;
            this.colDetPeso.FieldName = "DetPeso";
            this.colDetPeso.Name = "colDetPeso";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(176, 9);
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
            this.datFecha.Size = new System.Drawing.Size(101, 22);
            this.datFecha.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(83, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 15);
            this.labelControl3.TabIndex = 670;
            this.labelControl3.Text = "Fecha documento:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(825, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.Mask.EditMask = "f0";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Size = new System.Drawing.Size(49, 22);
            this.txtCodigo.TabIndex = 678;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.EditValue = "";
            this.txtCodSerie.EnterMoveNextControl = true;
            this.txtCodSerie.Location = new System.Drawing.Point(873, 12);
            this.txtCodSerie.Name = "txtCodSerie";
            this.txtCodSerie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSerie.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodSerie.Properties.Appearance.Options.UseFont = true;
            this.txtCodSerie.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodSerie.Properties.AutoHeight = false;
            this.txtCodSerie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodSerie.Properties.Mask.EditMask = "f0";
            this.txtCodSerie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodSerie.Size = new System.Drawing.Size(49, 22);
            this.txtCodSerie.TabIndex = 677;
            this.txtCodSerie.TabStop = false;
            this.txtCodSerie.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Enabled = false;
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(1056, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(68, 22);
            this.txtNumero.TabIndex = 676;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Enabled = false;
            this.txtNomSerie.Location = new System.Drawing.Point(987, 9);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Size = new System.Drawing.Size(69, 22);
            this.txtNomSerie.TabIndex = 675;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(955, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 674;
            this.labelControl4.Text = "Serie:";
            // 
            // lueMotivo
            // 
            this.lueMotivo.Location = new System.Drawing.Point(69, 32);
            this.lueMotivo.Name = "lueMotivo";
            this.lueMotivo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMotivo.Properties.Appearance.Options.UseFont = true;
            this.lueMotivo.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueMotivo.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueMotivo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueMotivo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueMotivo.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueMotivo.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueMotivo.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueMotivo.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueMotivo.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueMotivo.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueMotivo.Properties.AutoHeight = false;
            this.lueMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMotivo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ListaCenCosto", "CenCosto", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ListaProyecto", "Proyecto", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ListaBodega", "Bodega", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Requerido", "Chapeta/Lote", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueMotivo.Properties.DisplayMember = "Nombre";
            this.lueMotivo.Properties.NullText = "";
            this.lueMotivo.Properties.ValueMember = "Id";
            this.lueMotivo.Size = new System.Drawing.Size(287, 22);
            this.lueMotivo.TabIndex = 1;
            this.lueMotivo.EditValueChanged += new System.EventHandler(this.lueMotivo_EditValueChanged);
            // 
            // lblMotivo
            // 
            this.lblMotivo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(23, 35);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(40, 15);
            this.lblMotivo.TabIndex = 680;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtTipoMovimiento
            // 
            this.txtTipoMovimiento.EditValue = "";
            this.txtTipoMovimiento.Enabled = false;
            this.txtTipoMovimiento.EnterMoveNextControl = true;
            this.txtTipoMovimiento.Location = new System.Drawing.Point(470, 32);
            this.txtTipoMovimiento.Name = "txtTipoMovimiento";
            this.txtTipoMovimiento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoMovimiento.Properties.Appearance.Options.UseFont = true;
            this.txtTipoMovimiento.Properties.AutoHeight = false;
            this.txtTipoMovimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTipoMovimiento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoMovimiento.Properties.MaxLength = 180;
            this.txtTipoMovimiento.Size = new System.Drawing.Size(85, 23);
            this.txtTipoMovimiento.TabIndex = 4;
            this.txtTipoMovimiento.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(377, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 15);
            this.labelControl1.TabIndex = 684;
            this.labelControl1.Text = "Tipo movimiento:";
            // 
            // lueRazon
            // 
            this.lueRazon.Location = new System.Drawing.Point(69, 55);
            this.lueRazon.Name = "lueRazon";
            this.lueRazon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRazon.Properties.Appearance.Options.UseFont = true;
            this.lueRazon.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRazon.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueRazon.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRazon.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueRazon.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRazon.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRazon.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRazon.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueRazon.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRazon.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueRazon.Properties.AutoHeight = false;
            this.lueRazon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRazon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.lueRazon.Properties.DisplayMember = "Descripcion";
            this.lueRazon.Properties.NullText = "";
            this.lueRazon.Properties.ValueMember = "Codigo";
            this.lueRazon.Size = new System.Drawing.Size(287, 22);
            this.lueRazon.TabIndex = 2;
            this.lueRazon.EditValueChanged += new System.EventHandler(this.lueRazon_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(23, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 15);
            this.labelControl2.TabIndex = 686;
            this.labelControl2.Text = "Razón:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(23, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 15);
            this.labelControl5.TabIndex = 688;
            this.labelControl5.Text = "Bodega:";
            // 
            // lueBodega
            // 
            this.lueBodega.Location = new System.Drawing.Point(69, 78);
            this.lueBodega.Name = "lueBodega";
            this.lueBodega.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueBodega.Properties.Appearance.Options.UseFont = true;
            this.lueBodega.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueBodega.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueBodega.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueBodega.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueBodega.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueBodega.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueBodega.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueBodega.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueBodega.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueBodega.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueBodega.Properties.AutoHeight = false;
            this.lueBodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBodega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueBodega.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsCode", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsName", 100, "Nombre")});
            this.lueBodega.Properties.DisplayMember = "WhsName";
            this.lueBodega.Properties.NullText = "";
            this.lueBodega.Properties.ValueMember = "WhsCode";
            this.lueBodega.Size = new System.Drawing.Size(287, 22);
            this.lueBodega.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(417, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 15);
            this.labelControl6.TabIndex = 692;
            this.labelControl6.Text = "Proyecto:";
            // 
            // lueProyecto
            // 
            this.lueProyecto.Location = new System.Drawing.Point(470, 78);
            this.lueProyecto.Name = "lueProyecto";
            this.lueProyecto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueProyecto.Properties.Appearance.Options.UseFont = true;
            this.lueProyecto.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueProyecto.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueProyecto.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueProyecto.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueProyecto.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueProyecto.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueProyecto.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueProyecto.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueProyecto.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueProyecto.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueProyecto.Properties.AutoHeight = false;
            this.lueProyecto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProyecto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrjCode", 30, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrjName", 100, "Nombre")});
            this.lueProyecto.Properties.DisplayMember = "PrjCode";
            this.lueProyecto.Properties.NullText = "";
            this.lueProyecto.Properties.PopupFormMinSize = new System.Drawing.Size(300, 100);
            this.lueProyecto.Properties.ValueMember = "PrjCode";
            this.lueProyecto.Size = new System.Drawing.Size(84, 22);
            this.lueProyecto.TabIndex = 6;
            this.lueProyecto.EditValueChanged += new System.EventHandler(this.lueProyecto_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(385, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 15);
            this.labelControl7.TabIndex = 690;
            this.labelControl7.Text = "Centro de costo:";
            // 
            // lueCenCosto
            // 
            this.lueCenCosto.Location = new System.Drawing.Point(470, 55);
            this.lueCenCosto.Name = "lueCenCosto";
            this.lueCenCosto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueCenCosto.Properties.Appearance.Options.UseFont = true;
            this.lueCenCosto.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueCenCosto.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueCenCosto.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueCenCosto.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueCenCosto.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueCenCosto.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueCenCosto.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueCenCosto.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueCenCosto.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueCenCosto.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueCenCosto.Properties.AutoHeight = false;
            this.lueCenCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCenCosto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrcCode", 30, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrcName", 100, "Nombre")});
            this.lueCenCosto.Properties.DisplayMember = "PrcCode";
            this.lueCenCosto.Properties.NullText = "";
            this.lueCenCosto.Properties.PopupFormMinSize = new System.Drawing.Size(300, 100);
            this.lueCenCosto.Properties.ValueMember = "PrcCode";
            this.lueCenCosto.Size = new System.Drawing.Size(84, 22);
            this.lueCenCosto.TabIndex = 5;
            this.lueCenCosto.EditValueChanged += new System.EventHandler(this.lueCenCosto_EditValueChanged);
            // 
            // txtCenCosto
            // 
            this.txtCenCosto.EditValue = "";
            this.txtCenCosto.Enabled = false;
            this.txtCenCosto.EnterMoveNextControl = true;
            this.txtCenCosto.Location = new System.Drawing.Point(555, 55);
            this.txtCenCosto.Name = "txtCenCosto";
            this.txtCenCosto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenCosto.Properties.Appearance.Options.UseFont = true;
            this.txtCenCosto.Properties.AutoHeight = false;
            this.txtCenCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCenCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCenCosto.Properties.MaxLength = 180;
            this.txtCenCosto.Size = new System.Drawing.Size(269, 23);
            this.txtCenCosto.TabIndex = 693;
            this.txtCenCosto.TabStop = false;
            // 
            // txtProyecto
            // 
            this.txtProyecto.EditValue = "";
            this.txtProyecto.Enabled = false;
            this.txtProyecto.EnterMoveNextControl = true;
            this.txtProyecto.Location = new System.Drawing.Point(555, 78);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Properties.Appearance.Options.UseFont = true;
            this.txtProyecto.Properties.AutoHeight = false;
            this.txtProyecto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtProyecto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProyecto.Properties.MaxLength = 180;
            this.txtProyecto.Size = new System.Drawing.Size(269, 23);
            this.txtProyecto.TabIndex = 694;
            this.txtProyecto.TabStop = false;
            // 
            // txtSapNumero
            // 
            this.txtSapNumero.EditValue = "";
            this.txtSapNumero.Enabled = false;
            this.txtSapNumero.EnterMoveNextControl = true;
            this.txtSapNumero.Location = new System.Drawing.Point(1056, 32);
            this.txtSapNumero.Name = "txtSapNumero";
            this.txtSapNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSapNumero.Properties.Appearance.Options.UseFont = true;
            this.txtSapNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSapNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSapNumero.Properties.AutoHeight = false;
            this.txtSapNumero.Size = new System.Drawing.Size(68, 22);
            this.txtSapNumero.TabIndex = 695;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(955, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 15);
            this.labelControl8.TabIndex = 696;
            this.labelControl8.Text = "Nro. SAP:";
            // 
            // memObsDocumento
            // 
            this.memObsDocumento.Location = new System.Drawing.Point(158, 544);
            this.memObsDocumento.Name = "memObsDocumento";
            this.memObsDocumento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObsDocumento.Properties.Appearance.Options.UseFont = true;
            this.memObsDocumento.Properties.MaxLength = 254;
            this.memObsDocumento.Size = new System.Drawing.Size(419, 44);
            this.memObsDocumento.TabIndex = 7;
            // 
            // lblObsDocumento
            // 
            this.lblObsDocumento.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsDocumento.Location = new System.Drawing.Point(23, 546);
            this.lblObsDocumento.Name = "lblObsDocumento";
            this.lblObsDocumento.Size = new System.Drawing.Size(129, 15);
            this.lblObsDocumento.TabIndex = 698;
            this.lblObsDocumento.Text = "Observaciones documento:";
            // 
            // memObsDiario
            // 
            this.memObsDiario.Location = new System.Drawing.Point(158, 590);
            this.memObsDiario.Name = "memObsDiario";
            this.memObsDiario.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObsDiario.Properties.Appearance.Options.UseFont = true;
            this.memObsDiario.Properties.MaxLength = 30;
            this.memObsDiario.Size = new System.Drawing.Size(419, 30);
            this.memObsDiario.TabIndex = 8;
            // 
            // lblObsDiario
            // 
            this.lblObsDiario.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsDiario.Location = new System.Drawing.Point(23, 591);
            this.lblObsDiario.Name = "lblObsDiario";
            this.lblObsDiario.Size = new System.Drawing.Size(103, 15);
            this.lblObsDiario.TabIndex = 703;
            this.lblObsDiario.Text = "Observaciones diario:";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Appearance.Options.UseFont = true;
            this.btnExtraer.Image = global::umbAplicacion.Properties.Resources.imgExtraer16;
            this.btnExtraer.Location = new System.Drawing.Point(560, 109);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(152, 26);
            this.btnExtraer.TabIndex = 705;
            this.btnExtraer.Text = "&Extraer información";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // butExaminar
            // 
            this.butExaminar.Location = new System.Drawing.Point(89, 112);
            this.butExaminar.Name = "butExaminar";
            this.butExaminar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExaminar.Properties.Appearance.Options.UseFont = true;
            this.butExaminar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("butExaminar.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.butExaminar.Size = new System.Drawing.Size(465, 22);
            this.butExaminar.TabIndex = 704;
            this.butExaminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.butExaminar_ButtonClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(23, 115);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 15);
            this.labelControl9.TabIndex = 706;
            this.labelControl9.Text = "Ruta Excel:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // xfrmInvManMovimiento
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1146, 670);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.butExaminar);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.memObsDiario);
            this.Controls.Add(this.lblObsDiario);
            this.Controls.Add(this.memObsDocumento);
            this.Controls.Add(this.lblObsDocumento);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtSapNumero);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.txtCenCosto);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lueProyecto);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lueCenCosto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lueBodega);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lueRazon);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTipoMovimiento);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lueMotivo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grcListado);
            this.Name = "xfrmInvManMovimiento";
            this.Text = "Datos del movimiento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmManMovimiento_KeyDown);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txtNomSerie, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodSerie, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lueMotivo, 0);
            this.Controls.SetChildIndex(this.lblMotivo, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtTipoMovimiento, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.lueRazon, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.lueBodega, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.lueCenCosto, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.lueProyecto, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtCenCosto, 0);
            this.Controls.SetChildIndex(this.txtProyecto, 0);
            this.Controls.SetChildIndex(this.txtSapNumero, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.lblObsDocumento, 0);
            this.Controls.SetChildIndex(this.memObsDocumento, 0);
            this.Controls.SetChildIndex(this.lblObsDiario, 0);
            this.Controls.SetChildIndex(this.memObsDiario, 0);
            this.Controls.SetChildIndex(this.labelControl9, 0);
            this.Controls.SetChildIndex(this.butExaminar, 0);
            this.Controls.SetChildIndex(this.btnExtraer, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluTipoDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibeBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluMotPerdida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoMovimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCenCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCenCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProyecto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDiario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluItem;
        private DevExpress.XtraGrid.Views.Grid.GridView igvItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItmItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItmItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItmInvntryUom;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIteUndInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDetIdDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colDetTipDestino;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem smiBorrar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotPerdida;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colItmAvgPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colItmManBtchNum;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluBatch;
        private DevExpress.XtraGrid.Views.Grid.GridView glvBatch;
        private DevExpress.XtraGrid.Columns.GridColumn colDetBatchNro;
        private DevExpress.XtraGrid.Columns.GridColumn colDetBatchCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDetOpcion;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lueMotivo;
        private DevExpress.XtraEditors.LabelControl lblMotivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTipoMovimiento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueRazon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueBodega;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueProyecto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lueCenCosto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSapNumero;
        private DevExpress.XtraEditors.TextEdit txtProyecto;
        private DevExpress.XtraEditors.TextEdit txtCenCosto;
        private DevExpress.XtraEditors.MemoEdit memObsDocumento;
        private DevExpress.XtraEditors.LabelControl lblObsDocumento;
        private DevExpress.XtraEditors.MemoEdit memObsDiario;
        private DevExpress.XtraEditors.LabelControl lblObsDiario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluTipoDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPieza;
        private DevExpress.XtraGrid.Columns.GridColumn colIteTieLote;
        private DevExpress.XtraGrid.Columns.GridColumn colItePsoStd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxDecimalCuatro;
        private DevExpress.XtraGrid.Columns.GridColumn colDetBatchIteCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluMotPerdida;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPeso;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ibeBatch;
        public DevExpress.XtraEditors.SimpleButton btnExtraer;
        private DevExpress.XtraEditors.ButtonEdit butExaminar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
