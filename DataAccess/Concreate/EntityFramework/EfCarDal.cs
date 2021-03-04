﻿using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var addedEntity = context.Entry(entity);//referansı yakala.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var deleteedEntity = context.Entry(entity);
                deleteedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using(MyDataBaseContext context=new MyDataBaseContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
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
