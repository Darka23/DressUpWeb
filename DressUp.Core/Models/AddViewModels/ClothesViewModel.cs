using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DressUp.Core.Models.AddViewModels
{
    public class ClothesViewModel
    {
        [Required]
        public IFormFile Image { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public string ClothingType { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Material { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
