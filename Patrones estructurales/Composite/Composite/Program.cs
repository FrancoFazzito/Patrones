using System;
using System.Runtime.Remoting.Lifetime;

namespace Composite //permite crear estructuras jerarquicas o de arbol
{
    //compuestos que componen otros componentes o compuestos
    partial class Program
    {
        static void Main(string[] args)
        {
            ArmadoEquipo armadoEquipo = new ArmadoEquipo(UseType.oficina,19000);
            foreach (var item in armadoEquipo.GetEquipo())
            {
                Console.WriteLine();
                foreach (var element in item.GetElements())
                {
                    Console.WriteLine(element);
                    
                }
                Console.WriteLine($"{item.GetTotalPrice()}");
            }

            Console.ReadKey();
        }
    }
}
