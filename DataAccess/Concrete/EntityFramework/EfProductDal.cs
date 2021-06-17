using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using NorthwindContext context = new NorthwindContext();
            return filter == null
                ? context.Set<Product>().ToList()
                : context.Set<Product>().Where(filter).ToList();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using NorthwindContext context = new NorthwindContext();
            return context.Set<Product>().SingleOrDefault(filter);
        }

        public void Add(Product entity)
        {
            //IDisposeble pattern imlementation of C#
            using NorthwindContext context = new NorthwindContext();
            var addedEntity = context.Entry(entity); // referansi yakala
            addedEntity.State = EntityState.Added; // o aslinda eklenecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }

        public void Update(Product entity)
        {
            using NorthwindContext context = new NorthwindContext();
            var updatedEntity = context.Entry(entity); // referansi yakala
            updatedEntity.State = EntityState.Modified; // o aslinda guncellenecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }

        public void Delete(Product entity)
        {
            using NorthwindContext context = new NorthwindContext();
            var deletedEntity = context.Entry(entity); // referansi yakala
            deletedEntity.State = EntityState.Deleted; // o aslinda silinecek bir nesne
            context.SaveChanges(); // ve simdi ekle
        }
    }
}