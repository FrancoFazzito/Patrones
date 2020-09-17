using System;
using System.Threading;

namespace prototipo
{
    class Casa : IPrototipo
    {
        public string Calle { get; set; }


        public Casa()
        {

        }

        public Casa(int[] valores)
        {
            Console.WriteLine("constructor costoso");
            Thread.Sleep(1000);
        }

        public object Clonar()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"su valor es: {Calle}";
        }
    }
}
