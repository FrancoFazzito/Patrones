using System;

namespace Observador
{
    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;

        public Observador(string nombre, Sujeto sujeto)
        {
            this.nombre = nombre;
            this.sujeto = sujeto;
            sujeto.Suscribir(this);
        }

        public void Update(string mensaje) //modelo push - difunsion
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"push: {nombre}-{mensaje}");
        }

        public void UpdatePull() //
        {
            int dato = sujeto.Dato;
            if (dato > 6) //logica cuando vamos a leer o no
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"pull: {nombre}-{dato}");
            }
        }
    }
}
