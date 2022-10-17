namespace TPI
{
    partial class FrmAltaMaterial
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
            this.grbMaterial = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.txtFechaIngreso = new System.Windows.Forms.DateTimePicker();
=======
            this.mtxtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.nudProveedor = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.grbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMaterial
            // 
<<<<<<< HEAD
            this.grbMaterial.Controls.Add(this.txtFechaIngreso);
=======
            this.grbMaterial.Controls.Add(this.mtxtFechaIngreso);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.grbMaterial.Controls.Add(this.nudProveedor);
            this.grbMaterial.Controls.Add(this.txtNombre);
            this.grbMaterial.Controls.Add(this.lblName);
            this.grbMaterial.Controls.Add(this.nudCantidad);
            this.grbMaterial.Controls.Add(this.cboUnidadMedida);
<<<<<<< HEAD
            this.grbMaterial.Controls.Add(this.lblSupplier);
            this.grbMaterial.Controls.Add(this.lblCount);
            this.grbMaterial.Controls.Add(this.lblEntryDate);
            this.grbMaterial.Controls.Add(this.lblUOM);
            this.grbMaterial.Location = new System.Drawing.Point(14, 16);
            this.grbMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMaterial.Size = new System.Drawing.Size(401, 244);
=======
            this.grbMaterial.Controls.Add(this.lblProveedor);
            this.grbMaterial.Controls.Add(this.lblCantidad);
            this.grbMaterial.Controls.Add(this.lblFechaIngreso);
            this.grbMaterial.Controls.Add(this.lblUnidadMedida);
            this.grbMaterial.Location = new System.Drawing.Point(18, 14);
            this.grbMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaterial.Size = new System.Drawing.Size(501, 220);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.grbMaterial.TabIndex = 1;
            this.grbMaterial.TabStop = false;
            this.grbMaterial.Text = "Material";
            // 
            // mtxtFechaIngreso
            // 
<<<<<<< HEAD
            this.txtFechaIngreso.Location = new System.Drawing.Point(185, 185);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(163, 27);
            this.txtFechaIngreso.TabIndex = 4;
            this.txtFechaIngreso.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(185, 151);
            this.nudProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(210, 27);
=======
            this.mtxtFechaIngreso.Location = new System.Drawing.Point(171, 169);
            this.mtxtFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtFechaIngreso.Mask = "00/00/0000";
            this.mtxtFechaIngreso.Name = "mtxtFechaIngreso";
            this.mtxtFechaIngreso.Size = new System.Drawing.Size(310, 25);
            this.mtxtFechaIngreso.TabIndex = 24;
            this.mtxtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(170, 134);
            this.nudProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(312, 25);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.nudProveedor.TabIndex = 23;
            this.nudProveedor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
<<<<<<< HEAD
            this.txtNombre.Location = new System.Drawing.Point(185, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 27);
=======
            this.txtNombre.Location = new System.Drawing.Point(171, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 25);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.txtNombre.TabIndex = 20;
            // 
            // lblName
            // 
<<<<<<< HEAD
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Nombre:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(185, 66);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(129, 27);
=======
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 33);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(171, 65);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(311, 25);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.nudCantidad.TabIndex = 16;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Items.AddRange(new object[] {
            "Gramos",
            "Kilos",
            "Litros",
            "Metros",
            "Centimetros"});
<<<<<<< HEAD
            this.cboUnidadMedida.Location = new System.Drawing.Point(185, 111);
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(129, 28);
=======
            this.cboUnidadMedida.Location = new System.Drawing.Point(171, 100);
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(310, 26);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.cboUnidadMedida.TabIndex = 11;
            // 
            // lblSupplier
            // 
<<<<<<< HEAD
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(62, 151);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(80, 20);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Proveedor:";
=======
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(74, 138);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(84, 18);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor";
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            // 
            // lblCount
            // 
<<<<<<< HEAD
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(70, 73);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(72, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Cantidad:";
=======
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(84, 68);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 18);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            // 
            // lblEntryDate
            // 
<<<<<<< HEAD
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(18, 185);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(124, 20);
            this.lblEntryDate.TabIndex = 4;
            this.lblEntryDate.Text = "Fecha de Ingreso:";
=======
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(24, 173);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(130, 18);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            // 
            // lblUOM
            // 
<<<<<<< HEAD
            this.lblUOM.AutoSize = true;
            this.lblUOM.Location = new System.Drawing.Point(6, 114);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(136, 20);
            this.lblUOM.TabIndex = 2;
            this.lblUOM.Text = "Unidad de Medida:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(329, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
=======
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(14, 104);
            this.lblUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(146, 18);
            this.lblUnidadMedida.TabIndex = 2;
            this.lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 266);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 28);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
<<<<<<< HEAD
            this.btnAgregar.Location = new System.Drawing.Point(223, 296);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
=======
            this.btnAgregar.Location = new System.Drawing.Point(296, 266);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 28);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAltaMaterial
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 340);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbMaterial);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(530, 306);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbMaterial);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
            this.Name = "FrmAltaMaterial";
            this.Text = "Registrar Material";
            this.Load += new System.EventHandler(this.FrmAltaMaterial_Load);
            this.grbMaterial.ResumeLayout(false);
            this.grbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grbMaterial;
        private Label lblSupplier;
        private Label lblCount;
        private Label lblEntryDate;
        private Label lblUOM;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cboUnidadMedida;
        private NumericUpDown nudCantidad;
        private TextBox txtNombre;
<<<<<<< HEAD
        private Label lblName;
        private NumericUpDown nudProveedor;
        private DateTimePicker txtFechaIngreso;
=======
        private Label lblNombre;
        private NumericUpDown nudProveedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox mtxtFechaIngreso;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
>>>>>>> 9189e919af9a401a47fb1e550190d7c25fdaf5f1
    }
}