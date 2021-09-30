using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModel
{
    public class PlanoInstrutorClienteQueryView
    {
        //IDPIC = IDPlanoInstrutorCliente
        [Browsable(false)]
        public string IDPIC { get; set; }
        [Browsable(false)]
        public string IDInstrutor { get; set; }
        public string NomeInstrutor { get; set; }
        [Browsable(false)]
        public string IDPlano { get; set; }
        [Browsable(false)]
        public string IDCliente { get; set; }
        public string NomeCliente { get; set; }
        public string NomeCategoria { get; set; }
        public string QtdAulaSemana { get; set; }
        public string QtdMesesDuracao { get; set; }
        public string Valor { get; set; }
        public DateTime AdesaoContrato { get; set; }
        public DateTime TerminoContrato { get; set; }
        [Browsable(false)]
        public string IDFormapagamento { get; set; }
        public string NomeFormapagamento { get; set; }


    }
}
