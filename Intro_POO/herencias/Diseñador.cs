using System;
using System.Collections.Generic;
using System.Text;
using Intro_POO.clases; // Importa la clase Empleado desde el espacio de nombres Intro_POO.clases

namespace Intro_POO.herencias
{
    internal class Diseñador: Empleado
    {
        public Diseñador(string herramienta, int antiguedad) : base()
        {
            Herramienta = herramienta;
            Antiguedad = antiguedad;
        }

        public string Herramienta { get; set; }
        public int Antiguedad { get; set; }

        public void HerramientaDeDiseño()
        {
            Console.WriteLine($"El diseñador {Nombre} está diseñando con {Herramienta}.");
        }
        public void Diseñar()
        {
            Console.WriteLine($"El diseñador {Nombre} tiene una antigüedad de {Antiguedad} años y se encuentra trabajando.");
        }
    }
}
