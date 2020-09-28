using System;

namespace Estado
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Caldera caldera = new Caldera();

            caldera.trabajar();
            caldera.cortarFuego();
            caldera.ponerCombustible();
            caldera.forzarFuego();

            Console.WriteLine(caldera.ToString());

            Console.Read();
        }
    }

    internal class Caldera
    {
        private int temperatura;
        private int combustible;

        //representa estado actual
        private IEstado estado;

        //variable referencia a los estados
        private IEstado calentando;
        private IEstado alarma;

        public Caldera()
        {
            temperatura = 20;
            combustible = 50;

            calentando = new EstadoCalentando(this);
            alarma = new EstadoAlarma(this);

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
    }

    internal interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }

    internal class EstadoCalentando : IEstado
    {
        private readonly Caldera caldera;

        public EstadoCalentando(Caldera caldera)
        {
            this.caldera = caldera;
        }

        public void CortarFuego()
        {
            Console.WriteLine("cortamos fuego");
            //caldera.colocarEstado(caldera.Espera);
        }

        public void ForzarFuego()
        {
            Console.WriteLine("ya esta prendido el fuego");
        }

        public void PonerCombustible()
        {
            Console.WriteLine("no se puede colocar combustible mientras esta encendida");
        }

        public void Trabajar()
        {
            if (caldera.Combustible > 0)
            {
                Console.WriteLine("calentando");
                caldera.Combustible -= 3;
                caldera.Temperatura += 10;
            }

            if (caldera.Temperatura > 100)
            {
                caldera.colocarEstado(caldera.Alarma);
            }
            else if (caldera.Temperatura > 80)
            {
                //caldera.colocarEstado(caldera.Espera);
            }

            if (caldera.Combustible <= 0)
            {
                //caldera.colocarEstado(caldera.Espera);
            }
        }

        public override string ToString()
        {
            return $"calentando -> temperatura {caldera.Temperatura} combustible {caldera.Combustible}";
        }
    }

    internal class EstadoAlarma : IEstado //establecemos los estados posibles en clases
    {
        private readonly Caldera caldera;

        public EstadoAlarma(Caldera caldera)
        {
            this.caldera = caldera;
        }

        public void CortarFuego()
        {
            Console.WriteLine("no esta prendido");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("aumenta temperatura");
            caldera.Combustible -= 3;
            caldera.Temperatura += 10;
        }

        public void PonerCombustible()
        {
            Console.WriteLine("no se puede colocar combustible con temperatura alta");
        }

        public void Trabajar()
        {
            Console.WriteLine("ALARMA!!");
            caldera.Temperatura -= 5;

            if (caldera.Temperatura < 90 || caldera.Combustible <= 0)
            {
                caldera.colocarEstado(caldera.Alarma);
            }
        }

        public override string ToString()
        {
            return $"alarma -> temperatura {caldera.Temperatura} combustible {caldera.Combustible}";
        }
    }

}
