using Intro_POO.clases;
using System;
using System.Collections.Generic;
using System.Text;
// Martes 22 de Septiembre 2026
using MySql.Data; // Agregar la referencia a MySql.Data
using MySql.Data.MySqlClient; // Agregar la referencia a MySql.Data.MySqlClient

namespace Intro_POO.interfaces.Repositorios
{
    // Lunes 21 de Septiembre 2026
    internal class REmpleado : IRepositorio<Empleado>
    {
        // Cadena de conexión a la base de datos MySQL 
        string MySQlLocal = "Server=localhost;Database=poo;User=root;Password=180304;";

        public void Registro(Empleado empleado)
        {
            MySqlConnection conexion = new MySqlConnection(MySQlLocal);
            MySqlCommand comando = new MySqlCommand("INSERT INTO empleados (Nombre, Edad, Salario) VALUES (@Nombre, @Edad, @Salario)", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Salario", empleado.Salario);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Empleado registrado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al registrar empleado: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }


        public void Actualizar(Empleado empleado)
        {
            MySqlConnection conexion = new MySqlConnection(MySQlLocal);
            MySqlCommand comando = new MySqlCommand("UPDATE empleados SET Nombre = @Nombre, Edad = @Edad, " +
                "Salario = @Salario WHERE ID = @ID", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@ID", empleado.ID);
            comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Salario", empleado.Salario);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Empleado actualizado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al registrar empleado: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }


        public void Eliminar(Empleado empleado)
        {
            MySqlConnection conexion = new MySqlConnection(MySQlLocal);
            MySqlCommand comando = new MySqlCommand("DELETE FROM empleados WHERE ID = @ID", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@ID", empleado.ID);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Empleado eliminado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al registrar empleado: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }
        
    }
}
