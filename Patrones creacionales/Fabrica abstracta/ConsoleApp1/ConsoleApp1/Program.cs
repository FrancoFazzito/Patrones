using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--fabrica quimica--");

            IFabrica fabricaQuimica = new FabricaQuimica();

            fabricaQuimica.crearProductos(); //instancio los productos

            IproductoLeche leche = fabricaQuimica.productoLeche; //obtengo leche
            IproductoSabor sabor = fabricaQuimica.productoSabor; //obtengo sabor 

            fabricaQuimica.ofrecerLicuado();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--fabrica natural--");

            IFabrica fabricaNatural = new FabricaNatural();

            fabricaNatural.crearProductos();

            fabricaNatural.ofrecerLicuado();

            Console.Read();

        }
    }
}
