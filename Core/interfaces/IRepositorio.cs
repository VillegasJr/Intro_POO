using Core.clases;
using System;
using System.Collections.Generic;
using System.Text;

// Esta Interface tiene control sobre los
// metodos de las clases que la implementen,
// es decir, que las clases que implementen
// esta interfaz deben tener estos metodos,
// y si no los tienen, el compilador lanzara un error. 
namespace Core.interfaces
// Lunes 21 de Septiembre 2026
{
    // La <T> indica que es una interfaz generica, es decir, que puede recibir cualquier tipo de dato.
    // Esto se le llama polimorfismo di
    internal interface IRepositorio<T> 
    {
        // ======================== Implementadas en REmpleado y RProductos. ========================
        public void Registro(T obj); 
        public void Actualizar(T obj); 
        public void Eliminar(T obj); 
        public List<T> Lista(); 
        public List<T> Busqueda(string nombre);
        //=============================================================================================

        // ======================== Implementado en RProductos ========================
        Producto ObtenerID(int ID);
        // =============================================================================

        // ======================== Implementado en Rventa ========================
        public void RegistrarVenta(T obj);
        public int GenerarCodigo();
        public List<Venta> HistorialVenta();
        //=========================================================================


    }
    //============================ Jueves 24 de Septiembre 2026 =======================================
    // Nueva interfaz solo con la función específica
    internal interface IClaveUnica
    {
        Empleado? Verificacion(string clave);
    }
    //=================================================================================================
}
