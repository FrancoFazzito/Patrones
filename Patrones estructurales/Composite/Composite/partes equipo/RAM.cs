namespace Composite
{
    public class RAM<T> : ParteImplement<T>
    {
        public RAM(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public string TipoMemoriaRAM { get; set; }
        public int Capacidad { get; set; }
    }

}
