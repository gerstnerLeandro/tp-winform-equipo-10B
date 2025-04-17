using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_10B
{
    internal class Marca
    {
        private int IDmarca;
        private string nombre;
       

        public int IDMarca
        {
            set { IDmarca = value; }
            get { return IDmarca; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
