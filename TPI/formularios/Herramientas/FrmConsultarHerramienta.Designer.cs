namespace TPI.formularios.Herramientas
{
    partial class FrmConsultarHerramienta
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
            this.lblHerramientas = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.dgvHerramienta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramienta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHerramientas
            // 
            this.lblHerramientas.AutoSize = true;
            this.lblHerramientas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHerramientas.Location = new System.Drawing.Point(12, 9);
            this.lblHerramientas.Name = "lblHerramientas";
            this.lblHerramientas.Size = new System.Drawing.Size(168, 32);
            this.lblHerramientas.TabIndex = 0;
            this.lblHerramientas.Text = "Herramientas";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(12, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 21);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.Location = new System.Drawing.Point(71, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(256, 29);
            this.txtMarca.TabIndex = 2;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(333, 79);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 19);
            this.chkActivo.TabIndex = 3;
            this.chkActivo.Text = "Activo?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // dgvHerramienta
            // 
            this.dgvHerramienta.AllowUserToAddRows = false;
            this.dgvHerramienta.AllowUserToDeleteRows = false;
            this.dgvHerramienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerramienta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColCodProv,
            this.ColMarca,
            this.ColModelo,
            this.ColVida,
            this.ColActivo});
            this.dgvHerramienta.Location = new System.Drawing.Point(12, 143);
            this.dgvHerramienta.Name = "dgvHerramienta";
            this.dgvHerramienta.ReadOnly = true;
            this.dgvHerramienta.RowTemplate.Height = 25;
            this.dgvHerramienta.Size = new System.Drawing.Size(698, 255);
            this.dgvHerramienta.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(621, 79);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 33);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(12, 428);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 38);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(100, 428);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 38);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(188, 428);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 38);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(628, 428);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 38);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ColCod
            // 
            this.ColCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColCod.DataPropertyName = "Codigo_Herramienta";
            this.ColCod.HeaderText = "Código";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.Width = 71;
            // 
            // ColCodProv
            // 
            this.ColCodProv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColCodProv.DataPropertyName = "Cod_Proveedor";
            this.ColCodProv.HeaderText = "Proveedor";
            this.ColCodProv.Name = "ColCodProv";
            this.ColCodProv.ReadOnly = true;
            this.ColCodProv.Width = 86;
            // 
            // ColMarca
            // 
            this.ColMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMarca.DataPropertyName = "Marca_Herramienta";
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            // 
            // ColModelo
            // 
            this.ColModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColModelo.DataPropertyName = "Modelo_Herramienta";
            this.ColModelo.HeaderText = "Modelo";
            this.ColModelo.Name = "ColModelo";
            this.ColModelo.ReadOnly = true;
            // 
            // ColVida
            // 
            this.ColVida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColVida.DataPropertyName = "VIda_Util";
            this.ColVida.HeaderText = "Vida Útil";
            this.ColVida.Name = "ColVida";
            this.ColVida.ReadOnly = true;
            this.ColVida.Width = 76;
            // 
            // ColActivo
            // 
            this.ColActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColActivo.DataPropertyName = "Activo";
            this.ColActivo.HeaderText = "Activo?";
            this.ColActivo.Name = "ColActivo";
            this.ColActivo.ReadOnly = true;
            this.ColActivo.Width = 71;
            // 
            // FrmConsultarHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 473);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvHerramienta);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblHerramientas);
            this.Name = "FrmConsultarHerramienta";
            this.Text = "Consultar Herramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerramienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHerramientas;
        private Label lblMarca;
        private TextBox txtMarca;
        private CheckBox chkActivo;
        private DataGridView dgvHerramienta;
        private Button btnConsultar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ColCod;
        private DataGridViewTextBoxColumn ColCodProv;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColModelo;
        private DataGridViewTextBoxColumn ColVida;
        private DataGridViewTextBoxColumn ColActivo;
    }
}