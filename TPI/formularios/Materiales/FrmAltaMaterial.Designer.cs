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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbMaterial = new System.Windows.Forms.GroupBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudCodMaterial = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.grbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(108, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo de Material";
            // 
            // grbMaterial
            // 
            this.grbMaterial.Controls.Add(this.txtProveedor);
            this.grbMaterial.Controls.Add(this.txtFechaIngreso);
            this.grbMaterial.Controls.Add(this.txtNombre);
            this.grbMaterial.Controls.Add(this.lblNombre);
            this.grbMaterial.Controls.Add(this.nudCodMaterial);
            this.grbMaterial.Controls.Add(this.nudCantidad);
            this.grbMaterial.Controls.Add(this.cboUnidadMedida);
            this.grbMaterial.Controls.Add(this.lblProveedor);
            this.grbMaterial.Controls.Add(this.lblCantidad);
            this.grbMaterial.Controls.Add(this.lblFechaIngreso);
            this.grbMaterial.Controls.Add(this.lblUnidadMedida);
            this.grbMaterial.Controls.Add(this.lblCodigo);
            this.grbMaterial.Location = new System.Drawing.Point(12, 12);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Size = new System.Drawing.Size(351, 235);
            this.grbMaterial.TabIndex = 1;
            this.grbMaterial.TabStop = false;
            this.grbMaterial.Text = "Material";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(120, 195);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(121, 23);
            this.txtFechaIngreso.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // nudCodMaterial
            // 
            this.nudCodMaterial.Location = new System.Drawing.Point(119, 56);
            this.nudCodMaterial.Name = "nudCodMaterial";
            this.nudCodMaterial.Size = new System.Drawing.Size(120, 23);
            this.nudCodMaterial.TabIndex = 17;
            this.nudCodMaterial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(120, 89);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 23);
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
            this.cboUnidadMedida.Location = new System.Drawing.Point(120, 124);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(121, 23);
            this.cboUnidadMedida.TabIndex = 11;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(53, 163);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(59, 91);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(18, 203);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(96, 15);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(10, 127);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(104, 15);
            this.lblUnidadMedida.TabIndex = 2;
            this.lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(120, 160);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(121, 23);
            this.txtProveedor.TabIndex = 23;
            // 
            // FrmAltaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 286);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbMaterial);
            this.MinimumSize = new System.Drawing.Size(395, 325);
            this.Name = "FrmAltaMaterial";
            this.Text = "Registrar Material";
            this.Load += new System.EventHandler(this.FrmAltaMaterial_Load);
            this.grbMaterial.ResumeLayout(false);
            this.grbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCodigo;
        private GroupBox grbMaterial;
        private Label lblProveedor;
        private Label lblCantidad;
        private Label lblFechaIngreso;
        private Label lblUnidadMedida;
        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cboUnidadMedida;
        private NumericUpDown nudCodMaterial;
        private NumericUpDown nudCantidad;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtFechaIngreso;
        private TextBox txtProveedor;
    }
}