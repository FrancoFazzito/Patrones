using System;

namespace Mediador
{
    class ColegaB : IColega
    {
        private Mediador mediador;
        private string nombre;
        private int conteo;

        public ColegaB(Mediador mediador, string nombre)
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
            conteo++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"soy {nombre}, recibi {emisor}: {mensaje} [{conteo}]");
        }
    }
}
