using Intro_POO.clases;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Intro_POO.interfaces.Repositorios
{
    internal class RVentas : IRepositorio<Venta>
    {
        public void RegistrarVenta(Venta venta)
        {
            MySqlConnection conexion = new MySqlConnection(Utils.MySqlConexion);

            try
            {
                conexion.Open();

                MySqlTransaction transaction = conexion.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("INSERT INTO ventas (IDventa, IDempleado, Fecha, Total) " +
                "VALUES (@IDventa, @IDempleado, @Fecha, @Total)", conexion, transaction);

                comando.Parameters.AddWithValue("@IDventa", venta.codigoVenta);
                comando.Parameters.AddWithValue("@IDempleado", venta.empleado != null ? venta.empleado.ID : (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Fecha", venta.fecha);
                comando.Parameters.AddWithValue("@Total", venta.total);
                comando.ExecuteNonQuery();


                foreach (VentaProductos prod in venta.productos)
                {
                    MySqlCommand comandoDetalles = new MySqlCommand("INSERT INTO ventaproductos (IDventa, IDproductos, Cantidad, Total) " +
                    "VALUES (@IDventa, @IDproductos, @Cantidad, @Total)", conexion, transaction);
                    comandoDetalles.Parameters.AddWithValue("@IDventa", venta.codigoVenta);
                    comandoDetalles.Parameters.AddWithValue("@IDproductos", prod.Producto.ID);
                    comandoDetalles.Parameters.AddWithValue("@Cantidad", prod.Cantidad);
                    comandoDetalles.Parameters.AddWithValue("@Total", prod.Total);
                    comandoDetalles.ExecuteNonQuery();
                }

                transaction.Commit();
                Console.WriteLine("Venta Guardada - ID: " + venta.codigoVenta);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al registrar la venta " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public int GenerarCodigo()
        {
            MySqlConnection conexion = new MySqlConnection(Utils.MySqlConexion);
            MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) + 1 as next FROM ventas WHERE DATE(Fecha) = CURDATE()", conexion);
            int cantidad = 1;

            try
            {
                conexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        cantidad = Convert.ToInt32(leer["next"].ToString());
                    }
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar el código de venta: {ex.Message}");
            }
            finally
            {
                conexion.Close();
                // Aquí podrías agregar cualquier limpieza necesaria, aunque en este caso no hay recursos que liberar.
            }
            return cantidad;
        }

        public List<Venta> HistorialVenta()
        {
            MySqlConnection conexion = new MySqlConnection(Utils.MySqlConexion);
            MySqlCommand comando = new MySqlCommand(
                "SELECT v.IDventa, v.Fecha, v.Total, e.Nombre " +
                "FROM ventas v " +
                "LEFT JOIN empleados e ON v.IDempleado = e.IDempleado " +
                "ORDER BY v.Fecha DESC", conexion);

            List<Venta> historial = new List<Venta>();

            try
            {
                conexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Venta venta = new Venta
                    {
                        codigoVenta = leer["IDventa"].ToString(),
                        fecha = Convert.ToDateTime(leer["Fecha"]),
                        total = Convert.ToDecimal(leer["Total"]),
                        empleado = new Empleado { nombre = leer["Nombre"] != DBNull.Value ? leer["Nombre"].ToString() : "N/A" }
                    };
                    historial.Add(venta);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el historial de ventas: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return historial;
        }
        public List<VentaProductos> ObtenerDetallesVenta(string idVenta)
        {
            MySqlConnection conexion = new MySqlConnection(Utils.MySqlConexion);
            MySqlCommand comando = new MySqlCommand(
                "SELECT vp.Cantidad, vp.Total, p.Nombre, p.Precio " +
                "FROM ventaproductos vp " +
                "JOIN productos p ON vp.IDproductos = p.IDproductos " +
                "WHERE vp.IDventa = @IDventa", conexion);

            comando.Parameters.AddWithValue("@IDventa", idVenta);
            List<VentaProductos> detalles = new List<VentaProductos>();

            try
            {
                conexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    VentaProductos vp = new VentaProductos
                    {
                        Cantidad = Convert.ToDecimal(leer["Cantidad"]),
                        Total = Convert.ToDecimal(leer["Total"]),
                        Producto = new Producto
                        {
                            Nombre = leer["Nombre"].ToString(),
                            Precio = Convert.ToDecimal(leer["Precio"])
                        }
                    };
                    detalles.Add(vp);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar detalles: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
            return detalles;
        }

        // ============ ESTOS MODELOS NO SE USAN AQUI =============
        public void Actualizar(Venta obj)
        {
            throw new NotImplementedException();
        }
        public List<Venta> Busqueda(string nombre)
        {
            throw new NotImplementedException();
        }
        public void Eliminar(Venta obj)
        {
            throw new NotImplementedException();
        }
        public List<Venta> Lista()
        {
            throw new NotImplementedException();
        }
        public Producto ObtenerID(int ID)
        {
            throw new NotImplementedException();
        }
        public void Registro(Venta obj)
        {
            throw new NotImplementedException();
        }
        //========================================================
    }
}
