using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

int N;

Console.Write("Quantos Numeros voce vai digitar: ");
N = int.Parse(Console.ReadLine()!);

double[] vet = new double [N];

for(int i = 0; i < N; i++) {
    Console.Write("Digite um Numero: ");
    vet[i] = double.Parse(Console.ReadLine()!, CI);
}

Console.WriteLine();
Console.WriteLine("Numeros Digitados São: ");
for(int i = 0; i < N; i++) {
    Console.WriteLine(vet[i].ToString("F1", CI));
}
