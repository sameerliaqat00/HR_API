using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CityUpdateDTO
    {
        public int CityId { get; set; }
        [Required]
        public string? CityName { get; set; }
        [Required]
        public int? CountryId { get; set; }
    }
}
