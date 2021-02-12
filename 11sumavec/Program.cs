using System;

namespace _11sumavec
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=30;

            double[] A = new double[TAM];
            Random rnd=new Random();

            Console.WriteLine("programa que guarda vectores y suma en uno ");
            
            for(int i=0;  i<TAM; i++){
                A[i]=rnd.Next(-10,50);
       }
        
        Console.WriteLine("Elementos del vector A: "); imprime(A);
        
        }
    static void imprime(double[] v){
    for(int i=0; i<v.Length; i++)
      Console.Write("{0} ",v[i]);
    }
    
 }
}

