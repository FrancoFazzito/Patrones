using System;

namespace Estado
{
    class EstadoCalentando : IEstado
    {
        private Caldera caldera;

        public EstadoCalentando(Caldera caldera)
        {
            this.caldera = caldera;
        }

        public void CortarFuego()
        {
            Console.WriteLine("cortamos fuego");
            caldera.colocarEstado(caldera.Espera);
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
            else if(caldera.Temperatura > 80)
            {
                caldera.colocarEstado(caldera.Espera);
            }

            if (caldera.Combustible <= 0)
            {
                caldera.colocarEstado(caldera.Espera);
            }
        }

        public override string ToString()
        {
            return $"calentando -> temperatura {caldera.Temperatura} combustible {caldera.Combustible}";
        }
    }
}
