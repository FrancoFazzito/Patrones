using System;

namespace template
{
    class JugueteBarato : IPrimitiva
    {
        public void armar()
        {
            Console.WriteLine("Armando juguete barato");
        }

        public double decorar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("juguete {0}: decorado ",i);
            }

            return cantidad * 1.5;
        }

        public double empacar(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("juguete {0}: decorado ", i);
            }

            return cantidad * 1.2;
        }
    }
}
