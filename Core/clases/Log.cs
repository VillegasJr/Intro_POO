using System;
using System.Collections.Generic;
using System.Text;

namespace Core.clases
{
    public class Log
    {
        public DateTime fecha { get; set; }
        public Exception mensaje { get; set; }
        public Empleado empleado { get; set; }
        public int tipo { get; set; }
    }
}
