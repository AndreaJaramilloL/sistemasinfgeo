using System;

namespace _6pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub, don;
            string[] ings;

            string tamaño="", inredientes="", cubierta, donde;

            if(args.Length==0){
                Menu();
                return 1;
            }
             //eleir tamaño 
            tam=char.Parse(args[0].ToUpper());
            if(tam=='P') tamaño="Pequeña";
            else if(tam=='M') tamaño ="Mediana";
            else tamaño="Grande";

            //elegir ingredientes
            ings=args[1].Split("+");
            foreach(string i in ings){
                switch(char.Parse(i.ToUpper())){
                    case 'E' : inredientes+="Extraqueso ";break;
                    case 'C' : inredientes+="Champiñones ";break;
                    case 'P' : inredientes+="Piña ";break;
                }

            }
            //Tipo de cubierta
            cub=char.Parse(args[2].ToUpper());
            cubierta=(cub=='D' ? "Delgada": "Gruesa");
            //donde la consume
            don=char.Parse(args[3].ToUpper());
            donde=(don=='A' ? "Aquí": "Llevar");
            //resultado del pedido
            Console.WriteLine("tu pizza queda así");
            Console.WriteLine("Tamaño        : {0} ",tamaño);
            Console.WriteLine("Ingredientes  : {0} ",inredientes);
            Console.WriteLine("Cubierta      : {0} ",cubierta);
            Console.WriteLine("consumes      : {0} ",donde);
            return 0;
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("\n elige como deseas armar tu pizza");
            
            Console.WriteLine("Tamaño: [P]equeña [M]ediana [G]rande");
            Console.WriteLine("Ingredientes: [E]xtra queso, [C]hampiñones [P]iña, unidos por +");
            Console.WriteLine("Cubierta: [D]elgada [G]ruesa ");
            Console.WriteLine("Donde la consumes: [A]quí [L]levar");
        }
    }
}
