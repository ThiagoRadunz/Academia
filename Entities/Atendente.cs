using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Atendente
    {
        [Browsable(false)]
        public int IDAtendente { get; set; }
        public Usuario Usuario { get ; set; }
        [Browsable(false)]
        public int IDUsuario { get; set; }
        public string TelefoneCelular { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        [Browsable(false)]
        public string Estado { get; set; }
        [Browsable(false)]
        public string Cidade { get; set; }
        [Browsable(false)]
        public string Bairro { get; set; }
        [Browsable(false)]
        public string Rua { get; set; }
        [Browsable(false)]
        public int Numero { get; set; }
        [Browsable(false)]
        public double Salario { get; set; }
        [Browsable(false)]
        public double Comissao { get; set; }
        [Browsable(false)]
        public bool Ativo { get; set; }

        public Atendente()
        {
            Usuario = new Usuario();
        }
    }
}
