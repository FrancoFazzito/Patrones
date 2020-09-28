using System;
using System.Collections.Generic;

namespace Comando
{
    internal partial class Program //crea separacion entre quien hace la peticion y quien la lleva a cabo
    {
        private static void Main(string[] args) //permite hacer UNDO y REDO
        {
            Auto auto = new Auto();

            ControlRemoto control = new ControlRemoto(auto);
            control.EjecutarComando(0);
            control.EjecutarComando(1);
            control.EjecutarComando(2);
            control.EjecutarComando(3);

            Console.Read();
        }

        //conductor cliente
        //control invoker
        //auto receptor

        //queremos que diferentes receptores lleven de forma diferente
    }

    internal class ControlRemoto
    {
        private readonly List<IComando> comandos;

        public ControlRemoto(Auto auto)
        {
            comandos = new List<IComando>
            {
                new ComandoApagar(auto),
                new ComandoEncender(auto),
                new ComandoApagarAlarma(auto),
                new ComandoColocarAlarma(auto)
            };
        }

        public void EjecutarComando(int indexOpcion)
        {
            comandos[indexOpcion].ejecutar();
        }
    }

    internal class ComandoApagar : IComando
    {
        private readonly Auto auto;

        public ComandoApagar(Auto auto)
        {
            this.auto = auto;
        }

        public void ejecutar()
        {
            auto.Apagar();
        }
    }

    internal class ComandoApagarAlarma : IComando
    {
        private readonly Auto auto;

        public ComandoApagarAlarma(Auto auto)
        {
            this.auto = auto;
        }

        public void ejecutar()
        {
            auto.QuitarAlarma();
        }
    }

    internal class ComandoColocarAlarma : IComando
    {
        private readonly Auto auto;

        public ComandoColocarAlarma(Auto auto)
        {
            this.auto = auto;
        }

        public void ejecutar()
        {
            auto.ColocarAlarma();
        }
    }

    internal class ComandoEncender : IComando
    {
        private readonly Auto auto;

        public ComandoEncender(Auto auto)
        {
            this.auto = auto;
        }

        public void ejecutar()
        {
            auto.Encender();
        }
    }

    internal interface IComando
    {
        void ejecutar();
    }

    internal class Auto
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("se ha prendido el auto");
        }

        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("se ha apagado el auto");
        }

        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("se ha colocado la alarma");
        }

        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("se ha quitado la alarma");
        }
    }
}
