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
    public partial class TelaListaPedidos : Form
    {
        public Pedido PedidoSelecionado { get; set; }

        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracao(Pedido PedidoSelecionado)
        {
            AdicionaPedido tela = new AdicionaPedido();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = PedidoSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void dgListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarPedidos()
        {
            dgListaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListaPedidos.MultiSelect = false;
            dgListaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListaPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            dgListaPedidos.DataSource = pedidos;
        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private bool VerificarSelecao()
        {
            if (dgListaPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoSelecionado = (Pedido)dgListaPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(pedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o lanche.");
                    }
                    CarregarPedidos();
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido PedidoSelecionado = (Pedido)dgListaPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(PedidoSelecionado);
            }
        }
    }
}
