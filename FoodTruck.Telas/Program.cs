using FoodTruck.Negocio;
using FoodTruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Telas
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerenciador gerenciador = new Gerenciador();
            Cliente cliente = new Cliente();
            gerenciador.AdicionarCliente(cliente);
        }
    }
}
