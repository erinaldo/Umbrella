namespace umbAplicacion
{
    partial class frmAccFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccFormulario));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition8 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ickAcceso = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treListado = new DevExpress.XtraTreeList.TreeList();
            this.treMenNombre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treFrmCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treDocCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treOpeCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treCamCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cmsMenuAccion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ickAcceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).BeginInit();
            this.cmsMenuAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 571);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 40);
            this.panel1.TabIndex = 511;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Appearance.Options.UseFont = true;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(12, 6);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 28);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(112, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.lblNombre);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtCodigo);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl12);
            this.splitContainerControl1.Panel1.Controls.Add(this.grcListado);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.Controls.Add(this.treListado);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1106, 571);
            this.splitContainerControl1.SplitterPosition = 400;
            this.splitContainerControl1.TabIndex = 512;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 15);
            this.lblNombre.TabIndex = 572;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(60, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.MaxLength = 180;
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(327, 22);
            this.txtNombre.TabIndex = 570;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(60, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(109, 22);
            this.txtCodigo.TabIndex = 569;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Location = new System.Drawing.Point(12, 21);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 15);
            this.labelControl12.TabIndex = 571;
            this.labelControl12.Text = "Codigo:";
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(12, 76);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ickAcceso});
            this.grcListado.Size = new System.Drawing.Size(375, 489);
            this.grcListado.TabIndex = 512;
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
            this.colMenCodigo,
            this.colMenNombre});
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            styleFormatCondition5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Navy;
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.Appearance.Options.UseFont = true;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.ApplyToRow = true;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition5.Expression = "[DerAbreviatura] = \'T\'  Or [DerAbreviatura] = \'TP\'";
            styleFormatCondition6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            styleFormatCondition6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Maroon;
            styleFormatCondition6.Appearance.Options.UseBackColor = true;
            styleFormatCondition6.Appearance.Options.UseFont = true;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition6.Expression = "[DerAbreviatura] = \'V\'  Or [DerAbreviatura] = \'VP\'";
            styleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            styleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition7.Appearance.Options.UseBackColor = true;
            styleFormatCondition7.Appearance.Options.UseFont = true;
            styleFormatCondition7.Appearance.Options.UseForeColor = true;
            styleFormatCondition7.ApplyToRow = true;
            styleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition7.Expression = "[DerAbreviatura] = \'C\'  Or [DerAbreviatura] = \'CP\'";
            styleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition8.Appearance.Options.UseForeColor = true;
            styleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition8.Value1 = "0";
            this.grvListado.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition5,
            styleFormatCondition6,
            styleFormatCondition7,
            styleFormatCondition8});
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
            this.grvListado.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvListado_FocusedRowChanged);
            // 
            // colMenCodigo
            // 
            this.colMenCodigo.Caption = "Codigo";
            this.colMenCodigo.FieldName = "MenCodigo";
            this.colMenCodigo.Name = "colMenCodigo";
            // 
            // colMenNombre
            // 
            this.colMenNombre.Caption = "Menu";
            this.colMenNombre.FieldName = "MenNombre";
            this.colMenNombre.Name = "colMenNombre";
            this.colMenNombre.OptionsColumn.AllowEdit = false;
            this.colMenNombre.Visible = true;
            this.colMenNombre.VisibleIndex = 0;
            this.colMenNombre.Width = 330;
            // 
            // ickAcceso
            // 
            this.ickAcceso.AutoHeight = false;
            this.ickAcceso.Name = "ickAcceso";
            this.ickAcceso.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // treListado
            // 
            this.treListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.treListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Empty.Options.UseFont = true;
            this.treListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.EvenRow.Options.UseFont = true;
            this.treListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FilterPanel.Options.UseFont = true;
            this.treListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FixedLine.Options.UseFont = true;
            this.treListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FocusedCell.Options.UseFont = true;
            this.treListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FocusedRow.Options.UseFont = true;
            this.treListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FooterPanel.Options.UseFont = true;
            this.treListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.GroupButton.Options.UseFont = true;
            this.treListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.GroupFooter.Options.UseFont = true;
            this.treListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.treListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.treListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HorzLine.Options.UseFont = true;
            this.treListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.OddRow.Options.UseFont = true;
            this.treListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Preview.Options.UseFont = true;
            this.treListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Row.Options.UseFont = true;
            this.treListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.SelectedRow.Options.UseFont = true;
            this.treListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.VertLine.Options.UseFont = true;
            this.treListado.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treMenNombre,
            this.treFrmCodigo,
            this.treDocCodigo,
            this.treOpeCodigo,
            this.treCamCodigo});
            this.treListado.ContextMenuStrip = this.cmsMenuAccion;
            this.treListado.KeyFieldName = "MenCodigo";
            this.treListado.Location = new System.Drawing.Point(0, 0);
            this.treListado.Name = "treListado";
            this.treListado.OptionsBehavior.Editable = false;
            this.treListado.OptionsBehavior.EnableFiltering = true;
            this.treListado.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treListado.OptionsView.AutoWidth = false;
            this.treListado.ParentFieldName = "MenPadre";
            this.treListado.Size = new System.Drawing.Size(678, 565);
            this.treListado.TabIndex = 2;
            // 
            // treMenNombre
            // 
            this.treMenNombre.Caption = "Menu";
            this.treMenNombre.FieldName = "MenNombre";
            this.treMenNombre.Name = "treMenNombre";
            this.treMenNombre.OptionsColumn.AllowEdit = false;
            this.treMenNombre.Visible = true;
            this.treMenNombre.VisibleIndex = 0;
            this.treMenNombre.Width = 300;
            // 
            // treFrmCodigo
            // 
            this.treFrmCodigo.Caption = "Formulario";
            this.treFrmCodigo.FieldName = "FrmCodigo";
            this.treFrmCodigo.Name = "treFrmCodigo";
            this.treFrmCodigo.Visible = true;
            this.treFrmCodigo.VisibleIndex = 1;
            // 
            // treDocCodigo
            // 
            this.treDocCodigo.Caption = "Documento";
            this.treDocCodigo.FieldName = "DocCodigo";
            this.treDocCodigo.Name = "treDocCodigo";
            this.treDocCodigo.Visible = true;
            this.treDocCodigo.VisibleIndex = 2;
            // 
            // treOpeCodigo
            // 
            this.treOpeCodigo.Caption = "Operacion";
            this.treOpeCodigo.FieldName = "OpeCodigo";
            this.treOpeCodigo.Name = "treOpeCodigo";
            this.treOpeCodigo.Visible = true;
            this.treOpeCodigo.VisibleIndex = 3;
            // 
            // treCamCodigo
            // 
            this.treCamCodigo.Caption = "Campo";
            this.treCamCodigo.FieldName = "CamCodigo";
            this.treCamCodigo.Name = "treCamCodigo";
            this.treCamCodigo.Visible = true;
            this.treCamCodigo.VisibleIndex = 4;
            // 
            // cmsMenuAccion
            // 
            this.cmsMenuAccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.quitarToolStripMenuItem});
            this.cmsMenuAccion.Name = "cmsMenuAccion";
            this.cmsMenuAccion.Size = new System.Drawing.Size(153, 70);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem.Image = global::umbAplicacion.Properties.Resources.imgAgregar24;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // quitarToolStripMenuItem
            // 
            this.quitarToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitarToolStripMenuItem.Image")));
            this.quitarToolStripMenuItem.Name = "quitarToolStripMenuItem";
            this.quitarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitarToolStripMenuItem.Text = "Quitar";
            this.quitarToolStripMenuItem.Click += new System.EventHandler(this.quitarToolStripMenuItem_Click);
            // 
            // frmAccFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 611);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAccFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccMenu";
            this.Load += new System.EventHandler(this.frmAccMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ickAcceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).EndInit();
            this.cmsMenuAccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colMenNombre;
        public DevExpress.XtraTreeList.TreeList treListado;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ickAcceso;
        private DevExpress.XtraGrid.Columns.GridColumn colMenCodigo;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treMenNombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treFrmCodigo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treDocCodigo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treOpeCodigo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treCamCodigo;
        private System.Windows.Forms.ContextMenuStrip cmsMenuAccion;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarToolStripMenuItem;
    }
}