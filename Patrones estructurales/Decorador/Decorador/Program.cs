using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia del objeto nucleo
            Console.WriteLine("nucleo");
            IComponente auto = new Auto(5000.00, "fitito");
            Console.WriteLine($"{ auto.Descripcion()}  { auto.Costo()}");
            Console.WriteLine();

            //instancia de la decoracion 1
            Console.WriteLine("decoracion 1");
            auto = new AutoNitrogeno(auto, 5000);
            Console.WriteLine($"{ auto.Descripcion()}  { auto.Costo()}");
            Console.WriteLine();

            //instancia de la decoracion 2
            Console.WriteLine("decoracion 2");
            auto = new AutoSistemaSonido(auto, "sonido 5.1");
            Console.WriteLine($"{ auto.Descripcion()}  { auto.Costo()}");

            //podemos decorar todos los icomponent que queremos agregar
            //no podemos acceder a los metodos especificos

            Console.ReadKey();
        }
    }

    interface IComponente //interfaz para la decoracion
    {
        double Costo();
        string Descripcion();
    }

    class Auto : IComponente //representa al componenete y es el que lleva a cabo la implementacion para la decoracion
    {
        double costo;
        string descripcion;

        public Auto(double costo, string descripcion)
        {
            this.costo = costo;
            this.descripcion = descripcion;
        }

        public double Costo()
        {
            return costo;
        }

        public string Descripcion()
        {
            return descripcion;
        }
    }

    //decoraciones
    class AutoNitrogeno : IComponente
    {
        private IComponente autoDecorado;
        private double costoNitrogeno;

        public AutoNitrogeno(IComponente autoDecorado, double costo)
        {
            this.autoDecorado = autoDecorado;
            this.costoNitrogeno = costo;
        }

        public double Costo()
        {
            return autoDecorado.Costo() + costoNitrogeno;
        }

        public string Descripcion()
        {
            return autoDecorado.Descripcion() + " " + "con nitrogeno";
        }
    }


    class AutoSistemaSonido : IComponente
    {
        private IComponente autoDecorado;
        private string descripcionSonido;

        public AutoSistemaSonido(IComponente autoDecorado, string descripcionSonido)
        {
            this.autoDecorado = autoDecorado;
            this.descripcionSonido = descripcionSonido;
        }

        public double Costo()
        {
            return autoDecorado.Costo();
        }

        public string Descripcion()
        {
            return autoDecorado.Descripcion() + " " + descripcionSonido;
        }
    }
}
