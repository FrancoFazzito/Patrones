using System;

namespace Mediador
{
    class ColegaA : IColega
    {
        private Mediador mediador;
        private string nombre;

        public ColegaA(Mediador mediador, string nombre)
        {
            this.mediador = mediador;
            this.nombre = nombre;

            //nos suscribimos
            mediador.Suscribir(recibir); 
        }

        public void enviar(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"soy {nombre}, envio: {mensaje}");
            mediador.Enviar(nombre, mensaje);
        }

        public void recibir(string emisor, string mensaje) //suscribimos nuestro recibir
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"soy {nombre}, recibi {emisor}: {mensaje}");
        }
    }
}
