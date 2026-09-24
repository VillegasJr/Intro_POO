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
        // ================ Martes 22 de Sptiembre 2026 ========================
        // Cadena de conexión a la base de datos MySQL 
        string MySQlLocal = "Server=localhost;Database=poo;User=root;Password=180304;"; // Esta es la variable que hace como referencia la conexión del MySQL

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
                Console.WriteLine($"Error al registrar Empleado: {ex.Message}");
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
                Console.WriteLine($"Error al actualizar el Empleado: {ex.Message}");
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
                Console.WriteLine($"Error al eleminar el Empleado: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }
        //====================================================================================

        //=================================== Miercoles 23 de Septiembre 2026 =========================================
        public List<Empleado> Lista()
        {
            MySqlConnection conexion = new MySqlConnection(MySQlLocal);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM empleados", conexion);
            List<Empleado> lista = new List<Empleado>();

            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Ejecutamos la consulta SQL y obtenemos un lector de datos
                MySqlDataReader lector = comando.ExecuteReader();
                // Mostramos los datos de los empleados en la consola
                
                if (lector.HasRows) // 
                {
                    while (lector.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.ID = Convert.ToInt32(lector.GetInt32("ID"));
                        empleado.Nombre = Convert.ToString(lector.GetString("Nombre"));
                        empleado.Edad = Convert.ToInt32(lector.GetByte("Edad"));
                        empleado.Salario = Convert.ToDouble(lector.GetDouble("Salario"));
                        
                        lista.Add(empleado);
                    }
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al listar empleados: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
            return lista;
        }

        public List<Empleado> Busqueda(string nombre)
        {
            MySqlConnection conexion = new MySqlConnection(MySQlLocal);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Empleados WHERE Nombre LIKE @nombre", conexion);
            comando.Parameters.AddWithValue("@nombre", $"%{nombre}%");
            List<Empleado> lista = new List<Empleado>();

            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Ejecutamos la consulta SQL y obtenemos un lector de datos
                MySqlDataReader lector = comando.ExecuteReader();
                // Mostramos los datos de los empleados en la consola

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.ID = Convert.ToInt32(lector.GetInt32("ID"));
                        empleado.Nombre = Convert.ToString(lector.GetString("Nombre"));
                        empleado.Edad = Convert.ToInt32(lector.GetByte("Edad"));
                        empleado.Salario = Convert.ToDouble(lector.GetDouble("Salario"));

                        lista.Add(empleado);
                    }
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al listar empleados: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
            return lista;
        }
        //===========================================================================================================
    }
}
