using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalMenager : IRentalService
    {
        IRentalDal _ırentalDal;

        public RentalMenager(IRentalDal rentalDal)
        {
            _ırentalDal = rentalDal;

        }

        public IResult Add(Rental rental)
        {
            var results = _ırentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (results.Count > 0)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            _ırentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);


        }

            public IResult Delete(Rental rental)
        {
            _ırentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<RentalDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_ırentalDal.GetCarDetails(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetId(int Id)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r => r.Id == Id));
        }

        public IResult Update(Rental rental)
        {
            _ırentalDal.Update(rental);
            return new SuccessResult(Messages.RemtalUpdated);
        }

        
    }
}
