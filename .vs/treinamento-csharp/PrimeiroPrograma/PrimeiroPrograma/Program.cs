using PrimeiroPrograma.Modelos;

/*
string a = Console.ReadLine();
string b = Console.ReadLine();
int numA = int.Parse(a);
int numB = int.Parse(b);
Console.WriteLine("A soma é: " + (numA + numB));

-------

Console.WriteLine("Digite o primeiro número: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("A soma é: " + (a + b));

-------

Console.WriteLine("Digite o primeiro número: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine("A multiplicação é: " + (a * b * c));

-------

Cliente clienteA = new Cliente();
clienteA.Nome = "Douglas";
clienteA.Sobrenome = "Fernandes";
Console.WriteLine(clienteA.FaltaQuantosAnosPara(40));

var clienteB = new Cliente(22); //var - tipo implícito
clienteB.Nome = "Mythalie";
clienteB.Sobrenome = "Sandretti";
Console.WriteLine(clienteB.FaltaQuantosAnosPara(40));

// Atribuindo as propriedades na criação
Cliente clienteC = new Cliente()
{
    Nome = "João",
    Sobrenome = "Pedro"
};
Console.WriteLine(clienteC.NomeCompleto());

Usuario usuario = new Usuario();
usuario.Nome = "Douglas";
usuario.email = "douglas.pereira@iteris.com.br";
Console.WriteLine(usuario.ObterLogin());
*/

// QUESTÃO 1
Alternativa alternativa1A = new Alternativa("a", "5", false);
Alternativa alternativa1B = new Alternativa("b", "4", true);

Questao questao1 = new Questao("1) Quanto é 2 + 2?", 
    new List<Alternativa> { alternativa1A, alternativa1B });

// QUESTÃO 2
Alternativa alternativa2A = new Alternativa("a", "4", false);
Alternativa alternativa2B = new Alternativa("b", "7", true);

Questao questao2 = new Questao("2) Quanto é 2 + 5?",
    new List<Alternativa> { alternativa2A, alternativa2B });

// QUESTÃO 3
Alternativa alternativa3A = new Alternativa("a", "2 ^ 2", true);
Alternativa alternativa3B = new Alternativa("b", "- 2 * 2", false);
Alternativa alternativa3C = new Alternativa("c", "2 * 2", true);
Alternativa alternativa3D = new Alternativa("d", "4 ^ 2", true);

Questao questao3 = new Questao("3) 4 = X. Quais os possíveis valores de X:",
    new List<Alternativa> { alternativa3A, alternativa3B, alternativa3C, alternativa3D });

// QUIZ
Quiz quiz = new Quiz("Bem vindo ao Quiz Decola. Esse quiz é composto por 3 questões.",
    new List<Questao> { questao1, questao2, questao3 }, 0);

quiz.iniciaQuiz();