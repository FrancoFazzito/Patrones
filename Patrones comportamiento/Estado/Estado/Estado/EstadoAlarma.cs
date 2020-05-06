using System;

namespace Estado
{
    class EstadoAlarma : IEstado //establecemos los estados posibles en clases
    {
        private Caldera caldera;

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
                caldera.colocarEstado(caldera.Espera);
            }
        }

        public override string ToString()
        {
            return $"alarma -> temperatura {caldera.Temperatura} combustible {caldera.Combustible}";
        }
    }
}
