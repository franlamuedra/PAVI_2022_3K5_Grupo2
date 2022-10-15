﻿namespace TPI
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
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
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
            this.tsmSoporte.Size = new System.Drawing.Size(60, 20);
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
            this.consultarMaterialesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            this.consultarProToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
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
            this.consultarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.consultarProveedoresToolStripMenuItem.Text = "Consultar proveedores";
            this.consultarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.consultarProveedoresToolStripMenuItem_Click);
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
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 340);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(351, 243);
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
    }
}