using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public  class Categoria
    {
        private int IDcategoria;
        private string descripcion;

        public int IDCategoria {
             set {IDcategoria= value; }
             get {return IDcategoria; }
        }
        public string Descripcion
        {
            set { Descripcion = value; }
            get { return descripcion; }
        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
