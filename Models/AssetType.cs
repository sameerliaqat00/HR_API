﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class AssetType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssetTypeId { get; set; }
        public string? AssetTypes { get; set; }
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
        public ICollection<Asset> Asset { get; set; }

    }
}
