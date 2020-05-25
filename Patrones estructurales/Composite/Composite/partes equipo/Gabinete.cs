using System.Collections.Generic;

namespace Composite
{
    public class Gabinete<T> : ParteImplement<T>
    {
        public Gabinete(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }
    }
}
