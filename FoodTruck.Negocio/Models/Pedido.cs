using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio.Models
{
    [Table(name: "Pedidos")]
    public class Pedido
    {
        public long Id { get; set; }
        public DateTime DataCompra { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Lanche> Lanches { get; set; }
        public virtual ICollection<Bebida> Bebidas { get; set; }

        public Pedido()
        {
            this.DataCompra = DateTime.MinValue;
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
        }

        [NotMapped]
        public String NomeCliente
        {
            get
            {
                return Cliente.Nome;
            }
        }

        public Decimal ValorTotal
        {
            get
            {
                Decimal totalLanches = this.Lanches.Sum(m => m.Valor);
                Decimal totalBebidas = this.Bebidas.Sum(m => m.Valor);
                return totalLanches + totalBebidas;
            }
        }
    }
}
