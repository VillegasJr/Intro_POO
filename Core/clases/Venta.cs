using Core.interfaces.Repositorios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.clases
{
    public class Venta
    {
        public string codigoVenta { get; set; }
        public List<VentaProductos> productos { get; set; } //= new List<VentaProductos>();
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }

        public void AgregraProducto(Producto producto, decimal cantidad)
        {
            // Precio por cantidad de productos
            decimal productosT = producto.Precio * cantidad;

            VentaProductos productoVenta = new VentaProductos();
            productoVenta.Producto = producto;
            productoVenta.Cantidad = cantidad;
            productoVenta.Total = productosT;

            // Agregar la venta del producto
            productos.Add(productoVenta);
            // Calcular total
            total += productosT;
        }
        // 1. CONSTRUCTOR VACÍO (Agrega esta línea para solucionar el error)
        public Venta()
        {
            productos = new List<VentaProductos>();
        }
        // Constructor de la clase Venta
        public Venta(Empleado empleadoLogueado)
        {
            codigoVenta = GenerarCodigoVenta();
            fecha = DateTime.Now;
            empleado = empleadoLogueado;
            productos = new List<VentaProductos>();
        }
        private string GenerarCodigoVenta()
        {
            // Generar un código de venta único basado en la fecha y hora actual
            RVentas rVentas = new RVentas();
            return DateTime.Now.ToString("yyyyMMdd") + rVentas.GenerarCodigo().ToString("00");
        }
    }
}
