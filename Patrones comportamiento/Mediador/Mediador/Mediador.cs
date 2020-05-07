using System;

namespace Mediador
{
    class Mediador
    {
        //creamos un delegado para invocar los metodos
        public delegate void Envio(string emisor, string mensaje); //podamos invocar el metodo de los colegas ( recibir )
        Envio envioMensaje;
       
        public void Suscribir(Envio envio)  //adicion del metodo a invocar
        {

            envioMensaje += envio;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-- suscrito --");
        }
       
        public void Bloque(Envio envio)  //quitamos el metodo del delegado
        {
            envioMensaje -= envio;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- bloqueo de mensaje --");
        }

        public void Enviar(string emisor, string mensaje)
        {
            Console.WriteLine("se paso por mediador");

            this.envioMensaje(emisor, mensaje); //todos los metodos referenciados al delegado se van a invocar
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- mensajes enviados ---");
        }


    }
}
