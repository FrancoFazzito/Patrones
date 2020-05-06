using Subsistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fachada
{
    //manejo de muchos subsistemas
    class Program //actuar entre cliente y los subsistemas para simplificar la interfaz
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            fachada.Comprar();
            Console.ReadLine();
        }
    }

}




