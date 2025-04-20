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
    public partial class Form2AltaArticulo : Form
    {
        public Form2AltaArticulo()
        {
            InitializeComponent();
        }

        private void button2Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxCodigoArticulo_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1Aceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
           

            NegocioArticulos negocioArticulo = new NegocioArticulos();
            NegocioImagen negocioImagen = new NegocioImagen();
            try
            {
                articulo.Codigo = textBoxCodigoArticulo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Categoria = (Categoria)comboBoxIDcategoria.SelectedItem;
                articulo.Marca = (Marca)comboBoxIDmarca.SelectedItem;     
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
                articulo.Imagen.ImagenUrl = textBoxURL.Text;

                negocioArticulo.AgregarArticulo(articulo);

                frmAgregarMasImagenes frmAgregarMasImagen = new frmAgregarMasImagenes();
                
                frmAgregarMasImagen.ShowDialog();

               

                MessageBox.Show("Articulo agregado correctamente");

                Form5_ListarArticulos grilla = new Form5_ListarArticulos();
                grilla.ShowDialog();




                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del articulo" + ex);


            }
        }

        private void Form2AltaArticulo_Load(object sender, EventArgs e)
        {
            NegocioArticulos negocioArt = new NegocioArticulos();
            comboBoxIDcategoria.DataSource = negocioArt.listar();
            comboBoxIDcategoria.DataSource = negocioArt.listar();

            NegocioMarca negocioMarca = new NegocioMarca();
            comboBoxIDmarca.DataSource = negocioMarca.listar();

            NegocioCategoria negocioCategoria = new NegocioCategoria();
            comboBoxIDcategoria.DataSource = negocioCategoria.listar();

        }

        private void comboBoxIDmarca_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxIDcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
            private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1Imagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox1Imagen.Load("https://th.bing.com/th/id/OIP.iWIEidVomFA1iDjwsqxv6wHaHa?w=168&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7");
            }
        
    

        }

        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxURL.Text);
        }

        private void pictureBox1Imagen_Click(object sender, EventArgs e)
        {
            
        }

        private void labelURL_Click(object sender, EventArgs e)
        {

        }
    }
}
