using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            var estrategia = new Estrategia();
            var result = estrategia.Saludar("hola", Tipo.normal);
            Console.WriteLine(result);
            Console.Read();
        }
    }

    
}
