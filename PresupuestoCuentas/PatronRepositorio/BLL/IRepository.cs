using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace PresupuestoCuentas.BLL
{
   public interface  IRepository<T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
        T Buscar(int Id);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int Id);
    }
}
