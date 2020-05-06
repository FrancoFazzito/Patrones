namespace ConsoleApp1
{
    interface IFabrica //fabrica de licuados y tenemos 2 fabricas, una natural y otra industrial
    {
        void crearProductos();
        IproductoLeche productoLeche { get; }
        IproductoSabor productoSabor { get; }

        void ofrecerLicuado();
    }
}
