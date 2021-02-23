using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ve
{
    class Program
    {
        static void Main(string[] args)
        {
          const int n = 14;
          int[] A = {14,15,1,2,3,4,5,6,7,8,9,11,10,12,13};
          
          
          for(int i =0; i < n; i++)
         
          Console.Write(A[n - i - 1] + "\t");
           
           int[] n = new int [15];        
            int i;
            for(i =0; i < 15;i++)
            {
            n[i] = i + 1;
            }
            for(i =0; i< 15; i++)
            {
            Console.WriteLine("elemento [ "+n[i]+" ]");
            }
            Console.Write(n[15  - i - 1] + "\t");
        
                Console.ReadKey();
                Console.Write(" ");
        } 
    }

}
