using System;

class Program
{
    static void Main()
    {
        int [,] matriz = new int [3, 3];
 
        Random rand = new Random();
        Console.WriteLine("----------");
        for (int i = 0; i < 3; i++){
            for (int j = 0; j < 3; j++){
                matriz[i, j] = rand.Next(1, 101);
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
            Console.WriteLine("----------");
        int maior = matriz[0,0];

        foreach (int valor in matriz){
            if (valor > maior){
                    maior = valor;
            }
        }
        Console.WriteLine("O maior valor da matriz é: "+ maior);

        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
