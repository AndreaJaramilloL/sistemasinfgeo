using System;

class Alumno{
    private string nombre;//CLASE Vulnerabilidad
    private int edad;
    private DateTime fechaing;
    private string becado, calificaciones; 

    public Alumno(string nombre, int edad, DateTime fechaing, string becado, string calificaciones){
        this.nombre = nombre;
        this.edad = edad; 
        this.fechaing = fechaing; 
        this.calificaciones = calificaciones;
        this.becado = becado;
    }

    public string getBecado(){
        return becado;
    }

    public int getPromedio(){
        int sumatoria = 0;
            String[] valores = calificaciones.Split(",");
            foreach(string cal in valores){
                sumatoria+= Int32.Parse(cal);
            }
        int prom = (sumatoria)/valores.Length;
        return prom;
    }

        public override string ToString(){
            int epocaActual = DateTime.Now.Year;
            int epocaIngreso = fechaing.Year;
            string mensaje="";
            int prom = getPromedio();
            if(prom>6){
                mensaje = "Aprobado";
            }else{
                mensaje = "Reprobado";
            }
        return "Nombre: "+nombre +", "+"Edad: "+edad+", "+"FechaIng: "+fechaing.Date.ToString("dd/MM/yyyy")+", "
        +"Becado: "+becado+", "+"Califs: "+calificaciones+", "+"Antiguedad: "+(epocaActual-epocaIngreso)+", "
        +"Prom: "+getPromedio()+ ", "+"Mensaje: "+mensaje;
        }


}