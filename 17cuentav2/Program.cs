using System;
namespace _16cuentav1
{
    class Program
    {
        static void Main(string[] args)
        {
        mibanco.AgregaCliente(new Cliente("Amalia Garcia"));//0
        mibanco.AgregaCliente(new Cliente("Miguel alonso"));//0
        mibanco.AgregaCliente(new Cliente("Alejandro tello"));//0
        mibanco.AgregaCliente(new Cliente("Ricardo Monreal"));//0

//cliente 0
        mibanco.Clientes[0].AgregaCuenta(new CuentaDeAhorro(5500,.10);      
        mibanco.Clientes[0].AgregaCuenta(new CuentaDeAhorro(1000,400);  
        mibanco.Clientes[1].AgregaCuenta(new CuentaDeAhorro(6000,.05);  
        mibanco.Clientes[1].AgregaCuenta(new CuentaDeAhorro(8000,300);  
        mibanco.Clientes[2].AgregaCuenta(new CuentaDeAhorro(118000,400);  
        mibanco.Clientes[3].AgregaCuenta(new CuentaDeAhorro(150000,0.4);  
        mibanco.Clientes[3].AgregaCuenta(new CuentaDeAhorro(30000,0.3);  

        Console.WriteLine("\n Reporte Bancario");
        Console.WriteLine("\n Banco : {0} Propietario: {1}", mibanco.Nombre, mibanco.Propietario);
        foreach(Cliente cte in mibanco.Clientes){
            Console.WriteLine($"Nombre: {cte.Nombre}, Tiene: {cte.Cuentas.Count} cuentas");
            foreach(CuentaBancaria cta in cte.Cuentas){
                Console.WriteLine( (cta is CuentaDeCheques) ? "cuenta de cheques ": "cuenta de ahorro");
                Console.WriteLine($"{ccta.Saldo}");
            }

        }

        }
        static void PruebaCuentas()
        {
            CuentaDeAhorro = miahorro1 = new CuentaDeAhorro(5500,0.1);
            CuentaDeCheques = miahorro1 = new CuentaDeCheques(900,500);

            //miahorro
            miahorro1.Deposita(1500);
            miahorro1.Retira(100);
            Console.WriteLine("mi ahorro 1 {0},miahorro1.Saldo");
            miahorro1.CalcularIntereses();
            Console.WriteLine("mi ahorro 1 {0}",miahorro1.Saldo);

            //micheque


        }
    }
}

