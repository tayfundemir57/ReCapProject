using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _ıcustomerdal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _ıcustomerdal = customerDal;
        }

      
        public IResult Add(Customer customer)
        {
            _ıcustomerdal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public IResult Delete(Customer customer)
        {
            _ıcustomerdal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);

        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Customer>>(_ıcustomerdal.GetAll(), Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_ıcustomerdal.GetAll(), Messages.CustomerListed);
        }

        public IResult Update(Customer customer)
        {
            _ıcustomerdal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
