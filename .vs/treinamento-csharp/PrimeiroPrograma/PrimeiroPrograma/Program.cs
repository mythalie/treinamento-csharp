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
*/

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