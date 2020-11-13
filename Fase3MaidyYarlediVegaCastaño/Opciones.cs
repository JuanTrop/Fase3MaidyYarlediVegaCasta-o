using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3MaidyYarlediCastaño.PILA;
namespace Fase3MaidyYarlediCastaño
{
    public partial class Opciones : Form
    {
        
        
        public Opciones()
        {
            InitializeComponent();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            Pilas pila = new Pilas();
            pila.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            Transmetro cola = new Transmetro();
            cola.Show();
        }

        private void BtnListas_Click(object sender, EventArgs e)
        {
            Listas lista = new Listas();
            lista.Show();
        }
    }
}
