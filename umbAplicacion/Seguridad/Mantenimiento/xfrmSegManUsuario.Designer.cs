namespace umbAplicacion.Seguridad.Mantenimiento
{
    partial class xfrmSegManUsuario
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
            this.chkMovil = new System.Windows.Forms.CheckBox();
            this.chkBloqueado = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.chkVence = new System.Windows.Forms.CheckBox();
            this.txtConfirmar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueDepartamento = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lueSucursal = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdMovil = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.lueEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMovil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMovil
            // 
            this.chkMovil.AutoSize = true;
            this.chkMovil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMovil.Location = new System.Drawing.Point(321, 238);
            this.chkMovil.Name = "chkMovil";
            this.chkMovil.Size = new System.Drawing.Size(94, 19);
            this.chkMovil.TabIndex = 13;
            this.chkMovil.Text = "Usuario movil";
            this.chkMovil.UseVisualStyleBackColor = true;
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBloqueado.Location = new System.Drawing.Point(45, 274);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Size = new System.Drawing.Size(77, 19);
            this.chkBloqueado.TabIndex = 12;
            this.chkBloqueado.Text = "Bloqueado";
            this.chkBloqueado.UseVisualStyleBackColor = true;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificar.Location = new System.Drawing.Point(45, 256);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(250, 19);
            this.chkModificar.TabIndex = 11;
            this.chkModificar.Text = "Modificar clave de acceso en proxima conexion";
            this.chkModificar.UseVisualStyleBackColor = true;
            // 
            // chkVence
            // 
            this.chkVence.AutoSize = true;
            this.chkVence.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVence.Location = new System.Drawing.Point(45, 238);
            this.chkVence.Name = "chkVence";
            this.chkVence.Size = new System.Drawing.Size(174, 19);
            this.chkVence.TabIndex = 10;
            this.chkVence.Text = "La clave de acceso nunca vence";
            this.chkVence.UseVisualStyleBackColor = true;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.EditValue = "";
            this.txtConfirmar.EnterMoveNextControl = true;
            this.txtConfirmar.Location = new System.Drawing.Point(154, 210);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmar.Properties.AutoHeight = false;
            this.txtConfirmar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtConfirmar.Properties.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(261, 22);
            this.txtConfirmar.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Location = new System.Drawing.Point(45, 214);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 15);
            this.labelControl7.TabIndex = 560;
            this.labelControl7.Text = "Confirmar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(45, 192);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 15);
            this.labelControl6.TabIndex = 559;
            this.labelControl6.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(154, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.AutoHeight = false;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(261, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Location = new System.Drawing.Point(45, 170);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 15);
            this.labelControl5.TabIndex = 557;
            this.labelControl5.Text = "Departamento:";
            // 
            // lueDepartamento
            // 
            this.lueDepartamento.Location = new System.Drawing.Point(154, 166);
            this.lueDepartamento.Name = "lueDepartamento";
            this.lueDepartamento.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueDepartamento.Properties.Appearance.Options.UseBackColor = true;
            this.lueDepartamento.Properties.Appearance.Options.UseFont = true;
            this.lueDepartamento.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueDepartamento.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueDepartamento.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueDepartamento.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueDepartamento.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueDepartamento.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueDepartamento.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueDepartamento.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueDepartamento.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueDepartamento.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueDepartamento.Properties.AutoHeight = false;
            this.lueDepartamento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lueDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepartamento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehCodigo", 40, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehNombre", 120, "Transporte"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehPlaca", "Placa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehTipo", "Tipo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueDepartamento.Properties.DisplayMember = "VehNombre";
            this.lueDepartamento.Properties.NullText = "";
            this.lueDepartamento.Properties.ValueMember = "VehCodigo";
            this.lueDepartamento.Size = new System.Drawing.Size(261, 22);
            this.lueDepartamento.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Location = new System.Drawing.Point(45, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 15);
            this.labelControl4.TabIndex = 555;
            this.labelControl4.Text = "Sucursal:";
            // 
            // lueSucursal
            // 
            this.lueSucursal.Location = new System.Drawing.Point(154, 144);
            this.lueSucursal.Name = "lueSucursal";
            this.lueSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueSucursal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueSucursal.Properties.Appearance.Options.UseBackColor = true;
            this.lueSucursal.Properties.Appearance.Options.UseFont = true;
            this.lueSucursal.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueSucursal.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueSucursal.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueSucursal.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueSucursal.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueSucursal.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueSucursal.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueSucursal.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueSucursal.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueSucursal.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueSucursal.Properties.AutoHeight = false;
            this.lueSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lueSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSucursal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehCodigo", 40, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehNombre", 120, "Transporte"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehPlaca", "Placa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehTipo", "Tipo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueSucursal.Properties.DisplayMember = "VehNombre";
            this.lueSucursal.Properties.NullText = "";
            this.lueSucursal.Properties.ValueMember = "VehCodigo";
            this.lueSucursal.Size = new System.Drawing.Size(261, 22);
            this.lueSucursal.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(45, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 15);
            this.labelControl3.TabIndex = 553;
            this.labelControl3.Text = "ID dispositivo móvil:";
            // 
            // txtIdMovil
            // 
            this.txtIdMovil.EditValue = "";
            this.txtIdMovil.EnterMoveNextControl = true;
            this.txtIdMovil.Location = new System.Drawing.Point(154, 122);
            this.txtIdMovil.Name = "txtIdMovil";
            this.txtIdMovil.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMovil.Properties.Appearance.Options.UseFont = true;
            this.txtIdMovil.Properties.AutoHeight = false;
            this.txtIdMovil.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtIdMovil.Size = new System.Drawing.Size(261, 22);
            this.txtIdMovil.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(45, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 551;
            this.labelControl2.Text = "Teléfono móvil:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.EditValue = "";
            this.txtTelefono.EnterMoveNextControl = true;
            this.txtTelefono.Location = new System.Drawing.Point(154, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.AutoHeight = false;
            this.txtTelefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTelefono.Size = new System.Drawing.Size(261, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(45, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 15);
            this.labelControl1.TabIndex = 549;
            this.labelControl1.Text = "Correo electrónico:";
            // 
            // txtEmail
            // 
            this.txtEmail.EditValue = "";
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(154, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.AutoHeight = false;
            this.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtEmail.Size = new System.Drawing.Size(261, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(45, 60);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(51, 15);
            this.lblEmpleado.TabIndex = 547;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lueEmpleado
            // 
            this.lueEmpleado.Location = new System.Drawing.Point(154, 56);
            this.lueEmpleado.Name = "lueEmpleado";
            this.lueEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.lueEmpleado.Properties.Appearance.Options.UseFont = true;
            this.lueEmpleado.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueEmpleado.Properties.AppearanceDisabled.Options.UseFont = true;
            this.lueEmpleado.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueEmpleado.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueEmpleado.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueEmpleado.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueEmpleado.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueEmpleado.Properties.AppearanceFocused.Options.UseFont = true;
            this.lueEmpleado.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lueEmpleado.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.lueEmpleado.Properties.AutoHeight = false;
            this.lueEmpleado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lueEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehCodigo", 40, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehNombre", 120, "Transporte"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehPlaca", "Placa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VehTipo", "Tipo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueEmpleado.Properties.DisplayMember = "VehNombre";
            this.lueEmpleado.Properties.NullText = "";
            this.lueEmpleado.Properties.ValueMember = "VehCodigo";
            this.lueEmpleado.Size = new System.Drawing.Size(261, 22);
            this.lueEmpleado.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(45, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 15);
            this.lblNombre.TabIndex = 545;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.EnterMoveNextControl = true;
            this.txtNombre.Location = new System.Drawing.Point(154, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(154, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCodigo.Properties.AutoHeight = false;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCodigo.Size = new System.Drawing.Size(121, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl12.Location = new System.Drawing.Point(45, 16);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 15);
            this.labelControl12.TabIndex = 544;
            this.labelControl12.Text = "Codigo:";
            // 
            // xfrmSegManUsuario
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(462, 343);
            this.Controls.Add(this.chkMovil);
            this.Controls.Add(this.chkBloqueado);
            this.Controls.Add(this.chkModificar);
            this.Controls.Add(this.chkVence);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lueDepartamento);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lueSucursal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtIdMovil);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lueEmpleado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl12);
            this.Name = "xfrmSegManUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.SetChildIndex(this.labelControl12, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lueEmpleado, 0);
            this.Controls.SetChildIndex(this.lblEmpleado, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtIdMovil, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.lueSucursal, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            this.Controls.SetChildIndex(this.lueDepartamento, 0);
            this.Controls.SetChildIndex(this.labelControl5, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.labelControl6, 0);
            this.Controls.SetChildIndex(this.labelControl7, 0);
            this.Controls.SetChildIndex(this.txtConfirmar, 0);
            this.Controls.SetChildIndex(this.chkVence, 0);
            this.Controls.SetChildIndex(this.chkModificar, 0);
            this.Controls.SetChildIndex(this.chkBloqueado, 0);
            this.Controls.SetChildIndex(this.chkMovil, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMovil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMovil;
        private System.Windows.Forms.CheckBox chkBloqueado;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.CheckBox chkVence;
        private DevExpress.XtraEditors.TextEdit txtConfirmar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lueDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lueSucursal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIdMovil;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmpleado;
        private DevExpress.XtraEditors.LookUpEdit lueEmpleado;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}
