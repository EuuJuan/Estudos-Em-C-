int x, y;

Console.WriteLine("Digite dois numeros para o programa começar");

Console.WriteLine("Digite dois numeros: ");
x = int.Parse(Console.ReadLine()!);
y = int.Parse(Console.ReadLine()!);

while(x != y) {
    if(x < y) {
        Console.WriteLine("Crescente!");
    }
    else {
        Console.WriteLine("Decrescente!");
    }
    Console.WriteLine("Digite outros dois numeros: ");
    x = int.Parse(Console.ReadLine()!);
    y = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Programa finalizado.");
