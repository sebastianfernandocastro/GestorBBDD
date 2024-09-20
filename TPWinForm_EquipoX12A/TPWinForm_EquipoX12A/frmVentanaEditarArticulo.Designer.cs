namespace TPWinForm_EquipoX12A
{
    partial class frmVentanaEditarArticulo
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
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
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
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DisplayMember = "descripcion";
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(125, 146);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(120, 24);
            this.cbxCategoria.TabIndex = 4;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DisplayMember = "Descripcion";
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(125, 115);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(120, 24);
            this.cbxMarca.TabIndex = 3;
            // 
            // txbIngresarPrecio
            // 
            this.txbIngresarPrecio.Location = new System.Drawing.Point(125, 179);
            this.txbIngresarPrecio.Name = "txbIngresarPrecio";
            this.txbIngresarPrecio.Size = new System.Drawing.Size(190, 22);
            this.txbIngresarPrecio.TabIndex = 5;
            // 
            // txbIngresarDescripcion
            // 
            this.txbIngresarDescripcion.Location = new System.Drawing.Point(125, 82);
            this.txbIngresarDescripcion.Name = "txbIngresarDescripcion";
            this.txbIngresarDescripcion.Size = new System.Drawing.Size(190, 22);
            this.txbIngresarDescripcion.TabIndex = 2;
            // 
            // txbIngresarNombre
            // 
            this.txbIngresarNombre.Location = new System.Drawing.Point(125, 48);
            this.txbIngresarNombre.Name = "txbIngresarNombre";
            this.txbIngresarNombre.Size = new System.Drawing.Size(190, 22);
            this.txbIngresarNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Enabled = false;
            this.lblCategoria.Location = new System.Drawing.Point(26, 149);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 18;
            this.lblCategoria.Text = "Categora:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Location = new System.Drawing.Point(26, 118);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(26, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(26, 182);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(26, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbIngresarCodigo
            // 
            this.txbIngresarCodigo.Location = new System.Drawing.Point(125, 19);
            this.txbIngresarCodigo.Name = "txbIngresarCodigo";
            this.txbIngresarCodigo.Size = new System.Drawing.Size(190, 22);
            this.txbIngresarCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(26, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(29, 226);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(99, 40);
            this.btnConfirmarEdicion.TabIndex = 6;
            this.btnConfirmarEdicion.Text = "CONFIRMAR";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Location = new System.Drawing.Point(216, 226);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(99, 40);
            this.btnCancelarEdicion.TabIndex = 7;
            this.btnCancelarEdicion.Text = "CANCELAR";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // frmVentanaEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 278);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnConfirmarEdicion);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txbIngresarPrecio);
            this.Controls.Add(this.txbIngresarDescripcion);
            this.Controls.Add(this.txbIngresarNombre);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbIngresarCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmVentanaEditarArticulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar articulo";
            this.Load += new System.EventHandler(this.frmVentanaEditarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox txbIngresarPrecio;
        private System.Windows.Forms.TextBox txbIngresarDescripcion;
        private System.Windows.Forms.TextBox txbIngresarNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIngresarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnConfirmarEdicion;
        private System.Windows.Forms.Button btnCancelarEdicion;
    }
}