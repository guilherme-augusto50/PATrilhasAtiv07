using System;

class Program
{
    static void Main()
    {
    	
    	
    	int[,] matriz = new int[4,2];
    	
    	
    	Random rand = new Random();
    	
    	
    	
    	for (int i = 0; i < 4; i++) {
    		for (int j = 0; j < 2; j++) {
    			matriz[i, j] = rand.Next(1,11);
    	    }
    	}
    	for (int i = 0; i < 4; i++) {
    		for (int j = 0; j < 2; j++) {
    			Console.Write(matriz[i, j] + " ");
    		}
    		Console.WriteLine();
    	}
    	int soma = 0;
    	for (int i = 0; i < 4; i++) {
    		for (int j = 0; j < 2; j++) {
    			soma += matriz[i, j];
    		}
    	}	
    	Console.Write("A soma da matriz é: {0}\n",soma);
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
