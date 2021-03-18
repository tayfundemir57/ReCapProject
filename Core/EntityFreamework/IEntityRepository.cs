using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFreamework
{
    public interface IEntityRepository<T> where T : class, IEntity, new() // T yerine herşey gelebilir..
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // Ders:8 Dk:35 ,  filter=null demek filtre vermeyebilirsin demektir.

        T Get(Expression<Func<T, bool>> filter); // filtre vermelisin..

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}