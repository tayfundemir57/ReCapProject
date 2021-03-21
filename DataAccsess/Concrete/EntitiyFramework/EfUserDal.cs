using Core.EntityFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntitiyFramework
{
   public class EfUserDal:EfEntityRepositoryBase<User,RentCarContext>,IUserDal
    {

    }
}
