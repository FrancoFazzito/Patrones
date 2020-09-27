using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M1", 1000);
            productos.Add("A2", 2000);
            productos.Add("A3", 3000);
            productos.Add("A4", 1500);
            productos.Add("M5", 1800);
            productos.Add("M6", 1900);
            productos.Add("M7", 10000);

            
            Abstraccion abstraccion1 = new Abstraccion(new Implementacion1(), productos);
            abstraccion1.MostrarTotales();
            Console.WriteLine();

            Abstraccion abstraccion2 = new Abstraccion(new Implementacion2(), productos);
            abstraccion2.MostrarTotales();
            Console.WriteLine();

            Abstraccion abstraccion3 = new Abstraccion(new Implementacion3(), productos);
            abstraccion3.MostrarTotales();
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    interface IBridge //calculo de distintas formas 
    {
        void MostrarTotales(Dictionary<string, double> productos);
        void ListarProductos(Dictionary<string, double> productos);
    }

    class Abstraccion : IAbstraccion //manejador (tambien puede ser abstracta)
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }


        public void ListarProductos()
        {
            implementacion.ListarProductos(productos);
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
    }

    class Abstraccion2 : IAbstraccion //manejador (tambien puede ser abstracta)
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion2(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }


        public void ListarProductos()
        {
            implementacion.ListarProductos(productos);
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
    }

    interface IAbstraccion
    {
        void MostrarTotales();
        void ListarProductos();
    }

    //abstraccion A -> usa implementacion 1 y agrega algo

    //abstraccion B -> usa implementacion 2 y agrega algo

    class Implementacion1 : IBridge //cuerpo
    {
        public void ListarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void MostrarTotales(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item.Key + ' ' + item.Value);
            }
        }
    }

    class Implementacion2 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.WriteLine(item.Key + " IVA 21 ");
            }
        }

        public void MostrarTotales(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item.Key + ' ' + item.Value * 1.21);
            }
        }
    }

    class Implementacion3 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.WriteLine(item.Key);
            }
        }
        public void MostrarTotales(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item.Key + ' ' + item.Value * 1.13);
            }
        }
    }
}
