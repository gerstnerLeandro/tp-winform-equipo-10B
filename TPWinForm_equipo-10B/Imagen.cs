using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_10B
{
    internal class Imagen
    {
        private int IDimagen;
        private int IDarticulo;
        private string imagenUrl;

        public int IDImagen
        {
            set { IDarticulo = value; }
            get { return IDimagen; }
        }
        public int IDArticulo { 
            set { IDarticulo = value; }
            get { return IDarticulo; }
        }
        public string ImagenUrl
        {
            set { imagenUrl = value; }
            get { return imagenUrl; }
        }
        public override string ToString()
        {
            return imagenUrl;
        }
    }
}
