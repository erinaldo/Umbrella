﻿namespace umbAplicacion.Etiquetas.Mantenimiento
{
    partial class xfrmEtqManNutricional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmEtqManNutricional));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.lblInformacion = new DevExpress.XtraEditors.LabelControl();
            this.memInformacion = new DevExpress.XtraEditors.MemoEdit();
            this.memRegistro = new DevExpress.XtraEditors.MemoEdit();
            this.lblRegistro = new DevExpress.XtraEditors.LabelControl();
            this.memLeyenda1 = new DevExpress.XtraEditors.MemoEdit();
            this.lblLeyenda1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.lblPeso = new DevExpress.XtraEditors.LabelControl();
            this.txtCodBarra = new DevExpress.XtraEditors.TextEdit();
            this.lblCodBarra = new DevExpress.XtraEditors.LabelControl();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEtnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtnLabelUndMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtnValorUndMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtnLabelPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtnValorPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvItemIngrediente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxAbreviatura = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtLeyenda2 = new DevExpress.XtraEditors.TextEdit();
            this.lblLeyenda2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memInformacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memLeyenda1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxAbreviatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeyenda2.Properties)).BeginInit();
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
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Size = new System.Drawing.Size(1128, 46);
            this.panel1.Controls.SetChildIndex(this.btnGrabar, 0);
            this.panel1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.simpleButton1, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "CHORIZO PAISA TIPO I GRANEL 12";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(177, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 30;
            this.txtNombre.Size = new System.Drawing.Size(224, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.ToolTip = "Máximo 30 caracteres";
            this.txtNombre.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtNombre.ToolTipTitle = "Información";
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Appearance.Options.UseForeColor = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 15);
            this.lblNombre.TabIndex = 579;
            this.lblNombre.Text = "Nombre del producto(Label 1):";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "0";
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(465, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.Mask.EditMask = "n0";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Properties.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 576;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Appearance.Options.UseForeColor = true;
            this.lblCodigo.Location = new System.Drawing.Point(422, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 15);
            this.lblCodigo.TabIndex = 578;
            this.lblCodigo.Text = "Código:";
            // 
            // lblInformacion
            // 
            this.lblInformacion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.Appearance.Options.UseFont = true;
            this.lblInformacion.Appearance.Options.UseForeColor = true;
            this.lblInformacion.Location = new System.Drawing.Point(22, 80);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(168, 15);
            this.lblInformacion.TabIndex = 581;
            this.lblInformacion.Text = "Información del producto(Label 2):";
            // 
            // memInformacion
            // 
            this.memInformacion.EditValue = resources.GetString("memInformacion.EditValue");
            this.memInformacion.Location = new System.Drawing.Point(22, 99);
            this.memInformacion.Name = "memInformacion";
            this.memInformacion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memInformacion.Properties.Appearance.Options.UseFont = true;
            this.memInformacion.Properties.MaxLength = 650;
            this.memInformacion.Size = new System.Drawing.Size(522, 104);
            this.memInformacion.TabIndex = 1;
            this.memInformacion.ToolTip = "Máximo 650 caracteres";
            this.memInformacion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.memInformacion.ToolTipTitle = "Información";
            // 
            // memRegistro
            // 
            this.memRegistro.EditValue = "\'Reg .San. 9626-ALN-0416 SEGUN NTE INEN: 1338\' + chr(13) + \'CONSÉRVESE EN REFRIGE" +
    "RACIÓN / TIEMPO MÁXIMO DE CONSUMO 15 DÍAS\' + \'ABIERTO EL EMPAQUE, CONSUMIR TODO " +
    "EL CONTENIDO\'";
            this.memRegistro.Location = new System.Drawing.Point(22, 226);
            this.memRegistro.Name = "memRegistro";
            this.memRegistro.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memRegistro.Properties.Appearance.Options.UseFont = true;
            this.memRegistro.Properties.MaxLength = 250;
            this.memRegistro.Size = new System.Drawing.Size(522, 49);
            this.memRegistro.TabIndex = 2;
            this.memRegistro.ToolTip = "Máximo 250 caracteres";
            this.memRegistro.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.memRegistro.ToolTipTitle = "Información";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblRegistro.Appearance.Options.UseFont = true;
            this.lblRegistro.Appearance.Options.UseForeColor = true;
            this.lblRegistro.Location = new System.Drawing.Point(22, 207);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(130, 15);
            this.lblRegistro.TabIndex = 583;
            this.lblRegistro.Text = "Registro sanitario(Label 3):";
            // 
            // memLeyenda1
            // 
            this.memLeyenda1.EditValue = "\'*Porcentaje de valores diarios basados en una dieta de 2000kcal. (8380kJ). Sus v" +
    "alores diarios pueden ser mayores o menores dependiendo de sus necesidades calór" +
    "icas.\'";
            this.memLeyenda1.Location = new System.Drawing.Point(22, 299);
            this.memLeyenda1.Name = "memLeyenda1";
            this.memLeyenda1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memLeyenda1.Properties.Appearance.Options.UseFont = true;
            this.memLeyenda1.Properties.MaxLength = 180;
            this.memLeyenda1.Size = new System.Drawing.Size(522, 35);
            this.memLeyenda1.TabIndex = 3;
            this.memLeyenda1.ToolTip = "Máximo 180 caracteres";
            this.memLeyenda1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.memLeyenda1.ToolTipTitle = "Información";
            // 
            // lblLeyenda1
            // 
            this.lblLeyenda1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblLeyenda1.Appearance.Options.UseFont = true;
            this.lblLeyenda1.Appearance.Options.UseForeColor = true;
            this.lblLeyenda1.Location = new System.Drawing.Point(22, 280);
            this.lblLeyenda1.Name = "lblLeyenda1";
            this.lblLeyenda1.Size = new System.Drawing.Size(96, 15);
            this.lblLeyenda1.TabIndex = 585;
            this.lblLeyenda1.Text = "Leyenda 1(Label 6):";
            // 
            // txtPeso
            // 
            this.txtPeso.EditValue = "1.36 kg";
            this.txtPeso.EnterMoveNextControl = true;
            this.txtPeso.Location = new System.Drawing.Point(161, 337);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Properties.Appearance.Options.UseFont = true;
            this.txtPeso.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPeso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPeso.Properties.AutoHeight = false;
            this.txtPeso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPeso.Properties.MaxLength = 8;
            this.txtPeso.Size = new System.Drawing.Size(87, 23);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.ToolTip = "Máximo 8 caracteres";
            this.txtPeso.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtPeso.ToolTipTitle = "Información";
            // 
            // lblPeso
            // 
            this.lblPeso.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Appearance.Options.UseFont = true;
            this.lblPeso.Appearance.Options.UseForeColor = true;
            this.lblPeso.Location = new System.Drawing.Point(22, 340);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(133, 15);
            this.lblPeso.TabIndex = 588;
            this.lblPeso.Text = "Peso del producto(Label 4):";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.EditValue = "7861153901544";
            this.txtCodBarra.EnterMoveNextControl = true;
            this.txtCodBarra.Location = new System.Drawing.Point(412, 337);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Properties.Appearance.Options.UseFont = true;
            this.txtCodBarra.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodBarra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodBarra.Properties.AutoHeight = false;
            this.txtCodBarra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodBarra.Properties.MaxLength = 13;
            this.txtCodBarra.Size = new System.Drawing.Size(133, 23);
            this.txtCodBarra.TabIndex = 5;
            this.txtCodBarra.ToolTip = "Máximo 13 caracteres";
            this.txtCodBarra.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtCodBarra.ToolTipTitle = "Información";
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarra.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblCodBarra.Appearance.Options.UseFont = true;
            this.lblCodBarra.Appearance.Options.UseForeColor = true;
            this.lblCodBarra.Location = new System.Drawing.Point(280, 340);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(126, 15);
            this.lblCodBarra.TabIndex = 590;
            this.lblCodBarra.Text = "Código de barras(Label 5):";
            // 
            // grcListado
            // 
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Location = new System.Drawing.Point(551, 15);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluItem,
            this.itxAbreviatura});
            this.grcListado.Size = new System.Drawing.Size(553, 370);
            this.grcListado.TabIndex = 7;
            this.grcListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListado});
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
            this.grvListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grvListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvListado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvListado.Appearance.FocusedCell.Options.UseFont = true;
            this.grvListado.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grvListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvListado.Appearance.OddRow.Options.UseBackColor = true;
            this.grvListado.Appearance.OddRow.Options.UseFont = true;
            this.grvListado.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvListado.Appearance.Preview.Options.UseBackColor = true;
            this.grvListado.Appearance.Preview.Options.UseFont = true;
            this.grvListado.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvListado.Appearance.Row.Options.UseBackColor = true;
            this.grvListado.Appearance.Row.Options.UseFont = true;
            this.grvListado.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvListado.Appearance.RowSeparator.Options.UseFont = true;
            this.grvListado.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grvListado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEtnDescripcion,
            this.colEtnLabelUndMedida,
            this.colEtnValorUndMedida,
            this.colEtnLabelPorcentaje,
            this.colEtnValorPorcentaje});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Navy;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[DetAbreviatura] = \'T\'  Or [DetAbreviatura] = \'TP\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseFont = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[DetAbreviatura] = \'V\'  Or [DetAbreviatura] = \'VP\'";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            formatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Appearance.Options.UseFont = true;
            formatConditionRuleExpression3.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression3.Expression = "[DetAbreviatura] = \'C\'  Or [DetAbreviatura] = \'CP\'";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "0";
            gridFormatRule4.Rule = formatConditionRuleValue1;
            this.grvListado.FormatRules.Add(gridFormatRule1);
            this.grvListado.FormatRules.Add(gridFormatRule2);
            this.grvListado.FormatRules.Add(gridFormatRule3);
            this.grvListado.FormatRules.Add(gridFormatRule4);
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
            this.grvListado.OptionsView.ShowViewCaption = true;
            this.grvListado.ViewCaption = "Información nutricional";
            // 
            // colEtnDescripcion
            // 
            this.colEtnDescripcion.Caption = "Descripcion";
            this.colEtnDescripcion.FieldName = "EtnDescripcion";
            this.colEtnDescripcion.Name = "colEtnDescripcion";
            this.colEtnDescripcion.OptionsColumn.AllowEdit = false;
            this.colEtnDescripcion.OptionsColumn.TabStop = false;
            this.colEtnDescripcion.Visible = true;
            this.colEtnDescripcion.VisibleIndex = 0;
            this.colEtnDescripcion.Width = 200;
            // 
            // colEtnLabelUndMedida
            // 
            this.colEtnLabelUndMedida.Caption = "Label(UM)";
            this.colEtnLabelUndMedida.FieldName = "EtnLabelUndMedida";
            this.colEtnLabelUndMedida.Name = "colEtnLabelUndMedida";
            this.colEtnLabelUndMedida.OptionsColumn.AllowEdit = false;
            this.colEtnLabelUndMedida.Visible = true;
            this.colEtnLabelUndMedida.VisibleIndex = 1;
            this.colEtnLabelUndMedida.Width = 70;
            // 
            // colEtnValorUndMedida
            // 
            this.colEtnValorUndMedida.Caption = "Valor(UM)";
            this.colEtnValorUndMedida.FieldName = "EtnValorUndMedida";
            this.colEtnValorUndMedida.Name = "colEtnValorUndMedida";
            this.colEtnValorUndMedida.Visible = true;
            this.colEtnValorUndMedida.VisibleIndex = 2;
            this.colEtnValorUndMedida.Width = 90;
            // 
            // colEtnLabelPorcentaje
            // 
            this.colEtnLabelPorcentaje.Caption = "Label(%)";
            this.colEtnLabelPorcentaje.FieldName = "EtnLabelPorcentaje";
            this.colEtnLabelPorcentaje.Name = "colEtnLabelPorcentaje";
            this.colEtnLabelPorcentaje.OptionsColumn.AllowEdit = false;
            this.colEtnLabelPorcentaje.Visible = true;
            this.colEtnLabelPorcentaje.VisibleIndex = 3;
            this.colEtnLabelPorcentaje.Width = 70;
            // 
            // colEtnValorPorcentaje
            // 
            this.colEtnValorPorcentaje.Caption = "Valor(%)";
            this.colEtnValorPorcentaje.FieldName = "EtnValorPorcentaje";
            this.colEtnValorPorcentaje.Name = "colEtnValorPorcentaje";
            this.colEtnValorPorcentaje.Visible = true;
            this.colEtnValorPorcentaje.VisibleIndex = 4;
            this.colEtnValorPorcentaje.Width = 70;
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
            this.gluItem.PopupView = this.igvItemIngrediente;
            this.gluItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluItem.ValueMember = "ItemCode";
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
            // txtLeyenda2
            // 
            this.txtLeyenda2.EditValue = "Requiere cocción";
            this.txtLeyenda2.EnterMoveNextControl = true;
            this.txtLeyenda2.Location = new System.Drawing.Point(161, 361);
            this.txtLeyenda2.Name = "txtLeyenda2";
            this.txtLeyenda2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyenda2.Properties.Appearance.Options.UseFont = true;
            this.txtLeyenda2.Properties.AutoHeight = false;
            this.txtLeyenda2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtLeyenda2.Properties.MaxLength = 20;
            this.txtLeyenda2.Size = new System.Drawing.Size(384, 23);
            this.txtLeyenda2.TabIndex = 6;
            this.txtLeyenda2.ToolTip = "Máximo 20 caracteres";
            this.txtLeyenda2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtLeyenda2.ToolTipTitle = "Información";
            // 
            // lblLeyenda2
            // 
            this.lblLeyenda2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblLeyenda2.Appearance.Options.UseFont = true;
            this.lblLeyenda2.Appearance.Options.UseForeColor = true;
            this.lblLeyenda2.Location = new System.Drawing.Point(22, 364);
            this.lblLeyenda2.Name = "lblLeyenda2";
            this.lblLeyenda2.Size = new System.Drawing.Size(102, 15);
            this.lblLeyenda2.TabIndex = 593;
            this.lblLeyenda2.Text = "Leyenda 2(Label 33):";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(18, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 23);
            this.lblTitulo.TabIndex = 594;
            this.lblTitulo.Text = "Etiqueta Nutricional";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.simpleButton1.Location = new System.Drawing.Point(207, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 28);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "&Visualizar";
            // 
            // xfrmEtqManNutricional
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1128, 446);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtLeyenda2);
            this.Controls.Add(this.lblLeyenda2);
            this.Controls.Add(this.grcListado);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.lblCodBarra);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.memLeyenda1);
            this.Controls.Add(this.lblLeyenda1);
            this.Controls.Add(this.memRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.memInformacion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "xfrmEtqManNutricional";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblInformacion, 0);
            this.Controls.SetChildIndex(this.memInformacion, 0);
            this.Controls.SetChildIndex(this.lblRegistro, 0);
            this.Controls.SetChildIndex(this.memRegistro, 0);
            this.Controls.SetChildIndex(this.lblLeyenda1, 0);
            this.Controls.SetChildIndex(this.memLeyenda1, 0);
            this.Controls.SetChildIndex(this.lblPeso, 0);
            this.Controls.SetChildIndex(this.txtPeso, 0);
            this.Controls.SetChildIndex(this.lblCodBarra, 0);
            this.Controls.SetChildIndex(this.txtCodBarra, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            this.Controls.SetChildIndex(this.lblLeyenda2, 0);
            this.Controls.SetChildIndex(this.txtLeyenda2, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memInformacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memLeyenda1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItemIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxAbreviatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeyenda2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.LabelControl lblInformacion;
        private DevExpress.XtraEditors.MemoEdit memInformacion;
        private DevExpress.XtraEditors.MemoEdit memRegistro;
        private DevExpress.XtraEditors.LabelControl lblRegistro;
        private DevExpress.XtraEditors.MemoEdit memLeyenda1;
        private DevExpress.XtraEditors.LabelControl lblLeyenda1;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.LabelControl lblPeso;
        private DevExpress.XtraEditors.TextEdit txtCodBarra;
        private DevExpress.XtraEditors.LabelControl lblCodBarra;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluItem;
        private DevExpress.XtraGrid.Views.Grid.GridView igvItemIngrediente;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvInvntryUom;
        private DevExpress.XtraGrid.Columns.GridColumn colEtnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEtnLabelUndMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colEtnValorPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colEtnValorUndMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colEtnLabelPorcentaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxAbreviatura;
        private DevExpress.XtraEditors.TextEdit txtLeyenda2;
        private DevExpress.XtraEditors.LabelControl lblLeyenda2;
        private System.Windows.Forms.Label lblTitulo;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
