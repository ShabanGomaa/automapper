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
            //Map from User to CustomerDAL
            CreateMap<User, CustomerDAL>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));
        }
    }
}