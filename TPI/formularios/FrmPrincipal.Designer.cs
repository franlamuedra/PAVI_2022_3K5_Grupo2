namespace TPI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSoporte,
            this.tsmOperaciones,
            this.tsmReportes,
            this.tsmAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSoporte
            // 
            this.tsmSoporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.materialesToolStripMenuItem});
            this.tsmSoporte.Name = "tsmSoporte";
            this.tsmSoporte.Size = new System.Drawing.Size(60, 20);
            this.tsmSoporte.Text = "Soporte";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMaterialesToolStripMenuItem,
            this.nuevoMaterialToolStripMenuItem});
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialesToolStripMenuItem.Text = "Materiales";
            // 
            // consultarMaterialesToolStripMenuItem
            // 
            this.consultarMaterialesToolStripMenuItem.Name = "consultarMaterialesToolStripMenuItem";
            this.consultarMaterialesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarMaterialesToolStripMenuItem.Text = "Consultar materiales";
            this.consultarMaterialesToolStripMenuItem.Click += new System.EventHandler(this.consultarMaterialesToolStripMenuItem_Click);
            // 
            // nuevoMaterialToolStripMenuItem
            // 
            this.nuevoMaterialToolStripMenuItem.Name = "nuevoMaterialToolStripMenuItem";
            this.nuevoMaterialToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nuevoMaterialToolStripMenuItem.Text = "Nuevo material";
            this.nuevoMaterialToolStripMenuItem.Click += new System.EventHandler(this.nuevoMaterialToolStripMenuItem_Click);
            // 
            // tsmOperaciones
            // 
            this.tsmOperaciones.Name = "tsmOperaciones";
            this.tsmOperaciones.Size = new System.Drawing.Size(85, 20);
            this.tsmOperaciones.Text = "Operaciones";
            // 
            // tsmReportes
            // 
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(65, 20);
            this.tsmReportes.Text = "Reportes";
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Ferreteria Industrial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmSoporte;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem materialesToolStripMenuItem;
        private ToolStripMenuItem tsmAyuda;
        private ToolStripMenuItem tsmOperaciones;
        private ToolStripMenuItem tsmReportes;
        private ToolStripMenuItem consultarMaterialesToolStripMenuItem;
        private ToolStripMenuItem nuevoMaterialToolStripMenuItem;
    }
}