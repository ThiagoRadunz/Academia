using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string FoneCelular { get; set; }
        public string FoneFixo { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }
    }
}
