using System;
using System.Collections.Generic;
using System.Text;

namespace Core.clases
{
    // Lunes 21 de Septiembre 2026
    public class Producto
    {
        public int ID { get; set; } 
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio}");
        }
    }
}
