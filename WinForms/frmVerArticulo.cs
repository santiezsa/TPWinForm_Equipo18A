using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinForms
{
    public partial class frmVerArticulo : Form
    {
        public frmVerArticulo()
        {
            InitializeComponent();
        }

        // Objeto articulo para mostrar
        private Articulo articuloSeleccionado;
        private int indiceImagenActual = 0; // indice para navegar entre imagenes

        // Genero constructor que reciba un articulo a mostrar
        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articuloSeleccionado = articulo; // utilizo this para no confundir con la variable de la clase
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {

            if (articuloSeleccionado != null)
            {
                tbxVerCodigo.Text = articuloSeleccionado.Codigo;
                tbxVerNombre.Text = articuloSeleccionado.Nombre;
                tbxVerDescripcion.Text = articuloSeleccionado.Descripcion;

                // Marcas y categorias
                tbxVerMarca.Text = articuloSeleccionado.Marca.Descripcion;
                tbxVerCategoria.Text = articuloSeleccionado.Categoria.Descripcion;

                // Precio
                tbxVerPrecio.Text = articuloSeleccionado.Precio.ToString();

                // Ver varias imagenes o una imagen "placerholder" si no tiene imagen en la base
                cargarImagen(articuloSeleccionado.Imagenes.Count > 0 ? articuloSeleccionado.Imagenes[0].Url : "");
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picBoxArtVer.Load(imagen);
            }
            catch (Exception)
            {
                picBoxArtVer.Load("https://www.rubymaejewelry.com/wp-content/uploads/2010/07/placeholder.jpg");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Si hay mas de una imagen
            if (articuloSeleccionado.Imagenes.Count > 1)
            {
                indiceImagenActual--;
                if (indiceImagenActual < 0)
                {
                    indiceImagenActual = articuloSeleccionado.Imagenes.Count - 1; // Vuelve a la ultima imagen
                }
                cargarImagen(articuloSeleccionado.Imagenes[indiceImagenActual].Url);
                  
            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {

        }
    }
}
