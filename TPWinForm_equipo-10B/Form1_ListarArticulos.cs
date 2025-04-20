using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_10B
{
    public partial class Form5_ListarArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public Form5_ListarArticulos()
        {
            InitializeComponent();
        }
        public void Form5_ListarArticulos_Load(object sender, EventArgs e)
        {
            cargar();

        }
        public void cargar()
        {
            NegocioArticulos lista = new NegocioArticulos();

            try
            {
                listaArticulos = lista.listar();
                dgvListar.DataSource = listaArticulos;
                dgvListar.Columns[0].Visible = false;
                dgvListar.Columns[4].Visible = false;
                dgvListar.Columns[5].Visible = false;
                dgvListar.Columns[6].Visible = false;
                dgvListar.Columns[7].Visible = false;
                dgvListar.Columns[9].Visible = false;

                cargarImagen(listaArticulos[0].Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado =(Articulo) dgvListar.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1Imagen.Load(imagen);
            }
            catch (Exception ex){
                pictureBox1Imagen.Load("https://th.bing.com/th/id/OIP.iWIEidVomFA1iDjwsqxv6wHaHa?w=168&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7");
            }
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
