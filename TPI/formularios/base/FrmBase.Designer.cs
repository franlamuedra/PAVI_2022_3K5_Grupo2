namespace TPI
{
    partial class FrmBase
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPatron = new System.Windows.Forms.Label();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnModelo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(30, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 34);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 210);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(894, 291);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatron.Location = new System.Drawing.Point(30, 89);
            this.lblPatron.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(68, 21);
            this.lblPatron.TabIndex = 2;
            this.lblPatron.Text = "Patron";
            // 
            // txtPatron
            // 
            this.txtPatron.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatron.Location = new System.Drawing.Point(118, 86);
            this.txtPatron.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(412, 34);
            this.txtPatron.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(30, 554);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 46);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(281, 554);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(156, 554);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 46);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(790, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(770, 554);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 46);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(648, 112);
            this.rbtnMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(73, 22);
            this.rbtnMarca.TabIndex = 10;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            // 
            // rbtnModelo
            // 
            this.rbtnModelo.AutoSize = true;
            this.rbtnModelo.Location = new System.Drawing.Point(648, 143);
            this.rbtnModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnModelo.Name = "rbtnModelo";
            this.rbtnModelo.Size = new System.Drawing.Size(87, 22);
            this.rbtnModelo.TabIndex = 11;
            this.rbtnModelo.TabStop = true;
            this.rbtnModelo.Text = "Modelo";
            this.rbtnModelo.UseVisualStyleBackColor = true;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(929, 626);
            this.Controls.Add(this.rbtnModelo);
            this.Controls.Add(this.rbtnMarca);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.lblPatron);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBase";
            this.Text = "Base";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private DataGridView dataGridView1;
        private Label lblPatron;
        private TextBox txtPatron;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnBuscar;
        private Button btnSalir;
        private RadioButton rbtnMarca;
        private RadioButton rbtnModelo;
    }
}