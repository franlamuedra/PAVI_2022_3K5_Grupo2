namespace TPI.formularios.Transacciones
{
    partial class FrmNuevoMantenimiento
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
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColHer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCambios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboHerramientas = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCambios = new System.Windows.Forms.Label();
            this.txtCambios = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMantenimiento.Location = new System.Drawing.Point(14, 20);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(222, 29);
            this.lblMantenimiento.TabIndex = 0;
            this.lblMantenimiento.Text = "Mantenimiento N:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(6, 66);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(88, 18);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(102, 66);
            this.txtEmpleado.MaxLength = 50;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(190, 25);
            this.txtEmpleado.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 18);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHer,
            this.ColCambios,
            this.ColAcc});
            this.dgvDetalles.Location = new System.Drawing.Point(14, 289);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 25;
            this.dgvDetalles.Size = new System.Drawing.Size(625, 194);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColHer
            // 
            this.ColHer.HeaderText = "Herramienta";
            this.ColHer.MinimumWidth = 6;
            this.ColHer.Name = "ColHer";
            this.ColHer.ReadOnly = true;
            this.ColHer.Width = 125;
            // 
            // ColCambios
            // 
            this.ColCambios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCambios.HeaderText = "Cambios";
            this.ColCambios.MinimumWidth = 6;
            this.ColCambios.Name = "ColCambios";
            this.ColCambios.ReadOnly = true;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Acciones";
            this.ColAcc.MinimumWidth = 6;
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.ReadOnly = true;
            this.ColAcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAcc.Text = "Quitar";
            this.ColAcc.UseColumnTextForButtonValue = true;
            this.ColAcc.Width = 80;
            // 
            // cboHerramientas
            // 
            this.cboHerramientas.FormattingEnabled = true;
            this.cboHerramientas.Location = new System.Drawing.Point(102, 135);
            this.cboHerramientas.Name = "cboHerramientas";
            this.cboHerramientas.Size = new System.Drawing.Size(190, 26);
            this.cboHerramientas.TabIndex = 6;
            this.cboHerramientas.SelectedIndexChanged += new System.EventHandler(this.cboHerramientas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(553, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 27);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 138);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 18);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblCambios
            // 
            this.lblCambios.AutoSize = true;
            this.lblCambios.Location = new System.Drawing.Point(14, 241);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(77, 18);
            this.lblCambios.TabIndex = 9;
            this.lblCambios.Text = "Cambios:";
            // 
            // txtCambios
            // 
            this.txtCambios.Location = new System.Drawing.Point(102, 243);
            this.txtCambios.MaxLength = 300;
            this.txtCambios.Name = "txtCambios";
            this.txtCambios.Size = new System.Drawing.Size(291, 25);
            this.txtCambios.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(556, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(464, 489);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(102, 97);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(190, 25);
            this.txtFecha.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(102, 175);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(190, 25);
            this.txtMarca.TabIndex = 14;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(102, 210);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(190, 25);
            this.txtModelo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Modelo:";
            // 
            // FrmNuevoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(654, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCambios);
            this.Controls.Add(this.lblCambios);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboHerramientas);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblMantenimiento);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmNuevoMantenimiento";
            this.Text = "Registrar Mantenimiento";
            this.Load += new System.EventHandler(this.FrmNuevoMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMantenimiento;
        private Label lblEmpleado;
        private TextBox txtEmpleado;
        private Label lblFecha;
        private DataGridView dgvDetalles;
        private ComboBox cboHerramientas;
        private Button btnAgregar;
        private Label lblCodigo;
        private Label lblCambios;
        private TextBox txtCambios;
        private Button btnSalir;
        private Button btnAceptar;
        private DataGridViewTextBoxColumn ColHer;
        private DataGridViewTextBoxColumn ColCambios;
        private DataGridViewButtonColumn ColAcc;
        private TextBox txtFecha;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label label1;
        private Label label2;
    }
}