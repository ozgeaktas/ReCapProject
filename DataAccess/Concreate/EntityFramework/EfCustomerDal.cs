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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MyDataBaseContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 UserId = u.Id,
                                 UserName = u.FirstName,
                                 UserLastName = u.LastName,
                                 CompanyName = c.CompanyName,
                                 CustomerId=c.UserId

                             };
               return result.ToList();

            }
        }
    }
}
