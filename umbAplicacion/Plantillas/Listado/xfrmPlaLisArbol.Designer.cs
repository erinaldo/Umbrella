namespace umbAplicacion.Plantillas.Listado
{
    partial class xfrmPlaLisArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmPlaLisArbol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.treListado = new DevExpress.XtraTreeList.TreeList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(820, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Ce&rrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Appearance.Options.UseFont = true;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(703, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 32);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(241, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(125, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 32);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(8, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 32);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // treListado
            // 
            this.treListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.treListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Empty.Options.UseFont = true;
            this.treListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.EvenRow.Options.UseFont = true;
            this.treListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FilterPanel.Options.UseFont = true;
            this.treListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FixedLine.Options.UseFont = true;
            this.treListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FocusedCell.Options.UseFont = true;
            this.treListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FocusedRow.Options.UseFont = true;
            this.treListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.FooterPanel.Options.UseFont = true;
            this.treListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.GroupButton.Options.UseFont = true;
            this.treListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.GroupFooter.Options.UseFont = true;
            this.treListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.treListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.treListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.HorzLine.Options.UseFont = true;
            this.treListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.OddRow.Options.UseFont = true;
            this.treListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Preview.Options.UseFont = true;
            this.treListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.Row.Options.UseFont = true;
            this.treListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.SelectedRow.Options.UseFont = true;
            this.treListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.treListado.Appearance.VertLine.Options.UseFont = true;
            this.treListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treListado.Location = new System.Drawing.Point(0, 0);
            this.treListado.Name = "treListado";
            this.treListado.OptionsBehavior.Editable = false;
            this.treListado.OptionsBehavior.EnableFiltering = true;
            this.treListado.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treListado.OptionsMenu.ShowAutoFilterRowItem = false;
            this.treListado.OptionsView.AutoWidth = false;
            this.treListado.OptionsView.ShowAutoFilterRow = true;
            this.treListado.OptionsView.ShowCheckBoxes = true;
            this.treListado.Size = new System.Drawing.Size(940, 592);
            this.treListado.TabIndex = 1;
            this.treListado.DoubleClick += new System.EventHandler(this.treListado_DoubleClick);
            // 
            // xfrmPlaLisArbol
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 638);
            this.Controls.Add(this.treListado);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "xfrmPlaLisArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfrmPlaLisArbol";
            this.Load += new System.EventHandler(this.xfrmPlaLisArbol_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmPlaLisArbol_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btnNuevo;
        public DevExpress.XtraEditors.SimpleButton btnEliminar;
        public DevExpress.XtraEditors.SimpleButton btnModificar;
        public DevExpress.XtraEditors.SimpleButton btnCerrar;
        public DevExpress.XtraEditors.SimpleButton btnConsultar;
        public DevExpress.XtraTreeList.TreeList treListado;
    }
}