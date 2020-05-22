namespace Composite
{
    class Parte<T> : ParteImplement<T>
    {
        public Parte(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }
    }
}
