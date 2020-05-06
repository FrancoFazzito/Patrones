using System;

namespace Comando
{
    class Auto
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("se ha prendido el auto");
        }

        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("se ha apagado el auto");
        }

        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("se ha colocado la alarma");
        }

        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("se ha quitado la alarma");
        }
    }
}
