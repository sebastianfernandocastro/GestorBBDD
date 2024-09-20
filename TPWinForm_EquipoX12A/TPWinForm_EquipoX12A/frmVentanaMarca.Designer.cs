namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaMarca
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
            this.lblNombreVenana = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnConfirmarBusqueda = new System.Windows.Forms.Button();
            this.txbIdBuscar = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnConfrimarBusqueda = new System.Windows.Forms.Button();
            this.txbDescripcionAgregar = new System.Windows.Forms.TextBox();
            this.lblDescripcionAgregar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreVenana
            // 
            this.lblNombreVenana.AutoSize = true;
            this.lblNombreVenana.Location = new System.Drawing.Point(41, 74);
            this.lblNombreVenana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreVenana.Name = "lblNombreVenana";
            this.lblNombreVenana.Size = new System.Drawing.Size(64, 16);
            this.lblNombreVenana.TabIndex = 10;
            this.lblNombreVenana.Text = "MARCAS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(311, 284);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 43);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(311, 172);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(149, 41);
            this.btnBuscarArticulo.TabIndex = 22;
            this.btnBuscarArticulo.Text = "BUSCAR";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(311, 228);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(149, 43);
            this.btnAgregarArticulo.TabIndex = 21;
            this.btnAgregarArticulo.Text = "AGREGAR";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(311, 120);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(149, 39);
            this.btnMostrarTodo.TabIndex = 20;
            this.btnMostrarTodo.Text = "MOSTRAR";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(40, 120);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(248, 207);
            this.dgvArticulos.TabIndex = 19;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlBuscar.Controls.Add(this.btnConfirmarBusqueda);
            this.pnlBuscar.Controls.Add(this.txbIdBuscar);
            this.pnlBuscar.Controls.Add(this.lblId);
            this.pnlBuscar.Location = new System.Drawing.Point(311, 344);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(149, 44);
            this.pnlBuscar.TabIndex = 24;
            // 
            // btnConfirmarBusqueda
            // 
            this.btnConfirmarBusqueda.Location = new System.Drawing.Point(91, 11);
            this.btnConfirmarBusqueda.Name = "btnConfirmarBusqueda";
            this.btnConfirmarBusqueda.Size = new System.Drawing.Size(50, 23);
            this.btnConfirmarBusqueda.TabIndex = 2;
            this.btnConfirmarBusqueda.Text = "OK";
            this.btnConfirmarBusqueda.UseVisualStyleBackColor = true;
            this.btnConfirmarBusqueda.Click += new System.EventHandler(this.btnConfirmarBusqueda_Click);
            // 
            // txbIdBuscar
            // 
            this.txbIdBuscar.Location = new System.Drawing.Point(28, 11);
            this.txbIdBuscar.Name = "txbIdBuscar";
            this.txbIdBuscar.Size = new System.Drawing.Size(57, 22);
            this.txbIdBuscar.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblId.Location = new System.Drawing.Point(3, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlAgregar.Controls.Add(this.btnConfrimarBusqueda);
            this.pnlAgregar.Controls.Add(this.txbDescripcionAgregar);
            this.pnlAgregar.Controls.Add(this.lblDescripcionAgregar);
            this.pnlAgregar.Location = new System.Drawing.Point(40, 344);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(248, 44);
            this.pnlAgregar.TabIndex = 25;
            // 
            // btnConfrimarBusqueda
            // 
            this.btnConfrimarBusqueda.Location = new System.Drawing.Point(193, 11);
            this.btnConfrimarBusqueda.Name = "btnConfrimarBusqueda";
            this.btnConfrimarBusqueda.Size = new System.Drawing.Size(47, 23);
            this.btnConfrimarBusqueda.TabIndex = 2;
            this.btnConfrimarBusqueda.Text = "OK";
            this.btnConfrimarBusqueda.UseVisualStyleBackColor = true;
            this.btnConfrimarBusqueda.Click += new System.EventHandler(this.btnConfrimarBusqueda_Click);
            // 
            // txbDescripcionAgregar
            // 
            this.txbDescripcionAgregar.Location = new System.Drawing.Point(101, 11);
            this.txbDescripcionAgregar.Name = "txbDescripcionAgregar";
            this.txbDescripcionAgregar.Size = new System.Drawing.Size(86, 22);
            this.txbDescripcionAgregar.TabIndex = 1;
            // 
            // lblDescripcionAgregar
            // 
            this.lblDescripcionAgregar.AutoSize = true;
            this.lblDescripcionAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescripcionAgregar.Location = new System.Drawing.Point(12, 14);
            this.lblDescripcionAgregar.Name = "lblDescripcionAgregar";
            this.lblDescripcionAgregar.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionAgregar.TabIndex = 0;
            this.lblDescripcionAgregar.Text = "Descripcion:";
            // 
            // frmVentanaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblNombreVenana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentanaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana de Marcas";
            this.Load += new System.EventHandler(this.frmVentanaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreVenana;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Button btnConfirmarBusqueda;
        private System.Windows.Forms.TextBox txbIdBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Button btnConfrimarBusqueda;
        private System.Windows.Forms.TextBox txbDescripcionAgregar;
        private System.Windows.Forms.Label lblDescripcionAgregar;
    }
}