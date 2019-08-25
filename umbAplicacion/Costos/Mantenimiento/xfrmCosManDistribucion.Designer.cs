namespace umbAplicacion.Costos.Mantenimiento
{
    partial class xfrmCosManDistribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmCosManDistribucion));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colDetPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSapNumero = new DevExpress.XtraEditors.TextEdit();
            this.lblReferencia2 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia2 = new DevExpress.XtraEditors.TextEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.txtComentario = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.lblReferencia1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia1 = new DevExpress.XtraEditors.TextEdit();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.datFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaDesde = new DevExpress.XtraEditors.LabelControl();
            this.datFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaHasta = new DevExpress.XtraEditors.LabelControl();
            this.btnExtraer = new DevExpress.XtraEditors.SimpleButton();
            this.grcDetDistribucion = new DevExpress.XtraGrid.GridControl();
            this.grvDetDistribucion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDetSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCccFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCccNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCccCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCcoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCcoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::umbAplicacion.Costos.Mantenimiento.xfrmCosProgress), true, true);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetDistribucion)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 652);
            this.panel1.Size = new System.Drawing.Size(1204, 46);
            // 
            // colDetPorcentaje
            // 
            this.colDetPorcentaje.AppearanceHeader.Options.UseTextOptions = true;
            this.colDetPorcentaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetPorcentaje.Caption = "%";
            this.colDetPorcentaje.FieldName = "DetPorcentaje";
            this.colDetPorcentaje.Name = "colDetPorcentaje";
            this.colDetPorcentaje.OptionsColumn.AllowEdit = false;
            this.colDetPorcentaje.OptionsColumn.TabStop = false;
            this.colDetPorcentaje.Visible = true;
            this.colDetPorcentaje.VisibleIndex = 7;
            this.colDetPorcentaje.Width = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(974, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 15);
            this.labelControl2.TabIndex = 680;
            this.labelControl2.Text = "Nro SAP:";
            // 
            // txtSapNumero
            // 
            this.txtSapNumero.EditValue = "";
            this.txtSapNumero.Enabled = false;
            this.txtSapNumero.EnterMoveNextControl = true;
            this.txtSapNumero.Location = new System.Drawing.Point(1097, 102);
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
            this.txtSapNumero.Properties.ReadOnly = true;
            this.txtSapNumero.Size = new System.Drawing.Size(70, 22);
            this.txtSapNumero.TabIndex = 679;
            this.txtSapNumero.TabStop = false;
            // 
            // lblReferencia2
            // 
            this.lblReferencia2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia2.Appearance.Options.UseFont = true;
            this.lblReferencia2.Location = new System.Drawing.Point(28, 151);
            this.lblReferencia2.Name = "lblReferencia2";
            this.lblReferencia2.Size = new System.Drawing.Size(62, 15);
            this.lblReferencia2.TabIndex = 678;
            this.lblReferencia2.Text = "Referencia 2:";
            // 
            // txtReferencia2
            // 
            this.txtReferencia2.EditValue = "";
            this.txtReferencia2.EnterMoveNextControl = true;
            this.txtReferencia2.Location = new System.Drawing.Point(117, 148);
            this.txtReferencia2.Name = "txtReferencia2";
            this.txtReferencia2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia2.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtReferencia2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia2.Size = new System.Drawing.Size(359, 22);
            this.txtReferencia2.TabIndex = 669;
            // 
            // lblComentario
            // 
            this.lblComentario.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Appearance.Options.UseFont = true;
            this.lblComentario.Location = new System.Drawing.Point(28, 105);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(59, 15);
            this.lblComentario.TabIndex = 677;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.EditValue = "";
            this.txtComentario.EnterMoveNextControl = true;
            this.txtComentario.Location = new System.Drawing.Point(117, 102);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Properties.Appearance.Options.UseFont = true;
            this.txtComentario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtComentario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Size = new System.Drawing.Size(359, 22);
            this.txtComentario.TabIndex = 667;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(906, 101);
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
            this.txtCodigo.TabIndex = 676;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.EditValue = "";
            this.txtCodSerie.EnterMoveNextControl = true;
            this.txtCodSerie.Location = new System.Drawing.Point(906, 78);
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
            this.txtCodSerie.TabIndex = 675;
            this.txtCodSerie.TabStop = false;
            this.txtCodSerie.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Enabled = false;
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(1097, 78);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(69, 22);
            this.txtNumero.TabIndex = 674;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Enabled = false;
            this.txtNomSerie.Location = new System.Drawing.Point(1027, 78);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Properties.ReadOnly = true;
            this.txtNomSerie.Size = new System.Drawing.Size(69, 22);
            this.txtNomSerie.TabIndex = 673;
            // 
            // lblReferencia1
            // 
            this.lblReferencia1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia1.Appearance.Options.UseFont = true;
            this.lblReferencia1.Location = new System.Drawing.Point(28, 128);
            this.lblReferencia1.Name = "lblReferencia1";
            this.lblReferencia1.Size = new System.Drawing.Size(62, 15);
            this.lblReferencia1.TabIndex = 672;
            this.lblReferencia1.Text = "Referencia 1:";
            // 
            // txtReferencia1
            // 
            this.txtReferencia1.EditValue = "";
            this.txtReferencia1.EnterMoveNextControl = true;
            this.txtReferencia1.Location = new System.Drawing.Point(117, 125);
            this.txtReferencia1.Name = "txtReferencia1";
            this.txtReferencia1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia1.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtReferencia1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia1.Size = new System.Drawing.Size(359, 22);
            this.txtReferencia1.TabIndex = 668;
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(209, 78);
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
            this.datFecha.TabIndex = 666;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(117, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 15);
            this.labelControl3.TabIndex = 671;
            this.labelControl3.Text = "Fecha documento:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(995, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 670;
            this.labelControl4.Text = "Serie:";
            // 
            // datFechaDesde
            // 
            this.datFechaDesde.EditValue = null;
            this.datFechaDesde.Location = new System.Drawing.Point(209, 12);
            this.datFechaDesde.Name = "datFechaDesde";
            this.datFechaDesde.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFechaDesde.Properties.Appearance.Options.UseFont = true;
            this.datFechaDesde.Properties.AutoHeight = false;
            this.datFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFechaDesde.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFechaDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFechaDesde.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFechaDesde.Size = new System.Drawing.Size(101, 22);
            this.datFechaDesde.TabIndex = 681;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Appearance.Options.UseFont = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(117, 15);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(61, 15);
            this.lblFechaDesde.TabIndex = 682;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // datFechaHasta
            // 
            this.datFechaHasta.EditValue = null;
            this.datFechaHasta.Location = new System.Drawing.Point(209, 36);
            this.datFechaHasta.Name = "datFechaHasta";
            this.datFechaHasta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFechaHasta.Properties.Appearance.Options.UseFont = true;
            this.datFechaHasta.Properties.AutoHeight = false;
            this.datFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFechaHasta.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFechaHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFechaHasta.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFechaHasta.Size = new System.Drawing.Size(101, 22);
            this.datFechaHasta.TabIndex = 683;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Appearance.Options.UseFont = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(117, 39);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(59, 15);
            this.lblFechaHasta.TabIndex = 684;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Appearance.Options.UseFont = true;
            this.btnExtraer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExtraer.ImageOptions.Image")));
            this.btnExtraer.Location = new System.Drawing.Point(316, 33);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(160, 26);
            this.btnExtraer.TabIndex = 685;
            this.btnExtraer.Text = "&Extraer asiento contable";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // grcDetDistribucion
            // 
            this.grcDetDistribucion.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcDetDistribucion.Location = new System.Drawing.Point(7, 176);
            this.grcDetDistribucion.MainView = this.grvDetDistribucion;
            this.grcDetDistribucion.Name = "grcDetDistribucion";
            this.grcDetDistribucion.Size = new System.Drawing.Size(1191, 469);
            this.grcDetDistribucion.TabIndex = 686;
            this.grcDetDistribucion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetDistribucion});
            // 
            // grvDetDistribucion
            // 
            this.grvDetDistribucion.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.DetailTip.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.Empty.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.EvenRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.FilterPanel.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.FixedLine.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.FocusedCell.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grvDetDistribucion.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.GroupButton.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.GroupFooter.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.GroupPanel.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvDetDistribucion.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvDetDistribucion.Appearance.GroupRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.HorzLine.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.OddRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.Preview.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.Row.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.RowSeparator.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.SelectedRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.TopNewRow.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.VertLine.Options.UseFont = true;
            this.grvDetDistribucion.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvDetDistribucion.Appearance.ViewCaption.Options.UseFont = true;
            this.grvDetDistribucion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvDetDistribucion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDetSecuencia,
            this.colCccFormato,
            this.colCccNombre,
            this.colCccCodigo,
            this.colDetDebe,
            this.colDetHaber,
            this.colDetPorcentaje,
            this.colCcoCodigo,
            this.colCcoNombre});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDetPorcentaje;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "100.00";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.grvDetDistribucion.FormatRules.Add(gridFormatRule1);
            this.grvDetDistribucion.GridControl = this.grcDetDistribucion;
            this.grvDetDistribucion.Name = "grvDetDistribucion";
            this.grvDetDistribucion.OptionsCustomization.AllowColumnMoving = false;
            this.grvDetDistribucion.OptionsCustomization.AllowColumnResizing = false;
            this.grvDetDistribucion.OptionsCustomization.AllowGroup = false;
            this.grvDetDistribucion.OptionsCustomization.AllowSort = false;
            this.grvDetDistribucion.OptionsDetail.EnableMasterViewMode = false;
            this.grvDetDistribucion.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvDetDistribucion.OptionsFind.AllowFindPanel = false;
            this.grvDetDistribucion.OptionsFind.ShowClearButton = false;
            this.grvDetDistribucion.OptionsFind.ShowCloseButton = false;
            this.grvDetDistribucion.OptionsFind.ShowFindButton = false;
            this.grvDetDistribucion.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDetDistribucion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvDetDistribucion.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvDetDistribucion.OptionsView.ColumnAutoWidth = false;
            this.grvDetDistribucion.OptionsView.ShowDetailButtons = false;
            this.grvDetDistribucion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvDetDistribucion.OptionsView.ShowFooter = true;
            this.grvDetDistribucion.OptionsView.ShowGroupPanel = false;
            this.grvDetDistribucion.ViewCaption = "Productos";
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
            this.colDetSecuencia.Width = 40;
            // 
            // colCccFormato
            // 
            this.colCccFormato.Caption = "CtaContable";
            this.colCccFormato.FieldName = "CccFormato";
            this.colCccFormato.Name = "colCccFormato";
            this.colCccFormato.Visible = true;
            this.colCccFormato.VisibleIndex = 1;
            this.colCccFormato.Width = 140;
            // 
            // colCccNombre
            // 
            this.colCccNombre.Caption = "Descripción";
            this.colCccNombre.FieldName = "CccNombre";
            this.colCccNombre.Name = "colCccNombre";
            this.colCccNombre.OptionsColumn.AllowEdit = false;
            this.colCccNombre.OptionsColumn.TabStop = false;
            this.colCccNombre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CueNombre", "TOTALES:")});
            this.colCccNombre.Visible = true;
            this.colCccNombre.VisibleIndex = 2;
            this.colCccNombre.Width = 350;
            // 
            // colCccCodigo
            // 
            this.colCccCodigo.Caption = "Código";
            this.colCccCodigo.FieldName = "CccCodigo";
            this.colCccCodigo.Name = "colCccCodigo";
            // 
            // colDetDebe
            // 
            this.colDetDebe.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
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
            this.colDetDebe.Width = 110;
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
            this.colDetHaber.Width = 110;
            // 
            // colCcoCodigo
            // 
            this.colCcoCodigo.Caption = "CenCosto";
            this.colCcoCodigo.FieldName = "CcoCodigo";
            this.colCcoCodigo.Name = "colCcoCodigo";
            this.colCcoCodigo.Visible = true;
            this.colCcoCodigo.VisibleIndex = 5;
            this.colCcoCodigo.Width = 90;
            // 
            // colCcoNombre
            // 
            this.colCcoNombre.Caption = "Descripción";
            this.colCcoNombre.FieldName = "CcoNombre";
            this.colCcoNombre.Name = "colCcoNombre";
            this.colCcoNombre.Visible = true;
            this.colCcoNombre.VisibleIndex = 6;
            this.colCcoNombre.Width = 250;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // xfrmCosManDistribucion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1204, 698);
            this.Controls.Add(this.grcDetDistribucion);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.datFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.datFechaDesde);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSapNumero);
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
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Name = "xfrmCosManDistribucion";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
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
            this.Controls.SetChildIndex(this.txtSapNumero, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.lblFechaDesde, 0);
            this.Controls.SetChildIndex(this.datFechaDesde, 0);
            this.Controls.SetChildIndex(this.lblFechaHasta, 0);
            this.Controls.SetChildIndex(this.datFechaHasta, 0);
            this.Controls.SetChildIndex(this.btnExtraer, 0);
            this.Controls.SetChildIndex(this.grcDetDistribucion, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSapNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDetDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetDistribucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSapNumero;
        private DevExpress.XtraEditors.LabelControl lblReferencia2;
        private DevExpress.XtraEditors.TextEdit txtReferencia2;
        private DevExpress.XtraEditors.LabelControl lblComentario;
        private DevExpress.XtraEditors.TextEdit txtComentario;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl lblReferencia1;
        private DevExpress.XtraEditors.TextEdit txtReferencia1;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit datFechaDesde;
        private DevExpress.XtraEditors.LabelControl lblFechaDesde;
        private DevExpress.XtraEditors.DateEdit datFechaHasta;
        private DevExpress.XtraEditors.LabelControl lblFechaHasta;
        public DevExpress.XtraEditors.SimpleButton btnExtraer;
        public DevExpress.XtraGrid.GridControl grcDetDistribucion;
        public DevExpress.XtraGrid.Views.Grid.GridView grvDetDistribucion;
        private DevExpress.XtraGrid.Columns.GridColumn colDetSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCccFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colCccNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDetPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colDetHaber;
        private DevExpress.XtraGrid.Columns.GridColumn colDetDebe;
        private DevExpress.XtraGrid.Columns.GridColumn colCccCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCcoCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCcoNombre;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
