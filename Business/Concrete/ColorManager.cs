using Business.Abstract;
using DataAccsess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Utilities;
using Business.Constants;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colordal;

        public ColorManager(IColorDal ıcolordal)
        {
            _colordal = ıcolordal;
        }


        public IResult Add(Color color)
        {
            _colordal.Add(color);

            return new SuccessResult(Messages.ColorAdded);

        }

        public IResult Delete(Color color)
        {
            _colordal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }


        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour==17)
            {
                return new ErrorDataResult<List<Color>>(_colordal.GetAll(),Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Color>>(_colordal.GetAll(),Messages.ColorListed);

        }


        public IResult Update(Color color)
        {
            _colordal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}

