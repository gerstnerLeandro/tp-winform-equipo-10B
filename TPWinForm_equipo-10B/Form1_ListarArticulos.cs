using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_10B
{
    public partial class Form5_ListarArticulos : Form
    {
        public Form5_ListarArticulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo articulo = new Articulo();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ListarArticulos lista = new ListarArticulos();
            
           

        }

        private void Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Form5_ListarArticulos_Load(object sender, EventArgs e)
        {
            ListarArticulos lista = new ListarArticulos();
            Articulos.DataSource = lista.listar();
        }
    }
}
