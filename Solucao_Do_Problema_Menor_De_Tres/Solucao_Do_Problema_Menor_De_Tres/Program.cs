using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int a, b, c, menor;

Console.WriteLine("Digite os valores para rodar o programa");
Console.Write("Primeiro valor: ");
a = int.Parse(Console.ReadLine()!);

Console.Write("Segundo valor: ");
b = int.Parse(Console.ReadLine()!);

Console.Write("Terceiro valor: ");
c = int.Parse(Console.ReadLine()!);

if(a < b && a < c) {
    menor = a;
}else if(b < c) {
    menor = b;
}
else {
    menor = c;
}

Console.WriteLine("O menor numero é: " + menor);

Console.WriteLine();
Console.WriteLine("Fim do programa.");
