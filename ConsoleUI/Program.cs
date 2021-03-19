using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             // CarTest();
          //  CarRental();
            RentalList();

            // ColorTest();
            // BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();
            customer.CompanyName = "Mercedes";
            customer.UserId = 2;
            var result = customerManager.Add(customer);
           
        }

        private static void CarRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental();
            rental.CarId = 1;
            rental.CustomerId = 2;
            rental.Id = 1;
            rental.RentDate = DateTime.Now;
            rental.ReturnDate = DateTime.Now;
            var result = rentalManager.Add(rental);
           


        }
        private static void RentalList()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetCarRentalDetails();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.RentalId + " / " + item.CarId + " / " +  " / " + item.RentDate + " / " + item.ReturnDate + " / " + item.BrandName + " / " + item.ColorName);
            }
        }

    }
}
