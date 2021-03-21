using Core.EntityFreamework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
   //public interface ICarDal
   // {
   //     List<Car> GetAll();

   //     void Add(Car car);
   //     void Update(Car car);
   //     void Delete(Car car);

   //     List<Car> GetCategory(int categoryId);

    

    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();

    }
}
