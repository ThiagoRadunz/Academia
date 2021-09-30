using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plano
    {
        public int IDPlano { get; set; }
        public int IDCategoria { get; set; }
        public int QtdAulaSemana { get; set; }
        public int DuracaoPlano { get; set; }
        public double PrecoPlano { get; set; }
    }
}
