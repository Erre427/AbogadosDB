using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbogadosDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAbogados_Click(object sender, EventArgs e)
        {
            Abogados abogados = new Abogados();
            abogados.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void btnCasos_Click(object sender, EventArgs e)
        {
            Casos casos = new Casos();
            casos.Show();
        }

        private void btnAudiencias_Click(object sender, EventArgs e)
        {
            Audiencias audiencias = new Audiencias();
            audiencias.Show();
        }

        private void btnCasosAbogados_Click(object sender, EventArgs e)
        {
            Casos_Abogados casosAbogados = new Casos_Abogados();
            casosAbogados.Show();
        }
    }
}
