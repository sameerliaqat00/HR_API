using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CityCreateDTO
    {
        [Required]
        public string? CityName { get; set; }
        [Required]
        public int? CountryId { get; set; }
    }
}
