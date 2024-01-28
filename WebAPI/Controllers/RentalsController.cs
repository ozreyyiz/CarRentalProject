using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalDal;

        public RentalsController(IRentalService rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental) 
        {
        var result=_rentalDal.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
