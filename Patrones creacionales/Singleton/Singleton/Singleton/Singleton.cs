using System;
using System.Collections.Generic;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instancia;
        private static List<object> datos;

        private Singleton() //constructor privado para que no pueda ser instanciada 
        {
            datos = new List<object>();
        }

        public static Singleton getInstance()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                Console.WriteLine("instancia creada");
            }

            return instancia;
        }

        public void AddData(object dato)
        {
            datos.Add(dato);
        }

        public void Mostrar()
        {
            foreach (var dato in datos)
            {
                Console.WriteLine(dato);
            }
        }
    }
}
