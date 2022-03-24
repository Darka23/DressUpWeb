using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Infrastructure.Data.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        public string Condition { get; set; }

        [Required]
        [StringLength(5)]
        public string Category { get; set; }

        [Required]
        [StringLength(5)]
        public string Size { get; set; }

        [StringLength(250)]
        public string Description { get; set; }


    }
}
