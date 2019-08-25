namespace umbAplicacion.GestionBancos.Mantenimiento
{
    partial class xfrmGbaManExtBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmGbaManExtBancario));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.bedCueContable = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCuenta = new DevExpress.XtraEditors.LabelControl();
            this.butExaminar = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnExtraer = new DevExpress.XtraEditors.SimpleButton();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManBtchNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCodeAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtCueCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedCueContable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCueCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(996, 46);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(813, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 573;
            this.labelControl4.Text = "Serie:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(206, 12);
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
            this.labelControl3.Location = new System.Drawing.Point(114, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 15);
            this.labelControl3.TabIndex = 574;
            this.labelControl3.Text = "Fecha documento:";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(245, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(317, 23);
            this.txtNombre.TabIndex = 577;
            this.txtNombre.TabStop = false;
            // 
            // bedCueContable
            // 
            this.bedCueContable.EditValue = "";
            this.bedCueContable.Location = new System.Drawing.Point(114, 35);
            this.bedCueContable.Name = "bedCueContable";
            this.bedCueContable.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedCueContable.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedCueContable.Properties.Appearance.Options.UseBackColor = true;
            this.bedCueContable.Properties.Appearance.Options.UseFont = true;
            this.bedCueContable.Properties.AutoHeight = false;
            this.bedCueContable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bedCueContable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bedCueContable.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bedCueContable.Size = new System.Drawing.Size(132, 23);
            this.bedCueContable.TabIndex = 1;
            this.bedCueContable.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedCueContable_ButtonClick);
            this.bedCueContable.EditValueChanged += new System.EventHandler(this.bedCueContable_EditValueChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(25, 38);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(80, 15);
            this.lblCuenta.TabIndex = 578;
            this.lblCuenta.Text = "Cuenta contable:";
            // 
            // butExaminar
            // 
            this.butExaminar.Location = new System.Drawing.Point(114, 94);
            this.butExaminar.Name = "butExaminar";
            this.butExaminar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExaminar.Properties.Appearance.Options.UseFont = true;
            this.butExaminar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("butExaminar.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.butExaminar.Size = new System.Drawing.Size(447, 22);
            this.butExaminar.TabIndex = 3;
            this.butExaminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.butExaminar_ButtonClick);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(26, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 15);
            this.labelControl8.TabIndex = 579;
            this.labelControl8.Text = "Ruta Excel:";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Appearance.Options.UseFont = true;
            this.btnExtraer.Image = global::umbAplicacion.Properties.Resources.imgExtraer16;
            this.btnExtraer.Location = new System.Drawing.Point(567, 91);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(152, 26);
            this.btnExtraer.TabIndex = 4;
            this.btnExtraer.Text = "&Extraer estado cuenta";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(26, 126);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.Size = new System.Drawing.Size(958, 488);
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
            this.colDetFecha,
            this.colDetReferencia,
            this.colDetComentario,
            this.colDetHaber,
            this.colDetDebe,
            this.colManBtchNum,
            this.colTaxCodeAP});
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
            // colDetFecha
            // 
            this.colDetFecha.Caption = "Fecha";
            this.colDetFecha.FieldName = "DetFecha";
            this.colDetFecha.Name = "colDetFecha";
            this.colDetFecha.Visible = true;
            this.colDetFecha.VisibleIndex = 1;
            this.colDetFecha.Width = 90;
            // 
            // colDetReferencia
            // 
            this.colDetReferencia.Caption = "Referencia";
            this.colDetReferencia.FieldName = "DetReferencia";
            this.colDetReferencia.Name = "colDetReferencia";
            this.colDetReferencia.OptionsColumn.AllowEdit = false;
            this.colDetReferencia.OptionsColumn.TabStop = false;
            this.colDetReferencia.Visible = true;
            this.colDetReferencia.VisibleIndex = 2;
            this.colDetReferencia.Width = 150;
            // 
            // colDetComentario
            // 
            this.colDetComentario.Caption = "Comentario";
            this.colDetComentario.FieldName = "DetComentario";
            this.colDetComentario.Name = "colDetComentario";
            this.colDetComentario.OptionsColumn.AllowEdit = false;
            this.colDetComentario.OptionsColumn.TabStop = false;
            this.colDetComentario.Visible = true;
            this.colDetComentario.VisibleIndex = 3;
            this.colDetComentario.Width = 250;
            // 
            // colDetHaber
            // 
            this.colDetHaber.Caption = "Haber";
            this.colDetHaber.DisplayFormat.FormatString = "{0:0.00}";
            this.colDetHaber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetHaber.FieldName = "DetHaber";
            this.colDetHaber.Name = "colDetHaber";
            this.colDetHaber.Visible = true;
            this.colDetHaber.VisibleIndex = 5;
            this.colDetHaber.Width = 100;
            // 
            // colDetDebe
            // 
            this.colDetDebe.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDetDebe.AppearanceHeader.Options.UseFont = true;
            this.colDetDebe.Caption = "Debe";
            this.colDetDebe.DisplayFormat.FormatString = "{0:0.00}";
            this.colDetDebe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetDebe.FieldName = "DetDebe";
            this.colDetDebe.Name = "colDetDebe";
            this.colDetDebe.Visible = true;
            this.colDetDebe.VisibleIndex = 4;
            this.colDetDebe.Width = 100;
            // 
            // colManBtchNum
            // 
            this.colManBtchNum.Caption = "Tiene lote";
            this.colManBtchNum.FieldName = "ManBtchNum";
            this.colManBtchNum.Name = "colManBtchNum";
            // 
            // colTaxCodeAP
            // 
            this.colTaxCodeAP.Caption = "Impuesto";
            this.colTaxCodeAP.FieldName = "TaxCodeAP";
            this.colTaxCodeAP.Name = "colTaxCodeAP";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 600;
            this.lblNombre.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.EnterMoveNextControl = true;
            this.txtDescripcion.Location = new System.Drawing.Point(114, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(448, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Enabled = false;
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(915, 11);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(69, 22);
            this.txtNumero.TabIndex = 615;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Location = new System.Drawing.Point(845, 11);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Size = new System.Drawing.Size(69, 22);
            this.txtNomSerie.TabIndex = 614;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.EditValue = "";
            this.txtCodSerie.EnterMoveNextControl = true;
            this.txtCodSerie.Location = new System.Drawing.Point(709, 12);
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
            this.txtCodSerie.TabIndex = 616;
            this.txtCodSerie.TabStop = false;
            this.txtCodSerie.Visible = false;
            // 
            // txtCueCodigo
            // 
            this.txtCueCodigo.EditValue = "";
            this.txtCueCodigo.EnterMoveNextControl = true;
            this.txtCueCodigo.Location = new System.Drawing.Point(562, 35);
            this.txtCueCodigo.Name = "txtCueCodigo";
            this.txtCueCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCueCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCueCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCueCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCueCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCueCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCueCodigo.Properties.AutoHeight = false;
            this.txtCueCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCueCodigo.Properties.Mask.EditMask = "f0";
            this.txtCueCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCueCodigo.Size = new System.Drawing.Size(49, 22);
            this.txtCueCodigo.TabIndex = 617;
            this.txtCueCodigo.TabStop = false;
            this.txtCueCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(709, 34);
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
            this.txtCodigo.TabIndex = 618;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // xfrmGbaManExtBancario
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(996, 666);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCueCodigo);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.butExaminar);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.bedCueContable);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Name = "xfrmGbaManExtBancario";
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.lblCuenta, 0);
            this.Controls.SetChildIndex(this.bedCueContable, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.butExaminar, 0);
            this.Controls.SetChildIndex(this.btnExtraer, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtNomSerie, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodSerie, 0);
            this.Controls.SetChildIndex(this.txtCueCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedCueContable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCueCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.ButtonEdit bedCueContable;
        private DevExpress.XtraEditors.LabelControl lblCuenta;
        private DevExpress.XtraEditors.ButtonEdit butExaminar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.SimpleButton btnExtraer;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDetFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colDetReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDetComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colDetHaber;
        private DevExpress.XtraGrid.Columns.GridColumn colDetDebe;
        private DevExpress.XtraGrid.Columns.GridColumn colManBtchNum;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCodeAP;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraEditors.TextEdit txtCueCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
    }
}
