using System;

namespace Estado
{
    class Caldera
    {
        private int temperatura;
        private int combustible;

        //representa estado actual
        private IEstado estado;

        //variable referencia a los estados
        private IEstado calentando;
        private IEstado alarma;
        private IEstado espera;

        public Caldera()
        {
            temperatura = 20;
            combustible = 50;

            calentando = new EstadoCalentando(this);
            alarma = new EstadoAlarma(this);
            espera = new EstadoEspera(this);

            estado = calentando; //estado default
        }

        public void colocarEstado(IEstado estado)
        {
            Console.WriteLine("---cambio de estado---");
            this.estado = estado;
        }

        public void trabajar()
        {
            estado.Trabajar();
        }

        public void cortarFuego()
        {
            estado.CortarFuego();
        }

        public void ponerCombustible()
        {
            estado.PonerCombustible();
        }

        public void forzarFuego()
        {
            estado.ForzarFuego();
        }

        public override string ToString()
        {
            return estado.ToString();
        }

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal IEstado Calentando { get => calentando; set => calentando = value; }
        internal IEstado Alarma { get => alarma; set => alarma = value; }
        internal IEstado Espera { get => espera; set => espera = value; }

        
    }
}
