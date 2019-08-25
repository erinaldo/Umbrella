namespace umbAplicacion.Costos.Mantenimiento
{
    partial class xfrmCosManActCstProductos
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCosManActCstProductos));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colDetStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetSAPEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueBodega = new DevExpress.XtraEditors.LookUpEdit();
            this.lblBodega = new DevExpress.XtraEditors.LabelControl();
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvItemIngrediente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteUndInventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxDecimalesCuatro = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetTieLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetSAPSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetSAPDiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabVariante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetOpcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluVariante = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDetLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxLote = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetSaco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItePsoStd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMateriales = new DevExpress.XtraGrid.GridControl();
            this.grvMateriales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuenciaMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodigoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNombreMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteUndInventarioMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCantPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxDecimalesCuatroM = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDetTieLoteMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluBodega = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDetCantReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetBodStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluDetStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.grvDetStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSecItemProducir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodProducir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteNomProducir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCantidadMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIteCodMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodCodMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetComprometido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.memObsDocumento = new DevExpress.XtraEditors.MemoEdit();
            this.lblObsDocumento = new DevExpress.XtraEditors.LabelControl();
            this.memObsDiario = new DevExpress.XtraEditors.MemoEdit();
            this.lblObsDiario = new DevExpress.XtraEditors.LabelControl();
            this.colDetBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalesCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluVariante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalesCuatroM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluDetStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDiario.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Size = new System.Drawing.Size(1146, 46);
            // 
            // colDetStock
            // 
            this.colDetStock.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.colDetStock.AppearanceHeader.Options.UseFont = true;
            this.colDetStock.Caption = "Stock";
            this.colDetStock.DisplayFormat.FormatString = "{0:0.####}";
            this.colDetStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetStock.FieldName = "DetStock";
            this.colDetStock.Name = "colDetStock";
            this.colDetStock.OptionsColumn.AllowEdit = false;
            this.colDetStock.Visible = true;
            this.colDetStock.VisibleIndex = 7;
            this.colDetStock.Width = 70;
            // 
            // colDetSAPEntrada
            // 
            this.colDetSAPEntrada.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.colDetSAPEntrada.AppearanceCell.Options.UseFont = true;
            this.colDetSAPEntrada.Caption = "SAP Entrada";
            this.colDetSAPEntrada.DisplayFormat.FormatString = "0;(0); ";
            this.colDetSAPEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetSAPEntrada.FieldName = "DetSAPEntrada";
            this.colDetSAPEntrada.Name = "colDetSAPEntrada";
            this.colDetSAPEntrada.OptionsColumn.AllowEdit = false;
            this.colDetSAPEntrada.Visible = true;
            this.colDetSAPEntrada.VisibleIndex = 11;
            this.colDetSAPEntrada.Width = 80;
            // 
            // lueBodega
            // 
            this.lueBodega.Location = new System.Drawing.Point(92, 55);
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
            this.lueBodega.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.lueBodega.Properties.DisplayMember = "Descripcion";
            this.lueBodega.Properties.NullText = "";
            this.lueBodega.Properties.ValueMember = "Codigo";
            this.lueBodega.Size = new System.Drawing.Size(287, 22);
            this.lueBodega.TabIndex = 678;
            // 
            // lblBodega
            // 
            this.lblBodega.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.Location = new System.Drawing.Point(25, 58);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(38, 15);
            this.lblBodega.TabIndex = 677;
            this.lblBodega.Text = "Bodega:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(25, 35);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 676;
            this.lblProveedor.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(825, 9);
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
            this.txtCodigo.TabIndex = 673;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.EditValue = "";
            this.txtCodSerie.EnterMoveNextControl = true;
            this.txtCodSerie.Location = new System.Drawing.Point(873, 9);
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
            this.txtCodSerie.TabIndex = 672;
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
            this.txtNumero.TabIndex = 671;
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
            this.txtNomSerie.TabIndex = 670;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(942, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 669;
            this.labelControl4.Text = "Serie:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(184, 9);
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
            this.datFecha.TabIndex = 667;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(92, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 15);
            this.labelControl3.TabIndex = 668;
            this.labelControl3.Text = "Fecha documento:";
            // 
            // grcListado
            // 
            this.grcListado.ContextMenuStrip = this.cmsMenu;
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(25, 83);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluItem,
            this.itxDecimalesCuatro,
            this.iluVariante,
            this.itxLote});
            this.grcListado.Size = new System.Drawing.Size(1099, 369);
            this.grcListado.TabIndex = 680;
            this.grcListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListado});
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBorrar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(135, 26);
            // 
            // smiBorrar
            // 
            this.smiBorrar.Image = global::umbAplicacion.Properties.Resources.imgQuitar24;
            this.smiBorrar.Name = "smiBorrar";
            this.smiBorrar.Size = new System.Drawing.Size(134, 22);
            this.smiBorrar.Text = "Borrar linea";
            this.smiBorrar.Click += new System.EventHandler(this.smiBorrar_Click);
            // 
            // grvListado
            // 
            this.grvListado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvListado.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvListado.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvListado.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvListado.Appearance.DetailTip.Options.UseFont = true;
            this.grvListado.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Empty.Options.UseBackColor = true;
            this.grvListado.Appearance.Empty.Options.UseFont = true;
            this.grvListado.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvListado.Appearance.EvenRow.Options.UseFont = true;
            this.grvListado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvListado.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvListado.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.FilterPanel.Options.UseFont = true;
            this.grvListado.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvListado.Appearance.FixedLine.Options.UseFont = true;
            this.grvListado.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvListado.Appearance.FocusedCell.Options.UseFont = true;
            this.grvListado.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvListado.Appearance.FocusedRow.Options.UseFont = true;
            this.grvListado.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvListado.Appearance.FooterPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupButton.Options.UseFont = true;
            this.grvListado.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupFooter.Options.UseFont = true;
            this.grvListado.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupRow.Options.UseFont = true;
            this.grvListado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvListado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HorzLine.Options.UseFont = true;
            this.grvListado.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.OddRow.Options.UseBackColor = true;
            this.grvListado.Appearance.OddRow.Options.UseFont = true;
            this.grvListado.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Preview.Options.UseBackColor = true;
            this.grvListado.Appearance.Preview.Options.UseFont = true;
            this.grvListado.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Row.Options.UseBackColor = true;
            this.grvListado.Appearance.Row.Options.UseFont = true;
            this.grvListado.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvListado.Appearance.RowSeparator.Options.UseFont = true;
            this.grvListado.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvListado.Appearance.SelectedRow.Options.UseFont = true;
            this.grvListado.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvListado.Appearance.TopNewRow.Options.UseFont = true;
            this.grvListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.VertLine.Options.UseFont = true;
            this.grvListado.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvListado.Appearance.ViewCaption.Options.UseFont = true;
            this.grvListado.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.grvListado.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grvListado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetSecuencia,
            this.colIteCodigo,
            this.colIteNombre,
            this.colIteUndInventario,
            this.colDetCantidad,
            this.colDetCosto,
            this.colDetTieLote,
            this.colDetEstado,
            this.colDetSAPEntrada,
            this.colDetSAPSalida,
            this.colDetSAPDiario,
            this.colCabFormula,
            this.colCabVariante,
            this.colDetOpcion,
            this.colDetLote,
            this.colDetSaco,
            this.colItePsoStd});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "ReglaEnvioSAP";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Navy;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[EstCodigo] = \'Sap\' And [DetSAPSalida] > 0 And [DetSAPEntrada] > 0 And [DetSAPDia" +
    "rio] > 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.grvListado.FormatRules.Add(gridFormatRule1);
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
            this.grvListado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvListado.OptionsView.ColumnAutoWidth = false;
            this.grvListado.OptionsView.ShowDetailButtons = false;
            this.grvListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvListado.OptionsView.ShowGroupPanel = false;
            this.grvListado.OptionsView.ShowViewCaption = true;
            this.grvListado.ViewCaption = "ITEMS ACTUALIZAR COSTO";
            this.grvListado.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvListado_ShowingEditor);
            this.grvListado.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvListado_FocusedRowChanged);
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
            this.colIteCodigo.ColumnEdit = this.gluItem;
            this.colIteCodigo.FieldName = "IteCodigo";
            this.colIteCodigo.Name = "colIteCodigo";
            this.colIteCodigo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ItemCode", "{0:0}")});
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
            this.gluItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gluItem.DisplayMember = "ItemCode";
            this.gluItem.Name = "gluItem";
            this.gluItem.NullText = "";
            this.gluItem.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluItem.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluItem.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluItem.ValueMember = "ItemCode";
            this.gluItem.View = this.igvItemIngrediente;
            this.gluItem.Popup += new System.EventHandler(this.gluItem_Popup);
            this.gluItem.Leave += new System.EventHandler(this.gluItem_Leave);
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
            this.colIteUndInventario.Visible = true;
            this.colIteUndInventario.VisibleIndex = 3;
            this.colIteUndInventario.Width = 50;
            // 
            // colDetCantidad
            // 
            this.colDetCantidad.Caption = "Cantidad";
            this.colDetCantidad.ColumnEdit = this.itxDecimalesCuatro;
            this.colDetCantidad.FieldName = "DetCantidad";
            this.colDetCantidad.Name = "colDetCantidad";
            this.colDetCantidad.Visible = true;
            this.colDetCantidad.VisibleIndex = 6;
            this.colDetCantidad.Width = 80;
            // 
            // itxDecimalesCuatro
            // 
            this.itxDecimalesCuatro.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxDecimalesCuatro.Appearance.Options.UseFont = true;
            this.itxDecimalesCuatro.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatro.AppearanceDisabled.Options.UseFont = true;
            this.itxDecimalesCuatro.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatro.AppearanceFocused.Options.UseFont = true;
            this.itxDecimalesCuatro.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatro.AppearanceReadOnly.Options.UseFont = true;
            this.itxDecimalesCuatro.AutoHeight = false;
            this.itxDecimalesCuatro.Mask.EditMask = "n4";
            this.itxDecimalesCuatro.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxDecimalesCuatro.Name = "itxDecimalesCuatro";
            this.itxDecimalesCuatro.Leave += new System.EventHandler(this.itxDecimalesCuatro_Leave);
            // 
            // colDetCosto
            // 
            this.colDetCosto.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.colDetCosto.AppearanceHeader.Options.UseFont = true;
            this.colDetCosto.Caption = "Costo";
            this.colDetCosto.ColumnEdit = this.itxDecimalesCuatro;
            this.colDetCosto.DisplayFormat.FormatString = "0.0000;(0.0000); ";
            this.colDetCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCosto.FieldName = "DetCosto";
            this.colDetCosto.Name = "colDetCosto";
            this.colDetCosto.OptionsColumn.AllowEdit = false;
            this.colDetCosto.Visible = true;
            this.colDetCosto.VisibleIndex = 9;
            this.colDetCosto.Width = 80;
            // 
            // colDetTieLote
            // 
            this.colDetTieLote.Caption = "Tiene lote";
            this.colDetTieLote.FieldName = "DetTieLote";
            this.colDetTieLote.Name = "colDetTieLote";
            // 
            // colDetEstado
            // 
            this.colDetEstado.Caption = "Est";
            this.colDetEstado.FieldName = "EstCodigo";
            this.colDetEstado.Name = "colDetEstado";
            this.colDetEstado.Visible = true;
            this.colDetEstado.VisibleIndex = 14;
            // 
            // colDetSAPSalida
            // 
            this.colDetSAPSalida.Caption = "SAP Salida";
            this.colDetSAPSalida.DisplayFormat.FormatString = "0;(0); ";
            this.colDetSAPSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetSAPSalida.FieldName = "DetSAPSalida";
            this.colDetSAPSalida.Name = "colDetSAPSalida";
            this.colDetSAPSalida.OptionsColumn.AllowEdit = false;
            this.colDetSAPSalida.Visible = true;
            this.colDetSAPSalida.VisibleIndex = 10;
            this.colDetSAPSalida.Width = 80;
            // 
            // colDetSAPDiario
            // 
            this.colDetSAPDiario.Caption = "SAP Diario";
            this.colDetSAPDiario.DisplayFormat.FormatString = "0;(0); ";
            this.colDetSAPDiario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetSAPDiario.FieldName = "DetSAPDiario";
            this.colDetSAPDiario.Name = "colDetSAPDiario";
            this.colDetSAPDiario.OptionsColumn.AllowEdit = false;
            this.colDetSAPDiario.Visible = true;
            this.colDetSAPDiario.VisibleIndex = 12;
            this.colDetSAPDiario.Width = 80;
            // 
            // colCabFormula
            // 
            this.colCabFormula.Caption = "Formula";
            this.colCabFormula.FieldName = "CabFormula";
            this.colCabFormula.Name = "colCabFormula";
            // 
            // colCabVariante
            // 
            this.colCabVariante.Caption = "Variante";
            this.colCabVariante.FieldName = "CabVariante";
            this.colCabVariante.Name = "colCabVariante";
            this.colCabVariante.OptionsColumn.AllowEdit = false;
            this.colCabVariante.Visible = true;
            this.colCabVariante.VisibleIndex = 4;
            this.colCabVariante.Width = 50;
            // 
            // colDetOpcion
            // 
            this.colDetOpcion.ColumnEdit = this.iluVariante;
            this.colDetOpcion.Name = "colDetOpcion";
            this.colDetOpcion.Visible = true;
            this.colDetOpcion.VisibleIndex = 5;
            this.colDetOpcion.Width = 20;
            // 
            // iluVariante
            // 
            this.iluVariante.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iluVariante.Appearance.Options.UseFont = true;
            this.iluVariante.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluVariante.AppearanceDisabled.Options.UseFont = true;
            this.iluVariante.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluVariante.AppearanceDropDown.Options.UseFont = true;
            this.iluVariante.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluVariante.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluVariante.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluVariante.AppearanceFocused.Options.UseFont = true;
            this.iluVariante.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluVariante.AppearanceReadOnly.Options.UseFont = true;
            this.iluVariante.AutoHeight = false;
            this.iluVariante.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluVariante.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CabCodigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CabVariante", "Variante")});
            this.iluVariante.Name = "iluVariante";
            this.iluVariante.PopupFormMinSize = new System.Drawing.Size(40, 20);
            this.iluVariante.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.iluVariante.EditValueChanged += new System.EventHandler(this.iluVariante_EditValueChanged);
            // 
            // colDetLote
            // 
            this.colDetLote.Caption = "Lote";
            this.colDetLote.ColumnEdit = this.itxLote;
            this.colDetLote.FieldName = "DetLote";
            this.colDetLote.Name = "colDetLote";
            this.colDetLote.Visible = true;
            this.colDetLote.VisibleIndex = 7;
            this.colDetLote.Width = 80;
            // 
            // itxLote
            // 
            this.itxLote.AutoHeight = false;
            this.itxLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.itxLote.Name = "itxLote";
            // 
            // colDetSaco
            // 
            this.colDetSaco.Caption = "Sacos";
            this.colDetSaco.FieldName = "DetSaco";
            this.colDetSaco.Name = "colDetSaco";
            this.colDetSaco.Visible = true;
            this.colDetSaco.VisibleIndex = 8;
            this.colDetSaco.Width = 80;
            // 
            // colItePsoStd
            // 
            this.colItePsoStd.Caption = "Pso. Std.";
            this.colItePsoStd.FieldName = "ItePsoStd";
            this.colItePsoStd.Name = "colItePsoStd";
            this.colItePsoStd.Visible = true;
            this.colItePsoStd.VisibleIndex = 13;
            // 
            // grcMateriales
            // 
            this.grcMateriales.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcMateriales.Location = new System.Drawing.Point(25, 451);
            this.grcMateriales.MainView = this.grvMateriales;
            this.grcMateriales.Name = "grcMateriales";
            this.grcMateriales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itxDecimalesCuatroM,
            this.gluDetStock,
            this.iluBodega});
            this.grcMateriales.Size = new System.Drawing.Size(737, 162);
            this.grcMateriales.TabIndex = 681;
            this.grcMateriales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMateriales});
            // 
            // grvMateriales
            // 
            this.grvMateriales.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvMateriales.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvMateriales.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvMateriales.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvMateriales.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvMateriales.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvMateriales.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvMateriales.Appearance.DetailTip.Options.UseFont = true;
            this.grvMateriales.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.Empty.Options.UseBackColor = true;
            this.grvMateriales.Appearance.Empty.Options.UseFont = true;
            this.grvMateriales.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.EvenRow.Options.UseFont = true;
            this.grvMateriales.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvMateriales.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FilterPanel.Options.UseFont = true;
            this.grvMateriales.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FixedLine.Options.UseFont = true;
            this.grvMateriales.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FocusedCell.Options.UseFont = true;
            this.grvMateriales.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grvMateriales.Appearance.FocusedRow.Options.UseFont = true;
            this.grvMateriales.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvMateriales.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvMateriales.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvMateriales.Appearance.FooterPanel.Options.UseFont = true;
            this.grvMateriales.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvMateriales.Appearance.GroupButton.Options.UseFont = true;
            this.grvMateriales.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvMateriales.Appearance.GroupFooter.Options.UseFont = true;
            this.grvMateriales.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvMateriales.Appearance.GroupPanel.Options.UseFont = true;
            this.grvMateriales.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.GroupRow.Options.UseFont = true;
            this.grvMateriales.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvMateriales.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvMateriales.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvMateriales.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.HorzLine.Options.UseFont = true;
            this.grvMateriales.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.OddRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.OddRow.Options.UseFont = true;
            this.grvMateriales.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.Preview.Options.UseBackColor = true;
            this.grvMateriales.Appearance.Preview.Options.UseFont = true;
            this.grvMateriales.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.Row.Options.UseBackColor = true;
            this.grvMateriales.Appearance.Row.Options.UseFont = true;
            this.grvMateriales.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvMateriales.Appearance.RowSeparator.Options.UseFont = true;
            this.grvMateriales.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.SelectedRow.Options.UseFont = true;
            this.grvMateriales.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvMateriales.Appearance.TopNewRow.Options.UseFont = true;
            this.grvMateriales.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.VertLine.Options.UseFont = true;
            this.grvMateriales.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvMateriales.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMateriales.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvMateriales.Appearance.ViewCaption.Options.UseFont = true;
            this.grvMateriales.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.grvMateriales.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grvMateriales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvMateriales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetSecuenciaMat,
            this.colIteCodigoMat,
            this.colIteNombreMat,
            this.colIteUndInventarioMat,
            this.colDetCantPlan,
            this.colDetStock,
            this.colDetTieLoteMat,
            this.colBodCodigo,
            this.colDetCantReal,
            this.colDetBodStock,
            this.colDetComprometido,
            this.colEstCodigo});
            gridFormatRule3.Column = this.colDetStock;
            gridFormatRule3.ColumnApplyTo = this.colDetStock;
            gridFormatRule3.Name = "Color Stock";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            formatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Appearance.Options.UseFont = true;
            formatConditionRuleExpression3.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression3.Expression = " ([DetStock] - [DetComprometido]) < 0 And [EstCodigo] != \'Sap\'";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "Regla Envio SAP";
            formatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            formatConditionRuleExpression4.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression4.Appearance.Options.UseFont = true;
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression4.Expression = "[EstCodigo] = \'Sap\'";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            this.grvMateriales.FormatRules.Add(gridFormatRule3);
            this.grvMateriales.FormatRules.Add(gridFormatRule4);
            this.grvMateriales.GridControl = this.grcMateriales;
            this.grvMateriales.Name = "grvMateriales";
            this.grvMateriales.OptionsCustomization.AllowColumnMoving = false;
            this.grvMateriales.OptionsCustomization.AllowColumnResizing = false;
            this.grvMateriales.OptionsCustomization.AllowGroup = false;
            this.grvMateriales.OptionsCustomization.AllowSort = false;
            this.grvMateriales.OptionsDetail.EnableMasterViewMode = false;
            this.grvMateriales.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvMateriales.OptionsFind.AllowFindPanel = false;
            this.grvMateriales.OptionsFind.ShowClearButton = false;
            this.grvMateriales.OptionsFind.ShowCloseButton = false;
            this.grvMateriales.OptionsFind.ShowFindButton = false;
            this.grvMateriales.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvMateriales.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvMateriales.OptionsView.ColumnAutoWidth = false;
            this.grvMateriales.OptionsView.EnableAppearanceEvenRow = true;
            this.grvMateriales.OptionsView.EnableAppearanceOddRow = true;
            this.grvMateriales.OptionsView.ShowDetailButtons = false;
            this.grvMateriales.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvMateriales.OptionsView.ShowGroupPanel = false;
            this.grvMateriales.OptionsView.ShowViewCaption = true;
            this.grvMateriales.ViewCaption = "MATERIALES A UTILIZAR";
            this.grvMateriales.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvMateriales_ShowingEditor);
            // 
            // colDetSecuenciaMat
            // 
            this.colDetSecuenciaMat.Caption = "Nro";
            this.colDetSecuenciaMat.FieldName = "DetSecuencia";
            this.colDetSecuenciaMat.Name = "colDetSecuenciaMat";
            this.colDetSecuenciaMat.OptionsColumn.AllowEdit = false;
            this.colDetSecuenciaMat.OptionsColumn.TabStop = false;
            this.colDetSecuenciaMat.Visible = true;
            this.colDetSecuenciaMat.VisibleIndex = 0;
            this.colDetSecuenciaMat.Width = 30;
            // 
            // colIteCodigoMat
            // 
            this.colIteCodigoMat.Caption = "Item";
            this.colIteCodigoMat.FieldName = "IteCodigo";
            this.colIteCodigoMat.Name = "colIteCodigoMat";
            this.colIteCodigoMat.OptionsColumn.AllowEdit = false;
            this.colIteCodigoMat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ItemCode", "{0:0}")});
            this.colIteCodigoMat.Visible = true;
            this.colIteCodigoMat.VisibleIndex = 1;
            // 
            // colIteNombreMat
            // 
            this.colIteNombreMat.Caption = "Descripcion";
            this.colIteNombreMat.FieldName = "IteNombre";
            this.colIteNombreMat.Name = "colIteNombreMat";
            this.colIteNombreMat.OptionsColumn.AllowEdit = false;
            this.colIteNombreMat.OptionsColumn.TabStop = false;
            this.colIteNombreMat.Visible = true;
            this.colIteNombreMat.VisibleIndex = 2;
            this.colIteNombreMat.Width = 235;
            // 
            // colIteUndInventarioMat
            // 
            this.colIteUndInventarioMat.Caption = "Und.";
            this.colIteUndInventarioMat.FieldName = "IteUndInventario";
            this.colIteUndInventarioMat.Name = "colIteUndInventarioMat";
            this.colIteUndInventarioMat.OptionsColumn.AllowEdit = false;
            this.colIteUndInventarioMat.Visible = true;
            this.colIteUndInventarioMat.VisibleIndex = 3;
            this.colIteUndInventarioMat.Width = 45;
            // 
            // colDetCantPlan
            // 
            this.colDetCantPlan.Caption = "Cant. Plan";
            this.colDetCantPlan.ColumnEdit = this.itxDecimalesCuatroM;
            this.colDetCantPlan.DisplayFormat.FormatString = "#.####;(#.####); ";
            this.colDetCantPlan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantPlan.FieldName = "DetCantPlan";
            this.colDetCantPlan.Name = "colDetCantPlan";
            this.colDetCantPlan.OptionsColumn.AllowEdit = false;
            this.colDetCantPlan.Visible = true;
            this.colDetCantPlan.VisibleIndex = 4;
            this.colDetCantPlan.Width = 70;
            // 
            // itxDecimalesCuatroM
            // 
            this.itxDecimalesCuatroM.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxDecimalesCuatroM.Appearance.Options.UseFont = true;
            this.itxDecimalesCuatroM.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatroM.AppearanceDisabled.Options.UseFont = true;
            this.itxDecimalesCuatroM.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatroM.AppearanceFocused.Options.UseFont = true;
            this.itxDecimalesCuatroM.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxDecimalesCuatroM.AppearanceReadOnly.Options.UseFont = true;
            this.itxDecimalesCuatroM.AutoHeight = false;
            this.itxDecimalesCuatroM.Mask.EditMask = "n4";
            this.itxDecimalesCuatroM.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxDecimalesCuatroM.Name = "itxDecimalesCuatroM";
            this.itxDecimalesCuatroM.Leave += new System.EventHandler(this.itxDecimalesCuatroM_Leave);
            // 
            // colDetTieLoteMat
            // 
            this.colDetTieLoteMat.Caption = "Tiene lote";
            this.colDetTieLoteMat.FieldName = "DetTieLote";
            this.colDetTieLoteMat.Name = "colDetTieLoteMat";
            // 
            // colBodCodigo
            // 
            this.colBodCodigo.Caption = "Bod.";
            this.colBodCodigo.ColumnEdit = this.iluBodega;
            this.colBodCodigo.FieldName = "BodCodigo";
            this.colBodCodigo.Name = "colBodCodigo";
            this.colBodCodigo.Visible = true;
            this.colBodCodigo.VisibleIndex = 6;
            this.colBodCodigo.Width = 45;
            // 
            // iluBodega
            // 
            this.iluBodega.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iluBodega.Appearance.Options.UseFont = true;
            this.iluBodega.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.iluBodega.AppearanceDisabled.Options.UseFont = true;
            this.iluBodega.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.iluBodega.AppearanceDropDown.Options.UseFont = true;
            this.iluBodega.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.iluBodega.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluBodega.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.iluBodega.AppearanceFocused.Options.UseFont = true;
            this.iluBodega.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.iluBodega.AppearanceReadOnly.Options.UseFont = true;
            this.iluBodega.AutoHeight = false;
            this.iluBodega.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluBodega.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsCode", 30, "Cod."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WhsName", 100, "Bodega")});
            this.iluBodega.DisplayMember = "WhsCode";
            this.iluBodega.Name = "iluBodega";
            this.iluBodega.NullText = "";
            this.iluBodega.ValueMember = "WhsCode";
            this.iluBodega.EditValueChanged += new System.EventHandler(this.iluBodega_EditValueChanged);
            // 
            // colDetCantReal
            // 
            this.colDetCantReal.Caption = "Cant. Real";
            this.colDetCantReal.ColumnEdit = this.itxDecimalesCuatroM;
            this.colDetCantReal.DisplayFormat.FormatString = "#.####;(#.####); ";
            this.colDetCantReal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantReal.FieldName = "DetCantReal";
            this.colDetCantReal.Name = "colDetCantReal";
            this.colDetCantReal.Visible = true;
            this.colDetCantReal.VisibleIndex = 5;
            this.colDetCantReal.Width = 70;
            // 
            // colDetBodStock
            // 
            this.colDetBodStock.ColumnEdit = this.gluDetStock;
            this.colDetBodStock.Name = "colDetBodStock";
            this.colDetBodStock.Visible = true;
            this.colDetBodStock.VisibleIndex = 8;
            this.colDetBodStock.Width = 20;
            // 
            // gluDetStock
            // 
            this.gluDetStock.AutoHeight = false;
            this.gluDetStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluDetStock.Name = "gluDetStock";
            this.gluDetStock.PopupFormMinSize = new System.Drawing.Size(450, 200);
            this.gluDetStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gluDetStock.View = this.grvDetStock;
            // 
            // grvDetStock
            // 
            this.grvDetStock.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvDetStock.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDetStock.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvDetStock.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDetStock.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvDetStock.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDetStock.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvDetStock.Appearance.DetailTip.Options.UseFont = true;
            this.grvDetStock.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.Empty.Options.UseBackColor = true;
            this.grvDetStock.Appearance.Empty.Options.UseFont = true;
            this.grvDetStock.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.EvenRow.Options.UseFont = true;
            this.grvDetStock.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDetStock.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDetStock.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FixedLine.Options.UseFont = true;
            this.grvDetStock.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDetStock.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.grvDetStock.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDetStock.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvDetStock.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvDetStock.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvDetStock.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDetStock.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvDetStock.Appearance.GroupButton.Options.UseFont = true;
            this.grvDetStock.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvDetStock.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDetStock.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvDetStock.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDetStock.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.GroupRow.Options.UseFont = true;
            this.grvDetStock.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvDetStock.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetStock.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDetStock.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.HorzLine.Options.UseFont = true;
            this.grvDetStock.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.OddRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.OddRow.Options.UseFont = true;
            this.grvDetStock.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.Preview.Options.UseBackColor = true;
            this.grvDetStock.Appearance.Preview.Options.UseFont = true;
            this.grvDetStock.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.Row.Options.UseBackColor = true;
            this.grvDetStock.Appearance.Row.Options.UseFont = true;
            this.grvDetStock.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvDetStock.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDetStock.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDetStock.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvDetStock.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDetStock.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.VertLine.Options.UseFont = true;
            this.grvDetStock.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvDetStock.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetStock.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvDetStock.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDetStock.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.grvDetStock.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grvDetStock.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvDetStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSecItemProducir,
            this.colIteCodProducir,
            this.colIteNomProducir,
            this.colDetCantidadMat,
            this.colIteCodMaterial,
            this.colBodCodMaterial});
            this.grvDetStock.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridFormatRule2.Name = "Color Stock";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseFont = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "([DetStock] - [DetComprometido]) < 0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.grvDetStock.FormatRules.Add(gridFormatRule2);
            this.grvDetStock.Name = "grvDetStock";
            this.grvDetStock.OptionsCustomization.AllowColumnMoving = false;
            this.grvDetStock.OptionsCustomization.AllowColumnResizing = false;
            this.grvDetStock.OptionsCustomization.AllowGroup = false;
            this.grvDetStock.OptionsCustomization.AllowSort = false;
            this.grvDetStock.OptionsDetail.EnableMasterViewMode = false;
            this.grvDetStock.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvDetStock.OptionsFind.AllowFindPanel = false;
            this.grvDetStock.OptionsFind.ShowClearButton = false;
            this.grvDetStock.OptionsFind.ShowCloseButton = false;
            this.grvDetStock.OptionsFind.ShowFindButton = false;
            this.grvDetStock.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDetStock.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvDetStock.OptionsView.ColumnAutoWidth = false;
            this.grvDetStock.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDetStock.OptionsView.EnableAppearanceOddRow = true;
            this.grvDetStock.OptionsView.ShowDetailButtons = false;
            this.grvDetStock.OptionsView.ShowFooter = true;
            this.grvDetStock.OptionsView.ShowGroupPanel = false;
            this.grvDetStock.OptionsView.ShowViewCaption = true;
            this.grvDetStock.ViewCaption = "MATERIALES A UTILIZAR";
            // 
            // colSecItemProducir
            // 
            this.colSecItemProducir.Caption = "Nro";
            this.colSecItemProducir.FieldName = "DetSecuencia";
            this.colSecItemProducir.Name = "colSecItemProducir";
            this.colSecItemProducir.OptionsColumn.AllowEdit = false;
            this.colSecItemProducir.OptionsColumn.TabStop = false;
            this.colSecItemProducir.Visible = true;
            this.colSecItemProducir.VisibleIndex = 0;
            this.colSecItemProducir.Width = 30;
            // 
            // colIteCodProducir
            // 
            this.colIteCodProducir.Caption = "Item";
            this.colIteCodProducir.FieldName = "IteCodigo";
            this.colIteCodProducir.Name = "colIteCodProducir";
            this.colIteCodProducir.OptionsColumn.AllowEdit = false;
            this.colIteCodProducir.Visible = true;
            this.colIteCodProducir.VisibleIndex = 1;
            // 
            // colIteNomProducir
            // 
            this.colIteNomProducir.Caption = "Descripcion";
            this.colIteNomProducir.FieldName = "IteNombre";
            this.colIteNomProducir.Name = "colIteNomProducir";
            this.colIteNomProducir.OptionsColumn.AllowEdit = false;
            this.colIteNomProducir.OptionsColumn.TabStop = false;
            this.colIteNomProducir.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "IteNombre", "Stock Disponible:")});
            this.colIteNomProducir.Visible = true;
            this.colIteNomProducir.VisibleIndex = 2;
            this.colIteNomProducir.Width = 235;
            // 
            // colDetCantidadMat
            // 
            this.colDetCantidadMat.Caption = "Cantidad";
            this.colDetCantidadMat.DisplayFormat.FormatString = "{0:0.####}";
            this.colDetCantidadMat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetCantidadMat.FieldName = "DetCantidad";
            this.colDetCantidadMat.Name = "colDetCantidadMat";
            this.colDetCantidadMat.OptionsColumn.AllowEdit = false;
            this.colDetCantidadMat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DetCantidad", "{0:#.####}")});
            this.colDetCantidadMat.Visible = true;
            this.colDetCantidadMat.VisibleIndex = 3;
            this.colDetCantidadMat.Width = 70;
            // 
            // colIteCodMaterial
            // 
            this.colIteCodMaterial.Caption = "Cod. Material";
            this.colIteCodMaterial.FieldName = "IteCodMaterial";
            this.colIteCodMaterial.Name = "colIteCodMaterial";
            // 
            // colBodCodMaterial
            // 
            this.colBodCodMaterial.Caption = "Bodega";
            this.colBodCodMaterial.FieldName = "BodCodMaterial";
            this.colBodCodMaterial.Name = "colBodCodMaterial";
            // 
            // colDetComprometido
            // 
            this.colDetComprometido.Caption = "Compro";
            this.colDetComprometido.FieldName = "DetComprometido";
            this.colDetComprometido.Name = "colDetComprometido";
            this.colDetComprometido.Width = 60;
            // 
            // colEstCodigo
            // 
            this.colEstCodigo.Caption = "Est";
            this.colEstCodigo.FieldName = "EstCodigo";
            this.colEstCodigo.Name = "colEstCodigo";
            this.colEstCodigo.Visible = true;
            this.colEstCodigo.VisibleIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(92, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 180;
            this.txtNombre.Size = new System.Drawing.Size(399, 23);
            this.txtNombre.TabIndex = 682;
            this.txtNombre.TabStop = false;
            // 
            // memObsDocumento
            // 
            this.memObsDocumento.Location = new System.Drawing.Point(768, 479);
            this.memObsDocumento.Name = "memObsDocumento";
            this.memObsDocumento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObsDocumento.Properties.Appearance.Options.UseFont = true;
            this.memObsDocumento.Properties.MaxLength = 254;
            this.memObsDocumento.Size = new System.Drawing.Size(356, 67);
            this.memObsDocumento.TabIndex = 683;
            // 
            // lblObsDocumento
            // 
            this.lblObsDocumento.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsDocumento.Location = new System.Drawing.Point(768, 458);
            this.lblObsDocumento.Name = "lblObsDocumento";
            this.lblObsDocumento.Size = new System.Drawing.Size(129, 15);
            this.lblObsDocumento.TabIndex = 684;
            this.lblObsDocumento.Text = "Observaciones documento:";
            // 
            // memObsDiario
            // 
            this.memObsDiario.Location = new System.Drawing.Point(768, 573);
            this.memObsDiario.Name = "memObsDiario";
            this.memObsDiario.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObsDiario.Properties.Appearance.Options.UseFont = true;
            this.memObsDiario.Properties.MaxLength = 30;
            this.memObsDiario.Size = new System.Drawing.Size(356, 40);
            this.memObsDiario.TabIndex = 685;
            // 
            // lblObsDiario
            // 
            this.lblObsDiario.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsDiario.Location = new System.Drawing.Point(768, 552);
            this.lblObsDiario.Name = "lblObsDiario";
            this.lblObsDiario.Size = new System.Drawing.Size(103, 15);
            this.lblObsDiario.TabIndex = 686;
            this.lblObsDiario.Text = "Observaciones diario:";
            // 
            // colDetBodega
            // 
            this.colDetBodega.Caption = "Bodega";
            this.colDetBodega.FieldName = "DetBodega";
            this.colDetBodega.Name = "colDetBodega";
            this.colDetBodega.Width = 50;
            // 
            // xfrmCosManActCstProductos
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1146, 666);
            this.Controls.Add(this.memObsDiario);
            this.Controls.Add(this.lblObsDiario);
            this.Controls.Add(this.memObsDocumento);
            this.Controls.Add(this.lblObsDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grcMateriales);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.lueBodega);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Name = "xfrmCosManActCstProductos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmCosManActCstProductos_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.txtNomSerie, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodSerie, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.lblBodega, 0);
            this.Controls.SetChildIndex(this.lueBodega, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.grcMateriales, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblObsDocumento, 0);
            this.Controls.SetChildIndex(this.memObsDocumento, 0);
            this.Controls.SetChildIndex(this.lblObsDiario, 0);
            this.Controls.SetChildIndex(this.memObsDiario, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalesCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluVariante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxDecimalesCuatroM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluDetStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObsDiario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueBodega;
        private DevExpress.XtraEditors.LabelControl lblBodega;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluItem;
        private DevExpress.XtraGrid.Views.Grid.GridView igvItemIngrediente;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvInvntryUom;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIteUndInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetTieLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDetEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSAPEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSAPSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSAPDiario;
        private DevExpress.XtraGrid.Columns.GridColumn colCabFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colCabVariante;
        private DevExpress.XtraGrid.Columns.GridColumn colDetOpcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluVariante;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxDecimalesCuatro;
        public DevExpress.XtraGrid.GridControl grcMateriales;
        public DevExpress.XtraGrid.Views.Grid.GridView grvMateriales;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuenciaMat;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodigoMat;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNombreMat;
        private DevExpress.XtraGrid.Columns.GridColumn colIteUndInventarioMat;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colDetStock;
        private DevExpress.XtraGrid.Columns.GridColumn colDetTieLoteMat;
        private DevExpress.XtraGrid.Columns.GridColumn colBodCodigo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.MemoEdit memObsDocumento;
        private DevExpress.XtraEditors.LabelControl lblObsDocumento;
        private DevExpress.XtraEditors.MemoEdit memObsDiario;
        private DevExpress.XtraEditors.LabelControl lblObsDiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantReal;
        private DevExpress.XtraGrid.Columns.GridColumn colDetBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxDecimalesCuatroM;
        private DevExpress.XtraGrid.Columns.GridColumn colDetBodStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluDetStock;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colDetLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDetComprometido;
        private DevExpress.XtraGrid.Columns.GridColumn colSecItemProducir;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodProducir;
        private DevExpress.XtraGrid.Columns.GridColumn colIteNomProducir;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCantidadMat;
        private DevExpress.XtraGrid.Columns.GridColumn colIteCodMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colBodCodMaterial;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem smiBorrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSaco;
        private DevExpress.XtraGrid.Columns.GridColumn colItePsoStd;
        private DevExpress.XtraGrid.Columns.GridColumn colEstCodigo;
    }
}
