using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByDailyPrice(int dailyPrice);
        void Add(Car car);

        List<CarDetailDto> GetCarDetails();

       

    }
}
