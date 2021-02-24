using System.Collections.Generic;

namespace _16cuentav1
{
    public class Banco
    {
       private string nombre;
       private string propietario;
       private List<Cliente> clientes;//define una lista de tipo cliente

       public Banco(string nombre, string propietario){
           this.nombre=nombre;
           this.propietario=propietario;
           clientes=new List<Cliente>();//crea espacio en memoria para la lista
       }

       public string Nombre
       {
           get { return nombre; }
       }
       
       public string Propietario
       {
           get { return propietario; }
       }

       public List<Cliente> Clientes{//regresa la lista de clientes
           get {return clientes;}
       }
        public void AgregarCliente(Cliente cliente){//agrega un cliente a la lista
            clientes.Add(cliente);
        }
       
    }
}