using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args) //pasar los atributos compartidos primero y despues los concretos
        {
            
            Console.ReadLine();
        }
    }

    public class Concesionario
    {
        Dictionary<string, IFlyweight> Diccionario = new Dictionary<string, IFlyweight>();

        public IFlyweight Vender(string marca, string modelo, string color, string patente, string titular)
        {
            string Key = marca + modelo + color;
            if (!Diccionario.ContainsKey(Key))
            {
                Diccionario.Add(Key, new Modelo(marca, modelo, color));
            }

            Modelo modeloAuto = (Modelo)Diccionario[Key];
            return new Auto(modeloAuto, patente, titular);
        }
    }

    public class Modelo : IFlyweight
    {
        public Modelo(string marca, string anio, string color)
        {
            this.Marca = marca;
            this.Anio = anio;
            this.Color = color;
        }

        public string Marca { get; }
        public string Anio { get; }
        public string Color { get; }

        public string Describir()
        {
            string mensaje = "Marca: " + Marca + Environment.NewLine;
            mensaje += "Modelo: " + Anio + Environment.NewLine;
            mensaje += "Color: " + Color + Environment.NewLine;
            return mensaje;
        }
    }

    public interface IFlyweight
    {
        string Marca { get; }
        string Anio { get; }
        string Color { get; }
        string Describir();
    }

    public class Auto : IFlyweight
    {
        private Modelo modelo;

        public Auto(Modelo modelo, string patente, string titular)
        {
            this.modelo = modelo;
            this.Patente = patente;
            this.Titular = titular;
        }

        public string Marca { get { return modelo.Marca; } }

        public string Anio { get { return modelo.Anio; } }

        public string Color { get { return modelo.Color; } }

        public string Patente { get; }

        public string Titular { get; }

        public string Describir()
        {
            return modelo.Describir() + " Dominio: " + this.Patente + " de: " + this.Titular;
        }
    }
}
