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

            try
            {
                datos.SetearConsulta("select A.Id IDarticulo,A.Codigo codigoArticlo,A.Nombre nombreArticulo,A.Descripcion descripcionArticulo,A.IdMarca IDmarcaArticulo,MA.Descripcion marcaDescripcion,A.IdCategoria IDcategoriaArticulo,CA.Descripcion descripcionCategoria,A.Precio precioArticulo,I.ImagenUrl urlImagen from ARTICULOS A , MARCAS MA , CATEGORIAS CA , IMAGENES I where A.IdMarca=MA.Id and A.IdCategoria=CA.Id and A.Id=I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagen=new Imagen();

                    aux.IDArticulo = (int)datos.Lector["IDarticulo"];
                    aux.Codigo = (string)datos.Lector["codigoArticlo"];
                    aux.Nombre = (string)datos.Lector["nombreArticulo"];
                    if (!(datos.Lector["descripcionArticulo"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["descripcionArticulo"];
                    aux.Marca.IDMarca = (int)datos.Lector["IDmarcaArticulo"];
                    aux.Marca.Nombre = (string)datos.Lector["marcaDescripcion"];
                    aux.Categoria.IDCategoria = (int)datos.Lector["IDcategoriaArticulo"];
                    aux.Categoria.Descripcion=(string)datos.Lector["descripcionCategoria"];
                    if (!(datos.Lector["precioArticulo"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["precioArticulo"];                   
                    aux.Imagen.ImagenUrl = (string)datos.Lector["urlImagen"];
                    

                    lista.Add(aux);
                }
              
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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio)");
                datos.setearParametro("@codigo",nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.IDMarca);
                datos.setearParametro("@idCategoria", nuevo.Categoria.IDCategoria);
                datos.setearParametro("@precio", nuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Modificar(Articulo modificar)
        {
        }
    }
}