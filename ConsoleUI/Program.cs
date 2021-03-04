using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
           


            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c);
            }
            
            
        }

        
    }
}
