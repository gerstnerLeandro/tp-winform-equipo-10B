using System.Dynamic;
using System.Security.Policy;

namespace dominio
{
    public class Articulo
    {
        private int IDarticulo;
        private string codigo;
        private string nombre;
        private string descripcion;
        private Marca marca;
        private int idmarca;
        private Categoria categoria;
        private int idcategoria;
        private decimal precio;
        private Imagen imagen;

        public int IDArticulo
        {
            set { IDarticulo = value; }
            get { return IDarticulo; }
        }
        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public int Idmarca
        {
            set { idmarca = value; }
            get { return idmarca; }
        }
        public Marca Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public int Idcategoria
        {
            set { idcategoria = value; }
            get { return idcategoria; }
        }
        public Categoria Categoria
        {
            set {  categoria = value; }
            get { return categoria; }
        }
        public decimal Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public Imagen Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }
       
    }
}
