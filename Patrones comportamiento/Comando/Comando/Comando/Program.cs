using System;
using System.Collections.Generic;

namespace Comando
{
    partial class Program //crea separacion entre quien hace la peticion y quien la lleva a cabo
    {
        static void Main(string[] args) //permite hacer UNDO y REDO
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

    class ControlRemoto
    {
        private List<IComando> comandos;

        public ControlRemoto(Auto auto)
        {
            comandos = new List<IComando>();
            comandos.Add(new ComandoApagar(auto));
            comandos.Add(new ComandoEncender(auto));
            comandos.Add(new ComandoApagarAlarma(auto));
            comandos.Add(new ComandoColocarAlarma(auto));
        }

        public void EjecutarComando(int indexOpcion)
        {
            comandos[indexOpcion].ejecutar();
        }
    }
}
