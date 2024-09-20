using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_EquipoX12A
{
    
    public partial class frmVentanaEditarArticulo : Form
    {
        private Articulo _articulo;
        public frmVentanaEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
        }

        private void frmVentanaEditarArticulo_Load(object sender, EventArgs e)
        {
            NegocioMarca marcas = new NegocioMarca();
            CategoriaNegocio categorias = new CategoriaNegocio();
            cbxMarca.DataSource = marcas.listar();
            cbxMarca.ValueMember = "Id";
            cbxMarca.SelectedValue = _articulo.Marca.Id;

            cbxCategoria.DataSource = categorias.listar();
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.SelectedValue = _articulo.Categoria.Id;

            txbIngresarCodigo.Text = _articulo.Codigo;
            txbIngresarNombre.Text = _articulo.Nombre;
            txbIngresarDescripcion.Text = _articulo.Descripcion;
            txbIngresarPrecio.Text = _articulo.Precio.ToString();
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNeg = new ArticuloNegocio();
            try
            {
                Articulo nuevoArticulo = new Articulo();
                nuevoArticulo.Id = _articulo.Id;
                nuevoArticulo.Descripcion = txbIngresarDescripcion.Text;
                nuevoArticulo.Nombre = txbIngresarNombre.Text;
                nuevoArticulo.Codigo = txbIngresarCodigo.Text;
                nuevoArticulo.Precio = decimal.Parse(txbIngresarPrecio.Text);
                nuevoArticulo.Marca = (Marca)cbxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                if (nuevoArticulo.Descripcion != _articulo.Descripcion ||
                    nuevoArticulo.Nombre != _articulo.Nombre || nuevoArticulo.Codigo != _articulo.Codigo
                    || nuevoArticulo.Precio != _articulo.Precio || nuevoArticulo.Marca.Id != _articulo.Marca.Id ||
                    nuevoArticulo.Categoria.Id != _articulo.Categoria.Id)
                {
                    artNeg.Editar(nuevoArticulo);
                    MessageBox.Show("Cambios realizados con exito...");
                    Close();
                }
                else
                {
                    MessageBox.Show("El articulo no presenta ninguna modificacion...");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo realizar el cambio...error 404");
            }
        }
    }
}
