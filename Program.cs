using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
  public  class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Id: " + car.CarId + " / " + "Marka Id: " + car.BrandId + " / " + "Renk Id: " + car.ColorId +
                     " / " + "Model Yılı: " + car.ModelYear + " / " + "Günlük Ücret: " + car.DailyPrice + " / " + "Açıklama: " + car.Description);
            }


        }
    }
}
