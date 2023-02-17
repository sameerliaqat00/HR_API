using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CountryDTO
    {
        public int CountryId { get; set; } 
        [Required]
        public string? CountryName { get; set; }
    }
}
