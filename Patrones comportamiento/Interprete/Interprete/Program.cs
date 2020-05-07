using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete
{
    class Program //interpreta una instruccion escrita en un lenguaje con una fin especifico
    {
        static void Main(string[] args)
        {
            string expresion = "hola";
            Contexto contexto = new Contexto(expresion);

            List<Expresion> expresions = new List<Expresion>();
            expresions.Add(new ExpresionReverse());

            foreach (var exp in expresions)
            {
                exp.Interpretar(contexto);
            }

            Console.WriteLine("la palabra al reves es: {0}",contexto.Expresion);

            Console.Read();
        }
    }
    class Contexto
    {
        private string expresion;
        private int valor;

        public Contexto(string expresion)
        {
            this.expresion = expresion;
            Console.WriteLine("se evaluara {0}",expresion);
        }

        public string Expresion { get => expresion; set => expresion = value; }
        public int Valor { get => valor; set => valor = value; }
    }

    abstract class Expresion
    {
        protected Contexto contexto;

        public void Interpretar(Contexto contexto)
        {
            this.contexto = contexto;
            if (contexto.Expresion.Length == 0)
            {
                return;
            }
            else
            {
                this.contexto.Expresion = AlReves();
            }
        }

        public abstract string AlReves();
    }

    class ExpresionReverse : Expresion
    {
        public override string AlReves()
        {
            string frase = contexto.Expresion;
            string invertida = "";
            int posicion = 0;

            posicion = frase.Length;
            while (posicion > 0)
            {
                // en cada ciclo del bucle obtenemos una letra empezando por el
                // final para invertir la cadena.
                invertida = invertida + Mid(frase, posicion - 1, 1);
                posicion = posicion - 1;
            }

            return invertida;
        }

        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
    }
}
