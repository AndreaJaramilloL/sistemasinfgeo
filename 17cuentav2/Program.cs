using System;
namespace _16cuentav1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retiro;
            Banco mibanco = new Banco("Banco", "Andrea Jaramillo");
            CuentaBancaria micuenta1 = new CuentaBancaria(100);
            CuentaBancaria micuenta2 = new CuentaBancaria(300);
            Cliente micliente1 = new Cliente("Juan perez");
            Cliente micliente2 = new Cliente("Maria Lopez");
            Cliente micliente3 = new Cliente();
            micliente3.Nombre="Miguel Mendeza";
            micliente1.Cuenta = micuenta1;
            micliente2.Cuenta = micuenta2;
            micliente3.Cuenta = new CuentaBancaria(10000);
            micuenta1.Deposita(300);
            retiro = micuenta2.Retira(500);
            if(retiro) Console.WriteLine("retiro exitoso");
            else Console.WriteLine("no se puede retirar la cantidad solicitada");
            micliente3.Cuenta.Deposita(10000);
            micliente2.Cuenta.Retira(100);
            //agregar clientes existentes al banco
            mibanco.AgregarCliente(micliente1);
            mibanco.AgregarCliente(micliente2);
            mibanco.AgregarCliente(micliente3);
            mibanco.AgregarCliente(new Cliente("rubén Ibarra"));//crea y agreg un nuevo cliente
            mibanco.Clientes[3].Cuenta = new CuentaBancaria(50000);//crear y agregar una cuenta bancaria al nuevo cliente        
            //salida
            Console.WriteLine("control bancario");
            Console.WriteLine("saldo cuenta 1 : {0}", micuenta1.Saldo);
            Console.WriteLine("saldo cuenta 2 : {0}", micuenta2.Saldo);
            Console.WriteLine("cliente 1: nombre : {0}, saldo : {1}", micliente1.Nombre, micliente1.Cuenta.Saldo );
            Console.WriteLine("cliente 2: nombre : {0}, saldo : {1}", micliente2.Nombre, micliente2.Cuenta.Saldo );
            Console.WriteLine("cliente 3: nombre : {0}, saldo : {1}", micliente3.Nombre, micliente3.Cuenta.Saldo );
            //Imprimir reporte bancario 
            Console.WriteLine("\nReporte bancario");
            Console.WriteLine($"\nBanco {mibanco.Nombre}, Propietario {mibanco.Propietario}");
            foreach(Cliente cte in mibanco.Clientes){
                Console.WriteLine($"Nombre: {cte.Nombre}, Saldo:{cte.Cuenta.Saldo}");
            }
            Console.WriteLine("\ntotal de clientes  {0}", mibanco.Clientes.Count);
        }
    }
}

