namespace Visitante
{
    public class ElementoLeaf : Elemento
    {
        public ElementoLeaf(Elemento siguiente, Elemento hijo) 
        {
            this.siguiente = siguiente;
            this.hijo = hijo;
        }

        public override void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}
