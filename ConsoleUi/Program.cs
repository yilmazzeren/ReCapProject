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
            //cartest();
            //brandtest();
            //colorTest();
        }

        private static void colorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color() { Id = 2, Name = "Blue" };

            colorManager.Add(color);
            foreach (var c in colorManager.GetAllColors())
            {
                Console.WriteLine(c.Name);
            }
        }

        private static void brandtest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand = new Brand() { Id = 2, Name = "Fiat" };
            //brandManager.Add(brand);
            foreach (var b in brandManager.GetAllBrands())
            {
                Console.WriteLine(b.Id + " / " + b.Name);
            }
        }

        private static void cartest()
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
