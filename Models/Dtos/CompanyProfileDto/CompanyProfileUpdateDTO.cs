using System.ComponentModel.DataAnnotations;

namespace HR_API.Models.Dto.CompanyProfileDto
{
    public class CompanyProfileUpdateDTO
    {
        public int CompanyId { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        public string? CompanyLogo { get; set; }
        [Required]
        public int? CompanyTypeID { get; set; }
        public string? Website { get; set; }
        [Required]
        public string? Email { get; set; }
        public bool? AllowEmployeeLifeCycle { get; set; }
        public bool? IsCnicMandatory { get; set; }
        [Required]
        public int? SalaryMethodID { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please Enter Valid Integer Number")]
        public int? AllowedEmployee { get; set; }
        [Required]
        public DateTime AccountExpireDate { get; set; }
        public int? LoanEligibleMonth { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please Enter Valid Integer Number")]
        public int? AmountPrecision { get; set; }
        [Required]
        public string IsMinMaxTime { get; set; }
        public int? TotalWorkingDays { get; set; }
        public int? MonthDays { get; set; }
        public string? GraduityCalculateType { get; set; }
        public int? RaisedBeforeDays { get; set; }
        public int? DaysInPeriod { get; set; }
        public int? RegularizedPeriodID { get; set; }
    }
}
