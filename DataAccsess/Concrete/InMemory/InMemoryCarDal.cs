using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {

            new Car{CarId=1,BrandId=1, ColorId=10, ModelYear="2018",DailyPrice=180,Description="Renault Clio"},
            new Car { CarId = 2, BrandId = 2, ColorId = 12, ModelYear = "2020", DailyPrice = 250, Description = "Ford Focus" },
            new Car { CarId = 3, BrandId = 3, ColorId = 10, ModelYear = "2021", DailyPrice = 500, Description = "BMW 3.20i" },
            new Car { CarId = 4, BrandId = 4, ColorId = 18, ModelYear = "2019", DailyPrice = 1150, Description = "Volvo XC90" },
            new Car { CarId = 5, BrandId = 5, ColorId = 11, ModelYear = "2019", DailyPrice = 350, Description = "Opel İnsignia" },


            };


        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
