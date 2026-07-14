int N, cont;

Console.WriteLine("Qual a ordem da Matriz");
Console.Write("Digite aqui a ordem: ");
N = int.Parse(Console.ReadLine()!);

int[,] mat = new int [N, N];

for(int i = 0; i < N; i++) {
    for(int j = 0; j < N; j++) {
        Console.Write("Elemento [" + i + "," + j + "]:");
        mat[i, j] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine("Diagonal Principal:");
for(int i = 0; i < N; i++) {
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

cont = 0;
for(int i = 0; i < N; i++) {
    for (int j = 0; j < N; j++){
        if (mat[i, j] < 0){
            cont++;
        }
    }
}

Console.WriteLine("Quantidade de negativos = " + cont);
