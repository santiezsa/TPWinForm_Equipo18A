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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();

            try
            {
                comboBoxAgregarArtMarca.DataSource = marcasNegocio.listar();
                comboBoxAgregarArtMarca.DisplayMember = "Descripcion";
                comboBoxAgregarArtMarca.ValueMember = "Id";


                comboBoxAgregarArtCategoria.DataSource = categoriasNegocio.listar();
                comboBoxAgregarArtCategoria.DisplayMember = "Descripcion";
                comboBoxAgregarArtCategoria.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void tbxAgregarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAgregarDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void labAgregarDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblAgregarPrecio_Click(object sender, EventArgs e)
        {

        }

        private void tbxAgregarPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void labAgregarImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminarImagen_Click(object sender, EventArgs e)
        {

        }

        private void grbAtributosArt_Enter(object sender, EventArgs e)
        {

        }

        private void labAgregarMarca_Click(object sender, EventArgs e)
        {

        }

        private void labCategoria_Click(object sender, EventArgs e)
        {

        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }

        private void picBoxArt_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCargaArt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grboxVistaPreviaImg_Enter(object sender, EventArgs e)
        {

        }

        private void grboxImagenArt_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = tbxAgregarCodigo.Text;
                articulo.Precio = decimal.Parse(tbxAgregarPrecio.Text);
                articulo.Nombre = tbxAgregarNombre.Text;
                articulo.Descripcion = tbxAgregarDescripcion.Text;
                articulo.Marca = (Marca)comboBoxAgregarArtMarca.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxAgregarArtCategoria.SelectedItem;

                // TODO: Falta agregar este metodo en ArticuloNegocio
                articulo.Imagenes = new List<Imagen>();

                Imagen imagen = new Imagen();
                imagen.Url = tbxUrlImagen.Text;
                articulo.Imagenes.Add(imagen);

                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente.");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBoxAgregarArtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picBoxArt.Load(imagen);
            }
            catch(Exception)
            {
                picBoxArt.Load("https://www.rubymaejewelry.com/wp-content/uploads/2010/07/placeholder.jpg");
            }
        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }
    }
}
