using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ıcarDal;

        public CarManager(ICarDal ıcarDal)
        {
            _ıcarDal = ıcarDal;
        }

        public IResult Add(Car car)
        {

            if (car.CarName.Length < 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _ıcarDal.Add(car);

            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _ıcarDal.Delete(car);
                       
            return new SuccessDataResult<Car>(Messages.CarDeleted);

        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(Messages.CarListed);
        }

        public IDataResult<Car> GetCarsByCarId(int id)
        {
            return new SuccessDataResult<Car>(_ıcarDal.Get(p => p.CarId == id));
        }

        public IResult Update(Car car)
        {
            _ıcarDal.Update(car);

            return new SuccessDataResult<Car>(Messages.CarUpdated);

        }

    }

}