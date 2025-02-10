using System;

class Program
{
    static void Main()
    {
        double [,] matriz  = new double [2, 2];
        

       

         Console.WriteLine("Digite  uma matriz de 2x2");

            for (int i = 0; i < 2; i++){
                for (int j = 0; j < 2; j++){
                    Console.WriteLine("digite o valor para a posiçao {0}, {1}:", i+1, j+1);
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double soma = 0;
            int total  = matriz.Length;

            foreach (double valor in matriz){
                soma += valor;
            }

            double media  = soma / total;

            

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < 2; i++){
                for (int j = 0; j < 2; j++){
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMedia dos valores da matriz: {0}",media);



        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
