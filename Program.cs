using System;
using System.Collections.Generic;


namespace PR2_Alumnos
{
    class Program
    {

        


        static void Main(string[] args)
        {
            
            Multimedia multimedia = new Multimedia();
            
            // Crear Alumnos y agregarlos a las listas de semestres

            // Semestre 2

            Alumno JuanC = new Alumno ("Juan Diego","Cornejo Salgado", 19, 6301);
            Alumno AaronT = new Alumno ("Aaron","Tapia Lozada", 19, 6312);
            Alumno MalenaV = new Alumno ("Malena","Vega López", 20, 6313);
            Alumno MariaE = new Alumno ("María José","Escobedo Portillo", 19, 6322);
            Alumno JuanaR = new Alumno ("Juana","Rangel Castillo", 22, 6355);

            multimedia.Semestre2.Add(JuanC);
            multimedia.Semestre2.Add(AaronT);
            multimedia.Semestre2.Add(MalenaV);
            multimedia.Semestre2.Add(MariaE);
            multimedia.Semestre2.Add(JuanaR);

            // Semestre 4

            Alumno LauraL = new Alumno ("Laura","Lujan Ochoa", 21, 6208);
            Alumno JuanE = new Alumno ("Juan Esteban","Zapata Carballo", 26, 6256);
            Alumno GaelC = new Alumno ("Gael","Carrillo Gaytán", 20, 6278);
            Alumno CristobalM = new Alumno ("Crostobal","Meraz Loera", 20, 6238);
            Alumno DylanC = new Alumno ("Dylan","Castañeda Mendez", 20, 6255);

           multimedia.Semestre4.Add(JuanC);
           multimedia.Semestre4.Add(JuanE);
           multimedia.Semestre4.Add(GaelC);
           multimedia.Semestre4.Add(CristobalM);
           multimedia.Semestre4.Add(DylanC);  

            // Semestre 6

            Alumno CamilaR = new Alumno ("Camila","Ríos Casárez", 21, 6128);
            Alumno AnaO = new Alumno ("Ana","Osorio Chacón", 25, 6186);
            Alumno AlejandroZ = new Alumno ("Alejandro","Zamora Casas", 21, 6148);
            Alumno SantiagoP = new Alumno ("Santiago","Paz Cruz", 22, 6134);
            Alumno ManuelS = new Alumno ("Manuel","Segoviano Rivas", 21, 6119);

            multimedia.Semestre6.Add(CamilaR);
            multimedia.Semestre6.Add(AnaO);
            multimedia.Semestre6.Add(AlejandroZ);
            multimedia.Semestre6.Add(SantiagoP);
            multimedia.Semestre6.Add(ManuelS);  

            // Semestre 8

            Alumno GaelA = new Alumno ("Gael","Alvarado Linares", 23, 6035);
            Alumno DanielM = new Alumno ("Daniel","Mendoza Delatorre", 25, 6048);
            Alumno MarioJ = new Alumno ("Mario","Juarez Cardona", 22, 6081);
            Alumno AlmaC = new Alumno ("Alma","Carrera Baca", 22, 6061);
            Alumno LuisO = new Alumno ("Luis","Ornelas Mondragón", 24, 6083);

            multimedia.Semestre6.Add(GaelA);
            multimedia.Semestre6.Add(DanielM);
            multimedia.Semestre6.Add(MarioJ);
            multimedia.Semestre6.Add(AlmaC);
            multimedia.Semestre6.Add(LuisO);  
            

            // Llamar el método para mostrar a todos los alumnos de Multimedia

            multimedia.BuscarTodos();

            // Llamar el método para buscar a un alumno de Multimedia por matrícula

            multimedia.BuscarPorMatricula(6128);


            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            
            // Hacer el mismo procedimiento para artes

            Artes artes = new Artes();

            // Crear Alumnos y agregarlos a las listas de semestres

            // Semestre 2

            Alumno AmericaF = new Alumno ("America","Frías Almanza", 19, 7301);
            Alumno ViridianaO = new Alumno ("Viridiana","Olivares Lozada", 19, 7312);
            Alumno AbelardoB = new Alumno ("Abelardo","Barela Barrón", 20, 7313);
            Alumno LiliC = new Alumno ("Lili","Carrera Portillo", 19, 7322);
            Alumno AnahiM = new Alumno ("Anahí","Montañez Corona", 22, 7355);

            artes.Semestre2Artes.Add(AmericaF);
            artes.Semestre2Artes.Add(ViridianaO);
            artes.Semestre2Artes.Add(AbelardoB);
            artes.Semestre2Artes.Add(LiliC);
            artes.Semestre2Artes.Add(AnahiM);

            
            // Semestre 4

            Alumno DionO = new Alumno ("Dion","Ochoa Gaytán", 21, 7208);
            Alumno PascuaM = new Alumno ("Pascua","Miranda Gaytán", 26, 7256);
            Alumno GaelH = new Alumno ("Gael","Hoyos Gaytán", 20, 6278);
            Alumno GildardoH = new Alumno ("Gildardo","Herrera Loera", 20, 7238);
            Alumno MirellaB = new Alumno ("Mirella","Baez Mendez", 20, 7255);

            artes.Semestre4Artes.Add(DionO);
            artes.Semestre4Artes.Add(PascuaM);
            artes.Semestre4Artes.Add(GaelH);
            artes.Semestre4Artes.Add(GildardoH);
            artes.Semestre4Artes.Add(MirellaB);  

            // Semestre 6

            Alumno JaimeC = new Alumno ("Jaime","Cedillo Casárez", 21, 7128);
            Alumno OttoM = new Alumno ("Otto","Meraz Chacón", 25, 7186);
            Alumno JesusM = new Alumno ("Jesús","Murillo Casas", 21, 7148);
            Alumno Alberto = new Alumno ("Quezada","Paz Cruz", 22, 7134);
            Alumno EstebanL = new Alumno ("Lara","Segoviano Rivas", 21, 7119);

            artes.Semestre6Artes.Add(JaimeC);
            artes.Semestre6Artes.Add(OttoM);
            artes.Semestre6Artes.Add(JesusM);
            artes.Semestre6Artes.Add(Alberto);
            artes.Semestre6Artes.Add(EstebanL);  

            // Semestre 8

            Alumno JosefinaH = new Alumno ("Josefina","Hurtado Linares", 23, 7035);
            Alumno DanielaC = new Alumno ("Daniela","Cruz Delatorre", 25, 7048);
            Alumno HortensiaA = new Alumno ("Hortensia","Alcantar Cardona", 22, 7081);
            Alumno PabloG = new Alumno ("Pablo","Guerrero Baca", 22, 7061);
            Alumno AlfonsinaT = new Alumno ("Alfonsifna","Torres Mondragón", 24, 7083);

            artes.Semestre8Artes.Add(JosefinaH);
            artes.Semestre8Artes.Add(DanielaC);
            artes.Semestre8Artes.Add(HortensiaA);
            artes.Semestre8Artes.Add(PabloG);
            artes.Semestre8Artes.Add(AlfonsinaT);  
            
            // Llamar el método para mostrar a todos los alumnos de Multimedia
            
            artes.BuscarTodos();

            // Llamar el método para buscar a un alumno de Multimedia

            artes.BuscarPorMatricula(7128);

            Carrera carrera = new Carrera (OpcionesCarrera.MULTIMEDIA);


        }


        
    }
}
