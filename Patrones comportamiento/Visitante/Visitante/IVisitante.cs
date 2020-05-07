namespace Visitante
{
    public interface IVisitante
    {
        void Visitar(Elemento elemento);
        void Visitar(ElementoLeaf elemento);
    }
}
