using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        ICarService _carDal;

        public CarsController(ICarService carDal)
        {
            _carDal = carDal;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result=_carDal.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbybrandid")]

        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carDal.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbycolorid")]

        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carDal.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbydailyprice")]

        public IActionResult GetCarsByDailyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetCarsByDailyPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetail")]

        public IActionResult GetCarDetail()
        {
            var result = _carDal.GetCarDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Car car)
        {
            var result = _carDal.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(Car car)
        {
            var result = _carDal.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Car car)
        {
            var result = _carDal.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
