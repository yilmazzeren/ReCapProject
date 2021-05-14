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
            //cardDtoTest();
            cartest();
            //brandtest();
            //colorTest();
        }

        private static void cardDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Car Name :" + item.CarName + "Color Name :" + item.ColorName + "Brand Name :" + item.BrandName);
            }
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
            //Car car = new Car() { Id = 2, BrandId = 3, ColorId = 4, DailyPrice = 500, Description = "BMW", ModelYear = 2020 };
            //Car car1 = new Car() { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 200, Description = "Ford", ModelYear = 2020 };

            //carManager.Add(car1);
            //foreach (var c in carManager.GetById(2))
            //{
            //    Console.WriteLine(c.Description);
            //}

            //Console.WriteLine(carManager.GetById(2).Description);
            var result = carManager.GetCarDetails();
            if(result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + " / " + item.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
