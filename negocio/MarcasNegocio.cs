using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcasNegocio
    {
        public List<Marca> listar()
        {
            // Lista de marcas
            List<Marca> lista = new List<Marca>();
            // Conexion con la base de datos
            SqlConnection conexion = new SqlConnection();
            // Ejecutar comandos en la base de datos
            SqlCommand comando = new SqlCommand();
            // Leer lo que devuelve la base de datos
            SqlDataReader lector;


            try
            {
                // Descomentar si usan Windows Authentication
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";

                // Usando Docker
                conexion.ConnectionString = "server=localhost; database=CATALOGO_P3_DB; user id=sa; password=BaseDeDatos#2";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion from Marcas";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    
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
