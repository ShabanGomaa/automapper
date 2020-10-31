using Api.Business;
using AutoMapper;
using DataAccess;

namespace Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Map from customer DAL to customer BLL Object
            CreateMap<CustomerBLL, CustomerDAL> ().ReverseMap(); 
        }
    }
}
