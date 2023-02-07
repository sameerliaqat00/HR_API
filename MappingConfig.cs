using AutoMapper;
using HR_API.Models;
using HR_API.Models.Dto;

namespace HR_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig() {
            CreateMap<CompanyProfile, CompanyProfileDTO>().ReverseMap();
            CreateMap<CompanyProfile, CompanyProfileCreateDTO>().ReverseMap();
            CreateMap<CompanyProfile, CompanyProfileUpdateDTO>().ReverseMap();
        }
    }
}
