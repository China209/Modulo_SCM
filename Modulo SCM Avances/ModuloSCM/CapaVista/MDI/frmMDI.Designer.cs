namespace CapaVistaModuloSCM.MDI
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
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.msMenuMDI = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encargadoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInferior.SuspendLayout();
            this.msMenuMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Controls.Add(this.textBox1);
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 784);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1638, 120);
            this.pnlInferior.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.lblFecha.Location = new System.Drawing.Point(1150, 39);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(1413, 39);
            this.lblHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // msMenuMDI
            // 
            this.msMenuMDI.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msMenuMDI.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.visualizaToolStripMenuItem,
            this.datosToolStripMenuItem,
            this.módulosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msMenuMDI.Location = new System.Drawing.Point(0, 0);
            this.msMenuMDI.Name = "msMenuMDI";
            this.msMenuMDI.Padding = new System.Windows.Forms.Padding(16, 2, 0, 2);
            this.msMenuMDI.Size = new System.Drawing.Size(1638, 30);
            this.msMenuMDI.TabIndex = 4;
            this.msMenuMDI.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // visualizaToolStripMenuItem
            // 
            this.visualizaToolStripMenuItem.Name = "visualizaToolStripMenuItem";
            this.visualizaToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.visualizaToolStripMenuItem.Text = "Visualizar";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sCMToolStripMenuItem});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.módulosToolStripMenuItem.Text = "Módulos";
            // 
            // sCMToolStripMenuItem
            // 
            this.sCMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.sCMToolStripMenuItem.Name = "sCMToolStripMenuItem";
            this.sCMToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sCMToolStripMenuItem.Text = "SCM";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.encargadoBodegaToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.tipoDeMovimientoToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // encargadoBodegaToolStripMenuItem
            // 
            this.encargadoBodegaToolStripMenuItem.Name = "encargadoBodegaToolStripMenuItem";
            this.encargadoBodegaToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.encargadoBodegaToolStripMenuItem.Text = "Encargado Bodega";
            this.encargadoBodegaToolStripMenuItem.Click += new System.EventHandler(this.encargadoBodegaToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // tipoDeMovimientoToolStripMenuItem
            // 
            this.tipoDeMovimientoToolStripMenuItem.Name = "tipoDeMovimientoToolStripMenuItem";
            this.tipoDeMovimientoToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.tipoDeMovimientoToolStripMenuItem.Text = "Tipo de Movimiento";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 904);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.msMenuMDI);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip msMenuMDI;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encargadoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMovimientoToolStripMenuItem;
    }
}