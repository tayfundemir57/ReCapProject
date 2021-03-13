using Business.Concrete;
using DataAccsess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {

                Console.WriteLine("Araba Id : " + car.CarId+ "/ "+ "Renk Id : " + car.ColorId + "/ " );

            }


        }

    }
    
}
