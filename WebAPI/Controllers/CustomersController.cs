using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerDal;

        public CustomersController(ICustomerService customerService)
        {
            _customerDal = customerService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result= _customerDal.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer) 
        {
            var result = _customerDal.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
             return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer) 
        {
            var result=_customerDal.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer) 
        {
        var result= _customerDal.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
