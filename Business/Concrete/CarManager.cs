using Business.Abstract;
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

      

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter içermelidir.");
            }

            else if (car.DailyPrice==0)
            {
                 Console.WriteLine("Araba fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {
                 _carDal.Add(car);
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=>c.DailyPrice>=min&&c.DailyPrice<=max);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }
    }
}
