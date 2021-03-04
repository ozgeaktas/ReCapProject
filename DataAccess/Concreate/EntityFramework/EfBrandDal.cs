using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var addedEntity = context.Entry(entity);//referansı yakala.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var deleteedEntity = context.Entry(entity);
                deleteedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
