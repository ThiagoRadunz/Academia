using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produto
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public double QtdEstoque { get; set; }
        public double PrecoUnitario { get; set; }

        public Produto()
        {
            this.Categoria = new Categoria();
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
