//9 prorama que genere dos arrelos de 15 numeros aleatorios y los suma en un tercer vector

using System;

namespace _9dosvectores
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            int [] A = new int[TAM];
            int [] B = new int[TAM];
            int [] C = new int[TAM];
            Random rnd = new Random();
        Console.WriteLine("programa que suma dos vectores y suma dos vectores de 15 numeros aleatorios y los suma en un tercer vector");
            for(int i=0; i<TAM; i++){
                A[i]=rnd.Next(1,100);
                B[i]=rnd.Next(1,100);
                C[i]=A[i]+B[i];
            }
            Console.WriteLine("elementos en el vector A"); imprime(A);
            Console.WriteLine("elementos en el vector B"); imprime(B);
            Console.WriteLine("elementos en el vector C"); imprime(C);
           //Console.WriteLine("Programa que genera de 15 en 15 numeros aleatorios y los suma en un tercer vector!");
        }
        static void imprime(int[] v){
            for(int i=0;i<v.Length;i++)
    Console.Write("{0}",v[i]);
        }
    }

}
