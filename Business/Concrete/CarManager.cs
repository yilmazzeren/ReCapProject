using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal carDal;

        public CarManager(ICarDal carDal)
        {
            this.carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 3 && car.DailyPrice>0)
            {
                carDal.Add(car);

            }
            else
            {
                Console.WriteLine("Ürün eklenmedı. Açıklama minimum 3 karakter olmalıdır");
            }
        }

        public void Delete(Car car)
        {
            carDal.Delete(car);
        }

        public List<Car> GetById(int id)
        {
            return carDal.GetList(c=>c.Id==id);
        }

        public List<Car> GetList()
        {
            return carDal.GetList();
        }

        public void Update(Car car)
        {
            carDal.Update(car);
        }
    }
}
