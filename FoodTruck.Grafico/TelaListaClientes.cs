using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck.Grafico
{
    public partial class TelaListaClientes : Form
    {
        public TelaListaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManterCliente tela = new ManterCliente();
            tela.MdiParent = this.MdiParent;
            tela.Show();

        }
    }
}
