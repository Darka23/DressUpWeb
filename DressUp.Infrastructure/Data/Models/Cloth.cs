using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Infrastructure.Data.Models
{
    public class Cloth
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(15)]
        public string Size { get; set; }

        [Required]
        [StringLength(20)]
        public string Color { get; set; }

        [Required]
        [StringLength(5)]
        public string Category { get; set; }

        [Required]
        [StringLength(30)]
        public string ClothingType { get; set; }

        [Required]
        [StringLength(30)]
        public string Condition { get; set; }

        [Required]
        [StringLength(30)]
        public string Material { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
