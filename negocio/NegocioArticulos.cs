using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class NegocioArticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

           // SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;

            try
            {
                // conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "select A.Id,Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl, Precio from ARTICULOS A, IMAGENES IM  where A.Id=IM.IdArticulo";
                datos.SetearConsulta("select A.Id,Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl, Precio from ARTICULOS A, IMAGENES IM  where A.Id=IM.IdArticulo");
                //comando.Connection = conexion;
                //conexion.Open();
                //lector = comando.ExecuteReader();
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagen=new Imagen();

                    aux.IDArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.IDMarca = (int)datos.Lector["IdMarca"];
                    aux.Categoria.IDCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Imagen.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                //conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;

        }

        public void Agregar(Articulo nuevo)
        {

        }
        public void Modificar(Articulo modificar)
        {
        }
    }
}