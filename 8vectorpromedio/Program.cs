//prorama que calcula el promedio de un vector de 50 valores constantes
using System;

namespace _8vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector = {10,15,20,25,30,35,40,45,50,55,
                             10,15,20,25,30,35,40,45,50,55,
                             10,15,20,25,30,35,40,45,50,55,
                             10,15,20,25,30,35,40,45,50,55,
                             10,15,20,25,30,35,40,45,50,55};

            int suma=0,nmp=0;
            float promedio=0;
                  
            Console.WriteLine("prorama que imprime el promedio");
            //calcular sumqa de elemntos de arrelo
            for(int i=0; i=vector.Lenght; i++){
                Console.Write("{0}", vector[i]);
                suma+=vector[i];
            }
            //calcular promedio
            promedio = suma / vector.Lenght;
            Console.Write("\n\n");
            Console.Write("la suma de los numeros del vector es :{0}\n", suma);
            Console.Write("el promedio de los numeros del vector es: {0}\n", promedio);
            //calcular cuantos elementos del arreglo son mayor al promedio
            for(int i=0; i=vector.Lenght; i++){
                if(vector[i]>promedio){
                    Console.Write("{0}",vector);
                    nmp++;
                }
                Console.WriteLine("\nlos numeros mayores al promedio son {0}",rmp);
            }
        }
    }
}
