﻿namespace CapaVistaModuloSCM.MDI
{
    partial class frmMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.txtVistaUsuario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.msMenuMDI = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teléfonoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasYPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlInferior.SuspendLayout();
            this.msMenuMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Controls.Add(this.txtVistaUsuario);
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 844);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1638, 60);
            this.pnlInferior.TabIndex = 5;
            // 
            // txtVistaUsuario
            // 
            this.txtVistaUsuario.Location = new System.Drawing.Point(76, 21);
            this.txtVistaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtVistaUsuario.Name = "txtVistaUsuario";
            this.txtVistaUsuario.Size = new System.Drawing.Size(230, 27);
            this.txtVistaUsuario.TabIndex = 2;
            this.txtVistaUsuario.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblFecha.Location = new System.Drawing.Point(1170, 21);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(1433, 21);
            this.lblHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 20);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // msMenuMDI
            // 
            this.msMenuMDI.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msMenuMDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.módulosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.msMenuMDI.Location = new System.Drawing.Point(0, 0);
            this.msMenuMDI.Name = "msMenuMDI";
            this.msMenuMDI.Padding = new System.Windows.Forms.Padding(16, 2, 0, 2);
            this.msMenuMDI.Size = new System.Drawing.Size(1638, 33);
            this.msMenuMDI.TabIndex = 4;
            this.msMenuMDI.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.rutaToolStripMenuItem});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.módulosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.correoProveedorToolStripMenuItem,
            this.teléfonoProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // correoProveedorToolStripMenuItem
            // 
            this.correoProveedorToolStripMenuItem.Name = "correoProveedorToolStripMenuItem";
            this.correoProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.correoProveedorToolStripMenuItem.Text = "Correo Proveedor";
            this.correoProveedorToolStripMenuItem.Click += new System.EventHandler(this.correoProveedorToolStripMenuItem_Click);
            // 
            // teléfonoProveedorToolStripMenuItem
            // 
            this.teléfonoProveedorToolStripMenuItem.Name = "teléfonoProveedorToolStripMenuItem";
            this.teléfonoProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.teléfonoProveedorToolStripMenuItem.Text = "Teléfono Proveedor";
            this.teléfonoProveedorToolStripMenuItem.Click += new System.EventHandler(this.teléfonoProveedorToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasYPedidosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.herramientasToolStripMenuItem.Text = "Procesos";
            // 
            // comprasYPedidosToolStripMenuItem
            // 
            this.comprasYPedidosToolStripMenuItem.Name = "comprasYPedidosToolStripMenuItem";
            this.comprasYPedidosToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.comprasYPedidosToolStripMenuItem.Text = "Compras y Pedidos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.ayudaToolStripMenuItem.Text = "Herramientas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(83, 29);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 904);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.msMenuMDI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "Módulo SCM";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.msMenuMDI.ResumeLayout(false);
            this.msMenuMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.TextBox txtVistaUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip msMenuMDI;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.ToolStripMenuItem comprasYPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teléfonoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
    }
}