using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PlanoInstrutorCliente
    {
        
        //PIC = Plano Instrutor Cliente
        public int IDPIC { get; set; }
        public int IDInstrutor { get; set; }
        public int IDPlano { get; set; }
        public int IDCliente { get; set; }
        public int IDFormapagamento { get; set; }
        public DateTime AdesaoContrato { get; set; }
        public DateTime TerminoContrato { get; set; }

        public double CalcularComissao(int idInstrutor)
        {
            double total = 0;
            
            

            return total;
        }
    }
}
