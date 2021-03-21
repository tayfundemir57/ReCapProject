using Core.EntityFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntitiyFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,RentCarContext>,ICustomerDal
    {

    }
}
