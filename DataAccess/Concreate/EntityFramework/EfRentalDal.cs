using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDataBaseContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails()
        {
            using(MyDataBaseContext context=new MyDataBaseContext())
            {
                var result = from rnt in context.Rentals
                             join cus in context.Customers
                             on rnt.CustomerId equals cus.UserId
                             join cr in context.Cars
                             on rnt.CarId equals cr.Id
                             join clr in context.Colors
                             on cr.ColorId equals clr.ColorId
                             join brd in context.Brands
                             on cr.BrandId equals brd.BrandId
                             select new CarRentalDetailDto
                             {
                                 CarId=cr.Id,
                                 ColorName=clr.ColorName,
                                 BrandName=brd.BrandName,
                                 RentDate=rnt.RentDate,
                                 RentalId=rnt.Id,
                                 ReturnDate=rnt.ReturnDate,
                             };
                return result.ToList();

            }
        }
    }
}
