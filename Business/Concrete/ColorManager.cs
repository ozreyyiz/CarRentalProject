using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeletedSuccess);
        }

        public IDataResult <List<Color>> GetAll()
        {
            _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>();
          
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAddedSuccess);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdatedSucess);
        }

        public IDataResult <Color> GetById(int id)
        {
            _colorDal.Get(c => c.ColorId == id);
            return new SuccessDataResult<Color>();
        }
    }
}
