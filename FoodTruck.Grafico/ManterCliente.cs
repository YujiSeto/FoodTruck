using FoodTruck.Negocio;
using FoodTruck.Negocio.Models;
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
    public partial class ManterCliente : Form
    {
        public ManterCliente()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Id = Convert.ToInt64(tbId.Text);
            novoCliente.CPF = tbCpf.Text;
            novoCliente.Nome = tbNome.Text;
            novoCliente.Email = tbEmail.Text;
            Validacao validacao = Program.Gerenciador.AdicionarCliente(novoCliente);

            
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
        }
    }
}
