﻿using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace _33streams3
{
        public class Empleado {
            public int Id {get; set;}
            public string Nombre { get; set;}
            public double Salario { get; set;}
            public override string ToString() => $"Id:{Id,-3}, Nombre:{Nombre,-12}, Salario: {Salario,10:N0}";

        }
    class Program
    {
        static string ruta = Path.Combine(Environment.CurrentDirectory,"datos.xml");
        
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir y leer datos en formato XML");
            List<Empleado> emps = new List<Empleado>() {
                new Empleado {Id=1, Nombre="carlos lopez",Salario=5300},
                new Empleado {Id=2, Nombre="amara carlo",Salario=6500},
                new Empleado {Id=3, Nombre="juan jose marcos",Salario=15300},
                new Empleado {Id=4, Nombre="Miguel Alvare",Salario=3000}
            };
            emps.ForEach(e=>Console.WriteLine(e.ToString()));
            Console.WriteLine("serializar atos de empleado...");
            FileStream fEmps = File.Open(ruta,FileMode.Create);
            XmlSerializer xmlEmps = new XmlSerializer(typeof(List<Empleado>));
            xmlEmps.Serialize(fEmps,emps);
            fEmps.Close();

            Console.WriteLine("deserialuzar datos de empleados {0}", ruta);
            FileStream fEmps2 = File.Open(ruta,FileMode.Open);
            XmlSerializer xmlEmps2 = new XmlSerializer(typeof(List<Empleado>));
            List<Empleado> emps2 = (List<Empleado>)xmlEmps2.Deserialize(fEmps2);
            emps2.ForEach(e=>Console.WriteLine(e.ToString()));
        }
    }
}
