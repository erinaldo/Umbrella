namespace umbAplicacion.Finanzas.Mantenimiento
{
    partial class xfrmFinManDocPreliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmFinManDocPreliminar));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.lblReferencia1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia1 = new DevExpress.XtraEditors.TextEdit();
            this.btnExtraer = new DevExpress.XtraEditors.SimpleButton();
            this.butExaminar = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new DevExpress.XtraEditors.TextEdit();
            this.lblReferencia2 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia2 = new DevExpress.XtraEditors.TextEdit();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCueCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetReferencia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetReferencia2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCcoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCcoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSapNumero = new DevExpress.XtraEditors.TextEdit();
            this.btnExtraerDepreciacion = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Size = new System.Drawing.Size(996, 46);
            this.panel1.TabIndex = 7;
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
            this.txtCodigo.TabIndex = 634;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
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
            this.txtCodSerie.TabIndex = 632;
            this.txtCodSerie.TabStop = false;
            this.txtCodSerie.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Enabled = false;
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(899, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(69, 22);
            this.txtNumero.TabIndex = 631;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Location = new System.Drawing.Point(830, 12);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Size = new System.Drawing.Size(69, 22);
            this.txtNomSerie.TabIndex = 630;
            // 
            // lblReferencia1
            // 
            this.lblReferencia1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia1.Appearance.Options.UseFont = true;
            this.lblReferencia1.Location = new System.Drawing.Point(25, 60);
            this.lblReferencia1.Name = "lblReferencia1";
            this.lblReferencia1.Size = new System.Drawing.Size(62, 15);
            this.lblReferencia1.TabIndex = 629;
            this.lblReferencia1.Text = "Referencia 1:";
            // 
            // txtReferencia1
            // 
            this.txtReferencia1.EditValue = "";
            this.txtReferencia1.EnterMoveNextControl = true;
            this.txtReferencia1.Location = new System.Drawing.Point(114, 57);
            this.txtReferencia1.Name = "txtReferencia1";
            this.txtReferencia1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia1.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtReferencia1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia1.Size = new System.Drawing.Size(378, 22);
            this.txtReferencia1.TabIndex = 2;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Appearance.Options.UseFont = true;
            this.btnExtraer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraer.ImageOptions.Image")));
            this.btnExtraer.Location = new System.Drawing.Point(497, 107);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(152, 26);
            this.btnExtraer.TabIndex = 5;
            this.btnExtraer.Text = "&Extraer asiento contable";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // butExaminar
            // 
            this.butExaminar.Location = new System.Drawing.Point(114, 112);
            this.butExaminar.Name = "butExaminar";
            this.butExaminar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExaminar.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.butExaminar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.butExaminar.Size = new System.Drawing.Size(377, 22);
            this.butExaminar.TabIndex = 4;
            this.butExaminar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.butExaminar_ButtonClick);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(25, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 15);
            this.labelControl8.TabIndex = 628;
            this.labelControl8.Text = "Ruta Excel:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(206, 12);
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
            this.datFecha.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(114, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 15);
            this.labelControl3.TabIndex = 625;
            this.labelControl3.Text = "Fecha documento:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(798, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 624;
            this.labelControl4.Text = "Serie:";
            // 
            // lblComentario
            // 
            this.lblComentario.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Appearance.Options.UseFont = true;
            this.lblComentario.Location = new System.Drawing.Point(25, 38);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(59, 15);
            this.lblComentario.TabIndex = 636;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.EditValue = "";
            this.txtComentario.EnterMoveNextControl = true;
            this.txtComentario.Location = new System.Drawing.Point(114, 35);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Properties.Appearance.Options.UseFont = true;
            this.txtComentario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtComentario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Size = new System.Drawing.Size(378, 22);
            this.txtComentario.TabIndex = 1;
            // 
            // lblReferencia2
            // 
            this.lblReferencia2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia2.Appearance.Options.UseFont = true;
            this.lblReferencia2.Location = new System.Drawing.Point(25, 82);
            this.lblReferencia2.Name = "lblReferencia2";
            this.lblReferencia2.Size = new System.Drawing.Size(62, 15);
            this.lblReferencia2.TabIndex = 638;
            this.lblReferencia2.Text = "Referencia 2:";
            // 
            // txtReferencia2
            // 
            this.txtReferencia2.EditValue = "";
            this.txtReferencia2.EnterMoveNextControl = true;
            this.txtReferencia2.Location = new System.Drawing.Point(114, 79);
            this.txtReferencia2.Name = "txtReferencia2";
            this.txtReferencia2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia2.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtReferencia2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia2.Size = new System.Drawing.Size(378, 22);
            this.txtReferencia2.TabIndex = 3;
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(25, 145);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.Size = new System.Drawing.Size(942, 469);
            this.grcListado.TabIndex = 6;
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
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvListado.Appearance.FocusedRow.Options.UseFont = true;
            this.grvListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colCueFormato,
            this.colCueNombre,
            this.colDetComentario,
            this.colDetHaber,
            this.colDetDebe,
            this.colCueCodigo,
            this.colDetReferencia1,
            this.colDetReferencia2,
            this.colCcoCodigo,
            this.colCcoNombre});
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
            // colCueFormato
            // 
            this.colCueFormato.Caption = "CtaContable";
            this.colCueFormato.FieldName = "CueFormato";
            this.colCueFormato.Name = "colCueFormato";
            this.colCueFormato.Visible = true;
            this.colCueFormato.VisibleIndex = 1;
            this.colCueFormato.Width = 100;
            // 
            // colCueNombre
            // 
            this.colCueNombre.Caption = "Descripcion";
            this.colCueNombre.FieldName = "CueNombre";
            this.colCueNombre.Name = "colCueNombre";
            this.colCueNombre.OptionsColumn.AllowEdit = false;
            this.colCueNombre.OptionsColumn.TabStop = false;
            this.colCueNombre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CueNombre", "TOTALES:")});
            this.colCueNombre.Visible = true;
            this.colCueNombre.VisibleIndex = 2;
            this.colCueNombre.Width = 320;
            // 
            // colDetComentario
            // 
            this.colDetComentario.Caption = "Comentario";
            this.colDetComentario.FieldName = "DetComentario";
            this.colDetComentario.Name = "colDetComentario";
            this.colDetComentario.OptionsColumn.AllowEdit = false;
            this.colDetComentario.OptionsColumn.TabStop = false;
            this.colDetComentario.Visible = true;
            this.colDetComentario.VisibleIndex = 7;
            this.colDetComentario.Width = 250;
            // 
            // colDetHaber
            // 
            this.colDetHaber.Caption = "Haber";
            this.colDetHaber.DisplayFormat.FormatString = "{0:0.00}";
            this.colDetHaber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetHaber.FieldName = "DetHaber";
            this.colDetHaber.Name = "colDetHaber";
            this.colDetHaber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DetHaber", "{0:0.00}")});
            this.colDetHaber.Visible = true;
            this.colDetHaber.VisibleIndex = 4;
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
            this.colDetDebe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DetDebe", "{0:0.00}")});
            this.colDetDebe.Visible = true;
            this.colDetDebe.VisibleIndex = 3;
            this.colDetDebe.Width = 100;
            // 
            // colCueCodigo
            // 
            this.colCueCodigo.Caption = "Codigo";
            this.colCueCodigo.FieldName = "CueCodigo";
            this.colCueCodigo.Name = "colCueCodigo";
            // 
            // colDetReferencia1
            // 
            this.colDetReferencia1.Caption = "Referencia1";
            this.colDetReferencia1.FieldName = "DetReferencia1";
            this.colDetReferencia1.Name = "colDetReferencia1";
            this.colDetReferencia1.Visible = true;
            this.colDetReferencia1.VisibleIndex = 8;
            this.colDetReferencia1.Width = 100;
            // 
            // colDetReferencia2
            // 
            this.colDetReferencia2.Caption = "Referencia2";
            this.colDetReferencia2.FieldName = "DetReferencia2";
            this.colDetReferencia2.Name = "colDetReferencia2";
            this.colDetReferencia2.Visible = true;
            this.colDetReferencia2.VisibleIndex = 9;
            this.colDetReferencia2.Width = 100;
            // 
            // colCcoCodigo
            // 
            this.colCcoCodigo.Caption = "CenCosto";
            this.colCcoCodigo.FieldName = "CcoCodigo";
            this.colCcoCodigo.Name = "colCcoCodigo";
            this.colCcoCodigo.Visible = true;
            this.colCcoCodigo.VisibleIndex = 5;
            // 
            // colCcoNombre
            // 
            this.colCcoNombre.Caption = "Nombre";
            this.colCcoNombre.FieldName = "CcoNombre";
            this.colCcoNombre.Name = "colCcoNombre";
            this.colCcoNombre.Visible = true;
            this.colCcoNombre.VisibleIndex = 6;
            this.colCcoNombre.Width = 200;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(777, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 15);
            this.labelControl2.TabIndex = 665;
            this.labelControl2.Text = "Nro SAP:";
            // 
            // txtSapNumero
            // 
            this.txtSapNumero.EditValue = "";
            this.txtSapNumero.Enabled = false;
            this.txtSapNumero.EnterMoveNextControl = true;
            this.txtSapNumero.Location = new System.Drawing.Point(899, 35);
            this.txtSapNumero.Name = "txtSapNumero";
            this.txtSapNumero.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtSapNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSapNumero.Properties.Appearance.Options.UseBackColor = true;
            this.txtSapNumero.Properties.Appearance.Options.UseFont = true;
            this.txtSapNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSapNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSapNumero.Properties.AutoHeight = false;
            this.txtSapNumero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtSapNumero.Properties.Mask.EditMask = "f0";
            this.txtSapNumero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSapNumero.Size = new System.Drawing.Size(70, 22);
            this.txtSapNumero.TabIndex = 664;
            this.txtSapNumero.TabStop = false;
            // 
            // btnExtraerDepreciacion
            // 
            this.btnExtraerDepreciacion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraerDepreciacion.Appearance.Options.UseFont = true;
            this.btnExtraerDepreciacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraerDepreciacion.ImageOptions.Image")));
            this.btnExtraerDepreciacion.Location = new System.Drawing.Point(655, 107);
            this.btnExtraerDepreciacion.Name = "btnExtraerDepreciacion";
            this.btnExtraerDepreciacion.Size = new System.Drawing.Size(146, 26);
            this.btnExtraerDepreciacion.TabIndex = 666;
            this.btnExtraerDepreciacion.Text = "&Extraer depreciaciones";
            this.btnExtraerDepreciacion.Click += new System.EventHandler(this.btnExtraerDepreciacion_Click);
            // 
            // xfrmFinManDocPreliminar
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(996, 666);
            this.Controls.Add(this.btnExtraerDepreciacion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSapNumero);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.lblReferencia2);
            this.Controls.Add(this.txtReferencia2);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.lblReferencia1);
            this.Controls.Add(this.txtReferencia1);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.butExaminar);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Name = "xfrmFinManDocPreliminar";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.labelControl8, 0);
            this.Controls.SetChildIndex(this.butExaminar, 0);
            this.Controls.SetChildIndex(this.btnExtraer, 0);
            this.Controls.SetChildIndex(this.txtReferencia1, 0);
            this.Controls.SetChildIndex(this.lblReferencia1, 0);
            this.Controls.SetChildIndex(this.txtNomSerie, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodSerie, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtComentario, 0);
            this.Controls.SetChildIndex(this.lblComentario, 0);
            this.Controls.SetChildIndex(this.txtReferencia2, 0);
            this.Controls.SetChildIndex(this.lblReferencia2, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.txtSapNumero, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.btnExtraerDepreciacion, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butExaminar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl lblReferencia1;
        private DevExpress.XtraEditors.TextEdit txtReferencia1;
        public DevExpress.XtraEditors.SimpleButton btnExtraer;
        private DevExpress.XtraEditors.ButtonEdit butExaminar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblComentario;
        private DevExpress.XtraEditors.TextEdit txtComentario;
        private DevExpress.XtraEditors.LabelControl lblReferencia2;
        private DevExpress.XtraEditors.TextEdit txtReferencia2;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCueFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colCueNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDetComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colDetHaber;
        private DevExpress.XtraGrid.Columns.GridColumn colDetDebe;
        private DevExpress.XtraGrid.Columns.GridColumn colCueCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetReferencia1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraGrid.Columns.GridColumn colDetReferencia2;
        private DevExpress.XtraGrid.Columns.GridColumn colCcoCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCcoNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSapNumero;
        public DevExpress.XtraEditors.SimpleButton btnExtraerDepreciacion;
    }
}
