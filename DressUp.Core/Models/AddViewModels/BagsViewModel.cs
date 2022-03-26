using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models.AddViewModels
{
    public class BagsViewModel
    {
        public string Name { get; set; }

        public IFormFile Image { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Condition { get; set; }

        public decimal Price { get; set; }

        public string Material { get; set; }

        public string Color { get; set; }

    }
}
