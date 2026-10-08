using System;
using System.Collections.Generic;
using System.Text;

namespace Core.clases
{
    public class Response<Object>
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public Object Datos { get; set; }
    }
}
