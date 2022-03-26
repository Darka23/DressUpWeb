using System.ComponentModel.DataAnnotations;

namespace DressUp.Core.Models.AddViewModels
{
    public class ColorViewModel
    {
        [Required]
        [StringLength(20,ErrorMessage = "Името на цвета е задължително и трябва да е до 20 символа")]
        public string ColorName { get; set; }
    }
}
