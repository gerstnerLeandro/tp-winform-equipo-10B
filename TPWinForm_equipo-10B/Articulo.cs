using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_10B
{
    internal class Articulo 
    {
        private int codArticulo;
        private string nombre;
        private string descripcion;
        private Marca marca;
        private string categoria;
        private int stock;
        private bool disponible;
        private float precioContado;
        private int cuotas;
        private float precioCuota;
        private string medioPago;
        private bool envioGratis;

        public int CodigoArticulo{
            set { codArticulo = value; }
            get { return codArticulo; }
            }
        public string Nombre { 
            set { nombre = value; }
            get { return nombre; } 
            }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
       
        public string Categoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public int Stock
        {
            set { stock = value; }
            get { return stock; }
        }
        public bool Disponible
        {
            set { disponible = value; }
            get { return disponible; }
        }
        public float PrecioContado
        {
            set { precioContado = value; }
            get { return precioContado; }
        }
        public int Cuotas
        {
            set { cuotas = value; }
            get { return cuotas; }
        }
        public float PrecioCuota
        {
            set { precioCuota = value; }
            get { return precioCuota; }
        }
        public string MedioPago
        {
            set { medioPago = value; }
            get { return medioPago; }
        }
        public bool EnvioGratis
        {
            set {  envioGratis = value; }
            get { return envioGratis; }
        }
    }
}
