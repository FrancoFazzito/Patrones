using System;
using System.Threading;

namespace prototipo
{
    class Casa : IPrototipo
    {
        private string calle;

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }


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
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"su valor es: {Calle}";
        }
    }
}
