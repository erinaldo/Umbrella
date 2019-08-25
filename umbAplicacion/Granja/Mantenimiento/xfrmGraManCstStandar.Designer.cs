namespace umbAplicacion.Granja.Mantenimiento
{
    partial class xfrmGraManCstStandar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmGraManCstStandar));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.datFecDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.datFecHasta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIteNombre = new DevExpress.XtraEditors.TextEdit();
            this.bedItem = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluCtaContable = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvCtaContable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCtaCueCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCtaCueFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCtaCueNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxDecimalDos = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxComentario = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colEstCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.memObsDocumento = new DevExpress.XtraEditors.MemoEdit();
            this.lblObsDocumento = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIteNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluCtaContable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvCtaContable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Size = new System.Drawing.Size(662, 46);
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(90, 29);
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
            this.datFecha.Size = new System.Drawing.Size(122, 22);
            this.datFecha.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 15);
            this.labelControl4.TabIndex = 670;
            this.labelControl4.Text = "Fecha:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(90, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Size = new System.Drawing.Size(123, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // datFecDesde
            // 
            this.datFecDesde.EditValue = null;
            this.datFecDesde.Location = new System.Drawing.Point(90, 52);
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
            this.datFecDesde.Size = new System.Drawing.Size(122, 22);
            this.datFecDesde.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(290, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 15);
            this.labelControl1.TabIndex = 674;
            this.labelControl1.Text = "Fecha hasta:";
            // 
            // datFecHasta
            // 
            this.datFecHasta.EditValue = null;
            this.datFecHasta.Location = new System.Drawing.Point(355, 52);
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
            this.datFecHasta.Size = new System.Drawing.Size(122, 22);
            this.datFecHasta.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 15);
            this.labelControl2.TabIndex = 676;
            this.labelControl2.Text = "Fecha desde:";
            // 
            // txtIteNombre
            // 
            this.txtIteNombre.EditValue = "";
            this.txtIteNombre.EnterMoveNextControl = true;
            this.txtIteNombre.Location = new System.Drawing.Point(192, 75);
            this.txtIteNombre.Name = "txtIteNombre";
            this.txtIteNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteNombre.Properties.Appearance.Options.UseFont = true;
            this.txtIteNombre.Properties.AutoHeight = false;
            this.txtIteNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtIteNombre.Properties.ReadOnly = true;
            this.txtIteNombre.Size = new System.Drawing.Size(286, 23);
            this.txtIteNombre.TabIndex = 717;
            this.txtIteNombre.TabStop = false;
            // 
            // bedItem
            // 
            this.bedItem.EditValue = "";
            this.bedItem.Location = new System.Drawing.Point(90, 75);
            this.bedItem.Name = "bedItem";
            this.bedItem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedItem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedItem.Properties.Appearance.Options.UseBackColor = true;
            this.bedItem.Properties.Appearance.Options.UseFont = true;
            this.bedItem.Properties.AutoHeight = false;
            this.bedItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bedItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bedItem.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bedItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedItem.Size = new System.Drawing.Size(102, 23);
            this.bedItem.TabIndex = 4;
            this.bedItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedItem_ButtonClick);
            this.bedItem.EditValueChanged += new System.EventHandler(this.bedItem_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 15);
            this.labelControl3.TabIndex = 718;
            this.labelControl3.Text = "Item:";
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(12, 104);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluCtaContable,
            this.itxDecimalDos,
            this.itxComentario});
            this.grcListado.Size = new System.Drawing.Size(638, 241);
            this.grcListado.TabIndex = 5;
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
            this.colCueCodigo,
            this.colCueFormato,
            this.colCueNombre,
            this.colDetValor,
            this.colDetComentario,
            this.colEstCodigo});
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
            // colCueCodigo
            // 
            this.colCueCodigo.Caption = "Codigo";
            this.colCueCodigo.FieldName = "CueCodigo";
            this.colCueCodigo.Name = "colCueCodigo";
            // 
            // colCueFormato
            // 
            this.colCueFormato.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCueFormato.AppearanceCell.Options.UseFont = true;
            this.colCueFormato.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCueFormato.AppearanceHeader.Options.UseFont = true;
            this.colCueFormato.Caption = "Cta. Contable";
            this.colCueFormato.ColumnEdit = this.gluCtaContable;
            this.colCueFormato.FieldName = "CueFormato";
            this.colCueFormato.Name = "colCueFormato";
            this.colCueFormato.Visible = true;
            this.colCueFormato.VisibleIndex = 1;
            this.colCueFormato.Width = 90;
            // 
            // gluCtaContable
            // 
            this.gluCtaContable.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluCtaContable.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gluCtaContable.Appearance.Image")));
            this.gluCtaContable.Appearance.Options.UseFont = true;
            this.gluCtaContable.Appearance.Options.UseImage = true;
            this.gluCtaContable.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluCtaContable.AppearanceDisabled.Image = ((System.Drawing.Image)(resources.GetObject("gluCtaContable.AppearanceDisabled.Image")));
            this.gluCtaContable.AppearanceDisabled.Options.UseFont = true;
            this.gluCtaContable.AppearanceDisabled.Options.UseImage = true;
            this.gluCtaContable.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluCtaContable.AppearanceDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gluCtaContable.AppearanceDropDown.Image")));
            this.gluCtaContable.AppearanceDropDown.Options.UseFont = true;
            this.gluCtaContable.AppearanceDropDown.Options.UseImage = true;
            this.gluCtaContable.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluCtaContable.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("gluCtaContable.AppearanceFocused.Image")));
            this.gluCtaContable.AppearanceFocused.Options.UseFont = true;
            this.gluCtaContable.AppearanceFocused.Options.UseImage = true;
            this.gluCtaContable.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluCtaContable.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("gluCtaContable.AppearanceReadOnly.Image")));
            this.gluCtaContable.AppearanceReadOnly.Options.UseFont = true;
            this.gluCtaContable.AppearanceReadOnly.Options.UseImage = true;
            this.gluCtaContable.AutoHeight = false;
            this.gluCtaContable.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluCtaContable.DisplayMember = "CueFormato";
            this.gluCtaContable.ImmediatePopup = true;
            this.gluCtaContable.Name = "gluCtaContable";
            this.gluCtaContable.NullText = "";
            this.gluCtaContable.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluCtaContable.PopupFormMinSize = new System.Drawing.Size(300, 200);
            this.gluCtaContable.PopupFormSize = new System.Drawing.Size(300, 200);
            this.gluCtaContable.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluCtaContable.ValueMember = "CueFormato";
            this.gluCtaContable.View = this.igvCtaContable;
            this.gluCtaContable.Popup += new System.EventHandler(this.gluCtaContable_Popup);
            this.gluCtaContable.Leave += new System.EventHandler(this.gluCtaContable_Leave);
            // 
            // igvCtaContable
            // 
            this.igvCtaContable.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.igvCtaContable.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.igvCtaContable.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.igvCtaContable.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.DetailTip.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.DetailTip.Options.UseFont = true;
            this.igvCtaContable.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.Empty.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.Empty.Options.UseFont = true;
            this.igvCtaContable.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.EvenRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.EvenRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FilterCloseButton.Options.UseFont = true;
            this.igvCtaContable.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FilterPanel.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FilterPanel.Options.UseFont = true;
            this.igvCtaContable.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FixedLine.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FixedLine.Options.UseFont = true;
            this.igvCtaContable.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FocusedCell.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FocusedCell.Options.UseFont = true;
            this.igvCtaContable.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FocusedRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FocusedRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.FooterPanel.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.igvCtaContable.Appearance.FooterPanel.Options.UseFont = true;
            this.igvCtaContable.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.GroupButton.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.GroupButton.Options.UseFont = true;
            this.igvCtaContable.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.GroupFooter.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.GroupFooter.Options.UseFont = true;
            this.igvCtaContable.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.GroupPanel.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.GroupPanel.Options.UseFont = true;
            this.igvCtaContable.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.GroupRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.GroupRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.HeaderPanel.Options.UseFont = true;
            this.igvCtaContable.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.HideSelectionRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.HorzLine.Options.UseFont = true;
            this.igvCtaContable.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.OddRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.OddRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.Preview.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.Preview.Options.UseFont = true;
            this.igvCtaContable.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.Row.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.Row.Options.UseFont = true;
            this.igvCtaContable.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.RowSeparator.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.RowSeparator.Options.UseFont = true;
            this.igvCtaContable.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.SelectedRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.SelectedRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.TopNewRow.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.TopNewRow.Options.UseFont = true;
            this.igvCtaContable.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.VertLine.Options.UseFont = true;
            this.igvCtaContable.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.igvCtaContable.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvCtaContable.Appearance.ViewCaption.Options.UseBackColor = true;
            this.igvCtaContable.Appearance.ViewCaption.Options.UseFont = true;
            this.igvCtaContable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCtaCueCodigo,
            this.colCtaCueFormato,
            this.colCtaCueNombre});
            this.igvCtaContable.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.igvCtaContable.Name = "igvCtaContable";
            this.igvCtaContable.OptionsCustomization.AllowColumnMoving = false;
            this.igvCtaContable.OptionsCustomization.AllowColumnResizing = false;
            this.igvCtaContable.OptionsCustomization.AllowGroup = false;
            this.igvCtaContable.OptionsCustomization.AllowSort = false;
            this.igvCtaContable.OptionsFind.AllowFindPanel = false;
            this.igvCtaContable.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.igvCtaContable.OptionsView.ColumnAutoWidth = false;
            this.igvCtaContable.OptionsView.ShowAutoFilterRow = true;
            this.igvCtaContable.OptionsView.ShowDetailButtons = false;
            this.igvCtaContable.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.igvCtaContable.OptionsView.ShowGroupPanel = false;
            // 
            // colCtaCueCodigo
            // 
            this.colCtaCueCodigo.Caption = "Codigo";
            this.colCtaCueCodigo.FieldName = "CueCodigo";
            this.colCtaCueCodigo.Name = "colCtaCueCodigo";
            this.colCtaCueCodigo.OptionsColumn.AllowEdit = false;
            this.colCtaCueCodigo.Width = 80;
            // 
            // colCtaCueFormato
            // 
            this.colCtaCueFormato.Caption = "Cta. Contable";
            this.colCtaCueFormato.FieldName = "CueFormato";
            this.colCtaCueFormato.Name = "colCtaCueFormato";
            this.colCtaCueFormato.Visible = true;
            this.colCtaCueFormato.VisibleIndex = 0;
            this.colCtaCueFormato.Width = 50;
            // 
            // colCtaCueNombre
            // 
            this.colCtaCueNombre.Caption = "Descripcion";
            this.colCtaCueNombre.FieldName = "CueNombre";
            this.colCtaCueNombre.Name = "colCtaCueNombre";
            this.colCtaCueNombre.OptionsColumn.AllowEdit = false;
            this.colCtaCueNombre.Visible = true;
            this.colCtaCueNombre.VisibleIndex = 1;
            this.colCtaCueNombre.Width = 250;
            // 
            // colCueNombre
            // 
            this.colCueNombre.Caption = "Descripcion";
            this.colCueNombre.FieldName = "CueNombre";
            this.colCueNombre.Name = "colCueNombre";
            this.colCueNombre.OptionsColumn.AllowEdit = false;
            this.colCueNombre.OptionsColumn.TabStop = false;
            this.colCueNombre.Visible = true;
            this.colCueNombre.VisibleIndex = 2;
            this.colCueNombre.Width = 250;
            // 
            // colDetValor
            // 
            this.colDetValor.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetValor.AppearanceHeader.Options.UseFont = true;
            this.colDetValor.Caption = "Cantidad";
            this.colDetValor.ColumnEdit = this.itxDecimalDos;
            this.colDetValor.DisplayFormat.FormatString = "{0:0.##}";
            this.colDetValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetValor.FieldName = "DetValor";
            this.colDetValor.Name = "colDetValor";
            this.colDetValor.Visible = true;
            this.colDetValor.VisibleIndex = 3;
            // 
            // itxDecimalDos
            // 
            this.itxDecimalDos.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalDos.Appearance.Options.UseFont = true;
            this.itxDecimalDos.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalDos.AppearanceDisabled.Options.UseFont = true;
            this.itxDecimalDos.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalDos.AppearanceFocused.Options.UseFont = true;
            this.itxDecimalDos.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalDos.AppearanceReadOnly.Options.UseFont = true;
            this.itxDecimalDos.AutoHeight = false;
            this.itxDecimalDos.Mask.EditMask = "n2";
            this.itxDecimalDos.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxDecimalDos.Name = "itxDecimalDos";
            // 
            // colDetComentario
            // 
            this.colDetComentario.Caption = "Comentario";
            this.colDetComentario.ColumnEdit = this.itxComentario;
            this.colDetComentario.FieldName = "DetComentario";
            this.colDetComentario.Name = "colDetComentario";
            this.colDetComentario.Visible = true;
            this.colDetComentario.VisibleIndex = 4;
            this.colDetComentario.Width = 150;
            // 
            // itxComentario
            // 
            this.itxComentario.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxComentario.Appearance.Options.UseFont = true;
            this.itxComentario.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxComentario.AppearanceDisabled.Options.UseFont = true;
            this.itxComentario.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxComentario.AppearanceFocused.Options.UseFont = true;
            this.itxComentario.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxComentario.AppearanceReadOnly.Options.UseFont = true;
            this.itxComentario.AutoHeight = false;
            this.itxComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.itxComentario.Name = "itxComentario";
            // 
            // colEstCodigo
            // 
            this.colEstCodigo.Caption = "Estado";
            this.colEstCodigo.FieldName = "EstCodigo";
            this.colEstCodigo.Name = "colEstCodigo";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(12, 10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 15);
            this.labelControl5.TabIndex = 720;
            this.labelControl5.Text = "Codigo:";
            // 
            // memObsDocumento
            // 
            this.memObsDocumento.Location = new System.Drawing.Point(90, 351);
            this.memObsDocumento.Name = "memObsDocumento";
            this.memObsDocumento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObsDocumento.Properties.Appearance.Options.UseFont = true;
            this.memObsDocumento.Properties.MaxLength = 254;
            this.memObsDocumento.Size = new System.Drawing.Size(560, 44);
            this.memObsDocumento.TabIndex = 6;
            // 
            // lblObsDocumento
            // 
            this.lblObsDocumento.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsDocumento.Location = new System.Drawing.Point(11, 353);
            this.lblObsDocumento.Name = "lblObsDocumento";
            this.lblObsDocumento.Size = new System.Drawing.Size(73, 15);
            this.lblObsDocumento.TabIndex = 727;
            this.lblObsDocumento.Text = "Observaciones:";
            // 
            // xfrmGraManCstStandar
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.memObsDocumento);
            this.Controls.Add(this.lblObsDocumento);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.txtIteNombre);
            this.Controls.Add(this.bedItem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.datFecHasta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.datFecDesde);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl4);
            this.Name = "xfrmGraManCstStandar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmGraManCstStandar_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.datFecDesde, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.datFecHasta, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.bedItem, 0);
            this.Controls.SetChildIndex(this.txtIteNombre, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.lblObsDocumento, 0);
            this.Controls.SetChildIndex(this.memObsDocumento, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIteNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluCtaContable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvCtaContable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.DateEdit datFecDesde;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit datFecHasta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIteNombre;
        private DevExpress.XtraEditors.ButtonEdit bedItem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCueFormato;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluCtaContable;
        private DevExpress.XtraGrid.Views.Grid.GridView igvCtaContable;
        private DevExpress.XtraGrid.Columns.GridColumn colCtaCueCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCtaCueNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCtaCueFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colCueNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDetValor;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxDecimalDos;
        private DevExpress.XtraGrid.Columns.GridColumn colCueCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetComentario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxComentario;
        private DevExpress.XtraEditors.MemoEdit memObsDocumento;
        private DevExpress.XtraEditors.LabelControl lblObsDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colEstCodigo;
    }
}
