namespace umbAplicacion
{
    partial class frmOpciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgLista = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLista
            // 
            this.dtgLista.AllowUserToAddRows = false;
            this.dtgLista.AllowUserToOrderColumns = true;
            this.dtgLista.AllowUserToResizeRows = false;
            this.dtgLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colT,
            this.colD,
            this.colV,
            this.colPP,
            this.colPH,
            this.colML});
            this.dtgLista.Location = new System.Drawing.Point(12, 12);
            this.dtgLista.MultiSelect = false;
            this.dtgLista.Name = "dtgLista";
            this.dtgLista.ReadOnly = true;
            this.dtgLista.RowHeadersVisible = false;
            this.dtgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLista.Size = new System.Drawing.Size(628, 339);
            this.dtgLista.TabIndex = 0;
            this.dtgLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLista_CellDoubleClick);
            this.dtgLista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgLista_CellFormatting);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Codigo";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colT
            // 
            this.colT.DataPropertyName = "TipoDato";
            this.colT.HeaderText = "Tipo";
            this.colT.Name = "colT";
            this.colT.ReadOnly = true;
            this.colT.Visible = false;
            // 
            // colD
            // 
            this.colD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colD.DataPropertyName = "Descripcion";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colD.DefaultCellStyle = dataGridViewCellStyle1;
            this.colD.HeaderText = "Configuración";
            this.colD.Name = "colD";
            this.colD.ReadOnly = true;
            this.colD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colV
            // 
            this.colV.DataPropertyName = "Valor";
            this.colV.HeaderText = "Valor";
            this.colV.Name = "colV";
            this.colV.ReadOnly = true;
            this.colV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colV.Width = 150;
            // 
            // colPP
            // 
            this.colPP.DataPropertyName = "PosPadre";
            this.colPP.HeaderText = "PosPadre";
            this.colPP.Name = "colPP";
            this.colPP.ReadOnly = true;
            this.colPP.Visible = false;
            // 
            // colPH
            // 
            this.colPH.DataPropertyName = "PosHijo";
            this.colPH.HeaderText = "PosHijo";
            this.colPH.Name = "colPH";
            this.colPH.ReadOnly = true;
            this.colPH.Visible = false;
            // 
            // colML
            // 
            this.colML.DataPropertyName = "MaxLength";
            this.colML.HeaderText = "MaxLength";
            this.colML.Name = "colML";
            this.colML.ReadOnly = true;
            this.colML.Visible = false;
            // 
            // frmOpciones
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 363);
            this.Controls.Add(this.dtgLista);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpciones";
            this.Text = "Opciones del sistema";
            this.Load += new System.EventHandler(this.frmOpciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colML;
    }
}