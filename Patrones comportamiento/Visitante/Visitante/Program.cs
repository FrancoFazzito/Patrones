using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitante
{
    class Program //define y lleva nuevas operaciones sobre una estructura sin cambiar sus clases
    {             //vamos visitar los obejtos de esa estructura sin alterar sus clases
        static void Main(string[] args)
        {
            double totalCosto = 0;
            int totalObjetos = 0;
            int totalClasifacion = 0;

            Elemento estructuraObjeto =
                 new Elemento("botiquin", 30,
                 new Elemento("termomento",50,
                    new ElementoLeaf(
                        new Elemento("antibiotico", 40, new Elemento()),
                        new Elemento("antiacido",40,new Elemento()
                 ))));

            //visitante que visite todos los objetos
            Visitante visitante = new Visitante();
            visitante.ContarElementos(estructuraObjeto);

            totalCosto = visitante.Total;
            totalClasifacion = visitante.Clasificacion;
            totalObjetos = visitante.Conteo;

            System.Console.WriteLine($"se tiene {totalCosto} con clasificacion {totalClasifacion} y un total de {totalObjetos}");

            Console.Read();
        }
    }
}
