using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using static System.Net.Mime.MediaTypeNames;

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
                    
                    
                    aux.IDArticulo = (int)datos.Lector["IDarticulo"];
                    aux.Codigo = (string)datos.Lector["codigoArticlo"];
                    aux.Nombre = (string)datos.Lector["nombreArticulo"];
                    if (!(datos.Lector["descripcionArticulo"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["descripcionArticulo"];
                    aux.Marca.IDMarca = (int)datos.Lector["IDmarcaArticulo"];
                    aux.Idmarca= (int)datos.Lector["IDmarcaArticulo"];
                    aux.Marca.Nombre = (string)datos.Lector["marcaDescripcion"];
                    aux.Categoria.IDCategoria = (int)datos.Lector["IDcategoriaArticulo"];
                    aux.Idcategoria= (int)datos.Lector["IDcategoriaArticulo"];
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

        public void AgregarArticulo(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            NegocioImagen negocioImagen = new NegocioImagen();
            Imagen imagen = new Imagen();
            imagen.ImagenUrl = nuevo.Imagen.ImagenUrl;
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

                buscarUltimoID(imagen);
                negocioImagen.idUltimaImagen(imagen);

                             
                negocioImagen.AgregarImagen(imagen);
                //datos.cerrarConexion();

               // datos.SetearConsulta("insert into IMAGENES(IdArticulo,ImagenUrl) values(@idArticulo,@url)");
                //datos.setearParametro("idArticulo", imagen.IDArticulo);
               // datos.setearParametro("url",imagen.ImagenUrl);
               // datos.ejecutarAccion();

                /*
                datos.SetearConsulta("insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@precio); select SCOPE_IDENTITY() as ultimoid");
                datos.setearParametro("@codigo",nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.IDMarca);
                datos.setearParametro("@idCategoria", nuevo.Categoria.IDCategoria);
                datos.setearParametro("@precio", nuevo.Precio);
                
                datos.ejecutarLectura();
                corroboraba si el lector inicio y leia correctamente las filas de la BD
                Console.WriteLine(datos.Lector != null ? "Lector inicializado correctamente." : "Lector no inicializado.");
                Console.WriteLine(datos.Lector.HasRows ? "El lector tiene filas disponibles." : "El lector no tiene filas.");

               
                //Console.WriteLine("Lector inicializado: " + (datos.Lector != null));
                //Console.WriteLine("Tiene filas: " + (datos.Lector.HasRows));
                // Mueve el lector a la primera fila
                if (datos.Lector.Read()) // Posicionar en la primera fila
                {                       me aseuraba que no fuera null, lei que ejecutar una lectura podia llegar a devolver el dato
                                        en decimal asique lo pasaba a decimal y casteaba a int
                    nuevo.Imagen.IDArticulo = Convert.ToInt32(Convert.ToDecimal(datos.Lector["ultimoid"]));
                }
                y aun asi obtenia el resultado null o un 0
                hice valdaciones en ejecutarLectura y ejecutarAccion para que antes de abrir una coneccion se fijara si no habia una abierta
                para no tener problemas al momento de conseguir el ID
                ni con la ayuda de chatgpt pude solucionarlo, me ofrecia otras opciones como el excecute scalar
                pero modificaba el flujo de consulta eliminando las funciones echas en la clase accesoDatos
                */


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
        public void buscarUltimoID(Imagen nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select Id from ARTICULOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    nueva.IDArticulo = (int)datos.Lector["Id"];
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
            
        }
        public void Modificar(Articulo art)
        {
            AccesoDatos datos=new AccesoDatos();
            try
            {   
                

                datos.SetearConsulta("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@idMarca,IdCategoria=@idCategoria,Precio=@precio where Id= @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.Marca.IDMarca);
                datos.setearParametro("@idCategoria", art.Categoria.IDCategoria);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.IDArticulo);
                datos.ejecutarAccion();

                datos.SetearConsulta("update IMAGENES set ImagenUrl=@url where Id=@idImagen");
                datos.setearParametro("@url", art.Imagen.ImagenUrl);
                datos.setearParametro("@idImagen", art.Imagen.IDImagen);
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
    }
}