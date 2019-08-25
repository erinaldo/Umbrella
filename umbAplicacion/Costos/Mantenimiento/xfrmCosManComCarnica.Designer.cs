namespace umbAplicacion.Costos.Mantenimiento
{
    partial class xfrmCosManComCarnica
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCosManComCarnica));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.datFecDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.datFecHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomItemDesde = new DevExpress.XtraEditors.TextEdit();
            this.bedItemDesde = new DevExpress.XtraEditors.ButtonEdit();
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.txtNomItemHasta = new DevExpress.XtraEditors.TextEdit();
            this.bedItemHasta = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkBodega = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxCosto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnExtraer = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomItemDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItemDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomItemHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItemHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Appearance.Options.UseFont = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Size = new System.Drawing.Size(1114, 46);
            // 
            // datFecDesde
            // 
            this.datFecDesde.EditValue = null;
            this.datFecDesde.Location = new System.Drawing.Point(82, 12);
            this.datFecDesde.Name = "datFecDesde";
            this.datFecDesde.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecDesde.Properties.Appearance.Options.UseFont = true;
            this.datFecDesde.Properties.AutoHeight = false;
            this.datFecDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFecDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFecDesde.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFecDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFecDesde.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFecDesde.Size = new System.Drawing.Size(131, 22);
            this.datFecDesde.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(15, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 15);
            this.labelControl3.TabIndex = 629;
            this.labelControl3.Text = "Fecha desde:";
            // 
            // datFecHasta
            // 
            this.datFecHasta.EditValue = null;
            this.datFecHasta.Location = new System.Drawing.Point(82, 35);
            this.datFecHasta.Name = "datFecHasta";
            this.datFecHasta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecHasta.Properties.Appearance.Options.UseFont = true;
            this.datFecHasta.Properties.AutoHeight = false;
            this.datFecHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFecHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFecHasta.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFecHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFecHasta.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFecHasta.Size = new System.Drawing.Size(131, 22);
            this.datFecHasta.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(15, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 15);
            this.labelControl1.TabIndex = 631;
            this.labelControl1.Text = "Fecha hasta:";
            // 
            // txtNomItemDesde
            // 
            this.txtNomItemDesde.EditValue = "";
            this.txtNomItemDesde.EnterMoveNextControl = true;
            this.txtNomItemDesde.Location = new System.Drawing.Point(212, 81);
            this.txtNomItemDesde.Name = "txtNomItemDesde";
            this.txtNomItemDesde.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomItemDesde.Properties.Appearance.Options.UseFont = true;
            this.txtNomItemDesde.Properties.AutoHeight = false;
            this.txtNomItemDesde.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNomItemDesde.Properties.ReadOnly = true;
            this.txtNomItemDesde.Size = new System.Drawing.Size(326, 23);
            this.txtNomItemDesde.TabIndex = 644;
            this.txtNomItemDesde.TabStop = false;
            // 
            // bedItemDesde
            // 
            this.bedItemDesde.EditValue = "";
            this.bedItemDesde.Location = new System.Drawing.Point(82, 81);
            this.bedItemDesde.Name = "bedItemDesde";
            this.bedItemDesde.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedItemDesde.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedItemDesde.Properties.Appearance.Options.UseBackColor = true;
            this.bedItemDesde.Properties.Appearance.Options.UseFont = true;
            this.bedItemDesde.Properties.AutoHeight = false;
            this.bedItemDesde.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bedItemDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bedItemDesde.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bedItemDesde.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedItemDesde.Size = new System.Drawing.Size(132, 23);
            this.bedItemDesde.TabIndex = 3;
            this.bedItemDesde.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedItemDesde_ButtonClick);
            this.bedItemDesde.EditValueChanged += new System.EventHandler(this.bedItemDesde_EditValueChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(15, 84);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(55, 15);
            this.lblProveedor.TabIndex = 645;
            this.lblProveedor.Text = "Item desde:";
            // 
            // txtNomItemHasta
            // 
            this.txtNomItemHasta.EditValue = "";
            this.txtNomItemHasta.EnterMoveNextControl = true;
            this.txtNomItemHasta.Location = new System.Drawing.Point(212, 104);
            this.txtNomItemHasta.Name = "txtNomItemHasta";
            this.txtNomItemHasta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomItemHasta.Properties.Appearance.Options.UseFont = true;
            this.txtNomItemHasta.Properties.AutoHeight = false;
            this.txtNomItemHasta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNomItemHasta.Properties.ReadOnly = true;
            this.txtNomItemHasta.Size = new System.Drawing.Size(326, 23);
            this.txtNomItemHasta.TabIndex = 647;
            this.txtNomItemHasta.TabStop = false;
            // 
            // bedItemHasta
            // 
            this.bedItemHasta.EditValue = "";
            this.bedItemHasta.Location = new System.Drawing.Point(82, 104);
            this.bedItemHasta.Name = "bedItemHasta";
            this.bedItemHasta.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedItemHasta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedItemHasta.Properties.Appearance.Options.UseBackColor = true;
            this.bedItemHasta.Properties.Appearance.Options.UseFont = true;
            this.bedItemHasta.Properties.AutoHeight = false;
            this.bedItemHasta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bedItemHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bedItemHasta.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.bedItemHasta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedItemHasta.Size = new System.Drawing.Size(132, 23);
            this.bedItemHasta.TabIndex = 4;
            this.bedItemHasta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedItemHasta_ButtonClick);
            this.bedItemHasta.EditValueChanged += new System.EventHandler(this.bedItemHasta_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(15, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 15);
            this.labelControl2.TabIndex = 648;
            this.labelControl2.Text = "Item hasta:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(611, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 15);
            this.labelControl4.TabIndex = 650;
            this.labelControl4.Text = "Bodegas:";
            // 
            // chkBodega
            // 
            this.chkBodega.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBodega.Appearance.Options.UseFont = true;
            this.chkBodega.DisplayMember = "Descripcion";
            this.chkBodega.Location = new System.Drawing.Point(611, 36);
            this.chkBodega.Name = "chkBodega";
            this.chkBodega.Size = new System.Drawing.Size(275, 58);
            this.chkBodega.TabIndex = 5;
            this.chkBodega.ValueMember = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(981, 12);
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
            this.txtCodigo.Size = new System.Drawing.Size(111, 22);
            this.txtCodigo.TabIndex = 652;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(934, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 15);
            this.lblCodigo.TabIndex = 653;
            this.lblCodigo.Text = "Codigo:";
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(15, 133);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itxCosto});
            this.grcListado.Size = new System.Drawing.Size(1077, 417);
            this.grcListado.TabIndex = 654;
            this.grcListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListado});
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
            this.colDetValor,
            this.colDetCantidad,
            this.colDetCosto});
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
            this.grvListado.OptionsView.ShowGroupPanel = false;
            this.grvListado.ViewCaption = "Productos";
            // 
            // colDetSecuencia
            // 
            this.colDetSecuencia.Caption = "Nro";
            this.colDetSecuencia.FieldName = "DetSecuencia";
            this.colDetSecuencia.Name = "colDetSecuencia";
            this.colDetSecuencia.OptionsColumn.AllowEdit = false;
            this.colDetSecuencia.OptionsColumn.TabStop = false;
            this.colDetSecuencia.Visible = true;
            this.colDetSecuencia.VisibleIndex = 0;
            this.colDetSecuencia.Width = 30;
            // 
            // colIteCodigo
            // 
            this.colIteCodigo.Caption = "Item";
            this.colIteCodigo.FieldName = "IteCodigo";
            this.colIteCodigo.Name = "colIteCodigo";
            this.colIteCodigo.OptionsColumn.AllowEdit = false;
            this.colIteCodigo.Visible = true;
            this.colIteCodigo.VisibleIndex = 1;
            this.colIteCodigo.Width = 90;
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
            this.colIteNombre.Width = 340;
            // 
            // colDetValor
            // 
            this.colDetValor.Caption = "Valor";
            this.colDetValor.DisplayFormat.FormatString = "{0:0.00}";
            this.colDetValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetValor.FieldName = "DetValor";
            this.colDetValor.Name = "colDetValor";
            this.colDetValor.OptionsColumn.AllowEdit = false;
            this.colDetValor.Visible = true;
            this.colDetValor.VisibleIndex = 4;
            this.colDetValor.Width = 100;
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetCantidad.AppearanceHeader.Options.UseFont = true;
            this.colDetCantidad.Caption = "Cantidad";
            this.colDetCantidad.DisplayFormat.FormatString = "{0:0.0000}";
            this.colDetCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantidad.FieldName = "DetCantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.OptionsColumn.AllowEdit = false;
            this.colDetCantidad.Visible = true;
            this.colDetCantidad.VisibleIndex = 3;
            this.colDetCantidad.Width = 100;
            // 
            // colDetCosto
            // 
            this.colDetCosto.Caption = "Costo";
            this.colDetCosto.ColumnEdit = this.itxCosto;
            this.colDetCosto.DisplayFormat.FormatString = "{0:0.0000}";
            this.colDetCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCosto.FieldName = "DetCosto";
            this.colDetCosto.Name = "colDetCosto";
            this.colDetCosto.Visible = true;
            this.colDetCosto.VisibleIndex = 5;
            this.colDetCosto.Width = 100;
            // 
            // itxCosto
            // 
            this.itxCosto.AutoHeight = false;
            this.itxCosto.Mask.EditMask = "n4";
            this.itxCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxCosto.Name = "itxCosto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.EnterMoveNextControl = true;
            this.txtDescripcion.Location = new System.Drawing.Point(82, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.AutoHeight = false;
            this.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(456, 23);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(61, 15);
            this.lblDescripcion.TabIndex = 656;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Appearance.Options.UseFont = true;
            this.btnExtraer.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraer.Image")));
            this.btnExtraer.Location = new System.Drawing.Point(751, 95);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(135, 32);
            this.btnExtraer.TabIndex = 6;
            this.btnExtraer.Text = "&Extraer informacion";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // xfrmCosManComCarnica
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1114, 609);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.chkBodega);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNomItemHasta);
            this.Controls.Add(this.bedItemHasta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNomItemDesde);
            this.Controls.Add(this.bedItemDesde);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.datFecHasta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.datFecDesde);
            this.Controls.Add(this.labelControl3);
            this.Name = "xfrmCosManComCarnica";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecDesde, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.datFecHasta, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.bedItemDesde, 0);
            this.Controls.SetChildIndex(this.txtNomItemDesde, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.bedItemHasta, 0);
            this.Controls.SetChildIndex(this.txtNomItemHasta, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.chkBodega, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.btnExtraer, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomItemDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItemDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomItemHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItemHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit datFecDesde;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit datFecHasta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomItemDesde;
        private DevExpress.XtraEditors.ButtonEdit bedItemDesde;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private DevExpress.XtraEditors.TextEdit txtNomItemHasta;
        private DevExpress.XtraEditors.ButtonEdit bedItemHasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedListBoxControl chkBodega;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDetValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCosto;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        public DevExpress.XtraEditors.SimpleButton btnExtraer;
    }
}
