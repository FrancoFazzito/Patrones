using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Memento //se usa para salvar el estado interno de un objeto y tomarlo de manera externa
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el originador
            Originador auto = new Originador("nissan", 2010, 10000.51);
            Console.WriteLine(auto.ToString());

            //creamos el caretaker
            CareTaker careTaker = new CareTaker();

            //guardamos el estado
            careTaker.Memento = auto.CreaMemento();

            //modificamos 
            auto.Nombre = "chevrolet";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            Console.WriteLine(auto.ToString());

            auto.Restaurar(careTaker.Memento);
            Console.WriteLine(auto.ToString());

            Console.Read();
        }
    }
}
