using System;
using System.Collections.Generic;
using System.Text;
using Core.clases;

namespace Core.interfaces.Repositorios
{
    public class RLogs
    {
        public void GuardarLog(Log log)
        {
            // Aquí iría la lógica para guardar el log en la base de datos o en un archivo
            // Por ejemplo, podrías usar Entity Framework para guardar en una tabla de logs
            // o escribir en un archivo de texto.

            File.AppendAllText($"{log.fecha.ToString("yyyy-MM-dd")}.txt",
                $"{log.fecha.ToString("HH:mm:ss")}\t|" +
                $"\t{log.mensaje.Message}\t" + 
                $"\t{log.mensaje.StackTrace}\t" +
                $"\t{log.empleado.ID.ToString()}" +
                Environment.NewLine);
        }
    }
}
