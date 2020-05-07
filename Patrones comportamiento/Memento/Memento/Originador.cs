using System;

namespace Memento //se usa para salvar el estado interno de un objeto y tomarlo de manera externa
{
    [Serializable] //vamos a serializar estos objetos
    class Originador
    {
        private string nombre;
        private int modelo;
        private double costo;

        public Originador(string nombre, int modelo, double costo)
        {
            this.nombre = nombre;
            this.modelo = modelo;
            this.costo = costo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }

        public override string ToString()
        {
            return $"nombre: {nombre} modelo: {modelo} costo:{costo}";
        }

        public Memento CreaMemento()
        {
            Memento memento = new Memento();
            memento.Salvar(this);
            return memento;
        }

        public void Restaurar(Memento memento)
        {
            Originador temp = memento.Restaurar();

            nombre = temp.Nombre;
            modelo = temp.Modelo;
            costo = temp.Costo;
        }
    }
}
