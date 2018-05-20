using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruck.Negocio.Models
{
    public class Bebida : Produto
    {
        public float Tamanho { get; set; }

        public override String Descrever()
        {
            //String descricao = base.Descrever();
            //descricao += " - " + this.Tamanho + "ml";
            //return descricao;
            return String.Format($"{ this.Id} - {this.Nome} - {this.Valor} - {this.Tamanho}ml");
        }
    }
}
