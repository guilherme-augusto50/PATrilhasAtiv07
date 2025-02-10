using System;

class Program
{
    static void Main()
    {
    	
    	const int  NumL= 3;
    	const int NumC= 3;
    	
    	int[,] matriz = new int[NumL,NumC];
    	
    	//Console.WriteLine("Escreva um número");
    	
    	
    	for (int i = 0; i < NumL; i++) {
    		for (int j = 0; j < NumC; j++) {
    			matriz[i, j] = int.Parse(Console.ReadLine());
    	    }
    	}
    	for (int i = 0; i < NumL; i++) {
    		for (int j = 0; j < NumC; j++) {
    			Console.Write(matriz[i,j] + " ");
    		}
    		Console.WriteLine();
    	}	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
