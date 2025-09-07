using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class Categorias
    {
        private int idCategoria;
        private string descripcion;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
