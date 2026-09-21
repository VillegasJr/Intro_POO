using Humanizer; // Librería para humanizar fechas y tiempos, por ejemplo, convertir un intervalo de tiempo en una frase legible para humanos.

//============================================== Martes 14 Septiembre 2026 ============================================================================================================================================
/*
Persona persona = new Persona(); // Create an instance of the Persona class
persona.Nombre = "Raul"; // Set the Nombre property"
persona.ApellidoP = "Gonzalez"; // Set the ApellidoP property
persona.ApellidoM = "Lopez"; // Set the ApellidoM property
persona.Edad = 30; // Set the Edad property

// Este es un ejemplo de referencia, ya que personaDos apunta a la misma dirección de memoria que persona (Pointer).
Persona personaDos = persona; // Assign the reference of persona to personaDos
persona.Nombre = "Julia"; // Set the Nombre property"
persona.ApellidoP = "Garcia"; // Set the ApellidoP property
persona.ApellidoM = "Orlando"; // Set the ApellidoM property
persona.Edad = 26; // Set the Edad property

// De esta manera, personaDos también refleja los cambios realizados en persona,
// ya que ambos apuntan a la misma instancia de la clase Persona.
Persona persona2 = new Persona();
persona2.Nombre = "Gerath"; // Set the Nombre property"
persona2.ApellidoP = "Hernandez"; // Set the ApellidoP property
persona2.ApellidoM = "Tellez"; // Set the ApellidoM property
persona2.Edad = 15; // Set the Edad property

// El $ es un operador de interpolación de cadenas que permite insertar expresiones dentro de una cadena de
// texto, facilitando la construcción de mensajes dinámicos.
Console.WriteLine($"Hola {persona.Nombre} {persona.ApellidoP} {persona.ApellidoM}" + 
    $"tines la edad de {persona.Edad}");
Console.WriteLine($"Hola {personaDos.Nombre} {personaDos.ApellidoP} {personaDos.ApellidoM}" +
    $"tines la edad de {personaDos.Edad}");
Console.WriteLine($"Hola {persona2.Nombre} {persona2.ApellidoP} {persona2.ApellidoM}" +
    $"tines la edad de {persona2.Edad}");
*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------

/*
Persona personaTres = new Persona("Wendy", "Esquivel", "Calvario", 22); // Aqui se asignan los valores tal cual como los parametros del constructor de la clase Persona, en el orden que se definieron en el constructor.
Persona persona3 = new Persona(lastname1: "Esquivel", lastname2: "Calvario", name: "Wendy", age: 22); // Aqui se asignan los valores de los parametros del constructor de la clase Persona, pero se especifica el nombre del parametro al que se le asigna el valor, por lo que no importa el orden en el que se definieron los parametros en el constructor.
*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------
/*
DateTime nacimiento = Convert.ToDateTime("25/09/1995"); // Se crea una variable de tipo DateTime y se le asigna un valor de fecha, en este caso, la fecha de nacimiento de la persona.
DateTime hoy = DateTime.Today;

// Calcula la edad en años
int edad = (hoy - nacimiento).Days / 365;

// También puedes humanizar intervalos
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Tiempo transcurrido: {(hoy - nacimiento).Humanize()}");

Persona personaCuatro = new Persona("Wendy", "Esquivel", "Calvario", nacimiento); // Aqui se asignan los valores tal cual como los parametros del constructor de la clase Persona, en el orden que se definieron en el constructor.
Console.WriteLine($"Hola {personaCuatro.Nombre} {personaCuatro.ApellidoP} {personaCuatro.ApellidoM}" +
    $"tienes la edad de {edad}");

Persona personaCinco = new Persona("Wendy", "Esquivel", "Calvario", new DateTime(2004, 5, 12)); // Aqui se asignan los valores tal cual como los parametros del constructor de la clase Persona, en el orden que se definieron en el constructor.
Console.WriteLine($"Hola {personaCinco.Nombre} {personaCinco.ApellidoP} {personaCinco.ApellidoM}" +
    $"tienes la edad de {personaCinco.calcularEdad(personaCinco.Fechanacimiento)}");