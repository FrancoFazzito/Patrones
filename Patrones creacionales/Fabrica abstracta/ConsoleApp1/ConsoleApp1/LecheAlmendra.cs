using System;

namespace ConsoleApp1
{
    class LecheAlmendra : IproductoLeche
    {
        public void producir()
        {
            Console.WriteLine("procesar almendras");
        }
    } //productos concretos
}
