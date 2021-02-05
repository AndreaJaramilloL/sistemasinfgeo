//programa que muestre tablas de multiplicar 
//Andrea Jaramillo Leiva
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _7tablas
{
    class Program
    {
        static void Main(string[] args)
        {
           int r;
            Console.WriteLine("indica que tabla desea visualizar");  
            
            r = Convert.ToInt16(Console.ReadLine());
            for(int i = 1; i <= r; i++)
            {
                for(int j =4; j <= 11; j++)
                Console.WriteLine(i + "x" + j + "= " + (i * j));
                 Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
