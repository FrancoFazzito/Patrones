namespace Composite
{
    public class GPU<T> : ParteImplement<T>
    {
        public GPU(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public double Consumo { get; set; }
    }
}
