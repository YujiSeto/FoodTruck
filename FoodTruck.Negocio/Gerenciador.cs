using System;
using FoodTruck.Negocio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTruck.Negocio.Persistencia;

namespace FoodTruck.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Gerenciador()
        {
            Bebida bebida = new Bebida();
            Lanche lanche = new Lanche();
        }

        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();

            if(this.banco.Clientes.Where(c => c.Id == clienteAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um cliente com esse codigo");
            }

            if (String.IsNullOrEmpty(clienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome" , "O nome não pode ser nulo");
            }

            if (String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("E-mail","O e-mail não pode ser nulo");
            }

            if (!clienteAdicionado.Email.Contains("@"))
            {
                validacao.Mensagens.Add("E-mail", "E-mail no formato inválido");
            }

            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SalvarDados();
            }
            return validacao;
        }

        public List<Cliente> TodosOsClientes()
        {
            return this.banco.Clientes.ToList();
        }

        public void AdicionarLanche(Lanche lancheAdicionado)
        {
            this.banco.Lanches.Add(lancheAdicionado);
            this.banco.SalvarDados();
        }
    }
}
