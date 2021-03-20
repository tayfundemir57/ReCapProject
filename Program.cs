using Business.Concrete;
using DataAccsess.Concrete.EntitiyFramework;
//using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            // Core.Utilities.IResult result = CarResultAdd(carManager);
            // CarResultGetDetails(carManager);
            // CarResultDelete(carManager);
            // CarResultUpdate(carManager);
            // CarResultGetAll(carManager);

        }

        private static void CarResultGetAll(CarManager carManager)
        {
            var result5 = carManager.GetAll();

            if (result5.Success == true)
            {
                foreach (var car in result5.Data)
                {
                    Console.WriteLine("CarName: " + car.CarName + " / " + "ModelYear : " + car.ModelYear);
                }
            }
            else
            {
                Console.WriteLine(result5.Message);
            }
        }

        private static void CarResultUpdate(CarManager carManager)
        {
            var result4 = carManager.Update(new Car { CarId = 6, BrandId = 2, CarName = "Porcshe", ColorId = 3, ModelYear = 2017, DailyPrice = 800, Description = "Kazasız, hatasız.." });

            if (result4.Success == true)
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void CarResultDelete(CarManager carManager)
        {
            var result3 = carManager.Delete(new Car { CarId = 11 });

            if (result3.Success == true)
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void CarResultGetDetails(CarManager carManager)
        {
            var result2 = carManager.GetCarDetails();

            if (result2.Success == true)
            {
                foreach (var detail in result2.Data)
                {
                    Console.WriteLine(detail.CarName + " / " + detail.BrandName);

                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static Core.Utilities.IResult CarResultAdd(CarManager carManager)
        {
            var result = carManager.Add(new Car { CarName = "Toyota", BrandId = 5, ColorId = 3, DailyPrice = 600, Description = "Hybrid", ModelYear = 2018 });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            return result;
        }

        
    }
}
