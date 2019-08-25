namespace umbAplicacion.Granja.Auxiliar
{
    partial class xfrmGraAuxActivacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmGraAuxActivacion));
            this.datFecActivacion = new DevExpress.XtraEditors.DateEdit();
            this.lblFecActivacion = new System.Windows.Forms.Label();
            this.txtPsoFormacion = new DevExpress.XtraEditors.TextEdit();
            this.lblPsoFormacion = new System.Windows.Forms.Label();
            this.lblKg2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnActivar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.datFecActivacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecActivacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPsoFormacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // datFecActivacion
            // 
            this.datFecActivacion.EditValue = null;
            this.datFecActivacion.Location = new System.Drawing.Point(117, 19);
            this.datFecActivacion.Name = "datFecActivacion";
            this.datFecActivacion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFecActivacion.Properties.Appearance.Options.UseFont = true;
            this.datFecActivacion.Properties.AutoHeight = false;
            this.datFecActivacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFecActivacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datFecActivacion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datFecActivacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datFecActivacion.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datFecActivacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datFecActivacion.Size = new System.Drawing.Size(105, 22);
            this.datFecActivacion.TabIndex = 657;
            // 
            // lblFecActivacion
            // 
            this.lblFecActivacion.AutoSize = true;
            this.lblFecActivacion.Location = new System.Drawing.Point(27, 23);
            this.lblFecActivacion.Name = "lblFecActivacion";
            this.lblFecActivacion.Size = new System.Drawing.Size(78, 15);
            this.lblFecActivacion.TabIndex = 658;
            this.lblFecActivacion.Text = "Fec activacion:";
            // 
            // txtPsoFormacion
            // 
            this.txtPsoFormacion.Location = new System.Drawing.Point(347, 19);
            this.txtPsoFormacion.Name = "txtPsoFormacion";
            this.txtPsoFormacion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsoFormacion.Properties.Appearance.Options.UseFont = true;
            this.txtPsoFormacion.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPsoFormacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPsoFormacion.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtPsoFormacion.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtPsoFormacion.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtPsoFormacion.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtPsoFormacion.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtPsoFormacion.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtPsoFormacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPsoFormacion.Properties.Mask.EditMask = "f3";
            this.txtPsoFormacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPsoFormacion.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPsoFormacion.Size = new System.Drawing.Size(90, 22);
            this.txtPsoFormacion.TabIndex = 667;
            // 
            // lblPsoFormacion
            // 
            this.lblPsoFormacion.AutoSize = true;
            this.lblPsoFormacion.Location = new System.Drawing.Point(257, 23);
            this.lblPsoFormacion.Name = "lblPsoFormacion";
            this.lblPsoFormacion.Size = new System.Drawing.Size(84, 15);
            this.lblPsoFormacion.TabIndex = 668;
            this.lblPsoFormacion.Text = "Peso activación:";
            // 
            // lblKg2
            // 
            this.lblKg2.AutoSize = true;
            this.lblKg2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg2.Location = new System.Drawing.Point(443, 22);
            this.lblKg2.Name = "lblKg2";
            this.lblKg2.Size = new System.Drawing.Size(22, 15);
            this.lblKg2.TabIndex = 669;
            this.lblKg2.Text = "Kg";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(111, 57);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 26);
            this.simpleButton1.TabIndex = 671;
            this.simpleButton1.Text = "&Cancelar";
            // 
            // btnActivar
            // 
            this.btnActivar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Appearance.Options.UseFont = true;
            this.btnActivar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.Location = new System.Drawing.Point(12, 57);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(93, 26);
            this.btnActivar.TabIndex = 672;
            this.btnActivar.Text = "Con&firmar";
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // xfrmGraAuxActivacion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 95);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblKg2);
            this.Controls.Add(this.txtPsoFormacion);
            this.Controls.Add(this.lblPsoFormacion);
            this.Controls.Add(this.datFecActivacion);
            this.Controls.Add(this.lblFecActivacion);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "xfrmGraAuxActivacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activación del animal";
            ((System.ComponentModel.ISupportInitialize)(this.datFecActivacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFecActivacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPsoFormacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit datFecActivacion;
        private System.Windows.Forms.Label lblFecActivacion;
        private DevExpress.XtraEditors.TextEdit txtPsoFormacion;
        private System.Windows.Forms.Label lblPsoFormacion;
        private System.Windows.Forms.Label lblKg2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnActivar;
    }
}