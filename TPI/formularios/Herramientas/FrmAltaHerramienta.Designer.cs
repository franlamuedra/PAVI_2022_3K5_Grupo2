namespace TPI.formularios.Herramientas
{
    partial class FrmAltaHerramienta
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
            this.grbHerramienta = new System.Windows.Forms.GroupBox();
            this.nudVida = new System.Windows.Forms.NumericUpDown();
            this.nudProveedor = new System.Windows.Forms.NumericUpDown();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbHerramienta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grbHerramienta
            // 
            this.grbHerramienta.Controls.Add(this.nudVida);
            this.grbHerramienta.Controls.Add(this.nudProveedor);
            this.grbHerramienta.Controls.Add(this.lblVida);
            this.grbHerramienta.Controls.Add(this.lblProveedor);
            this.grbHerramienta.Controls.Add(this.txtModelo);
            this.grbHerramienta.Controls.Add(this.lblModelo);
            this.grbHerramienta.Controls.Add(this.txtMarca);
            this.grbHerramienta.Controls.Add(this.lblMarca);
            this.grbHerramienta.Location = new System.Drawing.Point(12, 12);
            this.grbHerramienta.Name = "grbHerramienta";
            this.grbHerramienta.Size = new System.Drawing.Size(290, 148);
            this.grbHerramienta.TabIndex = 0;
            this.grbHerramienta.TabStop = false;
            this.grbHerramienta.Text = "Herramienta";
            // 
            // nudVida
            // 
            this.nudVida.Location = new System.Drawing.Point(75, 108);
            this.nudVida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVida.Name = "nudVida";
            this.nudVida.Size = new System.Drawing.Size(201, 23);
            this.nudVida.TabIndex = 9;
            this.nudVida.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(75, 79);
            this.nudProveedor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(201, 23);
            this.nudProveedor.TabIndex = 8;
            this.nudProveedor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(18, 110);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(51, 15);
            this.lblVida.TabIndex = 6;
            this.lblVida.Text = "Vida Útil";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(8, 81);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(75, 49);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(201, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(21, 52);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(75, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(201, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(29, 23);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(227, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmAltaHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 226);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbHerramienta);
            this.Name = "FrmAltaHerramienta";
            this.Text = "Registrar Herramienta";
            this.Load += new System.EventHandler(this.FrmAltaHerramienta_Load);
            this.grbHerramienta.ResumeLayout(false);
            this.grbHerramienta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbHerramienta;
        private Label lblProveedor;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtMarca;
        private Label lblMarca;
        private Button btnCancelar;
        private Button btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblVida;
        private NumericUpDown nudProveedor;
        private NumericUpDown nudVida;
    }
}