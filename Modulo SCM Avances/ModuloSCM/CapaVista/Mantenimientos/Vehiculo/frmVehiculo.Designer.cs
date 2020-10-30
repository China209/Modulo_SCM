namespace CapaVistaModuloSCM.Mantenimientos.Vehiculo
{
    partial class frmVehiculo
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.navegador1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1807, 147);
            this.pnlSuperior.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(14, 5);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1779, 129);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(66, 181);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(66, 241);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(65, 308);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(51, 20);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(67, 371);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(69, 20);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(66, 434);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 20);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(66, 491);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(41, 20);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Año";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(66, 553);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(149, 20);
            this.lblCombustible.TabIndex = 7;
            this.lblCombustible.Text = "Tipo Combustible";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(67, 612);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.Tag = "pk_id_vehiculo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(236, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Tag = "fk_id_marca";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 11;
            this.textBox2.Tag = "placa_vehiculo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 367);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 27);
            this.textBox3.TabIndex = 12;
            this.textBox3.Tag = "modelo_vehiculo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(237, 430);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 27);
            this.textBox4.TabIndex = 13;
            this.textBox4.Tag = "color_vehiculo";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(236, 487);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(163, 27);
            this.txtAnio.TabIndex = 14;
            this.txtAnio.Tag = "anio_vehiculo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(237, 549);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 27);
            this.textBox6.TabIndex = 15;
            this.textBox6.Tag = "tipo_combustible_vehiculo";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(237, 605);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 16;
            this.cmbEstado.Tag = "estado_vehiculo";
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(498, 188);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.Size = new System.Drawing.Size(1254, 433);
            this.dgvVehiculo.TabIndex = 17;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1807, 676);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCombustible);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVehiculo";
            this.Text = "2312 - Vehículo";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Label lblColor;
    }
}