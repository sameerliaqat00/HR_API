using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class AssetType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssetTypeId { get; set; }
        public string? AssetTypes { get; set; }
        public ICollection<Asset> Asset { get; set; }
    }
}
