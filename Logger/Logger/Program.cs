using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("hola", "empleado",LogType.INFO);
            Logger.Log("hola", "gerente",LogType.WARN);
            Logger.Log("hola", "error producto",LogType.ERROR);

            Console.Read();
        }

        public static class Logger
        {
            public static void Log(string mensaje,string descripcion,LogType type)
            {
                string cadena = $"{type}  -  {DateTime.Now}  - {descripcion} - {mensaje}";

                Message msg = new Message(type, mensaje, descripcion, DateTime.Now);

                //guardar en BD

                Console.WriteLine(cadena);
            }


            private class Message
            {
                private LogType logType;
                private string texto;
                private string descripcion;
                private DateTime date;

                public Message(LogType logType, string texto, string descripcion, DateTime date)
                {
                    this.logType = logType;
                    this.texto = texto;
                    this.descripcion = descripcion;
                    this.date = date;
                }
            }

        }
    }
}
