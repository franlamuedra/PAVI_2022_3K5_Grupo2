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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMantenimiento.Location = new System.Drawing.Point(14, 20);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(180, 22);
            this.lblMantenimiento.TabIndex = 0;
            this.lblMantenimiento.Text = "Mantenimiento N:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(14, 71);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(67, 15);
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(89, 68);
            this.txtEmpleado.MaxLength = 50;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(190, 22);
            this.txtEmpleado.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 100);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
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
            this.dgvDetalles.Location = new System.Drawing.Point(14, 196);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowTemplate.Height = 25;
            this.dgvDetalles.Size = new System.Drawing.Size(625, 166);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColHer
            // 
            this.ColHer.HeaderText = "Herramienta";
            this.ColHer.Name = "ColHer";
            this.ColHer.ReadOnly = true;
            // 
            // ColCambios
            // 
            this.ColCambios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCambios.HeaderText = "Cambios";
            this.ColCambios.Name = "ColCambios";
            this.ColCambios.ReadOnly = true;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Acciones";
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
            this.cboHerramientas.Location = new System.Drawing.Point(89, 138);
            this.cboHerramientas.Name = "cboHerramientas";
            this.cboHerramientas.Size = new System.Drawing.Size(266, 23);
            this.cboHerramientas.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(553, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 141);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 15);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCambios
            // 
            this.lblCambios.AutoSize = true;
            this.lblCambios.Location = new System.Drawing.Point(21, 170);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(59, 15);
            this.lblCambios.TabIndex = 9;
            this.lblCambios.Text = "Cambios";
            // 
            // txtCambios
            // 
            this.txtCambios.Location = new System.Drawing.Point(89, 167);
            this.txtCambios.MaxLength = 300;
            this.txtCambios.Name = "txtCambios";
            this.txtCambios.Size = new System.Drawing.Size(371, 22);
            this.txtCambios.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(553, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(461, 380);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(89, 97);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(190, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // FrmNuevoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(653, 412);
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
    }
}