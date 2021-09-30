using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModel
{
    public class PlanoQueryView
    {
        public int IDPlano { get; set; }
        public string Categoria { get; set; }
        public int QtdAulaSemana { get; set; }
        public int DuracaoPlano { get; set; }
        public double PrecoPlano { get; set; }


    }
}
