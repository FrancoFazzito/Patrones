using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 4;

            IOperacion operacion = new Suma(); //instanciamos la estrategia a utlilizar 

            double result = operacion.calcular(num1, num2);

            Console.WriteLine(result);

            Console.Read();
        }
    }

    interface IOperacion //interfaz compartida por las estrategia
    {
        double calcular(double numero1, double numero2); //operacion comun a los algoritmos
    }

    class Suma : IOperacion //implementacion de la estrategia
    {
        public double calcular(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
    }

    class Resta : IOperacion //implementacion de la estrategia
    {
        public double calcular(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
    }
}
