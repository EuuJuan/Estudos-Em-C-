//Nesse codigo estudei como funciona as estruturas de controle em C# 

/*int hora;
 Console.Write("Digite uma hora do dia: ");
 hora = int.Parse(Console.ReadLine()!);

 if (hora < 12) {
    Console.WriteLine("Bom dia!");
  }
 else if (hora < 18){
    Console.WriteLine("Boa tarde!");
 }
else {
    Console.WriteLine("Boa noite!");
}*/

//Soma dos numeros com While
/*int x, soma;

soma = 0;
Console.Write("Digite o primeiro numero: ");
x = int.Parse(Console.ReadLine()!);

while (x != 0) {
    soma = soma + x;
    Console.Write("Digite outro numero: ");
    x = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Soma dos numeros é = " + soma);
Console.WriteLine("\nPrograma Finalizado.\n");*/

//Soma dos numeros com For
/*int N, x, soma,i;

soma = 0;
Console.Write("Digite o primeiro numero: ");
N = int.Parse(Console.ReadLine()!);

for (i = 1; i <= N; i++) {
    Console.Write("Digite outro numero: ");
    x = int.Parse(Console.ReadLine()!);
    soma = soma + x;
}

Console.WriteLine("Soma dos numeros é = " + soma);
Console.WriteLine("\nPrograma Finalizado.\n");*/