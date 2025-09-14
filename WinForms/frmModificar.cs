using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForms
{
    public partial class frmModificar : Form
    {
        private Articulo articulo;
        public frmModificar()
        {
            InitializeComponent();
        }

        public frmModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void tablaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            // Valido campos no vacios
            if (string.IsNullOrEmpty(tbxModificarCodigo.Text))
            {
                MessageBox.Show("El campo Código no puede estar vacío.");
                return false;
            }

            if (!decimal.TryParse(tbxModificarCodigo.Text, out _))
            {
                MessageBox.Show("El precio ingresado no es un número válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbxModificarCodigo.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return false;
            }

            return true;
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                // Modifico el articulo
                articulo.Codigo = tbxModificarCodigo.Text;
                articulo.Nombre = tbxModificarNombre.Text;
                articulo.Descripcion = tbxModificarDescripcion.Text;
                articulo.Precio = decimal.Parse(tbxModificarPrecio.Text);
                articulo.Marca = (Marca)comboBoxModificarMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxModificarCategoria.SelectedItem;

                // Actualizar la URL de la imagen existente
                if (articulo.Imagenes.Count > 0)
                {
                    articulo.Imagenes[0].Url = tbxUrlImagenModificar.Text;
                }



                negocio.modificar(articulo);
                MessageBox.Show("Modificado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void frmModificar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                // Listo marcas y categorias en los combobox
                comboBoxModificarCategoria.DataSource = categoriasNegocio.listar();
                comboBoxModificarMarca.DataSource = marcasNegocio.listar();

                comboBoxModificarMarca.ValueMember = "Id";
                comboBoxModificarMarca.DisplayMember = "Descripcion";
                comboBoxModificarCategoria.ValueMember = "Id";
                comboBoxModificarCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    // Datos del articulo
                    tbxModificarCodigo.Text = articulo.Codigo;
                    tbxModificarNombre.Text = articulo.Nombre;
                    tbxModificarDescripcion.Text = articulo.Descripcion;
                    tbxModificarPrecio.Text = articulo.Precio.ToString();
                    tbxUrlImagenModificar.Text = articulo.Imagenes.Count > 0 ? articulo.Imagenes[0].Url : "";

                    // Seleccion de marca y categoria
                    comboBoxModificarMarca.SelectedValue = articulo.Marca.Id;
                    comboBoxModificarCategoria.SelectedValue = articulo.Categoria.Id;

                    // Imagen
                    if (articulo.Imagenes.Count > 0)
                    {
                        picBoxArtModificar.Text = articulo.Imagenes[0].Url;
                        cargarImagen(articulo.Imagenes[0].Url);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picBoxArtModificar.Load(imagen);
            }
            catch (Exception)
            {
                picBoxArtModificar.Load("https://www.rubymaejewelry.com/wp-content/uploads/2010/07/placeholder.jpg");
            }
        }

        private void picBoxArt_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagenModificar.Text);
        }
    }
}
