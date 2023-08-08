using Api.Business;
using AutoMapper;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBLL>> Get()
        {
            CustomerDAL customerDAL = new CustomerDAL()
            {
                Id = 1,
                Name = "Customer 1"
            };

            CustomerBLL customerBLL = new CustomerBLL()
            {
                Id = customerDAL.Id,
                Name = customerDAL.Name
            };

            return await Task.FromResult(customerBLL);
        }

        [HttpGet("GetUsingMapper")]
        public async Task<ActionResult<CustomerBLL>> GetUsingMapper()
        {
            CustomerDAL customerDAL = new CustomerDAL()
            {
                Id = 1,
                Name = "Customer from automapper"
            };

            CustomerBLL customerBLL = _mapper.Map<CustomerBLL>(customerDAL);

            return await Task.FromResult(customerBLL);
        }
    }
}