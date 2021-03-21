﻿using Core.EntityFreamework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntitiyFramework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category, RentCarContext>,ICategoryDal
    {
        
    }
}

