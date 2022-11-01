namespace TPI.formularios.Transacciones
{
    partial class FrmConsultarAlquileres
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
            this.dgvAlquiler = new System.Windows.Forms.DataGridView();
            this.ColAlq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.AllowUserToAddRows = false;
            this.dgvAlquiler.AllowUserToDeleteRows = false;
            this.dgvAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAlq,
            this.ColDir,
            this.ColEntre,
            this.ColDev,
            this.ColDetalle});
            this.dgvAlquiler.Location = new System.Drawing.Point(12, 118);
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.ReadOnly = true;
            this.dgvAlquiler.RowTemplate.Height = 25;
            this.dgvAlquiler.Size = new System.Drawing.Size(592, 212);
            this.dgvAlquiler.TabIndex = 0;
            this.dgvAlquiler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquiler_CellContentClick);
            // 
            // ColAlq
            // 
            this.ColAlq.HeaderText = "Alquiler";
            this.ColAlq.Name = "ColAlq";
            this.ColAlq.ReadOnly = true;
            // 
            // ColDir
            // 
            this.ColDir.HeaderText = "Direccion";
            this.ColDir.Name = "ColDir";
            this.ColDir.ReadOnly = true;
            // 
            // ColEntre
            // 
            this.ColEntre.HeaderText = "Entrega";
            this.ColEntre.Name = "ColEntre";
            this.ColEntre.ReadOnly = true;
            // 
            // ColDev
            // 
            this.ColDev.HeaderText = "Devolucion";
            this.ColDev.Name = "ColDev";
            this.ColDev.ReadOnly = true;
            // 
            // ColDetalle
            // 
            this.ColDetalle.HeaderText = "Detalle";
            this.ColDetalle.Name = "ColDetalle";
            this.ColDetalle.ReadOnly = true;
            this.ColDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.dtpHasta);
            this.grbFiltros.Controls.Add(this.label2);
            this.grbFiltros.Controls.Add(this.btnConsultar);
            this.grbFiltros.Controls.Add(this.dtpDesde);
            this.grbFiltros.Controls.Add(this.label1);
            this.grbFiltros.Location = new System.Drawing.Point(12, 12);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(592, 100);
            this.grbFiltros.TabIndex = 1;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(367, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(219, 23);
            this.dtpHasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(511, 71);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(75, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(212, 23);
            this.dtpDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(481, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(93, 336);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 336);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmConsultarAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 371);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.dgvAlquiler);
            this.Name = "FrmConsultarAlquileres";
            this.Text = "Consultar Alquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAlquiler;
        private GroupBox grbFiltros;
        private DateTimePicker dtpDesde;
        private Label label1;
        private DataGridViewTextBoxColumn ColAlq;
        private DataGridViewTextBoxColumn ColDir;
        private DataGridViewTextBoxColumn ColEntre;
        private DataGridViewTextBoxColumn ColDev;
        private DataGridViewButtonColumn ColDetalle;
        private DateTimePicker dtpHasta;
        private Label label2;
        private Button btnConsultar;
        private Button btnSalir;
        private Button btnBorrar;
        private Button btnEditar;
    }
}