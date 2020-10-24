namespace CapaVista.Procesos
{
    partial class frmMovimientoInventarios
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1159, 35);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 35);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1159, 757);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 739);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1159, 53);
            this.pnlInferior.TabIndex = 2;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEliminar,
            this.itemActualizar});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(158, 52);
            // 
            // itemEliminar
            // 
            this.itemEliminar.Name = "itemEliminar";
            this.itemEliminar.Size = new System.Drawing.Size(157, 24);
            this.itemEliminar.Text = "Eliminar";
            // 
            // itemActualizar
            // 
            this.itemActualizar.Name = "itemActualizar";
            this.itemActualizar.Size = new System.Drawing.Size(157, 24);
            this.itemActualizar.Text = "Actualizar";
            this.itemActualizar.Click += new System.EventHandler(this.itemActualizar_Click);
            // 
            // frmMovimientoInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 792);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMovimientoInventarios";
            this.Text = "2400 - Movimientos de Inventarios";
            this.cmsOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem itemEliminar;
        private System.Windows.Forms.ToolStripMenuItem itemActualizar;
    }
}