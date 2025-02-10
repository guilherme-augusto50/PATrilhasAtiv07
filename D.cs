using System;

class Program
{
    static void Main()
    {
    	
    	
    	int[,] matriz = new int[10,10];
    	
    	
    	Console.WriteLine("Digite os elemntos da matriz 10x10: \n");
    	
    	
    	
    	for (int i = 0; i < 10; i++) {
    		for (int j = 0; j < 10; j++) {
    			if (i != j) {
    				Console.Write("elemento {0}, {1}:",i+1,j+1);
    				matriz[i, j] = int.Parse(Console.ReadLine());
    			} else {
    				matriz[i,j] = 0;
    				
    			}
    	    }
    	}
    	Console.WriteLine("\nTodos os elementos menos os da diagonal principal:");
    	for (int i = 0; i < 10; i++) {
    		for (int j = 0; j < 10; j++) {
    			Console.Write(matriz[i, j] + " ");
    		}
    		Console.WriteLine();
    	}	
    Console.WriteLine();
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
