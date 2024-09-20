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
    public partial class frmVentanaMarca : Form
    {
        private List<Marca> marcas;
        public frmVentanaMarca()
        {
            InitializeComponent();
        }

        private void frmVentanaMarca_Load(object sender, EventArgs e)
        {
            pnlBuscar.Visible = false;
            pnlAgregar.Visible = false;
        }
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            pnlBuscar.Visible = false;
            pnlAgregar.Visible = false;
            NegocioMarca ArtNeg = new NegocioMarca();
            marcas = ArtNeg.listar();
            dgvArticulos.DataSource = marcas;
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            pnlBuscar.Visible = true;
            pnlAgregar.Visible = false;

        }

        private void btnConfirmarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioMarca ArtNeg = new NegocioMarca();
                Marca marca = new Marca();
                marca.Id = int.Parse(txbIdBuscar.Text);
                marcas = ArtNeg.buscar(marca);
                dgvArticulos.DataSource = marcas;
            }
            catch (Exception ex)
            {

                MessageBox.Show("El codigo no fue encontrado...");
            }
          
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = true;
            pnlBuscar.Visible = false;
        }

        private void btnConfrimarBusqueda_Click(object sender, EventArgs e)
        {
            NegocioMarca Marca = new NegocioMarca();
            try
            {
                Marca.agregar(txbDescripcionAgregar.Text);
                txbDescripcionAgregar.Clear();
                pnlAgregar.Visible=false;
                MessageBox.Show("Marca agregada correctamente...");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Complete los campos antes de aceptar...");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioMarca marcaNegocio = new NegocioMarca();


            if (dgvArticulos.CurrentRow != null)
            {
                Marca marcaSeleccionada = (Marca)dgvArticulos.CurrentRow.DataBoundItem;
                if (marcaNegocio.checkBorrar(marcaSeleccionada.Id))
                {
                    try
                    {

                        DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar la marca '{marcaSeleccionada.Descripcion}'?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {

                            marcaNegocio.borrar(marcaSeleccionada.Id);


                            List<Marca> marcas = marcaNegocio.listar();
                            dgvArticulos.DataSource = marcas;

                            MessageBox.Show("Marca eliminada con éxito.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el artículo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Esta marca tiene Articulos asociados, primero debe eliminarlos...");
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para eliminar.");
            }
        }
    }
}
