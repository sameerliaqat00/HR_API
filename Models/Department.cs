using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        public string? Departments { get; set; }
        [ForeignKey("CompanyProfile")]
        public int CompanyId { get; set; }
        public CompanyProfile CompanyProfile { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("AspNetUser")]
        public string CreatedBy { get; set; }
        public AspNetUser AspNetUser { get; set; }

        public DateTime CreatedDate { get; set; }
        [ForeignKey("AspNetUser1")]
        public string UpdatedBy { get; set; }

        public ICollection<SubDepartment> SubDepartment { get; set; }
    }
}
