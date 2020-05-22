using System.Collections.Generic;

namespace Composite
{
    public interface IParte<T> //IComponent
    {
        void Add(IParte<T> element);
        IParte<T> Delete(T element);
        IParte<T> Find(T element);
        List<IParte<T>> GetElements();
        string Name { get; set; }
        int Id { get; set; }
        double Price { get; set; }
    }
}
