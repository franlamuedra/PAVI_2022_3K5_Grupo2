﻿namespace TPI
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
            this.mtxtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
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
            this.grbMaterial.Location = new System.Drawing.Point(12, 12);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Size = new System.Drawing.Size(351, 183);
            this.grbMaterial.TabIndex = 1;
            this.grbMaterial.TabStop = false;
            this.grbMaterial.Text = "Material";
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(119, 112);
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(219, 23);
            this.nudProveedor.TabIndex = 23;
            this.nudProveedor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 25);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 23);
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
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(120, 54);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(218, 23);
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
            this.cboUnidadMedida.Location = new System.Drawing.Point(120, 83);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(218, 23);
            this.cboUnidadMedida.TabIndex = 11;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(52, 115);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(59, 56);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(17, 144);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(96, 15);
            this.lblFechaIngreso.TabIndex = 4;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(10, 86);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(104, 15);
            this.lblUnidadMedida.TabIndex = 2;
            this.lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 222);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mtxtFechaIngreso
            // 
            this.mtxtFechaIngreso.Location = new System.Drawing.Point(120, 141);
            this.mtxtFechaIngreso.Mask = "00/00/0000";
            this.mtxtFechaIngreso.Name = "mtxtFechaIngreso";
            this.mtxtFechaIngreso.Size = new System.Drawing.Size(218, 23);
            this.mtxtFechaIngreso.TabIndex = 24;
            this.mtxtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // FrmAltaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 255);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbMaterial);
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