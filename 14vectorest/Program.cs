using System;

namespace _14vectorest
{
   class programa
   {
        static void Main(string[] args)
        {
            const int MAX=100;
            int n=0;
            double [] valores;
            double mayor=0, menor=0, promedio=0,varianza=0,desvest=0;
            Console.WriteLine("programa que genra estadisticas de numeros");
            
            Console.WriteLine("cuantos elementos desea calcular ?"); n=int.Parse(Console.ReadLine());
            if(n>MAX){
                Console.WriteLine("el maximo numero de elementos es: {0}",MAX);
            }
            //calculos
            else{
                valores = new double[n];
            //leer valores del usuario
            for(int i=0; i<n; i++){
                Console.Write("valores[{0}]", i+1);
                valores[i]=double.Parse(Console.ReadLine());
            }

            mayor=Funciones.May(valores);
            menor=Funciones.Men(valores);
            promedio=Funciones.Prom(valores);
            varianza=Funciones.Var(valores,promedio);
            desvest=Math.Sqrt(varianza);
            //salida
            Console.WriteLine("el mayor es        : {0}",mayor);
            Console.WriteLine("el menor es        : {0}",menor);
            Console.WriteLine("el promedio es     : {0}",promedio);
            Console.WriteLine("la varianza es     : {0}",varianza);
            Console.WriteLine("la desviacion estandar es     : {0}",desvest);
            }
        }
    }
        


}
