using System;

namespace Estado
{
    class EstadoEspera : IEstado
    {
        private Caldera caldera;

        public EstadoEspera(Caldera caldera)
        {
            this.caldera = caldera;
        }

        public void CortarFuego()
        {
            Console.WriteLine("no hay fuego prendido");
        }

        public void ForzarFuego()
        {
            if (caldera.Combustible > 0)
            {
                Console.WriteLine("se ha prendido fuego de manera forzada");
                caldera.Combustible -= 3;
                caldera.Temperatura += 10;
                
                caldera.colocarEstado(caldera.Calentando);

                if (caldera.Temperatura > 100)
                {
                    caldera.colocarEstado(caldera.Alarma);
                }
            }
        }

        public void PonerCombustible()
        {
            Console.WriteLine("Colocando combustible");
            caldera.Combustible += 28;
        }

        public void Trabajar()
        {
            caldera.Temperatura -= 5;

            if (caldera.Temperatura < 60 && caldera.Combustible > 0)
            {
                caldera.colocarEstado(caldera.Calentando);
            }
        }

        public override string ToString()
        {
            return $"esperando -> temperatura {caldera.Temperatura} combustible {caldera.Combustible}";
        }
    }
}
