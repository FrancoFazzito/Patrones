namespace Composite
{
    public class Fuente<T> : ParteImplement<T>
    {
        public Fuente(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public double Watts { get; set; }
        public double Watts80 => Watts * 0.80;
    }
}
