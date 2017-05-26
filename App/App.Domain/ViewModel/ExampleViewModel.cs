using System;
using System.ComponentModel.DataAnnotations;

namespace App.Business.ViewModel
{
    public class ExampleViewModel
    {
        [Key]
        public Guid ExampleId { get; set; }

        [Required(ErrorMessage = "Please, Description is required")]
        [MaxLength(ErrorMessage = "Max lenght it is 200 caracters")]
        public string Description { get; set; }
    }
}
