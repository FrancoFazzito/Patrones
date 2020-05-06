using System;
using System.Threading;

namespace prototipo
{
    class Persona : IPrototipo 
    {
        private string nombre;

        public Persona()
        {
            
        }

        public Persona(string[] costo)
        {
            Console.WriteLine("constructor costoso");
            Thread.Sleep(1000);
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public object Clonar()
        {
            return this.MemberwiseClone();
        }
    }
}
