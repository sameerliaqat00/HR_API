namespace HR_API.Models.Dto
{
    public class CompanyProfileUpdateDTO
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyLogo { get; set; }
        public int? CompanyTypeID { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public bool? AllowEmployeeLifeCycle { get; set; }
        public bool? IsCnicMandatory { get; set; }
        public int? SalaryMethodID { get; set; }
        public int? AllowedEmployee { get; set; }
        public DateTime AccountExpireDate { get; set; }
        public int? LoanEligibleMonth { get; set; }
        public int? AmountPrecision { get; set; }
        public bool IsMinMaxTime { get; set; }
        public int? TotalWorkingDays { get; set; }
        public int? MonthDays { get; set; }
        public bool? GraduityCalculateType { get; set; }
        public int? RaisedBeforeDays { get; set; }
        public int? DaysInPeriod { get; set; }
        public int? RegularizedPeriodID { get; set; }
    }
}
