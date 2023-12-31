using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;
      

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

      

        public IDataResult <List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(_carDal.GetAll(),Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.NameLengthError);  
            }

            else if (car.DailyPrice==0)
            {
                return new ErrorResult(Messages.MinPriceError);

            }
            else
            {
                 _carDal.Add(car);
                return new SuccessResult(Messages.CarAddSuccess);
            }
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdatedSuccess);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeletedSuccess);
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.DailyPrice>=min && p.DailyPrice<=max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }
    }
}
