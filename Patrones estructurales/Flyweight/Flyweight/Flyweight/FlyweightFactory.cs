using System;
using System.Collections.Generic;

namespace Flyweight
{
    class FlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int count = 0;

        public int adicionar(string nombre)
        {
            bool existe = flyweights.Exists(f => f.ObtenerNombre() == nombre);

            if (existe)
            {
                Console.WriteLine("ya existe");
                return -1;
            }
            else
            {
                Receta receta = new Receta();
                receta.ColocaNombre(nombre);

                flyweights.Add(receta);
                count = flyweights.Count;
                return count - 1;
            }
        }

        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }

        public int Count { get => count; set => count = value; }
    }
}
