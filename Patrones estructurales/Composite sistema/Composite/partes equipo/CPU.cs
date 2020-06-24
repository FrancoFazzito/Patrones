namespace Composite
{
    public class CPU<T> : ParteSocketImplement<T>
    {
        public CPU(string name, int id, double price, int level) : base(name, id, price, level)
        {

        }

        public string Socket { get; set; }
        public double Consumo { get; set; }
        public bool HasIntegrada { get; set; }
    }
}
