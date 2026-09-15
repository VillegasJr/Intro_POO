using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO.clases
{
    internal class Persona
    {
        // Contructor de la clase Persona, se ejecuta cuando se crea una instancia de la clase.
        //public Persona(string name, string lastname1, string lastname2, int age, DateTime birthDate)
            public Persona(string name, string lastname1, string lastname2, DateTime birthDate)
        {
            Nombre = name; // Asigna el valor del parámetro name al atributo Nombre de la clase Persona.
            ApellidoP = lastname1; // Asigna el valor del parámetro lastname1 al atributo ApellidoP de la clase Persona.
            ApellidoM = lastname2; // Asigna el valor del parámetro lastname2 al atributo ApellidoM de la clase Persona.
            // Edad = age; // Asigna el valor del parámetro age al atributo Edad de la clase Persona.
            Fechanacimiento = birthDate; // Asigna el valor del parámetro birthDate al atributo Fechanacimiento de la clase Persona.
        }


        // Las Propiedades get y set permiten acceder y modificar los valores de los atributos de la clase desde fuera de la clase.
        // Si solo tiene get y no tiene set, la propiedad será de solo lectura y no se podrá modificar desde fuera de la clase.
        // Si Solo tiene set y no tiene get, la propiedad será de solo escritura y no se podrá leer desde fuera de la clase.
        // Si un atributo es privado, no se podrá acceder a él desde fuera de la clase, pero si tiene una propiedad pública con get y set, se podrá acceder y modificar el valor del atributo desde fuera de la clase.
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Edad { get; set; }
        public DateTime Fechanacimiento { get; set; }
    }
}
