using System;



namespace Subsistemas
{
    class Fachada
    {
        private SistemaCompra compra = new SistemaCompra();
        private SistemaAlmacen almacen = new SistemaAlmacen();
        private SistemaEnvio envio = new SistemaEnvio();

        public void Comprar()
        {
            Console.WriteLine("--compra--");
            compra.comprar();
            Console.WriteLine("--almacen--");
            almacen.almacenar();
            Console.WriteLine("--envio--");
            envio.enviar();
            Console.WriteLine("--fachada--");
            Console.WriteLine("compra realizada con exito");
        }
    }
}
