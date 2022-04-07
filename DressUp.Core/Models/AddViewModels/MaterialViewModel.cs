using System.ComponentModel.DataAnnotations;

namespace DressUp.Core.Models.AddViewModels
{
    public class MaterialViewModel
    {
        [Required]
        public string MaterialName { get; set; }
    }
}
