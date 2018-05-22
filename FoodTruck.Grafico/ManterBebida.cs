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
    public partial class ManterBebida : Form
    {
        public ManterBebida()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida novaBebida = new Bebida();
            novaBebida.Id = Convert.ToInt64(tbId.Text);
            novaBebida.Nome = tbNome.Text;
            novaBebida.Valor = Convert.ToDecimal(tbValor.Text);
            novaBebida.Tamanho = Convert.ToSingle(tbTamanho.Text);
            Validacao validacao = Program.Gerenciador.CadastrarBebida(novaBebida);

            
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
