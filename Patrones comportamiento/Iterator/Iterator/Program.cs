using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            
            ICollection<int> aggregate = new CollectionConcreta<int>(array);
            Iiterator<int> iterator = aggregate.iterator();

            aggregate.Add(8);

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
            }

            Console.Read();
        }
    }

    public interface Iiterator<T>
    {
        bool HasNext();
        T Current();
        T First();
    }

    public interface ICollection<T>
    {
        List<T> elements { get; set; }
        Iiterator<T> iterator();
        void Add(T value);
        int Count();
    }

    public class CollectionConcreta<T> : ICollection<T>
    {
        public List<T> elements { get; set; }

        public CollectionConcreta(IEnumerable<T> elements)
        {
            this.elements = elements.ToList();
        }

        public CollectionConcreta()
        {
            this.elements = new List<T>();
        }

        public Iiterator<T> iterator()
        {
            return new IteratorConcreto(this);
        }

        public void Add(T value)
        {
            elements.Add(value);
        }

        public int Count()
        {
            return elements.Count;
        }

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }


        private class IteratorConcreto : Iiterator<T>
        {
            private List<T> list;
            private int index = -1;

            public IteratorConcreto(ICollection<T> list)
            {
                this.list = list.elements;
            }

            public T Current()
            {
                return list[index];
            }

            public T First()
            {
                return list[0];
            }

            public bool HasNext()
            {
                index++;
                return index < list.Count;
            }
        }
    }

}
