using System;
using System.Collections.Generic;
using System.Text;
using Intro_POO.clases; // Importa la clase Empleado desde el espacio de nombres Intro_POO.clases

namespace Intro_POO.herencias
{
    internal class Programador: Empleado
    {
        // Constructor usando : base() para inicializar propiedades heredadas
        public Programador(string lenguaje, int antiguedad) : base()
        {
            Lenguaje = lenguaje;
            Antiguedad = antiguedad;
        }


        public string Lenguaje { get; set; }
        public int Antiguedad { get; set; }
     

        public void LenguajeDeProgramacion()
        {
            Console.WriteLine($"El programador {Nombre} está programando en {Lenguaje}.");
        }
        public void Programar()
        {
            Console.WriteLine($"El programador {Nombre} tiene una antigüedad de {Antiguedad} años y se encuentra trabajando.");
        }
    }
}
