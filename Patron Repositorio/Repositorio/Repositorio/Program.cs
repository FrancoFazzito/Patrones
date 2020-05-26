using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioPersonas<Persona> servicio = new ServicioPersonas<Persona>();

            Persona persona = new Persona()
            {
                Id = 5,
                nacimiento = DateTime.Now,
                nombre = "franco"
            };

            servicio.Agregar(persona);

            persona.nombre = "lucas";

            servicio.Actualizar(persona);

            servicio.Eliminar(persona.Id);

            var busqueda = servicio.Buscar(x => x.Id >= 1);

            var sort = servicio.Ordenar(x => x.nombre);

            Console.ReadLine();
        }
    }
}
