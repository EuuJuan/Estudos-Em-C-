using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int idade1, idade2;
String nome1, nome2;
double media;

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome da Primeira Pessoa: ");
nome1 = Console.ReadLine()!;
Console.Write("Idade da Primeira Pessoa: ");
idade1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Dados da Segunda pessoa:");
Console.Write("Nome da Segunda Pessoa: ");
nome2 = Console.ReadLine()!;
Console.Write("Idade da Segunda Pessoa: ");
idade2 = int.Parse(Console.ReadLine()!);

media = (idade1 + idade2) / 2.0;

Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de " + media.ToString("F1", CI) + " anos.");
