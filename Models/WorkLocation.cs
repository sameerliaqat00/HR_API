using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_API.Models
{
    public class WorkLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkLocationId { get; set; }
        public string? LocationName { get; set; }
        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        [ForeignKey("City")]
        public int? CityId { get; set; }
        public City City { get; set; }
        public string? ZipCode { get; set; }
        public bool? EnableGeoTagging { get; set; }
        public bool? EnableGeoFence { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public double? Radius { get; set; }
        public string? Address { get; set; }
        public bool? ManualMode { get; set; }
        public bool? QRCodeMode { get; set; }
        public bool? VoiceMode { get; set; }
        public bool? VideoMode { get; set; }
        public bool? FaceMode { get; set; }
    }
}
