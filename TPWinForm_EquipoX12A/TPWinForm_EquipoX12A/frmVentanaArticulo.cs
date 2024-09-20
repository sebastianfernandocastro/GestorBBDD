using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_EquipoX12A
{
    public partial class frmVentanaArticulo : Form
    {
        List<Articulo> articulos;
        Herramientas herramienta;
        public frmVentanaArticulo()
        {
            InitializeComponent();
        }

        //Al abrir la ventana esconde los paneles de Agregar y Buscar articulo.
        private void frmVentanaArticulo_Load(object sender, EventArgs e)
        {
            pnlCargaArticulo.Visible = false;
            pnlFondoBusqueda.Visible = false;
        }

        //Lista los arituculos y los carga en el DataGridView
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            articulos = ArtNeg.listar();
            dgvArticulos.DataSource = articulos;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        //Te habilita el PnlCargaArticulo y lista las marcas y categorias
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            pnlCargaArticulo.Visible = true;
            pnlFondoBusqueda.Visible = false;
            NegocioMarca marcas = new NegocioMarca();
            CategoriaNegocio categorias = new CategoriaNegocio();
            cbxMarca.DataSource = marcas.listar();
            cbxCategoria.DataSource = categorias.listar();

        }

        //Carga la imagen de la fila seleccionada.
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imgNeg = new ImagenNegocio();
            List<Imagen> listaImagen = imgNeg.listar();
            bool checkImagen = false;
            if(dgvArticulos.CurrentRow != null)
            {
                try
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    foreach (Imagen imagen in listaImagen)
                    {
                        if (imagen.IdArticulo == seleccionado.Id)
                        {
                            pbxProducto.Load(imagen.UrlImagen);
                            checkImagen = true;
                            break;
                        }
                    }
                    if (!checkImagen)
                    {
                        pbxProducto.Load(@"imagen-no-disponible.png");
                    }

                }
                catch (Exception ex)
                {
                    pbxProducto.Load(@"imagen-no-disponible.png");
                }
            }
            
        }
        
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            pnlCargaArticulo.Visible = false;
            pnlFondoBusqueda.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            if (dgvArticulos.CurrentRow != null)
            {
                try
                {

                    Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;


                    DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar el artículo '{articuloSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {

                        articuloNegocio.Eliminar(articuloSeleccionado.Id);


                        List<Articulo> articulos = articuloNegocio.listar();
                        dgvArticulos.DataSource = articulos;

                        MessageBox.Show("Artículo eliminado con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para eliminar.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = new Articulo();
                articulo.Codigo = (string)txbCodigoBuscar.Text;
                articulo.Nombre = (string)txbNombreBuscar.Text;
                articulos = articuloNegocio.buscarArticulo(articulo);
                dgvArticulos.DataSource = articulos;
                dgvArticulos.Columns["Id"].Visible = false;                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontraron articulos...");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCodigoBuscar.Enabled = true;
            txbNombreBuscar.Enabled = true;
            txbCodigoBuscar.Clear();
            txbNombreBuscar.Clear();
        }

        private void txbCodigoBuscar_Click(object sender, EventArgs e)
        {
            txbNombreBuscar.Enabled = false;
        }

        private void txbNombreBuscar_Click(object sender, EventArgs e)
        {
            txbCodigoBuscar.Enabled = false;
        }
        private void txbCodigoBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                btnBuscar_Click(sender, e);
            }
        }

        private void txbNombreBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void txbIngresarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            herramienta = new Herramientas();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            bool seCargo = false;

            try
            {
                articulo.Id = 0;
                articulo.Codigo = txbIngresarCodigo.Text;
                articulo.Nombre = txbIngresarNombre.Text;
                articulo.Descripcion = txbIngresarDescripcion.Text;
                articulo.Precio = decimal.Parse(txbIngresarPrecio.Text);
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articuloNegocio.cargarArticulo(articulo);
                seCargo = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formato de los datos ingresados...", "Error");
                seCargo = false;
            }
            finally
            {
                if(seCargo && herramienta.ValidarUrl(txbUrlImagen.Text) )
                {
                    List<Articulo> listaAxiliar = articuloNegocio.buscarArticulo(articulo);
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    Imagen imagenNueva = new Imagen();
                    imagenNueva.IdArticulo = listaAxiliar[0].Id;

                    imagenNueva.UrlImagen = txbUrlImagen.Text;

                    if(imagenNegocio.cargar(imagenNueva))
                    {
                        MessageBox.Show("Articulo e imagen cargados con exito...");
                    }
                    else
                    {
                        MessageBox.Show("El articulo fue cargado con exito, pero sin imagen...");
                    }

                }
                else if(seCargo)
                {
                    MessageBox.Show("El articulo fue cargado con exito, pero sin imagen...");
                }
            }

        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                string urlImagen = txbUrlImagen.Text;
                pbxUrlImagen.Load(urlImagen);
            }
            catch (Exception)
            {

                pbxUrlImagen.Load(@"imagen-no-disponible.png");

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmVentanaEditarArticulo ventanaEditar;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            if (dgvArticulos.CurrentRow != null)
            {
                try
                {

                    Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;


                    DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas editar el artículo '{articuloSeleccionado.Nombre}'?", "Confirmar edicion", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        ventanaEditar = new frmVentanaEditarArticulo(articuloSeleccionado);
                        ventanaEditar.ShowDialog();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al editar el artículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para editar.");
            }
        }


    }
}
