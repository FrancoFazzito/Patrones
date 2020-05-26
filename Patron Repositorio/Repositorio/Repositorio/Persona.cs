using System;

namespace Repositorio
{
    public class Persona : IEntidad
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public DateTime nacimiento { get; set; }

        public override string ToString()
        {
            return $"{Id} {nombre} {nacimiento}";
        }
    }
}
