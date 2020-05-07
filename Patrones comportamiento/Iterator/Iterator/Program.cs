using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program //provee un mecanismo para acceder a los elementos de una coleccion de forma secuencial
    {
        static void Main(string[] args)
        {
            Contenedor contenedor = new Contenedor();

            foreach (var valor in contenedor)
            {
                Console.WriteLine(valor);
            }

            Console.Read();
        }
    }

    class Contenedor : IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedor()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = i * i;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ContenedorEnum(valores);
        }
    }

    class ContenedorEnum : IEnumerator
    {
        private int[] valores;
        private int posicion = -1;

        public ContenedorEnum(int[] valores)
        {
            this.valores = valores;
        }

        public object Current => valores[posicion];

        public bool MoveNext()
        {
            posicion++;

            if (posicion < valores.Length) //logica de pasar al siguiente elemento
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
