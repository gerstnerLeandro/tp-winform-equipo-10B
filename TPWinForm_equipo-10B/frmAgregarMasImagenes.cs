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
    public partial class frmAgregarMasImagenes : Form
    {
        public frmAgregarMasImagenes()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxURL.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox.Load("https://th.bing.com/th/id/OIP.iWIEidVomFA1iDjwsqxv6wHaHa?w=168&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7");
            }



        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarMasImagenes_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Imagen imagen= new Imagen();
            NegocioImagen negocio= new NegocioImagen();
            NegocioArticulos negocioArticulos= new NegocioArticulos();
            try
            {
                negocioArticulos.buscarUltimoID(imagen);
                imagen.ImagenUrl = textBoxURL.Text;
                negocio.AgregarImagen(imagen);
                MessageBox.Show("Imagen agregada correctamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar los datos de la imagen" + ex);
            }
            

        }
    }
}
