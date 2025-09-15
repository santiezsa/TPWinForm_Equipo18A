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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            cargarMarca();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cargarMarca()
        {
            MarcasNegocio negocio = new MarcasNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna marca seleccionada para modificar.");
                return;
            }

            Marca seleccionado = new Marca();
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarca modificar = new frmAgregarMarca(seleccionado);
            modificar.ShowDialog();
            cargarMarca();
        }

        private void btnCerrarVentanaMarcas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna marca seleccionada para eliminar.");
                return;
            }
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            Marca seleccionado;
            try
                {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    marcasNegocio.eliminar(seleccionado.Id);
                    cargarMarca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
