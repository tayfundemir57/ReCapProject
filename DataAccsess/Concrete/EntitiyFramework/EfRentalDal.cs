using Core.EntityFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccsess.Concrete.EntitiyFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,RentCarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {

                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cu in context.Customers on r.CustomerId equals cu.UserId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId



                             select new RentalDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 CustomerName = cu.CompanyName,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 Id = r.Id,
                                 UserId = r.CustomerId,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName

                             };

                return result.ToList();

            }
        }

    }
}
