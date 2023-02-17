using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CityDTO
    {
        public int CityId { get; set; }
        [Required]
        public string? CityName { get; set; }
        [Required]
        public int? CountryId { get; set; }
    }
}
