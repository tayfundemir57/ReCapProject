using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
                

        public List<Car> GetAll()
        {
            return _ıcarDal.GetAll();
        }


    }
}
