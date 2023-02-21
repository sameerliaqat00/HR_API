using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class SubDepartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubDepartmentId { get; set; }
        public string? SubDepartments { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

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
    }
}
