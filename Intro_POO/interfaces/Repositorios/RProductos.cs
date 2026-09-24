using Google.Protobuf.Collections;
using Intro_POO.clases;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Intro_POO.interfaces.Repositorios
{
    // Lunes 21 de Septiembre 2026
    internal class RProductos : IRepositorio<Producto>
    {
        string MySqlConexion = "Server=localhost;Database=poo;User=root;Password=180304;";
        public void Registro(Producto producto)
        {
            // Realizar conexion de la base de datos
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);
            MySqlCommand comando = new MySqlCommand("INSERT INTO productos (Nombre, Precio) VALUES (@Nombre, @Precio)", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Producto registrado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al registrar el Producto: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }

        public void Actualizar(Producto producto)
        {
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);
            MySqlCommand comando = new MySqlCommand("UPDATE productos SET Nombre = @Nombre, Precio = @Precio WHERE ID = @ID", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@ID", producto.ID);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Producto actualizado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al actualizar el Producto: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }

        // Implementación del método Eliminar de la interfaz IRepositorio
        public void Eliminar(Producto producto)
        {
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);
            MySqlCommand comando = new MySqlCommand("DELETE FROM productos WHERE ID = @ID", conexion); // Polimorfismo tipo de sobrecarga de métodos
            comando.Parameters.AddWithValue("@ID", producto.ID);
            try
            {
                // Abrimos la conexión a la base de datos
                conexion.Open();
                // Agregamos los parámetros a la consulta SQL
                comando.ExecuteNonQuery();
                // Mostramos un mensaje de éxito al registrar el empleado
                Console.WriteLine("Producto eliminado");
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al eleminar el Producto: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
        }

        //============================= Miercoles 23 de Septiembre 2026 ==============================
        public List<Producto> Lista()
        {
            List<Producto> productosLista = new List<Producto>();
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM productos", conexion);

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
                        Producto producto = new Producto();
                        producto.ID = Convert.ToInt32(lector.GetInt32("ID"));
                        producto.Nombre = Convert.ToString(lector.GetString("Nombre"));
                        producto.Precio = Convert.ToDouble(lector.GetDouble("Precio"));

                        productosLista.Add(producto);
                    }
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al listar los Productos: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
            return productosLista;
        }

        public List<Producto> Busqueda(string nombre)
        {
            List<Producto> productosBusqueda = new List<Producto>();
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);
            MySqlCommand comando = new MySqlCommand("SELECT * FROM productos WHERE Nombre LIKE @nombre", conexion);
            comando.Parameters.AddWithValue("@nombre", $"%{nombre}%");

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
                        Producto producto = new Producto();
                        producto.ID = Convert.ToInt32(lector.GetInt32("ID"));
                        producto.Nombre = Convert.ToString(lector.GetString("Nombre"));
                        producto.Precio = Convert.ToDouble(lector.GetDouble("Precio"));

                        productosBusqueda.Add(producto);
                    }
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores al abrir la conexión y mostramos un mensaje de error
                Console.WriteLine($"Error al buscar los Productos: {ex.Message}");
            }
            finally
            {
                // Cerramos la conexión a la base de datos
                conexion.Close();
            }
            return productosBusqueda;
        }
        //===========================================================================================
    }
}
