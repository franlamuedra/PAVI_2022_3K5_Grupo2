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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlqulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSoporte,
            this.tsmOperaciones,
            this.tsmReportes,
            this.tsmAyuda,
            this.tsmUsuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSoporte
            // 
            this.tsmSoporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.tsmSoporte.Name = "tsmSoporte";
            this.tsmSoporte.Size = new System.Drawing.Size(66, 19);
            this.tsmSoporte.Text = "Soporte";
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMaterialesToolStripMenuItem});
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialesToolStripMenuItem.Text = "Materiales";
            // 
            // consultarMaterialesToolStripMenuItem
            // 
            this.consultarMaterialesToolStripMenuItem.Name = "consultarMaterialesToolStripMenuItem";
            this.consultarMaterialesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.consultarMaterialesToolStripMenuItem.Text = "Consultar materiales";
            this.consultarMaterialesToolStripMenuItem.Click += new System.EventHandler(this.consultarMaterialesToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // consultarProToolStripMenuItem
            // 
            this.consultarProToolStripMenuItem.Name = "consultarProToolStripMenuItem";
            this.consultarProToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.consultarProToolStripMenuItem.Text = "Consultar herramientas";
            this.consultarProToolStripMenuItem.Click += new System.EventHandler(this.consultarProToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // consultarProveedoresToolStripMenuItem
            // 
            this.consultarProveedoresToolStripMenuItem.Name = "consultarProveedoresToolStripMenuItem";
            this.consultarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.consultarProveedoresToolStripMenuItem.Text = "Consultar proveedores";
            this.consultarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedoresToolStripMenuItem_Click);
            // 
            // tsmOperaciones
            // 
            this.tsmOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPresupuestosToolStripMenuItem,
            this.nuevoMantenimientosToolStripMenuItem,
            this.consultarAlquileresToolStripMenuItem,
            this.nuevoAlqulerToolStripMenuItem});
            this.tsmOperaciones.Name = "tsmOperaciones";
            this.tsmOperaciones.Size = new System.Drawing.Size(95, 19);
            this.tsmOperaciones.Text = "Operaciones";
            // 
            // consultarPresupuestosToolStripMenuItem
            // 
            this.consultarPresupuestosToolStripMenuItem.Name = "consultarPresupuestosToolStripMenuItem";
            this.consultarPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.consultarPresupuestosToolStripMenuItem.Text = "Consultar Mantenimientos";
            this.consultarPresupuestosToolStripMenuItem.Click += new System.EventHandler(this.consultarPresupuestosToolStripMenuItem_Click);
            // 
            // nuevoMantenimientosToolStripMenuItem
            // 
            this.nuevoMantenimientosToolStripMenuItem.Name = "nuevoMantenimientosToolStripMenuItem";
            this.nuevoMantenimientosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.nuevoMantenimientosToolStripMenuItem.Text = "Nuevo Mantenimiento";
            this.nuevoMantenimientosToolStripMenuItem.Click += new System.EventHandler(this.nuevoMantenimientosToolStripMenuItem_Click);
            // 
            // consultarAlquileresToolStripMenuItem
            // 
            this.consultarAlquileresToolStripMenuItem.Name = "consultarAlquileresToolStripMenuItem";
            this.consultarAlquileresToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.consultarAlquileresToolStripMenuItem.Text = "Consultar Alquileres";
            this.consultarAlquileresToolStripMenuItem.Click += new System.EventHandler(this.consultarAlquileresToolStripMenuItem_Click);
            // 
            // nuevoAlqulerToolStripMenuItem
            // 
            this.nuevoAlqulerToolStripMenuItem.Name = "nuevoAlqulerToolStripMenuItem";
            this.nuevoAlqulerToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.nuevoAlqulerToolStripMenuItem.Text = "Nuevo Alquiler";
            this.nuevoAlqulerToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlqulerToolStripMenuItem_Click);
            // 
            // tsmReportes
            // 
            this.tsmReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeMantenimientoToolStripMenuItem,
            this.reporteDeHerramientasToolStripMenuItem});
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(73, 19);
            this.tsmReportes.Text = "Reportes";
            // 
            // reporteDeMantenimientoToolStripMenuItem
            // 
            this.reporteDeMantenimientoToolStripMenuItem.Name = "reporteDeMantenimientoToolStripMenuItem";
            this.reporteDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.reporteDeMantenimientoToolStripMenuItem.Text = "Reporte de Mantenimiento";
            this.reporteDeMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeMantenimientoToolStripMenuItem_Click);
            // 
            // reporteDeHerramientasToolStripMenuItem
            // 
            this.reporteDeHerramientasToolStripMenuItem.Name = "reporteDeHerramientasToolStripMenuItem";
            this.reporteDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.reporteDeHerramientasToolStripMenuItem.Text = "Reporte de Alquileres";
            this.reporteDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeHerramientasToolStripMenuItem_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(58, 19);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmUsuario.Size = new System.Drawing.Size(66, 19);
            this.tsmUsuario.Text = "Usuario";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1054, 570);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(542, 321);
            this.Name = "FrmPrincipal";
            this.Text = "Ferreteria Industrial";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmSoporte;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem materialesToolStripMenuItem;
        private ToolStripMenuItem tsmAyuda;
        private ToolStripMenuItem tsmOperaciones;
        private ToolStripMenuItem tsmReportes;
        private ToolStripMenuItem consultarMaterialesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem consultarProToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem consultarProveedoresToolStripMenuItem;
        private ImageList imageList1;
        private ToolStripMenuItem tsmUsuario;
        private ToolStripMenuItem consultarPresupuestosToolStripMenuItem;
        private ToolStripMenuItem nuevoMantenimientosToolStripMenuItem;
        private ToolStripMenuItem reporteDeMantenimientoToolStripMenuItem;
        private ToolStripMenuItem reporteDeHerramientasToolStripMenuItem;
        private ToolStripMenuItem consultarAlquileresToolStripMenuItem;
        private ToolStripMenuItem nuevoAlqulerToolStripMenuItem;
    }
}