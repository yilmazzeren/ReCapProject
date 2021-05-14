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
            return new Result(true,Messages.CarDeleted);

        }

        public IDataResult<Car>GetById(int id)
        {
            return new SuccessDataResult<Car>(carDal.GetById(c => c.Id == id));

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetList()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(carDal.GetList(),Messages.ProductsListed);
        }

        public IResult Update(Car car)
        {
            carDal.Update(car);
            return new Result(true,Messages.CarUpdated);

        }


    }
}
