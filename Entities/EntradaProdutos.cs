using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntradaProdutos
    {
        public int IDEntradaProdutos { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataEntrada { get; set; }
        public Usuario Usuario { get; set; }
        public int IDUsuario { get; set; }
        public List<ItensEntrada> Items { get; set; }

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

        public EntradaProdutos()
        {
            this.Items = new List<ItensEntrada>();
        }
    }
}
