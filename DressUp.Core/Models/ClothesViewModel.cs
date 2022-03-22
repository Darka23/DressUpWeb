using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models
{
    public class ClothesViewModel
    {
        [Required]
        public string ImageUrl { get; set; }

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
        public string Category { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
