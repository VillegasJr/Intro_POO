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
    internal interface IRepositorio<T>
    {
        public void Registro(T obj);
        public void Actualizar(T obj);
        public void Eliminar(T obj);
    }
}
