using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
   public class Cliente
    {
        private int idade;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void Metodo()
        {
        }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
