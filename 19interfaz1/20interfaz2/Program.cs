using System;

namespace _20interfaz2
{
      public class Organismo {
          public Organismo(string nombre)=>Nombre=nombre;
          public string Nombre {get; set;}
            public void Respiracion() => Console.WriteLine("Respirando...");
            public void Movimeinto() => Console.WriteLine("Moviendoce...");
            public void Crecimiento() => Console.WriteLine("Crecimiento..");
        }
        public interface IAnimales {
            void Multicelular();
            void SangreCaliente();
        }
public interface ICanino : IAnimales {
    void Correr()
    void CuatroPata();
}
public interfaces IAve : IAnimales {
    void Volar();
    void DosPatas();
}

public class Perro : Organismo, ICanino {}
    public Perro(string nombre): base(nombre);
    public void MultiCelular()=>Console.WriteLine("multicelular");
    public void SangreCaliente()=>Console.WriteLine("multicelularsangre calienteular");
    public void Correr()=>Console.WriteLine("correr");
    public void CuatroPatas()=>Console.WriteLine("cuatro patas");
}
public class Perico : Organismo, IAve {
    public Perico(string nombre): base(nombre) {}
    public void MultiCelular()=>Console.WriteLine("multicelular");
    public void SangreCaliente()=>Console.WriteLine("multicelularsangre calienteular");
    public void Volar()=>Console.WriteLine("correr");
    public void DosPatas()=>Console.WriteLine("dos patas");

}
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Hello World!");
                        Perro miperro = new Perro("lassie");
                        Console.WriteLine($"mi perro {miperro.Nombre} esta haciendo lo sieguiente");
                        miperro.Respiracion();
                        miperro.Movimeinto();
                        miperro.Crecimiento();

                        Perico miperico = new Perico("sparroww");
                        Console.WriteLine($"mi perico llamado {miperico.Nombre} esta haciendo lo sieguiente");
                        miperico.Respiracion();
                        miperico.Movimeinto();
                        miperico.Crecimiento();
        }
    }
}
