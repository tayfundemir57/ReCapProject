using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetId(int Id);

        IDataResult<List<RentalDetailDto>> GetCarDetails();

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
