namespace umbAplicacion.Compras.Listado
{
    partial class xfrmComLisEntMercancias
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
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.impDocumento = new System.Drawing.Printing.PrintDocument();
            this.btnEnviarSAP = new DevExpress.XtraEditors.SimpleButton();
            this.colCabFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrvNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabTotNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabTotCamal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabDiferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCabTipCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcListado
            // 
            this.grcListado.Size = new System.Drawing.Size(941, 599);
            // 
            // grvListado
            // 
            this.grvListado.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvListado.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvListado.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvListado.Appearance.DetailTip.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvListado.Appearance.DetailTip.Options.UseFont = true;
            this.grvListado.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Empty.Options.UseBackColor = true;
            this.grvListado.Appearance.Empty.Options.UseFont = true;
            this.grvListado.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvListado.Appearance.EvenRow.Options.UseFont = true;
            this.grvListado.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvListado.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvListado.Appearance.FilterPanel.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.FilterPanel.Options.UseFont = true;
            this.grvListado.Appearance.FixedLine.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvListado.Appearance.FixedLine.Options.UseFont = true;
            this.grvListado.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvListado.Appearance.FocusedCell.Options.UseFont = true;
            this.grvListado.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvListado.Appearance.FocusedRow.Options.UseFont = true;
            this.grvListado.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.FooterPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupButton.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupButton.Options.UseFont = true;
            this.grvListado.Appearance.GroupFooter.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupFooter.Options.UseFont = true;
            this.grvListado.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupRow.Options.UseFont = true;
            this.grvListado.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvListado.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HorzLine.Options.UseFont = true;
            this.grvListado.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.OddRow.Options.UseBackColor = true;
            this.grvListado.Appearance.OddRow.Options.UseFont = true;
            this.grvListado.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Preview.Options.UseBackColor = true;
            this.grvListado.Appearance.Preview.Options.UseFont = true;
            this.grvListado.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Row.Options.UseBackColor = true;
            this.grvListado.Appearance.Row.Options.UseFont = true;
            this.grvListado.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvListado.Appearance.RowSeparator.Options.UseFont = true;
            this.grvListado.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvListado.Appearance.SelectedRow.Options.UseFont = true;
            this.grvListado.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvListado.Appearance.TopNewRow.Options.UseFont = true;
            this.grvListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.VertLine.Options.UseFont = true;
            this.grvListado.Appearance.ViewCaption.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvListado.Appearance.ViewCaption.Options.UseFont = true;
            this.grvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCabCodigo,
            this.colCabFecha,
            this.colDocNombre,
            this.colCabNumero,
            this.colPrvNombre,
            this.colCabTotNeto,
            this.colCabTotCamal,
            this.colCabDiferencia,
            this.colCabTipCompra,
            this.colEstCodigo});
            this.grvListado.OptionsBehavior.Editable = false;
            this.grvListado.OptionsDetail.EnableMasterViewMode = false;
            this.grvListado.OptionsFind.AlwaysVisible = true;
            this.grvListado.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvListado.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grvListado.OptionsSelection.MultiSelect = true;
            this.grvListado.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvListado.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.grvListado.OptionsView.ColumnAutoWidth = false;
            this.grvListado.OptionsView.ShowAutoFilterRow = true;
            this.grvListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Appearance.Options.UseFont = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.Location = new System.Drawing.Point(835, 6);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Appearance.Options.UseFont = true;
            this.btnConsultar.Location = new System.Drawing.Point(735, 6);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnviarSAP);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Size = new System.Drawing.Size(941, 46);
            this.panel1.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panel1.Controls.SetChildIndex(this.btnModificar, 0);
            this.panel1.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panel1.Controls.SetChildIndex(this.btnConsultar, 0);
            this.panel1.Controls.SetChildIndex(this.btnCerrar, 0);
            this.panel1.Controls.SetChildIndex(this.btnImprimir, 0);
            this.panel1.Controls.SetChildIndex(this.btnEnviarSAP, 0);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Appearance.Options.UseFont = true;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::umbAplicacion.Properties.Resources.imgImprimir16;
            this.btnImprimir.Location = new System.Drawing.Point(302, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 26);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Im&primir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // impDocumento
            // 
            this.impDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.impDocumento_PrintPage);
            // 
            // btnEnviarSAP
            // 
            this.btnEnviarSAP.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSAP.Appearance.Options.UseFont = true;
            this.btnEnviarSAP.Enabled = false;
            this.btnEnviarSAP.Image = global::umbAplicacion.Properties.Resources.imgSAP16;
            this.btnEnviarSAP.Location = new System.Drawing.Point(401, 11);
            this.btnEnviarSAP.Name = "btnEnviarSAP";
            this.btnEnviarSAP.Size = new System.Drawing.Size(93, 26);
            this.btnEnviarSAP.TabIndex = 6;
            this.btnEnviarSAP.Text = "Enviar &SAP";
            this.btnEnviarSAP.Click += new System.EventHandler(this.btnEnviarSAP_Click);
            // 
            // colCabFecha
            // 
            this.colCabFecha.Caption = "Fecha";
            this.colCabFecha.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colCabFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCabFecha.FieldName = "CabFecha";
            this.colCabFecha.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colCabFecha.Name = "colCabFecha";
            this.colCabFecha.Visible = true;
            this.colCabFecha.VisibleIndex = 1;
            this.colCabFecha.Width = 70;
            // 
            // colDocNombre
            // 
            this.colDocNombre.Caption = "Serie";
            this.colDocNombre.FieldName = "DocNombre";
            this.colDocNombre.Name = "colDocNombre";
            this.colDocNombre.Visible = true;
            this.colDocNombre.VisibleIndex = 2;
            this.colDocNombre.Width = 70;
            // 
            // colCabCodigo
            // 
            this.colCabCodigo.Caption = "Codigo";
            this.colCabCodigo.FieldName = "CabCodigo";
            this.colCabCodigo.Name = "colCabCodigo";
            // 
            // colCabNumero
            // 
            this.colCabNumero.Caption = "Numero";
            this.colCabNumero.FieldName = "CabNumero";
            this.colCabNumero.Name = "colCabNumero";
            this.colCabNumero.Visible = true;
            this.colCabNumero.VisibleIndex = 3;
            this.colCabNumero.Width = 70;
            // 
            // colPrvNombre
            // 
            this.colPrvNombre.Caption = "Proveedor";
            this.colPrvNombre.FieldName = "PrvNombre";
            this.colPrvNombre.Name = "colPrvNombre";
            this.colPrvNombre.Visible = true;
            this.colPrvNombre.VisibleIndex = 4;
            this.colPrvNombre.Width = 250;
            // 
            // colCabTotNeto
            // 
            this.colCabTotNeto.Caption = "Tot. Neto";
            this.colCabTotNeto.DisplayFormat.FormatString = "{0:0.00 kg}";
            this.colCabTotNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCabTotNeto.FieldName = "CabTotNeto";
            this.colCabTotNeto.Name = "colCabTotNeto";
            this.colCabTotNeto.Visible = true;
            this.colCabTotNeto.VisibleIndex = 5;
            this.colCabTotNeto.Width = 80;
            // 
            // colCabTotCamal
            // 
            this.colCabTotCamal.Caption = "Tot. Camal";
            this.colCabTotCamal.DisplayFormat.FormatString = "{0:0.00 kg}";
            this.colCabTotCamal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCabTotCamal.FieldName = "CabTotCamal";
            this.colCabTotCamal.Name = "colCabTotCamal";
            this.colCabTotCamal.Visible = true;
            this.colCabTotCamal.VisibleIndex = 6;
            this.colCabTotCamal.Width = 80;
            // 
            // colCabDiferencia
            // 
            this.colCabDiferencia.Caption = "Diferencia";
            this.colCabDiferencia.DisplayFormat.FormatString = "{0:0.00 kg}";
            this.colCabDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCabDiferencia.FieldName = "CabDiferencia";
            this.colCabDiferencia.Name = "colCabDiferencia";
            this.colCabDiferencia.Visible = true;
            this.colCabDiferencia.VisibleIndex = 7;
            this.colCabDiferencia.Width = 80;
            // 
            // colCabTipCompra
            // 
            this.colCabTipCompra.Caption = "Tip. Compra";
            this.colCabTipCompra.FieldName = "CabTipCompra";
            this.colCabTipCompra.Name = "colCabTipCompra";
            this.colCabTipCompra.Visible = true;
            this.colCabTipCompra.VisibleIndex = 8;
            // 
            // colEstCodigo
            // 
            this.colEstCodigo.Caption = "Est";
            this.colEstCodigo.FieldName = "EstCodigo";
            this.colEstCodigo.Name = "colEstCodigo";
            this.colEstCodigo.Width = 35;
            // 
            // xfrmComLisEntMercancias
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(941, 645);
            this.Name = "xfrmComLisEntMercancias";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grcListado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnImprimir;
        private System.Drawing.Printing.PrintDocument impDocumento;
        public DevExpress.XtraEditors.SimpleButton btnEnviarSAP;
        private DevExpress.XtraGrid.Columns.GridColumn colCabCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCabFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCabNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colPrvNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCabTotNeto;
        private DevExpress.XtraGrid.Columns.GridColumn colCabTotCamal;
        private DevExpress.XtraGrid.Columns.GridColumn colCabDiferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colCabTipCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colEstCodigo;
    }
}
