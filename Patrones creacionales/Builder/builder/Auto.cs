using System;

namespace builder
{
    class Auto //producto
    {
        private IMotor motor;
        private Icarroceria carroceria;
        private ILlantas llantas;

        public void ColocarMotor(IMotor motor)
        {
            this.motor = motor;
            Console.WriteLine($"se coloco el motor: {motor.especificaciones()}");
        }

        public void ColocarCarroceria(Icarroceria carroceria)
        {
            this.carroceria = carroceria;
            Console.WriteLine($"se coloco la carroceria: {carroceria.caracteristicas()}");
        }

        public void ColocarLlantas(ILlantas llantas)
        {
            this.llantas = llantas;
            Console.WriteLine($"se colocaron las llantas: {llantas.informacion()}");
        }

        public void MostrarAuto()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"AUTO:\ncarroceria: {carroceria.caracteristicas()} \nmotor: {motor.especificaciones()} \nllantas: {llantas.informacion()}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
