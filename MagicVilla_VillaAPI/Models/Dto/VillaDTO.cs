using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required] // Name is required
        [MaxLength(30, ErrorMessage = "Name length can't be more than 30.")]
        public string Name { get; set; }
        public int SqFt { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public string Details { get; set; }
        [Required] // Rate is required
        public double Rate { get; set; }

    }
}
