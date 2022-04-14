using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models.EditViewModels
{
    public class ClothesEditViewModel
    {
        public int Id { get; set; }

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
