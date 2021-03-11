using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _28linq2
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] frutas = new string[]
         {"pera","manzana","sandia","durazno","platano"};

         WriteLine("frutas comienzan co la letra m");
         var mfrutas = from  f in frutas where f.StrartsWith("m") select f;
         foreach(string f in mfrutas) Write($"{f});
        
        WriteLine("frutas que contienen las letras  an");
        WriteLine("frutas contienen letras an {0}", anfrutas.Count());
        foreach(string f in anfruta) Write($"{f} ");
        
        var frutasa = (from f in frutas where f.EndsWith('a') select f).ToList();
        WriteLine("");
        }

    }
}
