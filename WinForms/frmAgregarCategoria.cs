using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;


namespace WinForms
{
    public partial class frmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría";
        }

        private void txbAgregarCategoria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDescripcionAgregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            List<Categoria> categoriasExistentes = new List<Categoria>();

            try
            {
                if (string.IsNullOrWhiteSpace(txbAgregarCategoria.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }

                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txbAgregarCategoria.Text;
                
                try
                {
                    categoriasExistentes = negocio.listar();
                    string descripcionIngresada = txbAgregarCategoria.Text.Trim();
                    if (categoriasExistentes.Any(c => c.Descripcion.Equals(descripcionIngresada, StringComparison.OrdinalIgnoreCase) && (categoria == null || c.Id != categoria.Id)))
                    {
                        MessageBox.Show("Categoría repetida.");
                        return;
                    }
                    else
                    {
                        if (categoria.Id != 0)
                        {
                            negocio.modificar(categoria);
                            MessageBox.Show("Modificación exitosa");
                        }
                        else
                        {
                            negocio.agregar(categoria);
                            MessageBox.Show("Agregado exitosamente");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txbAgregarCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
