using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Venda
    {
        public int IDVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotal { get; set; }
        public int IDUsuario { get; set; }
        public int IDCliente { get; set; }
        public List<ItensVenda> Items { get; set; }

        public void CalcularPreco()
        {
            this.ValorTotal = this.Items.Sum(c => c.PrecoUnitario * c.Quantidade);
            //double valor = 0;
            //foreach (ItensEntrada item in Items)
            //{
            //    valor += item.Valor * item.Quantidade;
            //}
            //this.Valor = valor;
        }
        public Venda()
        {
            this.Items = new List<ItensVenda>();
        }
    }
}
