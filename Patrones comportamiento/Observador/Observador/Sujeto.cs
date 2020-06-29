using System;
using System.Collections.Generic;

namespace Observador
{
    class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private int dato;

        public void Suscribir(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void Desuscribir(IObservador observador)
        {
            observadores.Remove(observador);
        }

        private void Notificar() //mensaje como param
        {
            foreach (var observador in observadores)
            {
                observador.Update(mensaje);
                observador.UpdatePull();
            }
        }

        public void trabajo()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                this.dato = rnd.Next(10);

                Console.WriteLine("-- nuevo estado --");
                mensaje = $"el nuevo valor es {dato}";
                Notificar();
            }  
        }

        public int Dato { get => dato; set => dato = value; }
    }
}
