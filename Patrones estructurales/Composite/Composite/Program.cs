using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite //permite crear estructuras jerarquicas o de arbol
{
    //compuestos que componen otros componentes o compuestos
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> raiz = new Compuesto<string>("root"); //despligue de la raiz 
            IComponente<string> trabajo = raiz;

            string opcion = "";
            string dato = "";

            while (opcion != "6")
            {
                Console.WriteLine($"estoy en {trabajo.nombre}");
                Console.WriteLine("1 -> add compuesto");
                Console.WriteLine("2 -> add componente");
                Console.WriteLine("3 -> remove");
                Console.WriteLine("4 -> buscar");
                Console.WriteLine("5 -> mostrar");
                Console.WriteLine("6 -> salir");

                opcion = Console.ReadLine();
                Console.WriteLine("--------------");

                if (opcion == "1")
                {
                    Console.WriteLine("ingrese dato");
                    dato = Console.ReadLine();

                    IComponente<string> componente = new Compuesto<string>(dato);
                    trabajo.Adicionar(componente);

                }

                if (opcion == "2")
                {
                    Console.WriteLine("ingrese dato");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new Componente<string>(dato)); //agregar componente y se sigue trabajando sobre el mismo compuesto
                }

                if (opcion == "3")
                {
                    Console.WriteLine("ingrese dato");
                    dato = Console.ReadLine();

                    trabajo = trabajo.Eliminar(dato);
                }

                if (opcion == "4")
                {
                    Console.WriteLine("ingrese dato");
                    dato = Console.ReadLine();

                    trabajo = raiz.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(raiz.mostrar(0)); //mostrar todo
                }

            }
        }
    }
}
