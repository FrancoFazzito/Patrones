using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaResponsabilidad
{
    class Program // se manejan peticiones a objetos a -> b -> c hasta que uno tenga la responsabilidad de realizar la peticion
    {
        static void Main(string[] args)
        {
            Propietario propietario = new Propietario();
            Gerente gerente = new Gerente(propietario);
            Vendedor vendedor = new Vendedor(gerente);

            int cantidad = 100;
            double precio = 100.50;

            double total = vendedor.CalculoPrecioFinal(cantidad, precio);

            Console.WriteLine("su total es {0}",total);

            Console.Read();
        }
    }

    interface IHandler
    {
        double CalculoPrecioFinal(int cantidad, double precio);
    }

    class Vendedor : IHandler
    {
        private IHandler siguiente = null; //siguiente en la cadena de responsabilidad

        public Vendedor(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }

        public double CalculoPrecioFinal(int cantidad, double precio)
        {
            Console.WriteLine("--Vendedor--");

            double total = cantidad * precio;

            if (total > 10000)
            {
                total = siguiente.CalculoPrecioFinal(cantidad, precio);
            }

            return total;
        }
    }

    class Gerente : IHandler
    {
        private IHandler siguiente = null; //siguiente en la cadena de responsabilidad

        public Gerente(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }

        public double CalculoPrecioFinal(int cantidad, double precio)
        {
            Console.WriteLine("--Gerente--");

            double total = cantidad * precio;

            if (total > 20000)
            {
                total = siguiente.CalculoPrecioFinal(cantidad, precio);
            }

            return total;
        }
    }

    class Propietario : IHandler
    {
       

        public Propietario()  //ultimo en la cadena de responsabilidad
        {
            
        }

        public double CalculoPrecioFinal(int cantidad, double precio) //ultima instancia en la cadena de responsabilidad
        {
            Console.WriteLine("--Propietario--");

            double total = cantidad * precio;

            return total;
        }
    }
}
