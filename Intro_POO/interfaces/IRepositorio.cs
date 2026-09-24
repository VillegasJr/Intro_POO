using Intro_POO.clases;
using System;
using System.Collections.Generic;
using System.Text;

// Esta Interface tiene control sobre los
// metodos de las clases que la implementen,
// es decir, que las clases que implementen
// esta interfaz deben tener estos metodos,
// y si no los tienen, el compilador lanzara un error. 
namespace Intro_POO.interfaces
// Lunes 21 de Septiembre 2026
{
    // La <T> indica que es una interfaz generica, es decir, que puede recibir cualquier tipo de dato.
    // Esto se le llama polimorfismo di
    internal interface IRepositorio<T> 
    {
        public void Registro(T obj); // Declaramos el metodo Registro, que recibe un objeto de tipo T.
        public void Actualizar(T obj); // Declaramos el metodo Actualizar, que recibe un objeto de tipo T.
        public void Eliminar(T obj); // Declaramos el metodo Eliminar, que recibe un objeto de tipo T.


        //============================== Miercoles 23 de Septiembre 2026 ===================================
        public List<T> Lista(); 
        
        public List<T> Busqueda(string nombre); // Declaramos el metodo Busqueda, que recibe un string y retorna una lista de objetos de tipo T.
                                                //=================================================================================================


        //============================ Jueves 24 de Septiembre 2026 =======================================
        // Nueva interfaz solo con la función específica
        internal interface IClaveUnica
        {
            bool Verificacion(Empleado empleado);
        }
        //=================================================================================================
    }
}
