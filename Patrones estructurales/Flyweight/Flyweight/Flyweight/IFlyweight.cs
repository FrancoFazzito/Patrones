namespace Flyweight
{
    interface IFlyweight
    {
        void ColocaNombre(string nombre);
        string ObtenerNombre();
        void CalculaCosto();
        void Mostrar();
    }
}
