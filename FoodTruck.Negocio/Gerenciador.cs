﻿using System;
using FoodTruck.Negocio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio
{
    public class Gerenciador
    {
        private List<Cliente> Clientes;
        private List<Bebida> Bebidas;
        private List<Lanche> Lanches;
        private List<Pedido> Pedidos;

        public Gerenciador()
        {
            this.Clientes = new List<Cliente>();
            this.Bebidas = new List<Bebida>();
            this.Lanches = new List<Lanche>();
            this.Pedidos = new List<Pedido>();
        }

        public void AdicionarCliente(Cliente clienteAdicionado)
        {
            //Validações
            this.Clientes.Add(clienteAdicionado);
        }

    }
}
