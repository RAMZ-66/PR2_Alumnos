using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    public class Multimedia
    {


        public List<Alumno> Semestre2 = new List<Alumno>();
        public List<Alumno> Semestre4 = new List<Alumno>();
        public List<Alumno> Semestre6 = new List<Alumno>();
        public List<Alumno> Semestre8 = new List<Alumno>();

        public List<Multimedia> GrupoMultimedia = new List<Multimedia>();

        public Multimedia()
        {
            // Crear alumnos y agregarlos a la lista de 2° Semestre

            // Alumno JuanC = new Alumno ("Juan Diego","Cornejo Salgado", 19, 6301);
            // Alumno AaronT = new Alumno ("Aaron","Tapia Lozada", 19, 6312);
            // Alumno MalenaV = new Alumno ("Malena","Vega López", 20, 6313);
            // Alumno MariaE = new Alumno ("María José","Escobedo Portillo", 19, 6322);
            // Alumno JuanaR = new Alumno ("Juana","Rangel Castillo", 22, 6355);

            // Semestre2.Add(JuanC);
            // Semestre2.Add(AaronT);
            // Semestre2.Add(MalenaV);
            // Semestre2.Add(MariaE);
            // Semestre2.Add(JuanaR);
           

            // Crear alumnos y agregarlos a la lista de 4° Semestre
            

            // Alumno LauraL = new Alumno ("Laura","Lujan Ochoa", 21, 6208);
            // Alumno JuanE = new Alumno ("Juan Esteban","Zapata Carballo", 26, 6256);
            // Alumno GaelC = new Alumno ("Gael","Carrillo Gaytán", 20, 6278);
            // Alumno CristobalM = new Alumno ("Crostobal","Meraz Loera", 20, 6238);
            // Alumno DylanC = new Alumno ("Dylan","Castañeda Mendez", 20, 6255);

            // Semestre4.Add(JuanC);
            // Semestre4.Add(JuanE);
            // Semestre4.Add(GaelC);
            // Semestre4.Add(CristobalM);
            // Semestre4.Add(DylanC);  


            // Crear alumnos y agregarlos a la lista de 6° Semestre
            

            // Alumno CamilaR = new Alumno ("Camila","Ríos Casárez", 21, 6128);
            // Alumno AnaO = new Alumno ("Ana","Osorio Chacón", 25, 6186);
            // Alumno AlejandroZ = new Alumno ("Alejandro","Zamora Casas", 21, 6148);
            // Alumno SantiagoP = new Alumno ("Santiago","Paz Cruz", 22, 6134);
            // Alumno ManuelS = new Alumno ("Manuel","Segoviano Rivas", 21, 6119);

            // Semestre6.Add(CamilaR);
            // Semestre6.Add(AnaO);
            // Semestre6.Add(AlejandroZ);
            // Semestre6.Add(SantiagoP);
            // Semestre6.Add(ManuelS);  


            // Crear alumnos y agregarlos a la lista de 8° Semestre
            

            // Alumno GaelA = new Alumno ("Gael","Alvarado Linares", 23, 6035);
            // Alumno DanielM = new Alumno ("Daniel","Mendoza Delatorre", 25, 6048);
            // Alumno MarioJ = new Alumno ("Mario","Juarez Cardona", 22, 6081);
            // Alumno AlmaC = new Alumno ("Alma","Carrera Baca", 22, 6061);
            // Alumno LuisO = new Alumno ("Luis","Ornelas Mondragón", 24, 6083);

            // Semestre8.Add(GaelA);
            // Semestre8.Add(DanielM);
            // Semestre8.Add(MarioJ);
            // Semestre8.Add(AlmaC);
            // Semestre8.Add(LuisO);  

            Dictionary<string, string> DictionaryAlumnos = new Dictionary<string, string>();

            DictionaryAlumnos.Add("6301", "Juan Diego Cornejo Salgado | Matricula: 6301 | 19 años");
            DictionaryAlumnos.Add("6312", "AaronT");
            DictionaryAlumnos.Add("6313", "MalenaV");
            DictionaryAlumnos.Add("6322", "MariaE");
            DictionaryAlumnos.Add("6355", "JuanaR");  

            
           
            // foreach (var value in DictionaryAlumnos.Keys)
            // {              
            //     Console.WriteLine(value);                
                

            // }         
        }

        public void BuscarTodos()
        {
            Console.WriteLine("Mostrando todos los alumnos de Ingeniería en Multimedia ....");

            Console.WriteLine("");
            Console.WriteLine("------2ndo. Semestre------");
            Console.WriteLine("");
            
            for(int i = 0; i < Semestre2.Count; i++)
            {
                

                Console.WriteLine($"Alumno: {Semestre2[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre2[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre2[i].matricula}");
                Console.WriteLine("");
            }
             
            Console.WriteLine("------4to. Semestre------");
            Console.WriteLine("");
            
            for(int i = 0; i < Semestre4.Count; i++)
            {
                

                Console.WriteLine($"Alumno: {Semestre4[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre4[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre4[i].matricula}");
                Console.WriteLine("");
            }


            Console.WriteLine("------6to. Semestre------");
            Console.WriteLine("");
             
             for(int i = 0; i < Semestre6.Count; i++)
            {

                Console.WriteLine($"Alumno: {Semestre6[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre6[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre6[i].matricula}");
                Console.WriteLine("");
            }
             
            Console.WriteLine("------8vo. Semestre------");
            Console.WriteLine("");

             for(int i = 0; i < Semestre8.Count; i++)
            {

                Console.WriteLine($"Alumno: {Semestre8[i].NombreCompleto}");
                Console.WriteLine($"Edad: {Semestre8[i].edad}");
                Console.WriteLine($"Matrícula: {Semestre8[i].matricula}");
                Console.WriteLine("");
            }

        }


        // Buscar por matrícula
        public void BuscarPorMatricula(int matricula)
        {
            Console.WriteLine("Buscando alumno por matricula....");

            bool alumnoEncotrado = false;

            for (int i = 0; i < Semestre2.Count; i++)
            {
                if(Semestre2[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre2[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre2[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre2[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre4.Count; i++)
            {
                if(Semestre4[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre4[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre4[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre4[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre6.Count; i++)
            {
                if(Semestre6[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre6[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre6[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre6[i].matricula}");
                    Console.WriteLine("");
                    alumnoEncotrado = true;
                    
                    // cierre de ciclo
                    break;
                }
                
            }

            for (int i = 0; i < Semestre8.Count; i++)
            {
                if(Semestre8[i].matricula == matricula)
                {                                     
            
                    // Se encuentra el alumno[i] buscado por matricula;
                    Console.WriteLine($"Alumno: {Semestre8[i].NombreCompleto}");
                    Console.WriteLine($"Edad: {Semestre8[i].edad}");
                    Console.WriteLine($"Matrícula: {Semestre8[i].matricula}");
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

        

            // Console.WriteLine("Alumno: " + JuanC.NombreCompleto); 
            // Console.WriteLine($"Edad: {alumno.edad} ");
            // Console.WriteLine($"Matricula: {JuanC.matricula}");

        // public virtual void MostrarPorMatricula()
        // {
        //     for (int i = 0; i < Semestre2.Count; i++  )
        //     {
        //         Console.WriteLine(Semestre2[i].nombre," ",Semestre2[i].apellido," ", Semestre2[i].edad," ", Semestre2[i].matricula);
        //     }

        //     for (int i = 0; i < Semestre4.Count; i++  )
        //     {
        //         Console.WriteLine(Semestre4[i].InformacionPersonal," ",Semestre4[i].apellido," ", Semestre4[i].edad," ", Semestre4[i].matricula);
        //     }

        // }
       
    }
}
