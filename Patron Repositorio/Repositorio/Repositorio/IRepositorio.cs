using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositorio
{
    interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Eliminar(int id);
        void Actualizar(T entidad);
        T ObtenerPorId(int id);
        List<T> Buscar(Func<T, bool> where);
        List<T> Ordenar(Func<T, object> order);
        List<T> GetAll();
    }
}
