using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Componente<T> : IComponente<T>
    {
        public Componente(T nombre)
        {
            this.nombre = nombre;
        }


        public void Adicionar(IComponente<T> elemento)
        {
            Console.WriteLine("solo se adiciona en compuestos, no en componentes");
        }

        public IComponente<T> Buscar(T elemento)
        {
            if (elemento.Equals(nombre))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public IComponente<T> Eliminar(T elemento)
        {
            Console.WriteLine("no se puede eliminar directamente");
            return this;
        }

        public string mostrar(int profundidad)
        {
            return $"nivel de produndidad: {profundidad}";
        }

        public T nombre { get; set; }

    }
}
