using System;

namespace Visitante
{
    class Visitante : IVisitante
    {
        private int conteo;
        private int clasificacion;
        private double total;

        public int Conteo { get => conteo; set => conteo = value; }
        public int Clasificacion { get => clasificacion; set => clasificacion = value; }
        public double Total { get => total; set => total = value; }

        public void ContarElementos(Elemento elemento)
        {
            elemento.Aceptar(this);

            if (elemento.hijo != null)
            {
                ContarElementos(elemento.hijo);
            }

            if (elemento.siguiente != null)
            {
                ContarElementos(elemento.siguiente);
            }
        }

        public void Visitar(Elemento elemento)
        {
            conteo++;
            total += elemento.Costo;
        }

        public void Visitar(ElementoLeaf elemento)
        {
            clasificacion++;
            Console.WriteLine("no conteo");
        }
    }
}
