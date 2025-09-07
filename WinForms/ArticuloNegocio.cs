using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            // Lista de articulos
            List<Articulo> lista = new List<Articulo>();
            // Conexion con la base de datos
            SqlConnection conexion = new SqlConnection();
            // Ejecutar comandos en la base de datos
            SqlCommand comando = new SqlCommand();
            // Leer lo que devuelve la base de datos
            SqlDataReader lector;


            try
            {
                // Descomentar si usan Windows Authentication
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                
                // Usando Docker
                //conexion.ConnectionString = "server=localhost; database=CATALOGO_P3_DB; user id=sa; password=BaseDeDatos#2";
                
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, Precio FROM Articulos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    //aux.Marca = (string)lector["Marca"];
                    //aux.Categoria = (string)lector["Categoria"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
