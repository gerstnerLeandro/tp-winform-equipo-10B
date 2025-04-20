using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class NegocioImagen
    {

        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id,IdArticulo,ImagenUrl from IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IDImagen = (int)datos.Lector["Id"];
                    aux.IDArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];



                    lista.Add(aux);
                }
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

            

        }
        public void AgregarImagen(Imagen nuevo)
        {
            
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta("insert into IMAGENES(IdArticulo,ImagenUrl) values(@codigoArticulo,@url)");
                datos.setearParametro("@codigoArticulo", nuevo.IDArticulo);
                datos.setearParametro("@url", nuevo.ImagenUrl);
                
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
        
        
        public void idUltimaImagen(Imagen aux)
        {
            AccesoDatos datos=new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id from ARTICULOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    aux.IDImagen = (int)datos.Lector["Id"];
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
    }
}
