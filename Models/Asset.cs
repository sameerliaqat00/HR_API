using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class Asset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssetId { get; set; }
        public string? SerialNo { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Status")]
        public int? StatusId { get; set; }
        public Status Status { get; set; }
        [ForeignKey("AssetType")]
        public int? AssetsTypeId { get; set; }
        public AssetType AssetType { get; set; }
        public double? Price { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        public string? Description { get; set; }
        public string? Attachment { get; set; }
        [ForeignKey("CompanyProfile")]
        public int? CompanyId { get; set; }
        public CompanyProfile CompanyProfile { get; set; }
        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("AspNetUser")]
        public string CreatedBy { get; set; }
        public AspNetUser AspNetUser { get; set; }

        public DateTime CreatedDate { get; set; }
        [ForeignKey("AspNetUser1")]
        public string UpdatedBy { get; set; }
        public AspNetUser AspNetUser1 { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
