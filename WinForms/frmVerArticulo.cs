using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // Genero constructor que reciba un articulo a mostrar
        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articuloSeleccionado = articulo; // utilizo this para no confundir con la variable de la clase
        }

        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            
            if(articuloSeleccionado != null)
            {
                tbxVerCodigo.Text = articuloSeleccionado.Codigo;
                tbxVerNombre.Text = articuloSeleccionado.Nombre;
                tbxVerDescripcion.Text = articuloSeleccionado.Descripcion;

                // Marcas y categorias
                tbxVerMarca.Text = articuloSeleccionado.Marca.Descripcion;
                tbxVerCategoria.Text = articuloSeleccionado.Categoria.Descripcion;

                // Precio
                tbxVerPrecio.Text = articuloSeleccionado.Precio.ToString();

                // TODO: Agregar varias imagenes

            }

        }
    }
}
