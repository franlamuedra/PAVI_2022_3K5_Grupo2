namespace TPI.formularios.Proveedores
{
    partial class FrmAltaProveedor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbProveedor = new System.Windows.Forms.GroupBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grbProveedor
            // 
            this.grbProveedor.Controls.Add(this.mtxtTelefono);
            this.grbProveedor.Controls.Add(this.lblMail);
            this.grbProveedor.Controls.Add(this.lblTelefono);
            this.grbProveedor.Controls.Add(this.lblDireccion);
            this.grbProveedor.Controls.Add(this.txtNombre);
            this.grbProveedor.Controls.Add(this.txtDireccion);
            this.grbProveedor.Controls.Add(this.txtMail);
            this.grbProveedor.Controls.Add(this.lblNombre);
            this.grbProveedor.Location = new System.Drawing.Point(12, 12);
            this.grbProveedor.Name = "grbProveedor";
            this.grbProveedor.Size = new System.Drawing.Size(311, 157);
            this.grbProveedor.TabIndex = 1;
            this.grbProveedor.TabStop = false;
            this.grbProveedor.Text = "Proveedor";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(67, 116);
            this.mtxtTelefono.Mask = "000-000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(78, 23);
            this.mtxtTelefono.TabIndex = 9;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 61);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(30, 15);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 119);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 90);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(66, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(238, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(67, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(237, 23);
            this.txtMail.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(167, 195);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmAltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 230);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbProveedor);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 269);
            this.MinimumSize = new System.Drawing.Size(351, 269);
            this.Name = "FrmAltaProveedor";
            this.Text = "Registrar Proveedor";
            this.Load += new System.EventHandler(this.FrmAltaProveedor_Load);
            this.grbProveedor.ResumeLayout(false);
            this.grbProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancelar;
        private GroupBox grbProveedor;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblNombre;
        private Button btnAceptar;
        private MaskedTextBox mtxtTelefono;
    }
}