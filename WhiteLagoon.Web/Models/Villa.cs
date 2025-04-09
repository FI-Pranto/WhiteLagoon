using System.ComponentModel.DataAnnotations;

namespace WhiteLagoon.Web.Models
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public required string Name { get; set; }

        [MaxLength(200,ErrorMessage ="Can not be more than 200 character")]
        public string? Description { get; set; }

        [Required(ErrorMessage ="Price field can not be empty")]
        public double Price { get; set; }

        [Required(ErrorMessage ="Sqft must be provided")]
        public int Sqft { get; set; }
        [Required(ErrorMessage ="Provide Occupancy")]
        public int Occupancy { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get;set; }



    }
}
