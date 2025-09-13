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
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcasNegocio negocio = new MarcasNegocio();

            try
            { 
                marca.Descripcion = txbAgregarDescricionMarca.Text;

                negocio.agregar(marca);
                MessageBox.Show("Marca agregada exitosamente.");
                Close();
            }
                        catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
