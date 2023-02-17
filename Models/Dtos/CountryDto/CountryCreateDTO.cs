using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CountryCreateDTO
    {
        [Required]
        public string? CountryName { get; set; }
    }
}
