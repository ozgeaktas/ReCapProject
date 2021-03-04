using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
       List<Car>  _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car { BrandId=1, ColorId=2, DailyPrice=15000, Description="spor araba",  Id=1, ModelYear=2 },
                new Car { BrandId=2, ColorId=2, DailyPrice=60000, Description="dağ arabası",  Id=2, ModelYear=3 },
                new Car { BrandId=3, ColorId=3, DailyPrice=70000, Description="kamyonet",  Id=3, ModelYear=4 },
                new Car { BrandId=4, ColorId=3, DailyPrice=80000, Description="aile arabası",Id=4, ModelYear=1 },
                new Car { BrandId=5, ColorId=1, DailyPrice=90000, Description="lumizin",  Id=5, ModelYear=2 },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
