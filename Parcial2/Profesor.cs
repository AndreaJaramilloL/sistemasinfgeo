using System;//CLASE NODO
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

class Profesor{
    private string nombre, grupo, materia; 
    private DateTime fechaing; 
    private ArrayList listaAlumnos;
    private int [] promedios = new int[10];
    private int salario; 
    private int posicion;
    public Profesor(string nombre, DateTime fechaing, string grupo, string materia, int salario){
        this.nombre = nombre;
        this.fechaing = fechaing;
        this.grupo = grupo;
        this.materia = materia;
        this.salario = salario;
        listaAlumnos = new ArrayList();
        posicion = -1;
    }
    public string getNombre(){
        return nombre;
    }
    public string getGrupo(){
        return grupo;
    }
    public int getSalario(){
        return salario;
    }
    public ArrayList getAlumnos(){
        return listaAlumnos;
    }
    public bool agregarAlumno(Alumno alumno){
        if(alumno!=null && posicion < promedios.Length){
            listaAlumnos.Add(alumno);
            promedios[posicion+1] = alumno.getPromedio();
            posicion++;
            return true;
        }else{
            return false;
        }        
    }
    public int totalBecarios(){
        int cantBecados = 0;
        foreach(Alumno alumno in listaAlumnos){
            if((alumno.getBecado().ToLower()).Equals("si")){
                cantBecados++;
            }
        }
        return cantBecados;
    }
    public int getPromedioMayor(){
       int promedioMayor = promedios[0];
       for(int pos=1; pos<promedios.Length; pos++){
           if(promedios[pos] > promedioMayor){
               promedioMayor = promedios[pos];
           }
       }
       return promedioMayor;
    }
    public int getPromedioMenor(){
        int promedioMenor = promedios[0]; 
      return promedioMenor;
    }
    //devuelve el toString modificado de manera que realiza las operaciones correspondientes para obtener el informe deseado.
    public override string ToString(){
        int epocaActual = DateTime.Now.Year;
        int epocaIngreso = fechaing.Year;
        return "Nombre: "+nombre + ", "+"  FechaIng:   "+fechaing.Date.ToString("dd/MM/yyyy")+ ", "+"  Grupo:  "+grupo+ ", "+"  Materia: "+materia+", "+"  Salario: "+salario.ToString("C", new CultureInfo("en-US"))+", "+"  Alumnos: "+listaAlumnos.Count+", "+"  Antiguedad: "+(epocaActual-epocaIngreso);
    }
}