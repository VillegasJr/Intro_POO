using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO.clases
{
    internal class Empleado
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Sueldo { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Sueldo: {Sueldo}");
        }

        public void Trabajar()
        {
            Console.WriteLine($"El empleado {Nombre} está trabajando.");
        }


    }
}
