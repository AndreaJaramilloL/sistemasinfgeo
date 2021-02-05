//Diseñar una aplicación de consola para realizar lo siuiente:
//Números del 1 al 100 con ciclo while
//Números del 100 al 1 con ciclo do .. while
//Números del 50 al 200 con ciclo for
//Números del 2 al 100 solo los pares con ciclo for
//Números del 99 al 1 solo los impares con ciclo for
//Números del 272 al 40 en decrementos de 4 con ciclo while

//Andrea Jaramillo Leiva
//04 de febrero del 2021
using System;

namespace _5ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op,c,suma;
             if(args.Length==0){
                 Menu();
                 return 1;
            }
            op=int.Parse(args[0]);
            switch(op){
                case 1:{//numeros del 1 al 100 con while
                        c=1;suma=0;
                            while(c<=100){
                                Console.Write("{0} ",c);
                                suma+=c;
                                c++;
                        }
                        Console.WriteLine("\nla suma es {0} ",suma);
                   }   break;
                   case 2:{ //numeros del 100 al 1 usando do.. while
                        c=100;suma=0;
                           do{
                                Console.Write("{0} ",c);
                                suma+=c;
                                c--;
                        }while(c>=1);
                        Console.WriteLine("\nla suma es {0} ",suma);
                   }   break;
                   case 3 :{//numeros del 50 al 200 con for
                       suma=0;
                        for(c=50; c<=200; c++){
                          Console.Write("{0} ",c);   
                        }
                    Console.WriteLine("\nla suma es {0} ",suma);
                   }break;
                   case 4 :{//numeros del 2 al 100 pares con 100
                       suma=0;
                        for(c=2; c<=100; c+=2){
                          Console.Write("{0} ",c);   
                        }
                    Console.WriteLine("\nla suma es {0} ",suma);
                   }break; 
                   case 5 :{//numeros de 99 a el 1 impares usando for
                       suma=0;
                        for(c=99; c>=1; c--){
                          Console.Write("{0} ",c);   
                        }
                    Console.WriteLine("\nla suma es {0} ",suma);
                   }break; 
                   case 6 :{ //numeros del 100 al 1 usando do.. while
                        c=1272;suma=0;
                           do{
                                Console.Write("{0} ",c);
                                suma+=c;
                                c-=4;
                        }while(c>=4);
                        Console.WriteLine("\nla suma es {0} ",suma);
                   }   break;
                }
                     
            
             return 0;
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] numeros del 1 al 100 usando ciclo while");
            Console.WriteLine("[2] numeros del 100 al 1 con ciclo do. while");
            Console.WriteLine("[3] numeros del 50 al 200 usando ciclo for");
            Console.WriteLine("[4] numeros del 2 al 100 usando solo los pares con ciclo for");
            Console.WriteLine("[5] numeros del 99 al 1 usando ciclo for");
            Console.WriteLine("[6] numeros del 272 al 40 en decrementos de 4 con ciclo while");
        }
    }
}
