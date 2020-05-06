using System;

namespace ConsoleApp1
{
    class FabricaQuimica : IFabrica
    {
        private IproductoLeche leche;
        private IproductoSabor sabor;

        public IproductoLeche productoLeche { get { return leche; } }

        public IproductoSabor productoSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            leche = new LecheVaca();
            sabor = new SaborChocolate();

        }

        public void ofrecerLicuado()
        {
            leche.producir();
            sabor.informacion();
        }
    }
}
