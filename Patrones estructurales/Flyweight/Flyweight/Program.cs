using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args) //pasar los atributos compartidos primero y despues los concretos
        {
            List<int> americana = new List<int>(); //guarda los index de los flyweights dentro la lista de factory
            List<int> mexicana = new List<int>();
            List<int> italiana = new List<int>();
            List<int> argentina = new List<int>();

            FlyweightFactory factory = new FlyweightFactory();

            int index = factory.adicionar("asado");
            americana.Add(index);
            mexicana.Add(index);
            italiana.Add(index);

            index = factory.adicionar("tacos");
            mexicana.Add(index);

            index = factory.adicionar("frutas");
            mexicana.Add(index);

            foreach (int indexComida in mexicana)
            {
                //calcular costo hace el estado extrinsico
                //nombre es el estado intrinsico, es decir el valor compartido

                IFlyweight receta = factory[indexComida];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.ReadLine();
        }
    }
}
