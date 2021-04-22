using System;

namespace PR2_Alumnos
{
    public class Alumno
    {
       
        public string nombre;
        public string apellido;
        public int edad;
        public int matricula;

        public Alumno(string nombre, string apellido, int edad, int matricula)
        {

            this.nombre = nombre;

            this.apellido = apellido;

            this.edad = edad;

            this.matricula = matricula;

        }
        
        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

            // if ( matricula == null)
            // {

            // Console.WriteLine(InformacionPersonal); 
            // return null;

            // }                    
            

    }
}
