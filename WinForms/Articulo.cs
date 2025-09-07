using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class Articulo
    {
        private int idArticulo;
        private string codArticulo;
        private string nombre;
        private string descripcion;
        private Marcas marca;
        private Categorias categoria;
        private List <urlImagen> imagenes;
        private float precio;



        public int IdArticulo { get => idArticulo; }
        public string CodArticulo { get => codArticulo; set => codArticulo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Marcas IdMarca { get => marca; set => marca = value; }
        public Categorias IdCategoria { get => categoria; set => categoria = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<urlImagen> CargarImagenes { get => imagenes; set => imagenes = value; }

    }
}
