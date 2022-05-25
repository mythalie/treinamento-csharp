
namespace PrimeiroPrograma.Modelos
{
    internal class Questao
    {
        public Questao(string texto, List<Alternativa> alternativas)
        {
            Texto = texto;
            this.Alternativas = alternativas;
        }

        public string Texto { get; set; }
        public List<Alternativa> Alternativas { get; set; }
    }
}
