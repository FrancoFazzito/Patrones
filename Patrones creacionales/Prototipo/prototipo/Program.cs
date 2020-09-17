using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo
{
    class Program //crea nuevos objetos al clonar prototipos ya existentes
    {
        static void Main(string[] args) //usado cuando cuesta muchos recursos instanciar por constructor
        {
            AdminPrototipo admin = new AdminPrototipo();

            Persona uno = admin["persona"] as Persona;
            Persona dos = admin["persona"] as Persona;

            Console.WriteLine(uno.Nombre);
            Console.WriteLine(dos.Nombre);
            Console.WriteLine("--modificacion--");
            //podemos clonar y utlizar todos los estados de persona y cambiar el que nos interesa

            uno.Nombre = "damian";
            dos.Nombre = "julia";

            Console.WriteLine(uno.Nombre);
            Console.WriteLine(dos.Nombre);

            //podemos querer una instancia valiosa y clonarla luego
            admin.addPrototipo("nissan", new Auto("nissan sentra"));

            Console.WriteLine("--variable valiosa--");
            Auto auto = admin["nissan"] as Auto;

            Console.WriteLine(auto.Modelo);

            Console.ReadLine();
        }
    }
}
