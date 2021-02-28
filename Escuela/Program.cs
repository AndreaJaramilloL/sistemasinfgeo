using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Institucion inst = new Institucion("Universidad Patito SA de CV","Ing. Juan Perez", "Av De la Juventud 348");
        
            inst.agregarProfesor("Jose Diaz",DateTime.Parse("1/1/2018"),"1A","Fisica",1200);
            inst.agregarProfesor("Maria Perez",DateTime.Parse("10/2/2016"),"2A","Algebra",3400);
            inst.agregarProfesor("Claudia Sid",DateTime.Parse("1/4/2019"),"4B","Calculo",3800);
            inst.agregarProfesor("Carlos Lopez",DateTime.Parse("10/3/2016"),"8A","Quimica",1000);

            inst.agregarAlumno(1,"Fatima Soto",23,DateTime.Parse("1/1/2019"),"Si","7,7,7");
            inst.agregarAlumno(1,"Damian Diaz",25,DateTime.Parse("1/1/2016"),"No","8,8,8");
            inst.agregarAlumno(1,"Fatima Soto",23,DateTime.Parse("1/1/2018"),"Si","6,6,6");
            inst.agregarAlumno(2,"Maria Ochoa",20,DateTime.Parse("1/10/2018"),"Si","9,9,9");
            inst.agregarAlumno(2,"Carlos Diaz",23,DateTime.Parse("1/10/2018"),"No","8,8,8");
            inst.agregarAlumno(4,"Jose Ochoa",19,DateTime.Parse("1/10/2016"),"No","6,6,6");


            Console.WriteLine("\n>>Datos Generales de la Escuela: \n\n"
             +"Escuela:   "+inst.getNombre()+"\n"
             +"Encargado: "+inst.getEncargado()+"\n"
             +"Domicilio: "+inst.getDomicilio()+"\n");

             Console.WriteLine(" \nTotal grupos:      "+inst.getGrupos()+"\n"+
             "Total Alumnos:     "+ inst.getCantAlumnos() +"\n"+
             "Total Alumnos Becados:      \n"+
             "Total Salario Profesores:      "+inst.getSalarioTotal().ToString("C", new CultureInfo("en-US"))+"\n\n");

            Profesor[] profesores = inst.getProfesores();

            Console.WriteLine(">> Datos generales de los profesores: \n\n");
            for(int posx=0; posx < profesores.Length; posx++){
                Profesor profesor = (Profesor)profesores[posx];
                if(profesor!=null){
                    Console.WriteLine(profesor.ToString());
                }else{
                    break;
                }
            }
            
            Console.WriteLine("\n"+"Mayor salario: "+inst.salarioMayor.ToString("C", new CultureInfo("en-US"))+ "\n"+"Menor salario: "+
            inst.salarioMenor.ToString("C", new CultureInfo("en-US"))+"\n\n");
           
            for(int pos=0; pos < profesores.Length; pos++){
                Profesor profesor = (Profesor)profesores[pos];
                if(profesor!=null){
                     Console.WriteLine("\n\n > Nombre: "+profesor.getNombre()+",   "+"Grupo: "+profesor.getGrupo()+"\n\n");
                     ArrayList estudiantes = profesor.getAlumnos();
                    if(estudiantes.Count>0){
                        foreach(Alumno alumno in estudiantes){
                            Console.WriteLine(alumno.ToString());
                        }
                    Console.WriteLine("\n\n"+"Mayor Promedio: "+profesor.getPromedioMayor()+ 
                    "\n"+"Menor Promedio: "+profesor.getPromedioMenor()+"\n"+"Total becados: "+profesor.totalBecarios());
                    }else{
                        Console.WriteLine("No tiene alumnos aun");
                    }
                }else{
                    break;
                }
            }
        }
    }
}
