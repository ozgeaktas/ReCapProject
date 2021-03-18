using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByDailyPrice(int dailyPrice);
        IResult Add(Car car); //işlemin başarılı olup olmadığı ve işlemle ilgili bilgilendirme yapmak istiyoruz.

       IDataResult<List<CarDetailDto>> GetCarDetails();

       

    }
}
