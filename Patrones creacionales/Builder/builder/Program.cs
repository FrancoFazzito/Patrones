using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Program //separacion de especificacion de un objeto complejo (como debe construir) de su construccion
    {
        static void Main(string[] args) //misma especificacion pero distintas formas de representar
        {
            //construccion de productos en partes encargada por el constructor y orquestada por el director 
            //automovil -> motor - carroceria - llantas

            //instaciamos un director para poder llamar al constructor
            Director director = new Director();

            //construimos un auto con el builder
            BuilderBasico basico = new BuilderBasico();
            director.Construye(basico);

            //obtenemos el auto construido
            Auto auto = basico.GetAuto();

            auto.MostrarAuto();
            Console.Read();
        }
    }
}
