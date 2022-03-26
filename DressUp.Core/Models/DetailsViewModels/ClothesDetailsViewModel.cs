using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models.DetailsViewModels
{
    public class ClothesDetailsViewModel
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Category { get; set; }

        public string Condition { get; set; }

        public string Material { get; set; }

        public string Description { get; set; }
    }
}
