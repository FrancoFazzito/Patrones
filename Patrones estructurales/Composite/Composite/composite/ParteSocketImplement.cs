using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    abstract class ParteSocketImplement<T> : IParte<T>, IPerfomance //Composite
    {
        private List<IParte<T>> elementos;
        private List<IParte<T>> details;

        protected ParteSocketImplement(string name, int id, double price, int level)
        {
            Name = name;
            Id = id;
            Price = price;
            PerfomanceLevel = level;
            elementos = new List<IParte<T>>();
        }

        public void Add(IParte<T> element) => elementos.Add(element);

        public IParte<T> Find(T element)
        {
            if (Equals(element))
            {
                return this;
            }

            IParte<T> encontrado = null;

            foreach (IParte<T> elementoItem in elementos)
            {
                encontrado = elementoItem.Find(element);
                if (encontrado != null)
                {
                    break;
                }
            }

            return encontrado;
        }

        public IParte<T> Delete(T elemento)
        {
            IParte<T> elementoBuscado = Find(elemento);

            if (elementoBuscado != null)
            {
                elementos.Remove(elementoBuscado);
            }

            return this;
        }

        public List<IParte<T>> GetElements()
        {
            details = new List<IParte<T>>();
            details.AddRange(details);

            details.Add(this);

            foreach (var elemento in elementos)
            {
                details.AddRange(elemento.GetElements());
            }

            return details;
        }

        public double GetTotalPrice() => GetElements().Sum(p => p.Price);

        public override string ToString() => $"ID: {Id} {Name} ${Price}";

        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public int PerfomanceLevel { get; set; }
    }
}
