using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Infrastructure.Data.Models
{
    public class Bag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        public string Material { get; set; }

        [Required]
        [StringLength(30)]
        public string Color { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
