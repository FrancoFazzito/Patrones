namespace Composite
{
    class Fan<T> : ParteImplement<T>
    {
        public Fan(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public int TamañoFan { get; set; }
        public string Socket { get; set; }
    }
}
