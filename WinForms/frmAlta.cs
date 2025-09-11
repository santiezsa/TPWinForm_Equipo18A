using negocio;
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
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();

            try
            {
                cbxMarcaAltaArt.DataSource = marcasNegocio.listar();
                cbxMarcaAltaArt.DisplayMember = "Descripcion";
                cbxMarcaAltaArt.ValueMember = "Id";

                cbxCategoriaAltaArt.DataSource = categoriasNegocio.listar();
                cbxCategoriaAltaArt.DisplayMember = "Descripcion";
                cbxCategoriaAltaArt.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
