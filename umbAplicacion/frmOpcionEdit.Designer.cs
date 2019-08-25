namespace umbAplicacion
{
    partial class frmOpcionEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionEdit));
            this.lblDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboValSiNo = new System.Windows.Forms.ComboBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.cboValDiccionario = new System.Windows.Forms.ComboBox();
            this.txtValPwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pdgVal = new System.Windows.Forms.PrintDialog();
            this.csvVal = new WinValidators.CustomValidator();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(11, 15);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor actual:";
            // 
            // cboValSiNo
            // 
            this.cboValSiNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValSiNo.FormattingEnabled = true;
            this.cboValSiNo.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cboValSiNo.Location = new System.Drawing.Point(13, 76);
            this.cboValSiNo.Name = "cboValSiNo";
            this.cboValSiNo.Size = new System.Drawing.Size(121, 23);
            this.cboValSiNo.TabIndex = 2;
            this.cboValSiNo.Visible = false;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(13, 76);
            this.txtVal.MaxLength = 100;
            this.txtVal.Multiline = true;
            this.txtVal.Name = "txtVal";
            this.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVal.Size = new System.Drawing.Size(333, 59);
            this.txtVal.TabIndex = 3;
            this.txtVal.Visible = false;
            // 
            // cboValDiccionario
            // 
            this.cboValDiccionario.DisplayMember = "Descripcion";
            this.cboValDiccionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValDiccionario.FormattingEnabled = true;
            this.cboValDiccionario.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cboValDiccionario.Location = new System.Drawing.Point(12, 75);
            this.cboValDiccionario.Name = "cboValDiccionario";
            this.cboValDiccionario.Size = new System.Drawing.Size(334, 23);
            this.cboValDiccionario.TabIndex = 4;
            this.cboValDiccionario.ValueMember = "Codigo";
            this.cboValDiccionario.Visible = false;
            // 
            // txtValPwd
            // 
            this.txtValPwd.Location = new System.Drawing.Point(13, 76);
            this.txtValPwd.MaxLength = 20;
            this.txtValPwd.Name = "txtValPwd";
            this.txtValPwd.Size = new System.Drawing.Size(195, 22);
            this.txtValPwd.TabIndex = 5;
            this.txtValPwd.UseSystemPasswordChar = true;
            this.txtValPwd.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(292, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(211, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pdgVal
            // 
            this.pdgVal.UseEXDialog = true;
            // 
            // csvVal
            // 
            this.csvVal.ControlToValidate = null;
            this.csvVal.ErrorDisplayMode = WinValidators.BaseValidator.DisplayMode.Icon;
            this.csvVal.HighlightBackgroundOnError = true;
            this.csvVal.Icon = ((System.Drawing.Icon)(resources.GetObject("csvVal.Icon")));
            this.csvVal.StopAtError = false;
            this.csvVal.Validating += new WinValidators.CustomValidator.ValidatingEventHandler(this.csvVal_Validating);
            // 
            // frmOpcionEdit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(379, 198);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtValPwd);
            this.Controls.Add(this.cboValDiccionario);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.cboValSiNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesc);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpcionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmOpcionEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboValSiNo;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.ComboBox cboValDiccionario;
        private System.Windows.Forms.TextBox txtValPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PrintDialog pdgVal;
        private WinValidators.CustomValidator csvVal;
    }
}