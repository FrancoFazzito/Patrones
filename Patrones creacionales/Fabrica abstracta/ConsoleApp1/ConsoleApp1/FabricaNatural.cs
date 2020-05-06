using System;

namespace ConsoleApp1
{
    class FabricaNatural : IFabrica
    {
        private IproductoLeche leche;
        private IproductoSabor sabor;

        public IproductoLeche productoLeche { get { return leche; } }

        public IproductoSabor productoSabor { get { return sabor; }  }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            leche = new LecheAlmendra();
            sabor = new SaborVainilla();

        }

        public void ofrecerLicuado()
        {
            leche.producir();
            sabor.informacion();
        }
    }
}
