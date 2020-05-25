using System;
using System.Collections.Generic;

namespace Composite
{
    public abstract class ParteImplement<T> : IParte<T>, IPerfomance //Leaf
    {
        protected ParteImplement(string name, int id, double price, int level)
        {
            Name = name;
            Id = id;
            Price = price;
            PerfomanceLevel = level;
        }

        public void Add(IParte<T> element) => throw new ExceptionInvalidEdit();

        public IParte<T> Delete(T element) => throw new ExceptionInvalidEdit();

        public IParte<T> Find(T element) => Equals(element) ? (this) : null;

        public List<IParte<T>> GetElements() => new List<IParte<T>>() { this };

        public override string ToString() => $"ID: {Id}  {Name}  ${Price}";

        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public int PerfomanceLevel { get; set; }

        class ExceptionInvalidEdit : Exception
        {
            public override string Message => "no se puede cambiar elementos de esta parte del equipo";
        }
    }

}
