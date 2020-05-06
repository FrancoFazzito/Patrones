using System;

namespace template
{
    class JugueteNormal : IPrimitiva
    {
        public void armar()
        {
            Console.WriteLine("Armando juguete normal");
        }

        public double decorar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("juguete {0}: decorado ", cantidad);
            }

            return cantidad * 3;
        }

        public double empacar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("juguete {0}: decorado ", cantidad);
            }

            return cantidad * 2;
        }
    }
}
