using System;

class Program
{
    static void Main()
    {
        int [,] matriz = new int [10, 10];

        Console.WriteLine("Escreva uma matriz 4x4");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++) {
                Console.WriteLine("Digite o valor para a posiçao {0}, {1} ", i+1, j+1);
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int soma = 0; 
        for (int i = 0; i < 10; i++){
            soma += matriz[i, i];
        } 
        double media = soma  /10.0;

        int somaS = 0;
        for (int i = 0; i < 10; i++){
            somaS += matriz[i, 9 - i];
        }
       
        double mediaS = somaS / 10.0;

        Console.WriteLine("Soma da diagonal principal: " + soma);
        Console.WriteLine("Media da diagonal principal: " + media);
        Console.WriteLine("Soma da diagonal segundaria: " + somaS);
        Console.WriteLine("Soma da diagonal segundara: " + mediaS);

        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
