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
        public async Task<ActionResult<User>> Get()
        {
            CustomerDAL customerDAL = new CustomerDAL()
            {
                Id = 1,
                Name = "Customer 1"
            };

            User user = _mapper.Map<User>(customerDAL);

            return await Task.FromResult(user);
        }

        [HttpGet("GetUsingMapper")]
        public async Task<ActionResult<User>> GetUsingMapper()
        {
            CustomerDAL customerDAL = new CustomerDAL()
            {
                Id = 1,
                Name = "Customer from automapper"
            };

            User user = _mapper.Map<User>(customerDAL);

            return await Task.FromResult(user);
        }
    }
}