using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class EmployeeGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int EmployeeGradeId { get; set; }
        public string? GradeCode { get; set; }
        public string? GradeName { get; set; }
    }
}
