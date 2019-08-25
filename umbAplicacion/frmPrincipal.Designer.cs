namespace umbAplicacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.imgMenu = new DevExpress.Utils.ImageCollection(this.components);
            this.tabmdi1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.acoMain = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.lblSistema = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabmdi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acoMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.Images.SetKeyName(0, "imgSettings16.png");
            this.imgMenu.Images.SetKeyName(1, "imgGranja16.png");
            this.imgMenu.Images.SetKeyName(2, "imgProduccion16.png");
            this.imgMenu.Images.SetKeyName(3, "imgCosto16.png");
            this.imgMenu.Images.SetKeyName(4, "imgBancos16.png");
            this.imgMenu.Images.SetKeyName(5, "imgFinanzas16.png");
            this.imgMenu.Images.SetKeyName(6, "imgLogistica16.png");
            this.imgMenu.Images.SetKeyName(7, "imgCompra16.png");
            this.imgMenu.Images.SetKeyName(8, "imgInventario16.png");
            // 
            // tabmdi1
            // 
            this.tabmdi1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.True;
            this.tabmdi1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tabmdi1.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabmdi1.Appearance.Options.UseFont = true;
            this.tabmdi1.AppearancePage.Header.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabmdi1.AppearancePage.Header.ForeColor = System.Drawing.Color.Gray;
            this.tabmdi1.AppearancePage.Header.Options.UseFont = true;
            this.tabmdi1.AppearancePage.Header.Options.UseForeColor = true;
            this.tabmdi1.AppearancePage.HeaderActive.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabmdi1.AppearancePage.HeaderActive.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tabmdi1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tabmdi1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.tabmdi1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tabmdi1.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.tabmdi1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tabmdi1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.tabmdi1.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tabmdi1.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.tabmdi1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tabmdi1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.tabmdi1.AppearancePage.PageClient.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tabmdi1.AppearancePage.PageClient.Options.UseFont = true;
            this.tabmdi1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.tabmdi1.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.OnMouseUp;
            this.tabmdi1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.tabmdi1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.tabmdi1.MdiParent = this;
            this.tabmdi1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.tabmdi1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.True;
            // 
            // acoMain
            // 
            this.acoMain.Appearance.AccordionControl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.AccordionControl.Options.UseBackColor = true;
            this.acoMain.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.acoMain.Appearance.AccordionControl.Options.UseFont = true;
            this.acoMain.Appearance.Group.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Disabled.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Disabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Disabled.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Group.Disabled.Options.UseBackColor = true;
            this.acoMain.Appearance.Group.Disabled.Options.UseBorderColor = true;
            this.acoMain.Appearance.Group.Disabled.Options.UseFont = true;
            this.acoMain.Appearance.Group.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Hovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Hovered.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Group.Hovered.Options.UseBackColor = true;
            this.acoMain.Appearance.Group.Hovered.Options.UseBorderColor = true;
            this.acoMain.Appearance.Group.Hovered.Options.UseFont = true;
            this.acoMain.Appearance.Group.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Group.Normal.ForeColor = System.Drawing.Color.Black;
            this.acoMain.Appearance.Group.Normal.Options.UseBackColor = true;
            this.acoMain.Appearance.Group.Normal.Options.UseBorderColor = true;
            this.acoMain.Appearance.Group.Normal.Options.UseFont = true;
            this.acoMain.Appearance.Group.Normal.Options.UseForeColor = true;
            this.acoMain.Appearance.Group.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Pressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Pressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Group.Pressed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Group.Pressed.Options.UseBackColor = true;
            this.acoMain.Appearance.Group.Pressed.Options.UseBorderColor = true;
            this.acoMain.Appearance.Group.Pressed.Options.UseFont = true;
            this.acoMain.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Hint.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Hint.Options.UseBackColor = true;
            this.acoMain.Appearance.Hint.Options.UseFont = true;
            this.acoMain.Appearance.Item.Disabled.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Item.Disabled.Options.UseFont = true;
            this.acoMain.Appearance.Item.Hovered.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Item.Hovered.Options.UseFont = true;
            this.acoMain.Appearance.Item.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.Item.Normal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Item.Normal.Options.UseBackColor = true;
            this.acoMain.Appearance.Item.Normal.Options.UseFont = true;
            this.acoMain.Appearance.Item.Pressed.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.Item.Pressed.Options.UseFont = true;
            this.acoMain.Appearance.ItemWithContainer.Disabled.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.ItemWithContainer.Disabled.Options.UseFont = true;
            this.acoMain.Appearance.ItemWithContainer.Hovered.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.ItemWithContainer.Hovered.Options.UseFont = true;
            this.acoMain.Appearance.ItemWithContainer.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.acoMain.Appearance.ItemWithContainer.Normal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.ItemWithContainer.Normal.Options.UseBackColor = true;
            this.acoMain.Appearance.ItemWithContainer.Normal.Options.UseFont = true;
            this.acoMain.Appearance.ItemWithContainer.Pressed.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acoMain.Appearance.ItemWithContainer.Pressed.Options.UseFont = true;
            this.acoMain.ContextButtonsOptions.DisabledStateOpacity = 0F;
            this.acoMain.ContextButtonsOptions.NormalStateOpacity = 1F;
            this.acoMain.DistanceBetweenRootGroups = 0;
            this.acoMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acoMain.Images = this.imgMenu;
            this.acoMain.Location = new System.Drawing.Point(0, 0);
            this.acoMain.Name = "acoMain";
            this.acoMain.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.acoMain.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.acoMain.Size = new System.Drawing.Size(257, 374);
            this.acoMain.TabIndex = 12;
            this.acoMain.Text = "Menú";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.lblSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 33);
            this.panel1.TabIndex = 13;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(364, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(86, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "[Manager]";
            this.lblUsuario.Visible = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEmpresa.Location = new System.Drawing.Point(165, 3);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(193, 23);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "[Italimentos Cia. Ltda.]";
            this.lblEmpresa.Visible = false;
            // 
            // lblSistema
            // 
            this.lblSistema.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSistema.Location = new System.Drawing.Point(3, 3);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(156, 23);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "[Umbrella System]";
            this.lblSistema.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.acoMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(20, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 374);
            this.panel2.TabIndex = 14;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Granja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabmdi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acoMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imgMenu;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabmdi1;
        private DevExpress.XtraBars.Navigation.AccordionControl acoMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblSistema;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
    }
}

