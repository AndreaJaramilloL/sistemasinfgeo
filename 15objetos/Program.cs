using System;
//codigo cliente
namespace _15objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar la clase y crear espacio en memoria para objeto de la misma linea
            Empleado empleado1 = new Empleado();

             //instancia de clase que y en otra linea crear espacio para objeto
            Empleado empleado2;
            empleado2 = new Empleado();

           // empleado1 empleado3 = new empleado("Maria",45);
           Empleado empleado3 = new Empleado("Maria",45);
 
            empleado1.Nombre="juan";
            empleado1.Edad=25;
            empleado2.Nombre="pedro";
            empleado2.Edad=30;
            
           Console.WriteLine("empleado 1: {0} , {1}",empleado1.Nombre, empleado1.Edad);
           Console.WriteLine("empleado 2: {0} , {1}",empleado2.Nombre, empleado2.Edad);
           Console.WriteLine("empleado 3: {0} , {1}",empleado3.Nombre, empleado3.Edad);
           
           empleado1.CalcularV(DateTime.Parse("02/13/2021"),70); 
              
        }
    } 
}