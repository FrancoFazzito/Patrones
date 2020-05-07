using System;

namespace Visitante
{
    public class Elemento : Ielemento
    {
        public Elemento siguiente; //hermano
        public Elemento hijo; //hijo

        private string nombre;
        private double costo;

        public Elemento()
        {

        }

        public Elemento(string nombre, double costo, Elemento siguiente)
        {
            this.siguiente = siguiente;
            this.nombre = nombre;
            this.costo = costo;
            Console.WriteLine($"elemento creado con {nombre} costo {costo} y hermano {siguiente.Nombre}");
        }

        public virtual void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this); //visitante pueda entrar a visitarnos
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
