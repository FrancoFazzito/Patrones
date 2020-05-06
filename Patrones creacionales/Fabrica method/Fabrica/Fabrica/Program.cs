using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class Program //se decide instanciar en base a la informacion que brinda el cliente 
    {
        static void Main(string[] args)
        {
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("ingrese dinero");
            dinero = int.Parse(Console.ReadLine());

            vehiculo = Creador.metodoFabrica(dinero);

            Console.WriteLine(vehiculo);
            vehiculo.acelerar();
            vehiculo.frenar();
            vehiculo.girar();

            Console.Read();
            
        }
    }

    class Creador
    {
        public static IVehiculo metodoFabrica(int dinero)
        {
            IVehiculo vehiculo = null;

            if (dinero < 1000)
            {
                vehiculo = new Bici();
            }
            else if(dinero < 10000)
            {
                vehiculo = new Auto();
            }
            else
            {
                vehiculo = new Avion();
            }

            return vehiculo;
        }
    }

    class Bici : IVehiculo
    {
        public void acelerar()
        {
            Console.WriteLine("pedalear mas rapido");
        }

        public void frenar()
        {
            Console.WriteLine("presionar freno");
        }

        public void girar()
        {
            Console.WriteLine("usar manubrio");
        }
    }

    class Auto : IVehiculo
    {
        public void acelerar()
        {
            Console.WriteLine("apretar acelerador");
        }

        public void frenar()
        {
            Console.WriteLine("apretar freno");
        }

        public void girar()
        {
            Console.WriteLine("girar volante");
        }
    }

    class Avion : IVehiculo
    {
        public void acelerar()
        {
            Console.WriteLine("empujar acelerador");
        }

        public void frenar()
        {
            Console.WriteLine("jalar acelerador");
        }

        public void girar()
        {
            Console.WriteLine("mover volante");
        }
    }

    interface IVehiculo //interfaz comun Iproducto
    {
        void acelerar();
        void frenar();

        void girar();
    }
}
