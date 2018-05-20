using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio.Models
{
    public class Lanche
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}
