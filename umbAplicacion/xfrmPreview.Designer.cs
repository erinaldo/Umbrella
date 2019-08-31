namespace umbAplicacion
{
    partial class xfrmPreview
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
            this.crvImpresion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvImpresion
            // 
            this.crvImpresion.ActiveViewIndex = -1;
            this.crvImpresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvImpresion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvImpresion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvImpresion.InitialFocus = CrystalDecisions.Windows.Forms.UIComponent.ToolBar;
            this.crvImpresion.Location = new System.Drawing.Point(0, 0);
            this.crvImpresion.Name = "crvImpresion";
            this.crvImpresion.ReuseParameterValuesOnRefresh = true;
            this.crvImpresion.ShowCloseButton = false;
            this.crvImpresion.ShowCopyButton = false;
            this.crvImpresion.ShowGotoPageButton = false;
            this.crvImpresion.ShowGroupTreeButton = false;
            this.crvImpresion.ShowLogo = false;
            this.crvImpresion.ShowParameterPanelButton = false;
            this.crvImpresion.ShowRefreshButton = false;
            this.crvImpresion.ShowTextSearchButton = false;
            this.crvImpresion.Size = new System.Drawing.Size(1005, 611);
            this.crvImpresion.TabIndex = 0;
            this.crvImpresion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // xfrmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 611);
            this.Controls.Add(this.crvImpresion);
            this.Name = "xfrmPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualización de impresión";
            this.Load += new System.EventHandler(this.xfrmPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvImpresion;
    }
}