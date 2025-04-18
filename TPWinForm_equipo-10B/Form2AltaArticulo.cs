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
            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {
                articulo.Codigo = textBoxCodigoArticulo.Text;
                articulo.Nombre = textBoxNombre.Text;
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.Categoria =(Categoria) comboBoxIDcategoria.SelectedItem;
                
                articulo.Marca=(Marca) comboBoxIDmarca.SelectedItem;
                               
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);


                negocio.Agregar(articulo);
                MessageBox.Show("Articulo agregado correctamente");
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
    }
}
