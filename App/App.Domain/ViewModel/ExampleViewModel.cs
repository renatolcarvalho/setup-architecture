using System;
using System.ComponentModel.DataAnnotations;

namespace App.Business.ViewModel
{
    public class ExampleViewModel
    {
        public ExampleViewModel() => ExampleId = Guid.NewGuid();

        [Key]
        public Guid ExampleId { get; set; }

        [Required(ErrorMessage = "Please, Description is required")]
        [MaxLength(200, ErrorMessage = "Max lenght it is 200 caracters")]
        public string Description { get; set; }
    }
}
