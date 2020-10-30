namespace CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega
{
    partial class frmEncargadoBodega
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvEncargadoDatos = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargadoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.navegador1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1786, 142);
            this.pnlSuperior.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(5, 5);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1767, 129);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 189);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(61, 263);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(89, 20);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Location = new System.Drawing.Point(61, 354);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(68, 20);
            this.lblBodega.TabIndex = 3;
            this.lblBodega.Text = "Bodega";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(61, 443);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 189);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Tag = "pk_id_encargado_bodega";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(168, 263);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 28);
            this.cmbEmpleado.TabIndex = 6;
            this.cmbEmpleado.Tag = "fk_id_empleado";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(168, 346);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(121, 28);
            this.cmbBodega.TabIndex = 7;
            this.cmbBodega.Tag = "fk_id_bodega";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(168, 435);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.Tag = "estado_encargado_bodega";
            // 
            // dgvEncargadoDatos
            // 
            this.dgvEncargadoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargadoDatos.Location = new System.Drawing.Point(452, 189);
            this.dgvEncargadoDatos.Name = "dgvEncargadoDatos";
            this.dgvEncargadoDatos.RowHeadersWidth = 51;
            this.dgvEncargadoDatos.RowTemplate.Height = 24;
            this.dgvEncargadoDatos.Size = new System.Drawing.Size(1280, 312);
            this.dgvEncargadoDatos.TabIndex = 9;
            // 
            // frmEncargadoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1786, 576);
            this.Controls.Add(this.dgvEncargadoDatos);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEncargadoBodega";
            this.Text = " 2314 -Encargado de Bodega";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargadoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvEncargadoDatos;
    }
}