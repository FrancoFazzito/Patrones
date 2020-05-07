using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador
{
    class Program //define una relacion entre objetos
    {             //cuando uno cambia su estado, los estados son notificados
                  //un sujeto y varios observadores
        static void Main(string[] args)
        {
            Sujeto notificador = new Sujeto();

            Observador juan = new Observador("juan", notificador);
            Observador ana = new Observador("ana", notificador);
            Observador maria = new Observador("maria", notificador);

            for (int i = 0; i < 10; i++)
            {
                notificador.trabajo();
            }

            Console.Read();
        }
    }
}
