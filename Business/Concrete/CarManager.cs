using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 3 && car.DailyPrice>0)
            {
                carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);

            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);

            }
        }

        public IResult Delete(Car car)
        {
            carDal.Delete(car);
            return new Result(true,"Ürün Silindi");

        }

        public Car GetById(int id)
        {
            return carDal.GetById(c => c.Id == id);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            return carDal.GetCarDetails();
        }

        public List<Car> GetList()
        {
            return carDal.GetList();
        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new Result(true);

        }


    }
}
