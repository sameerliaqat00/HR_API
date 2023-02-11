using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class CompanyProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyLogo { get; set; }
        [ForeignKey("CompanyType")]
        public int? CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public bool? AllowEmployeeLifeCycle { get; set; }
        public bool? IsCnicMandatory { get; set; }
        [ForeignKey("SalaryMethod")]
        public int? SalaryMethodID { get; set; }
        public SalaryMethod SalaryMethod { get; set; }
        public int? AllowedEmployee { get; set; }
        public DateTime AccountExpireDate { get; set; }
        [ForeignKey("LoanEligibleMonth")]
        public int? LoanEligibleMonthId { get; set; }
        public LoanEligibleMonth LoanEligibleMonth { get; set; }
        public int? AmountPrecision { get; set; }
        public string IsMinMaxTime { get; set; }
        public int? TotalWorkingDays { get; set; }
        public int? MonthDays { get; set; }
        public string? GraduityCalculateType { get; set; }
        public int? RaisedBeforeDays { get; set; }
        public int? DaysInPeriod { get; set; }
        [ForeignKey("RegularizedPeriod")]
        public int? RegularizedPeriodID { get; set; }
        public RegularizedPeriod RegularizedPeriod { get; set; }
    }
}
