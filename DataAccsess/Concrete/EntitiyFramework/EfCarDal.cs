using Core.EntityFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {

                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { CarName = c.CarName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, ColorName = co.ColorName };

                return result.ToList();

            }
        }
    }


}
