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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalMenager rentalMenager = new RentalMenager(new EfRentalDal());

            //Core.Utilities.IResult result = CarResultAdd(carManager);
            // CarResultGetDetails(carManager);
            // CarResultDelete(carManager);
            // CarResultUpdate(carManager);
            // CarResultGetAll(carManager);

            // ColorResultAdd(colorManager);
            // ColorResultUpdate(colorManager);
            // ColorResultDelete(colorManager);
            // ColorResultGetAll(colorManager);

            // BrandResultAdd(brandManager);
            // BrandResultUpdate(brandManager);
            // BrandResultDelete(brandManager);
            // BrandResultGetAll(brandManager);


            //UserAdd(userManager);

            //CustomerAdd(customerManager);

             RentalAdd(rentalMenager);

          //  rentalMenager.Delete(new Rental { Id = 2 });



        }

        private static void RentalAdd(RentalMenager rentalMenager)
        {
            var result = rentalMenager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 01, 10, 30, 0), ReturnDate = new DateTime(2021, 02, 07, 10, 30, 0) });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAdd(CustomerManager customerManager)
        {
            var result21 = customerManager.Add(new Customer { CompanyName = "Pirelli Lastik" });
            if (result21.Success == true)
            {
                Console.WriteLine(result21.Message);
            }
        }

        private static void UserAdd(UserManager userManager)
        {
            var result20 = userManager.GetAll();

            if (result20.Success == true)
            {
                foreach (var user in result20.Data)
                {
                    Console.WriteLine("FisrtName : " + " / " + user.FirstName + " / " + "LastName : " + user.LastName + " / " + "Email : " + " / " + user.Email);
                }

            }
            else
            {
                Console.WriteLine(result20.Message);
            }
        }

        private static void BrandResultGetAll(BrandManager brandManager)
        {
            var result13 = brandManager.GetAll();
            if (result13.Success == true)
            {
                foreach (var brand in result13.Data)
                {
                    Console.WriteLine("BrandName: " + brand.BrandId + " / " + "BrandName: " + brand.BrandName);

                }
            }
            else
            {
                Console.WriteLine(result13.Message);
            }
        }

        private static void BrandResultDelete(BrandManager brandManager)
        {
            var result12 = brandManager.Delete(new Brand { BrandId = 1005 });
            if (result12.Success == true)
            {
                Console.WriteLine(result12.Message);
            }
        }

        private static void BrandResultUpdate(BrandManager brandManager)
        {
            var result11 = brandManager.Update(new Brand { BrandId = 1014, BrandName = "Opel" });
            if (result11.Success == true)
            {
                Console.WriteLine(result11.Message);
            }
        }

        private static void BrandResultAdd(BrandManager brandManager)
        {
            var result10 = brandManager.Add(new Brand { BrandName = "L200" });
            if (result10.Success == true)
            {
                Console.WriteLine(result10.Message);
            }
        }

        private static void ColorResultGetAll(ColorManager colorManager)
        {
            var result9 = colorManager.GetAll();

            if (result9.Success == true)
            {
                foreach (var Color in result9.Data)
                {
                    Console.WriteLine("ColorId : " + Color.ColorId + " / " + "ColorName : " + Color.ColorName);
                    
                }
            }
            else
            {
                Console.WriteLine(result9.Message);
            }
        }
        private static void ColorResultDelete(ColorManager colorManager)
        {
            var result8 = colorManager.Delete(new Color { ColorId = 1004 });
            if (result8.Success == true)
            {
                Console.WriteLine(result8.Message);
            }
        }

        private static void ColorResultUpdate(ColorManager colorManager)
        {
            var result7 = colorManager.Update(new Color { ColorId = 6, ColorName = "Yeşil" });

            if (result7.Success == true)
            {
                Console.WriteLine(result7.Message);
            }
        }

        private static void ColorResultAdd(ColorManager colorManager)
        {
            var result6 = colorManager.Add(new Color { ColorName = "Lacivert" });

            if (result6.Success == true)
            {
                Console.WriteLine(result6.Message);
            }
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
