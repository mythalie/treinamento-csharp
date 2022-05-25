
namespace PrimeiroPrograma.Modelos
{
    internal class Quiz
    {
        public Quiz(string nome, List<Questao> questoes, int nota)
        {
            Nome = nome;
            Questoes = questoes;
            Nota = nota;
        }

        public string Nome { get; set; }
        List<Questao> Questoes { get; set; }
        public int Nota { get; set; }

        public void iniciaQuiz()
        {
            Console.WriteLine(Nome);

            foreach (Questao questao in this.Questoes)
            {
                Console.WriteLine(questao.Texto);

                string gabarito = "";
                foreach (Alternativa alternativa in questao.Alternativas)
                {
                    if (alternativa.Certo)
                    {
                        gabarito += alternativa.Letra;
                    }

                    Console.WriteLine(alternativa.Letra + ". " + alternativa.Texto);
                }

                Console.Write("Resposta do usuário: ");
                var resposta = Console.ReadLine();
                Console.WriteLine();

                if (resposta == gabarito)
                {
                    this.Nota++;
                }
            }

            Console.WriteLine("Você acertou " + this.Nota + "/" + this.Questoes.Count + " respostas!");
        }
    }
}
