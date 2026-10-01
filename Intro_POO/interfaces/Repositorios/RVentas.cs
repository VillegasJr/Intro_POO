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
        string MySqlConexion = "Server=localhost;Database=poo;User=root;Password=180304;";
        public void RegistrarVenta(Venta venta)
        {
            MySqlConnection conexion = new MySqlConnection(MySqlConexion);

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
