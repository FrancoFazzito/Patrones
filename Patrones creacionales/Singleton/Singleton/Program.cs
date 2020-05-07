using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--primera instancia--");
            Singleton uno = Singleton.getInstance();

            uno.AddData("datos 1");
            uno.AddData("datos 2");

            uno.Mostrar(); //va a mostrar los datos


            Console.WriteLine("--obtenemos de vuelta la instancia--");
            Singleton dos = Singleton.getInstance();

            dos.Mostrar(); //mostramos los mismos datos ya que es la misma instancia 

            Console.ReadKey();

        }
    }
}
