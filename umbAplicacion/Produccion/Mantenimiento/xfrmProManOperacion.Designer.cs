namespace umbAplicacion.Produccion.Mantenimiento
{
    partial class xfrmProManOperacion
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lueTipo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueArea = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Size = new System.Drawing.Size(508, 46);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(50, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 15);
            this.labelControl1.TabIndex = 572;
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
            this.labelControl12.Location = new System.Drawing.Point(50, 16);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 15);
            this.labelControl12.TabIndex = 571;
            this.labelControl12.Text = "Codigo:";
            // 
            // lueTipo
            // 
            this.lueTipo.Location = new System.Drawing.Point(107, 56);
            this.lueTipo.Name = "lueTipo";
            this.lueTipo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTipo.Properties.Appearance.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueTipo.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueTipo.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueTipo.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueTipo.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueTipo.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueTipo.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueTipo.Properties.AutoHeight = false;
            this.lueTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTipo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.lueTipo.Properties.DisplayMember = "Descripcion";
            this.lueTipo.Properties.NullText = "";
            this.lueTipo.Properties.ValueMember = "Codigo";
            this.lueTipo.Size = new System.Drawing.Size(193, 22);
            this.lueTipo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(50, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 15);
            this.labelControl2.TabIndex = 573;
            this.labelControl2.Text = "Tipo:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(50, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 15);
            this.labelControl6.TabIndex = 603;
            this.labelControl6.Text = "Area:";
            // 
            // lueArea
            // 
            this.lueArea.Location = new System.Drawing.Point(107, 79);
            this.lueArea.Name = "lueArea";
            this.lueArea.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueArea.Properties.Appearance.Options.UseFont = true;
            this.lueArea.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueArea.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueArea.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueArea.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueArea.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueArea.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueArea.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueArea.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueArea.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueArea.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueArea.Properties.AutoHeight = false;
            this.lueArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueArea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.lueArea.Properties.DisplayMember = "Descripcion";
            this.lueArea.Properties.NullText = "";
            this.lueArea.Properties.ValueMember = "Codigo";
            this.lueArea.Size = new System.Drawing.Size(193, 22);
            this.lueArea.TabIndex = 3;
            // 
            // xfrmProManOperacion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(508, 159);
            this.Controls.Add(this.lueArea);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lueTipo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl12);
            this.Name = "xfrmProManOperacion";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.lueTipo, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.lueArea, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lueTipo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueArea;
    }
}
