using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        [Browsable(false)]
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        [Browsable(false)]
        public string Senha { get; set; }
        public Papel Funcao { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }



        
    }
}
