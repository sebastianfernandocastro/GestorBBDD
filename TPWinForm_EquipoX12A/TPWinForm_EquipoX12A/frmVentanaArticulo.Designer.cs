namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaArticulo
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
            this.lblContenidoDB = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.pnlCargaArticulo = new System.Windows.Forms.Panel();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmarAgregar = new System.Windows.Forms.Button();
            this.txbUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pbxUrlImagen = new System.Windows.Forms.PictureBox();
            this.txbIngresarPrecio = new System.Windows.Forms.TextBox();
            this.txbIngresarDescripcion = new System.Windows.Forms.TextBox();
            this.txbIngresarNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlFondoBusqueda = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbNombreBuscar = new System.Windows.Forms.TextBox();
            this.txbCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBusqueda = new System.Windows.Forms.Label();
            this.lblCodigoBusqueda = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.pnlCargaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).BeginInit();
            this.pnlFondoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContenidoDB
            // 
            this.lblContenidoDB.AutoSize = true;
            this.lblContenidoDB.Location = new System.Drawing.Point(14, 18);
            this.lblContenidoDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoDB.Name = "lblContenidoDB";
            this.lblContenidoDB.Size = new System.Drawing.Size(83, 16);
            this.lblContenidoDB.TabIndex = 0;
            this.lblContenidoDB.Text = "ARTICULOS";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(13, 64);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(874, 207);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(17, 310);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(249, 219);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 2;
            this.pbxProducto.TabStop = false;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(903, 64);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(149, 35);
            this.btnMostrarTodo.TabIndex = 0;
            this.btnMostrarTodo.Text = "MOSTRAR";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(904, 149);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(149, 35);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "AGREGAR";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // pnlCargaArticulo
            // 
            this.pnlCargaArticulo.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlCargaArticulo.Controls.Add(this.cbxCategoria);
            this.pnlCargaArticulo.Controls.Add(this.cbxMarca);
            this.pnlCargaArticulo.Controls.Add(this.btnConfirmarAgregar);
            this.pnlCargaArticulo.Controls.Add(this.txbUrlImagen);
            this.pnlCargaArticulo.Controls.Add(this.lblUrl);
            this.pnlCargaArticulo.Controls.Add(this.pbxUrlImagen);
            this.pnlCargaArticulo.Controls.Add(this.txbIngresarPrecio);
            this.pnlCargaArticulo.Controls.Add(this.txbIngresarDescripcion);
            this.pnlCargaArticulo.Controls.Add(this.txbIngresarNombre);
            this.pnlCargaArticulo.Controls.Add(this.lblCategoria);
            this.pnlCargaArticulo.Controls.Add(this.lblMarca);
            this.pnlCargaArticulo.Controls.Add(this.lblDescripcion);
            this.pnlCargaArticulo.Controls.Add(this.lblPrecio);
            this.pnlCargaArticulo.Controls.Add(this.lblNombre);
            this.pnlCargaArticulo.Controls.Add(this.txbIngresarCodigo);
            this.pnlCargaArticulo.Controls.Add(this.lblCodigo);
            this.pnlCargaArticulo.Location = new System.Drawing.Point(283, 310);
            this.pnlCargaArticulo.Name = "pnlCargaArticulo";
            this.pnlCargaArticulo.Size = new System.Drawing.Size(604, 219);
            this.pnlCargaArticulo.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(116, 142);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(120, 24);
            this.cbxCategoria.TabIndex = 4;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataSource = this.marcaBindingSource;
            this.cbxMarca.DisplayMember = "Descripcion";
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(116, 111);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(120, 24);
            this.cbxMarca.TabIndex = 3;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(dominio.Marca);
            // 
            // btnConfirmarAgregar
            // 
            this.btnConfirmarAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAgregar.Location = new System.Drawing.Point(513, 153);
            this.btnConfirmarAgregar.Name = "btnConfirmarAgregar";
            this.btnConfirmarAgregar.Size = new System.Drawing.Size(75, 44);
            this.btnConfirmarAgregar.TabIndex = 8;
            this.btnConfirmarAgregar.Text = "ACEPTAR";
            this.btnConfirmarAgregar.UseVisualStyleBackColor = true;
            this.btnConfirmarAgregar.Click += new System.EventHandler(this.btnConfirmarAgregar_Click);
            // 
            // txbUrlImagen
            // 
            this.txbUrlImagen.Location = new System.Drawing.Point(341, 15);
            this.txbUrlImagen.Name = "txbUrlImagen";
            this.txbUrlImagen.Size = new System.Drawing.Size(247, 22);
            this.txbUrlImagen.TabIndex = 6;
            this.txbUrlImagen.Leave += new System.EventHandler(this.txbUrlImagen_Leave);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.BackColor = System.Drawing.Color.DarkGray;
            this.lblUrl.Location = new System.Drawing.Point(254, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(75, 16);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "Url Imagen:";
            // 
            // pbxUrlImagen
            // 
            this.pbxUrlImagen.Location = new System.Drawing.Point(341, 47);
            this.pbxUrlImagen.Name = "pbxUrlImagen";
            this.pbxUrlImagen.Size = new System.Drawing.Size(166, 150);
            this.pbxUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrlImagen.TabIndex = 12;
            this.pbxUrlImagen.TabStop = false;
            // 
            // txbIngresarPrecio
            // 
            this.txbIngresarPrecio.Location = new System.Drawing.Point(116, 175);
            this.txbIngresarPrecio.Name = "txbIngresarPrecio";
            this.txbIngresarPrecio.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarPrecio.TabIndex = 5;
            this.txbIngresarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIngresarPrecio_KeyPress);
            // 
            // txbIngresarDescripcion
            // 
            this.txbIngresarDescripcion.Location = new System.Drawing.Point(116, 78);
            this.txbIngresarDescripcion.Name = "txbIngresarDescripcion";
            this.txbIngresarDescripcion.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarDescripcion.TabIndex = 2;
            // 
            // txbIngresarNombre
            // 
            this.txbIngresarNombre.Location = new System.Drawing.Point(116, 44);
            this.txbIngresarNombre.Name = "txbIngresarNombre";
            this.txbIngresarNombre.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.DarkGray;
            this.lblCategoria.Enabled = false;
            this.lblCategoria.Location = new System.Drawing.Point(17, 145);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categora:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.DarkGray;
            this.lblMarca.Location = new System.Drawing.Point(17, 114);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblPrecio.Location = new System.Drawing.Point(17, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombre.Location = new System.Drawing.Point(17, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbIngresarCodigo
            // 
            this.txbIngresarCodigo.Location = new System.Drawing.Point(116, 15);
            this.txbIngresarCodigo.Name = "txbIngresarCodigo";
            this.txbIngresarCodigo.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigo.Location = new System.Drawing.Point(17, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(903, 105);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(149, 35);
            this.btnBuscarArticulo.TabIndex = 1;
            this.btnBuscarArticulo.Text = "BUSCAR";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(904, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlFondoBusqueda
            // 
            this.pnlFondoBusqueda.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlFondoBusqueda.Controls.Add(this.btnLimpiar);
            this.pnlFondoBusqueda.Controls.Add(this.btnBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.txbNombreBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.txbCodigoBuscar);
            this.pnlFondoBusqueda.Controls.Add(this.lblNombreBusqueda);
            this.pnlFondoBusqueda.Controls.Add(this.lblCodigoBusqueda);
            this.pnlFondoBusqueda.Location = new System.Drawing.Point(903, 310);
            this.pnlFondoBusqueda.Name = "pnlFondoBusqueda";
            this.pnlFondoBusqueda.Size = new System.Drawing.Size(149, 219);
            this.pnlFondoBusqueda.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(25, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbNombreBuscar
            // 
            this.txbNombreBuscar.Location = new System.Drawing.Point(24, 93);
            this.txbNombreBuscar.Name = "txbNombreBuscar";
            this.txbNombreBuscar.Size = new System.Drawing.Size(100, 22);
            this.txbNombreBuscar.TabIndex = 1;
            this.txbNombreBuscar.Click += new System.EventHandler(this.txbNombreBuscar_Click);
            this.txbNombreBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNombreBuscar_KeyDown);
            // 
            // txbCodigoBuscar
            // 
            this.txbCodigoBuscar.Location = new System.Drawing.Point(24, 41);
            this.txbCodigoBuscar.Name = "txbCodigoBuscar";
            this.txbCodigoBuscar.Size = new System.Drawing.Size(100, 22);
            this.txbCodigoBuscar.TabIndex = 0;
            this.txbCodigoBuscar.Click += new System.EventHandler(this.txbCodigoBuscar_Click);
            this.txbCodigoBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCodigoBuscar_KeyDown);
            // 
            // lblNombreBusqueda
            // 
            this.lblNombreBusqueda.AutoSize = true;
            this.lblNombreBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombreBusqueda.Location = new System.Drawing.Point(43, 73);
            this.lblNombreBusqueda.Name = "lblNombreBusqueda";
            this.lblNombreBusqueda.Size = new System.Drawing.Size(59, 16);
            this.lblNombreBusqueda.TabIndex = 1;
            this.lblNombreBusqueda.Text = "Nombre:";
            // 
            // lblCodigoBusqueda
            // 
            this.lblCodigoBusqueda.AutoSize = true;
            this.lblCodigoBusqueda.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigoBusqueda.Location = new System.Drawing.Point(45, 18);
            this.lblCodigoBusqueda.Name = "lblCodigoBusqueda";
            this.lblCodigoBusqueda.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoBusqueda.TabIndex = 0;
            this.lblCodigoBusqueda.Text = "Codigo:";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(dominio.Categoria);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(903, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmVentanaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 569);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnlFondoBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.pnlCargaArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblContenidoDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentanaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Articulos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmVentanaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            this.pnlCargaArticulo.ResumeLayout(false);
            this.pnlCargaArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrlImagen)).EndInit();
            this.pnlFondoBusqueda.ResumeLayout(false);
            this.pnlFondoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContenidoDB;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Panel pnlCargaArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbIngresarCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIngresarNombre;
        private System.Windows.Forms.TextBox txbIngresarPrecio;
        private System.Windows.Forms.TextBox txbIngresarDescripcion;
        private System.Windows.Forms.PictureBox pbxUrlImagen;
        private System.Windows.Forms.TextBox txbUrlImagen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnConfirmarAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlFondoBusqueda;
        private System.Windows.Forms.Label lblNombreBusqueda;
        private System.Windows.Forms.Label lblCodigoBusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbNombreBuscar;
        private System.Windows.Forms.TextBox txbCodigoBuscar;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button btnEditar;
    }
}