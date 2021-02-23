using System;
                    
public class Program
{
    public static void Main()
    {
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[5];
        
        Random rnd = new Random();

         for (int a = 0; a < 5; a++)
        {
           A[a] = rnd.Next(1, 10);
           B[a] = rnd.Next(1, 10);
        }
        Console.Write("Array 1: ");
        for (int a = 0; a < 5; a++)
        {
            Console.Write(A[a] + " ");
        }
        Console.Write("\n\n B : ");
        for (int a = 0; a < 5; a++)
        {
            Console.Write(B[a] + " ");
        }
        
        for(int i = 0; i < 5; i++){
            int res = A[i];
            
            for(int j = 0; j < 5; j++){
                res *= B[j];
            }
            C[i] = res;
        }
        
        Console.Write("\n\nC : ");
        for (int a = 0; a < 5; a++)
        {
            Console.Write(C[a] + " ");
        }
        
    }
}
