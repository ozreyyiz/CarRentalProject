using Business.Abstract;
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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate!=null)
            {
                return new ErrorResult("Araba şu anda kiralık.");
            }


            _rentalDal.Add(rental);
            return new SuccessResult("Eklendi.");
        }
    }
}
