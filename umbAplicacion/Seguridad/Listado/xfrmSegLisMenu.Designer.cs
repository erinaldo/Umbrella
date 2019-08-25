namespace umbAplicacion.Seguridad.Listado
{
    partial class xfrmSegLisMenu
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
            this.treMenCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treMenNombre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treMenPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treMenNomPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treFrmCodigo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treFrmRuta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).BeginInit();
            this.SuspendLayout();
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
            // 
            // btnConsultar
            // 
            this.btnConsultar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Appearance.Options.UseFont = true;
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
            this.treListado.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treMenCodigo,
            this.treMenNombre,
            this.treMenPadre,
            this.treMenNomPadre,
            this.treFrmCodigo,
            this.treFrmRuta});
            this.treListado.OptionsBehavior.Editable = false;
            this.treListado.OptionsBehavior.EnableFiltering = true;
            this.treListado.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.treListado.OptionsMenu.ShowAutoFilterRowItem = false;
            this.treListado.OptionsView.AutoWidth = false;
            this.treListado.OptionsView.ShowAutoFilterRow = true;
            this.treListado.OptionsView.ShowCheckBoxes = true;
            this.treListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.Never;
            this.treListado.Size = new System.Drawing.Size(805, 592);
            // 
            // treMenCodigo
            // 
            this.treMenCodigo.Caption = "Codigo";
            this.treMenCodigo.FieldName = "MenCodigo";
            this.treMenCodigo.MinWidth = 32;
            this.treMenCodigo.Name = "treMenCodigo";
            this.treMenCodigo.Width = 91;
            // 
            // treMenNombre
            // 
            this.treMenNombre.Caption = "Menu";
            this.treMenNombre.FieldName = "MenNombre";
            this.treMenNombre.MinWidth = 32;
            this.treMenNombre.Name = "treMenNombre";
            this.treMenNombre.Visible = true;
            this.treMenNombre.VisibleIndex = 0;
            this.treMenNombre.Width = 516;
            // 
            // treMenPadre
            // 
            this.treMenPadre.Caption = "Cod. Padre";
            this.treMenPadre.FieldName = "MenPadre";
            this.treMenPadre.Name = "treMenPadre";
            // 
            // treMenNomPadre
            // 
            this.treMenNomPadre.Caption = "Padre";
            this.treMenNomPadre.FieldName = "MenNomPadre";
            this.treMenNomPadre.Name = "treMenNomPadre";
            // 
            // treFrmCodigo
            // 
            this.treFrmCodigo.Caption = "Cod. Formulario";
            this.treFrmCodigo.FieldName = "FrmCodigo";
            this.treFrmCodigo.Name = "treFrmCodigo";
            // 
            // treFrmRuta
            // 
            this.treFrmRuta.Caption = "Ruta";
            this.treFrmRuta.FieldName = "FrmRuta";
            this.treFrmRuta.Name = "treFrmRuta";
            // 
            // xfrmSegLisMenu
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(805, 638);
            this.Name = "xfrmSegLisMenu";
            ((System.ComponentModel.ISupportInitialize)(this.treListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.Columns.TreeListColumn treMenCodigo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treMenNombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treMenPadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treMenNomPadre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treFrmCodigo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treFrmRuta;
    }
}
