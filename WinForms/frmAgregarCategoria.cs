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

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txbAgregarCategoria.Text;
                
                if(categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificación exitosa");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado exitosamente");
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
