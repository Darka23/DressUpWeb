using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Infrastructure.Data.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MaterialName { get; set; }
    }
}
