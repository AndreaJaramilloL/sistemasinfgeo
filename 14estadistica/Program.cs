using System;

namespace _14estadistica
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = (10,20,30,40,50,60,70,80,90);
            double mayor=0,menor=0, promedio=0,varianza=0,desvest=0;
            Console.WriteLine("Programa que genera calculos estadisticos");

            //calculos
            mayor=May(valores);
            menor=Men(valores);
            promedio=P
            //salida
            Console.WriteLine("El mayor es     :{0}",mayor);
            Console.WriteLine("El menor es     :{0}",menor);
        }
        static double May(double[]v){
            double m=v[0];
            for(int i=0; i<v.Length; i++){
                if(v[i]>m) m=v[i];
            
            }
            return m;
        }
        static double Men(double[]v){
            double m=v[0];
            for(int i=0; i<v.Length; i++){
                if(v[i]>m) m=v[i];
            
            }
            return m;
        }
    }
}
