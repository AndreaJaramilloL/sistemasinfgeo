using System;
namespace _15objetos
{
    //class  Program
    //{
        class Empleado {
            private string nombre;
            private int edad;
            //constructor
            public Empleado(){
            }
            public Empleado(string nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
            }
            //propiedad : metodo publico para acceder a las variavles
            public string Nombre{
                get{return nombre;}//salida
                set{nombre=value;}//entrada
            }
            public int Edad{
                get {return edad;}
                set{edad=value;}
            }
            //metodo 
            public void CalcularV(DateTime inicio, double dias){
                DateTime final;

                final=inicio.AddDays(dias);

                Console.WriteLine("tienes vacaciones desde {0} hasta {1}",
                inicio.ToString("dd/MMM/yy"), final.ToString("dd/MMM/yy") );
         
            }
          
        }  
 //   }

}