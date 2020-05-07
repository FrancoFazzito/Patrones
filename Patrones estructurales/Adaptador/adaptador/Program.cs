using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            SumaDoubles suma = new SumaDoubles();
            string resultado = suma.SumaDouble(10.55, 50.20);
            Console.WriteLine(resultado);

            SumaAdaptada sumaAdaptada = new SumaAdaptada();
            resultado = suma.SumaDouble(100, 70.20);
            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
