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
        public frmAgregarCategoria()
        {
            InitializeComponent();
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
            Categoria categoria = new Categoria();
            CategoriasNegocio negocio = new CategoriasNegocio();

            try
            {
                categoria.Descripcion = txbAgregarCategoria.Text;
                negocio.agregar(categoria);
                MessageBox.Show("Categoría agregada exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
