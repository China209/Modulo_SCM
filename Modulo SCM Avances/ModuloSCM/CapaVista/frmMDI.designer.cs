namespace CapaVista
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pbxImagenMDI = new System.Windows.Forms.PictureBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.msMenuMDI = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encargadoBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fábricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.líneaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMDI)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.msMenuMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.pbxImagenMDI);
            this.pnlPrincipal.Controls.Add(this.pnlInferior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 30);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1005, 532);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pbxImagenMDI
            // 
            this.pbxImagenMDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImagenMDI.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenMDI.Image")));
            this.pbxImagenMDI.Location = new System.Drawing.Point(0, 0);
            this.pbxImagenMDI.Name = "pbxImagenMDI";
            this.pbxImagenMDI.Size = new System.Drawing.Size(1005, 445);
            this.pbxImagenMDI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenMDI.TabIndex = 1;
            this.pbxImagenMDI.TabStop = false;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 445);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1005, 87);
            this.pnlInferior.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(771, 31);
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
            this.lblHora.Location = new System.Drawing.Point(936, 31);
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
            this.msMenuMDI.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.msMenuMDI.Size = new System.Drawing.Size(1005, 30);
            this.msMenuMDI.TabIndex = 1;
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
            this.bodegaToolStripMenuItem,
            this.encargadoBodegaToolStripMenuItem,
            this.estadoProductoToolStripMenuItem,
            this.fábricaToolStripMenuItem,
            this.líneaDeProductoToolStripMenuItem,
            this.categoriaProductoToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.municipioToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.sucursalToolStripMenuItem});
            this.sCMToolStripMenuItem.Name = "sCMToolStripMenuItem";
            this.sCMToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sCMToolStripMenuItem.Text = "SCM";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // encargadoBodegaToolStripMenuItem
            // 
            this.encargadoBodegaToolStripMenuItem.Name = "encargadoBodegaToolStripMenuItem";
            this.encargadoBodegaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.encargadoBodegaToolStripMenuItem.Text = "Encargado Bodega";
            this.encargadoBodegaToolStripMenuItem.Click += new System.EventHandler(this.encargadoBodegaToolStripMenuItem_Click);
            // 
            // estadoProductoToolStripMenuItem
            // 
            this.estadoProductoToolStripMenuItem.Name = "estadoProductoToolStripMenuItem";
            this.estadoProductoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.estadoProductoToolStripMenuItem.Text = "Estado Producto";
            this.estadoProductoToolStripMenuItem.Click += new System.EventHandler(this.estadoProductoToolStripMenuItem_Click);
            // 
            // fábricaToolStripMenuItem
            // 
            this.fábricaToolStripMenuItem.Name = "fábricaToolStripMenuItem";
            this.fábricaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.fábricaToolStripMenuItem.Text = "Fábrica";
            this.fábricaToolStripMenuItem.Click += new System.EventHandler(this.fábricaToolStripMenuItem_Click);
            // 
            // líneaDeProductoToolStripMenuItem
            // 
            this.líneaDeProductoToolStripMenuItem.Name = "líneaDeProductoToolStripMenuItem";
            this.líneaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.líneaDeProductoToolStripMenuItem.Text = "Línea de Producto";
            this.líneaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.líneaDeProductoToolStripMenuItem_Click);
            // 
            // categoriaProductoToolStripMenuItem
            // 
            this.categoriaProductoToolStripMenuItem.Name = "categoriaProductoToolStripMenuItem";
            this.categoriaProductoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.categoriaProductoToolStripMenuItem.Text = "Categoria Producto";
            this.categoriaProductoToolStripMenuItem.Click += new System.EventHandler(this.categoriaProductoToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            this.municipioToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.municipioToolStripMenuItem.Text = "Municipio";
            this.municipioToolStripMenuItem.Click += new System.EventHandler(this.municipioToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
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
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 562);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.msMenuMDI);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMDI)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.msMenuMDI.ResumeLayout(false);
            this.msMenuMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.MenuStrip msMenuMDI;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxImagenMDI;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encargadoBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fábricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem líneaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municipioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
    }
}