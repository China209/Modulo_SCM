namespace CapaVistaModuloSCM.Mantenimientos.Bodega
{
    partial class frmBodega
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.navegador1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1769, 130);
            this.pnlSuperior.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(0, 5);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1765, 129);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(51, 165);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(51, 251);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(88, 20);
            this.lblMunicipio.TabIndex = 2;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(51, 318);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Location = new System.Drawing.Point(51, 458);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(112, 20);
            this.lblDimensiones.TabIndex = 4;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(51, 529);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(51, 603);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(51, 677);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(183, 165);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.Tag = "pk_id_bodega";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(183, 251);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(121, 28);
            this.cmbMunicipio.TabIndex = 9;
            this.cmbMunicipio.Tag = "fk_id_municipio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(183, 318);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(244, 108);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Tag = "descripcion_bodega";
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(183, 458);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 27);
            this.txtDimension.TabIndex = 11;
            this.txtDimension.Tag = "dimensiones_bodega";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(183, 529);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 27);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.Tag = "direccion_bodega";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(183, 603);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 27);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.Tag = "telefono_bodega";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(183, 677);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 14;
            this.cmbEstado.Tag = "estado_bodega";
            // 
            // dgvBodega
            // 
            this.dgvBodega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Location = new System.Drawing.Point(520, 200);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.RowHeadersWidth = 51;
            this.dgvBodega.RowTemplate.Height = 24;
            this.dgvBodega.Size = new System.Drawing.Size(1196, 496);
            this.dgvBodega.TabIndex = 15;
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1769, 755);
            this.Controls.Add(this.dgvBodega);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDimensiones);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBodega";
            this.Text = "2313 - Bodega";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvBodega;
        private System.Windows.Forms.Label lblCodigo;
    }
}