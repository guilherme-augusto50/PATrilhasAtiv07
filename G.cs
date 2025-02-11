using System;

class Program
{
    static void Main()
    {
        int [,] matriz = new int [4, 4];

        Console.WriteLine("Escreva uma matriz 4x4");
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++) {
                Console.WriteLine("Digite o valor para a posiçao {0}, {1} ", i+1, j+1);
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
       
        Console.WriteLine("Valores pares da matriz:");
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                if (matriz[i, j] % 2 ==0 ){
                    Console.Write(matriz[i, j] + " ");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
