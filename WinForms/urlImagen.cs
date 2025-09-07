using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class urlImagen
    {
        private int idImagen;
        private int idArticulo;
        private string url;

        public string Url { get => url; set => url = value; }
        public int IdImagen { get => idImagen; set => idImagen = value; }
        public int IdArticulo { get => idArticulo; }
    }
}
