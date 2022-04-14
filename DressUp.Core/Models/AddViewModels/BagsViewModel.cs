using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models.AddViewModels
{
    public class BagsViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        public string Color { get; set; }

    }
}
