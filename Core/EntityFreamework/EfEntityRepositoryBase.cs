﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Core.EntityFreamework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

        where TEntity : class, IEntity, new() // Kurallarımız..
        where TContext : DbContext, new()

    {

        public void Add(TEntity entity)
        {

            using (TContext context = new TContext()) // IDısposable pattern İmplementation of C# // Belleği hızlı temizlee
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

            }

        }

        public List<TEntity> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntitiy = context.Entry(entity);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
