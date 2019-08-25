namespace Umbrella
{
    partial class frmAccDocumento
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccDocumento));
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocCodSAPSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvItemIngrediente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxAbreviatura = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDocCodSap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.colDocCodSAPEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocCodSAPDiario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxAbreviatura)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcListado.Location = new System.Drawing.Point(0, 0);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluItem,
            this.itxAbreviatura});
            this.grcListado.Size = new System.Drawing.Size(378, 154);
            this.grcListado.TabIndex = 511;
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
            this.grvListado.Appearance.GroupRow.BackColor = System.Drawing.Color.AliceBlue;
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
            this.colDocCodigo,
            this.colDocNombre,
            this.colDocDescripcion,
            this.colDocCodSAPSalida,
            this.colDocCodSAPEntrada,
            this.colDocCodSAPDiario});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Navy;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[DerAbreviatura] = \'T\'  Or [DerAbreviatura] = \'TP\'";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[DerAbreviatura] = \'V\'  Or [DerAbreviatura] = \'VP\'";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[DerAbreviatura] = \'C\'  Or [DerAbreviatura] = \'CP\'";
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "0";
            this.grvListado.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
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
            this.grvListado.OptionsView.ColumnAutoWidth = false;
            this.grvListado.OptionsView.ShowDetailButtons = false;
            this.grvListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvListado.OptionsView.ShowGroupPanel = false;
            this.grvListado.ViewCaption = "Productos";
            // 
            // colDocCodigo
            // 
            this.colDocCodigo.Caption = "Codigo";
            this.colDocCodigo.FieldName = "DocCodigo";
            this.colDocCodigo.Name = "colDocCodigo";
            this.colDocCodigo.OptionsColumn.AllowEdit = false;
            this.colDocCodigo.OptionsColumn.TabStop = false;
            this.colDocCodigo.Width = 80;
            // 
            // colDocNombre
            // 
            this.colDocNombre.Caption = "Nombre";
            this.colDocNombre.FieldName = "DocNombre";
            this.colDocNombre.Name = "colDocNombre";
            this.colDocNombre.OptionsColumn.AllowEdit = false;
            this.colDocNombre.Visible = true;
            this.colDocNombre.VisibleIndex = 0;
            this.colDocNombre.Width = 80;
            // 
            // colDocDescripcion
            // 
            this.colDocDescripcion.Caption = "Descripcion";
            this.colDocDescripcion.FieldName = "DocDescripcion";
            this.colDocDescripcion.Name = "colDocDescripcion";
            this.colDocDescripcion.OptionsColumn.AllowEdit = false;
            this.colDocDescripcion.Visible = true;
            this.colDocDescripcion.VisibleIndex = 1;
            this.colDocDescripcion.Width = 200;
            // 
            // colDocCodSAPSalida
            // 
            this.colDocCodSAPSalida.Caption = "Cod. SAP Salida";
            this.colDocCodSAPSalida.FieldName = "DocCodSAPSalida";
            this.colDocCodSAPSalida.Name = "colDocCodSAPSalida";
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
            this.gluItem.Name = "gluItem";
            this.gluItem.NullText = "";
            this.gluItem.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluItem.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluItem.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluItem.ValueMember = "ItemCode";
            this.gluItem.View = this.igvItemIngrediente;
            // 
            // igvItemIngrediente
            // 
            this.igvItemIngrediente.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.DetailTip.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.DetailTip.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.Empty.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.Empty.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.EvenRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.EvenRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FilterCloseButton.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FilterPanel.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FilterPanel.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FixedLine.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FixedLine.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FocusedCell.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FocusedCell.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FocusedRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FocusedRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.FooterPanel.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.igvItemIngrediente.Appearance.FooterPanel.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.GroupButton.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.GroupButton.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.GroupFooter.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.GroupFooter.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.GroupPanel.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.GroupPanel.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.GroupRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.GroupRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.HeaderPanel.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.HideSelectionRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.HorzLine.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.OddRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.OddRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.Preview.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.Preview.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.Row.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.Row.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.RowSeparator.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.RowSeparator.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.SelectedRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.SelectedRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.TopNewRow.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.TopNewRow.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.VertLine.Options.UseFont = true;
            this.igvItemIngrediente.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.igvItemIngrediente.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItemIngrediente.Appearance.ViewCaption.Options.UseBackColor = true;
            this.igvItemIngrediente.Appearance.ViewCaption.Options.UseFont = true;
            this.igvItemIngrediente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIgvItemCode,
            this.colIgvItemName,
            this.colIgvInvntryUom});
            this.igvItemIngrediente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.igvItemIngrediente.Name = "igvItemIngrediente";
            this.igvItemIngrediente.OptionsCustomization.AllowColumnMoving = false;
            this.igvItemIngrediente.OptionsCustomization.AllowColumnResizing = false;
            this.igvItemIngrediente.OptionsCustomization.AllowGroup = false;
            this.igvItemIngrediente.OptionsCustomization.AllowSort = false;
            this.igvItemIngrediente.OptionsFind.AllowFindPanel = false;
            this.igvItemIngrediente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.igvItemIngrediente.OptionsView.ColumnAutoWidth = false;
            this.igvItemIngrediente.OptionsView.ShowAutoFilterRow = true;
            this.igvItemIngrediente.OptionsView.ShowDetailButtons = false;
            this.igvItemIngrediente.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.igvItemIngrediente.OptionsView.ShowGroupPanel = false;
            // 
            // colIgvItemCode
            // 
            this.colIgvItemCode.Caption = "Item";
            this.colIgvItemCode.FieldName = "ItemCode";
            this.colIgvItemCode.Name = "colIgvItemCode";
            this.colIgvItemCode.OptionsColumn.AllowEdit = false;
            this.colIgvItemCode.Visible = true;
            this.colIgvItemCode.VisibleIndex = 0;
            this.colIgvItemCode.Width = 80;
            // 
            // colIgvItemName
            // 
            this.colIgvItemName.Caption = "Descripcion";
            this.colIgvItemName.FieldName = "ItemName";
            this.colIgvItemName.Name = "colIgvItemName";
            this.colIgvItemName.OptionsColumn.AllowEdit = false;
            this.colIgvItemName.Visible = true;
            this.colIgvItemName.VisibleIndex = 1;
            this.colIgvItemName.Width = 300;
            // 
            // colIgvInvntryUom
            // 
            this.colIgvInvntryUom.Caption = "Unidad";
            this.colIgvInvntryUom.FieldName = "InvntryUom";
            this.colIgvInvntryUom.Name = "colIgvInvntryUom";
            this.colIgvInvntryUom.OptionsColumn.AllowEdit = false;
            this.colIgvInvntryUom.Visible = true;
            this.colIgvInvntryUom.VisibleIndex = 2;
            this.colIgvInvntryUom.Width = 80;
            // 
            // itxAbreviatura
            // 
            this.itxAbreviatura.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxAbreviatura.Appearance.Options.UseFont = true;
            this.itxAbreviatura.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxAbreviatura.AppearanceDisabled.Options.UseFont = true;
            this.itxAbreviatura.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxAbreviatura.AppearanceFocused.Options.UseFont = true;
            this.itxAbreviatura.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxAbreviatura.AppearanceReadOnly.Options.UseFont = true;
            this.itxAbreviatura.AutoHeight = false;
            this.itxAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.itxAbreviatura.MaxLength = 2;
            this.itxAbreviatura.Name = "itxAbreviatura";
            // 
            // colDocCodSap
            // 
            this.colDocCodSap.Caption = "Cod. SAP";
            this.colDocCodSap.FieldName = "DocCodSap";
            this.colDocCodSap.Name = "colDocCodSap";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 40);
            this.panel1.TabIndex = 510;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(107, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(7, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // colDocCodSAPEntrada
            // 
            this.colDocCodSAPEntrada.Caption = "Cod. SAP Entrada";
            this.colDocCodSAPEntrada.FieldName = "DocCodSAPEntrada";
            this.colDocCodSAPEntrada.Name = "colDocCodSAPEntrada";
            // 
            // colDocCodSAPDiario
            // 
            this.colDocCodSAPDiario.Caption = "Cod. SAP Diario";
            this.colDocCodSAPDiario.FieldName = "DocCodSAPDiario";
            this.colDocCodSAPDiario.Name = "colDocCodSAPDiario";
            // 
            // frmAccDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 194);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccDocumento";
            this.Text = "Documentos";
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxAbreviatura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDescripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluItem;
        private DevExpress.XtraGrid.Views.Grid.GridView igvItemIngrediente;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvInvntryUom;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxAbreviatura;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCodSap;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCodSAPSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCodSAPEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colDocCodSAPDiario;
    }
}