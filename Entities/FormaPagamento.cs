using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FormaPagamento
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Descricao { get; set; }
    }
}
