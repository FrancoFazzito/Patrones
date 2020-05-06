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

            
            Abstraccion abstraccion1 = new Abstraccion(new Implementecion1(), productos);
            abstraccion1.MostrarTotales();
            Console.WriteLine();

            Abstraccion abstraccion2 = new Abstraccion(new Implementecion2(), productos);
            abstraccion2.MostrarTotales();
            Console.WriteLine();

            Abstraccion abstraccion3 = new Abstraccion(new Implementecion3(), productos);
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

    class Abstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }

        public Abstraccion(int tipo, Dictionary<string, double> productos)
        {
            if (tipo == 1)
            {
                implementacion = new Implementecion1();
            }
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

    class Implementecion1 : IBridge
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

    class Implementecion2 : IBridge
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

    class Implementecion3 : IBridge
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
