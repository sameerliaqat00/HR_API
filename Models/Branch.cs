using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        [ForeignKey("CompanyProfile")]
        public int? CompanyId { get; set; }
        public CompanyProfile CompanyProfile { get; set; }

        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<AssetType> AssetType { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Designation> Designation { get; set; }
        public virtual ICollection<SubDepartment> SubDepartment { get; set; }
        public virtual ICollection<WorkLocation> WorkLocation { get; set; }

    }
}
