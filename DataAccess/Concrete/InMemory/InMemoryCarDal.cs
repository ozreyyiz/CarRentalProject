using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car { Id = 1,BrandId = 1,ColorId=1,DailyPrice=25000,ModelYear=2004,Descripion="Good Car."},
            new Car { Id = 2,BrandId = 3,ColorId=1,DailyPrice=175000,ModelYear=2019,Descripion="Well Car."},
            new Car { Id = 3,BrandId = 2,ColorId=2,DailyPrice=212000,ModelYear=2022,Descripion="Awesome Car."},
            new Car { Id = 4,BrandId = 2,ColorId=4,DailyPrice=93000,ModelYear=2014,Descripion="Beautiful Car."},
            new Car { Id = 5,BrandId = 3,ColorId=5,DailyPrice=2000,ModelYear=1985,Descripion="Like Car."},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carToDelete= _cars.SingleOrDefault(car => car.Id == id);

            _cars.Remove(carToDelete);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
           return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(car=>car.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.Descripion=car.Descripion;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
