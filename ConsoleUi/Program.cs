using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car() { Id = 2, BrandId = 3, ColorId = 4, DailyPrice = 500, Description = "BMW", ModelYear = 2020 };

            //carManager.Add(car);
            foreach (var c in carManager.GetList())
            {
                Console.WriteLine(c.Description);
            }
        }
    }
}
