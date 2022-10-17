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
            this.mtxtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.nudProveedor = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMaterial
            // 
            this.grbMaterial.Controls.Add(this.mtxtFechaIngreso);
            this.grbMaterial.Controls.Add(this.nudProveedor);
            this.grbMaterial.Controls.Add(this.txtNombre);
            this.grbMaterial.Controls.Add(this.lblNombre);
            this.grbMaterial.Controls.Add(this.nudCantidad);
            this.grbMaterial.Controls.Add(this.cboUnidadMedida);
            this.grbMaterial.Controls.Add(this.lblProveedor);
            this.grbMaterial.Controls.Add(this.lblCantidad);
            this.grbMaterial.Controls.Add(this.lblFechaIngreso);
            this.grbMaterial.Controls.Add(this.lblUnidadMedida);
            this.grbMaterial.Location = new System.Drawing.Point(18, 14);
            this.grbMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaterial.Size = new System.Drawing.Size(501, 220);
            this.grbMaterial.TabIndex = 1;
            this.grbMaterial.TabStop = false;
            this.grbMaterial.Text = "Material";
            // 
            // mtxtFechaIngreso
            // 
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
            this.nudProveedor.TabIndex = 23;
            this.nudProveedor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 25);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
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
            this.cboUnidadMedida.Location = new System.Drawing.Point(171, 100);
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(310, 26);
            this.cboUnidadMedida.TabIndex = 11;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(74, 138);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(84, 18);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(84, 68);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 18);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(24, 173);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(130, 18);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblUnidadMedida
            // 
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
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(296, 266);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAltaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(530, 306);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbMaterial);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Label lblProveedor;
        private Label lblCantidad;
        private Label lblFechaIngreso;
        private Label lblUnidadMedida;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cboUnidadMedida;
        private NumericUpDown nudCantidad;
        private TextBox txtNombre;
        private Label lblNombre;
        private NumericUpDown nudProveedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox mtxtFechaIngreso;
    }
}