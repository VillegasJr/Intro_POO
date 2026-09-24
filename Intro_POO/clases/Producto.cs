using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO.clases
{
    // Lunes 21 de Septiembre 2026
    internal class Producto
    {
        public int ID { get; set; } 
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
        }
    }
}
