using AutoMapper;
using HR_API.Models;
using HR_API.Models.Dto.CompanyProfileDto;

namespace HR_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CompanyProfile, CompanyProfileDTO>().ReverseMap();
            CreateMap<CompanyProfile, CompanyProfileCreateDTO>().ReverseMap();
            CreateMap<CompanyProfile, CompanyProfileUpdateDTO>().ReverseMap();

            CreateMap<CompanyType, CompanyTypeDTO>().ReverseMap();
            CreateMap<CompanyType, CompanyTypeCreateDTO>().ReverseMap();
            CreateMap<CompanyType, CompanyTypeUpdateDTO>().ReverseMap();

            CreateMap<SalaryMethod, SalaryMethodDTO>().ReverseMap();
            CreateMap<SalaryMethod, SalaryMethodCreateDTO>().ReverseMap();
            CreateMap<SalaryMethod, SalaryMethodUpdateDTO>().ReverseMap();

            CreateMap<LoanEligibleMonth, LoanEligibleMonthDTO>().ReverseMap();
            CreateMap<LoanEligibleMonth, LoanEligibleMonthCreateDTO>().ReverseMap();
            CreateMap<LoanEligibleMonth, LoanEligibleMonthUpdateDTO>().ReverseMap();
           
            CreateMap<RegularizedPeriod, RegularizedPeriodDTO>().ReverseMap();
            CreateMap<RegularizedPeriod, RegularizedPeriodCreateDTO>().ReverseMap();
            CreateMap<RegularizedPeriod, RegularizedPeriodUpdateDTO>().ReverseMap();

        }
    }
}
