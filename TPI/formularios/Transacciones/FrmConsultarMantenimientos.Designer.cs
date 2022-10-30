namespace TPI.formularios.Transacciones
{
    partial class FrmConsultarMantenimientos
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
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.BackColor = System.Drawing.Color.BurlyWood;
            this.grbFiltros.Controls.Add(this.dtpHasta);
            this.grbFiltros.Controls.Add(this.dtpDesde);
            this.grbFiltros.Controls.Add(this.lblHasta);
            this.grbFiltros.Controls.Add(this.btnConsultar);
            this.grbFiltros.Controls.Add(this.txtEmpleado);
            this.grbFiltros.Controls.Add(this.lblEmpleado);
            this.grbFiltros.Controls.Add(this.lblDesde);
            this.grbFiltros.Location = new System.Drawing.Point(14, 12);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(747, 98);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(368, 28);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(228, 25);
            this.dtpHasta.TabIndex = 8;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(83, 28);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(228, 25);
            this.dtpDesde.TabIndex = 7;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(319, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(49, 18);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(655, 69);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(92, 65);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(225, 25);
            this.txtEmpleado.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(7, 72);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(82, 18);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(32, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(52, 18);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde";
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.AllowUserToDeleteRows = false;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.ColFecha,
            this.ColEmpleado,
            this.ColDetalle});
            this.dgvMantenimiento.Location = new System.Drawing.Point(14, 116);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.ReadOnly = true;
            this.dgvMantenimiento.RowHeadersWidth = 51;
            this.dgvMantenimiento.RowTemplate.Height = 25;
            this.dgvMantenimiento.Size = new System.Drawing.Size(747, 215);
            this.dgvMantenimiento.TabIndex = 1;
            this.dgvMantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantenimiento_CellContentClick);
            this.dgvMantenimiento.Click += new System.EventHandler(this.dgvMantenimiento_Click);
            // 
            // ColNum
            // 
            this.ColNum.HeaderText = "Mantenimiento #";
            this.ColNum.MinimumWidth = 6;
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Width = 130;
            // 
            // ColFecha
            // 
            this.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 78;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            // 
            // ColDetalle
            // 
            this.ColDetalle.HeaderText = "Detalle";
            this.ColDetalle.MinimumWidth = 6;
            this.ColDetalle.Name = "ColDetalle";
            this.ColDetalle.ReadOnly = true;
            this.ColDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDetalle.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(14, 337);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.brnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(106, 337);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(672, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConsultarMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(775, 368);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvMantenimiento);
            this.Controls.Add(this.grbFiltros);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmConsultarMantenimientos";
            this.Text = "Consultar Mantenimientos";
            this.Load += new System.EventHandler(this.FrmConsultarMantenimientos_Load);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbFiltros;
        private Button btnConsultar;
        private TextBox txtEmpleado;
        private Label lblEmpleado;
        private Label lblDesde;
        private DataGridView dgvMantenimiento;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnSalir;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private DataGridViewTextBoxColumn ColNum;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColEmpleado;
        private DataGridViewButtonColumn ColDetalle;
    }
}