using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program //proxy -> credenciales
    {
        //proxy se usa de intermediario entre 2 objetos

        static void Main(string[] args)
        {
            Proxy.ISujeto proxy = new Proxy.ProxySencilo();
            proxy.Peticion(5);

            Proxy.ISujeto proxySeguro = new Proxy.ProxySeguro();
            proxySeguro.Peticion(4);

            Console.Read();
        }
    }

    //uso de anidamiento
    //cualquier clase colocada como privada y anidada solo sea conocida por el proxy
    class Proxy
    {
        public interface ISujeto
        {
            void Peticion(int opcion);
        }

        public class ProxySencilo : ISujeto
        {
            public void Peticion(int opcion)
            {
                Peticion peticion = new Peticion(opcion);
                Console.WriteLine($"su opcion fue la {peticion.Opcion}");
            }
        }

        public class ProxySeguro : ISujeto
        {

            public void Peticion(int opcion)
            {
                Console.WriteLine($"dame pass para la opcion: {opcion}");
                string pass = Console.ReadLine();

                if (pass == "123456")
                {
                    Peticion peticion = new Peticion(opcion);
                    Console.WriteLine($"su opcion fue la {peticion.Opcion}");
                }
                else
                {
                    Console.WriteLine($"Denegado");
                }
            }
        }

        private class Peticion //peticion esta private al exterior y solo la conoce el proxy
        {
            private int opcion;

            public Peticion(int opcion)
            {
                this.opcion = opcion;
            }

            public int Opcion { get => opcion; set => opcion = value; }
        }
    }
}
