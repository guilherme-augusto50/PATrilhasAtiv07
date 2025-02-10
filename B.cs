using System;

class Program
{
    static void Main()
    {
    	
    	
    	int[,] matriz = new int[10,10];
    	
    	Console.WriteLine("Digite os elemntos da matriz 10x10: \n");
    	
    	
    	
    	for (int i = 0; i < 10; i++) {
    		for (int j = 0; j < 10; j++) {
    			Console.Write("{0}º elemnto:",i+1);
    			matriz[i, j] = int.Parse(Console.ReadLine());
    	    }
    	}
    	Console.WriteLine("Elementos na diagonal principal");
    	for (int i = 0; i < 10; i++) {
    		Console.Write(matriz[i,i] + " ");
    	}	
    	Console.WriteLine();
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
