using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera caldera = new Caldera();

            caldera.trabajar();
            caldera.cortarFuego();
            caldera.ponerCombustible();
            caldera.forzarFuego(); 

            Console.WriteLine(caldera.ToString());

            Console.Read();
        }
    }
}
