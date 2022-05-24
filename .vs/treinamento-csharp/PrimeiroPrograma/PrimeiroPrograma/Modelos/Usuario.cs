using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string email;

        public string ObterLogin()
        {
            string[] nameOnly = email.Split('@');
            return nameOnly[0];
        }
    }
}
