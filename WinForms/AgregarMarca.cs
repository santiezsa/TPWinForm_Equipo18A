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
    public partial class frmAgregarMarca : Form
    {
        private Marca marca = null;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txbAgregarDescricionMarca.Text = marca.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();

            try
            {
                if(string.IsNullOrWhiteSpace(txbAgregarDescricionMarca.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }
                
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Descripcion = txbAgregarDescricionMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.modificarMarca(marca);
                    MessageBox.Show("Marca modificada exitosamente.");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca agregada exitosamente.");
                }
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
