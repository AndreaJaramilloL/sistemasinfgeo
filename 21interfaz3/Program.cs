using System;

namespace _21interfaz3
{
class Empleado {
    public string Paterno {get; set;}
    public string Materno {get; set;}
    public string Nombre {get; set;}
    public string Salario {get; set;}

    public int ComparteTo(Empleado otro){
         if(this.Salario < otro.Salario) return 1;
         else if(this.Salario > otro.Salario) return -1;
         else return 0;

    }
    

    public override string ToString() => $"{Nombre,-8} - {Salario,10:C}";
    public string ToString(string formato, IFormatProvider provedor){
        switch(formato){
            case "PMNS" : return $"{Paterno}, {Materno}, {Nombre}, Salario";
            case "NPMS" : return $"{Paterno}, {Materno}, {Nombre}, Salario";
            case "PMN" : return $"{Paterno}, {Materno}, {Nombre}, Salario";
            default : throw new FormatException("formato desconocido");
        }

    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Empleado> emps = new List<Empleado>{
                 new Empleado() {Paterno="Castañeda", Materno="Lopez", Nombre="Andrea"},
                 new Empleado() {Paterno="Garza", Materno="Moreno", Nombre="Andrea"},
                 new Empleado() {Paterno="Lope", Materno="flores", Nombre="Andrea"},
                 new Empleado() {Paterno="Barron", Materno="cling", Nombre="Andrea"},
                 new Empleado() {Paterno="mireles", Materno="Lope", Nombre="Andrea"},
            }
            Console.WriteLine("listado de empleados");
            emps.sort();
            emps.foreach(e=>Console.WriteLine(e.ToString()));

            Console.WriteLine("listado de empleados");
            emps.Reverse();
            emps.foreach (e=>Console.WriteLine(e.ToString()));
            {
                Console.WriteLine("listado de empleados con lista personalizada");
                emps.foreach (e=>Console.WriteLine item in collection)
                {
                    
                }
            }
            {
            

        }
    }
}
