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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregarCategoria = new frmAgregarCategoria();
            agregarCategoria.ShowDialog();
            cargarCategoria();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbAdmCategorias_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategoriasBis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarCategoria()
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            dgvCategorias.DataSource = negocio.listar();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarCategoria modificar = new frmAgregarCategoria(seleccionado);
            modificar.ShowDialog();
            cargarCategoria();
        }

        private void btnCerrarCategorias_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            Categoria seleccionado;
            try
                {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargarCategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
