using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO.clases
{
    internal class Empleado
    {

        public int ID { get; set; } // Agg 21/09/2026
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public int Clave { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID}"); // Agg 21/09/2026
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Salario: {Salario}");
        }

        public void Trabajar()
        {
            Console.WriteLine($"El empleado {Nombre} está trabajando.");
        }


    }
}
