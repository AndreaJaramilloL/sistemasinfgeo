using System;
using System.Collections;
using System.Collections.Generic;

class Institucion{

    private string nombre, encargado, domicilio;
    private int posicion = -1, cantAlumnos;
    public int [] salarios = new int[10];   
    public Profesor [] profesores;

    private HashSet<string> grupos;

    public int salarioMayor,salarioMenor; 

    public Institucion(string nombre, string encargado, string domicilio){
        this.nombre = nombre;
        this.encargado = encargado;
        this.domicilio = domicilio;
        grupos = new HashSet<string>();
        profesores = new Profesor[20];
    }


    public void agregarProfesor(string nombre, DateTime fechaing, string grupo, string materia, int salario){
        Profesor profesor = new Profesor(nombre,fechaing,grupo,materia,salario);
        grupos.Add(grupo);
        profesores[posicion+1] = profesor;
        salarios[posicion+1] = salario;
        posicion++;
    }

    public void agregarAlumno(int numProfesor, string nombre, int edad, DateTime fechaing, string becado, string calificaciones){
        Alumno alumno = new Alumno(nombre,edad,fechaing,becado,calificaciones);
        Profesor profesor = (Profesor)profesores[numProfesor-1];
        profesor.agregarAlumno(alumno);
        cantAlumnos++;
        
    }
    
    //devuelve el total de grupos que existen en la escuela, sin que exista un duplicado de estos. 
    public int getGrupos(){
        return grupos.Count;
    }

    //devuelve el nombre de la escuela.

    public string getNombre(){
        return nombre;
    }

    public Profesor[] getProfesores(){
        return profesores;
    }

    public int getCantAlumnos(){
        return cantAlumnos++;
    }


    public int getSalarioTotal(){
        salarioMayor = salarios[0];
        salarioMenor = salarios[0];
        int salarioTotal = 0;
        for(int pos=1; pos<salarios.Length; pos++){
            if(salarios[pos] > salarioMayor){
                salarioMayor = salarios[pos];
            }
            salarioTotal+=salarios[pos];
        }  
        salarioMenor = salarios[3];     
        return salarioTotal+salarios[0];
    }

    public string getEncargado(){
        return encargado;
    }

    public string getDomicilio(){
        return domicilio;
    }

}