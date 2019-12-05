namespace umbAplicacion.Produccion.Mantenimiento
{
    partial class xfrmProManFormulacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmProManFormulacion));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bedItem = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVariante = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.txtUndInventario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtcFormulacion = new DevExpress.XtraTab.XtraTabControl();
            this.xtpMateriales = new DevExpress.XtraTab.XtraTabPage();
            this.grcListado = new DevExpress.XtraGrid.GridControl();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.grvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDfmLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluItem = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.igvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvntryUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDfmCantidadPor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxCantidadPor = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDfmCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDfmPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxPorcentajeM = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDfmTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDfmLineaRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxEntero = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtpRuta = new DevExpress.XtraTab.XtraTabPage();
            this.grcRuta = new DevExpress.XtraGrid.GridControl();
            this.grvRuta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDfrLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOprCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluOperacion = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.grvOperacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvOppCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvOppNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvOppTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOprNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gluRecurso = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.grvRecurso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIgvRecCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIgvRecNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDfrTiempoPor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxTiempoPor = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDfrTiempo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxTiempo = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtpMermas = new DevExpress.XtraTab.XtraTabPage();
            this.grcMerma = new DevExpress.XtraGrid.GridControl();
            this.grvMerma = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDfeLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMerCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluMerma = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDfePorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itxPorcentaje = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDfeTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iluTipo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.txtUndVenta = new DevExpress.XtraEditors.TextEdit();
            this.lblUndVenta = new DevExpress.XtraEditors.LabelControl();
            this.txtPsoStdVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkProfundizar = new DevExpress.XtraEditors.CheckEdit();
            this.chkRendimiento = new DevExpress.XtraEditors.CheckEdit();
            this.lueArea = new DevExpress.XtraEditors.LookUpEdit();
            this.lblObservaciones = new DevExpress.XtraEditors.LabelControl();
            this.memObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.lueRuta = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtNomSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodSerie = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVariante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUndInventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcFormulacion)).BeginInit();
            this.xtcFormulacion.SuspendLayout();
            this.xtpMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).BeginInit();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCantidadPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxPorcentajeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxEntero)).BeginInit();
            this.xtpRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluRecurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxTiempoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxTiempo)).BeginInit();
            this.xtpMermas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcMerma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMerma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluMerma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUndVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPsoStdVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProfundizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRendimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            // 
            // btnGrabar
            // 
            this.btnGrabar.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Appearance.Options.UseFont = true;
            this.btnGrabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.Image")));
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 613);
            this.panel1.Size = new System.Drawing.Size(1029, 46);
            // 
            // bedItem
            // 
            this.bedItem.EditValue = "";
            this.bedItem.Location = new System.Drawing.Point(89, 13);
            this.bedItem.Name = "bedItem";
            this.bedItem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bedItem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedItem.Properties.Appearance.Options.UseBackColor = true;
            this.bedItem.Properties.Appearance.Options.UseFont = true;
            this.bedItem.Properties.AutoHeight = false;
            this.bedItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.bedItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bedItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bedItem.Size = new System.Drawing.Size(132, 23);
            this.bedItem.TabIndex = 0;
            this.bedItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bedItem_ButtonClick);
            this.bedItem.EditValueChanged += new System.EventHandler(this.bedItem_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 15);
            this.labelControl1.TabIndex = 522;
            this.labelControl1.Text = "Item:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 15);
            this.labelControl5.TabIndex = 559;
            this.labelControl5.Text = "Variante:";
            // 
            // cmbVariante
            // 
            this.cmbVariante.EditValue = "A";
            this.cmbVariante.Location = new System.Drawing.Point(89, 79);
            this.cmbVariante.Name = "cmbVariante";
            this.cmbVariante.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cmbVariante.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVariante.Properties.Appearance.Options.UseBackColor = true;
            this.cmbVariante.Properties.Appearance.Options.UseFont = true;
            this.cmbVariante.Properties.AutoComplete = false;
            this.cmbVariante.Properties.AutoHeight = false;
            this.cmbVariante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmbVariante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVariante.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cmbVariante.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbVariante.Size = new System.Drawing.Size(133, 23);
            this.cmbVariante.TabIndex = 3;
            this.cmbVariante.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Appearance.Options.UseFont = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(61, 15);
            this.lblDescripcion.TabIndex = 560;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtUndInventario
            // 
            this.txtUndInventario.EditValue = "";
            this.txtUndInventario.EnterMoveNextControl = true;
            this.txtUndInventario.Location = new System.Drawing.Point(865, 14);
            this.txtUndInventario.Name = "txtUndInventario";
            this.txtUndInventario.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndInventario.Properties.Appearance.Options.UseFont = true;
            this.txtUndInventario.Properties.AutoHeight = false;
            this.txtUndInventario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtUndInventario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndInventario.Properties.ReadOnly = true;
            this.txtUndInventario.Size = new System.Drawing.Size(150, 23);
            this.txtUndInventario.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(778, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 562;
            this.labelControl2.Text = "Und Inventario:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 15);
            this.labelControl4.TabIndex = 566;
            this.labelControl4.Text = "Area:";
            // 
            // xtcFormulacion
            // 
            this.xtcFormulacion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtcFormulacion.Appearance.Options.UseFont = true;
            this.xtcFormulacion.AppearancePage.Header.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtcFormulacion.AppearancePage.Header.Options.UseFont = true;
            this.xtcFormulacion.AppearancePage.Header.Options.UseTextOptions = true;
            this.xtcFormulacion.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.xtcFormulacion.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xtcFormulacion.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtcFormulacion.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xtcFormulacion.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.xtcFormulacion.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xtcFormulacion.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.xtcFormulacion.AppearancePage.PageClient.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xtcFormulacion.AppearancePage.PageClient.Options.UseFont = true;
            this.xtcFormulacion.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtcFormulacion.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtcFormulacion.Location = new System.Drawing.Point(12, 110);
            this.xtcFormulacion.Name = "xtcFormulacion";
            this.xtcFormulacion.SelectedTabPage = this.xtpMateriales;
            this.xtcFormulacion.Size = new System.Drawing.Size(1008, 446);
            this.xtcFormulacion.TabIndex = 567;
            this.xtcFormulacion.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpMateriales,
            this.xtpRuta,
            this.xtpMermas});
            this.xtcFormulacion.TabPageWidth = 120;
            // 
            // xtpMateriales
            // 
            this.xtpMateriales.Controls.Add(this.grcListado);
            this.xtpMateriales.MaxTabPageWidth = 120;
            this.xtpMateriales.Name = "xtpMateriales";
            this.xtpMateriales.Size = new System.Drawing.Size(868, 440);
            this.xtpMateriales.Text = "Lista de materiales";
            // 
            // grcListado
            // 
            this.grcListado.ContextMenuStrip = this.cmsMenu;
            this.grcListado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcListado.Location = new System.Drawing.Point(0, 0);
            this.grcListado.MainView = this.grvListado;
            this.grcListado.Name = "grcListado";
            this.grcListado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluItem,
            this.itxCantidad,
            this.itxCantidadPor,
            this.itxPorcentajeM,
            this.itxEntero});
            this.grcListado.Size = new System.Drawing.Size(868, 440);
            this.grcListado.TabIndex = 0;
            this.grcListado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListado});
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiBorrar});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(135, 26);
            // 
            // smiBorrar
            // 
            this.smiBorrar.Image = global::umbAplicacion.Properties.Resources.imgQuitar24;
            this.smiBorrar.Name = "smiBorrar";
            this.smiBorrar.Size = new System.Drawing.Size(134, 22);
            this.smiBorrar.Text = "Borrar linea";
            this.smiBorrar.Click += new System.EventHandler(this.smiBorrarToolStripMenuItem_Click);
            // 
            // grvListado
            // 
            this.grvListado.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvListado.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvListado.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvListado.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.DetailTip.Options.UseFont = true;
            this.grvListado.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Empty.Options.UseFont = true;
            this.grvListado.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.EvenRow.Options.UseFont = true;
            this.grvListado.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvListado.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FilterPanel.Options.UseFont = true;
            this.grvListado.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FixedLine.Options.UseFont = true;
            this.grvListado.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedCell.Options.UseFont = true;
            this.grvListado.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FocusedRow.Options.UseFont = true;
            this.grvListado.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.FooterPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupButton.Options.UseFont = true;
            this.grvListado.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupFooter.Options.UseFont = true;
            this.grvListado.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupPanel.Options.UseFont = true;
            this.grvListado.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvListado.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvListado.Appearance.GroupRow.Options.UseFont = true;
            this.grvListado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvListado.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvListado.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.HorzLine.Options.UseFont = true;
            this.grvListado.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.OddRow.Options.UseFont = true;
            this.grvListado.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Preview.Options.UseFont = true;
            this.grvListado.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.Row.Options.UseFont = true;
            this.grvListado.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.RowSeparator.Options.UseFont = true;
            this.grvListado.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.SelectedRow.Options.UseFont = true;
            this.grvListado.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.TopNewRow.Options.UseFont = true;
            this.grvListado.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.VertLine.Options.UseFont = true;
            this.grvListado.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvListado.Appearance.ViewCaption.Options.UseFont = true;
            this.grvListado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDfmLinea,
            this.colItemCode,
            this.colItemName,
            this.colInvntryUom,
            this.colDfmCantidadPor,
            this.colDfmCantidad,
            this.colDfmPorcentaje,
            this.colDfmTipo,
            this.colDfmLineaRuta});
            this.grvListado.GridControl = this.grcListado;
            this.grvListado.Name = "grvListado";
            this.grvListado.OptionsCustomization.AllowColumnMoving = false;
            this.grvListado.OptionsCustomization.AllowColumnResizing = false;
            this.grvListado.OptionsCustomization.AllowGroup = false;
            this.grvListado.OptionsCustomization.AllowSort = false;
            this.grvListado.OptionsDetail.EnableMasterViewMode = false;
            this.grvListado.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvListado.OptionsFind.AllowFindPanel = false;
            this.grvListado.OptionsFind.ShowClearButton = false;
            this.grvListado.OptionsFind.ShowCloseButton = false;
            this.grvListado.OptionsFind.ShowFindButton = false;
            this.grvListado.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvListado.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvListado.OptionsView.ColumnAutoWidth = false;
            this.grvListado.OptionsView.ShowDetailButtons = false;
            this.grvListado.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvListado.OptionsView.ShowFooter = true;
            this.grvListado.OptionsView.ShowGroupPanel = false;
            this.grvListado.ViewCaption = "Productos";
            this.grvListado.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.grvListado_CustomDrawFooter);
            this.grvListado.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvListado_ShowingEditor);
            // 
            // colDfmLinea
            // 
            this.colDfmLinea.Caption = "Nro";
            this.colDfmLinea.FieldName = "DfmLinea";
            this.colDfmLinea.Name = "colDfmLinea";
            this.colDfmLinea.OptionsColumn.AllowEdit = false;
            this.colDfmLinea.OptionsColumn.TabStop = false;
            this.colDfmLinea.Visible = true;
            this.colDfmLinea.VisibleIndex = 0;
            this.colDfmLinea.Width = 30;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Item";
            this.colItemCode.ColumnEdit = this.gluItem;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 80;
            // 
            // gluItem
            // 
            this.gluItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluItem.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.Appearance.Image")));
            this.gluItem.Appearance.Options.UseFont = true;
            this.gluItem.Appearance.Options.UseImage = true;
            this.gluItem.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceDisabled.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceDisabled.Image")));
            this.gluItem.AppearanceDisabled.Options.UseFont = true;
            this.gluItem.AppearanceDisabled.Options.UseImage = true;
            this.gluItem.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceDropDown.Image")));
            this.gluItem.AppearanceDropDown.Options.UseFont = true;
            this.gluItem.AppearanceDropDown.Options.UseImage = true;
            this.gluItem.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceFocused.Image")));
            this.gluItem.AppearanceFocused.Options.UseFont = true;
            this.gluItem.AppearanceFocused.Options.UseImage = true;
            this.gluItem.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluItem.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("gluItem.AppearanceReadOnly.Image")));
            this.gluItem.AppearanceReadOnly.Options.UseFont = true;
            this.gluItem.AppearanceReadOnly.Options.UseImage = true;
            this.gluItem.AutoHeight = false;
            this.gluItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gluItem.DisplayMember = "ItemCode";
            this.gluItem.Name = "gluItem";
            this.gluItem.NullText = "";
            this.gluItem.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluItem.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluItem.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluItem.PopupView = this.igvItem;
            this.gluItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluItem.ValueMember = "ItemCode";
            this.gluItem.Popup += new System.EventHandler(this.gluItem_Popup);
            this.gluItem.Leave += new System.EventHandler(this.gluItem_Leave);
            // 
            // igvItem
            // 
            this.igvItem.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.igvItem.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.igvItem.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.igvItem.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.igvItem.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.igvItem.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.igvItem.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.DetailTip.Options.UseBackColor = true;
            this.igvItem.Appearance.DetailTip.Options.UseFont = true;
            this.igvItem.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Empty.Options.UseBackColor = true;
            this.igvItem.Appearance.Empty.Options.UseFont = true;
            this.igvItem.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.EvenRow.Options.UseBackColor = true;
            this.igvItem.Appearance.EvenRow.Options.UseFont = true;
            this.igvItem.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.igvItem.Appearance.FilterCloseButton.Options.UseFont = true;
            this.igvItem.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FilterPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.FilterPanel.Options.UseFont = true;
            this.igvItem.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FixedLine.Options.UseBackColor = true;
            this.igvItem.Appearance.FixedLine.Options.UseFont = true;
            this.igvItem.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FocusedCell.Options.UseBackColor = true;
            this.igvItem.Appearance.FocusedCell.Options.UseFont = true;
            this.igvItem.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FocusedRow.Options.UseBackColor = true;
            this.igvItem.Appearance.FocusedRow.Options.UseFont = true;
            this.igvItem.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.FooterPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.igvItem.Appearance.FooterPanel.Options.UseFont = true;
            this.igvItem.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupButton.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupButton.Options.UseFont = true;
            this.igvItem.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupFooter.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupFooter.Options.UseFont = true;
            this.igvItem.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupPanel.Options.UseFont = true;
            this.igvItem.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.GroupRow.Options.UseBackColor = true;
            this.igvItem.Appearance.GroupRow.Options.UseFont = true;
            this.igvItem.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.igvItem.Appearance.HeaderPanel.Options.UseFont = true;
            this.igvItem.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.igvItem.Appearance.HideSelectionRow.Options.UseFont = true;
            this.igvItem.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.HorzLine.Options.UseFont = true;
            this.igvItem.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.OddRow.Options.UseBackColor = true;
            this.igvItem.Appearance.OddRow.Options.UseFont = true;
            this.igvItem.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Preview.Options.UseBackColor = true;
            this.igvItem.Appearance.Preview.Options.UseFont = true;
            this.igvItem.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.Row.Options.UseBackColor = true;
            this.igvItem.Appearance.Row.Options.UseFont = true;
            this.igvItem.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.RowSeparator.Options.UseBackColor = true;
            this.igvItem.Appearance.RowSeparator.Options.UseFont = true;
            this.igvItem.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.SelectedRow.Options.UseBackColor = true;
            this.igvItem.Appearance.SelectedRow.Options.UseFont = true;
            this.igvItem.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.TopNewRow.Options.UseBackColor = true;
            this.igvItem.Appearance.TopNewRow.Options.UseFont = true;
            this.igvItem.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.VertLine.Options.UseFont = true;
            this.igvItem.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.igvItem.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.igvItem.Appearance.ViewCaption.Options.UseBackColor = true;
            this.igvItem.Appearance.ViewCaption.Options.UseFont = true;
            this.igvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIgvItemCode,
            this.colIgvItemName,
            this.colIgvInvntryUom});
            this.igvItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.igvItem.Name = "igvItem";
            this.igvItem.OptionsCustomization.AllowColumnMoving = false;
            this.igvItem.OptionsCustomization.AllowColumnResizing = false;
            this.igvItem.OptionsCustomization.AllowGroup = false;
            this.igvItem.OptionsCustomization.AllowSort = false;
            this.igvItem.OptionsFind.AllowFindPanel = false;
            this.igvItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.igvItem.OptionsView.ColumnAutoWidth = false;
            this.igvItem.OptionsView.ShowAutoFilterRow = true;
            this.igvItem.OptionsView.ShowDetailButtons = false;
            this.igvItem.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.igvItem.OptionsView.ShowGroupPanel = false;
            // 
            // colIgvItemCode
            // 
            this.colIgvItemCode.Caption = "Codigo";
            this.colIgvItemCode.FieldName = "ItemCode";
            this.colIgvItemCode.Name = "colIgvItemCode";
            this.colIgvItemCode.OptionsColumn.AllowEdit = false;
            this.colIgvItemCode.Visible = true;
            this.colIgvItemCode.VisibleIndex = 0;
            this.colIgvItemCode.Width = 80;
            // 
            // colIgvItemName
            // 
            this.colIgvItemName.Caption = "Recurso";
            this.colIgvItemName.FieldName = "ItemName";
            this.colIgvItemName.Name = "colIgvItemName";
            this.colIgvItemName.OptionsColumn.AllowEdit = false;
            this.colIgvItemName.Visible = true;
            this.colIgvItemName.VisibleIndex = 1;
            this.colIgvItemName.Width = 300;
            // 
            // colIgvInvntryUom
            // 
            this.colIgvInvntryUom.Caption = "Unidad";
            this.colIgvInvntryUom.FieldName = "InvntryUom";
            this.colIgvInvntryUom.Name = "colIgvInvntryUom";
            this.colIgvInvntryUom.Visible = true;
            this.colIgvInvntryUom.VisibleIndex = 2;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Descripcion";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.TabStop = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 340;
            // 
            // colInvntryUom
            // 
            this.colInvntryUom.Caption = "Und";
            this.colInvntryUom.FieldName = "InvntryUom";
            this.colInvntryUom.Name = "colInvntryUom";
            this.colInvntryUom.OptionsColumn.AllowEdit = false;
            this.colInvntryUom.OptionsColumn.TabStop = false;
            this.colInvntryUom.Visible = true;
            this.colInvntryUom.VisibleIndex = 3;
            this.colInvntryUom.Width = 50;
            // 
            // colDfmCantidadPor
            // 
            this.colDfmCantidadPor.Caption = "Cantidad Por";
            this.colDfmCantidadPor.ColumnEdit = this.itxCantidadPor;
            this.colDfmCantidadPor.DisplayFormat.FormatString = "{0:0.00000}";
            this.colDfmCantidadPor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfmCantidadPor.FieldName = "DfmCantidadPor";
            this.colDfmCantidadPor.Name = "colDfmCantidadPor";
            this.colDfmCantidadPor.Visible = true;
            this.colDfmCantidadPor.VisibleIndex = 5;
            this.colDfmCantidadPor.Width = 100;
            // 
            // itxCantidadPor
            // 
            this.itxCantidadPor.AutoHeight = false;
            this.itxCantidadPor.Mask.EditMask = "n5";
            this.itxCantidadPor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxCantidadPor.Name = "itxCantidadPor";
            // 
            // colDfmCantidad
            // 
            this.colDfmCantidad.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDfmCantidad.AppearanceHeader.Options.UseFont = true;
            this.colDfmCantidad.Caption = "Cantidad";
            this.colDfmCantidad.ColumnEdit = this.itxCantidad;
            this.colDfmCantidad.DisplayFormat.FormatString = "{0:0.00000}";
            this.colDfmCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfmCantidad.FieldName = "DfmCantidad";
            this.colDfmCantidad.Name = "colDfmCantidad";
            this.colDfmCantidad.Visible = true;
            this.colDfmCantidad.VisibleIndex = 4;
            this.colDfmCantidad.Width = 100;
            // 
            // itxCantidad
            // 
            this.itxCantidad.AutoHeight = false;
            this.itxCantidad.Mask.EditMask = "n5";
            this.itxCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxCantidad.Name = "itxCantidad";
            this.itxCantidad.Leave += new System.EventHandler(this.itxCantidad_Leave);
            // 
            // colDfmPorcentaje
            // 
            this.colDfmPorcentaje.AppearanceHeader.Options.UseTextOptions = true;
            this.colDfmPorcentaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDfmPorcentaje.Caption = "%";
            this.colDfmPorcentaje.ColumnEdit = this.itxPorcentajeM;
            this.colDfmPorcentaje.FieldName = "DfmPorcentaje";
            this.colDfmPorcentaje.Name = "colDfmPorcentaje";
            this.colDfmPorcentaje.Visible = true;
            this.colDfmPorcentaje.VisibleIndex = 6;
            this.colDfmPorcentaje.Width = 50;
            // 
            // itxPorcentajeM
            // 
            this.itxPorcentajeM.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itxPorcentajeM.Appearance.Options.UseFont = true;
            this.itxPorcentajeM.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxPorcentajeM.AppearanceDisabled.Options.UseFont = true;
            this.itxPorcentajeM.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxPorcentajeM.AppearanceFocused.Options.UseFont = true;
            this.itxPorcentajeM.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxPorcentajeM.AppearanceReadOnly.Options.UseFont = true;
            this.itxPorcentajeM.AutoHeight = false;
            this.itxPorcentajeM.DisplayFormat.FormatString = "{0:0.00}";
            this.itxPorcentajeM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.itxPorcentajeM.Mask.EditMask = "n2";
            this.itxPorcentajeM.Name = "itxPorcentajeM";
            // 
            // colDfmTipo
            // 
            this.colDfmTipo.Caption = "Tipo";
            this.colDfmTipo.FieldName = "DfmTipo";
            this.colDfmTipo.Name = "colDfmTipo";
            // 
            // colDfmLineaRuta
            // 
            this.colDfmLineaRuta.Caption = "Ruta";
            this.colDfmLineaRuta.ColumnEdit = this.itxEntero;
            this.colDfmLineaRuta.DisplayFormat.FormatString = "0;(0); ";
            this.colDfmLineaRuta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfmLineaRuta.FieldName = "DfmLineaRuta";
            this.colDfmLineaRuta.Name = "colDfmLineaRuta";
            this.colDfmLineaRuta.Visible = true;
            this.colDfmLineaRuta.VisibleIndex = 7;
            this.colDfmLineaRuta.Width = 50;
            // 
            // itxEntero
            // 
            this.itxEntero.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxEntero.Appearance.Options.UseFont = true;
            this.itxEntero.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxEntero.AppearanceDisabled.Options.UseFont = true;
            this.itxEntero.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxEntero.AppearanceFocused.Options.UseFont = true;
            this.itxEntero.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.itxEntero.AppearanceReadOnly.Options.UseFont = true;
            this.itxEntero.AutoHeight = false;
            this.itxEntero.Mask.EditMask = "n0";
            this.itxEntero.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxEntero.Name = "itxEntero";
            // 
            // xtpRuta
            // 
            this.xtpRuta.Controls.Add(this.grcRuta);
            this.xtpRuta.MaxTabPageWidth = 120;
            this.xtpRuta.Name = "xtpRuta";
            this.xtpRuta.Size = new System.Drawing.Size(868, 440);
            this.xtpRuta.Text = "Operaciones ";
            // 
            // grcRuta
            // 
            this.grcRuta.ContextMenuStrip = this.cmsMenu;
            this.grcRuta.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcRuta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcRuta.Location = new System.Drawing.Point(0, 0);
            this.grcRuta.MainView = this.grvRuta;
            this.grcRuta.Name = "grcRuta";
            this.grcRuta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gluOperacion,
            this.itxTiempo,
            this.itxTiempoPor,
            this.gluRecurso});
            this.grcRuta.Size = new System.Drawing.Size(868, 440);
            this.grcRuta.TabIndex = 508;
            this.grcRuta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRuta});
            // 
            // grvRuta
            // 
            this.grvRuta.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvRuta.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvRuta.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvRuta.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.DetailTip.Options.UseFont = true;
            this.grvRuta.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.Empty.Options.UseFont = true;
            this.grvRuta.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.EvenRow.Options.UseFont = true;
            this.grvRuta.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvRuta.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FilterPanel.Options.UseFont = true;
            this.grvRuta.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FixedLine.Options.UseFont = true;
            this.grvRuta.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FocusedCell.Options.UseFont = true;
            this.grvRuta.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FocusedRow.Options.UseFont = true;
            this.grvRuta.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.FooterPanel.Options.UseFont = true;
            this.grvRuta.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.GroupButton.Options.UseFont = true;
            this.grvRuta.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.GroupFooter.Options.UseFont = true;
            this.grvRuta.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.GroupPanel.Options.UseFont = true;
            this.grvRuta.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvRuta.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvRuta.Appearance.GroupRow.Options.UseFont = true;
            this.grvRuta.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvRuta.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvRuta.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.HorzLine.Options.UseFont = true;
            this.grvRuta.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.OddRow.Options.UseFont = true;
            this.grvRuta.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.Preview.Options.UseFont = true;
            this.grvRuta.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.Row.Options.UseFont = true;
            this.grvRuta.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.RowSeparator.Options.UseFont = true;
            this.grvRuta.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.SelectedRow.Options.UseFont = true;
            this.grvRuta.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.TopNewRow.Options.UseFont = true;
            this.grvRuta.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.VertLine.Options.UseFont = true;
            this.grvRuta.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRuta.Appearance.ViewCaption.Options.UseFont = true;
            this.grvRuta.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvRuta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDfrLinea,
            this.colOprCodigo,
            this.colOprNombre,
            this.colRecCodigo,
            this.colRecNombre,
            this.colDfrTiempoPor,
            this.colDfrTiempo});
            this.grvRuta.GridControl = this.grcRuta;
            this.grvRuta.Name = "grvRuta";
            this.grvRuta.OptionsCustomization.AllowColumnMoving = false;
            this.grvRuta.OptionsCustomization.AllowColumnResizing = false;
            this.grvRuta.OptionsCustomization.AllowGroup = false;
            this.grvRuta.OptionsCustomization.AllowSort = false;
            this.grvRuta.OptionsDetail.EnableMasterViewMode = false;
            this.grvRuta.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvRuta.OptionsFind.AllowFindPanel = false;
            this.grvRuta.OptionsFind.ShowClearButton = false;
            this.grvRuta.OptionsFind.ShowCloseButton = false;
            this.grvRuta.OptionsFind.ShowFindButton = false;
            this.grvRuta.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvRuta.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvRuta.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvRuta.OptionsView.ColumnAutoWidth = false;
            this.grvRuta.OptionsView.ShowDetailButtons = false;
            this.grvRuta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvRuta.OptionsView.ShowFooter = true;
            this.grvRuta.OptionsView.ShowGroupPanel = false;
            this.grvRuta.ViewCaption = "Productos";
            this.grvRuta.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.grvRuta_CustomDrawFooter);
            this.grvRuta.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvRuta_ShowingEditor);
            // 
            // colDfrLinea
            // 
            this.colDfrLinea.Caption = "Nro";
            this.colDfrLinea.FieldName = "DfrLinea";
            this.colDfrLinea.Name = "colDfrLinea";
            this.colDfrLinea.OptionsColumn.AllowEdit = false;
            this.colDfrLinea.OptionsColumn.TabStop = false;
            this.colDfrLinea.Visible = true;
            this.colDfrLinea.VisibleIndex = 0;
            this.colDfrLinea.Width = 30;
            // 
            // colOprCodigo
            // 
            this.colOprCodigo.Caption = "Operacion";
            this.colOprCodigo.ColumnEdit = this.gluOperacion;
            this.colOprCodigo.FieldName = "OprCodigo";
            this.colOprCodigo.Name = "colOprCodigo";
            this.colOprCodigo.Visible = true;
            this.colOprCodigo.VisibleIndex = 1;
            this.colOprCodigo.Width = 90;
            // 
            // gluOperacion
            // 
            this.gluOperacion.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluOperacion.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gluOperacion.Appearance.Image")));
            this.gluOperacion.Appearance.Options.UseFont = true;
            this.gluOperacion.Appearance.Options.UseImage = true;
            this.gluOperacion.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluOperacion.AppearanceDisabled.Image = ((System.Drawing.Image)(resources.GetObject("gluOperacion.AppearanceDisabled.Image")));
            this.gluOperacion.AppearanceDisabled.Options.UseFont = true;
            this.gluOperacion.AppearanceDisabled.Options.UseImage = true;
            this.gluOperacion.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluOperacion.AppearanceDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gluOperacion.AppearanceDropDown.Image")));
            this.gluOperacion.AppearanceDropDown.Options.UseFont = true;
            this.gluOperacion.AppearanceDropDown.Options.UseImage = true;
            this.gluOperacion.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluOperacion.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("gluOperacion.AppearanceFocused.Image")));
            this.gluOperacion.AppearanceFocused.Options.UseFont = true;
            this.gluOperacion.AppearanceFocused.Options.UseImage = true;
            this.gluOperacion.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluOperacion.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("gluOperacion.AppearanceReadOnly.Image")));
            this.gluOperacion.AppearanceReadOnly.Options.UseFont = true;
            this.gluOperacion.AppearanceReadOnly.Options.UseImage = true;
            this.gluOperacion.AutoHeight = false;
            this.gluOperacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluOperacion.DisplayMember = "OppCodigo";
            this.gluOperacion.Name = "gluOperacion";
            this.gluOperacion.NullText = "";
            this.gluOperacion.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluOperacion.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluOperacion.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluOperacion.PopupView = this.grvOperacion;
            this.gluOperacion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluOperacion.ValueMember = "OppCodigo";
            this.gluOperacion.Popup += new System.EventHandler(this.gluOperacion_Popup);
            this.gluOperacion.Leave += new System.EventHandler(this.gluOperacion_Leave);
            // 
            // grvOperacion
            // 
            this.grvOperacion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvOperacion.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvOperacion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvOperacion.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvOperacion.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvOperacion.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvOperacion.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvOperacion.Appearance.DetailTip.Options.UseFont = true;
            this.grvOperacion.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.Empty.Options.UseBackColor = true;
            this.grvOperacion.Appearance.Empty.Options.UseFont = true;
            this.grvOperacion.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.EvenRow.Options.UseFont = true;
            this.grvOperacion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvOperacion.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FilterPanel.Options.UseFont = true;
            this.grvOperacion.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FixedLine.Options.UseFont = true;
            this.grvOperacion.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FocusedCell.Options.UseFont = true;
            this.grvOperacion.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FocusedRow.Options.UseFont = true;
            this.grvOperacion.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvOperacion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvOperacion.Appearance.FooterPanel.Options.UseFont = true;
            this.grvOperacion.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvOperacion.Appearance.GroupButton.Options.UseFont = true;
            this.grvOperacion.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvOperacion.Appearance.GroupFooter.Options.UseFont = true;
            this.grvOperacion.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvOperacion.Appearance.GroupPanel.Options.UseFont = true;
            this.grvOperacion.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.GroupRow.Options.UseFont = true;
            this.grvOperacion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvOperacion.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvOperacion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvOperacion.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.HorzLine.Options.UseFont = true;
            this.grvOperacion.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.OddRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.OddRow.Options.UseFont = true;
            this.grvOperacion.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.Preview.Options.UseBackColor = true;
            this.grvOperacion.Appearance.Preview.Options.UseFont = true;
            this.grvOperacion.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.Row.Options.UseBackColor = true;
            this.grvOperacion.Appearance.Row.Options.UseFont = true;
            this.grvOperacion.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvOperacion.Appearance.RowSeparator.Options.UseFont = true;
            this.grvOperacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.SelectedRow.Options.UseFont = true;
            this.grvOperacion.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvOperacion.Appearance.TopNewRow.Options.UseFont = true;
            this.grvOperacion.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.VertLine.Options.UseFont = true;
            this.grvOperacion.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvOperacion.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvOperacion.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvOperacion.Appearance.ViewCaption.Options.UseFont = true;
            this.grvOperacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIgvOppCodigo,
            this.colIgvOppNombre,
            this.colIgvOppTipo});
            this.grvOperacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grvOperacion.Name = "grvOperacion";
            this.grvOperacion.OptionsCustomization.AllowColumnMoving = false;
            this.grvOperacion.OptionsCustomization.AllowColumnResizing = false;
            this.grvOperacion.OptionsCustomization.AllowGroup = false;
            this.grvOperacion.OptionsCustomization.AllowSort = false;
            this.grvOperacion.OptionsFind.AllowFindPanel = false;
            this.grvOperacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvOperacion.OptionsView.ColumnAutoWidth = false;
            this.grvOperacion.OptionsView.ShowAutoFilterRow = true;
            this.grvOperacion.OptionsView.ShowDetailButtons = false;
            this.grvOperacion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvOperacion.OptionsView.ShowGroupPanel = false;
            // 
            // colIgvOppCodigo
            // 
            this.colIgvOppCodigo.Caption = "Codigo";
            this.colIgvOppCodigo.FieldName = "OppCodigo";
            this.colIgvOppCodigo.Name = "colIgvOppCodigo";
            this.colIgvOppCodigo.OptionsColumn.AllowEdit = false;
            this.colIgvOppCodigo.Visible = true;
            this.colIgvOppCodigo.VisibleIndex = 0;
            this.colIgvOppCodigo.Width = 100;
            // 
            // colIgvOppNombre
            // 
            this.colIgvOppNombre.Caption = "Operacion";
            this.colIgvOppNombre.FieldName = "OppNombre";
            this.colIgvOppNombre.Name = "colIgvOppNombre";
            this.colIgvOppNombre.OptionsColumn.AllowEdit = false;
            this.colIgvOppNombre.Visible = true;
            this.colIgvOppNombre.VisibleIndex = 1;
            this.colIgvOppNombre.Width = 280;
            // 
            // colIgvOppTipo
            // 
            this.colIgvOppTipo.Caption = "Tipo";
            this.colIgvOppTipo.FieldName = "OppTipo";
            this.colIgvOppTipo.Name = "colIgvOppTipo";
            this.colIgvOppTipo.OptionsColumn.AllowEdit = false;
            this.colIgvOppTipo.Visible = true;
            this.colIgvOppTipo.VisibleIndex = 2;
            this.colIgvOppTipo.Width = 80;
            // 
            // colOprNombre
            // 
            this.colOprNombre.Caption = "Descripcion";
            this.colOprNombre.FieldName = "OprNombre";
            this.colOprNombre.Name = "colOprNombre";
            this.colOprNombre.OptionsColumn.AllowEdit = false;
            this.colOprNombre.OptionsColumn.TabStop = false;
            this.colOprNombre.Visible = true;
            this.colOprNombre.VisibleIndex = 2;
            this.colOprNombre.Width = 200;
            // 
            // colRecCodigo
            // 
            this.colRecCodigo.Caption = "Recurso";
            this.colRecCodigo.ColumnEdit = this.gluRecurso;
            this.colRecCodigo.FieldName = "RecCodigo";
            this.colRecCodigo.Name = "colRecCodigo";
            this.colRecCodigo.Visible = true;
            this.colRecCodigo.VisibleIndex = 3;
            this.colRecCodigo.Width = 90;
            // 
            // gluRecurso
            // 
            this.gluRecurso.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gluRecurso.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("gluRecurso.Appearance.Image")));
            this.gluRecurso.Appearance.Options.UseFont = true;
            this.gluRecurso.Appearance.Options.UseImage = true;
            this.gluRecurso.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluRecurso.AppearanceDisabled.Image = ((System.Drawing.Image)(resources.GetObject("gluRecurso.AppearanceDisabled.Image")));
            this.gluRecurso.AppearanceDisabled.Options.UseFont = true;
            this.gluRecurso.AppearanceDisabled.Options.UseImage = true;
            this.gluRecurso.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluRecurso.AppearanceDropDown.Image = ((System.Drawing.Image)(resources.GetObject("gluRecurso.AppearanceDropDown.Image")));
            this.gluRecurso.AppearanceDropDown.Options.UseFont = true;
            this.gluRecurso.AppearanceDropDown.Options.UseImage = true;
            this.gluRecurso.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluRecurso.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("gluRecurso.AppearanceFocused.Image")));
            this.gluRecurso.AppearanceFocused.Options.UseFont = true;
            this.gluRecurso.AppearanceFocused.Options.UseImage = true;
            this.gluRecurso.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.gluRecurso.AppearanceReadOnly.Image = ((System.Drawing.Image)(resources.GetObject("gluRecurso.AppearanceReadOnly.Image")));
            this.gluRecurso.AppearanceReadOnly.Options.UseFont = true;
            this.gluRecurso.AppearanceReadOnly.Options.UseImage = true;
            this.gluRecurso.AutoHeight = false;
            this.gluRecurso.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluRecurso.DisplayMember = "RecCodigo";
            this.gluRecurso.Name = "gluRecurso";
            this.gluRecurso.NullText = "";
            this.gluRecurso.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.gluRecurso.PopupFormMinSize = new System.Drawing.Size(500, 200);
            this.gluRecurso.PopupFormSize = new System.Drawing.Size(500, 200);
            this.gluRecurso.PopupView = this.grvRecurso;
            this.gluRecurso.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gluRecurso.ValueMember = "RecCodigo";
            this.gluRecurso.Popup += new System.EventHandler(this.gluRecurso_Popup);
            this.gluRecurso.Leave += new System.EventHandler(this.gluRecurso_Leave);
            // 
            // grvRecurso
            // 
            this.grvRecurso.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvRecurso.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvRecurso.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvRecurso.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvRecurso.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.grvRecurso.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvRecurso.Appearance.DetailTip.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.DetailTip.Options.UseBackColor = true;
            this.grvRecurso.Appearance.DetailTip.Options.UseFont = true;
            this.grvRecurso.Appearance.Empty.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.Empty.Options.UseBackColor = true;
            this.grvRecurso.Appearance.Empty.Options.UseFont = true;
            this.grvRecurso.Appearance.EvenRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.EvenRow.Options.UseFont = true;
            this.grvRecurso.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvRecurso.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvRecurso.Appearance.FilterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvRecurso.Appearance.FilterPanel.Options.UseFont = true;
            this.grvRecurso.Appearance.FixedLine.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvRecurso.Appearance.FixedLine.Options.UseFont = true;
            this.grvRecurso.Appearance.FocusedCell.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvRecurso.Appearance.FocusedCell.Options.UseFont = true;
            this.grvRecurso.Appearance.FocusedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.FocusedRow.Options.UseFont = true;
            this.grvRecurso.Appearance.FooterPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvRecurso.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvRecurso.Appearance.FooterPanel.Options.UseFont = true;
            this.grvRecurso.Appearance.GroupButton.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvRecurso.Appearance.GroupButton.Options.UseFont = true;
            this.grvRecurso.Appearance.GroupFooter.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvRecurso.Appearance.GroupFooter.Options.UseFont = true;
            this.grvRecurso.Appearance.GroupPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvRecurso.Appearance.GroupPanel.Options.UseFont = true;
            this.grvRecurso.Appearance.GroupRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.GroupRow.Options.UseFont = true;
            this.grvRecurso.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvRecurso.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvRecurso.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvRecurso.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.HorzLine.Options.UseFont = true;
            this.grvRecurso.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.OddRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.OddRow.Options.UseFont = true;
            this.grvRecurso.Appearance.Preview.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.Preview.Options.UseBackColor = true;
            this.grvRecurso.Appearance.Preview.Options.UseFont = true;
            this.grvRecurso.Appearance.Row.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.Row.Options.UseBackColor = true;
            this.grvRecurso.Appearance.Row.Options.UseFont = true;
            this.grvRecurso.Appearance.RowSeparator.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvRecurso.Appearance.RowSeparator.Options.UseFont = true;
            this.grvRecurso.Appearance.SelectedRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.SelectedRow.Options.UseFont = true;
            this.grvRecurso.Appearance.TopNewRow.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvRecurso.Appearance.TopNewRow.Options.UseFont = true;
            this.grvRecurso.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.VertLine.Options.UseFont = true;
            this.grvRecurso.Appearance.ViewCaption.BackColor = System.Drawing.Color.Ivory;
            this.grvRecurso.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvRecurso.Appearance.ViewCaption.Options.UseBackColor = true;
            this.grvRecurso.Appearance.ViewCaption.Options.UseFont = true;
            this.grvRecurso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIgvRecCodigo,
            this.colIgvRecNombre});
            this.grvRecurso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grvRecurso.Name = "grvRecurso";
            this.grvRecurso.OptionsCustomization.AllowColumnMoving = false;
            this.grvRecurso.OptionsCustomization.AllowColumnResizing = false;
            this.grvRecurso.OptionsCustomization.AllowGroup = false;
            this.grvRecurso.OptionsCustomization.AllowSort = false;
            this.grvRecurso.OptionsFind.AllowFindPanel = false;
            this.grvRecurso.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvRecurso.OptionsView.ColumnAutoWidth = false;
            this.grvRecurso.OptionsView.ShowAutoFilterRow = true;
            this.grvRecurso.OptionsView.ShowDetailButtons = false;
            this.grvRecurso.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvRecurso.OptionsView.ShowGroupPanel = false;
            // 
            // colIgvRecCodigo
            // 
            this.colIgvRecCodigo.Caption = "Codigo";
            this.colIgvRecCodigo.FieldName = "RecCodigo";
            this.colIgvRecCodigo.Name = "colIgvRecCodigo";
            this.colIgvRecCodigo.Visible = true;
            this.colIgvRecCodigo.VisibleIndex = 0;
            this.colIgvRecCodigo.Width = 100;
            // 
            // colIgvRecNombre
            // 
            this.colIgvRecNombre.Caption = "Recurso";
            this.colIgvRecNombre.FieldName = "RecNombre";
            this.colIgvRecNombre.Name = "colIgvRecNombre";
            this.colIgvRecNombre.Visible = true;
            this.colIgvRecNombre.VisibleIndex = 1;
            this.colIgvRecNombre.Width = 280;
            // 
            // colRecNombre
            // 
            this.colRecNombre.Caption = "Descripcion";
            this.colRecNombre.FieldName = "RecNombre";
            this.colRecNombre.Name = "colRecNombre";
            this.colRecNombre.OptionsColumn.AllowEdit = false;
            this.colRecNombre.OptionsColumn.TabStop = false;
            this.colRecNombre.Visible = true;
            this.colRecNombre.VisibleIndex = 4;
            this.colRecNombre.Width = 200;
            // 
            // colDfrTiempoPor
            // 
            this.colDfrTiempoPor.Caption = "Tiempo Por";
            this.colDfrTiempoPor.ColumnEdit = this.itxTiempoPor;
            this.colDfrTiempoPor.DisplayFormat.FormatString = "{0:0.00}";
            this.colDfrTiempoPor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfrTiempoPor.FieldName = "DfrTiempoPor";
            this.colDfrTiempoPor.Name = "colDfrTiempoPor";
            this.colDfrTiempoPor.Visible = true;
            this.colDfrTiempoPor.VisibleIndex = 6;
            this.colDfrTiempoPor.Width = 100;
            // 
            // itxTiempoPor
            // 
            this.itxTiempoPor.AutoHeight = false;
            this.itxTiempoPor.Mask.EditMask = "n2";
            this.itxTiempoPor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxTiempoPor.Name = "itxTiempoPor";
            // 
            // colDfrTiempo
            // 
            this.colDfrTiempo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDfrTiempo.AppearanceHeader.Options.UseFont = true;
            this.colDfrTiempo.Caption = "Tiempo";
            this.colDfrTiempo.ColumnEdit = this.itxTiempoPor;
            this.colDfrTiempo.DisplayFormat.FormatString = "{0:0.00}";
            this.colDfrTiempo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfrTiempo.FieldName = "DfrTiempo";
            this.colDfrTiempo.Name = "colDfrTiempo";
            this.colDfrTiempo.Visible = true;
            this.colDfrTiempo.VisibleIndex = 5;
            this.colDfrTiempo.Width = 100;
            // 
            // itxTiempo
            // 
            this.itxTiempo.AutoHeight = false;
            this.itxTiempo.Mask.EditMask = "n2";
            this.itxTiempo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxTiempo.Name = "itxTiempo";
            // 
            // xtpMermas
            // 
            this.xtpMermas.Controls.Add(this.grcMerma);
            this.xtpMermas.Name = "xtpMermas";
            this.xtpMermas.Size = new System.Drawing.Size(868, 440);
            this.xtpMermas.Text = "Mermas";
            // 
            // grcMerma
            // 
            this.grcMerma.ContextMenuStrip = this.cmsMenu;
            this.grcMerma.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcMerma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcMerma.Location = new System.Drawing.Point(0, 0);
            this.grcMerma.MainView = this.grvMerma;
            this.grcMerma.Name = "grcMerma";
            this.grcMerma.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itxPorcentaje,
            this.iluMerma,
            this.iluTipo});
            this.grcMerma.Size = new System.Drawing.Size(868, 440);
            this.grcMerma.TabIndex = 508;
            this.grcMerma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMerma});
            // 
            // grvMerma
            // 
            this.grvMerma.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvMerma.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.grvMerma.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.grvMerma.Appearance.DetailTip.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.DetailTip.Options.UseFont = true;
            this.grvMerma.Appearance.Empty.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.Empty.Options.UseFont = true;
            this.grvMerma.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.EvenRow.Options.UseFont = true;
            this.grvMerma.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FilterCloseButton.Options.UseFont = true;
            this.grvMerma.Appearance.FilterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FilterPanel.Options.UseFont = true;
            this.grvMerma.Appearance.FixedLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FixedLine.Options.UseFont = true;
            this.grvMerma.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FocusedCell.Options.UseFont = true;
            this.grvMerma.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FocusedRow.Options.UseFont = true;
            this.grvMerma.Appearance.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.FooterPanel.Options.UseFont = true;
            this.grvMerma.Appearance.GroupButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.GroupButton.Options.UseFont = true;
            this.grvMerma.Appearance.GroupFooter.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.GroupFooter.Options.UseFont = true;
            this.grvMerma.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.GroupPanel.Options.UseFont = true;
            this.grvMerma.Appearance.GroupRow.BackColor = System.Drawing.Color.White;
            this.grvMerma.Appearance.GroupRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvMerma.Appearance.GroupRow.Options.UseFont = true;
            this.grvMerma.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvMerma.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.HideSelectionRow.Options.UseFont = true;
            this.grvMerma.Appearance.HorzLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.HorzLine.Options.UseFont = true;
            this.grvMerma.Appearance.OddRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.OddRow.Options.UseFont = true;
            this.grvMerma.Appearance.Preview.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.Preview.Options.UseFont = true;
            this.grvMerma.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.Row.Options.UseFont = true;
            this.grvMerma.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.RowSeparator.Options.UseFont = true;
            this.grvMerma.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.SelectedRow.Options.UseFont = true;
            this.grvMerma.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.TopNewRow.Options.UseFont = true;
            this.grvMerma.Appearance.VertLine.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.VertLine.Options.UseFont = true;
            this.grvMerma.Appearance.ViewCaption.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.grvMerma.Appearance.ViewCaption.Options.UseFont = true;
            this.grvMerma.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grvMerma.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDfeLinea,
            this.colMerCodigo,
            this.colDfePorcentaje,
            this.colDfeTipo});
            this.grvMerma.GridControl = this.grcMerma;
            this.grvMerma.Name = "grvMerma";
            this.grvMerma.OptionsCustomization.AllowColumnMoving = false;
            this.grvMerma.OptionsCustomization.AllowColumnResizing = false;
            this.grvMerma.OptionsCustomization.AllowGroup = false;
            this.grvMerma.OptionsCustomization.AllowSort = false;
            this.grvMerma.OptionsDetail.EnableMasterViewMode = false;
            this.grvMerma.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvMerma.OptionsFind.AllowFindPanel = false;
            this.grvMerma.OptionsFind.ShowClearButton = false;
            this.grvMerma.OptionsFind.ShowCloseButton = false;
            this.grvMerma.OptionsFind.ShowFindButton = false;
            this.grvMerma.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvMerma.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grvMerma.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grvMerma.OptionsView.ColumnAutoWidth = false;
            this.grvMerma.OptionsView.ShowDetailButtons = false;
            this.grvMerma.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvMerma.OptionsView.ShowFooter = true;
            this.grvMerma.OptionsView.ShowGroupPanel = false;
            this.grvMerma.ViewCaption = "Productos";
            this.grvMerma.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.grvMerma_CustomDrawFooter);
            this.grvMerma.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.grvMerma_ShowingEditor);
            // 
            // colDfeLinea
            // 
            this.colDfeLinea.Caption = "Nro";
            this.colDfeLinea.FieldName = "DfeLinea";
            this.colDfeLinea.Name = "colDfeLinea";
            this.colDfeLinea.OptionsColumn.AllowEdit = false;
            this.colDfeLinea.OptionsColumn.TabStop = false;
            this.colDfeLinea.Visible = true;
            this.colDfeLinea.VisibleIndex = 0;
            this.colDfeLinea.Width = 30;
            // 
            // colMerCodigo
            // 
            this.colMerCodigo.Caption = "Merma";
            this.colMerCodigo.ColumnEdit = this.iluMerma;
            this.colMerCodigo.FieldName = "MerCodigo";
            this.colMerCodigo.Name = "colMerCodigo";
            this.colMerCodigo.Visible = true;
            this.colMerCodigo.VisibleIndex = 1;
            this.colMerCodigo.Width = 320;
            // 
            // iluMerma
            // 
            this.iluMerma.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iluMerma.Appearance.Options.UseFont = true;
            this.iluMerma.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMerma.AppearanceDisabled.Options.UseFont = true;
            this.iluMerma.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMerma.AppearanceDropDown.Options.UseFont = true;
            this.iluMerma.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMerma.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluMerma.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMerma.AppearanceFocused.Options.UseFont = true;
            this.iluMerma.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluMerma.AppearanceReadOnly.Options.UseFont = true;
            this.iluMerma.AutoHeight = false;
            this.iluMerma.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluMerma.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MerCodigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MerNombre", "Merma", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.iluMerma.DisplayMember = "MerNombre";
            this.iluMerma.Name = "iluMerma";
            this.iluMerma.NullText = "";
            this.iluMerma.ValueMember = "MerCodigo";
            // 
            // colDfePorcentaje
            // 
            this.colDfePorcentaje.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDfePorcentaje.AppearanceHeader.Options.UseFont = true;
            this.colDfePorcentaje.Caption = "Porcentaje";
            this.colDfePorcentaje.ColumnEdit = this.itxPorcentaje;
            this.colDfePorcentaje.DisplayFormat.FormatString = "{0:0.00}";
            this.colDfePorcentaje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDfePorcentaje.FieldName = "DfePorcentaje";
            this.colDfePorcentaje.Name = "colDfePorcentaje";
            this.colDfePorcentaje.Visible = true;
            this.colDfePorcentaje.VisibleIndex = 3;
            // 
            // itxPorcentaje
            // 
            this.itxPorcentaje.AutoHeight = false;
            this.itxPorcentaje.Mask.EditMask = "n2";
            this.itxPorcentaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.itxPorcentaje.Name = "itxPorcentaje";
            // 
            // colDfeTipo
            // 
            this.colDfeTipo.Caption = "Tipo";
            this.colDfeTipo.ColumnEdit = this.iluTipo;
            this.colDfeTipo.FieldName = "DfeTipo";
            this.colDfeTipo.Name = "colDfeTipo";
            this.colDfeTipo.Visible = true;
            this.colDfeTipo.VisibleIndex = 2;
            this.colDfeTipo.Width = 100;
            // 
            // iluTipo
            // 
            this.iluTipo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.Appearance.Options.UseFont = true;
            this.iluTipo.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.AppearanceDisabled.Options.UseFont = true;
            this.iluTipo.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.AppearanceDropDown.Options.UseFont = true;
            this.iluTipo.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.AppearanceDropDownHeader.Options.UseFont = true;
            this.iluTipo.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.AppearanceFocused.Options.UseFont = true;
            this.iluTipo.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.iluTipo.AppearanceReadOnly.Options.UseFont = true;
            this.iluTipo.AutoHeight = false;
            this.iluTipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iluTipo.DisplayMember = "Descripcion";
            this.iluTipo.Name = "iluTipo";
            this.iluTipo.NullText = "";
            this.iluTipo.ValueMember = "Codigo";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(89, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(356, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = false;
            // 
            // txtGrupo
            // 
            this.txtGrupo.EditValue = "";
            this.txtGrupo.EnterMoveNextControl = true;
            this.txtGrupo.Location = new System.Drawing.Point(292, 58);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Properties.Appearance.Options.UseFont = true;
            this.txtGrupo.Properties.AutoHeight = false;
            this.txtGrupo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGrupo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.Properties.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(153, 23);
            this.txtGrupo.TabIndex = 574;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblGrupo.Appearance.Options.UseFont = true;
            this.lblGrupo.Appearance.Options.UseForeColor = true;
            this.lblGrupo.Location = new System.Drawing.Point(251, 61);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(35, 15);
            this.lblGrupo.TabIndex = 575;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtUndVenta
            // 
            this.txtUndVenta.EditValue = "";
            this.txtUndVenta.EnterMoveNextControl = true;
            this.txtUndVenta.Location = new System.Drawing.Point(865, 37);
            this.txtUndVenta.Name = "txtUndVenta";
            this.txtUndVenta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndVenta.Properties.Appearance.Options.UseFont = true;
            this.txtUndVenta.Properties.AutoHeight = false;
            this.txtUndVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtUndVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndVenta.Properties.ReadOnly = true;
            this.txtUndVenta.Size = new System.Drawing.Size(150, 23);
            this.txtUndVenta.TabIndex = 8;
            // 
            // lblUndVenta
            // 
            this.lblUndVenta.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndVenta.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUndVenta.Appearance.Options.UseFont = true;
            this.lblUndVenta.Appearance.Options.UseForeColor = true;
            this.lblUndVenta.Location = new System.Drawing.Point(778, 40);
            this.lblUndVenta.Name = "lblUndVenta";
            this.lblUndVenta.Size = new System.Drawing.Size(55, 15);
            this.lblUndVenta.TabIndex = 577;
            this.lblUndVenta.Text = "Und Venta:";
            // 
            // txtPsoStdVenta
            // 
            this.txtPsoStdVenta.EditValue = "";
            this.txtPsoStdVenta.EnterMoveNextControl = true;
            this.txtPsoStdVenta.Location = new System.Drawing.Point(865, 60);
            this.txtPsoStdVenta.Name = "txtPsoStdVenta";
            this.txtPsoStdVenta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPsoStdVenta.Properties.Appearance.Options.UseFont = true;
            this.txtPsoStdVenta.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPsoStdVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPsoStdVenta.Properties.AutoHeight = false;
            this.txtPsoStdVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPsoStdVenta.Properties.ReadOnly = true;
            this.txtPsoStdVenta.Size = new System.Drawing.Size(150, 23);
            this.txtPsoStdVenta.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(778, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 15);
            this.labelControl6.TabIndex = 579;
            this.labelControl6.Text = "Pso Std Venta:";
            // 
            // chkProfundizar
            // 
            this.chkProfundizar.Location = new System.Drawing.Point(521, 38);
            this.chkProfundizar.Name = "chkProfundizar";
            this.chkProfundizar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProfundizar.Properties.Appearance.Options.UseFont = true;
            this.chkProfundizar.Properties.Caption = "Profundizar nivel";
            this.chkProfundizar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkProfundizar.Size = new System.Drawing.Size(120, 19);
            this.chkProfundizar.TabIndex = 4;
            // 
            // chkRendimiento
            // 
            this.chkRendimiento.Location = new System.Drawing.Point(521, 59);
            this.chkRendimiento.Name = "chkRendimiento";
            this.chkRendimiento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRendimiento.Properties.Appearance.Options.UseFont = true;
            this.chkRendimiento.Properties.Caption = "Rendimiento crudo a terminado";
            this.chkRendimiento.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkRendimiento.Size = new System.Drawing.Size(179, 19);
            this.chkRendimiento.TabIndex = 5;
            // 
            // lueArea
            // 
            this.lueArea.Location = new System.Drawing.Point(89, 58);
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
            this.lueArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueArea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueArea.Properties.DisplayMember = "Descripcion";
            this.lueArea.Properties.NullText = "";
            this.lueArea.Properties.ValueMember = "Codigo";
            this.lueArea.Size = new System.Drawing.Size(132, 20);
            this.lueArea.TabIndex = 2;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Appearance.Options.UseFont = true;
            this.lblObservaciones.Location = new System.Drawing.Point(12, 559);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(73, 15);
            this.lblObservaciones.TabIndex = 581;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // memObservacion
            // 
            this.memObservacion.Location = new System.Drawing.Point(146, 557);
            this.memObservacion.Name = "memObservacion";
            this.memObservacion.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memObservacion.Properties.Appearance.Options.UseFont = true;
            this.memObservacion.Size = new System.Drawing.Size(644, 45);
            this.memObservacion.TabIndex = 580;
            // 
            // lueRuta
            // 
            this.lueRuta.Location = new System.Drawing.Point(865, 83);
            this.lueRuta.Name = "lueRuta";
            this.lueRuta.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueRuta.Properties.Appearance.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueRuta.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueRuta.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRuta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrsCodigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrsNombre", "Ruta Std", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueRuta.Properties.DisplayMember = "PrsNombre";
            this.lueRuta.Properties.NullText = "";
            this.lueRuta.Properties.ValueMember = "PrsCodigo";
            this.lueRuta.Size = new System.Drawing.Size(149, 20);
            this.lueRuta.TabIndex = 583;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(778, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 15);
            this.labelControl3.TabIndex = 584;
            this.labelControl3.Text = "Ruta:";
            // 
            // txtNumero
            // 
            this.txtNumero.EditValue = "";
            this.txtNumero.Enabled = false;
            this.txtNumero.EnterMoveNextControl = true;
            this.txtNumero.Location = new System.Drawing.Point(376, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumero.Properties.AutoHeight = false;
            this.txtNumero.Size = new System.Drawing.Size(68, 22);
            this.txtNumero.TabIndex = 657;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.EditValue = "TIS_001";
            this.txtNomSerie.Enabled = false;
            this.txtNomSerie.Location = new System.Drawing.Point(307, 13);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSerie.Properties.Appearance.Options.UseFont = true;
            this.txtNomSerie.Properties.AutoHeight = false;
            this.txtNomSerie.Size = new System.Drawing.Size(69, 22);
            this.txtNomSerie.TabIndex = 656;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(275, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 15);
            this.labelControl7.TabIndex = 655;
            this.labelControl7.Text = "Serie:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(451, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Properties.Mask.EditMask = "f0";
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodigo.Size = new System.Drawing.Size(49, 22);
            this.txtCodigo.TabIndex = 659;
            this.txtCodigo.TabStop = false;
            // 
            // txtCodSerie
            // 
            this.txtCodSerie.EditValue = "";
            this.txtCodSerie.EnterMoveNextControl = true;
            this.txtCodSerie.Location = new System.Drawing.Point(499, 13);
            this.txtCodSerie.Name = "txtCodSerie";
            this.txtCodSerie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodSerie.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSerie.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodSerie.Properties.Appearance.Options.UseFont = true;
            this.txtCodSerie.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodSerie.Properties.AutoHeight = false;
            this.txtCodSerie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodSerie.Properties.Mask.EditMask = "f0";
            this.txtCodSerie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCodSerie.Size = new System.Drawing.Size(49, 22);
            this.txtCodSerie.TabIndex = 658;
            this.txtCodSerie.TabStop = false;
            // 
            // xfrmProManFormulacion
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1029, 659);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCodSerie);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.lueRuta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.memObservacion);
            this.Controls.Add(this.lueArea);
            this.Controls.Add(this.chkRendimiento);
            this.Controls.Add(this.chkProfundizar);
            this.Controls.Add(this.txtPsoStdVenta);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUndVenta);
            this.Controls.Add(this.lblUndVenta);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.xtcFormulacion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtUndInventario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmbVariante);
            this.Controls.Add(this.bedItem);
            this.Controls.Add(this.labelControl1);
            this.Name = "xfrmProManFormulacion";
            this.Text = "Formulacion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xfrmProManFormulacion_KeyDown);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.bedItem, 0);
            this.Controls.SetChildIndex(this.cmbVariante, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtUndInventario, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.xtcFormulacion, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblGrupo, 0);
            this.Controls.SetChildIndex(this.txtGrupo, 0);
            this.Controls.SetChildIndex(this.lblUndVenta, 0);
            this.Controls.SetChildIndex(this.txtUndVenta, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.txtPsoStdVenta, 0);
            this.Controls.SetChildIndex(this.chkProfundizar, 0);
            this.Controls.SetChildIndex(this.chkRendimiento, 0);
            this.Controls.SetChildIndex(this.lueArea, 0);
            this.Controls.SetChildIndex(this.memObservacion, 0);
            this.Controls.SetChildIndex(this.lblObservaciones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.lueRuta, 0);
            this.Controls.SetChildIndex(this.txtNomSerie, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtCodSerie, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bedItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVariante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUndInventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcFormulacion)).EndInit();
            this.xtcFormulacion.ResumeLayout(false);
            this.xtpMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcListado)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCantidadPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxPorcentajeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxEntero)).EndInit();
            this.xtpRuta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluRecurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRecurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxTiempoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxTiempo)).EndInit();
            this.xtpMermas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcMerma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMerma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluMerma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itxPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iluTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUndVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPsoStdVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProfundizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRendimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodSerie.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit bedItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVariante;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.TextEdit txtUndInventario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabControl xtcFormulacion;
        private DevExpress.XtraTab.XtraTabPage xtpMateriales;
        private DevExpress.XtraTab.XtraTabPage xtpRuta;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit txtUndVenta;
        private DevExpress.XtraEditors.LabelControl lblUndVenta;
        private DevExpress.XtraEditors.TextEdit txtPsoStdVenta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraGrid.GridControl grcListado;
        public DevExpress.XtraGrid.Views.Grid.GridView grvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluItem;
        private DevExpress.XtraGrid.Views.Grid.GridView igvItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvntryUom;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmCantidadPor;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxCantidadPor;
        private DevExpress.XtraTab.XtraTabPage xtpMermas;
        public DevExpress.XtraGrid.GridControl grcMerma;
        public DevExpress.XtraGrid.Views.Grid.GridView grvMerma;
        private DevExpress.XtraGrid.Columns.GridColumn colDfeLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colMerCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDfePorcentaje;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxPorcentaje;
        public DevExpress.XtraGrid.GridControl grcRuta;
        public DevExpress.XtraGrid.Views.Grid.GridView grvRuta;
        private DevExpress.XtraGrid.Columns.GridColumn colDfrLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colOprCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluOperacion;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvOppCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvOppNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvOppTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDfrTiempoPor;
        private DevExpress.XtraGrid.Columns.GridColumn colDfrTiempo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxTiempo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxTiempoPor;
        private DevExpress.XtraEditors.CheckEdit chkProfundizar;
        private DevExpress.XtraEditors.CheckEdit chkRendimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colRecNombre;
        private DevExpress.XtraEditors.LookUpEdit lueArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit gluRecurso;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRecurso;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluMerma;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvInvntryUom;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvRecCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIgvRecNombre;
        private DevExpress.XtraEditors.LabelControl lblObservaciones;
        private DevExpress.XtraEditors.MemoEdit memObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDfeTipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit iluTipo;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem smiBorrar;
        private DevExpress.XtraGrid.Columns.GridColumn colOprNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmTipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxPorcentajeM;
        private DevExpress.XtraEditors.LookUpEdit lueRuta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtNomSerie;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colDfmLineaRuta;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit itxEntero;
    }
}
