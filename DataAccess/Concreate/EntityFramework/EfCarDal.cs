using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDataBaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                var result = from c in context.Cars
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             { 
                                 Description=c.Description,                           
                                 BrandName=b.BrandName,
                                 ColorName=r.ColorName,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();
                           
            }
        }
    }
}
