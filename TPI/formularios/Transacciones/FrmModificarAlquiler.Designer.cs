namespace TPI.formularios.Transacciones
{
    partial class FrmModificarAlquiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColHer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboHerramientas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquiler N";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(611, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHer,
            this.ColDir,
            this.ColAcc});
            this.dgvDetalle.Location = new System.Drawing.Point(14, 135);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(683, 187);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ColHer
            // 
            this.ColHer.HeaderText = "Herramienta";
            this.ColHer.Name = "ColHer";
            this.ColHer.ReadOnly = true;
            // 
            // ColDir
            // 
            this.ColDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDir.HeaderText = "Direccion";
            this.ColDir.Name = "ColDir";
            this.ColDir.ReadOnly = true;
            // 
            // ColAcc
            // 
            this.ColAcc.HeaderText = "Acciones";
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.ReadOnly = true;
            this.ColAcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAcc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(611, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(519, 344);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(58, 109);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(65, 15);
            this.lblD.TabIndex = 1;
            this.lblD.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Herramienta";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(269, 22);
            this.txtDireccion.TabIndex = 6;
            // 
            // cboHerramientas
            // 
            this.cboHerramientas.FormattingEnabled = true;
            this.cboHerramientas.Location = new System.Drawing.Point(130, 77);
            this.cboHerramientas.Name = "cboHerramientas";
            this.cboHerramientas.Size = new System.Drawing.Size(138, 23);
            this.cboHerramientas.TabIndex = 11;
            // 
            // FrmModificarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(710, 376);
            this.Controls.Add(this.cboHerramientas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 415);
            this.MinimumSize = new System.Drawing.Size(726, 415);
            this.Name = "FrmModificarAlquiler";
            this.Text = "Modificar Alquiler";
            this.Load += new System.EventHandler(this.FrmModificarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblD;
        private Label label3;
        private TextBox txtDireccion;
        private ComboBox cboHerramientas;
        private DataGridViewTextBoxColumn ColHer;
        private DataGridViewTextBoxColumn ColDir;
        private DataGridViewButtonColumn ColAcc;
    }
}