using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CountryUpdateDTO
    {
        public int CountryId { get; set; }
        [Required]
        public string? CountryName { get; set; }
    }
}
