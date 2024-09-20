namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnMostrarDB = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMostrarMarca = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMostrarDescripcion = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMostrarDB,
            this.tsbtnMostrarMarca,
            this.tsbtnMostrarDescripcion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1073, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnMostrarDB
            // 
            this.tsbtnMostrarDB.AutoSize = false;
            this.tsbtnMostrarDB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnMostrarDB.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbtnMostrarDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarDB.Name = "tsbtnMostrarDB";
            this.tsbtnMostrarDB.Size = new System.Drawing.Size(75, 25);
            this.tsbtnMostrarDB.Text = "ARTICULOS";
            this.tsbtnMostrarDB.ToolTipText = "ARTICULOS";
            this.tsbtnMostrarDB.Click += new System.EventHandler(this.tsbtnMostrarDB_Click);
            // 
            // tsbtnMostrarMarca
            // 
            this.tsbtnMostrarMarca.AutoSize = false;
            this.tsbtnMostrarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMostrarMarca.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnMostrarMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMostrarMarca.Image")));
            this.tsbtnMostrarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarMarca.Name = "tsbtnMostrarMarca";
            this.tsbtnMostrarMarca.Size = new System.Drawing.Size(75, 25);
            this.tsbtnMostrarMarca.Text = "MARCAS";
            this.tsbtnMostrarMarca.Click += new System.EventHandler(this.tsbtnMostrarMarca_Click);
            // 
            // tsbtnMostrarDescripcion
            // 
            this.tsbtnMostrarDescripcion.AutoSize = false;
            this.tsbtnMostrarDescripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMostrarDescripcion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnMostrarDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMostrarDescripcion.Image")));
            this.tsbtnMostrarDescripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMostrarDescripcion.Name = "tsbtnMostrarDescripcion";
            this.tsbtnMostrarDescripcion.Size = new System.Drawing.Size(100, 25);
            this.tsbtnMostrarDescripcion.Text = "CATEGORIAS";
            this.tsbtnMostrarDescripcion.Click += new System.EventHandler(this.tsbtnMostrarDescripcion_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1073, 609);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentanaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de BBDD";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarDB;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarMarca;
        private System.Windows.Forms.ToolStripButton tsbtnMostrarDescripcion;
    }
}