namespace umbAplicacion.Produccion.Mantenimiento
{
    partial class xfrmProManRecurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmProManRecurso));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lueGrupo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.datFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkEvaluar = new DevExpress.XtraEditors.CheckEdit();
            this.txtNomCenCosto = new DevExpress.XtraEditors.TextEdit();
            this.bedCenCosto = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGIF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEvaluar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomCenCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedCenCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMO.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Size = new System.Drawing.Size(477, 46);
            // 
            // lueGrupo
            // 
            this.lueGrupo.Location = new System.Drawing.Point(107, 56);
            this.lueGrupo.Name = "lueGrupo";
            this.lueGrupo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueGrupo.Properties.Appearance.Options.UseFont = true;
            this.lueGrupo.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueGrupo.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueGrupo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueGrupo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueGrupo.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueGrupo.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueGrupo.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueGrupo.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueGrupo.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueGrupo.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueGrupo.Properties.AutoHeight = false;
            this.lueGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.lueGrupo.Properties.DisplayMember = "Descripcion";
            this.lueGrupo.Properties.NullText = "";
            this.lueGrupo.Properties.ValueMember = "Codigo";
            this.lueGrupo.Size = new System.Drawing.Size(193, 22);
            this.lueGrupo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(22, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 15);
            this.labelControl2.TabIndex = 610;
            this.labelControl2.Text = "Grupo:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 15);
            this.labelControl1.TabIndex = 609;
            this.labelControl1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(107, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 180;
            this.txtNombre.Size = new System.Drawing.Size(351, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(107, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Size = new System.Drawing.Size(106, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Location = new System.Drawing.Point(22, 16);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 15);
            this.labelControl12.TabIndex = 608;
            this.labelControl12.Text = "Codigo:";
            // 
            // datFecha
            // 
            this.datFecha.EditValue = null;
            this.datFecha.Location = new System.Drawing.Point(107, 99);
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
            this.datFecha.Size = new System.Drawing.Size(106, 22);
            this.datFecha.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(22, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 15);
            this.labelControl3.TabIndex = 612;
            this.labelControl3.Text = "Fecha:";
            // 
            // chkEvaluar
            // 
            this.chkEvaluar.Location = new System.Drawing.Point(230, 100);
            this.chkEvaluar.Name = "chkEvaluar";
            this.chkEvaluar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEvaluar.Properties.Appearance.Options.UseFont = true;
            this.chkEvaluar.Properties.Caption = "Evaluar por separado los gastos";
            this.chkEvaluar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkEvaluar.Size = new System.Drawing.Size(190, 19);
            this.chkEvaluar.TabIndex = 4;
            // 
            // txtNomCenCosto
            // 
            this.txtNomCenCosto.EditValue = "";
            this.txtNomCenCosto.EnterMoveNextControl = true;
            this.txtNomCenCosto.Location = new System.Drawing.Point(213, 122);
            this.txtNomCenCosto.Name = "txtNomCenCosto";
            this.txtNomCenCosto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCenCosto.Properties.Appearance.Options.UseFont = true;
            this.txtNomCenCosto.Properties.AutoHeight = false;
            this.txtNomCenCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNomCenCosto.Properties.ReadOnly = true;
            this.txtNomCenCosto.Size = new System.Drawing.Size(245, 23);
            this.txtNomCenCosto.TabIndex = 616;
            this.txtNomCenCosto.TabStop = false;
            // 
            // bedCenCosto
            // 
            this.bedCenCosto.EditValue = "";
            this.bedCenCosto.Location = new System.Drawing.Point(107, 122);
            this.bedCenCosto.Name = "bedCenCosto";
            this.bedCenCosto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedCenCosto.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedCenCosto.Properties.Appearance.Options.UseBackColor = true;
            this.bedCenCosto.Properties.Appearance.Options.UseFont = true;
            this.bedCenCosto.Properties.AutoHeight = false;
            this.bedCenCosto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bedCenCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("bedCenCosto.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.bedCenCosto.Size = new System.Drawing.Size(107, 22);
            this.bedCenCosto.TabIndex = 5;
            this.bedCenCosto.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedCenCosto_ButtonClick);
            this.bedCenCosto.EditValueChanged += new System.EventHandler(this.bedCenCosto_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(22, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 15);
            this.labelControl4.TabIndex = 617;
            this.labelControl4.Text = "Centro de costo:";
            // 
            // txtGIF
            // 
            this.txtGIF.EditValue = "0";
            this.txtGIF.EnterMoveNextControl = true;
            this.txtGIF.Location = new System.Drawing.Point(351, 145);
            this.txtGIF.Name = "txtGIF";
            this.txtGIF.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtGIF.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGIF.Properties.Appearance.Options.UseBackColor = true;
            this.txtGIF.Properties.Appearance.Options.UseFont = true;
            this.txtGIF.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGIF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGIF.Properties.AutoHeight = false;
            this.txtGIF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGIF.Properties.Mask.EditMask = "n4";
            this.txtGIF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGIF.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGIF.Properties.MaxLength = 180;
            this.txtGIF.Size = new System.Drawing.Size(107, 22);
            this.txtGIF.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(230, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 15);
            this.labelControl5.TabIndex = 621;
            this.labelControl5.Text = "Gasto de fabricacion:";
            // 
            // txtMO
            // 
            this.txtMO.EditValue = "0";
            this.txtMO.EnterMoveNextControl = true;
            this.txtMO.Location = new System.Drawing.Point(107, 144);
            this.txtMO.Name = "txtMO";
            this.txtMO.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtMO.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMO.Properties.Appearance.Options.UseBackColor = true;
            this.txtMO.Properties.Appearance.Options.UseFont = true;
            this.txtMO.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMO.Properties.AutoHeight = false;
            this.txtMO.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtMO.Properties.Mask.EditMask = "n4";
            this.txtMO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMO.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMO.Properties.MaxLength = 180;
            this.txtMO.Size = new System.Drawing.Size(107, 22);
            this.txtMO.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(22, 149);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 15);
            this.labelControl6.TabIndex = 620;
            this.labelControl6.Text = "Mano de obra:";
            // 
            // xfrmProManRecurso
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(477, 221);
            this.Controls.Add(this.txtGIF);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMO);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtNomCenCosto);
            this.Controls.Add(this.bedCenCosto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chkEvaluar);
            this.Controls.Add(this.datFecha);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lueGrupo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl12);
            this.Name = "xfrmProManRecurso";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.lueGrupo, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.datFecha, 0);
            this.Controls.SetChildIndex(this.chkEvaluar, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.bedCenCosto, 0);
            this.Controls.SetChildIndex(this.txtNomCenCosto, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtMO, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.txtGIF, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEvaluar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomCenCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedCenCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMO.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit datFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkEvaluar;
        private DevExpress.XtraEditors.TextEdit txtNomCenCosto;
        private DevExpress.XtraEditors.ButtonEdit bedCenCosto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGIF;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMO;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
