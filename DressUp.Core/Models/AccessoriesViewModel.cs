using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models
{
    public class AccessoriesViewModel
    {
        public string Name { get; set; }

        public IFormFile Image { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
