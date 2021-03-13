using System;
using System.linq;
using static System.Console;
using System.Collections.Generic;
namespace _27linq1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1. fuente datos
            int[] numeros = new int[] {10,25,-1,10,0,20,22,65,000,-4,28,1000,2000,-233}; 

            //imprimir numeros pares
            WriteLine("listado de numeros pares de manera convencional");
            for(int i=0; i<numeros.Length; i++){
                inf(numeros[i]%2==0)
                Write($"{numeros[i]}");
            }
            //2. crear consulta para obtener numeros pares
            var qryppares = from num in numeros where (num%2)==0 select num;
            //3. ejecutar consulta
            WriteLine("estado de nueros pares usando linq");
            foreach (it n in qrypares)

              wrileLine(n);

              var qrypares = (from num in where (num%2)!=0 select num).ToArray();
              foreach(int n in qryinpares)
              Write($"{n}" );             

              WriteLine("listado de numeros mayores a 100 uasando linq y listado en formato lista");
              var mayores = (from num in numeros where (num>=20 && num<=1000) && num%2==0 select num).ToList();
              mayores.foreach(n=>Write($"{n}"));
        }
    }
}
