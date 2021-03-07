namespace _16cuentav1
{
    public class CuentaBancaria
    {
        
        protected double saldo;//permite que las clases que eredan uedan acceder a esta variavle

        public CuentaBancaria(double){
            this.saldo=saldo;
        }
       
       public double Saldo {
           get {return saldo;}
       }
       public void Deposita(double cant){
           saldo+=cant;
       }
       public virtual bool Retira(double cant) {// este metodo puede ser sobrecargado en la calse
           if(saldo>=cant){
               saldo-=cant;
               return true;
           } else
           return false;
       }


    }
}