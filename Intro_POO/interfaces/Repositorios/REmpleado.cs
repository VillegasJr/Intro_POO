using Intro_POO.clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_POO.interfaces.Repositorios
{
    // Lunes 21 de Septiembre 2026
    internal class REmpleado : IRepositorio<Empleado>
    {
        public void Registro(Empleado empleado)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Empleado registrado: {empleado.Nombre} de edad: {empleado.Edad}, con sueldo de {empleado.Sueldo}");
        }

        public void Actualizar(Empleado empleado)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Empleado actualizado: {empleado.Nombre} {empleado.Edad}, con sueldo de {empleado.Sueldo}");
        }
        public void Eliminar(Empleado empleado)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Empleado eliminado: {empleado.Nombre} {empleado.Edad}, con sueldo de {empleado.Sueldo}");
        }
    }
}
