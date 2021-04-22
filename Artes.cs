using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    public class Artes
    {
        public List<Alumno> Semestre2Artes = new List<Alumno>();
        public List<Alumno> Semestre4Artes = new List<Alumno>();
        public List<Alumno> Semestre6Artes = new List<Alumno>();
        public List<Alumno> Semestre8Artes = new List<Alumno>();

        

        public Artes()
        {
            
        }

        public void BuscarTodos()
        {
            Console.WriteLine("Mostrando todos los alumnos de Licenciatura en Artes Visuales....");

            Console.WriteLine("");
            Console.WriteLine("------2ndo. Semestre------");
            Console.WriteLine("");
            
            for(int i = 0; i < Semestre2Artes.Count; i++)
            {
                

                Console.WriteLine($"Alumno: {Semestre2Artes[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre2Artes[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre2Artes[i].matricula}");
                Console.WriteLine("");
            }
             
            Console.WriteLine("------4to. Semestre------");
            Console.WriteLine("");
            
            for(int i = 0; i < Semestre4Artes.Count; i++)
            {
                

                Console.WriteLine($"Alumno: {Semestre4Artes[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre4Artes[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre4Artes[i].matricula}");
                Console.WriteLine("");
            }


            Console.WriteLine("------6to. Semestre------");
            Console.WriteLine("");
             
             for(int i = 0; i < Semestre6Artes.Count; i++)
            {

                Console.WriteLine($"Alumno: {Semestre6Artes[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre6Artes[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre6Artes[i].matricula}");
                Console.WriteLine("");
            }
             
            Console.WriteLine("------8vo. Semestre------");
            Console.WriteLine("");

             for(int i = 0; i < Semestre8Artes.Count; i++)
            {

                Console.WriteLine($"Alumno: {Semestre8Artes[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre8Artes[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre8Artes[i].matricula}");
                Console.WriteLine("");
            }

        }


        // Buscar por matrícula
        public void BuscarPorMatricula(int matricula)
        {
            Console.WriteLine("Buscando alumno por matricula....");

            bool alumnoEncotrado = false;

            for (int i = 0; i < Semestre2Artes.Count; i++)
            {
                if(Semestre2Artes[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre2Artes[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre2Artes[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre2Artes[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre4Artes.Count; i++)
            {
                if(Semestre4Artes[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre4Artes[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre4Artes[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre4Artes[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre6Artes.Count; i++)
            {
                if(Semestre6Artes[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre6Artes[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre6Artes[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre6Artes[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre8Artes.Count; i++)
            {
                if(Semestre8Artes[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre8Artes[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre8Artes[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre8Artes[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            if (!alumnoEncotrado)
            {
                Console.WriteLine("No se encontró ningun alumno");
            }
       
                        
        }

    }
}
