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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar ventana = new frmModificar();
            ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar ventana = new frmEliminar();
            ventana.ShowDialog();
        }

        private void verArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (tablaArticulos.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Debe seleccionar un artículo para ver.");
            //    return;
            //}
            //else
            //{
            //    // Abre ventana para ver el articulo
            //    frmVerArticulo ventana = new frmVerArticulo();
            //    ventana.ShowDialog();
            //    return;
            //}
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas ventana = new frmMarcas();
            ventana.ShowDialog();

        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias ventana = new frmCategorias();
            ventana.ShowDialog();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.ShowDialog();
        }

        private void tablaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVerArticulo_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un artículo para ver.");
                return;
            }
            else
            {
                // Obtengo el objeto Articulo de la fila seleccionada por el usuario
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                // Abre ventana para ver el articulo y le paso el objeto obtenido
                frmVerArticulo ventana = new frmVerArticulo(articuloSeleccionado);
                ventana.ShowDialog();
                return;
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
