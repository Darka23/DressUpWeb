using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models
{
    public class ShoesViewModel
    {
        public string Name { get; set; }

        public IFormFile Image { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Condition { get; set; }

        public decimal Price { get; set; }

        public string Size { get; set; }
    }
}
