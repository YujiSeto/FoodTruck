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
    public partial class AdicionaPedido : Form
    {
        public Pedido PedidoSelecionado { get; set; }
        Pedido pedido = new Pedido();

        public AdicionaPedido()
        {
            InitializeComponent();
        }

        private void AdicionaPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
            CarregaDatagrids();
            CarregaTotal();
        }

        private void CarregaTotal()
        {
            lbTotal.Text = pedido.ValorTotal.ToString();
        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Descricao";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaDatagrids()
        {
            dgPedidoBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidoBebidas.MultiSelect = false;
            dgPedidoBebidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidoBebidas.AutoGenerateColumns = false;
            dgPedidoBebidas.DataSource = pedido.Bebidas.ToList();

            dgPedidoLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidoLanches.MultiSelect = false;
            dgPedidoLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidoLanches.AutoGenerateColumns = false;
            dgPedidoLanches.DataSource = pedido.Lanches.ToList();

            CarregaTotal();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
            pedido.Bebidas.Add(bebidaSelecionada);
            CarregaDatagrids();
        }

        private void btAdicionaLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)cbLanches.SelectedItem as Lanche;
            pedido.Lanches.Add(lancheSelecionado);
            CarregaDatagrids();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pedido.Cliente = cbClientes.SelectedItem as Cliente;
            pedido.DataCompra = DateTime.Now;
            Validacao validacao;
            if (PedidoSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastrarPedido(pedido);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarPedido(pedido);
            }
            if (validacao.Valido)
            {
                MessageBox.Show("Pedido cadastrado com sucesso!");
                this.Close();
            }
            else
            {
                String msg = "";
                foreach (var mensagem in validacao.Mensagens)
                {
                    msg += mensagem + Environment.NewLine;
                }
                MessageBox.Show(msg, "Erro");
            }
            this.Close();
        }

        private void dgBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdicionaPedido_Shown(object sender, EventArgs e)
        {
            if (PedidoSelecionado != null)
            {
                this.cbClientes.SelectedItem = PedidoSelecionado.Cliente;
                this.dgPedidoBebidas.DataSource = PedidoSelecionado.Bebidas.ToList();
                this.dgPedidoLanches.DataSource = PedidoSelecionado.Lanches.ToList();
                pedido = PedidoSelecionado;
            }
        }

        private void btRemoverBebidaSelecionada_Click(object sender, EventArgs e)
        {
            Bebida bebidaSelecionada = (Bebida)this.pedido.Bebidas.ElementAt(dgPedidoBebidas.SelectedRows[0].Index);
            pedido.Bebidas.Remove(bebidaSelecionada);
            CarregaDatagrids();
        }

        private void btRemoverLanche_Click(object sender, EventArgs e)
        {
            Lanche lancheSelecionado = (Lanche)this.pedido.Lanches.ElementAt(dgPedidoLanches.SelectedRows[0].Index) /*as Lanche*/;
            pedido.Lanches.Remove(lancheSelecionado);
            CarregaDatagrids();
        }
    }
}
