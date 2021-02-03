//programa que calcula el area de un circulo
using System;

namespace _2areacirculo
{
    class Program
    {
        double rad, area;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando el area de un circulo!");
            Console.WriteLine("Dame el radio"); 

            rad = float.Parse(Console.ReadLine());
            area = Math.PI *  Math.Pow(rad,2);

            Console.WriteLine("El área del circulo es: {0}", area);   
        }
    }
}
