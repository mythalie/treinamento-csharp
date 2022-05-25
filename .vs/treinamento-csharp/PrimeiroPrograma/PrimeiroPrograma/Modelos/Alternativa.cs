
namespace PrimeiroPrograma.Modelos
{
    internal class Alternativa
    {
        public Alternativa(string letra, string texto, bool certo)
        {
            Letra = letra;
            Texto = texto;
            Certo = certo;
        }

        public string Letra { get; set; }
        public string Texto { get; set; }
        public bool Certo { get; set; }
    }
}
