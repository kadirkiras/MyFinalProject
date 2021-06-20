using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>: IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new TContext();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public void Add(TEntity entity)
        {
            //IDisposeble pattern imlementation of C#
            using TContext context = new TContext();
            var addedEntity = context.Entry(entity); // referansi yakala
            addedEntity.State = EntityState.Added; // o aslinda eklenecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }

        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            var updatedEntity = context.Entry(entity); // referansi yakala
            updatedEntity.State = EntityState.Modified; // o aslinda guncellenecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            var deletedEntity = context.Entry(entity); // referansi yakala
            deletedEntity.State = EntityState.Deleted; // o aslinda silinecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }
    }
}