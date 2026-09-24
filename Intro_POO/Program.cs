using Humanizer;
using Intro_POO.clases;
using Intro_POO.herencias; // Librería para humanizar fechas y tiempos, por ejemplo, convertir un intervalo de tiempo en una frase legible para humanos.
using Intro_POO.interfaces.Repositorios;
using MySql.Data.MySqlClient;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
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
    $"tienes la edad de {personaCinco.calcularEdad(personaCinco.Fechanacimiento)} años");
*/

// ======================================================= Jueves 17 Septiembre 2026 ==========================================================================================================================================================================================
//Prubea de empleados y herencias Programador y Diseñador
/*
Console.WriteLine("--- Información del Empleado ---");
Empleado empleado = new Empleado();
empleado.Nombre = "Julian";
empleado.Edad = 30;
empleado.Sueldo = 50000;
empleado.MostrarInfo();
empleado.Trabajar();

// Prueba de la clase Programador que hereda de Empleado
Console.WriteLine("\n--- Información del Programador ---");
Programador programador = new Programador("C#", 5);
programador.Nombre = "Carlos";
programador.Edad = 28;
programador.Sueldo = 60000;
programador.MostrarInfo();
programador.LenguajeDeProgramacion();
programador.Programar();

// Prueba de la clase Diseñador que hereda de Empleado
Console.WriteLine("\n--- Información del Diseñador ---");
Diseñador diseñador = new Diseñador("Photoshop", 3);
diseñador.Nombre = "Ana";
diseñador.Edad = 26;
diseñador.Sueldo = 55000;
diseñador.MostrarInfo();
diseñador.HerramientaDeDiseño();
diseñador.Diseñar();
*/

// ===================================================== Lunes 21 Septiembre 2026 ==========================================================================================================================================================================================
/* El parámetro TreatTinyAsBoolean=false se utiliza para indicar que los valores de tipo TINYINT en la base de datos no deben ser tratados como booleanos,
sino como enteros. Esto es útil cuando se trabaja con campos que pueden tener valores distintos a 0 y 1, como por ejemplo, un campo que representa un estado o una categoría. */
REmpleado repoEmpleado = new REmpleado();
string nombreEmpleado = "";
bool esValido = false;
int opcion = 0;
string accion = "";

