using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    
    public class ItensEntrada
    {
        [Browsable(false)]
        public int IDItensEntrada { get; set; }
        public Produto Produto { get; set; }
        public int IDProduto { get; set; }
        public double PrecoUnitario { get; set; }
        public double Quantidade { get; set; }

        public ItensEntrada()
        {
            Produto = new Produto();
        }
        public override string ToString()
        {
            return Produto.Nome;
        }
    }
}
