using System;

namespace Flyweight
{
    class Receta : IFlyweight
    {
        private string nombre;
        private double costo;
        private double venta;

        public void ColocaNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public void CalculaCosto()
        {
            foreach (char letra in nombre)
            {
                costo += letra;
            }

            venta = costo * 1.3;
        }


        public void Mostrar()
        {
            Console.WriteLine($"{nombre} con venta en {venta}");
        }


    }
}