// Bucle para autenticar la clave del empleado
while (!esValido)
{
    Console.Write("Ingrese la clave del empleado: ");
    string claveIngresada = Console.ReadLine();

    nombreEmpleado = repoEmpleado.Verificacion(claveIngresada);

    if (nombreEmpleado != null)
    {
        Console.Clear();
        Console.WriteLine($"\nBienvenido(a): {nombreEmpleado}");
        esValido = true;

        // Bucle del menú principal corregido (continúa mientras no sea una opción válida de salida)
        bool salirMenu = false;
        while (!salirMenu)
        {
            Console.WriteLine("\n============== Menu Principal ==============");
            Console.WriteLine("1. Empleado");
            Console.WriteLine("2. Producto");
            Console.WriteLine("3. Tienda");
            Console.WriteLine("4. Salir");
            Console.Write("Ingresa el Numero: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion >= 1 && opcion <= 3)
                {
                    Console.Clear();
                    Console.WriteLine("============================================\n");
                    Console.WriteLine("=============== Acciones ===============");
                    Console.WriteLine("R. Registrar");
                    Console.WriteLine("A. Actualizar");
                    Console.WriteLine("E. Eliminar");
                    Console.WriteLine("I. Listar");
                    Console.WriteLine("B. Buscar");
                    Console.Write("Selecciona tu acción: ");

                    accion = Console.ReadLine().ToUpper();

                    Console.Clear();
                    Acciones(); // Ejecuta la acción en MySQL
                }
                else if (opcion == 4)
                {
                    salirMenu = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Clave incorrecta. Intente de nuevo.\n");
    }
}


void Acciones() {
    switch (opcion)
    {

        // Empleados
        case 1:
            REmpleado rEmpleado = new REmpleado();
            Empleado empleado = new Empleado();
            // =========================== Miercoles 23 Septiembre 2026 ==========================
            List<Empleado> empleadosList = rEmpleado.Lista();
            //=====================================================================================

            switch (accion)
            {

                // Empleados
                // Martes 22 Septiembre 2026
                // Implementacion de la base de datos MySQL para registrar, actualizar y eliminar empleados
                case "R":
                    Console.WriteLine("Ingrese el nombre del empleado:");
                    empleado.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del empleado:");
                    empleado.Edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el salario del empleado:");
                    empleado.Salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese una clave unica para el empleado:");
                    empleado.Clave = Convert.ToInt32(Console.ReadLine());


                    rEmpleado.Registro(empleado);
                    break;
                case "A":
                    //========================== Miercoles 23 Septiembre 2026 ==========================
                    Console.WriteLine("\n\n====== Lista de empleados: ======");
                    foreach (Empleado emp in empleadosList)
                    {
                        Console.WriteLine($"ID del Empleado:{emp.ID} - Nombre:{emp.Nombre} - Edad:{emp.Edad} - Salario:{emp.Salario}");
                    }
                    Console.WriteLine("====================================================\n\n");
                    //===================================================================================
                    //Selecionar ID del Empleado a Actualizar
                    Console.WriteLine("Ingrese el ID del empleado a actualizar:");
                    empleado.ID = Convert.ToInt32(Console.ReadLine());
                    /*MySqlConnection conexion = new MySqlConnection(MySQlLocalInfo);
                    MySqlCommand comando = new MySqlCommand("SELECT ID, Nombre, Edad, Salario FROM empleados WHERE ID = @ID", conexion);
                    comando.Parameters.AddWithValue("@ID", empleado.ID);*/
                    Console.WriteLine("===================================================\n");
                    // Ingresar la nueva informacion del empleado a actualizar
                    Console.WriteLine("Ingrese el nuevo nombre del empleado:");
                    empleado.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva edad del empleado:");
                    empleado.Edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo salario del empleado:");
                    empleado.Salario = Convert.ToDouble(Console.ReadLine());

                    rEmpleado.Actualizar(empleado);
                    break;
                case "E":
                    //===================== Miercoles 23 de Septiembre 2026 ====================
                    Console.WriteLine("\n\n====== Lista de empleados: ======");
                    foreach (Empleado emp in empleadosList)
                    {
                        Console.WriteLine($"ID del Empleado:{emp.ID} - Nombre:{emp.Nombre} - Edad:{emp.Edad} - Salario:{emp.Salario}");
                    }
                    Console.WriteLine("====================================================\n\n");
                    //==========================================================================
                    Console.WriteLine("Ingrese el ID del empleado a eliminar:");
                    empleado.ID = Convert.ToInt32(Console.ReadLine());

                    rEmpleado.Eliminar(empleado);
                    break;

                // =========================== Miercoles 23 Septiembre 2026 ==========================
                case "I":
                    // Mostrar la lista de empleados
                    Console.WriteLine("\n\n============= Lista de empleados ================");
                    for (int i = 0; i < empleadosList.Count; i++)
                    {
                        Empleado emp = empleadosList[i];
                        Console.WriteLine($"ID: {emp.ID} - Nombre: {emp.Nombre} - Edad: {emp.Edad} - Salario: {emp.Salario}");
                    }
                    Console.WriteLine("====================================================\n");
                    break;
                case "B":
                    // Busqueda por Nombre del empleado
                    Console.WriteLine("Ingrese el nombre del empleado a buscar:");
                    string nombreBusqueda = Console.ReadLine();
                    List<Empleado> empleadosEncontrados = rEmpleado.Busqueda(nombreBusqueda);

                    if (empleadosEncontrados.Count > 0)
                    {
                        Console.WriteLine("Empleados encontrados:");
                        foreach (Empleado emp in empleadosEncontrados)
                        {
                            Console.WriteLine($"ID: {emp.ID} - Nombre: {emp.Nombre} - Edad: {emp.Edad} - Salario: {emp.Salario}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Empleado no encontrado.");
                    }
                    break;
                //=====================================================================================
                default:
                    Console.WriteLine("Acción no válida.");
                    break;
            }
            break;

        // Productos
        case 2:
            RProductos rProductos = new RProductos();
            Producto producto = new Producto();
            List<Producto> productosList = rProductos.Lista();

            switch (accion)
            {
                case "R":
                    Console.WriteLine("Ingrese el nombre del producto:");
                    producto.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto:");
                    producto.Precio = Convert.ToDouble(Console.ReadLine());

                    rProductos.Registro(producto);
                    break;
                case "A":
                    Console.WriteLine("\n\n====== Lista de empleados: ======");
                    foreach (Producto prd in productosList)
                    {
                        Console.WriteLine($"ID del Producto:{prd.ID} - Nombre:{prd.Nombre} - Precio:{prd.Precio}");
                    }
                    Console.WriteLine("====================================================\n\n");
                    //Selecionar ID del Empleado a Actualizar
                    Console.WriteLine("Ingrese el ID del empleado a actualizar:");
                    producto.ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("===================================================\n");
                    Console.WriteLine("Ingrese el nuevo nombre del producto:");
                    producto.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio del producto:");
                    producto.Precio = Convert.ToDouble(Console.ReadLine());

                    rProductos.Actualizar(producto);
                    break;
                case "E":
                    Console.WriteLine("\n\n====== Lista de empleados: ======");
                    foreach (Producto prd in productosList)
                    {
                        Console.WriteLine($"ID del Producto:{prd.ID} - Nombre:{prd.Nombre} - Salario:{prd.Precio}");
                    }
                    Console.WriteLine("====================================================\n\n");
                    Console.WriteLine("Ingrese el ID del producto a eliminar:");
                    producto.ID = Convert.ToInt32(Console.ReadLine());

                    rProductos.Eliminar(producto);
                    break;
                case "I":
                    // Mostrar la lista de empleados
                    Console.WriteLine("\n\n============= Lista de empleados ================");
                    for (int i = 0; i < productosList.Count; i++)
                    {
                        Producto prd = productosList[i];
                        Console.WriteLine($"ID: {prd.ID} - Nombre: {prd.Nombre} - Precio: {prd.Precio}");
                    }
                    Console.WriteLine("====================================================\n");
                    break;
                case "B":
                    // Busqueda por Nombre del empleado
                    Console.WriteLine("Ingrese el nombre del empleado a buscar:");
                    string nombreBusqueda = Console.ReadLine();
                    List<Producto> productosEncontrados = rProductos.Busqueda(nombreBusqueda);

                    if (productosEncontrados.Count > 0)
                    {
                        Console.WriteLine("Productos encontrados:");
                        foreach (Producto prd in productosEncontrados)
                        {
                            Console.WriteLine($"ID: {prd.ID} - Nombre: {prd.Nombre} - Salario: {prd.Precio}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    break;
                default:
                    Console.WriteLine("Acción no válida.");
                    break;
            }
            break;

        // Tienda
        case 3:

            break;

        default:
            Console.WriteLine("Opción no válida.");

            break;
    }
}