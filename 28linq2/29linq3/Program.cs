using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace _29linq3
{
    class Estudiante {
        public int Matricula {get; set;}
        public string Nombre {get; set;}
        public string Domicilio {get; set;}
        public List<float> Califs {get; set;}
        public override string ToString() => &"Matricula:{Matricula},Nombre:{Nombre},Domicilio:{Domicilio},{string.Join(",",Calfs")};

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>(){
                Console.WriteLine{Matricula=111,Nombre="Juan perez", Domicilio="callejon gato 111,zac",Califs=new List<float>{97,92,81,78}},
                Console.WriteLine{Matricula=111,Nombre="Juan perez", Domicilio="callejon gato 111,zac",Califs=new List<float>{97,92,81,78}},
                Console.WriteLine{Matricula=111,Nombre="Juan perez", Domicilio="callejon gato 111,zac",Califs=new List<float>{97,92,81,78}},
                Console.WriteLine{Matricula=111,Nombre="Juan perez", Domicilio="callejon gato 111,zac",Califs=new List<float>{97,92,81,78}},
                Console.WriteLine{Matricula=111,Nombre="Juan perez", Domicilio="callejon gato 111,zac",Califs=new List<float>{97,92,81,78}},
            };

            WriteLine("todos los estudianates estan registrados y almacenados su s datos");
            estudiantes.foreach (e=>WriteLine(e.ToString()));

         WriteLine("estudiantes que son de zactaecas");

var estzac = (from e in estudiantes where e,Domicilio.Contains{"Zactecas"}select e)ToList(); 
estzac.foreach (e=>WriteLine(e.ToString())
{
    
}       }
    }
}
