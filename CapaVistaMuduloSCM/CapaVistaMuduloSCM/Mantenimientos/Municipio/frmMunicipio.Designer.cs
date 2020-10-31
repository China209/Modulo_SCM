﻿namespace CapaVistaMuduloSCM.Mantenimientos.Municipio
{
    partial class frmMunicipio
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
            this.pnlNavegador = new System.Windows.Forms.Panel();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbIdDepartamento = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbNombreDepartamento = new System.Windows.Forms.ComboBox();
            this.tltAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavegador
            // 
            this.pnlNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlNavegador.Controls.Add(this.navegador1);
            this.pnlNavegador.Location = new System.Drawing.Point(1, 1);
            this.pnlNavegador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNavegador.Name = "pnlNavegador";
            this.pnlNavegador.Size = new System.Drawing.Size(1428, 115);
            this.pnlNavegador.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(-15, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1424, 107);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.Location = new System.Drawing.Point(69, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.Location = new System.Drawing.Point(69, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label3.Location = new System.Drawing.Point(69, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label4.Location = new System.Drawing.Point(69, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label5.Location = new System.Drawing.Point(69, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtCodigo.Location = new System.Drawing.Point(214, 196);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(147, 23);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.Tag = "pk_id_municipio";
            // 
            // cmbIdDepartamento
            // 
            this.cmbIdDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.cmbIdDepartamento.FormattingEnabled = true;
            this.cmbIdDepartamento.Location = new System.Drawing.Point(214, 261);
            this.cmbIdDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdDepartamento.Name = "cmbIdDepartamento";
            this.cmbIdDepartamento.Size = new System.Drawing.Size(147, 25);
            this.cmbIdDepartamento.TabIndex = 7;
            this.cmbIdDepartamento.Tag = "fk_id_departamento";
            this.cmbIdDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtNombre.Location = new System.Drawing.Point(214, 362);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 23);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Tag = "nombre_municipio";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtDescripcion.Location = new System.Drawing.Point(214, 411);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 23);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.Tag = "descripcion_municipio";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(214, 460);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(147, 25);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.Tag = "estado_municipio";
            this.cmbEstado.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(673, 289);
            this.dataGridView1.TabIndex = 11;
            // 
            // cmbNombreDepartamento
            // 
            this.cmbNombreDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.cmbNombreDepartamento.FormattingEnabled = true;
            this.cmbNombreDepartamento.Location = new System.Drawing.Point(214, 298);
            this.cmbNombreDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNombreDepartamento.Name = "cmbNombreDepartamento";
            this.cmbNombreDepartamento.Size = new System.Drawing.Size(147, 25);
            this.cmbNombreDepartamento.TabIndex = 12;
            this.cmbNombreDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tltAyuda
            // 
            this.tltAyuda.IsBalloon = true;
            // 
            // frmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 587);
            this.Controls.Add(this.cmbNombreDepartamento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbIdDepartamento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNavegador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2305-Municipio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlNavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavegador;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbIdDepartamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbNombreDepartamento;
        private System.Windows.Forms.ToolTip tltAyuda;
    }
}