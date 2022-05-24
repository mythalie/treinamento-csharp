namespace PrimeiroPrograma.Modelos
{
    public class Cliente
    {
        private int idade;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void Metodo() { 
        }

        public string NomeCompleto() {
            return Nome + " " + Sobrenome;
        }
    }
}