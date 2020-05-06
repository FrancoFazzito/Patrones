using System;

namespace template
{
    class AlgoritmoArmado
    {
        public double metodoTemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;

            tipo.armar();

            total += crearJuguete(cantidad);
            total += tipo.decorar(cantidad);

            calidad();
            total += tipo.empacar(cantidad);

            Console.WriteLine("total de -> {0}",total);

            return total;
        }

        private double crearJuguete(int cantidad)
        {
            Console.WriteLine("creando {0} juguetes",cantidad);

            return 16.50 * cantidad;
        }

        private void calidad()
        {
            Console.WriteLine("pasa control de calidad");
        }
    }
}
