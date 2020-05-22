namespace Composite
{
    class Disco<T> : ParteImplement<T>
    {
        public Disco(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public int Capacidad { get; set; }
        public string Tipo { get; set; }
    }
}
