using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Modelos
{
   public class Cliente
    {

        public Cliente() { }

        public Cliente(int idade)
        {
            this.idade = idade; //this.idade para diferenciar o campo do parametro
        }

        private int idade; //campo
        public string Nome { get; set; } //propriedade
        public string Sobrenome { get; set; } //propriedade

        public string FaltaQuantosAnosPara(int idadeAlvo) 
        {
            int diferenca = idadeAlvo - idade;
            if (diferenca >= 0)
            {
                return "Falta(m) " + diferenca + " Anos(s)";
            } else
            {
                return "Já passou da idade";
            }
        }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
