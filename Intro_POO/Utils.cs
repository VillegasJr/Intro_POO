using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO
{
    internal static class Utils
    {
        // Implementación de la cadena de conexión a la base de datos MySQL
        // De esta forma podemos cambiar la cadena de conexión en un solo lugar y no tener que modificarla en cada clase que la use
        // esta declarado como static para que no se pueda instanciar la clase Utils y solo se pueda acceder a la propiedad MySqlConexion de forma estática
        public static string MySqlConexion = "Server=localhost;Database=poo;User=root;Password=180304;";
    }
}
