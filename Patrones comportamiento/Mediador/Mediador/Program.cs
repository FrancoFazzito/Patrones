using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
    class Program //objetos se comuniquen sin conocer la identidad del otro 
    {   
        //encapsulan los protocolos del objeto
        static void Main(string[] args)
        {
            //cliente -> mediador -> todos los colegas

            Mediador mediador = new Mediador();

            ColegaA juan = new ColegaA(mediador, "juan");
            ColegaA dario = new ColegaA(mediador, "dario");

            ColegaB ana = new ColegaB(mediador, "ana");

            ana.enviar("hola a todos");

            Console.Read();
        }
    }
}
