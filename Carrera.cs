using System;
using System.Collections.Generic;


namespace PR2_Alumnos
{
        enum OpcionesCarrera
    {
        MULTIMEDIA,
        ARTES
        
    }


    class Carrera
    {
        public OpcionesCarrera opcionesCarrera;

        public string nombreCarrera;
        public Carrera(OpcionesCarrera opcionesCarrera)
        {

            this.opcionesCarrera = opcionesCarrera;
            
            if (opcionesCarrera == OpcionesCarrera.MULTIMEDIA)
            {
                nombreCarrera = "Ingeniería en Multimedia";
            }
            else nombreCarrera = "Licenciatura en Artes Visuales";

            
        }
        
        public void mostrarCarrera()
        {

            Console.WriteLine(nombreCarrera);

        }
              
    }
}
