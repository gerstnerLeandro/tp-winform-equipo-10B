using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_10B
{
    internal class Marca
    {
        private int IDmarca;
        private int cuil;
        private string nombre;
        private string nacionalidad;

        public int IDMarca{
            set{IDmarca=value;}
            get{return IDmarca;}
            }
        public int CUIL
        {
            set{cuil=value;}
            get{return cuil;}
        }
        public string Nombre
        {
            set{nombre=value;}
            get{return nombre;}
        }
        public string Nacionalidad
        {
            set{nombre=value;} 
            get{return nacionalidad;}
        }
        }
}
