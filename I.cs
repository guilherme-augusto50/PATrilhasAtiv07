using System;

class Program
{
    static void Main()
    {
        int [,] matriz = new int [10, 10];
        int soma  = 0;

        Console.WriteLine("Escreva uma matriz 4x4");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++) {
                Console.WriteLine("Digite o valor para a posiçao {0}, {1} ", i+1, j+1);
                matriz[i,j] = int.Parse(Console.ReadLine());
                soma += matriz [i, j];
            }
        }

        Console.WriteLine("------- Matriz: --------");
        for (int i = 0; i < 10; i++){
            for (int j = 0; j < 10; j++){
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-----------------------\n");
        Console.WriteLine("A soma de todos os números da matriz é: {0}", soma );
      
        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
